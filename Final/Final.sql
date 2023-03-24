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
create 