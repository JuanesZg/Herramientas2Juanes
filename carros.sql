DROP DATABASE IF EXISTS Carros;
CREATE DATABASE Carros;
USE Carros;

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

/*CONSTRAINTS - FOREIGN KEYS DE RUTA*/
ALTER TABLE ruta ADD CONSTRAINT fk_ruta_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo (id_vehiculo);

/*CONSTRAINTS - FOREIGN KEYS DE VEHICULO*/

/* PROCEDIMIENTOS ALMACENADOS -------------------------------------------------------------------------------------------------------------------------------------------------------------*/

/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create proc registrarTipoVehiculo
(
	@id int, @nombre varchar(100)
)
as insert into tipo_vehiculo values(@id, @nombre);

exec registrarTipoVehiculo 3, 'Avion';

/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/

create proc actualizarTipoVehiculo
(
	@id int, @nombre varchar(100)
)
as update tipo_vehiculo set nombre = @nombre where id_tipo_vehiculo = @id;

exec actualizarTipoVehiculo 3, 'Carro';

/*PROCEDIMIENTO PARA ELIMINAR DATOS*/

create proc eliminarTipoVehiculo
(
	@id int
)
as delete from tipo_vehiculo where id_tipo_vehiculo = @id;

exec eliminarTipoVehiculo 3;

/*PROCEDIMIENTO PARA MOSTRAR DATOS*/

create proc listarTipoVehiculo
as 
SELECT * FROM tipo_vehiculo ORDER BY id_tipo_vehiculo ASC;

exec listarTipoVehiculo;