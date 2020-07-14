USE [BDagenda]
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioInserir]    Script Date: 02/06/2020 12:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspUsuarioInserir]
	@NomeCompleto varchar(50),
	@Email varchar(40),		
	@nomeUser varchar(30),
	@Senha varchar(30)
AS
BEGIN
IF @nomeUser=(select nomeUser from usuario where nomeUser=@nomeUser)
	print'Erro! Usuario já existe';
ElSE
	IF @Email=(select email from Pessoa where Email=@Email) 
		print 'Erro! Email já existe';
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
	INSERT INTO Usuario
	(
		nomeUser,
		Senha,
		IdPessoa
	)
	VALUES
	(
		@nomeUser,
		@Senha,
		@IdPessoa
	)
END;
END;
