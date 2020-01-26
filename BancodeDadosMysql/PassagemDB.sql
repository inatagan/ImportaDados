-- MySQL Script generated by MySQL Workbench
-- Sáb 22 Out 2016 20:28:50 BRST
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema PassagemDB
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `passagemdb` ;

-- -----------------------------------------------------
-- Schema passagemdb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `passagemdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `passagemdb` ;

-- -----------------------------------------------------
-- Table `passagemdb`.`passagem`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `passagemdb`.`passagem` ;

CREATE TABLE IF NOT EXISTS `passagemdb`.`passagem` (
  `placa` VARCHAR(32) NOT NULL AUTO_INCREMENT,
  `data` VARCHAR(32),
  `hora` VARCHAR(32),
  `equipamento` VARCHAR(32),
  `faixa` VARCHAR(32),
  PRIMARY KEY (`placa`))
ENGINE = InnoDB;