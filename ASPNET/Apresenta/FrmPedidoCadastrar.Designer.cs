namespace teste
{
    partial class FrmPedidoCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoCadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPedidoId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPedidoSituacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPedidoData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxItens = new System.Windows.Forms.GroupBox();
            this.btnInserirDesc = new System.Windows.Forms.Button();
            this.labelDescDisable = new System.Windows.Forms.Label();
            this.textBoxDescDisable = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.btnAlterarQtd = new System.Windows.Forms.Button();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.textBoxTotalItem = new System.Windows.Forms.TextBox();
            this.btnPedidoDescInserir = new System.Windows.Forms.Button();
            this.textBoxInserirDesc = new System.Windows.Forms.TextBox();
            this.textBoxPedidoValorUn = new System.Windows.Forms.TextBox();
            this.labelValUn = new System.Windows.Forms.Label();
            this.textBoxPedidoQtd = new System.Windows.Forms.TextBox();
            this.labelQtd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwPedidoItens = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPedidoFecharNovo = new System.Windows.Forms.Button();
            this.btnPedidoCancelarNovo = new System.Windows.Forms.Button();
            this.btnPedidoFinalizarNovo = new System.Windows.Forms.Button();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPedidoCliente = new System.Windows.Forms.Button();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.gbxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // textBoxPedidoId
            // 
            this.textBoxPedidoId.Enabled = false;
            this.textBoxPedidoId.Location = new System.Drawing.Point(375, 30);
            this.textBoxPedidoId.Name = "textBoxPedidoId";
            this.textBoxPedidoId.ReadOnly = true;
            this.textBoxPedidoId.Size = new System.Drawing.Size(120, 20);
            this.textBoxPedidoId.TabIndex = 8;
            this.textBoxPedidoId.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número";
            // 
            // textBoxPedidoSituacao
            // 
            this.textBoxPedidoSituacao.Enabled = false;
            this.textBoxPedidoSituacao.Location = new System.Drawing.Point(518, 97);
            this.textBoxPedidoSituacao.Name = "textBoxPedidoSituacao";
            this.textBoxPedidoSituacao.ReadOnly = true;
            this.textBoxPedidoSituacao.Size = new System.Drawing.Size(121, 20);
            this.textBoxPedidoSituacao.TabIndex = 12;
            this.textBoxPedidoSituacao.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Situação";
            // 
            // textBoxPedidoData
            // 
            this.textBoxPedidoData.Enabled = false;
            this.textBoxPedidoData.Location = new System.Drawing.Point(518, 30);
            this.textBoxPedidoData.Name = "textBoxPedidoData";
            this.textBoxPedidoData.ReadOnly = true;
            this.textBoxPedidoData.Size = new System.Drawing.Size(120, 20);
            this.textBoxPedidoData.TabIndex = 10;
            this.textBoxPedidoData.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data/Hora";
            // 
            // gbxItens
            // 
            this.gbxItens.Controls.Add(this.btnInserirDesc);
            this.gbxItens.Controls.Add(this.labelDescDisable);
            this.gbxItens.Controls.Add(this.textBoxDescDisable);
            this.gbxItens.Controls.Add(this.btnSelecionar);
            this.gbxItens.Controls.Add(this.button2);
            this.gbxItens.Controls.Add(this.codigoTextBox);
            this.gbxItens.Controls.Add(this.comboBoxProduto);
            this.gbxItens.Controls.Add(this.btnAlterarQtd);
            this.gbxItens.Controls.Add(this.labelValorTotal);
            this.gbxItens.Controls.Add(this.labelTotalItem);
            this.gbxItens.Controls.Add(this.textBoxValorTotal);
            this.gbxItens.Controls.Add(this.textBoxTotalItem);
            this.gbxItens.Controls.Add(this.btnPedidoDescInserir);
            this.gbxItens.Controls.Add(this.textBoxInserirDesc);
            this.gbxItens.Controls.Add(this.textBoxPedidoValorUn);
            this.gbxItens.Controls.Add(this.labelValUn);
            this.gbxItens.Controls.Add(this.textBoxPedidoQtd);
            this.gbxItens.Controls.Add(this.labelQtd);
            this.gbxItens.Controls.Add(this.label3);
            this.gbxItens.Controls.Add(this.dgwPedidoItens);
            this.gbxItens.Location = new System.Drawing.Point(12, 134);
            this.gbxItens.Name = "gbxItens";
            this.gbxItens.Size = new System.Drawing.Size(709, 288);
            this.gbxItens.TabIndex = 13;
            this.gbxItens.TabStop = false;
            this.gbxItens.Text = "Itens";
            this.gbxItens.Visible = false;
            // 
            // btnInserirDesc
            // 
            this.btnInserirDesc.Location = new System.Drawing.Point(608, 253);
            this.btnInserirDesc.Name = "btnInserirDesc";
            this.btnInserirDesc.Size = new System.Drawing.Size(94, 24);
            this.btnInserirDesc.TabIndex = 6;
            this.btnInserirDesc.Text = "Inserir desconto";
            this.btnInserirDesc.UseVisualStyleBackColor = true;
            this.btnInserirDesc.Visible = false;
            this.btnInserirDesc.Click += new System.EventHandler(this.btnInserirDesc_Click);
            // 
            // labelDescDisable
            // 
            this.labelDescDisable.AutoSize = true;
            this.labelDescDisable.Location = new System.Drawing.Point(184, 259);
            this.labelDescDisable.Name = "labelDescDisable";
            this.labelDescDisable.Size = new System.Drawing.Size(56, 13);
            this.labelDescDisable.TabIndex = 15;
            this.labelDescDisable.Text = "Desconto:";
            // 
            // textBoxDescDisable
            // 
            this.textBoxDescDisable.Location = new System.Drawing.Point(240, 255);
            this.textBoxDescDisable.Name = "textBoxDescDisable";
            this.textBoxDescDisable.ReadOnly = true;
            this.textBoxDescDisable.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescDisable.TabIndex = 16;
            this.textBoxDescDisable.TabStop = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(322, 34);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(68, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = ". . .";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Codigo", true));
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(9, 35);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(52, 20);
            this.codigoTextBox.TabIndex = 8;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ObjetoTransferencia.Produto);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DataSource = this.produtoBindingSource;
            this.comboBoxProduto.DisplayMember = "Sabor";
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(65, 35);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(204, 21);
            this.comboBoxProduto.TabIndex = 0;
            this.comboBoxProduto.ValueMember = "IdProduto";
            this.comboBoxProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxProduto_KeyDown);
            // 
            // btnAlterarQtd
            // 
            this.btnAlterarQtd.Location = new System.Drawing.Point(478, 33);
            this.btnAlterarQtd.Name = "btnAlterarQtd";
            this.btnAlterarQtd.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarQtd.TabIndex = 11;
            this.btnAlterarQtd.Text = "Alterar Qtd";
            this.btnAlterarQtd.UseVisualStyleBackColor = true;
            this.btnAlterarQtd.Visible = false;
            this.btnAlterarQtd.Click += new System.EventHandler(this.btnPedidoAlterar_Click);
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(356, 259);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(64, 13);
            this.labelValorTotal.TabIndex = 17;
            this.labelValorTotal.Text = "Valor Total: ";
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Location = new System.Drawing.Point(6, 259);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(63, 13);
            this.labelTotalItem.TabIndex = 13;
            this.labelTotalItem.Text = "Total Itens: ";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(420, 255);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.ReadOnly = true;
            this.textBoxValorTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotal.TabIndex = 18;
            this.textBoxValorTotal.TabStop = false;
            // 
            // textBoxTotalItem
            // 
            this.textBoxTotalItem.Location = new System.Drawing.Point(69, 255);
            this.textBoxTotalItem.Name = "textBoxTotalItem";
            this.textBoxTotalItem.ReadOnly = true;
            this.textBoxTotalItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalItem.TabIndex = 14;
            this.textBoxTotalItem.TabStop = false;
            // 
            // btnPedidoDescInserir
            // 
            this.btnPedidoDescInserir.Location = new System.Drawing.Point(562, 33);
            this.btnPedidoDescInserir.Name = "btnPedidoDescInserir";
            this.btnPedidoDescInserir.Size = new System.Drawing.Size(53, 23);
            this.btnPedidoDescInserir.TabIndex = 4;
            this.btnPedidoDescInserir.Text = "Inserir";
            this.btnPedidoDescInserir.UseVisualStyleBackColor = true;
            this.btnPedidoDescInserir.Visible = false;
            this.btnPedidoDescInserir.Click += new System.EventHandler(this.btnPedidoDescInserir_Click);
            // 
            // textBoxInserirDesc
            // 
            this.textBoxInserirDesc.Location = new System.Drawing.Point(555, 255);
            this.textBoxInserirDesc.Name = "textBoxInserirDesc";
            this.textBoxInserirDesc.Size = new System.Drawing.Size(53, 20);
            this.textBoxInserirDesc.TabIndex = 5;
            this.textBoxInserirDesc.Text = "0";
            this.textBoxInserirDesc.Visible = false;
            // 
            // textBoxPedidoValorUn
            // 
            this.textBoxPedidoValorUn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.textBoxPedidoValorUn.Enabled = false;
            this.textBoxPedidoValorUn.Location = new System.Drawing.Point(489, 34);
            this.textBoxPedidoValorUn.Name = "textBoxPedidoValorUn";
            this.textBoxPedidoValorUn.ReadOnly = true;
            this.textBoxPedidoValorUn.Size = new System.Drawing.Size(67, 20);
            this.textBoxPedidoValorUn.TabIndex = 3;
            this.textBoxPedidoValorUn.Visible = false;
            // 
            // labelValUn
            // 
            this.labelValUn.AutoSize = true;
            this.labelValUn.Location = new System.Drawing.Point(489, 18);
            this.labelValUn.Name = "labelValUn";
            this.labelValUn.Size = new System.Drawing.Size(48, 13);
            this.labelValUn.TabIndex = 12;
            this.labelValUn.Text = "Valor Un";
            this.labelValUn.Visible = false;
            // 
            // textBoxPedidoQtd
            // 
            this.textBoxPedidoQtd.Location = new System.Drawing.Point(431, 34);
            this.textBoxPedidoQtd.Name = "textBoxPedidoQtd";
            this.textBoxPedidoQtd.Size = new System.Drawing.Size(41, 20);
            this.textBoxPedidoQtd.TabIndex = 10;
            this.textBoxPedidoQtd.Text = "1";
            this.textBoxPedidoQtd.Visible = false;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(431, 18);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(24, 13);
            this.labelQtd.TabIndex = 9;
            this.labelQtd.Text = "Qtd";
            this.labelQtd.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produto";
            // 
            // dgwPedidoItens
            // 
            this.dgwPedidoItens.AllowUserToAddRows = false;
            this.dgwPedidoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPedidoItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTipo,
            this.colSabor,
            this.colQtd,
            this.colValorUn,
            this.colTotal,
            this.Editar,
            this.Excluir});
            this.dgwPedidoItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwPedidoItens.Location = new System.Drawing.Point(6, 90);
            this.dgwPedidoItens.Name = "dgwPedidoItens";
            this.dgwPedidoItens.ReadOnly = true;
            this.dgwPedidoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPedidoItens.Size = new System.Drawing.Size(695, 160);
            this.dgwPedidoItens.TabIndex = 19;
            this.dgwPedidoItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPedidoItens_CellContentClick);
            this.dgwPedidoItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwPedidoItens_CellFormatting);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Produto.Codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "Produto.Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTipo.Width = 130;
            // 
            // colSabor
            // 
            this.colSabor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSabor.DataPropertyName = "Produto.Sabor";
            this.colSabor.HeaderText = "Sabor";
            this.colSabor.Name = "colSabor";
            this.colSabor.ReadOnly = true;
            this.colSabor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSabor.Width = 130;
            // 
            // colQtd
            // 
            this.colQtd.DataPropertyName = "QtdProduto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQtd.DefaultCellStyle = dataGridViewCellStyle7;
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            this.colQtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQtd.Width = 52;
            // 
            // colValorUn
            // 
            this.colValorUn.DataPropertyName = "ValorUn";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.colValorUn.DefaultCellStyle = dataGridViewCellStyle8;
            this.colValorUn.HeaderText = "ValorUn";
            this.colValorUn.Name = "colValorUn";
            this.colValorUn.ReadOnly = true;
            this.colValorUn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValorUn.Width = 85;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotal.Width = 85;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.ToolTipText = "Click para editar Qtd.";
            this.Editar.Width = 30;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.ToolTipText = "Click para Excluir Produto";
            this.Excluir.Width = 30;
            // 
            // btnPedidoFecharNovo
            // 
            this.btnPedidoFecharNovo.Location = new System.Drawing.Point(647, 429);
            this.btnPedidoFecharNovo.Name = "btnPedidoFecharNovo";
            this.btnPedidoFecharNovo.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoFecharNovo.TabIndex = 5;
            this.btnPedidoFecharNovo.Text = "Fechar";
            this.btnPedidoFecharNovo.UseVisualStyleBackColor = true;
            this.btnPedidoFecharNovo.Click += new System.EventHandler(this.btnPedidoFecharNovo_Click);
            // 
            // btnPedidoCancelarNovo
            // 
            this.btnPedidoCancelarNovo.Location = new System.Drawing.Point(566, 429);
            this.btnPedidoCancelarNovo.Name = "btnPedidoCancelarNovo";
            this.btnPedidoCancelarNovo.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoCancelarNovo.TabIndex = 4;
            this.btnPedidoCancelarNovo.Text = "Cancelar";
            this.btnPedidoCancelarNovo.UseVisualStyleBackColor = true;
            this.btnPedidoCancelarNovo.Visible = false;
            this.btnPedidoCancelarNovo.Click += new System.EventHandler(this.btnPedidoCancelarNovo_Click);
            // 
            // btnPedidoFinalizarNovo
            // 
            this.btnPedidoFinalizarNovo.Location = new System.Drawing.Point(485, 429);
            this.btnPedidoFinalizarNovo.Name = "btnPedidoFinalizarNovo";
            this.btnPedidoFinalizarNovo.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoFinalizarNovo.TabIndex = 3;
            this.btnPedidoFinalizarNovo.Text = "Finalizar";
            this.btnPedidoFinalizarNovo.UseVisualStyleBackColor = true;
            this.btnPedidoFinalizarNovo.Visible = false;
            this.btnPedidoFinalizarNovo.Click += new System.EventHandler(this.btnPedidoFinalizarNovo_Click_1);
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DataSource = this.clienteBindingSource;
            this.comboBoxCliente.DisplayMember = "NomeCompleto";
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(12, 30);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCliente.TabIndex = 0;
            this.comboBoxCliente.ValueMember = "IdPessoa";
            this.comboBoxCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ObjetoTransferencia.Cliente);
            // 
            // btnPedidoCliente
            // 
            this.btnPedidoCliente.Location = new System.Drawing.Point(266, 29);
            this.btnPedidoCliente.Name = "btnPedidoCliente";
            this.btnPedidoCliente.Size = new System.Drawing.Size(40, 23);
            this.btnPedidoCliente.TabIndex = 1;
            this.btnPedidoCliente.Text = ". . .";
            this.btnPedidoCliente.UseVisualStyleBackColor = true;
            this.btnPedidoCliente.Click += new System.EventHandler(this.button1_ClickPedidoCliente);
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(12, 57);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(89, 23);
            this.btnInserirCliente.TabIndex = 2;
            this.btnInserirCliente.Text = "Inserir Cliente";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // FrmPedidoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(733, 471);
            this.Controls.Add(this.btnInserirCliente);
            this.Controls.Add(this.btnPedidoCliente);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.btnPedidoFinalizarNovo);
            this.Controls.Add(this.btnPedidoFecharNovo);
            this.Controls.Add(this.btnPedidoCancelarNovo);
            this.Controls.Add(this.gbxItens);
            this.Controls.Add(this.textBoxPedidoSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPedidoData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPedidoId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPedidoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.FrmPedidoCadastrar_Load);
            this.gbxItens.ResumeLayout(false);
            this.gbxItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPedidoId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPedidoSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPedidoData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxItens;
        private System.Windows.Forms.DataGridView dgwPedidoItens;
        private System.Windows.Forms.Button btnAlterarQtd;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.TextBox textBoxTotalItem;
        private System.Windows.Forms.Button btnPedidoDescInserir;
        private System.Windows.Forms.TextBox textBoxInserirDesc;
        private System.Windows.Forms.TextBox textBoxPedidoValorUn;
        private System.Windows.Forms.Label labelValUn;
        private System.Windows.Forms.TextBox textBoxPedidoQtd;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPedidoFecharNovo;
        private System.Windows.Forms.Button btnPedidoCancelarNovo;
        private System.Windows.Forms.Button btnPedidoFinalizarNovo;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Button btnPedidoCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnInserirDesc;
        private System.Windows.Forms.Label labelDescDisable;
        private System.Windows.Forms.TextBox textBoxDescDisable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
    }
}