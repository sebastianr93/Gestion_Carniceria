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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Carnes Rojas'),(2,'Carnes Blancas'),(3,'Embutidos'),(4,'Achuras'),(5,'Congelados'),(6,'Envasados');
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'seba','rodr','3214230','seba@gmail.com','32423534',23950.00),(2,'lucas','perez','23503249','perromamifero@gmail.com','325234',11490.00),(3,'santi','lab','23523509324','santi@gmail.com','325234',0.00),(4,'germish','diaz','325239234','germish@gmail.com','23523432',0.00),(6,'fer','senusnet','235239','fer@gmail.com','23523432',0.00),(7,'fede','papu','31252309','papuneitor@gmail.com','234590823',0.00),(11,'luchete','titilante','23563254','luchete@hola.com','235234',0.00),(12,'lore','spatola','3325','lore@gmail.com','23523',0.00);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itempedido`
--

LOCK TABLES `itempedido` WRITE;
/*!40000 ALTER TABLE `itempedido` DISABLE KEYS */;
INSERT INTO `itempedido` VALUES (1,1,8,80.00,10000.00);
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mediopago`
--

LOCK TABLES `mediopago` WRITE;
/*!40000 ALTER TABLE `mediopago` DISABLE KEYS */;
INSERT INTO `mediopago` VALUES (1,'Efectivo',0),(2,'Naranja X',0),(3,'Tarjeta de Débito',0),(4,'Transferencia Bancaria',0),(6,'Cuenta DNI',-20),(7,'Mercado Pago',10);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,'2025-07-20 00:06:15',800000.00,800000.00,1);
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
INSERT INTO `producto` VALUES (1,'Cuadril','La colita de cuadril, es un corte de carne que proviene de la parte superior del cuarto trasero de la vaca. Es un músculo triangular que se caracteriza por su capa de grasa externa y su textura tierna.',40.00,1,0,7000.00,'Peso'),(2,'Pechuga de Pollo','La pechuga de pollo es una pieza de carne magra y popular, proveniente del pecho del ave. Es conocida por su alto contenido de proteínas y bajo contenido de grasa, lo que la convierte en una opción saludable y versátil en la cocina.',16.00,2,0,5000.00,'Peso'),(3,'Milanesa de Soja (4)','Vianda de cuatro milanesas de soja. Son una alternativa vegetariana a las clásicas milanesas de carne, elaboradas principalmente a base de soja.',0.00,5,1,4000.00,'Unidad'),(4,'Chinchulin','El chinchulín es el intestino delgado del ganado, generalmente de vaca o cordero, se caracteriza por su textura crujiente por fuera y tierna por dentro al cocinarlo a la parrilla.',13.00,4,0,5500.00,'Peso'),(5,'Chorizo','El chorizo es un embutido elaborado con carne picada de cerdo, grasa, pimentón y ajo, que se embute en una tripa natural.',14.00,3,0,7600.00,'Peso'),(6,'Maple de Huevos (30)','Maple de 30 huevos frescos',0.00,6,19,6500.00,'Unidad'),(7,'Vacio','corte de vaca sin hueso',46.00,1,0,12000.00,'Peso'),(8,'Media Res','media res',159.00,1,0,10000.00,'Peso');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (2,'arcor','21312412','arcor@gmail.com','caramelos',43242.00),(3,'ssdf','12312','asfsadf','2342',423.00);
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,'2025-07-14 18:36:19','Efectivo',8000.00,1,6000.00,NULL),(2,'2025-07-14 18:36:59','Efectivo',8000.00,1,0.00,NULL),(3,'2025-07-14 18:38:33','Efectivo',8000.00,1,6000.00,NULL),(4,'2025-07-14 18:39:41','Efectivo',8000.00,1,5000.00,NULL),(5,'2025-07-14 18:49:34','Tarjeta de Crédito',55000.00,4,0.00,NULL),(6,'2025-07-14 19:32:37','Cuenta DNI',53200.00,7,40000.00,NULL),(7,'2025-07-20 00:02:10','Efectivo',48000.00,3,0.00,NULL),(8,'2025-07-20 00:17:14','Mercadopete',322400.00,2,42069.00,NULL),(9,'2025-07-23 16:52:10','Efectivo',10000.00,1,8000.00,NULL),(11,'2025-07-23 19:02:01','Efectivo',8000.00,2,2000.00,0.00),(12,'2025-07-24 18:03:46','Efectivo',8000.00,2,5000.00,0.00),(13,'2025-07-24 18:47:12','Efectivo',12000.00,1,0.00,11950.00),(14,'2025-07-24 18:47:32','Efectivo',12000.00,1,5000.00,5000.00),(15,'2025-07-24 18:47:45','Efectivo',10000.00,1,3000.00,7000.00),(16,'2025-07-24 18:48:02','Efectivo',12000.00,2,4000.00,0.00),(17,'2025-07-24 18:48:15','Efectivo',8000.00,2,3000.00,5000.00),(18,'2025-07-24 18:53:37','Efectivo',6500.00,2,0.00,6490.00);
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
  `Cantidad` int DEFAULT '1',
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
INSERT INTO `ventaproducto` VALUES (4,3,2,4000.00,8000.00),(5,2,11,5000.00,55000.00),(6,5,7,7600.00,53200.00),(7,7,4,12000.00,48000.00),(8,2,30,5000.00,150000.00),(8,4,12,5500.00,66000.00),(8,5,14,7600.00,106400.00),(9,8,1,10000.00,10000.00),(11,3,2,4000.00,8000.00),(12,3,2,4000.00,8000.00),(13,3,3,4000.00,12000.00),(14,3,3,4000.00,12000.00),(15,2,2,5000.00,10000.00),(16,3,3,4000.00,12000.00),(17,3,2,4000.00,8000.00),(18,6,1,6500.00,6500.00);
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

-- Dump completed on 2025-07-25 20:47:47
