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
using System.Threading;
using FBI.Irc;
using FBI.Framework;
using FBI.Framework.Config;
using FBI.Framework.Extensions;
using FBI.Framework.Localization;
using FBI.Console.Commands;

namespace FBI.Console
{
	/// <summary>
	///     Console class.
	/// </summary>
	sealed class Console
	{
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     LocalizationConsole segítségével állíthatók be a konzol nyelvi tulajdonságai.
		/// </summary>
		private readonly LocalizationConsole sLConsole = Singleton<LocalizationConsole>.Instance;
		private readonly IrcBase sIrcBase = Singleton<IrcBase>.Instance;
		/// <summary>
		///     ConsoleCommandManager class elérését tárolja.
		/// </summary>
		private readonly CCommandManager CCManager;

		/// <summary>
		///     Indulási függvény.
		/// </summary>
		public Console(string ServerName)
		{
			Log.Notice("Console", sLConsole.Console("Text"));
			Log.Debug("Console", sLConsole.Console("Text2"));
			var thread = new Thread(() => ConsoleRead());
			thread.Name = "FBI Console Thread";
			thread.Start();
			CCManager = new CCommandManager();
			CCManager.ServerName = ServerName;
			CCManager.Channel = "#fbi";
			System.Console.Title = FBIBase.Title + " || Console Writing Channel: " + CCManager.ServerName + FBIBase.Colon + CCManager.Channel;
		}

		/// <summary>
		///     Destruktor.
		/// </summary>
		/// <remarks>
		///     Ha ez lefut, akkor a class leáll.
		/// </remarks>
		~Console()
		{
			Log.Debug("Console", "~Console()");
		}

		/// <summary>
		///     Console-ba beírt parancsot hajtja végre.
		/// </summary>
		/// <remarks>
		///     Ha a Console-ba beírt szöveg egy parancs, akkor ez a
		///     függvény hajtja végre.
		/// </remarks>
		private void ConsoleRead()
		{
			try
			{
				string message;
				Log.Notice("Console", sLConsole.Console("Text3"));

				while(true)
				{
					message = System.Console.ReadLine();
					if(message.IsNull() || CCManager.CIncomingInfo(message))
						continue;

					sIrcBase.Networks[CCManager.ServerName].sSendMessage.SendCMPrivmsg(CCManager.Channel, message);
					Thread.Sleep(1000);
				}
			}
			catch(Exception e)
			{
				Log.Error("ConsoleRead", sLConsole.Exception("Error"), e.Message);
				Thread.Sleep(1000);

				if(!FBIBase.ExitStatus)
					ConsoleRead();
			}
		}
	}
}