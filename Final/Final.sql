-- Crear base de datos
create database DB_FINAL;
-- Usar Base de datos
use DB_FINAL;

-- Crear tabla empleado
create table empleado (
	id int identity(1,1) primary key,
	name varchar(50),
	last_name varchar(50),
	email varchar(30),
	phone varchar(30)
);
-- Crear tabla factura
create table factura (
	id int identity(1,1) primary key,
	id_empleado int, 
	cliente varchar(50),
	nit_cliente varchar(20),
	producto varchar(50),
	cantidad int, 
	valor float,
	foreign key (id_empleado) references empleado(id)
);
--Crear procediemiento guardar en empleado
create procedure usp_save_empleado
@name varchar(50),
@last_name varchar(50),
@email varchar(30),
@phone varchar(30)
as 
begin
	insert into empleado (name,last_name,email,phone)
	values (@name,@last_name,@email,@phone);
end
--- crear procedimiento borrar

create procedure usp_delete_empleado
@id int
as 
begin 
	delete from empleado
	where id = @id;
end
---- creaer consultar 
create procedure usp_consultar_empleado
@id int
as 
begin
	select * from empleado
	where id = @id
end 
-- crear actualizar 
create procedure usp_update_empleado
@id int,
@name varchar(50),
@last_name varchar(50),
@email varchar(30),
@phone varchar(30)
as 
begin
	 update empleado set name=@name, last_name=@last_name, email=@email, phone=@phone
	 where id = @id
end
-- crear listar
create procedure usp_listar_empleado
as 
begin
	select * from empleado
end

-- Crear USP facturas

create procedure usp_save_factura
@id_empleado int, 
@cliente varchar(50),
@nit_cliente varchar(20),
@producto varchar(50),
@cantidad int, 
@valor float
as
begin
insert into factura (id_empleado, cliente, nit_cliente, producto, cantidad, valor)
values (@id_empleado, @cliente, @nit_cliente, @producto, @cantidad, @valor);
end

create procedure usp_update_factura
@id int,
@id_empleado int, 
@cliente varchar(50),
@nit_cliente varchar(20),
@producto varchar(50),
@cantidad int, 
@valor float
as
begin
update factura set id_empleado=@id_empleado, cliente=@cliente, nit_cliente=@nit_cliente, producto=@producto, cantidad=@cantidad, valor=@valor where id=@id;
end

create procedure usp_delete_factura
@id int
as
begin
delete from factura where id=@id;
end

create procedure usp_consultar_factura
@id int
as
begin
select * from factura where id=@id;
end

create procedure usp_listar_factura
as
begin
select * from factura;
end
