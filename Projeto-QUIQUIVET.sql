create database quiquivet;

use quiquivet;

create table cliente(
idCliente int not null primary key auto_increment,
nomeCliente varchar(140),
dtNascimentoCliente date,
cpfCliente varchar(12),
rgCliente varchar(30),
telefoneCliente varchar(13),
emailCliente varchar(50)
);
select * from cliente;

create table funcionario(
idFuncionario int not null primary key auto_increment,
nomeFuncionario varchar(100),
rgFuncionario varchar(30),
cpfFuncionario varchar (12),
login varchar(80),
senha varchar(80)
);

create table consulta(
idConsulta int not null primary key auto_increment,
clienteConsulta varchar (80),
detalhesConsulta varchar(255),
medicoConsulta varchar(80),
precoConsulta int(4),
dtConsulta date
);
select * from consulta;
create table tabelapreco(
idPreco int not null primary key auto_increment,
nomeServico varchar(140),
precoServico int(4),
medicoServico varchar(50)
);
