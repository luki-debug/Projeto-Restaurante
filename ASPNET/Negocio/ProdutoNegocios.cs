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
    public class ProdutoNegocios
    {
        public string uspProcedure;
        public string uspParametro;

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", produto.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@IdTipo", produto.IdTipo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", produto.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Valor", produto.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Sabor", produto.Sabor);
                string msgProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoInserir").ToString();

                return msgProduto;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string Alterar(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", produto.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", produto.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@IdTipo", produto.IdTipo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", produto.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Valor", produto.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Sabor", produto.Sabor);
                string msgProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAlterar").ToString();

                return msgProduto;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string Excluir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", produto.IdProduto);
                string msgProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString();

                return msgProduto;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public ProdutoColletion ProdutoConsultarPorTipo(string tipo,string sabor,string codigo)
        {
            try
            {
                ProdutoColletion produtoColletion = new ProdutoColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Tipo", tipo);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Sabor", sabor);
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure,"uspProdutoConsultarPorTipo");

                foreach(DataRow linha in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(linha["IdProduto"]);
                    produto.Codigo = Convert.ToString(linha["Codigo"]);
                    produto.IdTipo = Convert.ToInt32(linha["IdTipo"]);
                    produto.Tipo = Convert.ToString(linha["Tipo"]);
                    produto.Descricao = Convert.ToString(linha["Descricao"]);
                    produto.Valor = Convert.ToDecimal(linha["Valor"]);
                    produto.Sabor = Convert.ToString(linha["Sabor"]);

                    produtoColletion.Add(produto);
                }
                return produtoColletion;
            }
            catch(Exception exception)
            {
                throw new Exception("Não foi possivel consultar produto por descricao. Detalhes: " + exception.Message);
            }
        }
        public ProdutoColletion TipoConsultar(string tipo)
        {
            try
            {
                ProdutoColletion produtoColletion = new ProdutoColletion();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Tipo", tipo);
                
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT*FROM ProdutoTipo WHERE Tipo LIKE '%'+@Tipo+'%'");

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdTipo = Convert.ToInt32(linha["IdTipo"]);
                    produto.Tipo = Convert.ToString(linha["Tipo"]);

                    produtoColletion.Add(produto);
                }
                return produtoColletion;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar os valores de tipo. Detalhes: " + exception.Message);
            }
        }

        public string TipoInserir(string tipo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Tipo", tipo);
                string msgProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO ProdutoTipo (Tipo) " +
                    "Values (@Tipo) SELECT @@IDENTITY AS Retorno").ToString();

                return msgProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string TipoExcluir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdTipo", produto.IdTipo);
                string msgProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM ProdutoTipo WHERE IdTipo=@IdTipo SELECT @IdTipo Retorno").ToString();

                return msgProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string TipoAlterar(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdTipo", produto.IdTipo);
                acessoDadosSqlServer.AdicionarParametros("@Tipo", produto.Tipo);
                string msgProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "BEGIN BEGIN TRY BEGIN TRAN IF" +
                    "(EXISTS(SELECT Tipo from ProdutoTipo where Tipo = @Tipo AND Idtipo = @IdTipo)) BEGIN RAISERROR('Este item não foi alterado',14,1) " +
                    "END IF(EXISTS(SELECT Tipo from ProdutoTipo where Tipo=@Tipo)) BEGIN RAISERROR('Este item já existe',14,1) END " +
                    "UPDATE ProdutoTipo SET Tipo = @Tipo WHERE IdTipo = @IdTipo SELECT @IdTipo AS Retorno COMMIT TRAN END TRY BEGIN CATCH ROLLBACK TRAN " +
                    "SELECT ERROR_MESSAGE() AS Retorno; END CATCH END;").ToString();

                return msgProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

    }
}
