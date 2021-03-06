/*
 * This file is part of FBI.
 * 
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
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using FBI.Framework;
using FBI.Framework.Irc;
using FBI.Framework.Config;
using FBI.Framework.Functions;
using FBI.Framework.Extensions;
using FBI.Framework.Localization;

namespace FBI.Framework.Irc
{
	public abstract partial class MessageHandler
	{
		protected readonly LocalizationConsole sLConsole = Singleton<LocalizationConsole>.Instance;
		protected readonly Utilities sUtilities = Singleton<Utilities>.Instance;
		public ChannelInfo sChannelInfo { get; private set; }
		public SendMessage sSendMessage { get; private set; }
		public NickInfo sNickInfo { get; private set; }
		public Sender sSender { get; private set; }
		private readonly object WriteLock = new object();
		private string _servername;
		public bool IsAllJoin;
		public bool Online;

		protected MessageHandler(string ServerName)
		{
			_servername = ServerName;
		}

		public void InitializeMessageHandler()
		{
			sSendMessage = new SendMessage(_servername);
			sSender = new Sender(_servername);
			sNickInfo = new NickInfo(_servername);
			sChannelInfo = new ChannelInfo(_servername);
		}

		protected void HandleSuccessfulAuth(IRCMessage sIRCMessage)
		{
			Console.WriteLine();
			Log.Success("MessageHandler", sLConsole.MessageHandler("Text"));
			Task.Factory.StartNew(() => IsJoin());

			if(ServerList.List[sIRCMessage.ServerName].UseNickServ())
			{
				if(sNickInfo.IsNickStorage())
					sNickInfo.Identify(ServerList.List[sIRCMessage.ServerName].NickServPassword());
			}

			if(ServerList.List[sIRCMessage.ServerName].UseHostServ())
			{
				if(sNickInfo.IsNickStorage())
					sNickInfo.Vhost(FBIBase.On);
				else
				{
					if(!Online)
					{
						Log.Notice("HostServ", sLConsole.HostServ("Text2"));
						sChannelInfo.JoinChannel();
						Online = true;
					}
				}
			}
			else
			{
				if(!Online)
				{
					if(ServerList.List[sIRCMessage.ServerName].HostServEnabled())
						sNickInfo.Vhost(FBIBase.Off);

					sChannelInfo.JoinChannel();
					Online = true;
				}
			}

			FBIBase.UrlTitleEnabled = true;
		}

		protected void HandleWaitingForConnection(IRCMessage sIRCMessage)
		{
			Log.Notice("MessageHandler", sLConsole.MessageHandler("Text2"));
		}

		protected void HandleNotRegistered(IRCMessage sIRCMessage)
		{
			Log.Notice("MessageHandler", sLConsole.MessageHandler("Text10"));
		}

		protected void HandleNoNickName(IRCMessage sIRCMessage)
		{
			Log.Warning("MessageHandler", sLConsole.MessageHandler("Text3"));
		}

		/// <summary>
		///     Ha a ConsoleLog be van kapcsolva, akkor
		///     kiírja a console-ra az IRC szerverről fogadott információkat.
		/// </summary>
		protected void HandleNotice(IRCMessage sIRCMessage)
		{
			sIRCMessage.MessageType = MessageType.Notice;

			if(ConsoleLog.CLog)
			{
				Console.ForegroundColor = ConsoleColor.Red;

				if(sIRCMessage.Nick == "NickServ" || sIRCMessage.Nick == "MemoServ" ||
					sIRCMessage.Nick == "ChanServ" || sIRCMessage.Nick == "HostServ")
					Console.Write(sLConsole.MessageHandler("Text4"));
				else
					Console.Write(string.Format("[{0}] ", sIRCMessage.Nick));

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(sIRCMessage.Args + Environment.NewLine);
				Console.ForegroundColor = ConsoleColor.Gray;
			}

			if(sIRCMessage.Nick == "NickServ")
			{
				if(sIRCMessage.Args.Contains("Password incorrect."))
				{
					sNickInfo.ChangeIdentifyStatus(true);
					Log.Error("NickServ", sLConsole.NickServ("Text2"));
					ConnectAllChannel();
				}
				else if(sIRCMessage.Args.Contains("You are already identified."))
					Log.Warning("NickServ", sLConsole.NickServ("Text3"));
				else if(sIRCMessage.Args.Contains("Password accepted - you are now recognized."))
				{
					sNickInfo.ChangeIdentifyStatus(true);
					Log.Success("NickServ", sLConsole.NickServ("Text4"));
				}

				var registered = new Regex("Nick (.+) isn't registered.");

				if(sIRCMessage.Args.Contains("Your nick isn't registered.") || (!sNickInfo.IsIdentify && registered.IsMatch(sIRCMessage.Args)))
				{
					Log.Warning("NickServ", sLConsole.NickServ("Text5"));
					sNickInfo.ChangeIdentifyStatus(true);
					ConnectAllChannel();
				}
			}

			if(sIRCMessage.Nick == "HostServ")
			{
				if(sIRCMessage.Args.Contains("You need to register before a vhost can be assigned to you."))
				{
					Log.Warning("HostServ", sLConsole.HostServ("Text3"));
					ConnectAllChannel();
				}
			}

			if(sIRCMessage.Nick == "HostServ" && ServerList.List[sIRCMessage.ServerName].UseHostServ())
			{
				if(sIRCMessage.Args.Contains("Your vhost of") && !sNickInfo.IsVhost)
				{
					ConnectAllChannel();
				}
			}
		}

		/// <summary>
		///     Válaszol, ha valaki pingeli a botot.
		/// </summary>
		protected void HandlePing(IRCMessage sIRCMessage)
		{
			sSender.Pong(sIRCMessage.Args);
		}

		/// <summary>
		///     Válaszol, ha valaki pongolja a botot.
		/// </summary>
		protected void HandlePong(IRCMessage sIRCMessage)
		{
			sSender.Pong(sIRCMessage.Args);
		}

		/// <summary>
		///     Ha ismeretlen parancs jön, akkor kiírja.
		/// </summary>
		protected void HandleUnknownCommand(IRCMessage sIRCMessage)
		{
			if(ConsoleLog.CLog)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(sLConsole.MessageHandler("Text4"));
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(sLConsole.MessageHandler("Text5"));
				Console.ForegroundColor = ConsoleColor.Gray;
			}
		}

		/// <summary>
		///     Ha a bot elsődleges nickje már használatban van, akkor
		///     átlép a másodlagosra, ha az is akkor a harmadlagosra.
		/// </summary>
		protected void HandleNickError(IRCMessage sIRCMessage)
		{
			Log.Error("MessageHandler", sLConsole.MessageHandler("Text6"), sNickInfo.NickStorage);
			string nick = sNickInfo.ChangeNick();
			Log.Notice("MessageHandler", sLConsole.MessageHandler("Text7"), nick);
			Online = false;
			sSender.Nick(nick);
		}

		/// <summary>
		///     Ha bannolva van egy szobából, akkor feljegyzi.
		/// </summary>
		protected void HandleChannelBan(IRCMessage sIRCMessage)
		{
			if(sIRCMessage.Info.Length < 4)
				return;

			FBIBase.DManager.Update("channels", string.Format("Enabled = 'false', Error = '{0}'", sLConsole.MessageHandler("Text8-1")), string.Format("Channel = '{0}' And ServerName = '{1}'", sIRCMessage.Info[3].ToLower(), sIRCMessage.ServerName));
			//sSendMessage.SendChatMessage(sIRCMessage.MessageType, ChannelPrivmsg, sLConsole.MessageHandler("Text8"), sIRCMessage.Info[3]);
		}

		/// <summary>
		///     Ha hibás egy IRC szobának a jelszava, akkor feljegyzi.
		/// </summary>
		protected void HandleNoChannelPassword(IRCMessage sIRCMessage)
		{
			if(sIRCMessage.Info.Length < 4)
				return;

			FBIBase.DManager.Update("channels", string.Format("Enabled = 'false', Error = '{0}'", sLConsole.MessageHandler("Text9-1")), string.Format("Channel = '{0}' And ServerName = '{1}'", sIRCMessage.Info[3].ToLower(), sIRCMessage.ServerName));
			//sSendMessage.SendChatMessage(sIRCMessage.MessageType, ChannelPrivmsg, sLConsole.MessageHandler("Text9"), sIRCMessage.Info[3]);
		}

		protected void HandleCannotJoinChannel(IRCMessage sIRCMessage)
		{
			if(sIRCMessage.Info.Length < 4)
				return;

			FBIBase.DManager.Update("channels", string.Format("Enabled = 'false', Error = '{0}'", sLConsole.MessageHandler("Text17-1")), string.Format("Channel = '{0}' And ServerName = '{1}'", sIRCMessage.Info[3].ToLower(), sIRCMessage.ServerName));
			//sSendMessage.SendChatMessage(sIRCMessage.MessageType, ChannelPrivmsg, sLConsole.MessageHandler("Text17"), sIRCMessage.Info[3]);
		}

		protected void HandleIrcJoin(IRCMessage sIRCMessage)
		{
			sIRCMessage.Channel = sIRCMessage.Channel.Remove(0, 1, FBIBase.Colon);
			LogToFile(sIRCMessage.Channel, sIRCMessage.Nick, sLConsole.MessageHandler("Text18"));

			if(sIRCMessage.Nick == sNickInfo.NickStorage)
			{
				if(sChannelInfo.CList.ContainsKey(sIRCMessage.Channel.ToLower()))
					FBIBase.DManager.Update("channels", "Enabled = 'true', Error = ''", string.Format("Channel = '{0}' And ServerName = '{1}'", sIRCMessage.Channel.ToLower(), sIRCMessage.ServerName));

				return;
			}
		}

		protected void HandleIrcLeft(IRCMessage sIRCMessage)
		{
			LogToFile(sIRCMessage.Channel, sIRCMessage.Nick, sLConsole.MessageHandler("Text19"), sIRCMessage.Args.Trim() == string.Empty ? string.Empty : sIRCMessage.Args);
		}

		protected void HandleIrcQuit(IRCMessage sIRCMessage)
		{
			//foreach(var chan in sChannelNameList.Names)
			//{
			//	if(chan.Value.Contains(sIRCMessage.Nick.ToLower(), FBIBase.Comma))
			//		LogToFile(chan.Key, sIRCMessage.Nick, sLConsole.MessageHandler("Text20"), sIRCMessage.Args.Trim() == string.Empty ? string.Empty : sIRCMessage.Args);
			//}
		}

		protected void HandleIrcKick(IRCMessage sIRCMessage)
		{
			if(sIRCMessage.Info.Length < 5)
				return;

			string text = sIRCMessage.Info.SplitToString(4, FBIBase.Space);
			LogToFile(sIRCMessage.Channel, sIRCMessage.Nick, sLConsole.MessageHandler("Text22"), sIRCMessage.Info[3], text.Remove(0, 1, ":"));
		}

		protected void HandleIrcMode(IRCMessage sIRCMessage)
		{
			if(sIRCMessage.Info.Length < 4)
				return;

			if(!sNickInfo.IsIdentify && sIRCMessage.Nick == "NickServ" && sIRCMessage.Channel.ToLower() == sNickInfo.NickStorage.ToLower() && sIRCMessage.Args == "+r")
			{
				sNickInfo.ChangeIdentifyStatus(true);
				Log.Success("NickServ", sLConsole.NickServ("Text4"));
			}

			LogToFile(sIRCMessage.Channel, sIRCMessage.Nick, sLConsole.MessageHandler("Text23"), sIRCMessage.Info.SplitToString(3, FBIBase.Space));
		}

		protected void HandleIrcTopic(IRCMessage sIRCMessage)
		{
			LogToFile(sIRCMessage.Channel, sIRCMessage.Nick, sLConsole.MessageHandler("Text24"), sIRCMessage.Args.Trim() == string.Empty ? string.Empty : sIRCMessage.Args);
		}

		protected void HandleIrcInvite(IRCMessage sIRCMessage)
		{
			Log.Notice("MessageHandler", sLConsole.MessageHandler("Text27"), sIRCMessage.Nick, sIRCMessage.Args);
			LogToFile(sIRCMessage.Nick, sIRCMessage.Nick, string.Format(sLConsole.MessageHandler("Text26"), sIRCMessage.Nick, sIRCMessage.Args));
		}

		/// <summary>
		///     
		/// </summary>
		/// <param name="channel"></param>
		/// <param name="user"></param>
		/// <param name="args"></param>
		private void LogToFile(string channel, string user, string args)
		{
			lock(WriteLock)
			{
				if((sChannelInfo.FSelect(IFunctions.Log) && sChannelInfo.FSelect(IChannelFunctions.Log, channel)) || !IsChannel(channel))
				{
					if(!IsChannel(channel))
					{
						if((args.Contains("admin") && args.Contains("access")) ||
						   (args.Contains("admin") && args.Contains("newpassword")) ||
						   (args.Contains("notes") && args.Contains("user") && args.Contains("access")) ||
						   (args.Contains("notes") && args.Contains("user") && args.Contains("register")) ||
						   (args.Contains("notes") && args.Contains("user") && args.Contains("remove")) ||
						   (args.Contains("notes") && args.Contains("user") && args.Contains("newpassword")))
							return;
					}

					string dir = LogConfig.IrcLogDirectory + "/" + _servername;
					sUtilities.CreateDirectory(dir);
					string logdir = sUtilities.DirectoryToSpecial(dir, channel);
					string logfile = string.Format("{0}/{1}-{2}-{3}.log", logdir, DateTime.Now.Year,
									DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString(),
									DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());

					sUtilities.CreateDirectory(logdir);
					sUtilities.CreateFile(logfile);
					var file = new StreamWriter(logfile, true) { AutoFlush = true };
					file.WriteLine("[{0}:{1}] <{2}> {3}", DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() :
					               DateTime.Now.Hour.ToString(), DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() :
					               DateTime.Now.Minute.ToString(), user, args);
					file.Close();
				}
			}
		}

		private void LogToFile(string channel, string user, string format, params object[] args)
		{
			lock(WriteLock)
			{
				LogToFile(channel, user, string.Format(format, args));
			}
		}

		private void ConnectAllChannel()
		{
			lock(WriteLock)
			{
				if(!Online)
				{
					sNickInfo.ChangeVhostStatus(true);
					sChannelInfo.JoinChannel();
					Online = true;
				}
			}
		}

		private void IsJoin()
		{
			Thread.Sleep(20*1000);
			ConnectAllChannel();
		}

		public bool IsChannel(string Name)
		{
			return (Name.Length >= 2 && Name.Trim().Length > 1 && Name.Substring(0, 1) == "#");
		}
	}
}