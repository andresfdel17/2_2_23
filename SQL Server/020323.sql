-- create database DB_universidad;
use DB_universidad;

create table profesor (
	id varchar(15) primary key,
	nombre varchar(40),
	apellido varchar(40),
	salario float
);

create procedure usp_guardarProf
@id varchar(15),
@nombre varchar(40),
@apellido varchar(40),
@salario float
as
begin 
	insert into profesor (id, nombre, apellido, salario)
	values (@id, @nombre, @apellido, @salario)
end

create procedure usp_editarProf
@id varchar(15),
@nombre varchar(40),
@apellido varchar(40),
@salario float
as
begin 
	update profesor set id=@id, nombre=@nombre, apellido=@apellido, salario=@salario where id=@id;
end

create procedure usp_eliminarProf
@id varchar(15)
as
begin 
	delete from profesor where id=@id
end

create procedure usp_select
@id int=0,
@all bit=1
as
if @all = 1
begin
select * from profesor;
end
else
begin
select * from profesor where id=@id;
end

execute usp_select