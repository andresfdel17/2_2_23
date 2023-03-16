create database DB_TIENDA;

use DB_TIENDA;

create table producto (
	idP varchar(15) primary key,
	nombre varchar(40),
	caracteristica varchar(100),
	precio float,
	cantidad int
);

create procedure usp_save_product
@idP varchar(15),
@nombre varchar(40),
@caracteristica varchar(100),
@precio float,
@cantidad int
as
begin
insert into producto (idP, nombre, caracteristica, precio, cantidad) values (@idP, @nombre, @caracteristica, @precio, @cantidad);
end

create procedure usp_update_product
@idP varchar(15),
@nombre varchar(40),
@caracteristica varchar(100),
@precio float,
@cantidad int
as
begin
update producto set idP=@idP, nombre=@nombre, caracteristica=@caracteristica, precio=@precio, cantidad=@cantidad;
end

create procedure usp_delete_product
@idP varchar(15)
as
begin
delete from producto where idP=@idP;
end

create procedure usp_get_product
@idP varchar(15) = 0,
@all bit = 1
as
if @all = 1
begin
select * from producto;
end
else
begin
select * from producto where idP=@idP;
end
