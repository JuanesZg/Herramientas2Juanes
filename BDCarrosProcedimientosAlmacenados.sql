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
[dbo].[dbo].[]