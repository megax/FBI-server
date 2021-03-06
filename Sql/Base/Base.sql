/* Base.sql */

-- ----------------------------
-- Records of channels
-- ----------------------------
INSERT INTO `channels` VALUES ("1", "1", "default", ",log:on,rejoin:on,commands:on", "#fbi", "", "false", "", "enUS");

-- ----------------------------
-- Records of servers
-- ----------------------------
INSERT INTO `servers` VALUES ('1', '1', 'yeahunter', 'irc.yeahunter.hu', '6667', 'false', 'FBI', '_FBI', '__FBI', 'FBI', 'FBI IRC Bot', 'false', '', 'false', 'false');

-- huHU
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "consolelog", "Console logolás bekapcsolva.\nConsole logolás kikapcsolva.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "sys", "Verzió: {0}\nPlatform: {0}\nOSVerzió: {0}\nProgramnyelv: c#\nMemória használat: {0} MB\nFutó szálak: {0}\nMűködési idő: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "cchannel", "Új csatorna ahova mostantól lehet írni: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/info", "Jelenleg Fél Operátor vagy.\nJelenleg Operátor vagy.\nJelenleg Adminisztrátor vagy.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/list", "Adminok: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/add", "A név már szerepel az admin listán!\nAdmin hozzáadva: {0}\nJelenlegi jelszó: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/remove", "Ilyen név nem létezik!\nAdmin törölve: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/rank", "Rang sikeresen módosítva.\nHibás rang!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin", "Parancsok: help | list | add | remove");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/channel/info", "Bekapcsolva: {0}\nKikapcsolva: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/channel", "{0}: bekapcsolva\n{0}: kikapcsolva\nIlyen csatorna nem létezik!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/update", "Sikeresen frissítve {0} csatornán a funkciók.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/update/all", "Sikeresen frissítve minden csatornán a funkciók.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/info", "Bekapcsolva: {0}\nKikapcsolva: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "function", "{0}: bekapcsolva\n{0}: kikapcsolva");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel", "Parancsok: add | remove | info | update | language | password");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/add", "A név már szerepel a csatorna listán!\nCsatorna hozzáadva: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/remove", "A mester csatorna nem törölhető!\nIlyen csatorna nem létezik!\nCsatorna eltávolítva: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/update", "A csatorna információk frissítésre kerültek.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/info", "Aktív: {0}\nAktív: Nincs információ.\nInaktív: {0}\nInaktív: Nincs információ.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/language", "Csatorna nyelvezete sikeresen meg lett változtatva erre: {0}\nIlyen csatorna nem létezik!\nA csatorna nyelvezete már: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/add", "Ilyen csatorna nem létezik!\nMár van megadva jelszó a csatornán!\nJelszó lett beállítva a csatornára, jelszó: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/remove", "Ilyen csatorna nem létezik!\nNincs a csatornához beállítva jelszó!\nJelszó el lett távolítva a csatornáról.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/update", "Ilyen csatorna nem létezik!\nNincs a csatornához beállítva jelszó!\nÚj jelszó lett beállítva a csatornára, jelszó: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/info", "Ilyen csatorna nem létezik!\nA csatornán nincs jelszó.\nA csatornán van jelszó.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "nick", "Nick megváltoztatása erre: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "join", "Kapcsolódás ehhez a csatornához: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "leave", "Lelépés erről a csatornáról: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "reload", "A programban nincs ilyen rész!\nValahol hiba történt az újratöltésben!\n{0} újra lett indítva.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "quit", "Viszlát :(\nConsole: Program leállítása.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "help", "Ha a parancs mögé írod a megadott parancs nevét vagy a nevet és alparancsát információt ad a használatáról.\nParancsok: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "plugin/load", "[Betöltés]: Összes plugin betöltése sikeres.\n[Betöltés]: Összes plugin betöltése sikertelen.\nA pluginok már be vannak töltve!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "plugin/unload", "[Leválasztás]: Összes plugin leválasztása sikeres.\n[Leválasztás]: Összes plugin leválasztása sikertelen.\nA pluginok már le vannak választva!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "plugin", "{0}: betöltve.\n{0}: letiltva.\nNincsen betöltve plugin!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("huHU", "cserver", "Új szerver amit mostantól lehet állítani a parancsokkal: {0}");

-- enUS
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "consolelog", "Console logging on.\nConsole logging off.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "sys", "Version: {0}\nPlatform: {0}\nOSVersion: {0}\nProgramming language: c#\nMemory allocation: {0} MB\nThread count: {0}\nUptime: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "cchannel", "The new channel to write to now: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/info", "You are half operator now.\nYou are operator now.\nYou are administrator now.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/list", "Admins: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/add", "The name is already in the admin list!\nAdmin added to the list: {0}\nPassword: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/remove", "No such nick!\nAdmin was deleted: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/rank", "Successfully changed the rank!\nRank error!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin", "Commands: help | list | add | remove");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/channel/info", "On: {0}\nOff: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/channel", "{0}: On\n{0}: Off\nNo such channel!");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/update", "Successfully updated the channel functions in: {0}.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/update/all", "Successfully updated the information of all channels.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/info", "On: {0}\nOff: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "function", "{0}: are on.\n{0}: are off.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel", "Commands: add | remove | info | update | language | password");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/add", "The name is already exists in the channel list.\nAdded channel: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/remove", "The master channel cannot delete!\nNo such channel!\nDeleted channel: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/update", "The channel informations are updated.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/info", "Active: {0}\nActive: Nothing information.\nInactive: {0}\nInactive: Nothing information.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/language", "Successfully changed the channel language to: {0}\nNo such channel!\nChannel current language: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/add", "There is no such a channel!\nPassword is already set on the channel!\n Password set on channel, password: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/remove", "There is no such a channel!\nThere is no password set on the channel!\n Password deleted from the channel.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/update", "There is no such a channel!\nThere is no password set on the channel!\nNew password set on the channel, password: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/info", "There is no such a channel!\nThere is no password set on the channel!\nThere is a password on the channel.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "nick", "Nick changes to: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "join", "Join to this channel: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "left", "Part of this channel: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "reload", "The program does not contains that part!\nThere is an error in the reload!\n{0} reloaded.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "quit", "Bye :(\nConsole: Program shut down.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "help", "If you wrote behind the command the command or the name or co-command then gets information about usage.\nCommands: {0}");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "plugin/load", "[Load]: All plugins done.\n[Load]: All plugins failed.\nPlugins are already loaded.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "plugin/unload", "[Unload]: All plugins done.\n[Unload]: All plugins failed.\nPlugins are already cutted.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "plugin", "{0}: loaded.\n{0}: ignored.\nNo plugin loeaded.");
INSERT INTO `localized_console_command` (`Language`, `Command`, `Text`) VALUES ("enUS", "cserver", "New server for the commands: {0}");

-- huHU
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin", "Kiírja az operátorok vagy adminisztrátorok által használható parancsokat.\nAdmin parancsai: info | list | add | remove | rank | access | newpassword");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/add", "Új admin hozzáadása.\nHasználata: admin add <admin neve>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/remove", "Admin eltávolítása.\nHasználata: admin remove <admin neve>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/rank", "Admin rangjának megváltoztatása.\nHasználata: admin rank <admin neve> <új rang pl halfoperator: 0, operator: 1, administrator: 2>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/info", "Kiírja, hogy éppen milyen rangja van.\nHasználata: admin info <admin neve>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "admin/list", "Kiírja az összes admin nevét aki az adatbázisban szerepel.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "function", "Funkciók vezérlésére szolgáló parancs.\nFunkció parancsai: channel | update | info\nHasználata globálisan:\nGlobalis funkció kezelése: function <on vagy off> <funkció név>\nGlobális funkciók kezelése: function <on vagy off> <funkció név1> <funkció név2> ... stb");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/channel", "A megadott csatornán ezzel a paranccsal állíthatók a funkciók.\nFunkció channel parancsai: info\nHasználata:\nCsatorna funkció kezelése: function channel <csatorna neve> <on vagy off> <funkció név>\nChannel funkciók kezelése: function channel <csatorna neve> <on vagy off> <funkció név1> <funkció név2> ... stb");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/channel/info", "Kiírja a funkciók állapotát.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/update", "Frissíti a funkciókat vagy alapértelmezésre állítja.\nFunkció update parancsai: all\nHasználata:\nMás channel: function update <csatorna neve>\nJelenlegi csatorna: function update");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/update/all", "Frissíti az összes funkciót vagy alapértelmezésre állítja.\nHasználata: function update all");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "function/info", "Kiírja a funkciók állapotát.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel", "Channel parancsai: add | remove | info | update | language | password");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/add", "Új csatorna hozzáadása.\nHasználata: channel add <csatorna neve> <ha van jelszó akkor az>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/remove", "Nem használatos csatorna eltávolítása.\nHasználata: channel remove <csatorna neve>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/info", "Az összes csatorna kiírása, ami az adatbázisban van és a hozzájuk tartozó információk.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/update", "Frissíti a csatornákhoz tartozó összes információkat és alapértelmezettre állítja.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/language", "Frissíti a csatorna nyelvezetét.\nHasználata: channel language <csatorna neve> <nyelvezet>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password", "Lehetővé teszi a jelszó beállítását a csatornán.\nParancsok: add | remove | update | info");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/add", "Hozzáadja a jelszót a csatornához.\nHasználata: channel password add <csatorna> <jelszó>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/remove", "Eltávolítja a jelszót a csatornáról.\nHasználata: channel password remove <csatorna>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/update", "Frissíti a csatorna jelszavát.\nHasználata: channel password update <csatorna> <jelszó>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "channel/password/info", "Kiírja a megadott csatorna jelszavának állapotát.\nHasználata: channel password info <csatorna>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "nick", "Bot nick nevének cseréje.\nHasználata: nick <név>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "join", "Kapcsolódás a megadott csatornára.\nHasználata:\nJelszó nélküli csatorna: join <csatorna neve>\nJelszóval ellátott csatorna: join <csatorna neve> <jelszó>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "leave", "Lelépés a megadott csatornáról.\nHasználata: leave <csatona neve>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "quit", "Bot leállítására használható parancs.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "reload", "Újraindítja a megadott programrészt.\nHasználata: reload <név>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "consolelog", "Az irc adatok konzolra írását engedélyezi vagy tiltja. Alapértelmezésben ki van kapcsolva.\nHasználata: consolelog <on vagy off>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "sys", "Kiírja a botról a rendszer információkat.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "cchannel", "A bot csatornára írását állíthatjuk vele.\nHasználata: cchannel <csatorna neve>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "connect", "Kapcsolodás az irc szerverhez.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "disconnect", "Kapcsolat bontása.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "reconnect", "Újrakapcsolodás az irc szerverhez.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "plugin", "Kiírja milyen pluginok vannak betöltve.\nPlugin parancsok: load | unload");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "plugin/load", "Betölt minden plugint.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "plugin/unload", "Eltávolít minden plugint.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("huHU", "cserver", "A szerverek között válthatunk vele.\nHasználata: cserver <szerver neve>");

-- enUS
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin", "Print Operators or Administrators can use commands.\nAdmin commands: info | list | add | remove | rank | access | newpassword");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/add", "Add new admin.\nUse: admin add <admin name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/remove", "Removing admin.\nUse: admin remove <admin name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/rank", "Admin rank change.\nUse: admin rank <admin name> <new rank e.g. halfoperator: 0, operator: 1, administrator: 2>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/info", "Show the admin's rank.\nUse: admin info <admin name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "admin/list", "Show the names of all the admin, who is included in the database.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "function", "Function control command.\nFunction commands: channel | update | info\nUse globally:\nGlobal management function: function <on or off> <function name>\nGlobal management functions: function <on or off> <function name1> <function name2> ... e.g.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/channel", "The specified channel, use this command to set functions.\nFunction channel commands: info\nUse:\nChannel management function: function channel <channel> <on or off> <function name>\nChannel management functions: function channel <channel> <on or off> <function name1> <function name2> ... e.g.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/channel/info", "Shows the functions status.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/update", "Updates the function or set defaults.\nFunction update command: all\nUse:\nOther channel: function update <channel name>\nCurrent channel: function update");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/update/all", "Updates all the features or set defaults.\nUse: function update all");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "function/info", "Shows the functions status.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel", "Channel commands: add | remove | info | update | language | password");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/add", "Add new channel.\nUse: channel add <channel name> <password if you have>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/remove", "Removing channel.\nUse: channel remove <channel name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/info", "Shows all the channels, which are in the database and associated information.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/update", "Updates on all channels of information and their default values.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/language", "Updates the language of the channel.\nUse: channel language <channel name> <language>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password", "You can set a password on the channel with it.\nCommands: add | remove | update | info");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/add", "Add password to the channel.\nUse: channel password add <channel> <password>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/remove", "Delete passworld from the channel.\nUse: channel password remove <channel>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/update", "Update password on the channel.\nUse: channel password update <channel> <password>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "channel/password/info", "Show the current channel password statement.\nUse: channel password info <channel>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "nick", "Bot nick change.\nUse: nick <name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "join", "Connect to the specified channel.\nUse:\nNon-password protected channels: join <channel name>\nPassword protected channels: join <channel name> <password>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "leave", "Part a given channel.\Use: leave <channel name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "quit", "Bot shutdown command.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "reload", "Reloads the specified program section.\nUse: reload <name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "consolelog", "Enables or disables display of the IRC logs to the console. The default is off.\nUse: consolelog <on or off>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "sys", "Show the system information of the bot.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "cchannel", "You can select which channel to send the robot.\nUse: cchannel <channel name>");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "connect", "Connect to the IRC server.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "disconnect", "Disconnect.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "reconnect", "Trying to reconnect to the IRC server.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "plugin", "Shows what plugins are loaded.\nPlugin commands: load | unload");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "plugin/load", "Loads all the plugin.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "plugin/unload", "Remove all plugin.");
INSERT INTO `localized_console_command_help` (`Language`, `Command`, `Text`) VALUES ("enUS", "cserver", "Switch between servers.\nUse: cserver <server's name>");

-- huHU
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "WrongSwitch", "Nem megfelelő kapcsoló lett megadva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoName", "A név nincs megadva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoValue", "Nincs paraméter!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "No1Value", "Nincs megadva egy paraméter!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoChannelName", "Nincs megadva a csatorna neve!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "FaultyQuery", "Hibás lekérdezés!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoRank", "Nincs megadva a rang!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoFunctionName", "Nincs megadva a funkció neve!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoChannelLanguage", "Nincs megadva a csatorna nyelvezete!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NotaChannelHasBeenSet", "Nem csatorna lett megadva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ImAlreadyOnThisChannel", "Már fent vagyok ezen a csatornán!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ThisChannelBlockedByAdmin", "Admin által letiltott csatorna!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ImNotOnThisChannel", "Nem vagyok fent ezen a csatornán!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoCommand", "Nincs megadva a parancs!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoIgnoreCommand", "Nem tehető kivételek közé a parancs!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoIgnoreMasterChannel", "Nem tiltható le a mester csatorna!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "FunctionAlreadyTurnedOn", "A funkció már be van kapcsolva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "FunctionAlreadyTurnedOff", "A funkció már ki van kapcsolva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "FunctionAlreadyTurnedOn2", "{0}: A funkció már be van kapcsolva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "FunctionAlreadyTurnedOff2", "{0}: A funkció már ki van kapcsolva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "NoServerName", "Nincs megadva a szerver neve!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ThereIsNoSuchAServerName", "Ilyen szerver név nem létezik!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ChannelAlreadyBeenUsed", "Jelenleg is ez a csatorna van beállítva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ServerAlreadyBeenUsed", "Jelenleg is ez a szerver van beállítva!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("huHU", "ThereIsNoSuchAnAddon", "Ilyen addon nem létezik!");

-- enUS
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "WrongSwitch", "Wrong Switch!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoName", "The name is not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoValue", "The parameters are not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "No1Value", "A parameter was not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoChannelName", "The channel name is not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "FaultyQuery", "Syntax error!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoRank", "The rank is not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoFunctionName", "The function name is not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoChannelLanguage", "The channel language is not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NotaChannelHasBeenSet", "Not a channel has been set!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ImAlreadyOnThisChannel", "I'm already on this channel!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ThisChannelBlockedByAdmin", "This channel blocked by admin!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ImNotOnThisChannel", "I'm not on this channel!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoCommand", "The command is not specified!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoIgnoreCommand", "You can't put this command to the inceptions!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoIgnoreMasterChannel", "The master channel shouldn't be ignored!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "FunctionAlreadyTurnedOn", "Function already turned on!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "FunctionAlreadyTurnedOff", "Function already turned off!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "FunctionAlreadyTurnedOn2", "{0}: Function already turned on!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "FunctionAlreadyTurnedOff2", "{0}: Function already turned off!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "NoServerName", "There is no server name!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ThereIsNoSuchAServerName", "There is no such a server name!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ChannelAlreadyBeenUsed", "Channel already been used!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ServerAlreadyBeenUsed", "Server already been used!");
INSERT INTO `localized_console_warning` (`Language`, `Command`, `Text`) VALUES ("enUS", "ThereIsNoSuchAnAddon", "There is no such an addon!");

-- ----------------------------
-- Records of fbi
-- ----------------------------
INSERT INTO `fbi` VALUES ("1", "1", "default", "log", "on");
INSERT INTO `fbi` VALUES ("2", "1", "default", "rejoin", "on");
INSERT INTO `fbi` VALUES ("3", "1", "default", "commands", "on");
INSERT INTO `fbi` VALUES ("4", "1", "default", "reconnect", "on");
