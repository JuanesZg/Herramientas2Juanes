/*-------------------------------------------------------------------------PROCEDIMIENTOS ALMACENADOS--------------------------------------------------------------------------------------*/

/*----------------------------------------------------------------------PROCEDIMIENTOS DE LA TABLA TIPO VEHICULO---------------------------------------------------------------------------*/
/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create procedure registrarTipoVehiculo (@id int, @nombre varchar(100)) as insert into tipo_vehiculo values(@id, @nombre);

/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/
create procedure actualizarTipoVehiculo (@id int, @nombre varchar(100)) as update tipo_vehiculo set nombre = @nombre where id_tipo_vehiculo = @id;

/*PROCEDIMIENTO PARA ELIMINAR DATOS*/
create procedure eliminarTipoVehiculo (@id int) as delete from tipo_vehiculo where id_tipo_vehiculo = @id;

/*PROCEDIMIENTO PARA MOSTRAR DATOS*/
create procedure listarTipoVehiculo as SELECT * FROM tipo_vehiculo ORDER BY id_tipo_vehiculo ASC;

/* EXECUTES DE LOS PROCEDIMIENTOS PARA TIPO DE VEHICULOS
exec registrarTipoVehiculo 3, 'Moto';
exec actualizarTipoVehiculo 3, 'Carro';
exec eliminarTipoVehiculo 3;
exec listarTipoVehiculo;
*/

/*----------------------------------------------------------------------PROCEDIMIENTOS DE LA TABLA TIPO CONDUCTOR--------------------------------------------------------------------------*/
/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create proc registrarTipoConductor (@id int, @nombre varchar(100)) as insert into tipo_conductor values(@id, @nombre);

/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/
create proc actualizarTipoConductor (@id int, @nombre varchar(100)) as update tipo_conductor set nombre = @nombre where id_tipo_conductor = @id;

/*PROCEDIMIENTO PARA ELIMINAR DATOS*/
create proc eliminarTipoConductor (@id int) as delete from tipo_conductor where id_tipo_conductor = @id;

/*PROCEDIMIENTO PARA MOSTRAR DATOS*/
create proc listarTipoConductor as SELECT * FROM tipo_conductor ORDER BY id_tipo_conductor ASC;

/* EXECUTES DE LOS PROCEDIMIENTOS PARA TIPO DE CONDUCTORES
exec registrarTipoConductor 3, 'Juanes';
exec actualizarTipoConductor 3, 'Juancho';
exec eliminarTipoConductor 3;
exec listarTipoConductor;
*/

/*----------------------------------------------------------------------PROCEDIMIENTOS DE LA TABLA VEHICULO---------------------------------------------------------------------------*/
/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create proc registrarVehiculo (@id int, @marca varchar(100), @modelo varchar(100), @matricula varchar(100), @anio int, @tipovehiculo int)
as
insert into vehiculo values(@id, @marca, @modelo, @matricula, @anio, @tipovehiculo);
--exec registrarVehiculo 1, 'Mazda', 'Bolita', 'ABC123', 2019, 1;

/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/
create proc actualizarVehiculo (@id int, @marca varchar(100), @modelo varchar(100), @matricula varchar(100), @anio int, @tipovehiculo int)
as
update vehiculo set marca = @marca, modelo = @modelo, matricula = @matricula, anio = @anio, id_tipo_vehiculo = @tipovehiculo where id_vehiculo = @id;
--exec actualizarVehiculo 1, 'BMW', 'X3', 'CBA321', 2023, 1;

/*PROCEDIMIENTO PARA ELIMINAR DATOS*/
create proc eliminarVehiculo (@id int) 
as 
delete from vehiculo where id_vehiculo = @id;
--exec eliminarVehiculo 1;

/*PROCEDIMIENTO PARA MOSTRAR DATOS*/
create proc listarVehiculo as SELECT * FROM vehiculo ORDER BY id_vehiculo ASC;
--exec listarVehiculo;

/*----------------------------------------------------------------------PROCEDIMIENTOS DE LA TABLA RUTA---------------------------------------------------------------------------*/
/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create proc registrarRuta (@id int, @estacion varchar(100), @vehiculo int) as insert into ruta values(@id, @estacion, @vehiculo);
--exec registrarRuta 1, 'Parque Berrío', 2;

/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/
create proc actualizarRuta (@id int, @estacion varchar(100), @vehiculo varchar(100)) as update ruta set estacion = @estacion, id_vehiculo = @vehiculo where id_ruta = @id;
--exec actualizarRuta 1, 'Poblado', 2;

/*PROCEDIMIENTO PARA ELIMINAR DATOS*/
create proc eliminarRuta (@id int) as delete from ruta where id_ruta = @id;
--exec eliminarRuta 1;

/*PROCEDIMIENTO PARA MOSTRAR DATOS*/
create proc listarRuta as SELECT * FROM ruta ORDER BY id_ruta ASC;
--exec listarRuta;

/*----------------------------------------------------------------------PROCEDIMIENTOS DE LA TABLA CONDUCTOR---------------------------------------------------------------------------*/
/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create proc registrarConductor (@id int, @nombre varchar(100), @tipolicencia varchar(100), @idvehiculo int, @idtipocondu int)
as
insert into conductor values(@id, @nombre, @tipolicencia, @idvehiculo, @idtipocondu);
--exec registrarConductor 1, 'Marcos', 'Moto', 1, 1;

/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/
create proc actualizarConductor (@id int, @nombre varchar(100), @tipolicencia varchar(100), @idvehiculo int, @idtipocondu int)
as
update conductor set nombre = @nombre, tipo_licencia = @tipolicencia, id_vehiculo = @idvehiculo, id_tipo_conductor = @idtipocondu where id_conductor = @id;
--exec actualizarConductor 3, 'Diego', 'Carro', 2, 2;

/*PROCEDIMIENTO PARA ELIMINAR DATOS*/
create proc eliminarConductor (@id int) 
as 
delete from conductor where id_conductor = @id;
--exec eliminarConductor 2;

/*PROCEDIMIENTO PARA MOSTRAR DATOS*/
create proc listarConductor as SELECT * FROM conductor ORDER BY id_conductor ASC;
--exec listarConductor;

/*----------------------------------------------------------------------PROCEDIMIENTOS DE LA TABLA CONTRATO---------------------------------------------------------------------------*/
/*PROCEDIMIENTO PARA INSERTAR DATOS*/
create proc registrarContrato (@id int, @idvehi int, @idcondu int) as insert into contrato values(@id, @idvehi, @idcondu);
--exec registrarContrato 1, 1, 1; 
/*PROCEDIMIENTO PARA ACTUALIZAR DATOS*/
create proc actualizarContrato (@id int, @idvehi int, @idcondu int) as update contrato set id_vehiculo = @idvehi, id_conductor = @idcondu where id_contrato = @id;
--exec actualizarContrato 1, 2, 1;
/*PROCEDIMIENTO PARA ELIMINAR DATOS*/
create proc eliminarContrato (@id int) as delete from contrato where id_contrato = @id;
--exec eliminarContrato 1;
/*PROCEDIMIENTO PARA MOSTRAR DATOS*/
create proc listarContrato as SELECT * FROM contrato ORDER BY id_contrato ASC;
--exec listarContrato;
