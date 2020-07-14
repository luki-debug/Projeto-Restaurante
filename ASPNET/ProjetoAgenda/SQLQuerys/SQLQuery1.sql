---- Geração de Modelo físico
---- Sql ANSI 2003 - brModelo.

--CREATE DATABASE BDAgendarCliente
--use BdagendarCliente

--CREATE TABLE Pessoa (
--IdPessoa INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--NomeCompleto VARCHAR(50) NOT NULL,
--Email VARCHAR(40) NOT NULL
--)

--CREATE TABLE Cliente (
--Endereço VARCHAR(100) NOT NULL,
--Telefone NUMERIC(20) NOT NULL,
--Telefone1 NUMERIC(20),
--Telefone2 NUMERIC(20),
--Telefone3 NUMERIC(20),
--Telefone4 NUMERIC(20),
--IdPessoa INT,
--FOREIGN KEY(IdPessoa) REFERENCES Pessoa (IdPessoa)
--)

CREATE TABLE Usuario2 (
nomeUser VARCHAR(30) NOT NULL,
Senha VARCHAR(30) NOT NULL,
IdPessoa INT identity(1,1),
FOREIGN KEY(IdPessoa) REFERENCES Pessoa (IdPessoa)
)

--CREATE TABLE Agenda (
--Data DATETIME,
--IdAgenda NUMERIC(10) PRIMARY KEY,
--IdPessoa INT,
--FOREIGN KEY(IdPessoa) REFERENCES Pessoa (IdPessoa)
--)
--select *from agenda

alter 

CREATE PROCEDURE uspUsuarioInserir
	@NomeCompleto varchar(50),
	@Email varchar(40),
	@nomeUser varchar(30),
	@Senha varchar(30)
AS
BEGIN
	
	INSERT INTO Pessoa
	(
		NomeCompleto,
		Email
	)
	VALUES
	(
		@NomeCompleto,
		@Email
	)
	INSERT INTO Usuario2
	(
		nomeUser,
		Senha
	)
	VALUES
	(
		@nomeUser,
		@Senha
	)
	SELECT @@IDENTITY AS Retorno 
END 
update usuario set IdPessoa=1 where nomeUser='luki'
EXEC uspUsuarioInserir 'Pedro Andrade','Contato@suporte','loki','12345678'
select*from pessoa p inner join Usuario2 u on p.IdPessoa=u.IdPessoa
select*from usuario
--drop database agendamento

--exec uspUsuarioInserir 'Andre Siqueira','contato@contato.com','andre','42083866'

--exec uspUsuarioConsultarPorNome'ucas'

--select*from pessoa p inner join usuario u on p.IdPessoa=u.IdPessoa
--select P.NomeCompleto,u.nomeUser from Usuario u inner join pessoa p on u.IdPessoa=p.IdPessoa






