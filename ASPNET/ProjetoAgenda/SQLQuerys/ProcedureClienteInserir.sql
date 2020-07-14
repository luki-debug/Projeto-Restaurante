USE [BDagenda]
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 02/06/2020 12:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspClienteInserir]
	@NomeCompleto varchar(50),
	@Email varchar(40),		
	@CPF varchar(15),
	@Endereço varchar(100),
	@Telefone varchar(20),
	@Telefone1 varchar(20)
AS
BEGIN
IF @Email=(select email from Pessoa where Email=@Email) 
		print 'Erro! Email já existe';
ELSE
	IF @CPF=(select CPF from Cliente where CPF=@CPF)
		print 'Erro! CPF já Cadastrado';
	ELSE
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
			DECLARE @IdPessoa int;
			SET @IdPessoa=@@IDENTITY;
			INSERT INTO Cliente
		(
			CPF,
			Endereço,
			Telefone,
			Telefone1,
			IdPessoa
		)
		VALUES
		(
			@CPF,
			@Endereço,
			@Telefone,
			@Telefone1,
			@IdPessoa
		)
	END;
END;