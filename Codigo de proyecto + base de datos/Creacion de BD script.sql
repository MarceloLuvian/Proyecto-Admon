SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `BFAbogados` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `BFAbogados` ;

-- -----------------------------------------------------
-- Table `BFAbogados`.`Abogado`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `BFAbogados`.`Abogado` (
  `ID_Abogado` INT NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(80) NULL ,
  `TipoAbogado` VARCHAR(20) NULL ,
  `Direccion` VARCHAR(60) NULL ,
  `Correo` VARCHAR(50) NULL ,
  `Telefono` VARCHAR(11) NULL ,
  PRIMARY KEY (`ID_Abogado`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BFAbogados`.`Agenda`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `BFAbogados`.`Agenda` (
  `ID_Agenda` INT NOT NULL AUTO_INCREMENT ,
  `Fecha` VARCHAR(45) NULL ,
  `Descripcion` VARCHAR(45) NULL ,
  `Abogado_ID_Abogado` INT NOT NULL ,
  PRIMARY KEY (`ID_Agenda`) ,
  INDEX `fk_Agenda_Abogado1_idx` (`Abogado_ID_Abogado` ASC) ,
  CONSTRAINT `fk_Agenda_Abogado1`
    FOREIGN KEY (`Abogado_ID_Abogado` )
    REFERENCES `BFAbogados`.`Abogado` (`ID_Abogado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BFAbogados`.`UsuarioAbogado`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `BFAbogados`.`UsuarioAbogado` (
  `ID_Usuario` INT NOT NULL AUTO_INCREMENT ,
  `NombreUsuario` VARCHAR(45) NULL ,
  `Contraseña` VARCHAR(45) NULL ,
  `Abogado_ID_Abogado` INT NOT NULL ,
  PRIMARY KEY (`ID_Usuario`) ,
  INDEX `fk_UsuarioAbogado_Abogado1_idx` (`Abogado_ID_Abogado` ASC) ,
  CONSTRAINT `fk_UsuarioAbogado_Abogado1`
    FOREIGN KEY (`Abogado_ID_Abogado` )
    REFERENCES `BFAbogados`.`Abogado` (`ID_Abogado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BFAbogados`.`Secretaria`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `BFAbogados`.`Secretaria` (
  `ID_Secretaria` INT NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(45) NULL ,
  `Direccion` VARCHAR(45) NULL ,
  `Correo` VARCHAR(45) NULL ,
  `Telefono` VARCHAR(10) NULL ,
  `Abogado_ID_Abogado` INT NOT NULL ,
  PRIMARY KEY (`ID_Secretaria`) ,
  INDEX `fk_Secretaria_Abogado1_idx` (`Abogado_ID_Abogado` ASC) ,
  CONSTRAINT `fk_Secretaria_Abogado1`
    FOREIGN KEY (`Abogado_ID_Abogado` )
    REFERENCES `BFAbogados`.`Abogado` (`ID_Abogado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BFAbogados`.`UsuarioSecretaria`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `BFAbogados`.`UsuarioSecretaria` (
  `ID_Usuario` INT NOT NULL AUTO_INCREMENT ,
  `NombreUsuario` VARCHAR(45) NULL ,
  `Contraseña` VARCHAR(45) NULL ,
  `Secretaria_ID_Secretaria` INT NOT NULL ,
  PRIMARY KEY (`ID_Usuario`) ,
  INDEX `fk_UsuarioSecretaria_Secretaria1_idx` (`Secretaria_ID_Secretaria` ASC) ,
  CONSTRAINT `fk_UsuarioSecretaria_Secretaria1`
    FOREIGN KEY (`Secretaria_ID_Secretaria` )
    REFERENCES `BFAbogados`.`Secretaria` (`ID_Secretaria` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
