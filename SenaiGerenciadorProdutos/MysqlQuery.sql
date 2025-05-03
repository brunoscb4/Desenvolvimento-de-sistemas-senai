create database GerenciadorProdutos
default character set utf8mb4
default collate utf8mb4_unicode_520_ci;

use GerenciadorProdutos;

create table CadastroUsuario
(
id int not null auto_increment primary key,
NOME varchar (150) not null,
EMAIL varchar (200) unique not null,
CPF varchar (11) unique not null,
USUARIO varchar(100) unique not null,
SENHA varchar (20) not null



);

create table CadastroProduto
(
id int not null auto_increment primary key,
PRODUTO varchar (200) not null,
PRECO decimal (10,2) not null,
ESTOQUE int not null,
CATEGORIA varchar (150) not null,
Usuario_id int,
foreign key (Usuario_id) references CadastroUsuario(id)

);

select * from CadastroUsuario;