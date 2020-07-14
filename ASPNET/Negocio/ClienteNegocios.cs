using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBanco;
using ObjetoTransferencia;

namespace Negocio
{
    public class ClienteNegocios
    {
        //Instanciar=criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        
        public string Inserir(Cliente cliente)
        {
            try 
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeCompleto", cliente.NomeCompleto);
                acessoDadosSqlServer.AdicionarParametros("@Email", cliente.Email);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
                acessoDadosSqlServer.AdicionarParametros("@Rua", cliente.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Municipio", cliente.Municipio);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", cliente.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Referencia", cliente.PontoReferencia);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", cliente.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Telefone1", cliente.Telefone1);
                string msgCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return msgCliente;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPessoa", cliente.IdPessoa);
                acessoDadosSqlServer.AdicionarParametros("@NomeCompleto", cliente.NomeCompleto);
                acessoDadosSqlServer.AdicionarParametros("@Email", cliente.Email);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
                acessoDadosSqlServer.AdicionarParametros("@Rua", cliente.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Municipio", cliente.Municipio);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", cliente.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Referencia", cliente.PontoReferencia);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", cliente.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Telefone1", cliente.Telefone1);
                string msgCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return msgCliente;

            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("IdPessoa", cliente.IdPessoa);
                string IdCliente=acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();

                return IdCliente;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public ClienteCollection ConsultarNome(string nome)
        {
            try
            {
                //Criar uma nova coleção de clientes
                ClienteCollection clienteColecao = new ClienteCollection();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                //Retornará uma DataTable
                DataTable dataTableCliente=acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    Cliente cliente = new Cliente();
                    cliente.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    cliente.NomeCompleto = Convert.ToString(linha["NomeCompleto"]);
                    cliente.Email = Convert.ToString(linha["Email"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.Rua = Convert.ToString(linha["Rua"]);
                    cliente.Municipio = Convert.ToString(linha["Municipio"]);
                    cliente.Cidade = Convert.ToString(linha["Cidade"]);
                    cliente.PontoReferencia = Convert.ToString(linha["PontoReferencia"]);
                    cliente.Telefone = Convert.ToString(linha["Telefone"]);
                    cliente.Telefone1 = Convert.ToString(linha["Telefone1"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch(Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
            
        }
    }
}
