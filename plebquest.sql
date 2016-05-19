-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2016 at 02:21 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `plebquest`
--

-- --------------------------------------------------------

--
-- Table structure for table `available_mobs`
--

CREATE TABLE IF NOT EXISTS `available_mobs` (
  `mob_id` int(11) NOT NULL,
  `region_id` int(11) NOT NULL,
  KEY `mob_id_available_idx` (`mob_id`),
  KEY `region_id_available_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `available_quests`
--

CREATE TABLE IF NOT EXISTS `available_quests` (
  `quest_id` int(11) NOT NULL,
  `region_id` int(11) NOT NULL,
  PRIMARY KEY (`quest_id`,`region_id`),
  KEY `region_id_available_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `boots`
--

CREATE TABLE IF NOT EXISTS `boots` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  `required_stats_id` int(11) NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `buffs`
--

CREATE TABLE IF NOT EXISTS `buffs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  `hp_change` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_buffs_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `characters`
--

CREATE TABLE IF NOT EXISTS `characters` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `current_hp` int(11) unsigned NOT NULL,
  `gender` tinyint(4) NOT NULL,
  `age` time NOT NULL,
  `level` int(10) unsigned NOT NULL,
  `current_exp` int(10) unsigned NOT NULL,
  `stats_id` int(11) NOT NULL,
  `alignement` int(11) NOT NULL,
  `is_cheater` tinyint(4) NOT NULL,
  `gold` int(10) unsigned NOT NULL,
  `class_id` int(11) NOT NULL,
  `race_id` int(11) NOT NULL,
  `equipment_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `class_id_idx` (`class_id`),
  KEY `race_id_idx` (`race_id`),
  KEY ` equipement_id_idx` (`equipment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `chests`
--

CREATE TABLE IF NOT EXISTS `chests` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  `required_stats_id` int(11) NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE IF NOT EXISTS `classes` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_classes_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `equipments`
--

CREATE TABLE IF NOT EXISTS `equipments` (
  `id` int(11) NOT NULL,
  `head_id` int(11) DEFAULT NULL,
  `chest_id` int(11) DEFAULT NULL,
  `pants_id` int(11) DEFAULT NULL,
  `boots_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `head_id_equipments_idx` (`head_id`),
  KEY `chest_id_equipements_idx` (`chest_id`),
  KEY `pants_id_equipments_idx` (`pants_id`),
  KEY `boots_id_equipments_idx` (`boots_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `heads`
--

CREATE TABLE IF NOT EXISTS `heads` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  `required_stats_id` int(11) NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_heads_idx` (`stats_id`),
  KEY `required_stats_id_heads_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `inventories`
--

CREATE TABLE IF NOT EXISTS `inventories` (
  `id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `character_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `item_id_inventories_idx` (`item_id`),
  KEY `character_id_inventories_idx` (`character_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `id` int(11) NOT NULL,
  `name` varchar(250) CHARACTER SET utf8 NOT NULL,
  `gold_value` int(10) unsigned NOT NULL,
  `weight` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `mobs`
--

CREATE TABLE IF NOT EXISTS `mobs` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `hp` int(10) unsigned NOT NULL,
  `level` int(10) unsigned NOT NULL,
  `base_exp` int(10) unsigned NOT NULL,
  `base_gold` int(10) unsigned NOT NULL,
  `stats_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_mobs_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `mob_drops`
--

CREATE TABLE IF NOT EXISTS `mob_drops` (
  `id` int(11) NOT NULL,
  `mob_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `mob_id_idx` (`mob_id`),
  KEY `item_id_mob_drops_idx` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pants`
--

CREATE TABLE IF NOT EXISTS `pants` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  `required_stats_id` int(11) NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_pants_idx` (`stats_id`),
  KEY `required_stats_id_pants_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `quests`
--

CREATE TABLE IF NOT EXISTS `quests` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` int(11) NOT NULL,
  `gold_reward` int(10) unsigned NOT NULL,
  `exp_reward` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `races`
--

CREATE TABLE IF NOT EXISTS `races` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_races_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `regions`
--

CREATE TABLE IF NOT EXISTS `regions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `sold_items`
--

CREATE TABLE IF NOT EXISTS `sold_items` (
  `item_id` int(11) NOT NULL,
  `region_id` int(11) NOT NULL,
  KEY `item_id_sold_idx` (`item_id`),
  KEY `region_id_sold_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `speels`
--

CREATE TABLE IF NOT EXISTS `speels` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` int(11) NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `heal` int(11) NOT NULL,
  `damage` int(11) NOT NULL,
  `buff_id` int(11) DEFAULT NULL,
  `debuff_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `stats`
--

CREATE TABLE IF NOT EXISTS `stats` (
  `id` int(11) NOT NULL,
  `strength` int(11) NOT NULL,
  `intellect` int(11) NOT NULL,
  `constitution` int(11) NOT NULL,
  `dexterity` int(11) NOT NULL,
  `wisdom` int(11) NOT NULL,
  `charisma` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `character_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `charater_id_users_idx` (`character_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `weapons`
--

CREATE TABLE IF NOT EXISTS `weapons` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `damage` int(11) NOT NULL,
  `stats_id` int(11) NOT NULL,
  `required_stats_id` int(11) NOT NULL,
  `required_lvl` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_weapons_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `available_mobs`
--
ALTER TABLE `available_mobs`
  ADD CONSTRAINT `mob_id_available` FOREIGN KEY (`mob_id`) REFERENCES `mobs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `region_id_available_mobs` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `available_quests`
--
ALTER TABLE `available_quests`
  ADD CONSTRAINT `quest_id_available` FOREIGN KEY (`quest_id`) REFERENCES `quests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `region_id_available` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `boots`
--
ALTER TABLE `boots`
  ADD CONSTRAINT `required_stats_id_boots` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_boots` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `buffs`
--
ALTER TABLE `buffs`
  ADD CONSTRAINT `stats_id_buffs` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `characters`
--
ALTER TABLE `characters`
  ADD CONSTRAINT ` equipement_id` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `class_id` FOREIGN KEY (`class_id`) REFERENCES `classes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `race_id` FOREIGN KEY (`race_id`) REFERENCES `races` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `chests`
--
ALTER TABLE `chests`
  ADD CONSTRAINT `required_stats_id_chest` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_chest` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `stats_id_classes` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `equipments`
--
ALTER TABLE `equipments`
  ADD CONSTRAINT `boots_id_equipments` FOREIGN KEY (`boots_id`) REFERENCES `boots` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `chest_id_equipments` FOREIGN KEY (`chest_id`) REFERENCES `chests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `head_id_equipments` FOREIGN KEY (`head_id`) REFERENCES `heads` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `pants_id_equipments` FOREIGN KEY (`pants_id`) REFERENCES `pants` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `heads`
--
ALTER TABLE `heads`
  ADD CONSTRAINT `required_stats_id_heads` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_heads` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `inventories`
--
ALTER TABLE `inventories`
  ADD CONSTRAINT `character_id_inventories` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `item_id_inventories` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `mobs`
--
ALTER TABLE `mobs`
  ADD CONSTRAINT `stats_id_mobs` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `mob_drops`
--
ALTER TABLE `mob_drops`
  ADD CONSTRAINT `item_id_mob_drops` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `mob_id_mob_drops` FOREIGN KEY (`mob_id`) REFERENCES `mobs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `pants`
--
ALTER TABLE `pants`
  ADD CONSTRAINT `required_stats_id_pants` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_pants` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `races`
--
ALTER TABLE `races`
  ADD CONSTRAINT `stats_id_races` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `sold_items`
--
ALTER TABLE `sold_items`
  ADD CONSTRAINT `item_id_sold` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `region_id_sold` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `speels`
--
ALTER TABLE `speels`
  ADD CONSTRAINT `required_stats_id` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `charater_id_users` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `weapons`
--
ALTER TABLE `weapons`
  ADD CONSTRAINT `required_stats_id_weapons` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_weapons` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
