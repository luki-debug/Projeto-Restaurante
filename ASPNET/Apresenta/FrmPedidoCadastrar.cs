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
using System.Reflection;
using teste.BDagendaDataSetTableAdapters;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace teste
{
    public partial class FrmPedidoCadastrar : Form
    {
        public Pedido pedidoSelecionado { get; set; }
        Cliente cliente;
        Cliente clientes;
        Produto produtoteste;
        PedidoItem itemSelecionado;
        public Produto produtoItem { get; set; }
        int produtoQtd = 0;
        decimal desconto = 0;
        decimal desValor = 0;
        decimal valorTotalItem = 0;


        public FrmPedidoCadastrar()
        {
            InitializeComponent();
            //carregarLista();
        }
        protected void carregarListaProduto() {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColletion produtoCollection = new ProdutoColletion();
            produtoCollection = produtoNegocios.ProdutoConsultarPorTipo(null, comboBoxProduto.Text, null);
            this.produtoBindingSource.DataSource = produtoCollection;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //if (dgwPedidoItens.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Nenhum item selecionado");
            //    return;
            //}

            //PedidoItem itemSelecionado = (dgwPedidoItens.SelectedRows[0].DataBoundItem as PedidoItem);

            //PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();

            //string retorno = pedidoItemNegocios.Excluir(itemSelecionado);

            //try
            //{
            //    int id = Convert.ToInt32(retorno);
            //    if (id > 0)
            //    {
            //        atualizarGrid();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Não foi possivel excluir produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Não possivel Excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnPedidoPesqCliente_Click(object sender, EventArgs e)
        {
            FrmPedidoSelecionarCliente frmPedidoSelecionarCliente = new FrmPedidoSelecionarCliente();
            DialogResult resultado = frmPedidoSelecionarCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                cliente = frmPedidoSelecionarCliente.clienteSelecionado;
                PedidoNegocios pedidoNegocios = new PedidoNegocios();
                PedidoColletion pedidoCollection = new PedidoColletion();
                Pedido pedido = new Pedido();

                /*string retorno = pedidoNegocios.Inserir(pedido);
                try
                {
                    int id = Convert.ToInt32(retorno);
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Erro ao criar Pedido. Detalhes: " + exception);
                }

                pedidoCollection= pedidoNegocios.ConsultarPorId(Convert.ToInt32(retorno));*/
                dgwPedidoItens.DataSource = pedidoCollection;
                //textBoxPedidoId.Text =Convert.ToString(pedidoSelecionado.IdPedido);
                //textBoxPedidoCliente.Text = frmPedidoSelecionarCliente.clienteSelecionado.NomeCompleto;
            }
        }

        private void btnPedidoFecharNovo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        /*private void textBoxPedidoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode==Keys.Back)
            {
                textBoxPedidoCliente.Clear();
                cliente = null;
            }
        }*/

        private void btnPedidoPesqProd_Click(object sender, EventArgs e)
        {
            FrmPedidoProdutoSelecionar frmPedidoProdutoSelecionar = new FrmPedidoProdutoSelecionar();
            DialogResult resultado = frmPedidoProdutoSelecionar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //textBoxPedidoCodigoProd.Text = frmPedidoProdutoSelecionar.produtoSelecionado.Codigo;
                //textBoxPedidoProduto.Text = frmPedidoProdutoSelecionar.produtoSelecionado.Sabor;
                //textBoxPedidoValorUn.Text = Convert.ToString(frmPedidoProdutoSelecionar.produtoSelecionado.Valor);
                produtoteste = frmPedidoProdutoSelecionar.produtoSelecionado;
            }
        }

        /*private void textBoxPedidoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                comboBoxProduto.Text = "";
                codigoTextBox.Clear();
                textBoxPedidoValorUn.Clear();
                textBoxPedidoQtd.Clear();
                textBoxPedidoDesc.Clear();
                produto = null;
                produtoQtd = 0;
                desconto = 0;
            }
        }*/

        private void btnPedidoDescInserir_Click(object sender, EventArgs e)
        {
            if (textBoxPedidoQtd.Text == string.Empty || textBoxPedidoQtd.Text == "0")
            {
                MessageBox.Show("Valor de quantidade inválida, digite um numero maior que 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //int.TryParse(textBoxPedidoQtd.Text, out i);
                if (int.TryParse(textBoxPedidoQtd.Text, out _))
                {
                    //produtoQtd = Convert.ToInt32(textBoxPedidoQtd.Text);
                    //decimal valorun = 12.99m;
                    valorTotalItem = int.Parse(textBoxPedidoQtd.Text) * decimal.Parse(textBoxPedidoValorUn.Text);

                    btnPedidoFinalizarNovo.Visible = true;
                    btnPedidoCancelarNovo.Visible = true;
                    comboBoxProduto.Text = "";


                    button2.Focus();

                    atualizarPedido();
                }
                else
                {
                    MessageBox.Show("Digite um numero válido em Qtd", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void atualizarGrid()
        {
            PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();
            PedidoItemColletion pedidoItemCollection = new PedidoItemColletion();

            dgwPedidoItens.AutoGenerateColumns = false;
            dgwPedidoItens.DataSource = null;
            pedidoItemCollection = pedidoItemNegocios.Consultar(int.Parse(textBoxPedidoId.Text));
            dgwPedidoItens.DataSource = pedidoItemCollection;
            dgwPedidoItens.Update();
            dgwPedidoItens.Refresh();

            if (pedidoItemCollection.Count > 0)
            {
                btnInserirDesc.Visible = true;
                textBoxInserirDesc.Visible = true;
            }
            else
            {
                btnInserirDesc.Visible = false;
                textBoxInserirDesc.Visible = false;
            }

            int itens = 0;
            foreach (PedidoItem item in pedidoItemCollection)
            {
                itens += item.QtdProduto;
            }

            decimal total = 0;
            foreach (PedidoItem valor in pedidoItemCollection)
            {
                total += valor.ValorTotal;
            }

            total -= desconto;

            textBoxDescDisable.Text = string.Format("{0:c}",desconto);

            textBoxTotalItem.Text = Convert.ToString(itens);
            textBoxValorTotal.Text = string.Format("{0:c}", total);
        }

        private void atualizarPedido()
        {
            //FrmPedidoCadastrar frmPedidoCadastrar = new FrmPedidoCadastrar();
            PedidoNegocios pedidoNegocios = new PedidoNegocios();
            PedidoColletion pedidoCollection = new PedidoColletion();
            PedidoItemColletion pedidoItemCollection = new PedidoItemColletion();
            PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();
            PedidoItem pedidoItem = new PedidoItem();

            pedidoItem.Pedido = new Pedido();
            pedidoItem.Pedido.IdPedido = int.Parse(textBoxPedidoId.Text);
            pedidoItem.Produto = new Produto();
            pedidoItem.Produto.IdProduto = produtoItem.IdProduto;
            pedidoItem.QtdProduto = int.Parse(textBoxPedidoQtd.Text);
            pedidoItem.ValorUn = decimal.Parse(textBoxPedidoValorUn.Text);
            pedidoItem.PorcentualDesconto = desconto;
            pedidoItem.ValorDesconto = desValor;
            pedidoItem.ValorTotal = valorTotalItem;


            string retorno = pedidoItemNegocios.Inserir(pedidoItem).ToString();

            try
            {
                int result=int.Parse(retorno);
                atualizarGrid();
            }
            catch
            {
                MessageBox.Show(retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //BindProperty
        private object carregarPropriedade(object propriedade, string nomePropriedade)
        {
            try
            {
                object retorno = "";

                if (nomePropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;
                    propriedadeAntesDoPonto = nomePropriedade.Substring(0, nomePropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = carregarPropriedade(propertyInfo.GetValue(propriedade, null), nomePropriedade.Substring(nomePropriedade.IndexOf(".") + 1));
                            }
                        }
                    }
                }
                else
                {
                    Type type;
                    PropertyInfo prfInfo;

                    if (propriedade != null)
                    {
                        type = propriedade.GetType();
                        prfInfo = type.GetProperty(nomePropriedade);
                        retorno = prfInfo.GetValue(propriedade, null);
                    }
                }

                return retorno;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

        private void dgwPedidoItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgwPedidoItens.Rows[e.RowIndex].DataBoundItem != null) && (dgwPedidoItens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgwPedidoItens.Rows[e.RowIndex].DataBoundItem, dgwPedidoItens.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Adiciona ToolType nas Imagens
            dgwPedidoItens.Rows[e.RowIndex].Cells["Editar"].ToolTipText="Click aqui para editar Qtd";
            dgwPedidoItens.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Click aqui para excluir";
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColletion produtoCollection = new ProdutoColletion();
            Produto produto = new Produto();
            //this.produtoBindingSource.DataSource = produtoCollection;

            btnAlterarQtd.Visible = false;
            comboBoxProduto.Enabled = true;
            labelQtd.Visible = false;
            labelValUn.Visible = false;
            textBoxPedidoValorUn.Visible = false;
            btnPedidoDescInserir.Visible = false;
            textBoxPedidoQtd.Visible = false;
            btnSelecionar.Enabled = true;
            

            produtoItem = null;

            produtoCollection = produtoNegocios.ProdutoConsultarPorTipo(null, comboBoxProduto.Text, null);
            this.produtoBindingSource.DataSource = produtoCollection;
            //produto = produtoCollection.Find(x => x.Sabor == comboBoxProduto.Text);
            //comboBoxProduto.Text = produto.Sabor;
            //codigoTextBox.Text = produto.Codigo;
            //textBoxPedidoValorUn.Text = Convert.ToString(produto.Valor);

            //produtoItem = produtoCollection.Find(x => x.Codigo == codigoTextBox.Text);

            //comboBoxProduto.Enabled = true;
        }

        private void comboBoxProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                comboBoxProduto.Text = "";
                codigoTextBox.Clear();
                textBoxPedidoValorUn.Clear();
                textBoxPedidoQtd.Clear();
                textBoxInserirDesc.Clear();
                produtoItem = null;
                produtoteste = null;
                produtoQtd = 0;
                desconto = 0;
            }
        }

        private void button1_ClickPedidoCliente(object sender, EventArgs e)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteCollection clienteCollection = new ClienteCollection();
            Cliente clientePedido = new Cliente();

            comboBoxCliente.Enabled = true;
            btnInserirCliente.Enabled = true;

            btnAlterarQtd.Visible = false;
            textBoxPedidoId.Text = null;
            textBoxInserirDesc.Text = null;
            textBoxPedidoData.Text = null;
            textBoxPedidoSituacao.Clear();

            comboBoxCliente.Text = "";
            comboBoxProduto.Text = "";
            codigoTextBox.Clear();
            textBoxPedidoValorUn.Clear();
            textBoxPedidoQtd.Clear();
            textBoxInserirDesc.Clear();
            produtoItem = null;
            produtoteste = null;
            textBoxTotalItem.Text = "0";
            valorTotalItem = 0;

            gbxItens.Visible = false;
            textBoxPedidoQtd.Visible = false;
            textBoxPedidoValorUn.Visible = false;
            textBoxInserirDesc.Visible = false;
            btnPedidoDescInserir.Visible = false;
            labelQtd.Visible = false;
            labelValUn.Visible = false;
            btnPedidoCancelarNovo.Visible = false;
            btnPedidoFinalizarNovo.Visible = false;

            dgwPedidoItens.DataSource = null;

            clienteCollection = clienteNegocios.ConsultarNome(comboBoxCliente.Text);
            this.clienteBindingSource.DataSource = clienteCollection;


            //cliente = clienteCollection.First(); // primeiro da lista //Queria apenas o primeiro cliente da consulta que fiz no banco e joguei na colecação ????
            // cliente = clienteCollection.Last(); /// ultimo registro da lista
            //clientePedido = clienteCollection.Find( x=> x.NomeCompleto == comboBox1.Text); /// possivel filtro por paremetro
            // cliente = clienteCollection[0]; primeira posição

        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.Text == string.Empty)
            {
                MessageBox.Show("Nenhum cliente selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClienteNegocios clienteNegocios = new ClienteNegocios();
                ClienteCollection clienteCollection = new ClienteCollection();
                Cliente clientePedido = new Cliente();
                clienteCollection = clienteNegocios.ConsultarNome(comboBoxCliente.Text);

                comboBoxCliente.Enabled = false;

                PedidoNegocios pedidoNegocios = new PedidoNegocios();
                PedidoColletion pedidoColletion = new PedidoColletion();
                Pedido pedido = new Pedido();

                clientePedido = clienteCollection.Find(x => x.NomeCompleto == comboBoxCliente.Text);
                pedido.Pessoa = new Cliente();
                pedido.Pessoa.IdPessoa = clientePedido.IdPessoa;
                pedido.Situacao = new Situacao();
                pedido.Situacao.IdSituacao = 5;

                string retorno = pedidoNegocios.Inserir(pedido);

                textBoxPedidoId.Text = retorno;

                pedidoColletion = pedidoNegocios.ConsultarPorId(int.Parse(retorno));

                Pedido pedido1 = new Pedido();
                pedido1 = pedidoColletion.Find(x => x.IdPedido == int.Parse(textBoxPedidoId.Text));
                textBoxPedidoData.Text = Convert.ToString(pedido1.DataHora);
                textBoxPedidoSituacao.Text = pedido1.Situacao.Descricao;

                gbxItens.Visible = true;
                btnInserirCliente.Enabled = false;
                textBoxTotalItem.Text = "0";
                textBoxValorTotal.Text = string.Format("{0:c}", valorTotalItem);


                //carregarListaProduto();
            }

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                comboBoxCliente.Text = "";
                textBoxPedidoData.Clear();
                textBoxPedidoId.Clear();
                textBoxPedidoSituacao.Clear();

                comboBoxProduto.Text = "";
                codigoTextBox.Clear();
                textBoxPedidoValorUn.Clear();
                textBoxPedidoQtd.Clear();
                textBoxInserirDesc.Clear();
                produtoItem = null;
                produtoteste = null;
                produtoQtd = 0;
                desconto = 0;

                gbxItens.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxProduto.Text == string.Empty)
            {
                MessageBox.Show("Nenhum produto seleciona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                ProdutoColletion produtoCollection = new ProdutoColletion();
                //Produto produtoItem = new Produto();
                //this.produtoBindingSource.DataSource = produtoCollection;

                comboBoxProduto.Enabled = false;
                labelQtd.Visible = true;
                labelValUn.Visible = true;
                btnPedidoDescInserir.Visible = true;
                textBoxPedidoQtd.Visible = true;
                textBoxPedidoValorUn.Visible = true;
                btnSelecionar.Enabled = false;

                textBoxPedidoQtd.Text = "1";
                //textBoxPedidoDesc.Text = "0";

                


                produtoCollection = produtoNegocios.ProdutoConsultarPorTipo(null, null, codigoTextBox.Text);
                this.produtoBindingSource.DataSource = produtoCollection;

                produtoItem = produtoCollection.Find(x => x.Codigo == codigoTextBox.Text);

                btnPedidoDescInserir.Focus();
            }

        }

        private void btnPedidoFinalizarNovo_Click_1(object sender, EventArgs e)
        {
            if (textBoxTotalItem.Text == string.Empty || textBoxTotalItem.Text == "0")
            {
                MessageBox.Show("Nenhum item inserido no pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();
                PedidoNegocios pedidoNegocios = new PedidoNegocios();

                Pedido pedido = new Pedido();

                pedido.IdPedido = int.Parse(textBoxPedidoId.Text);
                pedido.TotalDesconto = Convert.ToDecimal(textBoxDescDisable.Text.Replace("R$", ""));
                pedido.TotalValor = Convert.ToDecimal(textBoxValorTotal.Text.Replace("R$", ""));

                pedidoItemNegocios.AlterarSituacao(int.Parse(textBoxPedidoId.Text), 1);
                pedidoNegocios.InserirValor(pedido);

                Close();

                DialogResult = DialogResult.Yes;
            }
        }

        private void btnPedidoCancelarNovo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja cancelar o pedido ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();
            PedidoItemColletion pedidoItemCollection = new PedidoItemColletion();
            PedidoNegocios pedidoNegocios = new PedidoNegocios();
      
            Pedido pedido = new Pedido();

            pedido.IdPedido = int.Parse(textBoxPedidoId.Text);

            string retorno=pedidoNegocios.Excluir(pedido);

            if (int.Parse(retorno) > 0)
            {
                pedidoItemCollection = pedidoItemNegocios.Consultar(int.Parse(textBoxPedidoId.Text));

                dgwPedidoItens.DataSource = null;
                dgwPedidoItens.DataSource = pedidoItemCollection;

                textBoxPedidoData.Clear();
                textBoxInserirDesc.Clear();
                textBoxPedidoId.Clear();
                textBoxPedidoQtd.Clear();
                textBoxPedidoSituacao.Clear();
                textBoxPedidoValorUn.Clear();
                textBoxValorTotal.Clear();
                textBoxTotalItem.Clear();
                codigoTextBox.Clear();
                comboBoxCliente.Text = "";
                comboBoxProduto.Text = "";


                MessageBox.Show("Pedido apagado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Nenhum item a ser apagado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
           
        }

        private void btnPedidoAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxPedidoQtd.Text == string.Empty || textBoxPedidoQtd.Text == "0")
            {
                MessageBox.Show("Valor de quantidade inválida, digite um numero maior que 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
                if (int.TryParse(textBoxPedidoQtd.Text, out _))
                {
                    labelDescDisable.Visible = true;
                    textBoxDescDisable.Visible = true;
                    labelValUn.Visible = true;
                    textBoxPedidoValorUn.Visible = true;
                    textBoxInserirDesc.Visible = true;
                    btnPedidoDescInserir.Visible = true;
                    textBoxValorTotal.Visible = true;
                    textBoxTotalItem.Visible = true;
                    labelTotalItem.Visible = true;
                    labelValorTotal.Visible = true;
                    btnPedidoCancelarNovo.Enabled = true;
                    btnPedidoFecharNovo.Enabled = true;
                    btnPedidoFinalizarNovo.Enabled = true;
                    textBoxPedidoQtd.Enabled = true;
                    btnAlterarQtd.Visible = false;


                    itemSelecionado.QtdProduto = int.Parse(textBoxPedidoQtd.Text);
                    itemSelecionado.ValorTotal = itemSelecionado.ValorUn * int.Parse(textBoxPedidoQtd.Text);

                    PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();

                    string retorno = pedidoItemNegocios.AlterarQtd(itemSelecionado);

                    try
                    {
                        int id = Convert.ToInt32(retorno);
                        if (id > 0)
                        {
                            textBoxPedidoQtd.Text = "1";
                            atualizarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel alterar Qtd", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Não possivel Alterar Qtd. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            

                
        }

        private void dgwPedidoItens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string qtd = dgwPedidoItens.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show(qtd);
        }

        private void dgwPedidoItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwPedidoItens.Rows.Count==0)
            {
                return;
            }

                if (dgwPedidoItens.Columns[e.ColumnIndex] == dgwPedidoItens.Columns["Editar"])
                {
                itemSelecionado = (dgwPedidoItens.SelectedRows[0].DataBoundItem as PedidoItem);

                //
                textBoxDescDisable.Visible = false;
                labelDescDisable.Visible = false;
                textBoxInserirDesc.Visible = false;
                btnInserirDesc.Visible = false;
                labelValUn.Visible = false;
                textBoxPedidoValorUn.Visible = false;
                textBoxInserirDesc.Visible = false;
                btnPedidoDescInserir.Visible = false;
                textBoxValorTotal.Visible = false;
                textBoxTotalItem.Visible = false;
                labelTotalItem.Visible = false;
                labelValorTotal.Visible = false;
                btnPedidoCancelarNovo.Enabled = false;
                btnPedidoFecharNovo.Enabled = false;
                btnPedidoFinalizarNovo.Enabled = false;
                textBoxPedidoQtd.Enabled = true;
                btnAlterarQtd.Visible = true;
                //

                textBoxPedidoQtd.Text = dgwPedidoItens.Rows[e.RowIndex].Cells["colQtd"].Value.ToString();
                textBoxPedidoQtd.Focus();
                
            }

            if (dgwPedidoItens.Columns[e.ColumnIndex] == dgwPedidoItens.Columns["Excluir"])
            {

                PedidoItem itemSelecionado = (dgwPedidoItens.SelectedRows[0].DataBoundItem as PedidoItem);

                PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();

                string retorno = pedidoItemNegocios.Excluir(itemSelecionado);

                try
                {
                    int id = Convert.ToInt32(retorno);
                    if (id > 0)
                    {
                        atualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Não possivel Excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInserirDesc_Click(object sender, EventArgs e)
        {
            if (textBoxInserirDesc.Text.Contains(".")==true)
            {
                textBoxInserirDesc.Clear();
                MessageBox.Show("Digite apenas numeros e simbolos válidos de moeda", 
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(decimal.TryParse(textBoxInserirDesc.Text,out _) == false)
            {
                textBoxInserirDesc.Clear();
                MessageBox.Show("Este campo deve ser preenchido com numeros",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string total=textBoxValorTotal.Text.Replace("R$", "");
            decimal verificar = Convert.ToDecimal(textBoxInserirDesc.Text);
            if (verificar > Convert.ToDecimal(total))
            {
                textBoxInserirDesc.Clear();
                MessageBox.Show("Valor de desconto maior que valor total do pedido",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            desconto = Convert.ToDecimal(textBoxInserirDesc.Text);
            textBoxInserirDesc.Clear();
            atualizarGrid();
        }
    }
}
