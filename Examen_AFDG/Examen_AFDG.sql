create database DB_AFDG;

use DB_AFDG;

create table tabla_AFDG (
	codigo int primary key,
	caracteristica varchar(100)
);

create procedure usp_save_AFDG
@codigo int,
@caracteristica varchar(100)
as
begin
insert into tabla_AFDG (codigo, caracteristica) values (@codigo,@caracteristica);
end

select * from tabla_AFDG;