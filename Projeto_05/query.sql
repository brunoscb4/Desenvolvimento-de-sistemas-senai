create database agenda;

use agenda;


create table usuario
(
ID int auto_increment primary key,
NOME varchar(200) not null,
EMAIL varchar(250) unique not null,
CPF  varchar(14) unique not null,
TELEFONE varchar(14) unique not null,
SENHA varchar(250) not null

);


create table registros
(
ID int auto_increment primary key,
CALENDARIO date not null,
HORA  time ,
DESCRICAO varchar(800) not null,
ID_USER int not null,
foreign key (ID_USER) references usuario(ID)

);

select * from registros;
