create database ControleContatos;

use ControleContatos;


create table usuario
(
ID int auto_increment primary key,

NOME  varchar(150) not null,
EMAIL varchar(250) unique not null,
CPF varchar (14) unique not null,
TEL varchar(14) unique not null,
SENHA varchar(100) not null
);

create table contatos
(
ID int auto_increment primary key,

NOME varchar(150) not null,
TEL varchar(14) not null,
ID_TEL int  not null,

foreign key (ID_TEL) references usuario (ID)

);