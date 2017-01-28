
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: plebquest
-- ------------------------------------------------------
-- Server version	5.7.14

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
-- Table structure for table `available_mobs`
--

DROP TABLE IF EXISTS `available_mobs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `available_mobs` (
  `mob_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `mob_id_available_idx` (`mob_id`),
  KEY `region_id_available_idx` (`region_id`),
  CONSTRAINT `mob_id_available` FOREIGN KEY (`mob_id`) REFERENCES `mobs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `region_id_available_mobs` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `available_mobs`
--

LOCK TABLES `available_mobs` WRITE;
/*!40000 ALTER TABLE `available_mobs` DISABLE KEYS */;
/*!40000 ALTER TABLE `available_mobs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `available_quests`
--

DROP TABLE IF EXISTS `available_quests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `available_quests` (
  `quest_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`quest_id`,`region_id`),
  KEY `region_id_available_idx` (`region_id`),
  CONSTRAINT `quest_id_available` FOREIGN KEY (`quest_id`) REFERENCES `quests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `region_id_available` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `available_quests`
--

LOCK TABLES `available_quests` WRITE;
/*!40000 ALTER TABLE `available_quests` DISABLE KEYS */;
/*!40000 ALTER TABLE `available_quests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `available_speels`
--

DROP TABLE IF EXISTS `available_speels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `available_speels` (
  `class_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `speel_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `class_id_available_idx` (`class_id`),
  KEY `speel_id_available_idx` (`speel_id`),
  CONSTRAINT `class_id_available` FOREIGN KEY (`class_id`) REFERENCES `classes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `speel_id_available` FOREIGN KEY (`speel_id`) REFERENCES `speels` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `available_speels`
--

LOCK TABLES `available_speels` WRITE;
/*!40000 ALTER TABLE `available_speels` DISABLE KEYS */;
/*!40000 ALTER TABLE `available_speels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boots`
--

DROP TABLE IF EXISTS `boots`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `boots` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`),
  CONSTRAINT `required_stats_id_boots` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stats_id_boots` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boots`
--

LOCK TABLES `boots` WRITE;
/*!40000 ALTER TABLE `boots` DISABLE KEYS */;
INSERT INTO `boots` VALUES ('58bb841f-301d-11e6-9352-002564e986a2','boots','2c21bb81-1e2b-11e6-8b61-002564e986a2','2c21bb81-1e2b-11e6-8b61-002564e986a2',1,0);
/*!40000 ALTER TABLE `boots` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `buffs`
--

DROP TABLE IF EXISTS `buffs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `buffs` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `hp_change` int(11) NOT NULL,
  `mana_change` int(11) NOT NULL,
  `nb_turn` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_buffs_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buffs`
--

LOCK TABLES `buffs` WRITE;
/*!40000 ALTER TABLE `buffs` DISABLE KEYS */;
INSERT INTO `buffs` VALUES ('b5d8be68-4888-11e6-b679-002564e986a2','test','2c21bb81-1e2b-11e6-8b61-002564e986a2',3,0,10),('c0324595-4888-11e6-b679-002564e986a2','bad test','2c21bb81-1e2b-11e6-8b61-002564e986a2',-5,-20,12);
/*!40000 ALTER TABLE `buffs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `characters`
--

DROP TABLE IF EXISTS `characters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `characters` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `current_hp` int(11) unsigned NOT NULL,
  `gender` tinyint(4) NOT NULL,
  `age` time NOT NULL,
  `level` int(10) unsigned NOT NULL,
  `current_exp` int(10) unsigned NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `alignement` int(11) NOT NULL,
  `is_cheater` tinyint(4) NOT NULL,
  `gold` int(10) unsigned NOT NULL,
  `class_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `race_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `equipment_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `current_mp` int(11) unsigned NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `current_quest_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `class_id_idx` (`class_id`),
  KEY `race_id_idx` (`race_id`),
  KEY ` equipement_id_idx` (`equipment_id`),
  KEY `region_id_character_idx` (`region_id`),
  CONSTRAINT ` equipement_id` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `class_id` FOREIGN KEY (`class_id`) REFERENCES `classes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `race_id` FOREIGN KEY (`race_id`) REFERENCES `races` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `region_id_character` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `characters`
--

LOCK TABLES `characters` WRITE;
/*!40000 ALTER TABLE `characters` DISABLE KEYS */;
INSERT INTO `characters` VALUES ('ebbb0cb8-301d-11e6-9352-002564e986a2','roger',100,0,'00:00:45',1,0,'2c21bb81-1e2b-11e6-8b61-002564e986a2',0,0,0,'38f362c5-1e21-11e6-8056-c86000bd4895','0adfe9b7-1e2b-11e6-8b61-002564e986a2','85410e59-301d-11e6-9352-002564e986a2',100,'ae6e7aa3-301d-11e6-9352-002564e986a2',NULL);
/*!40000 ALTER TABLE `characters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chests`
--

DROP TABLE IF EXISTS `chests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chests` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`),
  CONSTRAINT `required_stats_id_chest` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stats_id_chest` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chests`
--

LOCK TABLES `chests` WRITE;
/*!40000 ALTER TABLE `chests` DISABLE KEYS */;
INSERT INTO `chests` VALUES ('617ba35c-301d-11e6-9352-002564e986a2','chest','2c21bb81-1e2b-11e6-8b61-002564e986a2','2c21bb81-1e2b-11e6-8b61-002564e986a2',1,1);
/*!40000 ALTER TABLE `chests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classes` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_classes_idx` (`stats_id`),
  CONSTRAINT `stats_id_classes` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` VALUES ('12ef3381-1e22-11e6-8056-c86000bd4895','Ritualist','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('12ef3b31-1e22-11e6-8056-c86000bd4895','Guardian','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f35921-1e21-11e6-8056-c86000bd4895','Paladin','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f362c5-1e21-11e6-8056-c86000bd4895','Voodoo Doctor','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f369cb-1e21-11e6-8056-c86000bd4895','Monk','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3b6c9-1e21-11e6-8056-c86000bd4895','Illusioner','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3bc27-1e21-11e6-8056-c86000bd4895','Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3c043-1e21-11e6-8056-c86000bd4895','Mason','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3c4ac-1e21-11e6-8056-c86000bd4895','Fighter','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3c99a-1e21-11e6-8056-c86000bd4895','Thief','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3cf91-1e21-11e6-8056-c86000bd4895','Runemaster','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3d358-1e21-11e6-8056-c86000bd4895','Hunter','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3d6ce-1e21-11e6-8056-c86000bd4895','Mime','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3da09-1e21-11e6-8056-c86000bd4895','Lunatic','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3dd48-1e21-11e6-8056-c86000bd4895','Birdmaster','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3e077-1e21-11e6-8056-c86000bd4895','Vermineer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3e3a7-1e21-11e6-8056-c86000bd4895','Black Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3e6d7-1e21-11e6-8056-c86000bd4895','Dark Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3ea0f-1e21-11e6-8056-c86000bd4895','Onion Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3ed42-1e21-11e6-8056-c86000bd4895','Dragoon Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3f068-1e21-11e6-8056-c86000bd4895','Holy Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3f3af-1e21-11e6-8056-c86000bd4895','Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3f6e8-1e21-11e6-8056-c86000bd4895','Warlock','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3fa0f-1e21-11e6-8056-c86000bd4895','Wizard','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f3fd96-1e21-11e6-8056-c86000bd4895','Priest','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f400c3-1e21-11e6-8056-c86000bd4895','White Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f403f2-1e21-11e6-8056-c86000bd4895','Red Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f4071c-1e21-11e6-8056-c86000bd4895','Blue Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f40a80-1e21-11e6-8056-c86000bd4895','Green Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f40da7-1e21-11e6-8056-c86000bd4895','Black Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f410d7-1e21-11e6-8056-c86000bd4895','Rogue','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f41415-1e21-11e6-8056-c86000bd4895','Death Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f41751-1e21-11e6-8056-c86000bd4895','Shaman','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f41a75-1e21-11e6-8056-c86000bd4895','Druid','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f41da4-1e21-11e6-8056-c86000bd4895','Arcanist','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f420c8-1e21-11e6-8056-c86000bd4895','Assassin','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f423fb-1e21-11e6-8056-c86000bd4895','Artificer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f4271f-1e21-11e6-8056-c86000bd4895','BattleMage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f42a6c-1e21-11e6-8056-c86000bd4895','WarMage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f42d92-1e21-11e6-8056-c86000bd4895','Beastmaster','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f430bf-1e21-11e6-8056-c86000bd4895','Berserker','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f433e6-1e21-11e6-8056-c86000bd4895','Blade Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f43727-1e21-11e6-8056-c86000bd4895','Blade Dancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f43d43-1e21-11e6-8056-c86000bd4895','Blood Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f4426a-1e21-11e6-8056-c86000bd4895','Chronomancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f44747-1e21-11e6-8056-c86000bd4895','Necromancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f44c24-1e21-11e6-8056-c86000bd4895','Dancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f450fc-1e21-11e6-8056-c86000bd4895','Flame Dancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f455d9-1e21-11e6-8056-c86000bd4895','Demonlord','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f45941-1e21-11e6-8056-c86000bd4895','Demon Hunter','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f45c76-1e21-11e6-8056-c86000bd4895','Dragon Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f46353-1e21-11e6-8056-c86000bd4895','Lancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f4687a-1e21-11e6-8056-c86000bd4895','Gunner','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f46d5d-1e21-11e6-8056-c86000bd4895','Mesmer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f47203-1e21-11e6-8056-c86000bd4895','Pirate','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f47b97-1e21-11e6-8056-c86000bd4895','Ranger','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f4814d-1e21-11e6-8056-c86000bd4895','Runepriest','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f485f0-1e21-11e6-8056-c86000bd4895','Sun Knight','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f48b22-1e21-11e6-8056-c86000bd4895','Reaper','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('38f490b2-1e21-11e6-8056-c86000bd4895','Windwalker','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a72c67-1e21-11e6-8056-c86000bd4895','Ninja','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a73642-1e21-11e6-8056-c86000bd4895','Samurai','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a73cbc-1e21-11e6-8056-c86000bd4895','Time Mage','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a744dd-1e21-11e6-8056-c86000bd4895','Singer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a74c49-1e21-11e6-8056-c86000bd4895','Bard','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a75306-1e21-11e6-8056-c86000bd4895','Astromancer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a75a4c-1e21-11e6-8056-c86000bd4895','Gladiator','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('a6a76005-1e21-11e6-8056-c86000bd4895','Archer','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895'),('df43cc2a-1e21-11e6-8056-c86000bd4895','Witch Doctor','Placeholder Baker','32b5ab10-1e1f-11e6-8056-c86000bd4895');
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `completed_quests`
--

DROP TABLE IF EXISTS `completed_quests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `completed_quests` (
  `quest_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `character_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `quest_id_current_idx` (`quest_id`),
  KEY `character_id_current_idx` (`character_id`),
  CONSTRAINT `character_id_current` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `quest_id_current` FOREIGN KEY (`quest_id`) REFERENCES `quests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `completed_quests`
--

LOCK TABLES `completed_quests` WRITE;
/*!40000 ALTER TABLE `completed_quests` DISABLE KEYS */;
/*!40000 ALTER TABLE `completed_quests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipments`
--

DROP TABLE IF EXISTS `equipments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipments` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `head_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `chest_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pants_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `boots_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `head_id_equipments_idx` (`head_id`),
  KEY `chest_id_equipements_idx` (`chest_id`),
  KEY `pants_id_equipments_idx` (`pants_id`),
  KEY `boots_id_equipments_idx` (`boots_id`),
  CONSTRAINT `boots_id_equipments` FOREIGN KEY (`boots_id`) REFERENCES `boots` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `chest_id_equipments` FOREIGN KEY (`chest_id`) REFERENCES `chests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `head_id_equipments` FOREIGN KEY (`head_id`) REFERENCES `heads` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pants_id_equipments` FOREIGN KEY (`pants_id`) REFERENCES `pants` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipments`
--

LOCK TABLES `equipments` WRITE;
/*!40000 ALTER TABLE `equipments` DISABLE KEYS */;
INSERT INTO `equipments` VALUES ('85410e59-301d-11e6-9352-002564e986a2','48f583d8-301d-11e6-9352-002564e986a2','617ba35c-301d-11e6-9352-002564e986a2','6c413404-301d-11e6-9352-002564e986a2','58bb841f-301d-11e6-9352-002564e986a2');
/*!40000 ALTER TABLE `equipments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `heads`
--

DROP TABLE IF EXISTS `heads`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `heads` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_heads_idx` (`stats_id`),
  KEY `required_stats_id_heads_idx` (`required_stats_id`),
  CONSTRAINT `required_stats_id_heads` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stats_id_heads` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `heads`
--

LOCK TABLES `heads` WRITE;
/*!40000 ALTER TABLE `heads` DISABLE KEYS */;
INSERT INTO `heads` VALUES ('48f583d8-301d-11e6-9352-002564e986a2','head','2c21bb81-1e2b-11e6-8b61-002564e986a2','2c21bb81-1e2b-11e6-8b61-002564e986a2',1,0);
/*!40000 ALTER TABLE `heads` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventories`
--

DROP TABLE IF EXISTS `inventories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventories` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `character_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `item_id_inventories_idx` (`item_id`),
  KEY `character_id_inventories_idx` (`character_id`),
  CONSTRAINT `character_id_inventories` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `item_id_inventories` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventories`
--

LOCK TABLES `inventories` WRITE;
/*!40000 ALTER TABLE `inventories` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `items` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) CHARACTER SET utf8 NOT NULL,
  `gold_value` int(10) unsigned NOT NULL,
  `weight` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES ('0fe7f238-1e24-11e6-8056-c86000bd4895','Goblin ear',10,1),('2bb96553-1e2b-11e6-8b61-002564e986a2','Goblin ear',10,1);
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mob_drops`
--

DROP TABLE IF EXISTS `mob_drops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mob_drops` (
  `mob_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `mob_id_idx` (`mob_id`),
  KEY `item_id_mob_drops_idx` (`item_id`),
  CONSTRAINT `item_id_mob_drops` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `mob_id_mob_drops` FOREIGN KEY (`mob_id`) REFERENCES `mobs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mob_drops`
--

LOCK TABLES `mob_drops` WRITE;
/*!40000 ALTER TABLE `mob_drops` DISABLE KEYS */;
/*!40000 ALTER TABLE `mob_drops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mobs`
--

DROP TABLE IF EXISTS `mobs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mobs` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `hp` int(10) unsigned NOT NULL,
  `level` int(10) unsigned NOT NULL,
  `base_exp` int(10) unsigned NOT NULL,
  `base_gold` int(10) unsigned NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_mobs_idx` (`stats_id`),
  CONSTRAINT `stats_id_mobs` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mobs`
--

LOCK TABLES `mobs` WRITE;
/*!40000 ALTER TABLE `mobs` DISABLE KEYS */;
/*!40000 ALTER TABLE `mobs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pants`
--

DROP TABLE IF EXISTS `pants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pants` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_pants_idx` (`stats_id`),
  KEY `required_stats_id_pants_idx` (`required_stats_id`),
  CONSTRAINT `required_stats_id_pants` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stats_id_pants` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pants`
--

LOCK TABLES `pants` WRITE;
/*!40000 ALTER TABLE `pants` DISABLE KEYS */;
INSERT INTO `pants` VALUES ('6c413404-301d-11e6-9352-002564e986a2','pants','2c21bb81-1e2b-11e6-8b61-002564e986a2','2c21bb81-1e2b-11e6-8b61-002564e986a2',1,1);
/*!40000 ALTER TABLE `pants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quests`
--

DROP TABLE IF EXISTS `quests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `quests` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `gold_reward` int(10) unsigned NOT NULL,
  `exp_reward` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quests`
--

LOCK TABLES `quests` WRITE;
/*!40000 ALTER TABLE `quests` DISABLE KEYS */;
/*!40000 ALTER TABLE `quests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `races`
--

DROP TABLE IF EXISTS `races`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `races` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_races_idx` (`stats_id`),
  CONSTRAINT `stats_id_races` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `races`
--

LOCK TABLES `races` WRITE;
/*!40000 ALTER TABLE `races` DISABLE KEYS */;
INSERT INTO `races` VALUES ('00049c15-1e2d-11e6-8b61-002564e986a2','Halfling','32b5ab10-1e1f-11e6-8056-c86000bd4895','Shortfolk is a broad term which comprises halflings, hobbits, and kenders, three races of humanoids who have similar origins. Of the three, halflings are the ones who most closely resemble humans, looking a bit like stocky human children. Halflings are a genial race who delight in practical jokes, especially when the butt of a joke is a human or elf. Halflings will often travel with bands of humans or elves, where they function as scouts. Their adventurous spirits and good humor make them excell'),('0adfd3f2-1e2b-11e6-8b61-002564e986a2','Giant','32b5ab10-1e1f-11e6-8056-c86000bd4895','Giants are the largest of the humanoids, and in many ways, the most repulsive. Giants tend to live in patriarchal communities, with the dominant male serving as a chieftain. Giants tend to practice poor hygiene, and most other races find them repulsive. Giants are incredibly strong, and highly resiliant, able to withstand blows that would kill an ox. Giants are completely devoid of any cleverness, however, so they are incapable of practicing magic in any form. A giant will learn things moderatel'),('0adfdff6-1e2b-11e6-8b61-002564e986a2','Dwarf','32b5ab10-1e1f-11e6-8056-c86000bd4895','Dwarves are short, foul tempered, greedy, smelly, bearded (even their women) humanoids. They live a long time, long enough to hold grudges against most anything else alive. However, dwarves are also exceedingly brave, and are generally the first to rally against the forces of Chaos. Dwarves make excellent warriors, where their stocky frames make them gritty opponents. Nowhere is a dwarf more intimidating than in the mines and underground corridors he calls home. Dwarves are moderately adept at l'),('0adfe9b7-1e2b-11e6-8b61-002564e986a2','High Elf','32b5ab10-1e1f-11e6-8056-c86000bd4895','High elves are delicate, graceful beings. They are slight in stature, standing somewhat shorter and less stocky than humans. Their hair takes on hues of amber, brown, blonde, and silver. High elves have enormous lifespans, and they tend to distrust any except for their own kind. Considered excessively haughty by most, high elves are actually quite amiable towards those few whom they deem worthy of their company. High elves have a passion for philosophy, and will sometimes continue a debate for d'),('0ae791e5-1e2b-11e6-8b61-002564e986a2','Human','32b5ab10-1e1f-11e6-8056-c86000bd4895','Humans are currently the most common race on the planet. This is not because they have long lifespans, superior health, uncommon wit, or any uncommon ability at magic. Indeed, nothing about humans is extraordinary in any way, making their success a bit of an anomaly. Perhaps it is a practial joke played upon the world by the gods? Humans are versatile creatures, and they learn things quite quickly, unless, of course, they are enrolled in an American public school.'),('0ae79bc0-1e2b-11e6-8b61-002564e986a2','Orc','32b5ab10-1e1f-11e6-8056-c86000bd4895','Orcs are the most prevalent of the blackfolk, due in large part to their rapid rates of reproduction. Orcs typically are found in clan units of from fifty to two hundred orcs. Larger communities of orcs are seldom seen unless a powerful overlord unites them. (Without such an overlord, the rival clans would very quickly begin to squabble, and chaos would result). Orcs stand about one and a half to two meters in height, and their noses resemble the snouts of swine. Orcs traditionally dress in garb'),('12aaf32e-1e2d-11e6-8b61-002564e986a2','Kender','32b5ab10-1e1f-11e6-8056-c86000bd4895','\"As klepto as a Kender,\" is a common saying among any who have spent time among Kender, and indeed this reputation is well deserved. Kender make legendary thieves, and nothing that isn\'t tied down, locked inside a chest, and the chest sat on by an ogre, is safe from the sticky fingers of a Kender. Kender features are more elfin than other shortfolk, suggesting that they have a slightly different genetic heritage. Kender wear their brown or blonde hair tied into intricate topknots. Some would arg'),('24db0df2-1e2d-11e6-8b61-002564e986a2','Tabaxi','32b5ab10-1e1f-11e6-8056-c86000bd4895','The tabaxi (or cat-men, as they are known to most humans) are a race of intelligent feline humanoids which inhabit the far reaches of tropical jungles, avoiding both humans and sapient non humans. They live in small prides of 2-8 members, each pride roaming a large territory and rarely having anything to do with other prides. The cat-men are tall and lithe and move with the smooth easy grace of cats. Their fine fur is tawny and striped with black, in a pattern similar to that of a tiger. They we'),('5ba3501a-1e2e-11e6-8b61-002564e986a2','Half Giants','32b5ab10-1e1f-11e6-8056-c86000bd4895','Half-Giants are big, strong, sturdy, and stupid, and ugly. Since they are ostracized by society, they rarely receive a good education of any standard except in warfare. Half-Giants, being hunted by most fanatical monster-hunters, are born into danger and bigotry, and must fight to survive even at a young age. Their parents usually hate them since most Half-Giants are the product of rape. The term gentle giant rarely applies to Half-Giants because of their short temper and their great anger. They'),('60cea0e5-1e2d-11e6-8b61-002564e986a2','Aryan','32b5ab10-1e1f-11e6-8056-c86000bd4895','the Nordic race was descended from Proto-Aryans who he believed had prehistorically dwelt on the North German Plain and who had ultimately originated from the lost continent of Atlantis. The Nazis declared that the Nordics (now referred to as the Germanic peoples), were the true Aryans (ethnically the closest descendants of the Proto-Indo-Europeans) because they were much less racially mixed with peoples who were \"non-native\" to the European continent, than other Indo-European peoples, such a'),('849d39db-1e2d-11e6-8b61-002564e986a2','Githyanki','32b5ab10-1e1f-11e6-8056-c86000bd4895','Githyanki are an ancient race descended from humans. They are strongly humanoid in appearance, and are approximately of human height but tend to be much more gaunt and long of limb. They have rough, yellow skin and gleaming black eyes that instantly betray their in- humanness. Lime many demihuman races, their ears have sharp points and are serrated at the back. Githyanki are exceptionally wise and intelligent, but slightly less physical than humans. They tend to make excellent spellcasters, alth'),('94af799c-1e2d-11e6-8b61-002564e986a2','Dunadan','32b5ab10-1e1f-11e6-8056-c86000bd4895','The Dunadan are an ancient race, much akin to humans, but commonly larger in stature and with darker complexion. They are heartier and longer lived than humans, but because of their longer lives, few worldly experiences are new to them.'),('a09d1fc9-1e2c-11e6-8b61-002564e986a2','Kitsune','32b5ab10-1e1f-11e6-8056-c86000bd4895','The Kitsune, a race of magical, humanoid foxes, are a paradoxal race. Some are so shy as to never show their face, while others are so social they are almost rude. However, like elves, kitsune are lovers of fine arts and admirers of those that can create it. Preferring entertaining over combat themselves, they are often at the local tavern, the social ones anyway, letting their spectacular illusionary magicks both dazzle and entertain the crowd around them. Another paradoxical fact of this race '),('ab0ac352-1e2d-11e6-8b61-002564e986a2','Kobold','32b5ab10-1e1f-11e6-8056-c86000bd4895','Kobolds are dog-people who stand just over one meter tall on average. Their bodies are covered with mangy fur of brown, black, or grey color. Kobolds have short ears on top of their head that can pivot in almost any direction, giving them excellent directional hearing sense. Kobold society is considered barbaric to many, with cannibalism and cruelty the norm. Kobolds rarely live past the age of thirty under the best of conditions, and the continual infighting and bickering among kobolds usually '),('b5e064ee-1ec1-11e6-8056-c86000bd4895','Snow Elf','32b5ab10-1e1f-11e6-8056-c86000bd4895','Occasionally referred to as Ice Elves are an endangered race of Mer. It is commonly believed that centuries of underground living twisted the race into the blind, merciless Farmer'),('b779a233-1e2c-11e6-8b61-002564e986a2','Gnome','32b5ab10-1e1f-11e6-8056-c86000bd4895','Gnomes are tiny, stout humanoids who resemble short dwarves with round faces, however, unlike dwarves, gnome females do not have beards. Gnomes have a passion for mechanical devices, and will spend long hours constructing progressively more complicated gadgets. Gnomes speak very quickly, and they possess the ability to talk, listen, and gesticulate wildly all at the same time. Gnomes are moderately strong, and will make tolerable fighters, however they they tend to make better clerics and spellc'),('bb7f9b89-1e2e-11e6-8b61-002564e986a2','Merfolk','32b5ab10-1e1f-11e6-8056-c86000bd4895','The merfolk are of both genders. In their appearance please include a valid description of their tails. It can just be ‘the fin is .....(colour)’. And also when you do that include when they can transform into people. Some may only do it at dawn, others at noon, others once a week, others at will.... It’s up to you. They do not have ranks. Their powers are- swimming, control over water.'),('c5c340bb-1e2d-11e6-8b61-002564e986a2','Wood Elf','32b5ab10-1e1f-11e6-8056-c86000bd4895','Wood elves are the rustic cousins of high elves. They prefer to make their homes in deciduous forests where the autumn leaves match the auburn, gold, and brown hues of their hair. A wood elf regards the forest as a spiritual place, and much of their philosophy touches on the balance they observe in nature. Wood elves make excellent rangers and rogues, but they lack the resilience to fight effectively, and generally prefer to disappear into the forest, striking their enemy from afar. Wood elves a'),('c8ce01b7-1e2c-11e6-8b61-002564e986a2','Hobbit','32b5ab10-1e1f-11e6-8056-c86000bd4895','Shortfolk is a broad term which comprises halflings, hobbits, and kenders, three races of humanoids who have similar origins. Hobbits, of the shortfolk, are the least likely to be seen outside their comfortable hovels, preferring instead to tend to their gardens, smoke their fanciful pipes, and discuss matters of petty politics. Hobbits are more plump than halflings, though this doesn\'t stop them from being somewhat more agile. Hobbits who do find the gumption to explore the world often find tha'),('d3031fbb-1e2a-11e6-8b61-002564e986a2','Apeman','32b5ab10-1e1f-11e6-8056-c86000bd4895','Apemen have been called \"the missing link\" by some, however they are actually an ape-like race who have evolved in parallel with humankind. Apemen are very strong, however the lack of an opposing thumb has left them with marginal agility.'),('d4424dda-1e2d-11e6-8b61-002564e986a2','Dark Elf','32b5ab10-1e1f-11e6-8056-c86000bd4895','The dark elves, also know as drow are the dark-skinned, white-haired subterranean cousins of the elves of the sunlit world, whom they split off from many centuries ago to dwell underground. They are most commonly found allied with the Chaos, and they will rarely champion a cause that does not benefit them directly. As such they are disliked by most of the refined races, an antipathy they return in kind. Dark elves make good warriors and excellent thieves, but their real forte is magic, particula'),('e5caf2c5-1e2c-11e6-8b61-002564e986a2','Half Elf','32b5ab10-1e1f-11e6-8056-c86000bd4895','Possessing many of the features of both humans and elves, half elves are a hybrid race. Generally speaking, half elves are decended from wood elf and human parentage, since dark elves and humans are not genetically compatable, and since high elves, though compatable, would consider such a union to be utterly revolting. Half elves are somewhat slighter of build than the average human, though they are as tall as humans. They are often ostracized, not generally welcomed by either elven or human soc'),('f0250b2a-1e2a-11e6-8b61-002564e986a2','Draconian','32b5ab10-1e1f-11e6-8056-c86000bd4895','Draconians are a bipedal race of beings spawned from shapeshifted dragons and humans. The union was not perfect, so the resulting race is exceedingly intelligent, but physically very weak. Draconians make excellent spellcasters, but lack the resiliance to become proper fighters. Their heavy claws and lumbering gaits hamper any attempts at thievery.');
/*!40000 ALTER TABLE `races` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `regions`
--

DROP TABLE IF EXISTS `regions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `regions` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `regions`
--

LOCK TABLES `regions` WRITE;
/*!40000 ALTER TABLE `regions` DISABLE KEYS */;
INSERT INTO `regions` VALUES ('ae6e7aa3-301d-11e6-9352-002564e986a2','Phalaphel','Les falafels ou tamiya sont une spécialité culinaire levantine très répandue au Proche-Orient constituée de boulettes de pois chiches, de fèves, ou des deux, mélangées à diverses épices, et frites dans l\'huile.');
/*!40000 ALTER TABLE `regions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sold_items`
--

DROP TABLE IF EXISTS `sold_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sold_items` (
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `item_id_sold_idx` (`item_id`),
  KEY `region_id_sold_idx` (`region_id`),
  CONSTRAINT `item_id_sold` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `region_id_sold` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sold_items`
--

LOCK TABLES `sold_items` WRITE;
/*!40000 ALTER TABLE `sold_items` DISABLE KEYS */;
/*!40000 ALTER TABLE `sold_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `speelbook`
--

DROP TABLE IF EXISTS `speelbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `speelbook` (
  `character_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `speel_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `speelbook`
--

LOCK TABLES `speelbook` WRITE;
/*!40000 ALTER TABLE `speelbook` DISABLE KEYS */;
INSERT INTO `speelbook` VALUES ('0','0',1),('ebbb0cb8-301d-11e6-9352-002564e986a2','a103bd60-1eef-11e6-8056-c86000bd4895',2);
/*!40000 ALTER TABLE `speelbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `speels`
--

DROP TABLE IF EXISTS `speels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `speels` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `heal` int(11) NOT NULL,
  `damage` int(11) NOT NULL,
  `buff_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `debuff_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mana_usage` int(11) NOT NULL,
  `mana_drain` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `required_stats_id_idx` (`required_stats_id`),
  CONSTRAINT `required_stats_id` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `speels`
--

LOCK TABLES `speels` WRITE;
/*!40000 ALTER TABLE `speels` DISABLE KEYS */;
INSERT INTO `speels` VALUES ('a103bd60-1eef-11e6-8056-c86000bd4895','Right in the Speels','32b5ab10-1e1f-11e6-8056-c86000bd4895',1,1,0,'b5d8be68-4888-11e6-b679-002564e986a2','c0324595-4888-11e6-b679-002564e986a2',1,0);
/*!40000 ALTER TABLE `speels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stats`
--

DROP TABLE IF EXISTS `stats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stats` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `strength` int(11) NOT NULL,
  `intellect` int(11) NOT NULL,
  `constitution` int(11) NOT NULL,
  `dexterity` int(11) NOT NULL,
  `wisdom` int(11) NOT NULL,
  `charisma` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stats`
--

LOCK TABLES `stats` WRITE;
/*!40000 ALTER TABLE `stats` DISABLE KEYS */;
INSERT INTO `stats` VALUES ('2c21bb81-1e2b-11e6-8b61-002564e986a2',0,0,0,0,0,0),('32b5ab10-1e1f-11e6-8056-c86000bd4895',0,0,0,0,0,0);
/*!40000 ALTER TABLE `stats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subclasses`
--

DROP TABLE IF EXISTS `subclasses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subclasses` (
  `character_id` int(11) NOT NULL,
  `class_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subclasses`
--

LOCK TABLES `subclasses` WRITE;
/*!40000 ALTER TABLE `subclasses` DISABLE KEYS */;
/*!40000 ALTER TABLE `subclasses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `username` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `character_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`),
  KEY `charater_id_users_idx` (`character_id`),
  CONSTRAINT `charater_id_users` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('f2f6f7f7-301d-11e6-9352-002564e986a2','test','test','ebbb0cb8-301d-11e6-9352-002564e986a2');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `weapons`
--

DROP TABLE IF EXISTS `weapons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `weapons` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `damage` int(11) NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_weapons_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`),
  CONSTRAINT `required_stats_id_weapons` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stats_id_weapons` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weapons`
--

LOCK TABLES `weapons` WRITE;
/*!40000 ALTER TABLE `weapons` DISABLE KEYS */;
/*!40000 ALTER TABLE `weapons` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-08 22:08:08
