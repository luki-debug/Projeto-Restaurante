CREATE PROCEDURE uspClienteUsuarioPorNome
	@Nome varchar(50)
AS
BEGIN
	SELECT 
	P.IdPessoa,
	P.NomeCompleto,
	P.Email,
	U.nomeUser,
	U.Senha
	From Pessoa AS P INNER JOIN Usuario AS U
	ON P.IdPessoa=U.IdPessoa
	WHERE NomeCompleto LIKE '%'+@Nome+'%'
END