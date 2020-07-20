namespace teste
{
    partial class FrmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToResizeColumns = false;
            this.dataGridViewProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewProduto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduto.ColumnHeadersHeight = 30;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.Tipo,
            this.NomeProduto,
            this.Valor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProduto.EnableHeadersVisualStyles = false;
            this.dataGridViewProduto.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProduto.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewProduto.MultiSelect = false;
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProduto.RowHeadersVisible = false;
            this.dataGridViewProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewProduto.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProduto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduto.Size = new System.Drawing.Size(619, 277);
            this.dataGridViewProduto.TabIndex = 0;
            this.dataGridViewProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.CodigoProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.CodigoProduto.HeaderText = "Código";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "Sabor";
            this.NomeProduto.HeaderText = "Sabor";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 250;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPesquisa.Location = new System.Drawing.Point(63, 37);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(460, 20);
            this.textBoxPesquisa.TabIndex = 2;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisa.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPesquisa.Location = new System.Drawing.Point(12, 39);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(48, 16);
            this.labelPesquisa.TabIndex = 3;
            this.labelPesquisa.Text = "Nome:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(527, 369);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(77, 33);
            this.buttonFechar.TabIndex = 13;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(340, 369);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(77, 33);
            this.buttonConsultar.TabIndex = 12;
            this.buttonConsultar.Text = "Detalhes";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(433, 369);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(77, 33);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(247, 369);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(77, 33);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(154, 369);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(77, 33);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click_1);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(529, 31);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 32);
            this.buttonPesquisar.TabIndex = 14;
            this.buttonPesquisar.Text = "&Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click_1);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(866, 414);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.dataGridViewProduto);
            this.Name = "FrmProduto";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.Shown += new System.EventHandler(this.FrmProduto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}