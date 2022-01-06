/*
Navicat MySQL Data Transfer

Source Server         : benjo
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : bankomat

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-01-06 01:17:46
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `bankomat`
-- ----------------------------
DROP TABLE IF EXISTS `bankomat`;
CREATE TABLE `bankomat` (
  `BankomatID` int(11) NOT NULL auto_increment,
  `GradID` int(11) NOT NULL,
  `Adresa` varchar(150) NOT NULL,
  `StanjeBankomata` int(11) NOT NULL,
  `StatusBankomataID` int(11) NOT NULL,
  PRIMARY KEY  (`BankomatID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bankomat
-- ----------------------------
INSERT INTO `bankomat` VALUES ('1', '1', 'Marsala Tita 15', '10000', '1');
INSERT INTO `bankomat` VALUES ('2', '1', 'Zmaja od Bosne 8', '8000', '1');
INSERT INTO `bankomat` VALUES ('3', '2', 'Marsala Tita 12', '0', '3');
INSERT INTO `bankomat` VALUES ('4', '2', 'Zdravstvenih radnika', '0', '2');
INSERT INTO `bankomat` VALUES ('5', '3', 'Branimirova bb', '12000', '1');
INSERT INTO `bankomat` VALUES ('6', '3', 'Savska 53', '5000', '1');
INSERT INTO `bankomat` VALUES ('7', '3', 'Sarajevska cesta bb', '0', '2');
INSERT INTO `bankomat` VALUES ('8', '4', 'Bihaćka ulica 35', '3000', '1');
INSERT INTO `bankomat` VALUES ('9', '5', 'Radnička 83', '13000', '1');
INSERT INTO `bankomat` VALUES ('10', '5', 'Dostojevskog bb', '0', '3');
INSERT INTO `bankomat` VALUES ('11', '5', 'Dunavska 53', '0', '3');
INSERT INTO `bankomat` VALUES ('12', '5', 'Humska bb', '0', '2');
INSERT INTO `bankomat` VALUES ('13', '5', 'Evropska 22', '11000', '1');
INSERT INTO `bankomat` VALUES ('14', '6', 'Vladimira Perića Valtera', '7000', '1');
INSERT INTO `bankomat` VALUES ('15', '7', 'Kozaračka bb', '3000', '1');
INSERT INTO `bankomat` VALUES ('16', '7', 'Cvijetna 71', '0', '3');
INSERT INTO `bankomat` VALUES ('17', '8', 'Kosovska bb', '0', '3');
INSERT INTO `bankomat` VALUES ('18', '8', 'Cara Lazara 25', '6000', '1');
INSERT INTO `bankomat` VALUES ('19', '9', 'Trg mladih bb', '7000', '1');
INSERT INTO `bankomat` VALUES ('20', '9', 'Moskovska ulica 28', '0', '2');
INSERT INTO `bankomat` VALUES ('21', '10', 'Titova cesta 62', '1000', '3');
INSERT INTO `bankomat` VALUES ('22', '10', 'Jenkova ulica bb', '9000', '1');
INSERT INTO `bankomat` VALUES ('23', '11', 'Unaza 38', '4000', '1');
INSERT INTO `bankomat` VALUES ('24', '11', 'Rruga Studenti bb', '0', '3');
INSERT INTO `bankomat` VALUES ('25', '12', 'Rruga Adria 32', '12000', '1');
INSERT INTO `bankomat` VALUES ('26', '12', 'Rruga Currila 12', '0', '3');

-- ----------------------------
-- Table structure for `drzava`
-- ----------------------------
DROP TABLE IF EXISTS `drzava`;
CREATE TABLE `drzava` (
  `DrzavaID` int(11) NOT NULL auto_increment,
  `Naziv_Drzave` varchar(100) NOT NULL,
  PRIMARY KEY  (`DrzavaID`),
  UNIQUE KEY `Naziv_Drzave` (`Naziv_Drzave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of drzava
-- ----------------------------
INSERT INTO `drzava` VALUES ('6', 'Albanija');
INSERT INTO `drzava` VALUES ('1', 'Bosna i Hercegovina');
INSERT INTO `drzava` VALUES ('4', 'Crna Gora');
INSERT INTO `drzava` VALUES ('2', 'Hrvatska');
INSERT INTO `drzava` VALUES ('5', 'Slovenija');
INSERT INTO `drzava` VALUES ('3', 'Srbija');

-- ----------------------------
-- Table structure for `grad`
-- ----------------------------
DROP TABLE IF EXISTS `grad`;
CREATE TABLE `grad` (
  `GradID` int(11) NOT NULL auto_increment,
  `Ime_grada` varchar(150) NOT NULL,
  `Postanski_broj` int(11) NOT NULL,
  `DrzavaID` int(11) NOT NULL,
  PRIMARY KEY  (`GradID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of grad
-- ----------------------------
INSERT INTO `grad` VALUES ('1', 'Sarajevo', '71000', '1');
INSERT INTO `grad` VALUES ('2', 'Goražde', '73000', '1');
INSERT INTO `grad` VALUES ('3', 'Zagreb', '10000', '2');
INSERT INTO `grad` VALUES ('4', 'Split', '21000', '2');
INSERT INTO `grad` VALUES ('5', 'Beograd', '11000', '3');
INSERT INTO `grad` VALUES ('6', 'Novi Sad', '21000', '3');
INSERT INTO `grad` VALUES ('7', 'Podgorica', '81000', '4');
INSERT INTO `grad` VALUES ('8', 'Sutomore', '85355', '4');
INSERT INTO `grad` VALUES ('9', 'Ljubljana', '1000', '5');
INSERT INTO `grad` VALUES ('10', 'Maribor', '2000', '5');
INSERT INTO `grad` VALUES ('11', 'Tirana', '1000', '6');
INSERT INTO `grad` VALUES ('12', 'Drač', '2001', '6');

-- ----------------------------
-- Table structure for `korisnik`
-- ----------------------------
DROP TABLE IF EXISTS `korisnik`;
CREATE TABLE `korisnik` (
  `KorisnikID` int(11) NOT NULL auto_increment,
  `Ime` varchar(200) NOT NULL,
  `Prezime` varchar(200) NOT NULL,
  `ImeOca` varchar(200) NOT NULL,
  `JMBG` bigint(20) NOT NULL,
  `ZanimanjeID` int(11) NOT NULL,
  `AdresaStanovanja` varchar(250) NOT NULL,
  `GradID` int(11) NOT NULL,
  `DatumRodjenja` date NOT NULL,
  `KontaktTelefon` varchar(100) NOT NULL,
  `Email` varchar(100) default NULL,
  PRIMARY KEY  (`KorisnikID`),
  UNIQUE KEY `JMBG` (`JMBG`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of korisnik
-- ----------------------------
INSERT INTO `korisnik` VALUES ('1', 'Hrvoje', 'Petrovic', 'Stipe', '1204965921345', '1', 'Vrbik 15', '3', '1965-04-12', '+3851225883', 'hpetrovic@gmail.com');
INSERT INTO `korisnik` VALUES ('2', 'Avdo', 'Avdić', 'Sudo', '1010985921345', '1', 'Kranjčevićeva 10', '1', '1985-10-10', '+38761000000', 'aavdic@gmail.com');
INSERT INTO `korisnik` VALUES ('3', 'Marko', 'Marković', 'Saša', '1206997921345', '2', 'Sarajevska 33', '5', '1997-06-11', '+3815584421', 'mmarkovic@outlook.com');
INSERT INTO `korisnik` VALUES ('4', 'Dejan', 'Bakočević', 'Ognjen', '503980921345', '2', 'Romanovih bb', '7', '1980-03-05', '+3824125528', 'dejanbakocevic@outlook.com');
INSERT INTO `korisnik` VALUES ('5', 'Ana', 'Anić', 'Janez', '512999921345', '3', 'Roška Cesta bb', '9', '1999-12-05', '+3861763255', 'anaanic@gmail.com');
INSERT INTO `korisnik` VALUES ('6', 'Azem', 'Ismaili', 'Besar', '204955921345', '4', 'Skender Luarasi 48', '11', '1955-04-02', '+3554444221', 'azem_ismaili@yahoo.com');

-- ----------------------------
-- Table structure for `racun`
-- ----------------------------
DROP TABLE IF EXISTS `racun`;
CREATE TABLE `racun` (
  `BrojRacuna` int(11) NOT NULL auto_increment,
  `KorisnikID` int(11) NOT NULL,
  `VrstaRacunaID` int(11) NOT NULL,
  `StanjeRacuna` int(11) NOT NULL,
  `Pin` int(11) NOT NULL,
  `DnevniLimit` int(11) NOT NULL,
  `StatusRacunaID` int(11) NOT NULL,
  PRIMARY KEY  (`BrojRacuna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of racun
-- ----------------------------
INSERT INTO `racun` VALUES ('1', '1', '1', '2000', '1234', '100', '1');
INSERT INTO `racun` VALUES ('2', '1', '2', '1280', '7632', '30', '1');
INSERT INTO `racun` VALUES ('3', '2', '2', '2380', '1111', '1000', '1');
INSERT INTO `racun` VALUES ('4', '3', '1', '0', '0', '20', '2');
INSERT INTO `racun` VALUES ('5', '4', '1', '300', '2222', '40', '2');
INSERT INTO `racun` VALUES ('6', '5', '3', '150', '3333', '20', '1');
INSERT INTO `racun` VALUES ('7', '6', '2', '250', '0', '20', '1');

-- ----------------------------
-- Table structure for `statusbankomata`
-- ----------------------------
DROP TABLE IF EXISTS `statusbankomata`;
CREATE TABLE `statusbankomata` (
  `StatusBankomataID` int(11) NOT NULL auto_increment,
  `StatusBankomata` varchar(20) NOT NULL,
  PRIMARY KEY  (`StatusBankomataID`),
  UNIQUE KEY `StatusBankomata` (`StatusBankomata`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of statusbankomata
-- ----------------------------
INSERT INTO `statusbankomata` VALUES ('2', 'Nije u funkciji');
INSERT INTO `statusbankomata` VALUES ('3', 'Potrebno dopuniti');
INSERT INTO `statusbankomata` VALUES ('1', 'U funkciji');

-- ----------------------------
-- Table structure for `statusracuna`
-- ----------------------------
DROP TABLE IF EXISTS `statusracuna`;
CREATE TABLE `statusracuna` (
  `StatusRacunaID` int(11) NOT NULL auto_increment,
  `StatusRacuna` varchar(20) NOT NULL,
  PRIMARY KEY  (`StatusRacunaID`),
  UNIQUE KEY `StatusRacuna` (`StatusRacuna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of statusracuna
-- ----------------------------
INSERT INTO `statusracuna` VALUES ('1', 'Aktivan');
INSERT INTO `statusracuna` VALUES ('2', 'Blokiran');

-- ----------------------------
-- Table structure for `trans`
-- ----------------------------
DROP TABLE IF EXISTS `trans`;
CREATE TABLE `trans` (
  `TransferID` int(11) NOT NULL auto_increment,
  `BrojRacunaPosiljaoca` int(11) NOT NULL,
  `BrojRacunaPrimaoca` int(11) NOT NULL,
  `VrstaUslugeID` int(11) NOT NULL,
  `Vrijednost` int(11) NOT NULL,
  `DatumIVrijeme` datetime NOT NULL,
  `BankomatID` int(11) NOT NULL,
  PRIMARY KEY  (`TransferID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of trans
-- ----------------------------
INSERT INTO `trans` VALUES ('1', '1', '5', '3', '150', '2021-12-23 13:12:15', '5');
INSERT INTO `trans` VALUES ('2', '3', '4', '3', '50', '2021-12-23 13:12:15', '12');
INSERT INTO `trans` VALUES ('3', '2', '7', '3', '30', '2022-01-03 11:05:11', '8');
INSERT INTO `trans` VALUES ('4', '4', '6', '3', '80', '2021-12-30 14:55:31', '4');
INSERT INTO `trans` VALUES ('5', '6', '2', '3', '25', '2021-12-23 13:12:15', '18');
INSERT INTO `trans` VALUES ('6', '3', '6', '3', '500', '2021-12-31 09:52:25', '1');

-- ----------------------------
-- Table structure for `transakcija`
-- ----------------------------
DROP TABLE IF EXISTS `transakcija`;
CREATE TABLE `transakcija` (
  `TransakcijaID` int(11) NOT NULL auto_increment,
  `BrojRacuna` int(11) NOT NULL,
  `VrstaUslugeID` int(11) NOT NULL,
  `Vrijednost` int(11) NOT NULL,
  `DatumIVrijeme` datetime NOT NULL,
  `BankomatID` int(11) NOT NULL,
  PRIMARY KEY  (`TransakcijaID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of transakcija
-- ----------------------------
INSERT INTO `transakcija` VALUES ('1', '1', '1', '100', '2022-01-01 15:15:30', '1');
INSERT INTO `transakcija` VALUES ('2', '1', '1', '100', '2022-01-01 15:15:30', '5');
INSERT INTO `transakcija` VALUES ('3', '1', '2', '50', '2022-01-01 15:15:30', '5');
INSERT INTO `transakcija` VALUES ('4', '1', '1', '80', '2022-01-01 15:15:30', '2');
INSERT INTO `transakcija` VALUES ('5', '1', '1', '30', '2022-01-01 15:15:30', '5');
INSERT INTO `transakcija` VALUES ('6', '1', '2', '40', '2022-01-01 15:15:30', '3');
INSERT INTO `transakcija` VALUES ('7', '2', '1', '20', '2022-01-01 15:15:30', '15');
INSERT INTO `transakcija` VALUES ('8', '2', '1', '30', '2022-01-01 15:15:30', '7');
INSERT INTO `transakcija` VALUES ('9', '2', '2', '50', '2022-01-01 15:15:30', '3');
INSERT INTO `transakcija` VALUES ('10', '2', '2', '70', '2022-01-01 15:15:30', '3');
INSERT INTO `transakcija` VALUES ('11', '2', '1', '30', '2022-01-01 15:15:30', '18');
INSERT INTO `transakcija` VALUES ('12', '3', '1', '300', '2022-01-01 15:15:30', '9');
INSERT INTO `transakcija` VALUES ('13', '3', '1', '50', '2022-01-01 15:15:30', '9');
INSERT INTO `transakcija` VALUES ('14', '3', '2', '100', '2022-01-01 15:15:30', '13');
INSERT INTO `transakcija` VALUES ('15', '3', '2', '20', '2022-01-01 15:15:30', '13');
INSERT INTO `transakcija` VALUES ('16', '3', '1', '1000', '2022-01-01 15:15:30', '10');
INSERT INTO `transakcija` VALUES ('17', '3', '1', '900', '2022-01-01 15:15:30', '11');
INSERT INTO `transakcija` VALUES ('18', '4', '1', '10', '2022-01-01 15:15:30', '20');
INSERT INTO `transakcija` VALUES ('19', '4', '2', '50', '2022-01-01 15:15:30', '4');
INSERT INTO `transakcija` VALUES ('20', '4', '2', '20', '2022-01-01 15:15:30', '1');
INSERT INTO `transakcija` VALUES ('21', '4', '1', '20', '2022-01-01 15:15:30', '14');
INSERT INTO `transakcija` VALUES ('22', '4', '2', '20', '2022-01-01 15:15:30', '21');
INSERT INTO `transakcija` VALUES ('23', '4', '1', '20', '2022-01-01 15:15:30', '14');
INSERT INTO `transakcija` VALUES ('24', '5', '1', '40', '2022-01-01 15:15:30', '10');
INSERT INTO `transakcija` VALUES ('25', '5', '1', '20', '2022-01-01 15:15:30', '10');
INSERT INTO `transakcija` VALUES ('26', '5', '2', '30', '2022-01-01 15:15:30', '10');
INSERT INTO `transakcija` VALUES ('27', '5', '1', '30', '2022-01-01 15:15:30', '15');
INSERT INTO `transakcija` VALUES ('28', '5', '2', '40', '2022-01-01 15:15:30', '10');
INSERT INTO `transakcija` VALUES ('29', '6', '1', '20', '2022-01-01 15:15:30', '12');
INSERT INTO `transakcija` VALUES ('30', '6', '1', '20', '2022-01-01 15:15:30', '12');
INSERT INTO `transakcija` VALUES ('31', '6', '2', '70', '2022-01-01 15:15:30', '12');
INSERT INTO `transakcija` VALUES ('32', '6', '1', '10', '2022-01-01 15:15:30', '17');
INSERT INTO `transakcija` VALUES ('33', '6', '2', '40', '2022-01-01 15:15:30', '8');
INSERT INTO `transakcija` VALUES ('34', '6', '2', '20', '2022-01-01 15:15:30', '2');
INSERT INTO `transakcija` VALUES ('35', '6', '1', '20', '2022-01-01 15:15:30', '8');
INSERT INTO `transakcija` VALUES ('36', '7', '1', '20', '2022-01-01 15:15:30', '10');
INSERT INTO `transakcija` VALUES ('37', '7', '1', '20', '2022-01-01 15:15:30', '7');
INSERT INTO `transakcija` VALUES ('38', '7', '2', '40', '2022-01-01 15:15:30', '5');
INSERT INTO `transakcija` VALUES ('39', '7', '1', '10', '2022-01-01 15:15:30', '5');
INSERT INTO `transakcija` VALUES ('40', '7', '2', '20', '2022-01-01 15:15:30', '1');
INSERT INTO `transakcija` VALUES ('41', '7', '2', '100', '2022-01-01 15:15:30', '1');
INSERT INTO `transakcija` VALUES ('42', '7', '1', '20', '2022-01-01 15:15:30', '18');
INSERT INTO `transakcija` VALUES ('43', '7', '1', '20', '2022-01-01 15:15:30', '18');

-- ----------------------------
-- Table structure for `vrstaracuna`
-- ----------------------------
DROP TABLE IF EXISTS `vrstaracuna`;
CREATE TABLE `vrstaracuna` (
  `VrstaRacunaID` int(11) NOT NULL auto_increment,
  `VrstaRacuna` varchar(20) NOT NULL,
  PRIMARY KEY  (`VrstaRacunaID`),
  UNIQUE KEY `VrstaRacuna` (`VrstaRacuna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of vrstaracuna
-- ----------------------------
INSERT INTO `vrstaracuna` VALUES ('2', 'Devizni');
INSERT INTO `vrstaracuna` VALUES ('3', 'Studentski');
INSERT INTO `vrstaracuna` VALUES ('1', 'Tekući');

-- ----------------------------
-- Table structure for `vrstausluge`
-- ----------------------------
DROP TABLE IF EXISTS `vrstausluge`;
CREATE TABLE `vrstausluge` (
  `VrstaUslugeID` int(11) NOT NULL auto_increment,
  `VrstaUsluge` varchar(20) NOT NULL,
  PRIMARY KEY  (`VrstaUslugeID`),
  UNIQUE KEY `VrstaUsluge` (`VrstaUsluge`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of vrstausluge
-- ----------------------------
INSERT INTO `vrstausluge` VALUES ('1', 'Isplata sa računa');
INSERT INTO `vrstausluge` VALUES ('3', 'Transfer');
INSERT INTO `vrstausluge` VALUES ('2', 'Uplata na račun');

-- ----------------------------
-- Table structure for `zanimanje`
-- ----------------------------
DROP TABLE IF EXISTS `zanimanje`;
CREATE TABLE `zanimanje` (
  `ZanimanjeID` int(11) NOT NULL auto_increment,
  `Zanimanje` varchar(50) NOT NULL,
  PRIMARY KEY  (`ZanimanjeID`),
  UNIQUE KEY `Zanimanje` (`Zanimanje`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of zanimanje
-- ----------------------------
INSERT INTO `zanimanje` VALUES ('2', 'Nezaposlen');
INSERT INTO `zanimanje` VALUES ('4', 'Penzioner');
INSERT INTO `zanimanje` VALUES ('3', 'Student');
INSERT INTO `zanimanje` VALUES ('1', 'Zaposlen');
