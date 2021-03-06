/*
 * This file is part of FBI.
 * 
 * Copyright (C) 2010-2012 Twl
 * Copyright (C) 2010-2012 Megax <http://www.megaxx.info/>
 * 
 * FBI is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * FBI is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with FBI.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using FBI.Framework;
using FBI.Framework.Config;
using FBI.Framework.Network;
using FBI.Framework.Extensions;
using FBI.Framework.Localization;

namespace FBI.Client
{
	/// <summary>
	/// Listener used inside the Alaris bot to get and handle ACS responses.
	/// </summary>
	sealed class ClientSocket : IDisposable
	{
		private readonly ClientPacketHandler sClientPacketHandler = Singleton<ClientPacketHandler>.Instance;
		private readonly Utilities sUtilities = Singleton<Utilities>.Instance;
		private static NetworkStream stream;
		private static TcpClient client;
		private string _password;
		private bool isclose;

		/// <summary>
		/// Initializes a new instance of the <see cref="Alaris.Core.ClientListener"/> class.
		/// </summary>
		/// <param name='port'>
		/// Port to listen on.
		/// </param>
		public ClientSocket(string host, int port, string password)
		{
			isclose = false;
			_password = password;
			client = new TcpClient();
			client.Connect(host, port);
			sClientPacketHandler.Init();
		}

		/// <summary>
		/// Start listening.
		/// </summary>
		public void Socket()
		{
			//Log.Notice("ClientSocket", sLConsole.ClientSocket("Text"));
			//Log.Notice("ClientSocket", sLConsole.ClientSocket("Text2"), client.Client.RemoteEndPoint);
			var client_thread = new Thread(new ParameterizedThreadStart(ClientHandler));
			client_thread.Start(client);
			Thread.Sleep(50);

			var packet = new FBIPacket();
			packet.Write<int>((int)Opcode.CMSG_REQUEST_AUTH);
			packet.Write<string>(FBIBase.GetGuid().ToString());
			packet.Write<string>(sUtilities.Md5(_password));
			SendPacketToSCS(packet);
		}
		
		/// <summary>
		/// Client handler procedure.
		/// </summary>
		/// <param name='ob'>
		/// The object passed with ParameterizedThreadStart (a TcpClient)
		/// </param>
		public void ClientHandler(object ob)
		{
			client = (ob as TcpClient);
			stream = client.GetStream();
			byte[] message_buffer = new byte[262144];
			int bytes_read;
			//Log.Notice("ClientHandler", sLConsole.ClientSocket("Text3"));

			while(!isclose)
			{
				bytes_read = 0;

				// read
				if(stream.DataAvailable && stream.CanRead)
				{
					//Log.Debug("ClientHandler", sLConsole.ClientSocket("Text4"));
					bytes_read = stream.Read(message_buffer, 0, message_buffer.Length);

					if(bytes_read == 0)
					{
						//Log.Warning("ClientHandler", sLConsole.ClientSocket("Text5"));
						break;
					}

					var encoding = new UTF8Encoding();
					var msg = encoding.GetString(message_buffer, 0, bytes_read);
					var packet = new FBIPacket(msg);
					sClientPacketHandler.HandlePacket(packet, client);
				}

				Thread.Sleep(100);
			}

			//Log.Warning("ClientHandler", sLConsole.ClientSocket("Text6"));
			Environment.Exit(1);
		}

		public void Close()
		{
			isclose = true;

			if(!client.IsNull())
				client.Close();
		}

		public void Dispose()
		{
			if(!client.IsNull())
				client.Close();

			if(!stream.IsNull())
				stream.Dispose();
		}

		/// <summary>
		/// Sends the packet to SCS.
		/// </summary>
		/// <param name='packet'>
		/// Packet.
		/// </param>
		public static void SendPacketToSCS(FBIPacket packet)
		{
			try
			{
				if(client.Connected)
				{
					//Log.Debug("FBIServer", sLConsole.ClientSocket("Text7"));
					var encoder = new UTF8Encoding();
					byte[] buffer = encoder.GetBytes(packet.GetNetMessage());
					stream.Write(buffer, 0, buffer.Length);
					stream.Flush();
					//Log.Debug("FBIServer", sLConsole.ClientSocket("Text8"));
				}
			}
			catch
			{
				//Log.Error("FBIServer", sLConsole.ClientSocket("Text9"));
			}
		}
	}
}