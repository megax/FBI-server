-- ------------------------------ Table structure for ignore_channels-- ----------------------------DROP TABLE IF EXISTS `ignore_channels`;CREATE TABLE `ignore_channels` (Id INTEGER  PRIMARY KEY AUTOINCREMENT,Channel VARCHAR(20));-- ------------------------------ Table structure for ignore_nicks-- ----------------------------DROP TABLE IF EXISTS `ignore_nicks`;CREATE TABLE `ignore_nicks` (Id INTEGER  PRIMARY KEY AUTOINCREMENT,Nick VARCHAR(30));-- ------------------------------ Table structure for ignore_commands-- ----------------------------DROP TABLE IF EXISTS `ignore_commands`;CREATE TABLE `ignore_commands` (Id INTEGER  PRIMARY KEY AUTOINCREMENT,Command VARCHAR(30));-- ------------------------------ Table structure for ignore_irc_commands-- ----------------------------DROP TABLE IF EXISTS `ignore_irc_commands`;CREATE TABLE `ignore_irc_commands` (Id INTEGER  PRIMARY KEY AUTOINCREMENT,Command VARCHAR(30));