create database tarefas;

use tarefas;


create table usuario
(
ID int auto_increment primary key,
NOME varchar(150) not null,
EMAIL varchar(250) unique not null,
USUARIO varchar(100) unique not null,
CPF varchar(14) unique not null,
TELEFONE varchar(14) unique not null,
SENHA varchar (100) not null
);


create table cadastrotarefas
(
ID int auto_increment primary key,
DESCRICAO varchar(500) not null,
DATACONCLUSAO datetime not null,
SITUACAO varchar(100) not null,

ID_TAREFA int not null,
foreign key (ID_TAREFA) references usuario (ID)
)


select * from cadastrotarefas;