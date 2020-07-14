namespace teste
{
    partial class FrmProdutoCadastrar
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonProdutoCancelar = new System.Windows.Forms.Button();
            this.buttonProdutoSalvar = new System.Windows.Forms.Button();
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.textBoxSabor = new System.Windows.Forms.TextBox();
            this.labelSabor = new System.Windows.Forms.Label();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.labelTotal300Char = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.produtoTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDagendaDataSet = new teste.BDagendaDataSet();
            this.btnNovotipo = new FontAwesome.Sharp.IconButton();
            this.produtoTipoTableAdapter = new teste.BDagendaDataSetTableAdapters.ProdutoTipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtoTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDagendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(336, 85);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(81, 20);
            this.textBoxValor.TabIndex = 4;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 37);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(336, 71);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 13);
            this.labelCPF.TabIndex = 11;
            this.labelCPF.Text = "Valor";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 13);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Descrição";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(287, 22);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(28, 13);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Tipo";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 23);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "Código";
            // 
            // buttonProdutoCancelar
            // 
            this.buttonProdutoCancelar.Location = new System.Drawing.Point(351, 276);
            this.buttonProdutoCancelar.Name = "buttonProdutoCancelar";
            this.buttonProdutoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonProdutoCancelar.TabIndex = 7;
            this.buttonProdutoCancelar.Text = "&Cancelar";
            this.buttonProdutoCancelar.UseVisualStyleBackColor = true;
            this.buttonProdutoCancelar.Click += new System.EventHandler(this.buttonProdutoCancelar_Click);
            // 
            // buttonProdutoSalvar
            // 
            this.buttonProdutoSalvar.Location = new System.Drawing.Point(264, 276);
            this.buttonProdutoSalvar.Name = "buttonProdutoSalvar";
            this.buttonProdutoSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonProdutoSalvar.TabIndex = 6;
            this.buttonProdutoSalvar.Text = "&Salvar";
            this.buttonProdutoSalvar.UseVisualStyleBackColor = true;
            this.buttonProdutoSalvar.Click += new System.EventHandler(this.buttonProdutoSalvar_Click);
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(118, 37);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.Size = new System.Drawing.Size(44, 20);
            this.textBoxIdProduto.TabIndex = 13;
            this.textBoxIdProduto.Visible = false;
            // 
            // textBoxSabor
            // 
            this.textBoxSabor.Location = new System.Drawing.Point(12, 85);
            this.textBoxSabor.Name = "textBoxSabor";
            this.textBoxSabor.Size = new System.Drawing.Size(194, 20);
            this.textBoxSabor.TabIndex = 2;
            // 
            // labelSabor
            // 
            this.labelSabor.AutoSize = true;
            this.labelSabor.Location = new System.Drawing.Point(12, 71);
            this.labelSabor.Name = "labelSabor";
            this.labelSabor.Size = new System.Drawing.Size(35, 13);
            this.labelSabor.TabIndex = 9;
            this.labelSabor.Text = "Sabor";
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(12, 135);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(405, 96);
            this.richTextBoxDescricao.TabIndex = 5;
            this.richTextBoxDescricao.Text = "";
            // 
            // labelTotal300Char
            // 
            this.labelTotal300Char.AutoSize = true;
            this.labelTotal300Char.Location = new System.Drawing.Point(294, 234);
            this.labelTotal300Char.Name = "labelTotal300Char";
            this.labelTotal300Char.Size = new System.Drawing.Size(123, 13);
            this.labelTotal300Char.TabIndex = 0;
            this.labelTotal300Char.Text = "Limite de 300 caracteres";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DataSource = this.produtoTipoBindingSource;
            this.comboBoxTipo.DisplayMember = "Tipo";
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(287, 37);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxTipo.TabIndex = 14;
            this.comboBoxTipo.ValueMember = "IdTipo";
            // 
            // produtoTipoBindingSource
            // 
            this.produtoTipoBindingSource.DataMember = "ProdutoTipo";
            this.produtoTipoBindingSource.DataSource = this.bDagendaDataSet;
            // 
            // bDagendaDataSet
            // 
            this.bDagendaDataSet.DataSetName = "BDagendaDataSet";
            this.bDagendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNovotipo
            // 
            this.btnNovotipo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNovotipo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNovotipo.IconColor = System.Drawing.Color.Black;
            this.btnNovotipo.IconSize = 16;
            this.btnNovotipo.Location = new System.Drawing.Point(15, 276);
            this.btnNovotipo.Name = "btnNovotipo";
            this.btnNovotipo.Rotation = 0D;
            this.btnNovotipo.Size = new System.Drawing.Size(97, 23);
            this.btnNovotipo.TabIndex = 15;
            this.btnNovotipo.Text = "Inserir Novo Tipo";
            this.btnNovotipo.UseVisualStyleBackColor = true;
            this.btnNovotipo.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // produtoTipoTableAdapter
            // 
            this.produtoTipoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProdutoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.btnNovotipo);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelTotal300Char);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.labelSabor);
            this.Controls.Add(this.textBoxSabor);
            this.Controls.Add(this.textBoxIdProduto);
            this.Controls.Add(this.buttonProdutoCancelar);
            this.Controls.Add(this.buttonProdutoSalvar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.produtoTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDagendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonProdutoCancelar;
        private System.Windows.Forms.Button buttonProdutoSalvar;
        private System.Windows.Forms.TextBox textBoxIdProduto;
        private System.Windows.Forms.TextBox textBoxSabor;
        private System.Windows.Forms.Label labelSabor;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Label labelTotal300Char;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private FontAwesome.Sharp.IconButton btnNovotipo;
        private BDagendaDataSet bDagendaDataSet;
        private System.Windows.Forms.BindingSource produtoTipoBindingSource;
        private BDagendaDataSetTableAdapters.ProdutoTipoTableAdapter produtoTipoTableAdapter;
    }
}