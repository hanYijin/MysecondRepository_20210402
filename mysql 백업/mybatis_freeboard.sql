-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: localhost    Database: mybatis
-- ------------------------------------------------------
-- Server version	8.0.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `freeboard`
--

DROP TABLE IF EXISTS `freeboard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `freeboard` (
  `idx` int NOT NULL AUTO_INCREMENT,
  `title` varchar(45) DEFAULT NULL,
  `pass` varchar(10) DEFAULT NULL,
  `content` text,
  `wdate` datetime DEFAULT NULL,
  `name` varchar(20) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `see` int DEFAULT '0',
  PRIMARY KEY (`idx`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `freeboard`
--

LOCK TABLES `freeboard` WRITE;
/*!40000 ALTER TABLE `freeboard` DISABLE KEYS */;
INSERT INTO `freeboard` VALUES (1,'title','1234','content','2021-06-01 09:37:27','123','email@naver.com',0),(2,'title','1234','content','2021-06-01 11:30:08','123','email@naver.com',0),(3,'title','1234','content','2021-06-01 11:31:24','123','email@naver.com',0),(4,'title','1234','content','2021-06-01 11:53:40','123','email@naver.com',0),(5,'title','1234','content','2021-06-01 11:56:20','123','email@naver.com',0),(6,'title','1234','content','2021-06-01 12:07:31','123','email@naver.com',0),(7,'title','1234','content','2021-06-01 12:07:35','123','email@naver.com',0),(8,'title','1234','content','2021-06-01 12:11:14','123','email@naver.com',0),(9,'title','1234','content','2021-06-01 12:13:33','123','email@naver.com',0),(10,'title','1234','content','2021-06-01 12:18:19','123','email@naver.com',0),(11,NULL,'1234',NULL,'2021-06-01 12:20:12',NULL,NULL,0),(12,NULL,'1234',NULL,'2021-06-01 12:20:45',NULL,NULL,0),(13,NULL,'1234',NULL,'2021-06-01 13:18:46',NULL,NULL,0),(14,NULL,'1234',NULL,'2021-06-07 13:07:23',NULL,NULL,0),(15,NULL,'1234',NULL,'2021-06-07 13:07:44',NULL,NULL,0),(16,NULL,'1234',NULL,'2021-06-07 13:08:27',NULL,NULL,0),(17,NULL,'1234',NULL,'2021-06-15 09:34:07',NULL,NULL,0),(18,NULL,'1234',NULL,'2021-06-15 09:34:34','gksdlwls',NULL,0),(19,NULL,'1234',NULL,'2021-06-15 10:09:13',NULL,NULL,0),(20,NULL,'1234',NULL,'2021-06-15 10:09:19','gksldl',NULL,0),(21,NULL,'1234',NULL,'2021-06-15 10:14:03','gksldl',NULL,0),(22,NULL,'1234',NULL,'2021-06-15 10:14:04','gksldl',NULL,0),(23,NULL,'1234',NULL,'2021-06-15 10:14:33','gksldl',NULL,0);
/*!40000 ALTER TABLE `freeboard` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-15 15:37:15
