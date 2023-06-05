DROP DATABASE IF EXISTS Carros;
CREATE DATABASE Carros;
USE Carros;

/*------------------------------------------------------------------------------------CREACIÓN DE TABLAS-----------------------------------------------------------------------------------*/

CREATE TABLE tipo_vehiculo(
	id_tipo_vehiculo INT PRIMARY KEY,
	nombre VARCHAR(100)
);

CREATE TABLE ruta(
	id_ruta INT PRIMARY KEY,
	estacion VARCHAR(255),
	id_vehiculo INT
);

CREATE TABLE vehiculo(
	id_vehiculo INT PRIMARY KEY,
	marca VARCHAR(255),
	modelo VARCHAR(255),
	matricula VARCHAR(255),
	anio INT,
	id_tipo_vehiculo INT
);

CREATE TABLE contrato(
	id_contrato INT PRIMARY KEY,
	id_vehiculo INT,
	id_conductor INT
);

CREATE TABLE conductor(
	id_conductor INT PRIMARY KEY,
	nombre VARCHAR(255),
	tipo_licencia VARCHAR(255),
	id_vehiculo INT,
	id_tipo_conductor INT
);

CREATE TABLE tipo_conductor(
	id_tipo_conductor INT PRIMARY KEY,
	nombre VARCHAR(255)
);

/* --------------------------------------------------------------------------------CONSTRAINTS - FOREIGN KEYS------------------------------------------------------------------------------*/

/*CONSTRAINTS - FOREIGN KEYS DE RUTA*/
ALTER TABLE ruta ADD CONSTRAINT fk_ruta_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo (id_vehiculo);

/*CONSTRAINTS - FOREIGN KEYS DE VEHICULO*/

ALTER TABLE vehiculo ADD CONSTRAINT fk_vehiculo_tipo_vehiculo FOREIGN KEY (id_tipo_vehiculo) REFERENCES tipo_vehiculo (id_tipo_vehiculo);

/*CONSTRAINTS - FOREIGN KEYS DE CONTRATO*/

ALTER TABLE contrato ADD CONSTRAINT fk_contrato_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo (id_vehiculo);

ALTER TABLE contrato ADD CONSTRAINT fk_contrato_conductor FOREIGN KEY (id_conductor) REFERENCES conductor (id_conductor);

/*CONSTRAINTS - FOREIGN KEYS DE CONDUCTOR*/

ALTER TABLE conductor ADD CONSTRAINT fk_conductor_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo (id_vehiculo);

ALTER TABLE conductor ADD CONSTRAINT fk_conductor_tipo_conductor FOREIGN KEY (id_tipo_conductor) REFERENCES tipo_conductor (id_tipo_conductor);

