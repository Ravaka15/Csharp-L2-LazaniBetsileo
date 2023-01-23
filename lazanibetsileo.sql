-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3309
-- Généré le : ven. 01 avr. 2022 à 21:45
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `lazanibetsileo`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `IdCli` int(4) NOT NULL AUTO_INCREMENT,
  `NomCli` char(30) NOT NULL,
  `PrenomCli` char(40) NOT NULL,
  `AdresseCli` char(40) NOT NULL,
  `TelephoneCli` char(10) DEFAULT NULL,
  `VilleCli` char(20) NOT NULL,
  `CIN` char(12) DEFAULT NULL,
  PRIMARY KEY (`IdCli`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`IdCli`, `NomCli`, `PrenomCli`, `AdresseCli`, `TelephoneCli`, `VilleCli`, `CIN`) VALUES
(1, 'FANOMEZANA', 'Hobisoa', 'Andrainjato', '0342356478', 'Fianarantsoa', '201123543765'),
(2, 'RAKOTO', 'Mamisoa', 'Andrainjato', '0342356343', 'Fianarantsoa', '201545678435'),
(3, 'MIRANTSOA', 'Miray', 'Ambalavao', '0322356343', 'Fianarantsoa', '201234678435'),
(4, 'MITIA', ' Mino', 'Fandrina', '0322356333', 'Fianarantsoa', '204234678435'),
(5, 'AINA', ' Fanambinana', 'Fandrina', '0342696333', 'Fianarantsoa', '204234678321'),
(6, 'RAVAKINIAINA', ' Fanantenana', 'Ambositra', '0341696333', 'Fianarantsoa', NULL),
(7, 'Manantena', ' Fana', 'Antsirabe', '0341696223', 'Antananarivo', NULL),
(8, 'MALALATIANA', 'Minoharisoa', 'Antsirabe', '0341696923', 'Antananarivo', NULL),
(9, 'TOJONIAINA', 'Hasimanjato', 'Antsirabe', '0342696923', 'Antananarivo', NULL),
(10, 'AMBININTSOA', 'Paula', 'Andrainjato', '0346709800', 'Mahajanga', '302890098802');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `IdCom` int(4) NOT NULL AUTO_INCREMENT,
  `QttCom` int(5) NOT NULL,
  `DateCom` date NOT NULL,
  `IdCli` int(4) DEFAULT NULL,
  `Refprod` int(4) DEFAULT NULL,
  PRIMARY KEY (`IdCom`),
  KEY `IdCli` (`IdCli`),
  KEY `Refprod` (`Refprod`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`IdCom`, `QttCom`, `DateCom`, `IdCli`, `Refprod`) VALUES
(1, 5, '2022-01-12', 1, 3001),
(2, 15, '2022-01-02', 3, 2002),
(3, 5, '2022-01-02', 3, 1001),
(4, 5, '2022-01-02', 4, 1001),
(5, 3, '2022-01-03', 10, 1004),
(6, 3, '2022-01-03', 10, 1003),
(7, 10, '2022-01-03', 9, 5001),
(8, 10, '2022-01-03', 7, 5001),
(9, 1, '2022-01-03', 6, 5001),
(10, 1, '2022-01-03', 6, 4001),
(11, 5, '2022-03-17', 6, NULL),
(12, 2, '2022-03-17', 6, NULL),
(13, 9, '2022-03-27', 8, 1001),
(14, 4, '2022-03-27', 8, 4003),
(15, 5, '2022-03-27', 1, 1001),
(16, 5, '2022-03-27', 1, 1001),
(17, 5, '2022-03-27', 1, 1001),
(18, 5, '2022-03-27', 8, 1001),
(19, 15, '2022-03-27', 8, 1002),
(20, 5, '2022-03-27', 8, 1001),
(21, 15, '2022-03-27', 8, 1002),
(22, 5, '2022-03-27', 1, 1003),
(23, 5, '2022-03-27', 1, 1003),
(24, 30, '2022-03-27', 3, 5001),
(25, 5, '2022-03-27', 2, 1003),
(26, 5, '2022-03-27', 2, 1002),
(27, 5, '2022-03-27', 3, 1002),
(28, 5, '2022-03-27', 2, 1003),
(29, 10, '2022-03-27', 2, 4003),
(30, 5, '2022-03-27', 1, 1001),
(31, 5, '2022-03-27', 1, 1001),
(32, 5, '2022-03-27', 1, 1001),
(33, 5, '2022-03-27', 1, 1001),
(34, 5, '2022-03-27', 6, 1003),
(35, 30, '2022-03-27', 6, 1006),
(36, 3, '2022-02-02', 2, 1002);

-- --------------------------------------------------------

--
-- Structure de la table `facture`
--

DROP TABLE IF EXISTS `facture`;
CREATE TABLE IF NOT EXISTS `facture` (
  `IdFact` int(4) NOT NULL,
  `DateFact` date NOT NULL,
  `IdCli` int(4) DEFAULT NULL,
  PRIMARY KEY (`IdFact`),
  KEY `IdCli` (`IdCli`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `facture`
--

INSERT INTO `facture` (`IdFact`, `DateFact`, `IdCli`) VALUES
(1, '2022-01-10', 6),
(2, '2022-01-13', 1),
(3, '2022-01-13', 3),
(4, '2022-01-15', 7),
(5, '2022-01-15', 8),
(6, '2022-01-15', 2),
(7, '2022-01-15', 9),
(8, '2022-01-15', 4),
(9, '2022-01-16', 10),
(10, '2022-01-16', 5);

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `IdFrs` int(4) NOT NULL AUTO_INCREMENT,
  `NomFrs` char(30) NOT NULL,
  `PrenomFrs` char(40) NOT NULL,
  `AdresseFrs` char(40) NOT NULL,
  `TelephoneFrs` char(10) DEFAULT NULL,
  PRIMARY KEY (`IdFrs`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`IdFrs`, `NomFrs`, `PrenomFrs`, `AdresseFrs`, `TelephoneFrs`) VALUES
(1, 'RASOARIMALALA', 'Hoby', 'Tsaramandroso', '0346678907'),
(2, 'RAHARITIANA', 'Minosoa', 'Ambalavao', '0346678957'),
(3, 'ROSE', 'Joseph', 'Ambalavao', '0346678951'),
(4, 'RAZAKAMANANA', 'Tokiniaina', 'Ambalavao', '0346678950'),
(5, 'RAKOTO', 'Felix', 'Ambalavao', '0340678950'),
(6, 'RATSIRAKA', 'Jean Pierre', 'Ambalavao', '0320678950'),
(7, 'FANOMEZANA', 'Michel', 'Ambalavao', '0320698950'),
(8, 'MAMENOTSOA', 'Albert', 'Ambalavao', '0320698900'),
(9, 'MELISSA', 'Andotiana', 'Ambalavao', '0320668900'),
(10, 'RAVAO', 'Mamisoa', 'Ambositra', '0346798709');

-- --------------------------------------------------------

--
-- Structure de la table `livrer`
--

DROP TABLE IF EXISTS `livrer`;
CREATE TABLE IF NOT EXISTS `livrer` (
  `IdLiv` int(4) NOT NULL AUTO_INCREMENT,
  `QttLiv` int(5) NOT NULL,
  `DateLiv` date NOT NULL,
  `IdFrs` int(4) DEFAULT NULL,
  `Refprod` int(4) DEFAULT NULL,
  PRIMARY KEY (`IdLiv`),
  KEY `Refprod` (`Refprod`),
  KEY `IdFrs` (`IdFrs`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `livrer`
--

INSERT INTO `livrer` (`IdLiv`, `QttLiv`, `DateLiv`, `IdFrs`, `Refprod`) VALUES
(1, 60, '2022-02-13', 2, 3001),
(2, 23, '2022-02-03', 2, 1001),
(3, 30, '2022-02-10', 3, 1002),
(4, 40, '2022-02-15', 1, 2002),
(5, 15, '2022-02-15', 1, 2003),
(6, 20, '2022-01-15', 5, 4003),
(7, 30, '2022-01-20', 3, 3002),
(8, 20, '2022-01-20', 4, 5001),
(9, 50, '2022-01-13', 6, 1005),
(10, 30, '2022-01-05', 7, 3002),
(11, 100, '2022-03-27', 3, 1001),
(12, 100, '2022-03-27', 7, 1001),
(13, 100, '2022-03-27', 9, 4003),
(14, 15, '2022-03-27', 9, 4002);

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `Refprod` int(4) NOT NULL AUTO_INCREMENT,
  `Nomprod` char(30) NOT NULL,
  `Typeprod` char(30) NOT NULL,
  `Prixprod` int(10) DEFAULT NULL,
  `Qttprod` int(4) NOT NULL,
  PRIMARY KEY (`Refprod`)
) ENGINE=MyISAM AUTO_INCREMENT=5003 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`Refprod`, `Nomprod`, `Typeprod`, `Prixprod`, `Qttprod`) VALUES
(1001, 'Vin blanc', 'Vin normaux', 11000, 100),
(1002, 'Vin rose', 'Vin normaux', 11000, 12),
(1003, 'Vin gris', 'Vin normaux', 11000, 20),
(1004, 'Vin rouge', 'Vin normaux', 12000, 0),
(1005, 'Vin gris Fhorm', 'Vin normaux', 15000, 30),
(1006, 'Vin rouge prestige', 'Vin normaux', 15000, 30),
(2001, 'Vin blanc special', 'Vin effervescent', 15000, 50),
(2002, 'Vin blanc mousseux', 'Vin effervescent', 30000, 30),
(3001, 'Vin blanc moelleux', 'Vin doux et aromatises', 18000, 40),
(3002, 'Vin aperitif', 'Vin doux et aromatises', 18000, 47),
(3003, 'Vin rouge doux', 'Vin doux et aromatises', 18000, 50),
(4001, 'Liqueur a l orange', 'Produit derive', 20000, 55),
(4002, 'Eau de vie de vin', 'Produit derive', 20000, 70),
(4003, 'Liqueur a la mandarine', 'Produit derive', 20000, 165),
(5001, 'Vin en vrac', 'Vin en vrac en litre', 1500, 100);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
