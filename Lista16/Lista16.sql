create database Lista16
default character set utf8mb4
default collate utf8mb4_unicode_520_ci;

use Lista16;

create table  cadastro
(
id int not null auto_increment primary key,
idFuncionario int  not null,
nome varchar (150) not null,
cpf varchar (11) unique not null,
dataNascimento date,
cargo varchar (150) not null,
setor varchar (100) not null,
salario decimal ( 10,2),
sexo varchar (20)


)
default collate utf8mb4_unicode_520_ci
select * from cadastro;
delete from cadastro where id = 1;