-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 19 Mai 2016 à 03:32
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `plebquest`
--

-- --------------------------------------------------------

--
-- Structure de la table `available_mobs`
--

CREATE TABLE IF NOT EXISTS `available_mobs` (
  `mob_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `mob_id_available_idx` (`mob_id`),
  KEY `region_id_available_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `available_quests`
--

CREATE TABLE IF NOT EXISTS `available_quests` (
  `quest_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`quest_id`,`region_id`),
  KEY `region_id_available_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `boots`
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
-- Déclencheurs `boots`
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
-- Structure de la table `buffs`
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
-- Déclencheurs `buffs`
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
-- Structure de la table `characters`
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
-- Déclencheurs `characters`
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
-- Structure de la table `chests`
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
-- Déclencheurs `chests`
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
-- Structure de la table `classes`
--

CREATE TABLE IF NOT EXISTS `classes` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_classes_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déclencheurs `classes`
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
-- Structure de la table `equipments`
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
-- Déclencheurs `equipments`
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
-- Structure de la table `heads`
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
-- Déclencheurs `heads`
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
-- Structure de la table `inventories`
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
-- Déclencheurs `inventories`
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
-- Structure de la table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) CHARACTER SET utf8 NOT NULL,
  `gold_value` int(10) unsigned NOT NULL,
  `weight` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déclencheurs `items`
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
-- Structure de la table `mobs`
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
-- Déclencheurs `mobs`
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
-- Structure de la table `mob_drops`
--

CREATE TABLE IF NOT EXISTS `mob_drops` (
  `mob_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `mob_id_idx` (`mob_id`),
  KEY `item_id_mob_drops_idx` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `pants`
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
-- Déclencheurs `pants`
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
-- Structure de la table `quests`
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
-- Déclencheurs `quests`
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
-- Structure de la table `races`
--

CREATE TABLE IF NOT EXISTS `races` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `stats_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stats_id_races_idx` (`stats_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déclencheurs `races`
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
-- Structure de la table `regions`
--

CREATE TABLE IF NOT EXISTS `regions` (
  `id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déclencheurs `regions`
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
-- Structure de la table `sold_items`
--

CREATE TABLE IF NOT EXISTS `sold_items` (
  `item_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `region_id` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  KEY `item_id_sold_idx` (`item_id`),
  KEY `region_id_sold_idx` (`region_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `speels`
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
-- Déclencheurs `speels`
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
-- Structure de la table `stats`
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
-- Déclencheurs `stats`
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
-- Structure de la table `users`
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
-- Déclencheurs `users`
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
-- Structure de la table `weapons`
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
-- Déclencheurs `weapons`
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
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `available_mobs`
--
ALTER TABLE `available_mobs`
  ADD CONSTRAINT `mob_id_available` FOREIGN KEY (`mob_id`) REFERENCES `mobs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `region_id_available_mobs` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `available_quests`
--
ALTER TABLE `available_quests`
  ADD CONSTRAINT `quest_id_available` FOREIGN KEY (`quest_id`) REFERENCES `quests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `region_id_available` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `boots`
--
ALTER TABLE `boots`
  ADD CONSTRAINT `required_stats_id_boots` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_boots` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `buffs`
--
ALTER TABLE `buffs`
  ADD CONSTRAINT `stats_id_buffs` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `characters`
--
ALTER TABLE `characters`
  ADD CONSTRAINT ` equipement_id` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `class_id` FOREIGN KEY (`class_id`) REFERENCES `classes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `race_id` FOREIGN KEY (`race_id`) REFERENCES `races` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `chests`
--
ALTER TABLE `chests`
  ADD CONSTRAINT `required_stats_id_chest` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_chest` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `stats_id_classes` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `equipments`
--
ALTER TABLE `equipments`
  ADD CONSTRAINT `boots_id_equipments` FOREIGN KEY (`boots_id`) REFERENCES `boots` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `chest_id_equipments` FOREIGN KEY (`chest_id`) REFERENCES `chests` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `head_id_equipments` FOREIGN KEY (`head_id`) REFERENCES `heads` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `pants_id_equipments` FOREIGN KEY (`pants_id`) REFERENCES `pants` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `heads`
--
ALTER TABLE `heads`
  ADD CONSTRAINT `required_stats_id_heads` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_heads` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `inventories`
--
ALTER TABLE `inventories`
  ADD CONSTRAINT `character_id_inventories` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `item_id_inventories` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `mobs`
--
ALTER TABLE `mobs`
  ADD CONSTRAINT `stats_id_mobs` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `mob_drops`
--
ALTER TABLE `mob_drops`
  ADD CONSTRAINT `item_id_mob_drops` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `mob_id_mob_drops` FOREIGN KEY (`mob_id`) REFERENCES `mobs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `pants`
--
ALTER TABLE `pants`
  ADD CONSTRAINT `required_stats_id_pants` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_pants` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `races`
--
ALTER TABLE `races`
  ADD CONSTRAINT `stats_id_races` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `sold_items`
--
ALTER TABLE `sold_items`
  ADD CONSTRAINT `item_id_sold` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `region_id_sold` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `speels`
--
ALTER TABLE `speels`
  ADD CONSTRAINT `required_stats_id` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `charater_id_users` FOREIGN KEY (`character_id`) REFERENCES `characters` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `weapons`
--
ALTER TABLE `weapons`
  ADD CONSTRAINT `required_stats_id_weapons` FOREIGN KEY (`required_stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `stats_id_weapons` FOREIGN KEY (`stats_id`) REFERENCES `stats` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
