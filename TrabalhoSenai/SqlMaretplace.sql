create database Marketplace
default character set utf8mb4
default collate utf8mb4_unicode_520_ci;

use Marketplace;

create table CadastroUsuario
(
ID int auto_increment primary key,
NOME varchar(300) not null,
EMAIL varchar(300) unique not null,
CPF varchar (14) unique not null,
USUARIO varchar(100) unique not null,
TELEFONE varchar (14) unique not null,
SENHA varchar (100) not null
);

create table CadastroProduto
(
ID int auto_increment primary key,
PRODUTO varchar(300) not null,
CATEGORIA varchar(100) not null,
ESTOQUE int not null,
CODIGO 	int not null,
VALOR_DA_COMPRA decimal(10,2),
VALOR_DE_VENDA decimal not null,
ID_USUARIO INT not null,
foreign key (ID_USUARIO) references CadastroUsuario(ID)

);



select * from CadastroUsuario;

