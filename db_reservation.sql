/*
Navicat MySQL Data Transfer

Source Server         : con
Source Server Version : 50021
Source Host           : localhost:3306
Source Database       : db_reservation

Target Server Type    : MYSQL
Target Server Version : 50021
File Encoding         : 65001

Date: 2016-03-14 21:26:16
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tblpaymentbaptist`
-- ----------------------------
DROP TABLE IF EXISTS `tblpaymentbaptist`;
CREATE TABLE `tblpaymentbaptist` (
  `Money` varchar(20) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tblpaymentbaptist
-- ----------------------------
INSERT INTO `tblpaymentbaptist` VALUES ('1000');

-- ----------------------------
-- Table structure for `tbl_baptisms`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_baptisms`;
CREATE TABLE `tbl_baptisms` (
  `Contact` varchar(50) NOT NULL default '',
  `Firstbap` varchar(50) default NULL,
  `Middlebap` varchar(50) default NULL,
  `Lastbapt` varchar(50) default NULL,
  `Monthbap` varchar(50) default NULL,
  `Daybap` varchar(50) default NULL,
  `Yearbap` varchar(50) default NULL,
  `Timebap` varchar(50) default NULL,
  `Monthbirth` varchar(50) default NULL,
  `Daybirth` varchar(50) default NULL,
  `Yearbirth` varchar(50) default NULL,
  `Placebirth` varchar(50) default NULL,
  `Place` varchar(50) default NULL,
  `Fathername` varchar(50) default NULL,
  `fatherplace` varchar(50) default NULL,
  `Mothername` varchar(50) default NULL,
  `motherplace` varchar(50) default NULL,
  `Kindofmarriage` varchar(50) default NULL,
  `Godmother` varchar(50) default NULL,
  `Godfather` varchar(50) default NULL,
  `PangalanngPari` varchar(50) default NULL,
  `Status` varchar(50) default NULL,
  `Balance` varchar(50) default NULL,
  PRIMARY KEY  (`Contact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_baptisms
-- ----------------------------
INSERT INTO `tbl_baptisms` VALUES ('0987654321', 'Juan', 'De', 'Cruz', 'JANUARY', '1', '2016', '8:30 AM', 'JANUARY', '1', '2015', 'Caloocan', 'Place', 'Father', 'Place', 'Mother', 'Place', 'Kindofmarriage', 'None', 'None', 'None', 'installment', '880');
INSERT INTO `tbl_baptisms` VALUES ('123', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 'Fully Paid', '0');

-- ----------------------------
-- Table structure for `tbl_fun`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_fun`;
CREATE TABLE `tbl_fun` (
  `Contact` varchar(50) NOT NULL default '',
  `Firstfun` varchar(50) default NULL,
  `Middlefun` varchar(50) default NULL,
  `Lastfun` varchar(50) default NULL,
  `Day` varchar(50) default NULL,
  `Month` varchar(50) default NULL,
  `Status` varchar(50) default NULL,
  `Father` varchar(50) default NULL,
  `Mother` varchar(50) default NULL,
  `Wife` varchar(50) default NULL,
  `Cause` varchar(50) default NULL,
  `PlaceofFuneral` varchar(50) default NULL,
  `DayofFuneral` varchar(50) default NULL,
  `MonthofFuneral` varchar(50) default NULL,
  `Time` varchar(50) default NULL,
  `NameofPriest` varchar(50) default NULL,
  `Statuss` varchar(50) default NULL,
  `Balance` varchar(50) default NULL,
  PRIMARY KEY  (`Contact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_fun
-- ----------------------------
INSERT INTO `tbl_fun` VALUES ('0987654321', 'First', 'Middle', 'Last', '1', 'FEBRUARY', 'Status', 'Father', 'Mother', 'Wife', 'Dota2', 'Place', '1', 'FEBRUARY', '12:30 PM', 'none', 'installment', '1320');
INSERT INTO `tbl_fun` VALUES ('123', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 'Fully Paid', '0');

-- ----------------------------
-- Table structure for `tbl_funeralpay`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_funeralpay`;
CREATE TABLE `tbl_funeralpay` (
  `Payment` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_funeralpay
-- ----------------------------
INSERT INTO `tbl_funeralpay` VALUES ('1500');

-- ----------------------------
-- Table structure for `tbl_mar`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_mar`;
CREATE TABLE `tbl_mar` (
  `Contact` varchar(50) NOT NULL default '',
  `Husbandfirst` varchar(50) default NULL,
  `Husbandmiddle` varchar(50) default NULL,
  `Husbandlast` varchar(50) default NULL,
  `HusbandDay` varchar(50) default NULL,
  `HusbandMonth` varchar(50) default NULL,
  `HusbandYear` varchar(50) default NULL,
  `HusbandCity` varchar(50) default NULL,
  `HusbandProvince` varchar(50) default NULL,
  `HusbandCountry` varchar(50) default NULL,
  `HusbandGender` varchar(50) default NULL,
  `HusbandReligion` varchar(50) default NULL,
  `HusbandCivilStatus` varchar(50) default NULL,
  `Husbandfatherfirst` varchar(50) default NULL,
  `Husbandfathermiddle` varchar(50) default NULL,
  `Husbandfatherlast` varchar(50) default NULL,
  `Husbandfathercitizen` varchar(50) default NULL,
  `Husbandmotherfirst` varchar(50) default NULL,
  `Husbandmothermiddle` varchar(50) default NULL,
  `Husbandmotherlast` varchar(50) default NULL,
  `Husbandmothercitizen` varchar(50) default NULL,
  `Wifefirst` varchar(50) default NULL,
  `Wifemiddle` varchar(50) default NULL,
  `Wifelast` varchar(50) default NULL,
  `WifeDay` varchar(50) default NULL,
  `WifeMonth` varchar(50) default NULL,
  `WifeYear` varchar(50) default NULL,
  `WifeCity` varchar(50) default NULL,
  `WifeProvince` varchar(50) default NULL,
  `WifeCountry` varchar(50) default NULL,
  `WifeGender` varchar(50) default NULL,
  `WifeReligion` varchar(50) default NULL,
  `WifeCivil` varchar(50) default NULL,
  `Wifefatherfirst` varchar(50) default NULL,
  `Wifefathermiddle` varchar(50) default NULL,
  `Wifefatherlast` varchar(50) default NULL,
  `Wifefathercitizen` varchar(50) default NULL,
  `Wifemotherfirst` varchar(50) default NULL,
  `Wifemothermiddle` varchar(50) default NULL,
  `Wifemotherlast` varchar(50) default NULL,
  `Wifemothercitizen` varchar(50) default NULL,
  `Godmother` varchar(50) default NULL,
  `Godfather` varchar(50) default NULL,
  `Day` varchar(50) default NULL,
  `Month` varchar(50) default NULL,
  `Year` varchar(50) default NULL,
  `Office` varchar(50) default NULL,
  `City` varchar(50) default NULL,
  `Province` varchar(50) default NULL,
  `Time` varchar(50) default NULL,
  `Status` varchar(50) default NULL,
  `Balance` int(50) default NULL,
  PRIMARY KEY  (`Contact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_mar
-- ----------------------------
INSERT INTO `tbl_mar` VALUES ('098766543', 'Anthony', 'Canon', 'Dedios', '1', 'JANUARY', '1989', 'City', 'Province', 'Country', 'MALE', 'Religion', 'Status', 'First', 'Middle', 'Last', 'Citizen', 'First', 'Middle', 'Last', 'Citizen', 'Farrah', 'Dy', 'Mandeeli', '15', 'FEBRUARY', '1987', 'City', 'Province', 'Country', 'FEMALE', 'Religion', 'Status', 'First', 'Middle', 'Last', 'Citizen', 'First', 'Middle', 'Last', 'Citizen', 'Godmother', 'Godfather', null, null, null, null, null, null, null, 'installment', '400');
INSERT INTO `tbl_mar` VALUES ('123123', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 'Fully Paid', '0');

-- ----------------------------
-- Table structure for `tbl_optional`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_optional`;
CREATE TABLE `tbl_optional` (
  `ribbon` varchar(20) default NULL,
  `flowers` varchar(20) default NULL,
  `candle` varchar(20) default NULL,
  `carpet` varchar(20) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_optional
-- ----------------------------
INSERT INTO `tbl_optional` VALUES ('100', '200', '50', '150');

-- ----------------------------
-- Table structure for `tbl_registration`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_registration`;
CREATE TABLE `tbl_registration` (
  `RegistrationID` varchar(50) NOT NULL default '',
  `Firstname` varchar(50) default NULL,
  `Lastname` varchar(50) default NULL,
  `Requirements` varchar(50) default NULL,
  `Fillup` varchar(50) default NULL,
  `Payment` varchar(50) default NULL,
  `ReqA` varchar(50) default NULL,
  `ReqB` varchar(50) default NULL,
  `ReqC` varchar(50) default NULL,
  `ReqD` varchar(50) default NULL,
  `ReqE` varchar(50) default NULL,
  `Complete` varchar(50) default NULL,
  `Complete2` varchar(50) default NULL,
  PRIMARY KEY  (`RegistrationID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_registration
-- ----------------------------
INSERT INTO `tbl_registration` VALUES ('098766543', 'Farrah', 'Mandeeli', 'x', 'Complete', 'Incomplete', '', '', '', 'd', 'e', '', null);
INSERT INTO `tbl_registration` VALUES ('123123', 'Anthony', 'Canon', 'x', 'x', 'Complete', null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for `tbl_registrationbaptist`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_registrationbaptist`;
CREATE TABLE `tbl_registrationbaptist` (
  `RegistrationID` varchar(50) NOT NULL default '',
  `Firstname` varchar(50) default NULL,
  `Lastname` varchar(50) default NULL,
  `Requirements` varchar(50) default NULL,
  `Fillup` varchar(50) default NULL,
  `Payment` varchar(50) default NULL,
  `ReqA` varchar(50) default NULL,
  `Complete` varchar(50) default NULL,
  `Complete2` varchar(50) default NULL,
  PRIMARY KEY  (`RegistrationID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_registrationbaptist
-- ----------------------------
INSERT INTO `tbl_registrationbaptist` VALUES ('0987654321', 'Farrah', 'Mandeeli', 'x', 'Complete', 'Incomplete', null, null, null);
INSERT INTO `tbl_registrationbaptist` VALUES ('123', 'Hannah', 'Joyce', 'x', 'x', 'Complete', null, null, null);

-- ----------------------------
-- Table structure for `tbl_registrationfuneral`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_registrationfuneral`;
CREATE TABLE `tbl_registrationfuneral` (
  `RegistrationID` varchar(50) default NULL,
  `Firstname` varchar(50) default NULL,
  `Lastname` varchar(50) default NULL,
  `Requirements` varchar(50) default NULL,
  `Fillup` varchar(50) default NULL,
  `Payment` varchar(50) default NULL,
  `ReqA` varchar(50) default NULL,
  `ReqB` varchar(50) default NULL,
  `Complete` varchar(50) default NULL,
  `Complete2` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_registrationfuneral
-- ----------------------------
INSERT INTO `tbl_registrationfuneral` VALUES ('09876543210', 'Anthony', 'Canon', 'x', 'x', 'Complete', null, null, null, null);
INSERT INTO `tbl_registrationfuneral` VALUES ('0987654321', 'Hannah', 'Pimentel', 'x', 'Complete', 'Incomplete', null, null, null, null);

-- ----------------------------
-- Table structure for `tbl_totalpay`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_totalpay`;
CREATE TABLE `tbl_totalpay` (
  `Payment` varchar(20) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_totalpay
-- ----------------------------
INSERT INTO `tbl_totalpay` VALUES ('500');

-- ----------------------------
-- Table structure for `tbl_user`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE `tbl_user` (
  `Username` varchar(50) NOT NULL default '',
  `Password` varchar(50) default NULL,
  `Firstname` varchar(50) default NULL,
  `Lastname` varchar(50) default NULL,
  `Contact` varchar(50) default NULL,
  `Status` varchar(50) default NULL,
  `Levelofaccess` varchar(50) default NULL,
  PRIMARY KEY  (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_user
-- ----------------------------
INSERT INTO `tbl_user` VALUES ('Admin', '123', 'Ton', 'Cruz', '09202192143', 'Enabled', 'Admin');
INSERT INTO `tbl_user` VALUES ('Client', '123', 'Farrah', 'Mandeeli', '09993358223', 'Enabled', 'Client');
