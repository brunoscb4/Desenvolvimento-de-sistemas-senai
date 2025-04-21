create database Lista15
default character set utf8mb4
default collate utf8mb4_unicode_ci;

use Lista15;

create table if not exists setor(
id int not null auto_increment primary key,
IdUsuario INT NOT NULL,
NomeSetor VARCHAR (150) NOT NULL

)

select * from setor;