-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: hotels
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `authorization`
--

DROP TABLE IF EXISTS `authorization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authorization` (
  `id_login` int NOT NULL AUTO_INCREMENT,
  `Login` varchar(10) NOT NULL,
  `Parol` varchar(10) NOT NULL,
  PRIMARY KEY (`id_login`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorization`
--

LOCK TABLES `authorization` WRITE;
/*!40000 ALTER TABLE `authorization` DISABLE KEYS */;
INSERT INTO `authorization` VALUES (1,'1111','1111'),(2,'3333','3333');
/*!40000 ALTER TABLE `authorization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lives`
--

DROP TABLE IF EXISTS `lives`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lives` (
  `id_live` int NOT NULL AUTO_INCREMENT,
  `fio` varchar(100) NOT NULL,
  PRIMARY KEY (`id_live`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lives`
--

LOCK TABLES `lives` WRITE;
/*!40000 ALTER TABLE `lives` DISABLE KEYS */;
INSERT INTO `lives` VALUES (1,'Волков Максим Леонидович'),(2,'Окунев Геннадий Евгеньевич'),(3,'Тараканова Анна Николаевна'),(4,'Воробьев Павел Анатольевич'),(5,'Николаев Николай Николаевич'),(6,'Волгин Юрий Андреевич'),(7,'Жукова Наталья Борисовна'),(8,'Петухова Лидия Ивановна'),(9,'Белов Иван Дмитриевич'),(10,'Галкин Виктор Викторович'),(11,'Окулова Елена Витальевна'),(12,'Яковлев Захар Егорович'),(14,'Огурцов Олег Вениаминович'),(15,'Белкина Марина Юльевна'),(16,'Зверев Анрей Валерьевич'),(17,'Лебедева Наталья Владимировна'),(19,'Мухина Дарья Андреевна');
/*!40000 ALTER TABLE `lives` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `position`
--

DROP TABLE IF EXISTS `position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `position` (
  `id_position` int NOT NULL AUTO_INCREMENT,
  `name_position` varchar(20) NOT NULL,
  PRIMARY KEY (`id_position`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `position`
--

LOCK TABLES `position` WRITE;
/*!40000 ALTER TABLE `position` DISABLE KEYS */;
INSERT INTO `position` VALUES (1,'Директор'),(2,'Управляющий'),(3,'Администратор'),(4,'Зам. директора'),(5,'Зам. управляющего'),(6,'Горничная'),(7,'Сантехник'),(8,'Дворник'),(9,'Электрик'),(10,'Охранник'),(11,'Повар');
/*!40000 ALTER TABLE `position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reg`
--

DROP TABLE IF EXISTS `reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reg` (
  `id_reg` int NOT NULL AUTO_INCREMENT,
  `who_live` int NOT NULL,
  `who_write` int NOT NULL,
  `when_in` varchar(10) NOT NULL,
  `when_out` varchar(10) NOT NULL,
  `id_room` int NOT NULL,
  PRIMARY KEY (`id_reg`),
  KEY `FK_Reg_Lives` (`who_live`),
  KEY `FK_Reg_Workers` (`who_write`),
  KEY `FK_Reg_Rooms` (`id_room`),
  CONSTRAINT `FK_Reg_Lives` FOREIGN KEY (`who_live`) REFERENCES `lives` (`id_live`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Reg_Rooms` FOREIGN KEY (`id_room`) REFERENCES `rooms` (`id_room`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Reg_Workers` FOREIGN KEY (`who_write`) REFERENCES `workers` (`id_worker`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reg`
--

LOCK TABLES `reg` WRITE;
/*!40000 ALTER TABLE `reg` DISABLE KEYS */;
INSERT INTO `reg` VALUES (1,1,1,'2022-09-01','2022-09-03',1),(2,2,2,'2022-09-02','2022-09-05',2),(3,3,3,'2022-09-03','2022-09-07',3),(4,4,4,'2022-09-05','2022-09-07',5),(5,5,5,'2022-09-02','2022-09-07',6),(6,6,1,'2022-09-07','2022-09-10',21),(7,7,2,'2022-09-10','2022-09-12',10),(8,8,3,'2022-09-12','2022-09-15',12),(9,9,4,'2022-09-12','2022-09-17',11),(10,10,5,'2022-09-11','2022-09-16',15),(11,11,1,'2022-09-10','2022-09-20',18),(12,12,2,'2022-09-15','2022-09-19',21),(13,1,1,'2022-09-20','2022-09-25',4),(14,2,2,'2022-09-21','2022-09-24',7),(15,3,3,'2022-09-27','2022-10-01',9),(16,5,5,'2022-09-30','2022-10-03',14),(17,6,1,'2022-10-01','2022-10-05',17),(18,7,2,'2022-10-03','2022-10-04',2),(19,8,3,'2022-10-05','2022-10-06',5),(20,8,3,'2022-10-05','2022-10-06',9),(21,9,4,'2022-10-12','2022-10-18',1),(22,10,5,'2022-10-04','2022-10-10',3),(23,11,1,'2022-10-03','2022-10-10',4),(24,12,2,'2022-10-12','2022-10-18',14),(25,14,4,'2022-10-15','2022-10-15',12),(26,8,2,'2022-10-16','2022-10-16',16),(28,3,2,'2022-10-17','2022-10-20',17),(30,15,3,'2022-10-15','2022-10-20',5),(31,17,5,'2022-10-17','2022-10-24',12),(33,3,2,'2022-10-19','2022-10-25',1),(34,4,6,'2022-10-19','2022-10-22',14);
/*!40000 ALTER TABLE `reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rooms` (
  `id_room` int NOT NULL AUTO_INCREMENT,
  `num_room` varchar(3) NOT NULL,
  `floor_room` int NOT NULL,
  PRIMARY KEY (`id_room`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
INSERT INTO `rooms` VALUES (1,'11',1),(2,'12',1),(3,'13',1),(4,'14',1),(5,'15',1),(6,'16',1),(7,'17',1),(8,'21',2),(9,'22',2),(10,'23',2),(11,'24',2),(12,'25',2),(13,'26',2),(14,'27',2),(15,'31',3),(16,'32',3),(17,'33',3),(18,'34',3),(19,'35',3),(20,'36',3),(21,'37',3),(22,'18',1);
/*!40000 ALTER TABLE `rooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workers`
--

DROP TABLE IF EXISTS `workers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workers` (
  `id_worker` int NOT NULL AUTO_INCREMENT,
  `fio` varchar(100) NOT NULL,
  `id_position` int NOT NULL,
  PRIMARY KEY (`id_worker`),
  KEY `FK_Workers_Position` (`id_position`),
  CONSTRAINT `FK_Workers_Position` FOREIGN KEY (`id_position`) REFERENCES `position` (`id_position`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workers`
--

LOCK TABLES `workers` WRITE;
/*!40000 ALTER TABLE `workers` DISABLE KEYS */;
INSERT INTO `workers` VALUES (1,'Галкин Максим Викторович ',1),(2,'Петрова Ольга Викторовна',2),(3,'Васильева Мария Александровна',3),(4,'Александров Александр Александрович',4),(5,'Федоров Владислав Олегович',5),(6,'Муромцев Илья Борисович',3),(7,'Самойлов Никита Дмитриевич',9),(8,'Дмитриев Дмитрий Дмитриевич',11),(9,'Савельева Татьяна Павловна',3);
/*!40000 ALTER TABLE `workers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-19 17:11:12
