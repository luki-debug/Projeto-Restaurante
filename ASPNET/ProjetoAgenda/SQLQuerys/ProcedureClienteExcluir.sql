CREATE PROCEDURE uspClienteExcluir
	@idPessoa INT
AS
BEGIN
	DELETE FROM Cliente
	WHERE IdPessoa=@idPessoa;
	DELETE FROM Pessoa
	WHERE IdPessoa=@idPessoa;
END