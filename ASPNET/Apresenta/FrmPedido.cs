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
using System.Runtime.CompilerServices;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace teste
{

    public partial class FrmPedido : Form
    {
        int posicao1 = 3;
        int posicaoPanel1 = 290;
        string mouseClick="";
        Panel ativado;
        int i = 0;

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void buttonNovoPedido_Click(object sender, EventArgs e)
        {

        }

        private void buttonPedidoNovo_Click(object sender, EventArgs e)
        {

            //Teste de Adicionar um novo campo a cada novo pedido*
            //panelPedidoStatus = new Panel();
            //panelPedidoStatus.BackColor = Color.Purple;
            //panelPedidoStatus.Location = new Point(3, posicao1);
            //panelPedidoStatus.Name = "panelPedidoOrdem";
            //panelPedidoStatus.Size = new Size(221, 78);
            //panelPedidoStatus.TabIndex = 15;
            //SetAutoScrollMargins();
            //panelPedidoOrdem.Controls.Add(panelPedidoStatus);

            //posicao1 +=84;

            FrmPedidoCadastrar frmPedidoCadastrar = new FrmPedidoCadastrar();
            DialogResult result=frmPedidoCadastrar.ShowDialog();
            
            if (result == DialogResult.Yes)
            {
                carregarStatusPedido(0);  
            }

        }
        //private void SetAutoScrollMargins()
        //{
        //    /* Se a caixa de texto estiver fora dos limites do painel,
        //       ative a rolagem automática e defina a margem. */
        //    if (panelPedidoStatus.Location.X > panelPedidoOrdem.Location.X ||
        //       panelPedidoStatus.Location.Y > panelPedidoOrdem.Location.Y)
        //    {
        //        panelPedidoOrdem.AutoScroll = true;
        //        /* Se o AutoScrollMargin estiver definido como menos
        //           que (5,5), defina-o para 5,5. */
        //        if (panelPedidoOrdem.AutoScrollMargin.Width < 5 ||
        //           panelPedidoOrdem.AutoScrollMargin.Height < 5)
        //        {
        //            panelPedidoOrdem.SetAutoScrollMargin(5, 5);
        //        }
        //    }
        //}

        public void FrmPedido_Load(object sender, EventArgs e)
        {
            carregarStatusPedido(0);
            //PedidoNegocios pedidoNegocios = new PedidoNegocios();
            //SituacaoColletion situacaoCollecion = new SituacaoColletion();

            //situacaoCollecion = pedidoNegocios.ConsultarTiposSituacao(0, "");

            //this.situacaoBindingSource.DataSource= situacaoCollecion;

            //PedidoColletion pedidoCollection = new PedidoColletion();
            //pedidoCollection=pedidoNegocios.ConsultarPorSituacaoOuTodos(1,null);


            ////int posicao1 = 3;
            //foreach (Pedido pedido in pedidoCollection)
            //{
            //    if ( pedido.Situacao.Descricao=="Em preparo" )
            //    {
            //        //panelPedidoStatus = new Panel();
            //        //panelPedidoStatus.BackColor = Color.Purple;
            //        //panelPedidoStatus.Location = new Point(3, posicao1);
            //        //panelPedidoStatus.Name = "panelPedido"+posicao1;
            //        //panelPedidoStatus.Size = new Size(221, 78);
            //        //panelPedidoStatus.TabIndex = 15;
            //        //SetAutoScrollMargins();
            //        //panelPedidoOrdem.Controls.Add(panelPedidoStatus);

            //        //posicao1 += 84;
            //        string descricao = pedido.Situacao.Descricao;
            //        string nome = pedido.Pessoa.NomeCompleto;
            //        string data = Convert.ToString(pedido.DataHora);

            //        painelPedido(descricao,nome,data);

            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mouseClick = "";

            PedidoNegocios pedidoNegocios = new PedidoNegocios();
            SituacaoColletion situacaoCollection = new SituacaoColletion();

            panelPedidoDetal.Visible = false;
            pnlValorT.Visible = false;

            Situacao situacao = new Situacao();

            situacaoCollection= pedidoNegocios.ConsultarTiposSituacao(0, comboBoxSituacaoPesq.Text);

            situacao = situacaoCollection.Find(x => x.Descricao == comboBoxSituacaoPesq.Text);

            carregarStatusPedido(situacao.IdSituacao);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void painelPedido(string descricao, string nome, string data, string id)
        {
            Panel panelPedidoStatus = new Panel();
            panelPedidoStatus.SuspendLayout();

            Label BOXLABEL = new Label();
            TextBox BOXHORA = new TextBox();
            TextBox BOXSIT = new TextBox();
            Label TEXTIDPEDIDO = new Label();
            Label TEXTNOME = new Label();
            Label TEXTTIME = new Label();
            Label LABELTEXTID = new Label();



            //PANELSTATUS
            //
            panelPedidoStatus.BackColor = System.Drawing.Color.Gainsboro;
            panelPedidoStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelPedidoStatus.Controls.Add(BOXLABEL);
            panelPedidoStatus.Controls.Add(TEXTTIME);
            panelPedidoStatus.Controls.Add(BOXSIT);
            panelPedidoStatus.Controls.Add(TEXTNOME);
            panelPedidoStatus.Controls.Add(TEXTIDPEDIDO);
            panelPedidoStatus.Controls.Add(LABELTEXTID);
            panelPedidoStatus.Location = new Point(3, posicao1);
            panelPedidoStatus.Name = "panelPedidoStatus" + posicao1.ToString();
            panelPedidoStatus.Size = new Size(250, 78);
            panelPedidoStatus.TabIndex = 15;
            panelPedidoStatus.ResumeLayout(false);
            panelPedidoStatus.PerformLayout();

            string tag = posicao1.ToString();
            panelPedidoStatus.Tag = tag;



            panelPedidoStatus.MouseClick += new MouseEventHandler(PANEL_MouseClick);
            panelPedidoStatus.MouseLeave += new EventHandler(PANEL_MouseLeave);
            panelPedidoStatus.MouseMove += new MouseEventHandler(PANEL_MouseMove);

            //panelPedidoStatus.Controls.Add(BOXLABEL);
            //panelPedidoStatus.Controls.Add(BOXHORA);
            //panelPedidoStatus.Controls.Add(BOXSIT);
            //panelPedidoStatus.Controls.Add(BOXNOME);

            panelPedidoOrdem.Controls.Add(panelPedidoStatus);

            //panelPedidoStatus = new Panel();
            //panelPedidoStatus.BackColor = Color.Purple;
            //panelPedidoStatus.Location = new Point(3, posicao1);
            //panelPedidoStatus.Name = "panelPedido" + posicao1;
            //panelPedidoStatus.Size = new Size(221, 78);
            //panelPedidoStatus.TabIndex = 15;
            //SetAutoScrollMargins();
            //panelPedidoOrdem.Controls.Add(panelPedidoStatus);


            // EXEMPLOBOXLABEL
            // 
            BOXLABEL.AutoSize = true;
            BOXLABEL.Location = new System.Drawing.Point(3, 44);
            BOXLABEL.Name = "EXEMPLOBOXLABEL";
            BOXLABEL.Size = new System.Drawing.Size(61, 13);
            BOXLABEL.TabIndex = 3;
            BOXLABEL.Text = "Hora inicio:";
            BOXLABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // EXEMPLOTEXTTIME
            // 
            TEXTTIME.Location = new System.Drawing.Point(64, 44);
            TEXTTIME.Name = "EXEMPLOBOXHORA";
            //TEXTTIME.ForeColor = Color.Black;
            TEXTTIME.Size = new System.Drawing.Size(34, 13);
            TEXTTIME.Text = data;
            TEXTTIME.TabIndex = 2;
            //TEXTTIME.Enabled = false;
            // 
            // EXEMPLOBOXSIT
            //
            if (descricao == "Em preparo")
            {
                BOXSIT.BackColor = System.Drawing.Color.Yellow;
                BOXSIT.ForeColor = Color.Black;
            }
            else if(descricao == "Aberto")
            {
                BOXSIT.BackColor = System.Drawing.Color.Red;
                BOXSIT.ForeColor = Color.White;
            }
            else if(descricao == "Pronto")
            {
                BOXSIT.BackColor = System.Drawing.Color.Orange;
                BOXSIT.ForeColor = Color.Black;
            }
            else if(descricao == "Enviando")
            {
                BOXSIT.BackColor = System.Drawing.Color.Blue;
                BOXSIT.ForeColor = Color.White;
            }
            else if(descricao == "Finalizado")
            {
                BOXSIT.BackColor = System.Drawing.Color.Green;
                BOXSIT.ForeColor = Color.Black;
            }

            BOXSIT.Location = new System.Drawing.Point(150, 16);
            BOXSIT.Name = "EXEMPLOBOXSIT";
            BOXSIT.ReadOnly = true;
            BOXSIT.Size = new System.Drawing.Size(89, 20);
            BOXSIT.TabIndex = 1;
            BOXSIT.Text = descricao;
            //BOXSIT.Enabled = false;
            // 
            // EXEMPLOTEXTNOME
            // 
            TEXTNOME.Location = new System.Drawing.Point(3, 17);
            TEXTNOME.Name = "EXEMPLOBOXNOME";
            //TEXTNOME.ReadOnly = true;
            TEXTNOME.Size = new System.Drawing.Size(108, 13);
            TEXTNOME.TabIndex = 0;
            TEXTNOME.Text = nome;
            TEXTNOME.BorderStyle = BorderStyle.None;
            //TEXTNOME.Enabled = false;
            // LABELTEXTID
            // 
            LABELTEXTID.AutoSize = true;
            LABELTEXTID.Location = new Point(150, 44);
            LABELTEXTID.Name = "LABELTEXTID";
            LABELTEXTID.Size = new Size(53, 13);
            LABELTEXTID.TabIndex = 5;
            LABELTEXTID.Text = "Pedido:";
            // 
            // TEXTIDPEDIDO
            // 
            TEXTIDPEDIDO.Location = new Point(203, 44);
            TEXTIDPEDIDO.Name = "TEXTIDPEDIDO";
            //TEXTIDPEDIDO.Size = new Size(25, 13);
            TEXTIDPEDIDO.TabIndex = 1;
            TEXTIDPEDIDO.Text = "#"+id;

            if (panelPedidoStatus.Location.X > panelPedidoOrdem.Location.X ||
              panelPedidoStatus.Location.Y > panelPedidoOrdem.Location.Y)
            {
                panelPedidoOrdem.AutoScroll = true;
                /* Se o AutoScrollMargin estiver definido como menos
                   que (5,5), defina-o para 5,5. */
                if (panelPedidoOrdem.AutoScrollMargin.Width < 5 ||
                   panelPedidoOrdem.AutoScrollMargin.Height < 5)
                {
                    panelPedidoOrdem.SetAutoScrollMargin(5, 5);
                }
            }

            posicao1 += 84;


        }

        public void carregarStatusPedido(int i)
        {
            if (i == 0)
            {
                i = 1;
            }

            mouseClick = "";
            posicao1 = 3;
            panelPedidoOrdem.Controls.Clear();

            PedidoNegocios pedidoNegocios = new PedidoNegocios();
            SituacaoColletion situacaoCollecion = new SituacaoColletion();

            situacaoCollecion = pedidoNegocios.ConsultarTiposSituacao(0, "");

            this.situacaoBindingSource.DataSource = situacaoCollecion;

            PedidoColletion pedidoCollection = new PedidoColletion();
            pedidoCollection = pedidoNegocios.ConsultarPorSituacaoOuTodos(i, null);

            
            //int posicao1 = 3;
            foreach (Pedido pedido in pedidoCollection)
            {
                //if (pedido.Situacao.Descricao == "Em preparo")
                //{
                    //panelPedidoStatus = new Panel();
                    //panelPedidoStatus.BackColor = Color.Purple;
                    //panelPedidoStatus.Location = new Point(3, posicao1);
                    //panelPedidoStatus.Name = "panelPedido"+posicao1;
                    //panelPedidoStatus.Size = new Size(221, 78);
                    //panelPedidoStatus.TabIndex = 15;
                    //SetAutoScrollMargins();
                    //panelPedidoOrdem.Controls.Add(panelPedidoStatus);

                    //posicao1 += 84;
                    string descricao = pedido.Situacao.Descricao;
                    string nome = pedido.Pessoa.NomeCompleto;
                    DateTime dataTime = Convert.ToDateTime(pedido.DataHora);
                    string id = Convert.ToString(pedido.IdPedido);
                    
                    string data = dataTime.ToShortTimeString();
                    //dateTime.ToString("hh:mm tt");

                    painelPedido(descricao, nome, data, id);

                //}
            }
        }
        private void FrmPedido_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void PANEL_MouseMove(object sender, MouseEventArgs e)
        {
            Panel painel = sender as Panel;

            if (Convert.ToString(painel.Tag) != mouseClick) 
            {
                painel.BackColor = Color.FromArgb(80,35,135);
                painel.ForeColor = Color.White;
            }
                
        }

        private void PANEL_MouseLeave(object sender, EventArgs e)
        {
            Panel painel = sender as Panel;

            if (Convert.ToString(painel.Tag) != mouseClick)
            {
                painel.BackColor = Color.Gainsboro;
                painel.ForeColor = Color.Black;
                painel.BorderStyle = BorderStyle.FixedSingle;
            }

        }

        private void padraoPainelStatus(Panel painel)
        {
            
            painel.BackColor = Color.Gainsboro;
            painel.ForeColor = Color.Black;
            painel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PANEL_MouseClick(object sender, MouseEventArgs e)
        {

            Panel painel = sender as Panel;

            if (Convert.ToString(painel.Tag) != mouseClick)
            {
                panelPedidoDetal.Visible = true;
                iconPrint.Visible = true;
                painel.BorderStyle = BorderStyle.Fixed3D;
                painel.BackColor = Color.FromArgb(56, 24, 95);

                if (mouseClick != "")
                {
                    padraoPainelStatus(ativado);
                }


                mouseClick = Convert.ToString(painel.Tag);
                ativado = painel;

                PedidoNegocios pedidoNegocios = new PedidoNegocios();
                PedidoColletion pedidoCollection = new PedidoColletion();
                ClienteNegocios clienteNegocios = new ClienteNegocios();
                ClienteCollection clienteCollection = new ClienteCollection();
                PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();
                PedidoItemColletion pedidoItemCollection = new PedidoItemColletion();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();

                Point pt = new Point();
                pt.X = 203;
                pt.Y = 44;

                Control idtext = painel.GetChildAtPoint(pt, GetChildAtPointSkip.None);
                string id = idtext.Text.Replace("#", "");

                pedidoCollection = pedidoNegocios.ConsultarPorId(int.Parse(id));

                pedido = pedidoCollection.Find(x => x.IdPedido == int.Parse(id));

                textBoxPedidoNum.Text = Convert.ToString(pedido.IdPedido);
                DateTime dataTime = Convert.ToDateTime(pedido.DataHora);
                string time = dataTime.ToShortTimeString();
                textBoxPedidoHorario.Text = time;

                //Cor status txt
                if (pedido.Situacao.Descricao == "Em preparo")
                {
                    textPedidoStatus.BackColor = Color.Yellow;
                    textPedidoStatus.ForeColor = Color.Black;
                }
                else if (pedido.Situacao.Descricao == "Aberto")
                {
                    textPedidoStatus.BackColor = Color.Red;
                    textPedidoStatus.ForeColor = Color.White;
                }
                else if (pedido.Situacao.Descricao == "Pronto")
                {
                    textPedidoStatus.BackColor = Color.Orange;
                    textPedidoStatus.ForeColor = Color.Black;
                }
                else if (pedido.Situacao.Descricao == "Enviando")
                {
                    textPedidoStatus.BackColor = Color.Blue;
                    textPedidoStatus.ForeColor = Color.White;
                }
                else if (pedido.Situacao.Descricao == "Finalizado")
                {
                    textPedidoStatus.BackColor = Color.Green;
                    textPedidoStatus.ForeColor = Color.Black;
                }
                //

                textPedidoStatus.Text = pedido.Situacao.Descricao;

                clienteCollection = clienteNegocios.ConsultarNome(pedido.Pessoa.NomeCompleto);

                cliente = clienteCollection.Find(x => x.NomeCompleto == pedido.Pessoa.NomeCompleto);

                textPedidoNome.Text = cliente.NomeCompleto;
                textBoxRua.Text = cliente.Rua;
                textBoxMunicipio.Text = cliente.Municipio;
                textBoxCidade.Text = cliente.Cidade;
                textBoxReferencia.Text = cliente.PontoReferencia;
                textPedidoTel.Text = cliente.Telefone;
                textPedidoTel2.Text = cliente.Telefone1;

                dgwItens.AutoGenerateColumns = false;
                dgwItens.DataSource = null;
                pedidoItemCollection = pedidoItemNegocios.Consultar(pedido.IdPedido);
                dgwItens.DataSource = pedidoItemCollection;
                dgwItens.Update();
                dgwItens.Refresh();


                decimal ValorT = 0;
                pnlValorT.Visible = true;

                foreach (PedidoItem vt in pedidoItemCollection)
                {
                    ValorT += vt.ValorTotal;
                }

                decimal ValorLiquid = ValorT - pedido.TotalDesconto;

                tbxValorBruto.Text = String.Format("{0:c}", ValorT);
                tbxDesc.Text = String.Format("{0:c}", pedido.TotalDesconto);
                tbxValorTotal.Text = String.Format("{0:c}", ValorLiquid);

            }

        }

        private void dgwItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgwItens.Rows[e.RowIndex].DataBoundItem != null) && (dgwItens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgwItens.Rows[e.RowIndex].DataBoundItem, dgwItens.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void textValorTotal_MouseClick(object sender, MouseEventArgs e)
        {
            tbxValorTotal.SelectAll();
        }

    }
}
