-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: localhost    Database: covibbs
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
-- Table structure for table `post`
--

DROP TABLE IF EXISTS `post`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `post` (
  `postID` int NOT NULL,
  `postTitle` varchar(45) DEFAULT NULL,
  `userID` varchar(20) DEFAULT NULL,
  `postDate` datetime DEFAULT NULL,
  `postContent` varchar(5000) DEFAULT NULL,
  `postAvailable` int DEFAULT NULL,
  PRIMARY KEY (`postID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `post`
--

LOCK TABLES `post` WRITE;
/*!40000 ALTER TABLE `post` DISABLE KEYS */;
INSERT INTO `post` VALUES (1,'ffff','han','2021-05-28 11:47:35','글 fffffgfdg내용',0),(2,'안녕하세요! ','han','2021-05-28 11:47:45','글수정해보았습니다^^\r\n오타\r\n줄띄움\r\n모두 완벽!!!\r\n\r\n\r\n\r\nㅇㅇㅇㅇ\r\nㅇㅇㅇ\r\nㅇㅇ\r\nㅇ\r\nㅇㅇ\r\nㅇㅇㅇ\r\nㅇㅇㅇㅇ',0),(3,'안','han','2021-06-02 14:50:03','글 내용',1),(4,'ㅇㅇ','han','2021-06-02 14:51:01','ㅇㅇㅇㅇ',1),(5,'ㅇㅇ','han','2021-06-02 14:52:56',NULL,1),(6,NULL,'han','2021-06-02 14:53:25',NULL,1),(7,'dfdf','han','2021-06-02 15:34:25','글 내용dgffadgafd',1),(8,'dfadf','han','2021-06-02 15:34:43','글 내용agafdgfdsgfdg',1),(9,'ffff','han','2021-06-02 15:34:49','글 내용ff',1),(10,'fff','han','2021-06-02 15:34:55','글 내용fffff',1),(11,'fff','han','2021-06-02 15:35:00','글 내용ffff',0),(12,'fff','han','2021-06-02 15:35:06','글 내용fff',0),(13,'dd','han','2021-06-02 16:09:35','글 내용dddd',1),(14,'dfd','aa','2021-06-02 16:30:40','글 내용dfadfdsfadf',0),(15,'dd','aa','2021-06-03 16:09:33','글 내용dddd',0);
/*!40000 ALTER TABLE `post` ENABLE KEYS */;
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
