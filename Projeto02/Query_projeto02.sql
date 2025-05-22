create database CadastroJogos;

use CadastroJogos;

create table CadastroUsuario
(
ID int auto_increment primary key,
NOME varchar (250) not null,
EMAIL varchar (500) unique not null,
USUARIO varchar (150) unique not null,
SENHA varchar(150) not null,
CPF varchar (14) unique not null,
TELEFONE varchar(14) unique not null

);

create table CadastroDeJogos
(
ID 	int auto_increment primary key,
	JOGO varchar (500) not null,
    EMPRESA varchar(250) ,
    CATEGORIA varchar (250),
    ESTOQUE int not null,
    VALOR decimal(10,2) not null,
    ID_JOGOS int not null,
    foreign key (ID_JOGOS) references CadastroUsuario(ID)

);

select * from CadastroUsuario;
select*from CadastroDeJogos;
