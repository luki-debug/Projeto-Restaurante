namespace ObjetoTransferencia
{
    public class Cliente
    {
        /*Forma usanda em outras linguagens
        //Variável
        private string NomeCliente;

        //GET=Pegar
        public string getNomeCliente()
        {
            return NomeCliente;
        }

        //SET=Setar
        public void setNomeCliente(string NomeClienteSet)
        {
            NomeCliente = NomeClienteSet.ToUpper();
        }*/
        public int IdPessoa { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Rua { get; set; }
        public string Telefone { get; set; }
        public string Telefone1 { get; set; }
        public string Municipio { get; set; }
        public string  Cidade { get; set; }
        public string PontoReferencia { get; set; }
    }
}
