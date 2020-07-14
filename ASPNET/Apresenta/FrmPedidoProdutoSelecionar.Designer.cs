namespace teste
{
    partial class FrmPedidoProdutoSelecionar
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
            this.btnPedidoClienteCancel = new System.Windows.Forms.Button();
            this.btnPedidoClienteSel = new System.Windows.Forms.Button();
            this.btnPedidoClientePesq = new System.Windows.Forms.Button();
            this.dgwPedidoProdutoSel = new System.Windows.Forms.DataGridView();
            this.textBoxPedidoConsul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoProdutoSel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedidoClienteCancel
            // 
            this.btnPedidoClienteCancel.Location = new System.Drawing.Point(351, 276);
            this.btnPedidoClienteCancel.Name = "btnPedidoClienteCancel";
            this.btnPedidoClienteCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoClienteCancel.TabIndex = 11;
            this.btnPedidoClienteCancel.Text = "Cancelar";
            this.btnPedidoClienteCancel.UseVisualStyleBackColor = true;
            this.btnPedidoClienteCancel.Click += new System.EventHandler(this.btnPedidoClienteCancel_Click);
            // 
            // btnPedidoClienteSel
            // 
            this.btnPedidoClienteSel.Location = new System.Drawing.Point(268, 276);
            this.btnPedidoClienteSel.Name = "btnPedidoClienteSel";
            this.btnPedidoClienteSel.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoClienteSel.TabIndex = 10;
            this.btnPedidoClienteSel.Text = "Selecionar";
            this.btnPedidoClienteSel.UseVisualStyleBackColor = true;
            this.btnPedidoClienteSel.Click += new System.EventHandler(this.btnPedidoClienteSel_Click);
            // 
            // btnPedidoClientePesq
            // 
            this.btnPedidoClientePesq.Location = new System.Drawing.Point(351, 12);
            this.btnPedidoClientePesq.Name = "btnPedidoClientePesq";
            this.btnPedidoClientePesq.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoClientePesq.TabIndex = 9;
            this.btnPedidoClientePesq.Text = "Pesquisar";
            this.btnPedidoClientePesq.UseVisualStyleBackColor = true;
            this.btnPedidoClientePesq.Click += new System.EventHandler(this.btnPedidoClientePesq_Click);
            // 
            // dgwPedidoProdutoSel
            // 
            this.dgwPedidoProdutoSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPedidoProdutoSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colCPF,
            this.colEndereco});
            this.dgwPedidoProdutoSel.Location = new System.Drawing.Point(12, 41);
            this.dgwPedidoProdutoSel.MultiSelect = false;
            this.dgwPedidoProdutoSel.Name = "dgwPedidoProdutoSel";
            this.dgwPedidoProdutoSel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPedidoProdutoSel.Size = new System.Drawing.Size(414, 215);
            this.dgwPedidoProdutoSel.TabIndex = 8;
            // 
            // textBoxPedidoConsul
            // 
            this.textBoxPedidoConsul.Location = new System.Drawing.Point(91, 13);
            this.textBoxPedidoConsul.Name = "textBoxPedidoConsul";
            this.textBoxPedidoConsul.Size = new System.Drawing.Size(254, 20);
            this.textBoxPedidoConsul.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo | Sabor";
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Tipo";
            this.colNome.HeaderText = "Tipo";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCPF
            // 
            this.colCPF.DataPropertyName = "Sabor";
            this.colCPF.HeaderText = "Sabor";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.DataPropertyName = "Valor";
            this.colEndereco.HeaderText = "Valor";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            // 
            // FrmPedidoProdutoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.btnPedidoClienteCancel);
            this.Controls.Add(this.btnPedidoClienteSel);
            this.Controls.Add(this.btnPedidoClientePesq);
            this.Controls.Add(this.dgwPedidoProdutoSel);
            this.Controls.Add(this.textBoxPedidoConsul);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidoProdutoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoProdutoSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedidoClienteCancel;
        private System.Windows.Forms.Button btnPedidoClienteSel;
        private System.Windows.Forms.Button btnPedidoClientePesq;
        private System.Windows.Forms.DataGridView dgwPedidoProdutoSel;
        private System.Windows.Forms.TextBox textBoxPedidoConsul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
    }
}