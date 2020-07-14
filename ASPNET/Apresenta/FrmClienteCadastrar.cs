using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocio;

namespace teste
{
    public partial class FrmClienteCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;
        public FrmClienteCadastrar(AcaoNaTela acaoNaTela,Cliente cliente)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Cliente";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Cliente";
                textBoxCodigo.Text =cliente.IdPessoa.ToString();
                textBoxNome.Text = cliente.NomeCompleto;
                textBoxEmail.Text = cliente.Email;
                textBoxCPF.Text = cliente.CPF;
                textBoxRua.Text = cliente.Rua;
                textBoxMunicipio.Text = cliente.Municipio;
                textBoxCidade.Text = cliente.Cidade;
                textBoxReferencia.Text = cliente.PontoReferencia;
                textBoxTelefone.Text = cliente.Telefone;
                textBoxTelefone1.Text = cliente.Telefone1;

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Cliente";
                textBoxCodigo.ReadOnly = true;
                textBoxCodigo.TabStop = false;
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;
                textBoxEmail.ReadOnly = true;
                textBoxEmail.TabStop = false;
                textBoxCPF.ReadOnly = true;
                textBoxCPF.TabStop = false;
                textBoxRua.ReadOnly = true;
                textBoxRua.TabStop = false;
                textBoxMunicipio.ReadOnly = true;
                textBoxMunicipio.TabStop = false;
                textBoxCidade.ReadOnly = true;
                textBoxCidade.TabStop = false;
                textBoxReferencia.ReadOnly = true;
                textBoxReferencia.TabStop = false;
                textBoxTelefone.ReadOnly = true;
                textBoxTelefone.TabStop = false;
                textBoxTelefone1.ReadOnly = true;
                textBoxTelefone1.TabStop = false;

                buttonClienteSalvar.Visible = false;
                buttonClienteCancelar.Text = "Fechar";
                buttonClienteCancelar.Focus();

                textBoxCodigo.Text = cliente.IdPessoa.ToString();
                textBoxNome.Text = cliente.NomeCompleto;
                textBoxEmail.Text = cliente.Email;
                textBoxCPF.Text = cliente.CPF;
                textBoxRua.Text = cliente.Rua;
                textBoxMunicipio.Text = cliente.Municipio;
                textBoxCidade.Text = cliente.Cidade;
                textBoxReferencia.Text = cliente.PontoReferencia;
                textBoxTelefone.Text = cliente.Telefone;
                textBoxTelefone1.Text = cliente.Telefone1;
            }
        }

        private void buttonClienteSalvar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Cliente cliente = new Cliente();
                cliente.NomeCompleto = textBoxNome.Text;
                cliente.Email = textBoxEmail.Text;
                cliente.CPF = textBoxCPF.Text;
                cliente.Rua = textBoxRua.Text;
                cliente.Municipio = textBoxMunicipio.Text;
                cliente.Cidade = textBoxCidade.Text;
                cliente.PontoReferencia = textBoxReferencia.Text;
                cliente.Telefone = textBoxTelefone.Text;
                cliente.Telefone1 = textBoxTelefone1.Text;

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno =clienteNegocios.Inserir(cliente);

                try
                {
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente cadastrado com sucesso. Código" + idCliente.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não possivel cadastrar. Detalhes: " + retorno , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Cliente cliente = new Cliente();
                cliente.IdPessoa = Convert.ToInt32(textBoxCodigo.Text);
                cliente.NomeCompleto = textBoxNome.Text;
                cliente.Email = textBoxEmail.Text;
                cliente.CPF = textBoxCPF.Text;
                cliente.Rua = textBoxRua.Text;
                cliente.Municipio = textBoxMunicipio.Text;
                cliente.Cidade = textBoxCidade.Text;
                cliente.PontoReferencia = textBoxReferencia.Text;
                cliente.Telefone = textBoxTelefone.Text;
                cliente.Telefone1 = textBoxTelefone1.Text;

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Alterar(cliente);

                try
                {
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente alterado com sucesso. Código" + idCliente.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não possivel alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }


            }
        }

        private void buttonClienteCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void labelEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}
