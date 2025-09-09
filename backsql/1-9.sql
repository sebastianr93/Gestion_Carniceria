-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: mibasededatos
-- ------------------------------------------------------
-- Server version	8.0.42

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
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Carnes Rojas'),(2,'Cerdo'),(3,'Embutidos'),(4,'Carnes Blancas'),(5,'Pescados');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Correo` varchar(150) DEFAULT NULL,
  `DNI` varchar(20) DEFAULT NULL,
  `Deuda` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'German','Perez','1152325201','german@gmail.com','203658520',527500.00),(2,'Pedro','Samael','12524101','pedro@hotmail.com','20365201',0.00),(3,'Rodrigo','Sikiuk','12524140','rodri@outlook.com','2025410',50000.00);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itempedido`
--

DROP TABLE IF EXISTS `itempedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `itempedido` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pedido` int NOT NULL,
  `id_producto` int NOT NULL,
  `cantidad` decimal(18,2) NOT NULL,
  `preciounitario` decimal(18,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_pedido` (`id_pedido`),
  KEY `id_producto` (`id_producto`),
  CONSTRAINT `itempedido_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id`),
  CONSTRAINT `itempedido_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itempedido`
--

LOCK TABLES `itempedido` WRITE;
/*!40000 ALTER TABLE `itempedido` DISABLE KEYS */;
INSERT INTO `itempedido` VALUES (1,1,1,34.00,20000.00),(2,1,2,24.00,10000.00),(3,2,5,25.00,3000.00),(4,3,1,2.00,20000.00),(5,4,1,1.00,20000.00),(6,5,3,2.00,15000.00),(7,6,4,3.00,5000.00),(8,7,1,2.00,20000.00),(9,8,4,2.00,5000.00),(10,9,3,3.00,15000.00),(11,10,2,2.00,10000.00),(12,11,2,2.00,10000.00),(13,12,3,2.00,15000.00),(14,13,2,2.00,10000.00),(15,14,2,2.00,10000.00),(16,15,4,1.00,5000.00),(17,16,1,3.00,1000.00),(18,17,1,2.00,1000.00),(19,18,1,2.00,10000.00);
/*!40000 ALTER TABLE `itempedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mediopago`
--

DROP TABLE IF EXISTS `mediopago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mediopago` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `porcentaje_ajuste` int NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `mediopago_chk_1` CHECK ((`porcentaje_ajuste` between -(100) and 100))
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mediopago`
--

LOCK TABLES `mediopago` WRITE;
/*!40000 ALTER TABLE `mediopago` DISABLE KEYS */;
INSERT INTO `mediopago` VALUES (1,'Efectivo',0),(2,'Tarjeta',20);
/*!40000 ALTER TABLE `mediopago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `valortotal` decimal(18,2) NOT NULL,
  `pagoparcial` decimal(18,2) NOT NULL,
  `id_proveedor` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_proveedor` (`id_proveedor`),
  CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,'2025-08-22 18:54:18',920000.00,50000.00,2),(2,'2025-08-22 18:58:19',75000.00,30000.00,3),(3,'2025-09-02 18:17:49',40000.00,40000.00,1),(4,'2025-09-02 18:29:29',20000.00,20000.00,1),(5,'2025-09-02 18:30:21',30000.00,30000.00,1),(6,'2025-09-02 18:31:21',15000.00,15000.00,4),(7,'2025-09-02 18:31:58',40000.00,40000.00,3),(8,'2025-09-02 18:36:34',10000.00,5000.00,3),(9,'2025-09-02 18:36:57',45000.00,20000.00,1),(10,'2025-09-02 18:37:18',20000.00,1000.00,2),(11,'2025-09-02 18:49:32',20000.00,0.00,1),(12,'2025-09-02 18:50:14',30000.00,0.00,4),(13,'2025-09-02 18:51:09',20000.00,0.00,1),(14,'2025-09-02 18:51:28',20000.00,0.00,1),(15,'2025-09-02 18:51:48',5000.00,0.00,1),(16,'2025-09-03 18:59:56',3000.00,0.00,1),(17,'2025-09-03 19:27:13',2000.00,2000.00,1),(18,'2025-09-03 19:41:03',20000.00,20000.00,1);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(150) NOT NULL,
  `Descripcion` text,
  `Peso` decimal(10,2) DEFAULT NULL,
  `CategoriaID` int DEFAULT NULL,
  `Cantidad` int DEFAULT '0',
  `Precio` decimal(10,2) DEFAULT NULL,
  `Tipo` enum('Unidad','Peso') NOT NULL,
  `PrecioCosto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Producto_Categoria` (`CategoriaID`),
  CONSTRAINT `FK_Producto_Categoria` FOREIGN KEY (`CategoriaID`) REFERENCES `categoria` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Lomos','Lomo de vaca',157.00,1,0,20000.00,'Peso',10000.00),(2,'Pechito de Cerdo','Pecho de cerdo',275.50,1,0,10000.00,'Peso',5000.00),(3,'Salamines','salaminos traidos de tandil',0.00,3,56,15000.00,'Unidad',7500.00),(4,'Pollos','Pollos enteros de campo',237.00,5,0,5000.00,'Peso',3000.00),(5,'Patys de pollo','Suprema cortada y preparada de pollo',0.00,4,278,3000.00,'Unidad',2000.00),(7,'prueba','producto de prueba',120.00,1,0,10000.00,'Peso',5000.00),(8,'Riñon','riñon de cerdo',14.00,2,0,5000.00,'Peso',2500.00);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(150) NOT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Correo` varchar(150) DEFAULT NULL,
  `Descripcion` text,
  `CuentaCorriente` decimal(12,2) DEFAULT '0.00',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Mercado Central','20541140','mercado@hotmail.com','Mercado Central de carnes',93000.00),(2,'Distribuidora carnes','20587410','distri@hotmail.com','Distribuidora de carnes',889000.00),(3,'Granja Diaz','15478410','granja@outlook.com','Granja de productos avícolas',50000.00),(4,'Mercado Frutas','12545241','prueba@hotmail.com','mercado de frutas',30000.00);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `FormatoPago` varchar(50) DEFAULT NULL,
  `ValorTotal` decimal(12,2) DEFAULT NULL,
  `ClienteID` int DEFAULT NULL,
  `PagoParcial` decimal(10,2) NOT NULL DEFAULT '0.00',
  `DeudaCompra` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ClienteID` (`ClienteID`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `cliente` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,'2025-08-22 18:53:03','Efectivo',95000.00,1,20000.00,75000.00),(2,'2025-08-24 19:32:56','Efectivo',10000.00,1,5000.00,5000.00),(3,'2025-08-26 17:56:25','Tarjeta',20000.00,1,12000.00,8000.00),(4,'2025-08-26 18:49:32','Efectivo',40000.00,1,0.00,0.00),(5,'2025-08-26 18:52:23','Efectivo',30000.00,2,0.00,0.00),(6,'2025-08-26 18:53:04','Efectivo',30000.00,3,0.00,0.00),(7,'2025-08-26 18:57:05','Efectivo',30000.00,2,0.00,0.00),(8,'2025-08-26 19:35:51','Efectivo',30000.00,2,0.00,0.00),(9,'2025-08-27 18:56:43','Efectivo',30000.00,3,0.00,0.00),(10,'2025-08-27 19:29:07','Efectivo',70000.00,1,20000.00,50000.00),(11,'2025-08-27 19:29:31','Efectivo',15000.00,1,10000.00,5000.00),(12,'2025-08-28 18:52:35','Efectivo',60000.00,1,0.00,0.00),(13,'2025-08-28 18:52:58','Efectivo',95000.00,1,0.00,0.00),(14,'2025-08-28 18:53:07','Efectivo',4000.00,1,0.00,0.00),(15,'2025-08-28 19:06:58','Efectivo',35000.00,1,5000.00,30000.00),(16,'2025-08-28 19:07:29','Efectivo',9000.00,1,1500.00,7500.00),(17,'2025-08-28 19:08:56','Efectivo',30000.00,1,0.00,0.00),(18,'2025-08-28 19:09:03','Efectivo',5000.00,1,0.00,0.00),(19,'2025-08-28 19:17:32','Efectivo',80000.00,1,1000.00,79000.00),(20,'2025-08-28 19:17:46','Efectivo',40000.00,1,0.00,0.00),(21,'2025-08-28 19:19:43','Efectivo',21000.00,1,2000.00,19000.00),(22,'2025-08-28 19:25:31','Efectivo',19000.00,1,0.00,0.00),(23,'2025-08-28 19:25:42','Efectivo',58000.00,1,0.00,0.00),(24,'2025-08-28 19:40:02','Efectivo',83000.00,1,2000.00,81000.00),(25,'2025-08-28 19:40:50','Efectivo',5000.00,1,5000.00,0.00),(26,'2025-08-28 19:41:58','Efectivo',4000.00,1,0.00,0.00),(27,'2025-08-28 19:42:12','Efectivo',20000.00,1,0.00,0.00),(28,'2025-08-28 19:42:53','Efectivo',45000.00,1,1000.00,44000.00),(29,'2025-08-28 19:49:08','Efectivo',4000.00,1,2000.00,2000.00),(30,'2025-08-28 19:52:00','Efectivo',84000.00,1,1000.00,83000.00),(31,'2025-08-28 19:52:59','Efectivo',15000.00,1,1000.00,14000.00),(32,'2025-09-01 18:39:40','Efectivo',50000.00,3,0.00,50000.00),(33,'2025-09-01 18:48:19','Efectivo',30000.00,1,30000.00,0.00),(34,'2025-09-01 18:48:30','Efectivo',50000.00,1,0.00,50000.00),(35,'2025-09-01 18:51:16','Efectivo',30000.00,1,30000.00,0.00),(36,'2025-09-02 19:27:06','Efectivo',20000.00,1,20000.00,0.00);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventaproducto`
--

DROP TABLE IF EXISTS `ventaproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventaproducto` (
  `VentaID` int NOT NULL,
  `ProductoID` int NOT NULL,
  `Cantidad` decimal(10,2) DEFAULT '1.00',
  `PrecioUnitario` decimal(10,2) NOT NULL DEFAULT '0.00',
  `SubTotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`VentaID`,`ProductoID`),
  KEY `ProductoID` (`ProductoID`),
  CONSTRAINT `ventaproducto_ibfk_1` FOREIGN KEY (`VentaID`) REFERENCES `venta` (`ID`) ON DELETE CASCADE,
  CONSTRAINT `ventaproducto_ibfk_2` FOREIGN KEY (`ProductoID`) REFERENCES `producto` (`ID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventaproducto`
--

LOCK TABLES `ventaproducto` WRITE;
/*!40000 ALTER TABLE `ventaproducto` DISABLE KEYS */;
INSERT INTO `ventaproducto` VALUES (1,1,2.00,20000.00,40000.00),(1,2,1.00,10000.00,10000.00),(1,3,3.00,15000.00,45000.00),(2,4,2.00,5000.00,10000.00),(3,2,2.00,10000.00,20000.00),(4,1,2.00,20000.00,40000.00),(5,1,2.00,20000.00,30000.00),(6,1,2.00,20000.00,30000.00),(7,1,2.00,20000.00,30000.00),(8,1,2.00,20000.00,30000.00),(9,5,9.00,3000.00,27000.00),(10,1,2.00,20000.00,40000.00),(10,2,3.00,10000.00,30000.00),(11,2,2.00,10000.00,15000.00),(12,1,3.00,20000.00,60000.00),(13,1,4.00,20000.00,80000.00),(13,4,3.00,5000.00,15000.00),(15,1,1.00,20000.00,20000.00),(15,4,3.00,5000.00,15000.00),(16,4,1.00,5000.00,5000.00),(17,1,1.00,20000.00,20000.00),(17,4,2.00,5000.00,10000.00),(18,4,1.00,5000.00,5000.00),(19,1,2.00,20000.00,40000.00),(19,2,1.00,10000.00,10000.00),(19,3,2.00,15000.00,30000.00),(20,1,2.00,20000.00,40000.00),(21,3,1.00,15000.00,15000.00),(21,5,2.00,3000.00,6000.00),(22,4,2.00,5000.00,10000.00),(22,5,3.00,3000.00,9000.00),(23,3,3.00,15000.00,45000.00),(23,4,2.00,5000.00,10000.00),(23,5,1.00,3000.00,3000.00),(24,1,4.00,20000.00,80000.00),(24,5,1.00,3000.00,3000.00),(25,4,1.00,5000.00,5000.00),(27,1,1.00,20000.00,20000.00),(28,1,2.00,20000.00,40000.00),(28,4,1.00,5000.00,5000.00),(30,1,2.00,20000.00,40000.00),(30,3,2.00,15000.00,30000.00),(30,4,1.00,5000.00,5000.00),(30,5,3.00,3000.00,9000.00),(31,3,1.00,15000.00,15000.00),(32,1,1.00,20000.00,20000.00),(32,3,2.00,15000.00,30000.00),(33,1,2.00,20000.00,30000.00),(34,1,3.00,20000.00,50000.00),(35,1,1.50,20000.00,30000.00),(36,2,2.00,10000.00,20000.00);
/*!40000 ALTER TABLE `ventaproducto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-08 19:08:41
