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
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();
            MyConfig myConfig = new MyConfig();
            myConfig.MyconfigButton(buttonAlterar);
            myConfig.MyconfigButton(buttonConsultar);
            myConfig.MyconfigButton(buttonExcluir);
            myConfig.MyconfigButton(buttonFechar);
            myConfig.MyconfigButton(buttonInserir);
            myConfig.MyconfigButton(buttonPesquisar);

            //Não gerar linhas automaticas
            dataGridViewCliente.AutoGenerateColumns = false;

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteCollection clienteCollection = new ClienteCollection();
            clienteCollection = clienteNegocios.ConsultarNome(textBoxPesquisa.Text);
            dataGridViewCliente.DataSource = null;
            dataGridViewCliente.DataSource = clienteCollection;
            dataGridViewCliente.Update();
            dataGridViewCliente.Refresh();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
             //Verificar se tem algum item selecionado
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado");
                return;
            }
            //Perguntar se quer excluir
            DialogResult resultado = MessageBox.Show("Tem certeza ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar o item selecionado
            Cliente clienteSelecionado = (dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente);

            //Instanciar regra de Negocio
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            //Chamar método de Excluir
            string retorno=clienteNegocios.Excluir(clienteSelecionado);

            //Verica se Exclui com sucesso
            //Se o retorno  for numero foi com sucesso, se foi string gerou erro
            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente Excluido com sucesso!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();

            }
            catch
            {
                MessageBox.Show("Não possivel Excluir. Detalhes: "+retorno,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClienteSelecionar_Shown(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            //Instanciar o form de cadastro
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(AcaoNaTela.Inserir,null);
            DialogResult dialogResult= frmClienteCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum item selecionado
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado");
                return;
            }
            //Pegar o item selecionado
            Cliente clienteSelecionado = (dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente);

            //Instanciar o form de cadastro
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(AcaoNaTela.Alterar, clienteSelecionado);
            DialogResult dialogResult = frmClienteCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum item selecionado
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado");
                return;
            }
            //Pegar o item selecionado
            Cliente clienteSelecionado = (dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente);

            //Instanciar o form de cadastro
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(AcaoNaTela.Consultar, clienteSelecionado);
            frmClienteCadastrar.ShowDialog();
        }

        private void FrmClienteSelecionar_Load(object sender, EventArgs e)
        {

        }
    }
}
