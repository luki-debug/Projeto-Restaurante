
namespace teste
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPedidoConsultar = new System.Windows.Forms.Button();
            this.buttonPedidoAlterar = new System.Windows.Forms.Button();
            this.buttonPedidoNovo = new System.Windows.Forms.Button();
            this.buttonPedidoEnviar = new System.Windows.Forms.Button();
            this.buttonPedidoCancelar = new System.Windows.Forms.Button();
            this.buttonPedidoFinalizar = new System.Windows.Forms.Button();
            this.panelPedidoDetal = new System.Windows.Forms.Panel();
            this.textBoxPedidoHorario = new System.Windows.Forms.TextBox();
            this.textBoxPedidoNum = new System.Windows.Forms.TextBox();
            this.textPedidoStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwItens = new System.Windows.Forms.DataGridView();
            this.colCodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTelefone2 = new System.Windows.Forms.Label();
            this.textPedidoTel2 = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.labelPedidoMunicipio = new System.Windows.Forms.Label();
            this.labelPedidoCidade = new System.Windows.Forms.Label();
            this.textBoxReferencia = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.textPedidoTel = new System.Windows.Forms.TextBox();
            this.textPedidoNome = new System.Windows.Forms.TextBox();
            this.labelPedidoReferencia = new System.Windows.Forms.Label();
            this.labelPedidoEndereco = new System.Windows.Forms.Label();
            this.labelPedidoTelefone = new System.Windows.Forms.Label();
            this.labelPedidoCliente = new System.Windows.Forms.Label();
            this.labelPedidoHoraIn = new System.Windows.Forms.Label();
            this.labelPedidoNum = new System.Windows.Forms.Label();
            this.pnlValorT = new System.Windows.Forms.Panel();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxValorBruto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxValorTotal = new System.Windows.Forms.TextBox();
            this.labelPedidoValorTotal = new System.Windows.Forms.Label();
            this.panelPedidoOrdem = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxSituacaoPesq = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iconPrint = new FontAwesome.Sharp.IconButton();
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPedidoDetal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItens)).BeginInit();
            this.pnlValorT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPedidoConsultar
            // 
            this.buttonPedidoConsultar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPedidoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.buttonPedidoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidoConsultar.Location = new System.Drawing.Point(23, 421);
            this.buttonPedidoConsultar.Name = "buttonPedidoConsultar";
            this.buttonPedidoConsultar.Size = new System.Drawing.Size(77, 33);
            this.buttonPedidoConsultar.TabIndex = 10;
            this.buttonPedidoConsultar.Text = "Consultar";
            this.buttonPedidoConsultar.UseVisualStyleBackColor = false;
            // 
            // buttonPedidoAlterar
            // 
            this.buttonPedidoAlterar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPedidoAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.buttonPedidoAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidoAlterar.Location = new System.Drawing.Point(692, 421);
            this.buttonPedidoAlterar.Name = "buttonPedidoAlterar";
            this.buttonPedidoAlterar.Size = new System.Drawing.Size(77, 33);
            this.buttonPedidoAlterar.TabIndex = 9;
            this.buttonPedidoAlterar.Text = "Alterar";
            this.buttonPedidoAlterar.UseVisualStyleBackColor = false;
            // 
            // buttonPedidoNovo
            // 
            this.buttonPedidoNovo.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPedidoNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.buttonPedidoNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidoNovo.Location = new System.Drawing.Point(607, 421);
            this.buttonPedidoNovo.Name = "buttonPedidoNovo";
            this.buttonPedidoNovo.Size = new System.Drawing.Size(77, 33);
            this.buttonPedidoNovo.TabIndex = 11;
            this.buttonPedidoNovo.Text = "Novo";
            this.buttonPedidoNovo.UseVisualStyleBackColor = false;
            this.buttonPedidoNovo.Click += new System.EventHandler(this.buttonPedidoNovo_Click);
            // 
            // buttonPedidoEnviar
            // 
            this.buttonPedidoEnviar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPedidoEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.buttonPedidoEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidoEnviar.Location = new System.Drawing.Point(108, 421);
            this.buttonPedidoEnviar.Name = "buttonPedidoEnviar";
            this.buttonPedidoEnviar.Size = new System.Drawing.Size(77, 33);
            this.buttonPedidoEnviar.TabIndex = 12;
            this.buttonPedidoEnviar.Text = "Enviar";
            this.buttonPedidoEnviar.UseVisualStyleBackColor = false;
            // 
            // buttonPedidoCancelar
            // 
            this.buttonPedidoCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPedidoCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.buttonPedidoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidoCancelar.Location = new System.Drawing.Point(777, 421);
            this.buttonPedidoCancelar.Name = "buttonPedidoCancelar";
            this.buttonPedidoCancelar.Size = new System.Drawing.Size(77, 33);
            this.buttonPedidoCancelar.TabIndex = 13;
            this.buttonPedidoCancelar.Text = "Cancelar";
            this.buttonPedidoCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonPedidoFinalizar
            // 
            this.buttonPedidoFinalizar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPedidoFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.buttonPedidoFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedidoFinalizar.Location = new System.Drawing.Point(193, 421);
            this.buttonPedidoFinalizar.Name = "buttonPedidoFinalizar";
            this.buttonPedidoFinalizar.Size = new System.Drawing.Size(77, 33);
            this.buttonPedidoFinalizar.TabIndex = 14;
            this.buttonPedidoFinalizar.Text = "Finalizar";
            this.buttonPedidoFinalizar.UseVisualStyleBackColor = false;
            // 
            // panelPedidoDetal
            // 
            this.panelPedidoDetal.AutoScroll = true;
            this.panelPedidoDetal.AutoScrollMargin = new System.Drawing.Size(5, 10);
            this.panelPedidoDetal.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPedidoDetal.Controls.Add(this.textBoxPedidoHorario);
            this.panelPedidoDetal.Controls.Add(this.textBoxPedidoNum);
            this.panelPedidoDetal.Controls.Add(this.textPedidoStatus);
            this.panelPedidoDetal.Controls.Add(this.groupBox1);
            this.panelPedidoDetal.Controls.Add(this.labelTelefone2);
            this.panelPedidoDetal.Controls.Add(this.textPedidoTel2);
            this.panelPedidoDetal.Controls.Add(this.textBoxCidade);
            this.panelPedidoDetal.Controls.Add(this.textBoxMunicipio);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoMunicipio);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoCidade);
            this.panelPedidoDetal.Controls.Add(this.textBoxReferencia);
            this.panelPedidoDetal.Controls.Add(this.textBoxRua);
            this.panelPedidoDetal.Controls.Add(this.textPedidoTel);
            this.panelPedidoDetal.Controls.Add(this.textPedidoNome);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoReferencia);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoEndereco);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoTelefone);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoCliente);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoHoraIn);
            this.panelPedidoDetal.Controls.Add(this.labelPedidoNum);
            this.panelPedidoDetal.Location = new System.Drawing.Point(300, 41);
            this.panelPedidoDetal.Name = "panelPedidoDetal";
            this.panelPedidoDetal.Size = new System.Drawing.Size(584, 311);
            this.panelPedidoDetal.TabIndex = 2;
            this.panelPedidoDetal.Visible = false;
            // 
            // textBoxPedidoHorario
            // 
            this.textBoxPedidoHorario.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPedidoHorario.Enabled = false;
            this.textBoxPedidoHorario.Location = new System.Drawing.Point(65, 53);
            this.textBoxPedidoHorario.Name = "textBoxPedidoHorario";
            this.textBoxPedidoHorario.ReadOnly = true;
            this.textBoxPedidoHorario.Size = new System.Drawing.Size(86, 20);
            this.textBoxPedidoHorario.TabIndex = 6;
            // 
            // textBoxPedidoNum
            // 
            this.textBoxPedidoNum.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPedidoNum.Enabled = false;
            this.textBoxPedidoNum.Location = new System.Drawing.Point(74, 20);
            this.textBoxPedidoNum.Name = "textBoxPedidoNum";
            this.textBoxPedidoNum.ReadOnly = true;
            this.textBoxPedidoNum.Size = new System.Drawing.Size(64, 20);
            this.textBoxPedidoNum.TabIndex = 0;
            // 
            // textPedidoStatus
            // 
            this.textPedidoStatus.BackColor = System.Drawing.Color.Yellow;
            this.textPedidoStatus.Location = new System.Drawing.Point(432, 20);
            this.textPedidoStatus.Name = "textPedidoStatus";
            this.textPedidoStatus.ReadOnly = true;
            this.textPedidoStatus.Size = new System.Drawing.Size(100, 20);
            this.textPedidoStatus.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dgwItens);
            this.groupBox1.Location = new System.Drawing.Point(24, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 265);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens do Pedido";
            // 
            // dgwItens
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            this.dgwItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoProduto,
            this.colTipo,
            this.colSabor,
            this.colQuant,
            this.colValorUn,
            this.colValorTotal});
            this.dgwItens.Location = new System.Drawing.Point(6, 32);
            this.dgwItens.MultiSelect = false;
            this.dgwItens.Name = "dgwItens";
            this.dgwItens.ReadOnly = true;
            this.dgwItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwItens.Size = new System.Drawing.Size(509, 218);
            this.dgwItens.TabIndex = 24;
            this.dgwItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwItens_CellFormatting);
            // 
            // colCodigoProduto
            // 
            this.colCodigoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCodigoProduto.DataPropertyName = "Produto.Codigo";
            this.colCodigoProduto.HeaderText = "Codigo";
            this.colCodigoProduto.Name = "colCodigoProduto";
            this.colCodigoProduto.ReadOnly = true;
            this.colCodigoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoProduto.Width = 90;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTipo.DataPropertyName = "Produto.Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSabor
            // 
            this.colSabor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSabor.DataPropertyName = "Produto.Sabor";
            this.colSabor.HeaderText = "Sabor";
            this.colSabor.Name = "colSabor";
            this.colSabor.ReadOnly = true;
            this.colSabor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSabor.Width = 130;
            // 
            // colQuant
            // 
            this.colQuant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuant.DataPropertyName = "QtdProduto";
            this.colQuant.HeaderText = "Qtd";
            this.colQuant.Name = "colQuant";
            this.colQuant.ReadOnly = true;
            this.colQuant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuant.Width = 35;
            // 
            // colValorUn
            // 
            this.colValorUn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colValorUn.DataPropertyName = "ValorUn";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.colValorUn.DefaultCellStyle = dataGridViewCellStyle8;
            this.colValorUn.HeaderText = "ValorUn";
            this.colValorUn.Name = "colValorUn";
            this.colValorUn.ReadOnly = true;
            this.colValorUn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colValorUn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValorUn.Width = 51;
            // 
            // colValorTotal
            // 
            this.colValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.colValorTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            this.colValorTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colValorTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValorTotal.Width = 62;
            // 
            // labelTelefone2
            // 
            this.labelTelefone2.AutoSize = true;
            this.labelTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone2.Location = new System.Drawing.Point(383, 106);
            this.labelTelefone2.Name = "labelTelefone2";
            this.labelTelefone2.Size = new System.Drawing.Size(64, 13);
            this.labelTelefone2.TabIndex = 20;
            this.labelTelefone2.Text = "Telefone Alt";
            // 
            // textPedidoTel2
            // 
            this.textPedidoTel2.BackColor = System.Drawing.Color.Gainsboro;
            this.textPedidoTel2.Location = new System.Drawing.Point(453, 104);
            this.textPedidoTel2.Name = "textPedidoTel2";
            this.textPedidoTel2.ReadOnly = true;
            this.textPedidoTel2.Size = new System.Drawing.Size(79, 20);
            this.textPedidoTel2.TabIndex = 19;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxCidade.Location = new System.Drawing.Point(432, 141);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.ReadOnly = true;
            this.textBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidade.TabIndex = 18;
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxMunicipio.Location = new System.Drawing.Point(270, 141);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.ReadOnly = true;
            this.textBoxMunicipio.Size = new System.Drawing.Size(100, 20);
            this.textBoxMunicipio.TabIndex = 17;
            // 
            // labelPedidoMunicipio
            // 
            this.labelPedidoMunicipio.AutoSize = true;
            this.labelPedidoMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoMunicipio.Location = new System.Drawing.Point(218, 143);
            this.labelPedidoMunicipio.Name = "labelPedidoMunicipio";
            this.labelPedidoMunicipio.Size = new System.Drawing.Size(52, 13);
            this.labelPedidoMunicipio.TabIndex = 16;
            this.labelPedidoMunicipio.Text = "Municipio";
            // 
            // labelPedidoCidade
            // 
            this.labelPedidoCidade.AutoSize = true;
            this.labelPedidoCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoCidade.Location = new System.Drawing.Point(392, 143);
            this.labelPedidoCidade.Name = "labelPedidoCidade";
            this.labelPedidoCidade.Size = new System.Drawing.Size(40, 13);
            this.labelPedidoCidade.TabIndex = 15;
            this.labelPedidoCidade.Text = "Cidade";
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxReferencia.Location = new System.Drawing.Point(114, 174);
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.ReadOnly = true;
            this.textBoxReferencia.Size = new System.Drawing.Size(145, 20);
            this.textBoxReferencia.TabIndex = 14;
            // 
            // textBoxRua
            // 
            this.textBoxRua.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRua.Location = new System.Drawing.Point(51, 141);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.ReadOnly = true;
            this.textBoxRua.Size = new System.Drawing.Size(161, 20);
            this.textBoxRua.TabIndex = 13;
            // 
            // textPedidoTel
            // 
            this.textPedidoTel.BackColor = System.Drawing.Color.Gainsboro;
            this.textPedidoTel.Location = new System.Drawing.Point(249, 104);
            this.textPedidoTel.Name = "textPedidoTel";
            this.textPedidoTel.ReadOnly = true;
            this.textPedidoTel.Size = new System.Drawing.Size(100, 20);
            this.textPedidoTel.TabIndex = 12;
            // 
            // textPedidoNome
            // 
            this.textPedidoNome.BackColor = System.Drawing.Color.Gainsboro;
            this.textPedidoNome.Location = new System.Drawing.Point(63, 104);
            this.textPedidoNome.Name = "textPedidoNome";
            this.textPedidoNome.ReadOnly = true;
            this.textPedidoNome.Size = new System.Drawing.Size(100, 20);
            this.textPedidoNome.TabIndex = 11;
            // 
            // labelPedidoReferencia
            // 
            this.labelPedidoReferencia.AutoSize = true;
            this.labelPedidoReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoReferencia.Location = new System.Drawing.Point(24, 176);
            this.labelPedidoReferencia.Name = "labelPedidoReferencia";
            this.labelPedidoReferencia.Size = new System.Drawing.Size(90, 13);
            this.labelPedidoReferencia.TabIndex = 10;
            this.labelPedidoReferencia.Text = "Ponto Referência";
            // 
            // labelPedidoEndereco
            // 
            this.labelPedidoEndereco.AutoSize = true;
            this.labelPedidoEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoEndereco.Location = new System.Drawing.Point(24, 143);
            this.labelPedidoEndereco.Name = "labelPedidoEndereco";
            this.labelPedidoEndereco.Size = new System.Drawing.Size(27, 13);
            this.labelPedidoEndereco.TabIndex = 9;
            this.labelPedidoEndereco.Text = "Rua";
            // 
            // labelPedidoTelefone
            // 
            this.labelPedidoTelefone.AutoSize = true;
            this.labelPedidoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoTelefone.Location = new System.Drawing.Point(200, 106);
            this.labelPedidoTelefone.Name = "labelPedidoTelefone";
            this.labelPedidoTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelPedidoTelefone.TabIndex = 8;
            this.labelPedidoTelefone.Text = "Telefone";
            // 
            // labelPedidoCliente
            // 
            this.labelPedidoCliente.AutoSize = true;
            this.labelPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoCliente.Location = new System.Drawing.Point(24, 106);
            this.labelPedidoCliente.Name = "labelPedidoCliente";
            this.labelPedidoCliente.Size = new System.Drawing.Size(39, 13);
            this.labelPedidoCliente.TabIndex = 7;
            this.labelPedidoCliente.Text = "Cliente";
            // 
            // labelPedidoHoraIn
            // 
            this.labelPedidoHoraIn.AutoSize = true;
            this.labelPedidoHoraIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoHoraIn.Location = new System.Drawing.Point(24, 55);
            this.labelPedidoHoraIn.Name = "labelPedidoHoraIn";
            this.labelPedidoHoraIn.Size = new System.Drawing.Size(41, 13);
            this.labelPedidoHoraIn.TabIndex = 5;
            this.labelPedidoHoraIn.Text = "Horário";
            // 
            // labelPedidoNum
            // 
            this.labelPedidoNum.AutoSize = true;
            this.labelPedidoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoNum.Location = new System.Drawing.Point(24, 22);
            this.labelPedidoNum.Name = "labelPedidoNum";
            this.labelPedidoNum.Size = new System.Drawing.Size(50, 13);
            this.labelPedidoNum.TabIndex = 1;
            this.labelPedidoNum.Text = "Pedido #";
            // 
            // pnlValorT
            // 
            this.pnlValorT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(9)))), ((int)(((byte)(34)))));
            this.pnlValorT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlValorT.Controls.Add(this.tbxDesc);
            this.pnlValorT.Controls.Add(this.label2);
            this.pnlValorT.Controls.Add(this.tbxValorBruto);
            this.pnlValorT.Controls.Add(this.label1);
            this.pnlValorT.Controls.Add(this.tbxValorTotal);
            this.pnlValorT.Controls.Add(this.labelPedidoValorTotal);
            this.pnlValorT.Location = new System.Drawing.Point(300, 345);
            this.pnlValorT.Name = "pnlValorT";
            this.pnlValorT.Size = new System.Drawing.Size(584, 57);
            this.pnlValorT.TabIndex = 26;
            this.pnlValorT.Visible = false;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesc.Location = new System.Drawing.Point(277, 12);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.ReadOnly = true;
            this.tbxDesc.Size = new System.Drawing.Size(82, 26);
            this.tbxDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desc";
            // 
            // tbxValorBruto
            // 
            this.tbxValorBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorBruto.Location = new System.Drawing.Point(106, 12);
            this.tbxValorBruto.Name = "tbxValorBruto";
            this.tbxValorBruto.ReadOnly = true;
            this.tbxValorBruto.Size = new System.Drawing.Size(82, 26);
            this.tbxValorBruto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Bruto";
            // 
            // tbxValorTotal
            // 
            this.tbxValorTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorTotal.Location = new System.Drawing.Point(482, 12);
            this.tbxValorTotal.Name = "tbxValorTotal";
            this.tbxValorTotal.ReadOnly = true;
            this.tbxValorTotal.Size = new System.Drawing.Size(82, 26);
            this.tbxValorTotal.TabIndex = 0;
            this.tbxValorTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textValorTotal_MouseClick);
            // 
            // labelPedidoValorTotal
            // 
            this.labelPedidoValorTotal.AutoSize = true;
            this.labelPedidoValorTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoValorTotal.ForeColor = System.Drawing.Color.White;
            this.labelPedidoValorTotal.Location = new System.Drawing.Point(384, 15);
            this.labelPedidoValorTotal.Name = "labelPedidoValorTotal";
            this.labelPedidoValorTotal.Size = new System.Drawing.Size(98, 22);
            this.labelPedidoValorTotal.TabIndex = 1;
            this.labelPedidoValorTotal.Text = "Valor Liqui";
            // 
            // panelPedidoOrdem
            // 
            this.panelPedidoOrdem.BackColor = System.Drawing.Color.White;
            this.panelPedidoOrdem.Location = new System.Drawing.Point(23, 41);
            this.panelPedidoOrdem.Name = "panelPedidoOrdem";
            this.panelPedidoOrdem.Size = new System.Drawing.Size(271, 361);
            this.panelPedidoOrdem.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxSituacaoPesq
            // 
            this.comboBoxSituacaoPesq.DataSource = this.situacaoBindingSource;
            this.comboBoxSituacaoPesq.DisplayMember = "Descricao";
            this.comboBoxSituacaoPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSituacaoPesq.FormattingEnabled = true;
            this.comboBoxSituacaoPesq.Location = new System.Drawing.Point(23, 14);
            this.comboBoxSituacaoPesq.Name = "comboBoxSituacaoPesq";
            this.comboBoxSituacaoPesq.Size = new System.Drawing.Size(205, 21);
            this.comboBoxSituacaoPesq.TabIndex = 16;
            this.comboBoxSituacaoPesq.ValueMember = "IdSituacao";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconPrint
            // 
            this.iconPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconPrint.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPrint.IconSize = 26;
            this.iconPrint.Location = new System.Drawing.Point(848, 2);
            this.iconPrint.Margin = new System.Windows.Forms.Padding(0);
            this.iconPrint.Name = "iconPrint";
            this.iconPrint.Rotation = 0D;
            this.iconPrint.Size = new System.Drawing.Size(36, 36);
            this.iconPrint.TabIndex = 18;
            this.iconPrint.UseVisualStyleBackColor = false;
            this.iconPrint.Visible = false;
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataSource = typeof(ObjetoTransferencia.Situacao);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(896, 473);
            this.Controls.Add(this.pnlValorT);
            this.Controls.Add(this.iconPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSituacaoPesq);
            this.Controls.Add(this.panelPedidoDetal);
            this.Controls.Add(this.panelPedidoOrdem);
            this.Controls.Add(this.buttonPedidoFinalizar);
            this.Controls.Add(this.buttonPedidoCancelar);
            this.Controls.Add(this.buttonPedidoEnviar);
            this.Controls.Add(this.buttonPedidoNovo);
            this.Controls.Add(this.buttonPedidoConsultar);
            this.Controls.Add(this.buttonPedidoAlterar);
            this.DoubleBuffered = true;
            this.Name = "FrmPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPedido_MouseDown);
            this.panelPedidoDetal.ResumeLayout(false);
            this.panelPedidoDetal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItens)).EndInit();
            this.pnlValorT.ResumeLayout(false);
            this.pnlValorT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPedidoConsultar;
        private System.Windows.Forms.Button buttonPedidoAlterar;
        private System.Windows.Forms.Button buttonPedidoNovo;
        private System.Windows.Forms.Button buttonPedidoEnviar;
        private System.Windows.Forms.Button buttonPedidoCancelar;
        private System.Windows.Forms.Button buttonPedidoFinalizar;
        private System.Windows.Forms.Panel panelPedidoDetal;
        private System.Windows.Forms.Panel panelPedidoOrdem;
        private System.Windows.Forms.Label labelTelefone2;
        private System.Windows.Forms.TextBox textPedidoTel2;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxMunicipio;
        private System.Windows.Forms.Label labelPedidoMunicipio;
        private System.Windows.Forms.Label labelPedidoCidade;
        private System.Windows.Forms.TextBox textBoxReferencia;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.TextBox textPedidoTel;
        private System.Windows.Forms.TextBox textPedidoNome;
        private System.Windows.Forms.Label labelPedidoReferencia;
        private System.Windows.Forms.Label labelPedidoEndereco;
        private System.Windows.Forms.Label labelPedidoTelefone;
        private System.Windows.Forms.Label labelPedidoCliente;
        private System.Windows.Forms.TextBox textBoxPedidoHorario;
        private System.Windows.Forms.Label labelPedidoHoraIn;
        private System.Windows.Forms.TextBox textPedidoStatus;
        private System.Windows.Forms.Label labelPedidoNum;
        private System.Windows.Forms.TextBox textBoxPedidoNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgwItens;
        private System.Windows.Forms.Panel pnlValorT;
        private System.Windows.Forms.Label labelPedidoValorTotal;
        private System.Windows.Forms.TextBox tbxValorTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxSituacaoPesq;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxValorBruto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
    }
}