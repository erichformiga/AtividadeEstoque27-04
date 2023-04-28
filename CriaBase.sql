create database loja;


create table usuarios (
	CodUse INT auto_increment primary key,
	NomeUse VARCHAR(50),
	EmailUse VARCHAR(50),
	SenhaUse VARCHAR(50)
);

create table produtos (
	CodProd INT auto_increment primary key,
	NomeProd VARCHAR(50),
	PrecoProd FLOAT,
	QtdeProd INT
);

create table almoxarifado (
	CodAlx INT auto_increment primary key,
	NomeAlx VARCHAR (55)
);

create table saldo (
	CodSaldo INT auto_increment primary key,
	CodProd INT,
	CodAlx INT,
	QtdeProd INT
);

create table clientes (
	CodCli INT auto_increment primary key,
	NomeCli VARCHAR(255) NOT NULL,
	EmailCli VARCHAR(255) NOT NULL,
	EnderecoCli VARCHAR(255) NOT NULL
);

create table pedidos (
	CodPed INT auto_increment primary key,
	CodCli INT not null,
	CodProd INT not null,
	QtdeProd INT not null,
	DataPed date
);
