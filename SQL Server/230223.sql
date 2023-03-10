use DB_Example;
-- crea tablas
create table estudiante(
	id int identity(1,1) not null primary key,
	name varchar(15),
	apellido varchar(15),
	telefono varchar(15),
	age int
);
-- insertar datos
insert into estudiante (name, apellido, telefono, age) 
values ('Andres', 'Felipe', '3058215370', 27),
('Daniela', 'Manjarres', '1234567891', 18);

select * from estudiante;

-- procedimientos almacenados
create procedure usp_saveEstudiante
	-- parametros o variables
	@name varchar(15),
	@apellido varchar(15),
	@telefono varchar(15),
	@age int
as 
begin
-- procesos
insert into estudiante (name, apellido, telefono, age) 
values (@name, @apellido, @telefono, @age);
end

create procedure usp_updateEstudiante
@id int,
@name varchar(15)
as 
begin
	update estudiante set name=@name where id=@id;
end

create procedure usp_deleteEstudiante
@id int
as 
begin
	delete from estudiante where id=@id;
end

create procedure usp_selectEstudiante
@id int = 0,
@all bit = 1
as 
	if @all = 1
	begin
	select * from estudiante;
	end
	else
	begin
	select * from estudiante where id=@id;
	end

execute usp_deleteEstudiante 1;
execute usp_saveEstudiante 'Marielly','Gutierrez','3136150398',46;
execute usp_updateEstudiante 2,'Danielita';
execute usp_selectEstudiante


-- PRODUCTO

-- codigo
-- nombre
-- caracteristica
-- cantidad
-- valor

-- crear tabla
-- crear registro
-- 