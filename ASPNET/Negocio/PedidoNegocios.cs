using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBanco;
using ObjetoTransferencia;
using System.Security.Permissions;

namespace Negocio
{
    public class PedidoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdSituacao", pedido.Situacao.IdSituacao);
                acessoDadosSqlServer.AdicionarParametros("@IdPessoa", pedido.Pessoa.IdPessoa);
                string idPedido = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoInserir").ToString();

                return idPedido;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public PedidoColletion ConsultarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                PedidoColletion pedidoColletion = new PedidoColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@DataInicial", dataInicial);
                acessoDadosSqlServer.AdicionarParametros("@DataFinal", dataFinal);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarPorData");

                foreach(DataRow dataRow in dataTable.Rows)
                {
                    Pedido pedido = new Pedido();
                    pedido.IdPedido =Convert.ToInt32(dataRow["IdPedido"]);
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);
                    pedido.Situacao = new Situacao();
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["Descricao"]);
                    pedido.Pessoa = new Cliente(); 
                    pedido.Pessoa.NomeCompleto =Convert.ToString(dataRow["NomeCompleto"]);

                    pedidoColletion.Add(pedido);
                }

                return pedidoColletion;
            }
            catch(Exception exception)
            {
                throw new Exception("Erro ao consultar por data. Detalhes:" + exception.Message);
            }
        }

        public PedidoColletion ConsultarPorId(int id)
        {
            try
            {
                PedidoColletion pedidoColletion = new PedidoColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPedido", id);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarPorId");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Pedido pedido = new Pedido();
                    pedido.IdPedido = Convert.ToInt32(dataRow["IdPedido"]);
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);
                    pedido.Situacao = new Situacao();
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["Descricao"]);
                    pedido.Pessoa = new Cliente();
                    pedido.Pessoa.NomeCompleto = Convert.ToString(dataRow["NomeCompleto"]);
                    pedido.TotalDesconto = Convert.ToDecimal(dataRow["TotalDesconto"]);
                    pedido.TotalValor = Convert.ToDecimal(dataRow["TotalValor"]);

                    pedidoColletion.Add(pedido);
                }

                return pedidoColletion;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro ao consultar por Id. Detalhes:" + exception.Message);
            }
        }

        public PedidoColletion ConsultarPorSituacaoOuTodos(int idsituacao,string situacao)
        {
            try
            {
                PedidoColletion pedidoColletion = new PedidoColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdSituacao", idsituacao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarPorSituacao");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Pedido pedido = new Pedido();
                    pedido.IdPedido = Convert.ToInt32(dataRow["IdPedido"]);
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);
                    pedido.Situacao = new Situacao();
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["Descricao"]);
                    pedido.Pessoa = new Cliente();
                    pedido.Pessoa.NomeCompleto = Convert.ToString(dataRow["NomeCompleto"]);
                    pedido.TotalDesconto = Convert.ToDecimal(dataRow["TotalDesconto"]);
                    pedido.TotalValor = Convert.ToDecimal(dataRow["TotalValor"]);

                    pedidoColletion.Add(pedido);
                }

                return pedidoColletion;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro ao consultar por data. Detalhes:" + exception.Message);
            }
        }

        public SituacaoColletion ConsultarTiposSituacao(int idsituacao,string descricao)
        {
            try
            {
                SituacaoColletion pedidoColletion = new SituacaoColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdSituacao", idsituacao);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", descricao);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarSituacao");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Situacao situacao = new Situacao();
                    situacao.IdSituacao = Convert.ToInt32(dataRow["IdSituacao"]);
                    situacao.Descricao = Convert.ToString(dataRow["Descricao"]);

                    pedidoColletion.Add(situacao);
                }

                return pedidoColletion;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro ao consultar por data. Detalhes:" + exception.Message);
            }
        }

        public string Excluir(Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPedido", pedido.IdPedido);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "BEGIN DELETE FROM PedidoItem WHERE IdPedido=@IdPedido" +
                    " DELETE FROM Pedido WHERE IdPedido=@IdPedido select @@ROWCOUNT as retorno END;").ToString();

                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string InserirValor(Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPedido", pedido.IdPedido);
                acessoDadosSqlServer.AdicionarParametros("@TotalDesconto", pedido.TotalDesconto);
                acessoDadosSqlServer.AdicionarParametros("@TotalValor", pedido.TotalValor);
                string idPedido = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoInserirValor").ToString();

                return idPedido;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
