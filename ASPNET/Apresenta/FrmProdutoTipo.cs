using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class FrmProdutoTipo : Form
    {
        string cellCurrentRetorno;
        public FrmProdutoTipo()
        {
            InitializeComponent();
        }

        private void FrmProdutoTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDagendaDataSet.ProdutoTipo'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTipoTableAdapter.Fill(this.bDagendaDataSet.ProdutoTipo);
            atualizarGrid();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            string retorno=produtoNegocios.TipoInserir(textBoxInserirTipo.Text);

            
            if(int.TryParse(retorno, out _) == true)
            {
                atualizarGrid();
                MessageBox.Show("Inserido com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Não foi possivel inserir novo tipo. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void atualizarGrid()
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColletion produtoCollection = new ProdutoColletion();

            produtoCollection = produtoNegocios.TipoConsultar("");

            dgwTipo.DataSource = null;
            dgwTipo.AutoGenerateColumns = false;
            produtoCollection.Sort((x, y) => x.Tipo.CompareTo(y.Tipo));
            dgwTipo.DataSource = produtoCollection;
            //dgwTipo.Sort(colTipo,ListSortDirection.Ascending);
            dgwTipo.Update();
            dgwTipo.Refresh();
        }

        private void dgwTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwTipo.Rows.Count == 0)
            {
                return;
            }


            if (dgwTipo.Columns[e.ColumnIndex] == dgwTipo.Columns["Editar"])
            {
                Produto itemSelecionado = (dgwTipo.SelectedRows[0].DataBoundItem as Produto);

                //
                dgwTipo.SelectedRows[0].Cells[1].ReadOnly = false;
                //dgwTipo.Columns["colTipo"].ReadOnly = false;

                cellCurrentRetorno = dgwTipo.SelectedRows[0].Cells[1].Value.ToString();
                dgwTipo.CurrentCell = dgwTipo.SelectedRows[0].Cells[1];
                


            }

            if (dgwTipo.Columns[e.ColumnIndex] == dgwTipo.Columns["Excluir"])
            {

                DialogResult excluir = MessageBox.Show("Deseja excluir este Item ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (excluir == DialogResult.No)
                {
                    return;
                }

                Produto itemSelecionado = (dgwTipo.SelectedRows[0].DataBoundItem as Produto);

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();

                string retorno = produtoNegocios.TipoExcluir(itemSelecionado);

                try
                {
                   
                    if (int.TryParse(retorno,out _)==true)
                    {
                        atualizarGrid();
                    }

                }
                catch
                {
                    MessageBox.Show("Não possivel Excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgwTipo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgwTipo.SelectedRows[0].Cells[1].ReadOnly = true;

            ProdutoNegocios produtoNegocios = new ProdutoNegocios();

            Produto produto = new Produto();

            //string tran = dgwTipo.Rows[e.RowIndex].Cells[1].Value.ToString();

            produto.Tipo = dgwTipo.Rows[e.RowIndex].Cells[1].Value.ToString();
            produto.IdTipo = Convert.ToInt32(dgwTipo.Rows[e.RowIndex].Cells[0].Value);

            string retorno = produtoNegocios.TipoAlterar(produto).ToString();

            if(int.TryParse(retorno, out _) == true)
            {
                MessageBox.Show("Item atualizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(retorno== "Este item não foi alterado")
            {
                dgwTipo.Rows[e.RowIndex].Cells[1].Value = cellCurrentRetorno;
            }
            else
            {
                MessageBox.Show(retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgwTipo.Rows[e.RowIndex].Cells[1].Value = cellCurrentRetorno;
            }
            

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            DialogResult fechar = new DialogResult();


            if (fechar == DialogResult.No)
            {
                return;
            }
            else
            {
                Close();
            }

        }

        private void dgwTipo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adiciona ToolType nas Imagens
            dgwTipo.Rows[e.RowIndex].Cells["Editar"].ToolTipText = "Click aqui para editar";
            dgwTipo.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Click aqui para excluir";
            //
        }
    }
}
