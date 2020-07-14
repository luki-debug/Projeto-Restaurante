CREATE PROCEDURE uspClienteConsultarPorNome
	@Nome varchar(50)
AS
BEGIN
	SELECT 
	P.IdPessoa,
	P.NomeCompleto,
	P.Email,
	C.CPF,
	C.Endereço,
	C.Telefone,
	C.Telefone1
	From Pessoa AS P INNER JOIN Cliente AS C
	ON P.IdPessoa=C.IdPessoa
	WHERE NomeCompleto LIKE '%'+@Nome+'%'
END