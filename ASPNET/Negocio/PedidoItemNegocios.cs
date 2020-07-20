using AcessoBanco;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PedidoItemNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPedido", pedidoItem.Pedido.IdPedido);
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", pedidoItem.Produto.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@QtdProduto", pedidoItem.QtdProduto);
                acessoDadosSqlServer.AdicionarParametros("@ValorUn", pedidoItem.ValorUn);
                acessoDadosSqlServer.AdicionarParametros("@PorcentualDesconto", pedidoItem.PorcentualDesconto);
                acessoDadosSqlServer.AdicionarParametros("@ValorDesconto", pedidoItem.ValorDesconto);
                acessoDadosSqlServer.AdicionarParametros("@ValorTotal", pedidoItem.ValorTotal);
                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoItemInserir").ToString();

                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public PedidoItemColletion Consultar(int idPedido)
        {
            try
            {
                PedidoItemColletion pedidoItemColletion = new PedidoItemColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idPedido", idPedido);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarItem");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PedidoItem pedidoItem = new PedidoItem();
                    pedidoItem.Pedido = new Pedido();
                    pedidoItem.Pedido.IdPedido = Convert.ToInt32(dataRow["IdPedido"]);

                    pedidoItem.Produto = new Produto();
                    pedidoItem.Produto.IdProduto=Convert.ToInt32(dataRow["IdProduto"]);
                    pedidoItem.Produto.Codigo = Convert.ToString(dataRow["Codigo"]);
                    pedidoItem.Produto.Tipo = Convert.ToString(dataRow["Tipo"]);
                    pedidoItem.Produto.Sabor = Convert.ToString(dataRow["Sabor"]);
                    pedidoItem.PorcentualDesconto = Convert.ToDecimal(dataRow["PorcentualDesconto"]);
                    pedidoItem.QtdProduto = Convert.ToInt32(dataRow["QtdProduto"]);
                    pedidoItem.ValorDesconto = Convert.ToDecimal(dataRow["ValorDesconto"]);
                    pedidoItem.ValorTotal = Convert.ToDecimal(dataRow["ValorTotal"]);
                    pedidoItem.ValorUn = Convert.ToDecimal(dataRow["ValorUn"]);

                    pedidoItemColletion.Add(pedidoItem);
                }

                return pedidoItemColletion;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro ao consultar item do produto. Detalhes:" + exception.Message);
            }
        }

        public string AlterarSituacao(int idpedido, int idsituacao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPedido", idpedido);
                acessoDadosSqlServer.AdicionarParametros("@IdSituacao", idsituacao);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoAlterarSituacao").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Idpedido", pedidoItem.Pedido.IdPedido);
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", pedidoItem.Produto.IdProduto);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM PedidoItem WHERE IdPedido=@IdPedido" +
                    " AND IdProduto=@IdProduto select @@ROWCOUNT as retorno").ToString();

                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string AlterarQtd(PedidoItem pedidoItem)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Idpedido", pedidoItem.Pedido.IdPedido);
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", pedidoItem.Produto.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@QtdProduto", pedidoItem.QtdProduto);
                acessoDadosSqlServer.AdicionarParametros("@ValorTotal", pedidoItem.ValorTotal);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE PedidoItem SET QtdProduto=@QtdProduto, ValorTotal=@ValorTotal WHERE IdPedido=@IdPedido" +
                    " AND IdProduto=@IdProduto select @@ROWCOUNT as retorno").ToString();

                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

    }
}
