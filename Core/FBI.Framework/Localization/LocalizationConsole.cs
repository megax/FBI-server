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
using FBI.Framework.Config;

namespace FBI.Framework.Localization
{
	public sealed class LocalizationConsole
	{
		public string Locale { get; set; }
		private LocalizationConsole() {}

		public string MainText(string Name)
		{
			switch(Name)
			{
				case "StartText":
				{
					if(Locale == "huHU")
						return "A program leállításához használd a <Ctrl+C> vagy <quit> parancsot!";
					else if(Locale == "enUS")
						return "To shut down the program use the <Ctrl+C> or the <quit> command!";
					else
						return "To shut down the program use the <Ctrl+C> or the <quit> command!";
				}
				case "StartText2":
				{
					if(Locale == "huHU")
						return "FBI Verzió: {0}";
					else if(Locale == "enUS")
						return "FBI Version: {0}";
					else
						return "FBI Version: {0}";
				}
				case "StartText2-2":
				{
					if(Locale == "huHU")
						return "Weboldal: {0}";
					else if(Locale == "enUS")
						return "Website: {0}";
					else
						return "Website: {0}";
				}
				case "StartText2-3":
				{
					if(Locale == "huHU")
						return "Programot készítette: {0}";
					else if(Locale == "enUS")
						return "Programmed by: {0}";
					else
						return "Programmed by: {0}";
				}
				case "StartText2-4":
				{
					if(Locale == "huHU")
						return "Fejlesztők: {0}";
					else if(Locale == "enUS")
						return "Developers: {0}";
					else
						return "Developers: {0}";
				}
				case "StartText3":
				{
					if(Locale == "huHU")
						return "Rendszer indul...";
					else if(Locale == "enUS")
						return "System is starting...";
					else
						return "System is starting...";
				}
				case "StartText4":
				{
					if(Locale == "huHU")
						return "Nem kezelt kivétel keletkezett. ({0})";
					else if(Locale == "enUS")
						return "An unhandled exception has been thrown. ({0})";
					else
						return "An unhandled exception has been thrown. ({0})";
				}
				case "StartText5":
				{
					if(Locale == "huHU")
						return "CleanManager indul...";
					else if(Locale == "enUS")
						return "CleanManager is starting...";
					else
						return "CleanManager is starting...";
				}
				case "StartText6":
				{
					if(Locale == "huHU")
						return "Színvak mód be van kapcsolva!";
					else if(Locale == "enUS")
						return "Colorblind mode is on!";
					else
						return "Colorblind mode is on!";
				}
				default:
					return string.Empty;
			}
		}

		public string Exception(string Name)
		{
			switch(Name)
			{
				case "Error":
				{
					if(Locale == "huHU")
						return "Meghibásodás részletei: {0}";
					else if(Locale == "enUS")
						return "Failure details: {0}";
					else
						return "Failure details: {0}";
				}
				case "FatalError":
				{
					if(Locale == "huHU")
						return "VÉGZETES HIBA";
					else if(Locale == "enUS")
						return "FATAL ERROR";
					else
						return "FATAL ERROR";
				}
				case "MajorError":
				{
					if(Locale == "huHU")
						return "SÚLYOS HIBA";
					else if(Locale == "enUS")
						return "MAJOR ERROR";
					else
						return "MAJOR ERROR";
				}
				default:
					return string.Empty;
			}
		}

		public string Translations(string Name)
		{
			return Translations(Name, Locale);
		}

		public string Translations(string Name, string Language)
		{
			switch(Name)
			{
				case "NoFound":
				{
					if(Language == "huHU")
						return "Nem találhatóak fordítások!";
					else if(Language == "enUS")
						return "No translations found!";
					else
						return "No translations found!";
				}
				case "NoFound2":
				{
					if(Language == "huHU")
						return "Nem található néhány fordítás!";
					else if(Language == "enUS")
						return "Any translations did not find!";
					else
						return "Any translations did not find!";
				}
				default:
					return string.Empty;
			}
		}

		public string FBIBot(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "FBIBot sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started FBIBot.";
					else
						return "Successfully started FBIBot.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Network indul...";
					else if(Locale == "enUS")
						return "Network starting...";
					else
						return "Network starting...";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Console indul...";
					else if(Locale == "enUS")
						return "Console starting...";
					else
						return "Console starting...";
				}
				default:
					return string.Empty;
			}
		}

		public string Console(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Console sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the Console.";
					else
						return "Successfully started the Console.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Console parancs olvasója indul...";
					else if(Locale == "enUS")
						return "Console reader starting...";
					else
						return "Console reader starting...";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Console parancs olvasó része elindult.";
					else if(Locale == "enUS")
						return "Successfully started the Console reader.";
					else
						return "Successfully started the Console reader.";
				}
				default:
					return string.Empty;
			}
		}

		public string CCommandManager(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "CCommandManager sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the CCommandManager.";
					else
						return "Successfully started the CCommandManager.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Összes Command handler regisztrálásra került.";
					else if(Locale == "enUS")
						return "All Command Handler are registered.";
					else
						return "All Command Handler are registered.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Összes Command handler törlésre került.";
					else if(Locale == "enUS")
						return "All Command Handler were deleted.";
					else
						return "All Command Handler were deleted.";
				}
				default:
					return string.Empty;
			}
		}

		public string Log(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Indulási időpont: [{0}. {1}. {2}. {3}:{4}:{5}]\n";
					else if(Locale == "enUS")
						return "Started time: [{0}. {1}. {2}. {3}:{4}:{5}]\n";
					else
						return "Started time: [{0}. {1}. {2}. {3}:{4}:{5}]\n";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "\nIndulási időpont: [{0}. {1}. {2}. {3}:{4}:{5}]\n";
					else if(Locale == "enUS")
						return "\nStarted time: [{0}. {1}. {2}. {3}:{4}:{5}]\n";
					else
						return "\nStarted time: [{0}. {1}. {2}. {3}:{4}:{5}]\n";
				}
				default:
					return string.Empty;
			}
		}

		public string DatabaseManager(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Adatbázis betöltése elindult.";
					else if(Locale == "enUS")
						return "Started the database loading.";
					else
						return "Started the database loading.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Adatbázis fajtájának kiválasztása folyamatban.";
					else if(Locale == "enUS")
						return "Selecting the Database.";
					else
						return "Selecting the Database.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Nincs az adatbázis típusa kiválasztva!";
					else if(Locale == "enUS")
						return "Database type's is not selected!";
					else
						return "Database type's is not selected!";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Két adatbázis van kiválasztva!";
					else if(Locale == "enUS")
						return "2 Database are selected!";
					else
						return "2 Database are selected!";
				}
				default:
					return string.Empty;
			}
		}

		public string MySql(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Hiba történt az adatbázishoz való kapcsolodás során!";
					else if(Locale == "enUS")
						return "Error was handled when tried to connect to the database.";
					else
						return "Error was handled when tried to connect to the database.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "MySql adatbázishoz sikeres a kapcsolodás.";
					else if(Locale == "enUS")
						return "Successfully connected to the MySql database.";
					else
						return "Successfully connected to the MySql database.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Query hiba: {0}";
					else if(Locale == "enUS")
						return "Query error: {0}";
					else
						return "Query error: {0}";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Sql kapcsolat összeomlott.";
					else if(Locale == "enUS")
						return "Sql connection crash.";
					else
						return "Sql connection crash.";
				}
				default:
					return string.Empty;
			}
		}

		public string SQLite(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Hiba történt az adatbázishoz való kapcsolodás során!";
					else if(Locale == "enUS")
						return "Error was handled when tried to connect to the database!";
					else
						return "Error was handled when tried to connect to the database!";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "SQLite adatbázishoz sikeres a kapcsolodás.";
					else if(Locale == "enUS")
						return "Successfully connected to the SQLite database.";
					else
						return "Successfully connected to the SQLite database.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Query hiba: {0}";
					else if(Locale == "enUS")
						return "Query error: {0}";
					else
						return "Query error: {0}";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				default:
					return string.Empty;
			}
		}

		public string Utilities(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Ellenőrzése: {0}";
					else if(Locale == "enUS")
						return "Checking: {0}";
					else
						return "Checking: {0}";
				}
				default:
					return string.Empty;
			}
		}

		public string FBIBase(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Timer indul...";
					else if(Locale == "enUS")
						return "Timer is starting...";
					else
						return "Timer is starting...";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Mysql indul...";
					else if(Locale == "enUS")
						return "MySql is starting...";
					else
						return "MySql is starting...";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Az adatbázishoz sikeres a kapcsolodás.";
					else if(Locale == "enUS")
						return "Successfully connected to the database.";
					else
						return "Successfully connected to the database.";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "{0} mester csatorna frissitve lett erre: {1}";
					else if(Locale == "enUS")
						return "{0} master channel is updated to: {1}";
					else
						return "{0} master channel is updated to: {1}";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "AddonManager betöltése folyamatban...";
					else if(Locale == "enUS")
						return "AddonManager is loading...";
					else
						return "AddonManager is loading...";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "Kapcsolat kezdeményezése.";
					else if(Locale == "enUS")
						return "Initiating connection.";
					else
						return "Initiating connection.";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "A megadott mester csatorna már létezik egyszer az adatbázisban így az alapértelmezett fog lenni a neve!";
					else if(Locale == "enUS")
						return "The master channel already exist on the database, named by default!";
					else
						return "The master channel already exist on the database, named by default!";
				}
				case "Text8":
				{
					if(Locale == "huHU")
						return "CacheDB indul...";
					else if(Locale == "enUS")
						return "CacheDB is starting...";
					else
						return "CacheDB is starting...";
				}
				case "Text9":
				{
					if(Locale == "huHU")
						return "CleanManager indul...";
					else if(Locale == "enUS")
						return "CleanManager is starting...";
					else
						return "CleanManager is starting...";
				}
				default:
					return string.Empty;
			}
		}

		public string Timer(string Name)
		{
			return Timer(Name, Locale);
		}

		public string Timer(string Name, string Language)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Timer sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully loaded the Timer.";
					else
						return "Successfully loaded the Timer.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Program indulási időpontja mentésre került.";
					else if(Locale == "enUS")
						return "Successfully saved the Program's started time.";
					else
						return "Successfully saved the Program's started time.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "A program {0}ms alatt indult el.";
					else if(Locale == "enUS")
						return "The program is loaded under {0}ms.";
					else
						return "The program is loaded under {0}ms.";
				}
				case "Uptime":
				{
					if(Language == "huHU")
						return "{0} nap, {1} óra, {2} perc, {3} másodperc.";
					else if(Language == "enUS")
						return "{0} day(s), {1} hour(s), {2} min(s), {3} sec(s).";
					else
						return "{0} day(s), {1} hour(s), {2} min(s), {3} sec(s).";
				}
				default:
					return string.Empty;
			}
		}

		public string Config(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Program leállítása!";
					else if(Locale == "enUS")
						return "Program is shutting down!";
					else
						return "Program is shutting down!";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Kérlek töltsed ki a konfigot!";
					else if(Locale == "enUS")
						return "Please set up the Config file!";
					else
						return "Please set up the Config file!";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Konfig fájl betöltése.";
					else if(Locale == "enUS")
						return "Config file is loading.";
					else
						return "Config file is loading.";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Konfig adatbázis betöltve.";
					else if(Locale == "enUS")
						return "Config database is loading.";
					else
						return "Config database is loading.";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Nincs konfig fájl!";
					else if(Locale == "enUS")
						return "No such config file!";
					else
						return "No such config file!";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "Elkészítése folyamatban...";
					else if(Locale == "enUS")
						return "Preparing...";
					else
						return "Preparing...";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "Konfig fájl elkészült!";
					else if(Locale == "enUS")
						return "Config file is completed!";
					else
						return "Config file is completed!";
				}
				case "Text8":
				{
					if(Locale == "huHU")
						return "Meghibásodás az xml írása során. Részletek: {0}";
					else if(Locale == "enUS")
						return "Failure was handled during the xml writing. Details: {0}";
					else
						return "Failure was handled during the xml writing. Details: {0}";
				}
				case "Text9":
				{
					if(Locale == "huHU")
						return "FBIok indítása...";
					else if(Locale == "enUS")
						return "FBIs starting...";
					else
						return "FBIs starting...";
				}
				case "Text10":
				{
					if(Locale == "huHU")
						return "FBIok száma: {0}";
					else if(Locale == "enUS")
						return "FBIs number: {0}";
					else
						return "FBIs number: {0}";
				}
				case "Text11":
				{
					if(Locale == "huHU")
						return "Nincs betöltendő FBI!";
					else if(Locale == "enUS")
						return "There is no load of FBI!";
					else
						return "There is no load of FBI!";
				}
				case "Text12":
				{
					if(Locale == "huHU")
						return "A {0} szerver név már használva van így nem kerül betöltésre!";
					else if(Locale == "enUS")
						return "The {0} server is already in use so not loaded!";
					else
						return "The {0} server is already in use so not loaded!";
				}
				case "Text13":
				{
					if(Locale == "huHU")
						return "Meghibásodás az yml írása során. Részletek: {0}";
					else if(Locale == "enUS")
						return "Failure was handled during the yml writing. Details: {0}";
					else
						return "Failure was handled during the yml writing. Details: {0}";
				}
				default:
					return string.Empty;
			}
		}

		public string IRCConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Irc beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the Irc settings.";
					else
						return "Loaded the Irc settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string MySqlConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "MySql beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the MySql settings.";
					else
						return "Loaded the MySql settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string SQLiteConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "SQLite beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the SQLite settings.";
					else
						return "Loaded the SQLite settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string LocalizationConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Localization beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the Localization settings.";
					else
						return "Loaded the Localization settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string ShutdownConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Shutdown beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the Shutdown settings.";
					else
						return "Loaded the Shutdown settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string CrashConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Crash beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the Crash settings.";
					else
						return "Loaded the Crash settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string ServerConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Server beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the Server settings.";
					else
						return "Loaded the Server settings.";
				}
				default:
					return string.Empty;
			}
		}

		public string CleanConfig(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Clean beállításai betöltve.";
					else if(Locale == "enUS")
						return "Loaded the Clean settings.";
					else
						return "Loaded the Clean settings.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "CleanConfig sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the CleanConfig.";
					else
						return "Successfully started the CleanConfig.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Régi konfig fájlok keresése elindult.";
					else if(Locale == "enUS")
						return "Searching for old config files have been started.";
					else
						return "Searching for old config files have been started.";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Konfig mapa elérhetősége: {0}";
					else if(Locale == "enUS")
						return "Config folder's path: {0}";
					else
						return "Config folder's path: {0}";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Régi konfig fájl törölve lett: {0}";
					else if(Locale == "enUS")
						return "Old config file has been deleted: {0}";
					else
						return "Old config file has been deleted: {0}";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "Régi konfig fájlok sikeresen törölve.";
					else if(Locale == "enUS")
						return "Old config files have been deleted successfully.";
					else
						return "Old config files have been deleted successfully.";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "Nincsenek régi konfig fájlok!";
					else if(Locale == "enUS")
						return "There is not any old config files!";
					else
						return "There is not any old config files!";
				}
				default:
					return string.Empty;
			}
		}

		public string ChannelInfo(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "ChannelList: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "ChannelList: Failure request!";
					else
						return "ChannelList: Failure request!";
				}
				/*case "Text2":
				{
					if(Locale == "huHU")
						return "FSelect: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "FSelect: Failure reuqest!";
					else
						return "FSelect: Failure reuqest!";
				}*/
				case "Text3":
				{
					if(Locale == "huHU")
						return "ChannelFunctionReload: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "ChannelFunctionReload: Failre request!";
					else
						return "ChannelFunctionReload: Failre request!";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "ChannelListReload: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "ChannelListReload: Failre request!";
					else
						return "ChannelListReload: Failre request!";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Kapcsolódás a csatornákhoz...";
					else if(Locale == "enUS")
						return "Connecting to channels...";
					else
						return "Connecting to channels...";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "JoinChannel: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "JoinChannel: Failure request!";
					else
						return "JoinChannel: Failure request!";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "Sikeres kapcsolódás a csatornákhoz.";
					else if(Locale == "enUS")
						return "Successfully connected to channels.";
					else
						return "Successfully connected to channels.";
				}
				case "Text8":
				{
					if(Locale == "huHU")
						return "Néhány kapcsolódás sikertelen!";
					else if(Locale == "enUS")
						return "Some connection unsuccessful.";
					else
						return "Some connection unsuccessful.";
				}
				case "Text9":
				{
					if(Locale == "huHU")
						return "Letiltott csatornák: {0}";
					else if(Locale == "enUS")
						return "Banned channels: {0}";
					else
						return "Banned channels: {0}";
				}
				case "Text11":
				{
					if(Locale == "huHU")
						return "FunctionReload: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "FunctionReload: Failre request!";
					else
						return "FunctionReload: Failre request!";
				}
				default:
					return string.Empty;
			}
		}

		public string NickServ(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Azonosító jelszó küldése a kiszolgálónak.";
					else if(Locale == "enUS")
						return "Sending nickserv identify.";
					else
						return "Sending nickserv identify.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Azonosító jelszó hibás!";
					else if(Locale == "enUS")
						return "Bad identify password!";
					else
						return "Bad identify password!";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Azonosító már aktiválva van!";
					else if(Locale == "enUS")
						return "Already identified!";
					else
						return "Already identified!";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Azonosító jelszó elfogadva.";
					else if(Locale == "enUS")
						return "Identify password accepted!";
					else
						return "Identify password accepted!";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "A nick nincs regisztrálva!";
					else if(Locale == "enUS")
						return "Your nick isn't registered!";
					else
						return "Your nick isn't registered!";
				}
				default:
					return string.Empty;
			}
		}

		public string HostServ(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Vhost bekapcsolásra került.";
					else if(Locale == "enUS")
						return "Vhost is ON.";
					else
						return "Vhost is ON.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Vhost kikapcsolásra került.";
					else if(Locale == "enUS")
						return "Vhost is OFF.";
					else
						return "Vhost is OFF.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "A nick nincs beregisztrálva így a vhost nem került bekapcsolásra!";
					else if(Locale == "enUS")
						return "Nick isnt registered, so the vhost still off!";
					else
						return "Nick isnt registered, so the vhost still off!";
				}
				default:
					return string.Empty;
			}
		}

		public string MessageHandler(string Name)
		{
			return MessageHandler(Name, Locale);
		}

		public string MessageHandler(string Name, string Language)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Language == "huHU")
						return "Sikeres kapcsolódás az irc kiszolgálóhoz.";
					else if(Language == "enUS")
						return "Successfully connected to IRC server.";
					else
						return "Successfully connected to IRC server.";
				}
				case "Text2":
				{
					if(Language == "huHU")
						return "Várakozás a kapcsolat feldolgozására.";
					else if(Language == "enUS")
						return "Waiting for connection processing.";
					else
						return "Waiting for connection processing.";
				}
				case "Text3":
				{
					if(Language == "huHU")
						return "Nincs megadva a bot nick neve!";
					else if(Language == "enUS")
						return "No such Bot's nickname.";
					else
						return "No such Bot's nickname.";
				}
				case "Text4":
				{
					if(Language == "huHU")
						return "[SZERVER] ";
					else if(Language == "enUS")
						return "[SERVER] ";
					else
						return "[SERVER] ";
				}
				case "Text5":
				{
					if(Language == "huHU")
						return "Nem létező irc parancs\n";
					else if(Language == "enUS")
						return "No such irc command.\n";
					else
						return "No such irc command.\n";
				}
				case "Text6":
				{
					if(Language == "huHU")
						return "{0}-t már használja valaki!";
					else if(Language == "enUS")
						return "{0} already in use.";
					else
						return "{0} already in use.";
				}
				case "Text7":
				{
					if(Language == "huHU")
						return "Újra próbálom ezzel: {0}";
					else if(Language == "enUS")
						return "Retrying with: {0}";
					else
						return "Retrying with: {0}";
				}
				case "Text8":
				{
					if(Language == "huHU")
						return "Csatornára való kapcsolódás letiltva: {0}";
					else if(Language == "enUS")
						return "Banned channel: {0}";
					else
						return "Banned channel: {0}";
				}
				case "Text8-1":
				{
					if(Language == "huHU")
						return "Csatornára való kapcsolódás letiltva!";
					else if(Language == "enUS")
						return "Banned channel!";
					else
						return "Banned channel!";
				}
				case "Text9":
				{
					if(Language == "huHU")
						return "Ezen csatorna jelszava hibás: {0}";
					else if(Language == "enUS")
						return "Bad password for channel: {0}";
					else
						return "Bad password for channel: {0}";
				}
				case "Text9-1":
				{
					if(Language == "huHU")
						return "Csatorna jelszava hibás!";
					else if(Language == "enUS")
						return "Bad password for channel!";
					else
						return "Bad password for channel!";
				}
				case "Text10":
				{
					if(Language == "huHU")
						return "Nem regisztrált!";
					else if(Language == "enUS")
						return "You have not registered!";
					else
						return "You have not registered!";
				}
				case "Text11":
				{
					if(Language == "huHU")
						return "Jelenleg fent van.";
					else if(Language == "enUS")
						return "Currently online.";
					else
						return "Currently online.";
				}
				case "Text12":
				{
					if(Language == "huHU")
						return "Ez a név nincs beregisztrálva!";
					else if(Language == "enUS")
						return "This nickname isn't registered!";
					else
						return "This nickname isn't registered!";
				}
				case "Text13":
				{
					if(Language == "huHU")
						return "Nincs fent ekkortól: {0}";
					else if(Language == "enUS")
						return "Last seen time: {0}";
					else
						return "Last seen time: {0}";
				}
				case "Text14":
				{
					if(Language == "huHU")
						return "Foglalt ez a nick!";
					else if(Language == "enUS")
						return "Nickname is already in use!";
					else
						return "Nickname is already in use!";
				}
				case "Text15":
				{
					if(Language == "huHU")
						return "Hibás a megadott nick!";
					else if(Language == "enUS")
						return "Erroneous Nickname!";
					else
						return "Erroneous Nickname!";
				}
				case "Text16":
				{
					if(Language == "huHU")
						return "Nem lehet megváltoztatni a becenevet mert le van tiltva vagy moderált csatornán van fent!";
					else if(Language == "enUS")
						return "Cannot change nickname while banned or moderated on channel!";
					else
						return "Cannot change nickname while banned or moderated on channel!";
				}
				case "Text17":
				{
					if(Language == "huHU")
						return "Nem lehet csatlakozni a csatornára (+i): {0}";
					else if(Language == "enUS")
						return "Cannot join channel (+i): {0}";
					else
						return "Cannot join channel (+i): {0}";
				}
				case "Text17-1":
				{
					if(Language == "huHU")
						return "Nem lehet csatlakozni a csatornára (+i)!";
					else if(Language == "enUS")
						return "Cannot join channel (+i)!";
					else
						return "Cannot join channel (+i)!";
				}
				case "Text18":
				{
					if(Language == "huHU")
						return "[csatlakozott]";
					else if(Language == "enUS")
						return "[joined]";
					else
						return "[joined]";
				}
				case "Text19":
				{
					if(Language == "huHU")
						return "[kilépett innen (left)] {0}";
					else if(Language == "enUS")
						return "[left] {0}";
					else
						return "[left] {0}";
				}
				case "Text20":
				{
					if(Language == "huHU")
						return "[kilépett (quit)] {0}";
					else if(Language == "enUS")
						return "[quit] {0}";
					else
						return "[quit] {0}";
				}
				case "Text21":
				{
					if(Language == "huHU")
						return "[Mostantól {0}-ként ismert]";
					else if(Language == "enUS")
						return "[Is now known as {0}]";
					else
						return "[Is now known as {0}]";
				}
				case "Text22":
				{
					if(Language == "huHU")
						return "[Kirúgta a következő felhasználót: {0} oka: {1}]";
					else if(Language == "enUS")
						return "[Kicked that user: {0} reason: {1}]";
					else
						return "[Kicked that user: {0} reason: {1}]";
				}
				case "Text23":
				{
					if(Language == "huHU")
						return "[Beállítja a módot: {0}]";
					else if(Language == "enUS")
						return "[Set mode: {0}]";
					else
						return "[Set mode: {0}]";
				}
				case "Text24":
				{
					if(Language == "huHU")
						return "[Téma] Új téma: {0}";
					else if(Language == "enUS")
						return "[Topic] New topic: {0}";
					else
						return "[Topic] New topic: {0}";
				}
				case "Text25":
				{
					if(Language == "huHU")
						return "[ACTION] {0}";
					else if(Language == "enUS")
						return "[ACTION] {0}";
					else
						return "[ACTION] {0}";
				}
				case "Text26":
				{
					if(Language == "huHU")
						return "[INVITE] {0} meghívott téged a {1} szobába.";
					else if(Language == "enUS")
						return "[INVITE] {0} invites you to join {1}";
					else
						return "[INVITE] {0} invites you to join {1}";
				}
				case "Text27":
				{
					if(Language == "huHU")
						return "{0} meghívott téged a {1} szobába.";
					else if(Language == "enUS")
						return "{0} invites you to join {1}";
					else
						return "{0} invites you to join {1}";
				}
				default:
					return string.Empty;
			}
		}

		public string Network(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Network sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the Network.";
					else
						return "Successfully started the Network.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Kapcsolat létrehozása az irc szerverrel.";
					else if(Locale == "enUS")
						return "Establishing connection with irc server.";
					else
						return "Establishing connection with irc server.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Opcodes thread indul...";
					else if(Locale == "enUS")
						return "Opcodes thread started...";
					else
						return "Opcodes thread started...";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Ping thread indul...";
					else if(Locale == "enUS")
						return "Ping thread started...";
					else
						return "Ping thread started...";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Összes IRC handler regisztrálásra került.";
					else if(Locale == "enUS")
						return "All of IRC handlers are registered.";
					else
						return "All of IRC handlers are registered.";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "Kapcsolódás megindult ide: {0}";
					else if(Locale == "enUS")
						return "Connection to: {0}";
					else
						return "Connection to: {0}";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "Kapcsolat bontva.";
					else if(Locale == "enUS")
						return "Connection closed.";
					else
						return "Connection closed.";
				}
				case "Text8":
				{
					if(Locale == "huHU")
						return "Kapcsolat bontásra került.";
					else if(Locale == "enUS")
						return "Connection have been closed.";
					else
						return "Connection have been closed.";
				}
				case "Text9":
				{
					if(Locale == "huHU")
						return "Újrakapcsolódás megindult ide: {0}";
					else if(Locale == "enUS")
						return "Reconnection to: {0}";
					else
						return "Reconnection to: {0}";
				}
				case "Text10":
				{
					if(Locale == "huHU")
						return "Végzetes hiba történt a kapcsolat létrehozásánál!";
					else if(Locale == "enUS")
						return "Fatal error was happened while established the connection.";
					else
						return "Fatal error was happened while established the connection.";
				}
				case "Text11":
				{
					if(Locale == "huHU")
						return "A kapcsolat sikeresen létrejött!";
					else if(Locale == "enUS")
						return "Successfully established the connection.";
					else
						return "Successfully established the connection.";
				}
				case "Text12":
				{
					if(Locale == "huHU")
						return "Hiba történt a kapcsolat létrehozásánál!";
					else if(Locale == "enUS")
						return "Error was happened while established the connection.";
					else
						return "Error was happened while established the connection.";
				}
				case "Text13":
				{
					if(Locale == "huHU")
						return "Felhasználói információk ellettek küldve.";
					else if(Locale == "enUS")
						return "Users' datas are sent.";
					else
						return "Users' datas are sent.";
				}
				case "Text14":
				{
					if(Locale == "huHU")
						return "A szál sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started th thread.";
					else
						return "Successfully started th thread.";
				}
				case "Text15":
				{
					if(Locale == "huHU")
						return "Elindult az irc adatok fogadása.";
					else if(Locale == "enUS")
						return "Started the irc data receiving.";
					else
						return "Started the irc data receiving.";
				}
				case "Text16":
				{
					if(Locale == "huHU")
						return "Nem jön információ az irc szerver felöl!";
					else if(Locale == "enUS")
						return "Do not going data from irc server!";
					else
						return "Do not going data form irc server!";
				}
				case "Text18":
				{
					if(Locale == "huHU")
						return "Ismeretlen opcode kód: {0}";
					else if(Locale == "enUS")
						return "Received unhandled opcode: {0}";
					else
						return "Received unhandled opcode: {0}";
				}
				case "Text19":
				{
					if(Locale == "huHU")
						return "A tanúsítvány nem lett elfogadva, kivétel: {0}";
					else if(Locale == "enUS")
						return "Certificate not accepted, exception: {0}";
					else
						return "Certificate not accepted, exception: {0}";
				}
				case "Text20":
				{
					if(Locale == "huHU")
						return "A szerver neve: {0}";
					else if(Locale == "enUS")
						return "Server's name: {0}";
					else
						return "Server's name: {0}";
				}
				case "Text21":
				{
					if(Locale == "huHU")
						return "Kapcsolódás típusa: {0}";
					else if(Locale == "enUS")
						return "Connection type: {0}";
					else
						return "Connection type: {0}";
				}
				default:
					return string.Empty;
			}
		}

		public string Other(string Name)
		{
			return Other(Name, Locale);
		}

		public string Other(string Name, string Language)
		{
			switch(Name)
			{
				case "Nothing":
				{
					if(Language == "huHU")
						return "Semmi";
					else if(Language == "enUS")
						return "Nothing";
					else
						return "Nothing";
				}
				case "Nobody":
				{
					if(Language == "huHU")
						return "Senki";
					else if(Language == "enUS")
						return "Nobody";
					else
						return "Nobody";
				}
				case "Notfound":
				{
					if(Language == "huHU")
						return "Nem található!";
					else if(Language == "enUS")
						return "Not found!";
					else
						return "Not found!";
				}
				case "NoSuchFunctions":
				{
					if(Language == "huHU")
						return "Ilyen funkció nem létezik!";
					else if(Language == "enUS")
						return "No such function!";
					else
						return "No such function!";
				}
				case "NoSuchFunctions2":
				{
					if(Language == "huHU")
						return "Ilyen funkció nem létezik: {0}";
					else if(Language == "enUS")
						return "No such function: {0}";
					else
						return "No such function: {0}";
				}
				case "MessageLength":
				{
					if(Language == "huHU")
						return "Túl hosszú a szöveg!";
					else if(Language == "enUS")
						return "Text is too long!";
					else
						return "Text is too long!";
				}
				case "NoFoundHelpCommand":
				{
					if(Language == "huHU")
						return "Ilyen help parancs nem létezik vagy nincs hozzá fordítás!";
					else if(Language == "enUS")
						return "No such help command or there is no translation for it!";
					else
						return "No such help command or there is no translation for it!";
				}
				case "NoFoundHelpCommand2":
				{
					if(Language == "huHU")
						return "Ilyen help parancs nem létezik!";
					else if(Language == "enUS")
						return "No such help command!";
					else
						return "No such help command!";
				}
				case "And":
				{
					if(Language == "huHU")
						return "és";
					else if(Language == "enUS")
						return "and";
					else
						return "and";
				}
				default:
					return string.Empty;
			}
		}

		public string ServerListener(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Indul...";
					else if(Locale == "enUS")
						return "Started...";
					else
						return "Started...";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Client kapcsolódik: {0}";
					else if(Locale == "enUS")
						return "Client connection from: {0}";
					else
						return "Client connection from: {0}";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Client kezelése...";
					else if(Locale == "enUS")
						return "Handling client...";
					else
						return "Handling client...";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Rendelkezésre álló adatok olvasása.";
					else if(Locale == "enUS")
						return "Stream data available, reading.";
					else
						return "Stream data available, reading.";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Elveszett a kapcsolat!";
					else if(Locale == "enUS")
						return "Lost connection!";
					else
						return "Lost connection!";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				default:
					return string.Empty;
			}
		}

		public string ClientSocket(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Indul...";
					else if(Locale == "enUS")
						return "Started...";
					else
						return "Started...";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Client kapcsolódik: {0}";
					else if(Locale == "enUS")
						return "Client connection from: {0}";
					else
						return "Client connection from: {0}";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Client kezelése...";
					else if(Locale == "enUS")
						return "Handling client...";
					else
						return "Handling client...";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Rendelkezésre álló adatok olvasása.";
					else if(Locale == "enUS")
						return "Stream data available, reading.";
					else
						return "Stream data available, reading.";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Elveszett a kapcsolat!";
					else if(Locale == "enUS")
						return "Lost connection!";
					else
						return "Lost connection!";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "Kapcsolodva. Csomag küldése.";
					else if(Locale == "enUS")
						return "Connected. Sending packet.";
					else
						return "Connected. Sending packet.";
				}
				case "Text8":
				{
					if(Locale == "huHU")
						return "Csomag elküldve.";
					else if(Locale == "enUS")
						return "Packet sent.";
					else
						return "Packet sent.";
				}
				case "Text9":
				{
					if(Locale == "huHU")
						return "Nem sikerült elküldeni SCS csomagot!";
					else if(Locale == "enUS")
						return "Couldn't send SCS packet!";
					else
						return "Couldn't send SCS packet!";
				}
				default:
					return string.Empty;
			}
		}

		public string ServerPacketHandler(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Csomagot kapott, ID: {0} tőle: {1}";
					else if(Locale == "enUS")
						return "Got packet with ID: {0} from: {1}";
					else
						return "Got packet with ID: {0} from: {1}";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Hitelesítés sikertelen! Guid a clienttől: {0}";
					else if(Locale == "enUS")
						return "Auth unsuccessful! Guid of client: {0}";
					else
						return "Auth unsuccessful! Guid of client: {0}";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Hash volt: {0}";
					else if(Locale == "enUS")
						return "Hash was: {0}";
					else
						return "Hash was: {0}";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Vissza port: {0}";
					else if(Locale == "enUS")
						return "Back port is: {0}";
					else
						return "Back port is: {0}";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Hitelesítés sikeres. Guid a clienttől: {0}";
					else if(Locale == "enUS")
						return "Auth successful. Guid of client: {0}";
					else
						return "Auth successful. Guid of client: {0}";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "Kapcsolat bontva! Guid a clienttől: {0}";
					else if(Locale == "enUS")
						return "Connection closed! Guid of client: {0}";
					else
						return "Connection closed! Guid of client: {0}";
				}
				case "Text7":
				{
					if(Locale == "huHU")
						return "Újraindítás folyamatban...";
					else if(Locale == "enUS")
						return "Restart in progress...";
					else
						return "Restart in progress...";
				}
				default:
					return string.Empty;
			}
		}

		public string ClientPacketHandler(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Csomagot kapott, ID: {0} tőle: {1}";
					else if(Locale == "enUS")
						return "Got packet with ID: {0} from: {1}";
					else
						return "Got packet with ID: {0} from: {1}";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Hitelesítést megtagadta az SCS szerver!";
					else if(Locale == "enUS")
						return "Authentication denied to SCS server!";
					else
						return "Authentication denied to SCS server!";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Kapcsolat bontva!";
					else if(Locale == "enUS")
						return "Connection closed!";
					else
						return "Connection closed!";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Sikeresen hitelesítve az SCS szerver.";
					else if(Locale == "enUS")
						return "Successfully authed to SCS server.";
					else
						return "Successfully authed to SCS server.";
				}
				default:
					return string.Empty;
			}
		}

		public string Runtime(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Nem sikerült beállítani folyamat nevét: {0}";
					else if(Locale == "enUS")
						return "Failed to set process name: {0}";
					else
						return "Failed to set process name: {0}";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Hiba a folyamat nevének beállításában!";
					else if(Locale == "enUS")
						return "Error setting process name!";
					else
						return "Error setting process name!";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "A program több mint {0} mb-ot fogyaszt!";
					else if(Locale == "enUS")
						return "The program, more than {0} MB consumed!";
					else
						return "The program, more than {0} MB consumed!";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				default:
					return string.Empty;
			}
		}

		public string CrashDumper(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Crash dump készítése...";
					else if(Locale == "enUS")
						return "Creating crash dump...";
					else
						return "Creating crash dump...";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Nem sikerült crash dump-ot írni! ({0})";
					else if(Locale == "enUS")
						return "Failed to write crash dump! ({0})";
					else
						return "Failed to write crash dump! ({0})";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Crash dump létrehozva.";
					else if(Locale == "enUS")
						return "Crash dump created.";
					else
						return "Crash dump created.";
				}
				default:
					return string.Empty;
			}
		}

		public string FBI(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "Leállt az egyik FBI ezért újra lesz indítva.";
					else if(Locale == "enUS")
						return "One of the summix has been shuted down, it will be restarted.";
					else
						return "One of the summix has been shuted down, it will be restarted.";
				}
				default:
					return string.Empty;
			}
		}

		public string SendMessage(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "ChannelList: Hibás lekérdezés!";
					else if(Locale == "enUS")
						return "ChannelList: Failure request!";
					else
						return "ChannelList: Failure request!";
				}
				default:
					return string.Empty;
			}
		}

		public string IrcBase(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "A program leáll!";
					else if(Locale == "enUS")
						return "Program shutting down!";
					else
						return "Program shutting down!";
				}
				default:
					return string.Empty;
			}
		}

		public string Sender(string Name)
		{
			return Sender(Name, Locale);
		}

		public string Sender(string Name, string Language)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Language == "huHU")
						return "Távozom";
					else if(Language == "enUS")
						return "Leaving";
					else
						return "Leaving";
				}
				default:
					return string.Empty;
			}
		}

		public string CacheDB(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "CacheDB sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the CacheDB.";
					else
						return "Successfully started the CacheDB.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "Adatbázisból táblák betöltése a magba.";
					else if(Locale == "enUS")
						return "Load tables from the database to the core.";
					else
						return "Load tables from the database to the core.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Adatbázisból {0} tábla betöltése a magba.";
					else if(Locale == "enUS")
						return "{0} loaded to the core.";
					else
						return "{0} loaded to the core.";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Magból a táblák takarításra kerültek.";
					else if(Locale == "enUS")
						return "Tables cleared from the core.";
					else
						return "Tables cleared from the core.";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Magból törölve a {0} tábla.";
					else if(Locale == "enUS")
						return "Table {0} deleted from the core.";
					else
						return "Table {0} deleted from the core.";
				}
				default:
					return string.Empty;
			}
		}

		public string CleanManager(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "CleanManager sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the CleanManager.";
					else
						return "Successfully started the CleanManager.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "CleanConfig indul...";
					else if(Locale == "enUS")
						return "CleanConfig is starting...";
					else
						return "CleanConfig is starting...";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "CleanDatabase indul...";
					else if(Locale == "enUS")
						return "CleanDatabase is starting...";
					else
						return "CleanDatabase is starting...";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "Néhány helyen takarítás közben hiba lépett fel!";
					else if(Locale == "enUS")
						return "Some problems occured during cleanup in some place!";
					else
						return "Some problems occured during cleanup in some place!";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "Sikeresen elkészültek a takarítások.";
					else if(Locale == "enUS")
						return "Cleanups have been finished.";
					else
						return "Cleanups have been finished.";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "Nincs bekapcsolva a takarítás!";
					else if(Locale == "enUS")
						return "Cleanup is not turned on!";
					else
						return "Cleanup is not turned on!";
				}
				default:
					return string.Empty;
			}
		}

		public string CleanDatabase(string Name)
		{
			switch(Name)
			{
				case "Text":
				{
					if(Locale == "huHU")
						return "CleanDatabase sikeresen elindult.";
					else if(Locale == "enUS")
						return "Successfully started the CleanDatabase.";
					else
						return "Successfully started the CleanDatabase.";
				}
				case "Text2":
				{
					if(Locale == "huHU")
						return "A {0} tábla takarítása megkezdődött.";
					else if(Locale == "enUS")
						return "The {0} table's cleanup have been started.";
					else
						return "The {0} table's cleanup have been started.";
				}
				case "Text3":
				{
					if(Locale == "huHU")
						return "Régi szervernév ({0}) törölve lett a {1} táblából.";
					else if(Locale == "enUS")
						return "The old servername ({0}) has been deleted from the table {1}.";
					else
						return "The old servername ({0}) has been deleted from the table {1}.";
				}
				case "Text4":
				{
					if(Locale == "huHU")
						return "A {0} tábla takarítása kész.";
					else if(Locale == "enUS")
						return "The table {0} is ready for cleanup.";
					else
						return "The table {0} is ready for cleanup.";
				}
				case "Text5":
				{
					if(Locale == "huHU")
						return "A magban lévő táblák takarítása indul.";
					else if(Locale == "enUS")
						return "The core tables' cleanup is starting.";
					else
						return "The core tables' cleanup is starting.";
				}
				case "Text6":
				{
					if(Locale == "huHU")
						return "A magban lévő táblák takarítása kész.";
					else if(Locale == "enUS")
						return "The core tables' cleanup have been finished.";
					else
						return "The core tables' cleanup have been finished.";
				}
				default:
					return string.Empty;
			}
		}
	}
}
