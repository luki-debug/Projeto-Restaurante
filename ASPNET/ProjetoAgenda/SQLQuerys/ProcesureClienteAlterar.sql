USE [BDagenda]
GO
/****** Object:  StoredProcedure [dbo].[uspClienteAlterar]    Script Date: 02/06/2020 15:17:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspClienteAlterar]
	@IdPessoa int,
	@NomeCompleto varchar(50),
	@Email varchar(40),		
	@CPF varchar(15),
	@Endereço varchar(100),
	@Telefone varchar(20),
	@Telefone1 varchar(20)
AS
BEGIN
	DECLARE @VERIFICAR INT;
	UPDATE Pessoa SET
		NomeCompleto=@NomeCompleto,
		Email=@Email
	WHERE IdPessoa=@IdPessoa
	IF @@ROWCOUNT=1
		BEGIN
		UPDATE Cliente SET
			CPF=@CPF,
			Endereço=@Endereço,
			Telefone=@Telefone,
			Telefone1=@Telefone1,
			IdPessoa=@IdPessoa
		WHERE IdPessoa=@IdPessoa
			PRINT 'Registro atualizado!'
		END;
	ELSE
		PRINT 'Erro! Email já cadastrado';
END;