using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class FrmProdutoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        ProdutoNegocios produtoNegocios = new ProdutoNegocios();
        ProdutoColletion produtoCollections = new ProdutoColletion();
        public FrmProdutoCadastrar(AcaoNaTela acaoNaTela,Produto produto)
        {
            InitializeComponent();
            acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Produto";

                produtoCollections = produtoNegocios.TipoConsultar("");

                comboBoxTipo.DataSource = produtoCollections;

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Produto";
                this.textBoxIdProduto.Text = produto.IdProduto.ToString();
                this.textBoxCodigo.Text = produto.Codigo;
                int valorTipo = produto.IdTipo;
                produtoCollections = produtoNegocios.TipoConsultar("");
                this.comboBoxTipo.DataSource = produtoCollections;
                int i=comboBoxTipo.FindString(produto.Tipo);
                comboBoxTipo.SelectedIndex = i;
                this.richTextBoxDescricao.Text = produto.Descricao;
                this.textBoxValor.Text = produto.Valor.ToString();
                this.textBoxSabor.Text = produto.Sabor;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Alterar Produto";
                this.textBoxCodigo.ReadOnly = true;
                this.textBoxCodigo.TabStop = false;
                this.comboBoxTipo.Enabled = false;
                this.comboBoxTipo.TabStop = false;
                this.richTextBoxDescricao.ReadOnly = true;
                this.richTextBoxDescricao.TabStop = false;
                this.textBoxValor.ReadOnly = true;
                this.textBoxValor.TabStop = false;
                this.textBoxSabor.ReadOnly = true;
                this.textBoxSabor.TabStop = false;
                this.labelTotal300Char.Visible = false;
                this.btnNovotipo.Visible = false;

                produtoCollections = produtoNegocios.TipoConsultar("");
                this.comboBoxTipo.DataSource = produtoCollections;
                int i = comboBoxTipo.FindString(produto.Tipo);
                comboBoxTipo.SelectedIndex = i;
                this.textBoxCodigo.Text = produto.Codigo;
                this.richTextBoxDescricao.Text = produto.Descricao;
                this.textBoxValor.Text = produto.Valor.ToString();
                this.textBoxSabor.Text = produto.Sabor;

                this.buttonProdutoSalvar.Visible = false;
                this.buttonProdutoCancelar.Text = "Fechar";
                this.buttonProdutoCancelar.Focus();
            }
        }

        private void buttonProdutoSalvar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Produto produto = new Produto();
                produto.Codigo = textBoxCodigo.Text;  
                produto.IdTipo = Convert.ToInt32(comboBoxTipo.SelectedValue);
                produto.Descricao = richTextBoxDescricao.Text;
                produto.Valor = Convert.ToDecimal(textBoxValor.Text);
                produto.Sabor = textBoxSabor.Text;

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                string retorno = produtoNegocios.Inserir(produto);

                try
                {
                    int idProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto Cadastrado com sucessso");
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel cadastrar o produto" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(textBoxIdProduto.Text);
                produto.Codigo = textBoxCodigo.Text;
                produto.IdTipo = Convert.ToInt32(comboBoxTipo.SelectedValue);
                produto.Descricao = richTextBoxDescricao.Text;
                produto.Valor = Convert.ToDecimal(textBoxValor.Text);
                produto.Sabor = textBoxSabor.Text;

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                string retorno = Convert.ToString(produtoNegocios.Alterar(produto));

                try
                {
                    int idProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto alterado com sucessso");
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar o produto" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void buttonProdutoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmProdutoTipo frmProdutoTipo = new FrmProdutoTipo();
            frmProdutoTipo.ShowDialog();

            produtoCollections = produtoNegocios.TipoConsultar("");
            this.comboBoxTipo.DataSource = produtoCollections;
        }
    }
}
