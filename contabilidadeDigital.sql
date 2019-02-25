CREATE DATABASE  IF NOT EXISTS `contabilidadedigital` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `contabilidadedigital`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: contabilidadedigital
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `descontos`
--

DROP TABLE IF EXISTS `descontos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `descontos` (
  `iddescontos` int(11) NOT NULL AUTO_INCREMENT,
  `cod` int(11) NOT NULL,
  `nome_rubrica` varchar(70) NOT NULL,
  `valor_rubrica` double NOT NULL,
  `base_inss` tinyint(1) NOT NULL,
  `id_relatorio` int(11) NOT NULL,
  PRIMARY KEY (`iddescontos`),
  KEY `FK_descontos-relatorio_idx` (`id_relatorio`),
  CONSTRAINT `FK_descontos-relatorio` FOREIGN KEY (`id_relatorio`) REFERENCES `relatorio` (`idrelatorio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `descontos`
--

LOCK TABLES `descontos` WRITE;
/*!40000 ALTER TABLE `descontos` DISABLE KEYS */;
/*!40000 ALTER TABLE `descontos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `outros`
--

DROP TABLE IF EXISTS `outros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `outros` (
  `idoutros` int(11) NOT NULL AUTO_INCREMENT,
  `cod` int(11) NOT NULL,
  `nome_rubrica` varchar(70) NOT NULL,
  `valor_rubrica` double NOT NULL,
  `base_inss` tinyint(1) NOT NULL,
  `id_relatorio` int(11) NOT NULL,
  PRIMARY KEY (`idoutros`),
  KEY `FK_outros-relatorio_idx` (`id_relatorio`),
  CONSTRAINT `FK_outros-relatorio` FOREIGN KEY (`id_relatorio`) REFERENCES `relatorio` (`idrelatorio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `outros`
--

LOCK TABLES `outros` WRITE;
/*!40000 ALTER TABLE `outros` DISABLE KEYS */;
/*!40000 ALTER TABLE `outros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proventos`
--

DROP TABLE IF EXISTS `proventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proventos` (
  `idproventos` int(11) NOT NULL AUTO_INCREMENT,
  `cod` int(11) NOT NULL,
  `nome_rubrica` varchar(70) NOT NULL,
  `valor_rubrica` double NOT NULL,
  `base_inss` tinyint(1) NOT NULL,
  `id_relatorio` int(11) NOT NULL,
  PRIMARY KEY (`idproventos`),
  KEY `FK_proventos-relatorio_idx` (`id_relatorio`),
  CONSTRAINT `FK_proventos-relatorio` FOREIGN KEY (`id_relatorio`) REFERENCES `relatorio` (`idrelatorio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proventos`
--

LOCK TABLES `proventos` WRITE;
/*!40000 ALTER TABLE `proventos` DISABLE KEYS */;
/*!40000 ALTER TABLE `proventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relatorio`
--

DROP TABLE IF EXISTS `relatorio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `relatorio` (
  `idrelatorio` int(11) NOT NULL AUTO_INCREMENT,
  `empresa` varchar(70) NOT NULL,
  `cnpj` varchar(14) NOT NULL,
  `competencia` varchar(45) NOT NULL,
  `total_proventos` double NOT NULL,
  `total_descontos` double NOT NULL,
  `total_outros` double NOT NULL,
  `base_inss` double NOT NULL,
  PRIMARY KEY (`idrelatorio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relatorio`
--

LOCK TABLES `relatorio` WRITE;
/*!40000 ALTER TABLE `relatorio` DISABLE KEYS */;
/*!40000 ALTER TABLE `relatorio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-16  8:13:55
