using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using ObjetoTransferencia;


namespace teste
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
            Myconfig(buttonPesquisar);
            Myconfig(buttonInserir);
            Myconfig(buttonAlterar);
            Myconfig(buttonConsultar);
            Myconfig(buttonExcluir);
            Myconfig(buttonFechar);
            dataGridViewProduto.AutoGenerateColumns = false;

        }
        public void Myconfig(Button button)
        {
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(242)))), ((int)(((byte)(133)))));
            button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(242)))), ((int)(((byte)(133)))));
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(203)))), ((int)(((byte)(134)))));
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarGrid()
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColletion produtoCollection = new ProdutoColletion();
            produtoCollection = produtoNegocios.ProdutoConsultarPorTipo(null,textBoxPesquisa.Text,null);
            dataGridViewProduto.DataSource = null;
            produtoCollection.Sort((x, y) => x.Tipo.CompareTo(y.Tipo));
            dataGridViewProduto.DataSource = produtoCollection;
            dataGridViewProduto.Update();
            dataGridViewProduto.Refresh();
        }

        private void buttonPesquisar_Click_1(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void FrmProduto_Shown(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar(AcaoNaTela.Inserir,null);
            DialogResult dialogResult = frmProdutoCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto selecionado");
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja excluir este item ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            string retorno = produtoNegocios.Excluir (produtoSelecionado);

            try
            {
                int IdProduto = Convert.ToInt32(retorno);
                MessageBox.Show("Produto Excluido com sucesso! Id: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();

            }
            catch
            {
                MessageBox.Show("Não possivel Excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto selecionado");
                return;
            }

            Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar(AcaoNaTela.Consultar, produtoSelecionado);
            frmProdutoCadastrar.ShowDialog();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto selecionado");
                return;
            }

            Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar(AcaoNaTela.Alterar, produtoSelecionado);
            DialogResult dialogResult =frmProdutoCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }
    }
}
