namespace teste
{
    partial class FrmPedidoSelecionarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPedidoClienteConsul = new System.Windows.Forms.TextBox();
            this.dgwPedidoClienteSel = new System.Windows.Forms.DataGridView();
            this.btnPedidoClientePesq = new System.Windows.Forms.Button();
            this.btnPedidoClienteSel = new System.Windows.Forms.Button();
            this.btnPedidoClienteCancel = new System.Windows.Forms.Button();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoClienteSel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome I CPF: ";
            // 
            // textBoxPedidoClienteConsul
            // 
            this.textBoxPedidoClienteConsul.Location = new System.Drawing.Point(91, 8);
            this.textBoxPedidoClienteConsul.Name = "textBoxPedidoClienteConsul";
            this.textBoxPedidoClienteConsul.Size = new System.Drawing.Size(254, 20);
            this.textBoxPedidoClienteConsul.TabIndex = 1;
            // 
            // dgwPedidoClienteSel
            // 
            this.dgwPedidoClienteSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPedidoClienteSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colCPF,
            this.colEndereco});
            this.dgwPedidoClienteSel.Location = new System.Drawing.Point(12, 36);
            this.dgwPedidoClienteSel.MultiSelect = false;
            this.dgwPedidoClienteSel.Name = "dgwPedidoClienteSel";
            this.dgwPedidoClienteSel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPedidoClienteSel.Size = new System.Drawing.Size(414, 215);
            this.dgwPedidoClienteSel.TabIndex = 2;
            // 
            // btnPedidoClientePesq
            // 
            this.btnPedidoClientePesq.Location = new System.Drawing.Point(351, 7);
            this.btnPedidoClientePesq.Name = "btnPedidoClientePesq";
            this.btnPedidoClientePesq.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoClientePesq.TabIndex = 3;
            this.btnPedidoClientePesq.Text = "Pesquisar";
            this.btnPedidoClientePesq.UseVisualStyleBackColor = true;
            this.btnPedidoClientePesq.Click += new System.EventHandler(this.btnPedidoClientePesq_Click);
            // 
            // btnPedidoClienteSel
            // 
            this.btnPedidoClienteSel.Location = new System.Drawing.Point(268, 271);
            this.btnPedidoClienteSel.Name = "btnPedidoClienteSel";
            this.btnPedidoClienteSel.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoClienteSel.TabIndex = 4;
            this.btnPedidoClienteSel.Text = "Selecionar";
            this.btnPedidoClienteSel.UseVisualStyleBackColor = true;
            this.btnPedidoClienteSel.Click += new System.EventHandler(this.btnPedidoClienteSel_Click);
            // 
            // btnPedidoClienteCancel
            // 
            this.btnPedidoClienteCancel.Location = new System.Drawing.Point(351, 271);
            this.btnPedidoClienteCancel.Name = "btnPedidoClienteCancel";
            this.btnPedidoClienteCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPedidoClienteCancel.TabIndex = 5;
            this.btnPedidoClienteCancel.Text = "Cancelar";
            this.btnPedidoClienteCancel.UseVisualStyleBackColor = true;
            this.btnPedidoClienteCancel.Click += new System.EventHandler(this.btnPedidoClienteCancel_Click);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "IdPessoa";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "NomeCompleto";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCPF
            // 
            this.colCPF.DataPropertyName = "CPF";
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.DataPropertyName = "Endereco";
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            // 
            // FrmPedidoSelecionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.btnPedidoClienteCancel);
            this.Controls.Add(this.btnPedidoClienteSel);
            this.Controls.Add(this.btnPedidoClientePesq);
            this.Controls.Add(this.dgwPedidoClienteSel);
            this.Controls.Add(this.textBoxPedidoClienteConsul);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidoSelecionarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoClienteSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPedidoClienteConsul;
        private System.Windows.Forms.DataGridView dgwPedidoClienteSel;
        private System.Windows.Forms.Button btnPedidoClientePesq;
        private System.Windows.Forms.Button btnPedidoClienteSel;
        private System.Windows.Forms.Button btnPedidoClienteCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
    }
}