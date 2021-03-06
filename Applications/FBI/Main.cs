﻿/*
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
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using FBI.Framework.Irc;
using FBI.Framework;
using FBI.Framework.Config;
using FBI.Framework.Extensions;
using FBI.Framework.Localization;

namespace FBI
{
	/// <summary>
	///     Main class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     LocalizationConsole segítségével állíthatók be a konzol nyelvi tulajdonságai.
		/// </summary>
		private static readonly LocalizationConsole sLConsole = Singleton<LocalizationConsole>.Instance;
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     A hibákat lehet feljegyezni egy olyan fájlba melyből az infórmációk alapján feldolgozhatók a hibák. Főként Visual Studioval lehet használni.
		/// </summary>
		private static readonly CrashDumper sCrashDumper = Singleton<CrashDumper>.Instance;
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     Utilities sokféle függvényt tartalmaz melyek hasznosak lehetnek.
		/// </summary>
		private static readonly Utilities sUtilities = Singleton<Utilities>.Instance;
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     Futással kapcsolatos információkat táról.
		/// </summary>
		private static readonly Runtime sRuntime = Singleton<Runtime>.Instance;
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     Csak windows alatt müködő függvények.
		/// </summary>
		private static readonly Windows sWindows = Singleton<Windows>.Instance;
		private static readonly IrcBase sIrcBase = Singleton<IrcBase>.Instance;
		/// <summary>
		///     Hozzáférést biztosít singleton-on keresztül a megadott class-hoz.
		///     Csak linux alatt müködő függvények.
		/// </summary>
		private static readonly Linux sLinux = Singleton<Linux>.Instance;

		/// <summary>
		///     A Main függvény. Itt indul el a program.
		/// </summary>
		/// <remarks>
		///     FBI2 IRC bot
		///     <para>
		///         Készítette Megaxxx és Jackneill.
		///     </para>
		/// </remarks>
		private static void Main(string[] args)
		{
			sRuntime.SetProcessName("FBI");
			string configdir = "Configs";
			string configfile = "FBI.yml";
			string console_encoding = "utf-8";
			string localization = "start";
			bool serverenabled = false;
			int serverport = -1;
			string serverpassword = "0";
			bool colorbindmode = false;
			System.Console.BackgroundColor = ConsoleColor.Black;
			System.Console.ForegroundColor = ConsoleColor.Gray;

			for(int i = 0; i < args.Length; i++)
			{
				string arg = args[i];

				if(arg == "-h" || arg == "--help")
				{
					Help();
					return;
				}
				else if(arg.Contains("--config-dir="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						configdir = arg.Substring(arg.IndexOf("=")+1);

					continue;
				}
				else if(arg.Contains("--config-file="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						configfile = arg.Substring(arg.IndexOf("=")+1);

					continue;
				}
				else if(arg.Contains("--console-encoding="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						console_encoding = arg.Substring(arg.IndexOf("=")+1);

					continue;
				}
				else if(arg.Contains("--console-localization="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						localization = arg.Substring(arg.IndexOf("=")+1);

					continue;
				}
				else if(arg.Contains("--server-enabled="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						serverenabled = Convert.ToBoolean(arg.Substring(arg.IndexOf("=")+1));

					continue;
				}
				else if(arg.Contains("--server-port="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						serverport = Convert.ToInt32(arg.Substring(arg.IndexOf("=")+1));

					continue;
				}
				else if(arg.Contains("--server-password="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						serverpassword = arg.Substring(arg.IndexOf("=")+1);

					continue;
				}
				else if(arg.Contains("--colorbind-mode="))
				{
					if(arg.Substring(arg.IndexOf("=")+1) != string.Empty)
						colorbindmode = Convert.ToBoolean(arg.Substring(arg.IndexOf("=")+1));

					continue;
				}
			}

			if(!console_encoding.IsNumber())
				System.Console.OutputEncoding = Encoding.GetEncoding(console_encoding);
			else
				System.Console.OutputEncoding = Encoding.GetEncoding(Convert.ToInt32(console_encoding));

			sLConsole.Locale = localization;
			System.Console.Title = FBIBase.Title;

			if(colorbindmode)
				System.Console.ForegroundColor = ConsoleColor.Gray;
			else
				System.Console.ForegroundColor = ConsoleColor.Blue;

			System.Console.WriteLine("[FBI]");
			System.Console.WriteLine(sLConsole.MainText("StartText"));
			System.Console.WriteLine(sLConsole.MainText("StartText2"), sUtilities.GetVersion());
			System.Console.WriteLine(sLConsole.MainText("StartText2-2"), Consts.FBIWebsite);
			System.Console.WriteLine(sLConsole.MainText("StartText2-3"), Consts.FBIProgrammedBy);
			System.Console.WriteLine(sLConsole.MainText("StartText2-4"), Consts.FBIDevelopers);
			System.Console.WriteLine("================================================================================"); // 80
			System.Console.ForegroundColor = ConsoleColor.Gray;
			System.Console.WriteLine();

			new Config(configdir, configfile, colorbindmode);
			sUtilities.CreatePidFile(FBIConfig.ConfigFile);

			if(localization == "start")
				sLConsole.Locale = LocalizationConfig.Locale;
			else if(localization != "start")
				sLConsole.Locale = localization;

			if(sUtilities.GetPlatformType() == PlatformType.Windows && console_encoding == "utf-8" &&
			   CultureInfo.CurrentCulture.Name == "hu-HU" && sLConsole.Locale == "huHU")
				System.Console.OutputEncoding = Encoding.GetEncoding(852);

			new ServerConfig(serverenabled ? serverenabled : ServerConfig.Enabled,
				serverport != -1 ? serverport : ServerConfig.Port, serverpassword != "0" ? serverpassword : ServerConfig.Password);

			System.Console.WriteLine();
			Log.Notice("Main", sLConsole.MainText("StartText3"));

			if(colorbindmode)
				Log.Notice("Main", sLConsole.MainText("StartText6"));

			if(sUtilities.GetPlatformType() == PlatformType.Windows)
				sWindows.Init();
			else if(sUtilities.GetPlatformType() == PlatformType.Linux)
				sLinux.Init();

			AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
			{
				Log.LargeError(sLConsole.Exception("FatalError"));
				Log.Error("Main", sLConsole.MainText("StartText4"), eventArgs.ExceptionObject as Exception);
				sCrashDumper.CreateCrashDump(eventArgs.ExceptionObject);
				Shutdown("Crash.", true);
			};

			new FBIBot();
		}

		/// <summary>
		///     Segítséget nyújt a kapcsolokhoz.
		/// </summary>
		private static void Help()
		{
			System.Console.WriteLine("[FBI] Version: {0}", sUtilities.GetVersion());
			System.Console.WriteLine("Options:");
			System.Console.WriteLine("\t-h, --help\t\t\tShow help");
			System.Console.WriteLine("\t--config-dir=<dir>\t\tSet up the config folder's path and 'name");
			System.Console.WriteLine("\t--config-file=<file>\t\tSet up the config file's place");
			System.Console.WriteLine("\t--console-encoding=Value\tSet up the program's character encoding");
			System.Console.WriteLine("\t--console-localization=Value\tSet up the program's console language settings");
			System.Console.WriteLine("\t--server-enabled=Value\t\tPremition to join the server.");
			System.Console.WriteLine("\t--server-port=<port>\t\tSet server port.");
			System.Console.WriteLine("\t--server-password=<pass>\tSet password.");
			System.Console.WriteLine("\t--server-identify=Value\t\tSet identify.");
			System.Console.WriteLine("\t--colorbind-mode=Value\t\tSet colorbind.");
		}

		public static void Shutdown(string Message, bool Crash = false)
		{
			if(!FBIBot.sFBIBase.IsNull())
			{
				bool e = false;
				foreach(var nw in sIrcBase.Networks)
				{
					if(!sIrcBase.Networks[nw.Key].IsNull() && sIrcBase.Networks[nw.Key].Online)
						e = true;
				}

				if(e)
					FBIBase.Quit();
				else
					Process.GetCurrentProcess().Kill();
			}
			else
				Process.GetCurrentProcess().Kill();

			if(Crash && FBIBase.ExitStatus)
				return;

			sIrcBase.Shutdown(Message);
		}
	}
}