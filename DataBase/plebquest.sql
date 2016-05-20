-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2016 at 03:13 AM
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
  `mob_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `mob_id_available_idx` (`mob_id`),
  KEY `region_id_available_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `available_quests`
--

CREATE TABLE IF NOT EXISTS `available_quests` (
  `quest_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`quest_id`,`region_id`),
  KEY `region_id_available_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `available_speels`
--

CREATE TABLE IF NOT EXISTS `available_speels` (
  `class_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `speel_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `class_id_available_idx` (`class_id`),
  KEY `speel_id_available_idx` (`speel_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `boots`
--

CREATE TABLE IF NOT EXISTS `boots` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `boots`
--
DROP TRIGGER IF EXISTS `boots_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `boots_BEFORE_INSERT` BEFORE INSERT ON `boots`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `buffs`
--

CREATE TABLE IF NOT EXISTS `buffs` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `hp_change` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_buffs_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `buffs`
--
DROP TRIGGER IF EXISTS `buffs_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `buffs_BEFORE_INSERT` BEFORE INSERT ON `buffs`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `characters`
--

CREATE TABLE IF NOT EXISTS `characters` (
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
  PRIMARY KEY (`id`),
  KEY `class_id_idx` (`class_id`),
  KEY `race_id_idx` (`race_id`),
  KEY ` equipement_id_idx` (`equipment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `characters`
--
DROP TRIGGER IF EXISTS `characters_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `characters_BEFORE_INSERT` BEFORE INSERT ON `characters`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `chests`
--

CREATE TABLE IF NOT EXISTS `chests` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `chests`
--
DROP TRIGGER IF EXISTS `chests_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `chests_BEFORE_INSERT` BEFORE INSERT ON `chests`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE IF NOT EXISTS `classes` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_classes_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`id`, `name`, `description`, `stats_id`) VALUES
('12ef3381-1e22-11e6-8056-c86000bd4895', 'Ritualist', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('12ef3b31-1e22-11e6-8056-c86000bd4895', 'Guardian', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f35921-1e21-11e6-8056-c86000bd4895', 'Paladin', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f362c5-1e21-11e6-8056-c86000bd4895', 'Voodoo Doctor', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f369cb-1e21-11e6-8056-c86000bd4895', 'Monk', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3b6c9-1e21-11e6-8056-c86000bd4895', 'Illusioner', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3bc27-1e21-11e6-8056-c86000bd4895', 'Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3c043-1e21-11e6-8056-c86000bd4895', 'Mason', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3c4ac-1e21-11e6-8056-c86000bd4895', 'Fighter', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3c99a-1e21-11e6-8056-c86000bd4895', 'Thief', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3cf91-1e21-11e6-8056-c86000bd4895', 'Runemaster', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3d358-1e21-11e6-8056-c86000bd4895', 'Hunter', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3d6ce-1e21-11e6-8056-c86000bd4895', 'Mime', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3da09-1e21-11e6-8056-c86000bd4895', 'Lunatic', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3dd48-1e21-11e6-8056-c86000bd4895', 'Birdmaster', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3e077-1e21-11e6-8056-c86000bd4895', 'Vermineer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3e3a7-1e21-11e6-8056-c86000bd4895', 'Black Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3e6d7-1e21-11e6-8056-c86000bd4895', 'Dark Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3ea0f-1e21-11e6-8056-c86000bd4895', 'Onion Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3ed42-1e21-11e6-8056-c86000bd4895', 'Dragoon Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3f068-1e21-11e6-8056-c86000bd4895', 'Holy Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3f3af-1e21-11e6-8056-c86000bd4895', 'Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3f6e8-1e21-11e6-8056-c86000bd4895', 'Warlock', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3fa0f-1e21-11e6-8056-c86000bd4895', 'Wizard', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f3fd96-1e21-11e6-8056-c86000bd4895', 'Priest', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f400c3-1e21-11e6-8056-c86000bd4895', 'White Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f403f2-1e21-11e6-8056-c86000bd4895', 'Red Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f4071c-1e21-11e6-8056-c86000bd4895', 'Blue Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f40a80-1e21-11e6-8056-c86000bd4895', 'Green Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f40da7-1e21-11e6-8056-c86000bd4895', 'Black Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f410d7-1e21-11e6-8056-c86000bd4895', 'Rogue', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f41415-1e21-11e6-8056-c86000bd4895', 'Death Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f41751-1e21-11e6-8056-c86000bd4895', 'Shaman', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f41a75-1e21-11e6-8056-c86000bd4895', 'Druid', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f41da4-1e21-11e6-8056-c86000bd4895', 'Arcanist', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f420c8-1e21-11e6-8056-c86000bd4895', 'Assassin', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f423fb-1e21-11e6-8056-c86000bd4895', 'Artificer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f4271f-1e21-11e6-8056-c86000bd4895', 'BattleMage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f42a6c-1e21-11e6-8056-c86000bd4895', 'WarMage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f42d92-1e21-11e6-8056-c86000bd4895', 'Beastmaster', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f430bf-1e21-11e6-8056-c86000bd4895', 'Berserker', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f433e6-1e21-11e6-8056-c86000bd4895', 'Blade Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f43727-1e21-11e6-8056-c86000bd4895', 'Blade Dancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f43d43-1e21-11e6-8056-c86000bd4895', 'Blood Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f4426a-1e21-11e6-8056-c86000bd4895', 'Chronomancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f44747-1e21-11e6-8056-c86000bd4895', 'Necromancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f44c24-1e21-11e6-8056-c86000bd4895', 'Dancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f450fc-1e21-11e6-8056-c86000bd4895', 'Flame Dancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f455d9-1e21-11e6-8056-c86000bd4895', 'Demonlord', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f45941-1e21-11e6-8056-c86000bd4895', 'Demon Hunter', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f45c76-1e21-11e6-8056-c86000bd4895', 'Dragon Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f46353-1e21-11e6-8056-c86000bd4895', 'Lancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f4687a-1e21-11e6-8056-c86000bd4895', 'Gunner', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f46d5d-1e21-11e6-8056-c86000bd4895', 'Mesmer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f47203-1e21-11e6-8056-c86000bd4895', 'Pirate', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f47b97-1e21-11e6-8056-c86000bd4895', 'Ranger', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f4814d-1e21-11e6-8056-c86000bd4895', 'Runepriest', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f485f0-1e21-11e6-8056-c86000bd4895', 'Sun Knight', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f48b22-1e21-11e6-8056-c86000bd4895', 'Reaper', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('38f490b2-1e21-11e6-8056-c86000bd4895', 'Windwalker', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a72c67-1e21-11e6-8056-c86000bd4895', 'Ninja', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a73642-1e21-11e6-8056-c86000bd4895', 'Samurai', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a73cbc-1e21-11e6-8056-c86000bd4895', 'Time Mage', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a744dd-1e21-11e6-8056-c86000bd4895', 'Singer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a74c49-1e21-11e6-8056-c86000bd4895', 'Bard', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a75306-1e21-11e6-8056-c86000bd4895', 'Astromancer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a75a4c-1e21-11e6-8056-c86000bd4895', 'Gladiator', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('a6a76005-1e21-11e6-8056-c86000bd4895', 'Archer', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895'),
('df43cc2a-1e21-11e6-8056-c86000bd4895', 'Witch Doctor', 'Placeholder Baker', '32b5ab10-1e1f-11e6-8056-c86000bd4895');

--
-- Triggers `classes`
--
DROP TRIGGER IF EXISTS `classes_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `classes_BEFORE_INSERT` BEFORE INSERT ON `classes`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `equipments`
--

CREATE TABLE IF NOT EXISTS `equipments` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `head_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `chest_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pants_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `boots_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `head_id_equipments_idx` (`head_id`),
  KEY `chest_id_equipements_idx` (`chest_id`),
  KEY `pants_id_equipments_idx` (`pants_id`),
  KEY `boots_id_equipments_idx` (`boots_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `equipments`
--
DROP TRIGGER IF EXISTS `equipments_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `equipments_BEFORE_INSERT` BEFORE INSERT ON `equipments`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `heads`
--

CREATE TABLE IF NOT EXISTS `heads` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_heads_idx` (`stats_id`),
  KEY `required_stats_id_heads_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `heads`
--
DROP TRIGGER IF EXISTS `heads_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `heads_BEFORE_INSERT` BEFORE INSERT ON `heads`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `inventories`
--

CREATE TABLE IF NOT EXISTS `inventories` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `character_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `item_id_inventories_idx` (`item_id`),
  KEY `character_id_inventories_idx` (`character_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `inventories`
--
DROP TRIGGER IF EXISTS `inventories_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `inventories_BEFORE_INSERT` BEFORE INSERT ON `inventories`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) CHARACTER SET utf8 NOT NULL,
  `gold_value` int(10) unsigned NOT NULL,
  `weight` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `name`, `gold_value`, `weight`) VALUES
('0fe7f238-1e24-11e6-8056-c86000bd4895', 'Goblin ear', 10, 1);

--
-- Triggers `items`
--
DROP TRIGGER IF EXISTS `items_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `items_BEFORE_INSERT` BEFORE INSERT ON `items`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `mobs`
--

CREATE TABLE IF NOT EXISTS `mobs` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `hp` int(10) unsigned NOT NULL,
  `level` int(10) unsigned NOT NULL,
  `base_exp` int(10) unsigned NOT NULL,
  `base_gold` int(10) unsigned NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_mobs_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `mobs`
--
DROP TRIGGER IF EXISTS `mobs_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `mobs_BEFORE_INSERT` BEFORE INSERT ON `mobs`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `mob_drops`
--

CREATE TABLE IF NOT EXISTS `mob_drops` (
  `mob_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `mob_id_idx` (`mob_id`),
  KEY `item_id_mob_drops_idx` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pants`
--

CREATE TABLE IF NOT EXISTS `pants` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `gold_value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_pants_idx` (`stats_id`),
  KEY `required_stats_id_pants_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `pants`
--
DROP TRIGGER IF EXISTS `pants_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `pants_BEFORE_INSERT` BEFORE INSERT ON `pants`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `quests`
--

CREATE TABLE IF NOT EXISTS `quests` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `gold_reward` int(10) unsigned NOT NULL,
  `exp_reward` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `quests`
--
DROP TRIGGER IF EXISTS `quests_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `quests_BEFORE_INSERT` BEFORE INSERT ON `quests`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `races`
--

CREATE TABLE IF NOT EXISTS `races` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_races_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `races`
--
DROP TRIGGER IF EXISTS `races_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `races_BEFORE_INSERT` BEFORE INSERT ON `races`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `regions`
--

CREATE TABLE IF NOT EXISTS `regions` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `regions`
--
DROP TRIGGER IF EXISTS `regions_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `regions_BEFORE_INSERT` BEFORE INSERT ON `regions`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `sold_items`
--

CREATE TABLE IF NOT EXISTS `sold_items` (
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `item_id_sold_idx` (`item_id`),
  KEY `region_id_sold_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `speels`
--

CREATE TABLE IF NOT EXISTS `speels` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  `heal` int(11) NOT NULL,
  `damage` int(11) NOT NULL,
  `buff_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `debuff_id` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `speels`
--
DROP TRIGGER IF EXISTS `speels_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `speels_BEFORE_INSERT` BEFORE INSERT ON `speels`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `stats`
--

CREATE TABLE IF NOT EXISTS `stats` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `strength` int(11) NOT NULL,
  `intellect` int(11) NOT NULL,
  `constitution` int(11) NOT NULL,
  `dexterity` int(11) NOT NULL,
  `wisdom` int(11) NOT NULL,
  `charisma` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `stats`
--

INSERT INTO `stats` (`id`, `strength`, `intellect`, `constitution`, `dexterity`, `wisdom`, `charisma`) VALUES
('32b5ab10-1e1f-11e6-8056-c86000bd4895', 0, 0, 0, 0, 0, 0);

--
-- Triggers `stats`
--
DROP TRIGGER IF EXISTS `stats_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `stats_BEFORE_INSERT` BEFORE INSERT ON `stats`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `username` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `character_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `charater_id_users_idx` (`character_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `users`
--
DROP TRIGGER IF EXISTS `users_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `users_BEFORE_INSERT` BEFORE INSERT ON `users`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `weapons`
--

CREATE TABLE IF NOT EXISTS `weapons` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `damage` int(11) NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `required_lvl` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_weapons_idx` (`stats_id`),
  KEY `required_stats_id_idx` (`required_stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Triggers `weapons`
--
DROP TRIGGER IF EXISTS `weapons_BEFORE_INSERT`;
DELIMITER //
CREATE TRIGGER `weapons_BEFORE_INSERT` BEFORE INSERT ON `weapons`
 FOR EACH ROW BEGIN
	set NEW.id = UUID();
END
//
DELIMITER ;

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
-- Constraints for table `available_speels`
--
ALTER TABLE `available_speels`
  ADD CONSTRAINT `class_id_available` FOREIGN KEY (`class_id`) REFERENCES `classes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `speel_id_available` FOREIGN KEY (`speel_id`) REFERENCES `speels` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

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
