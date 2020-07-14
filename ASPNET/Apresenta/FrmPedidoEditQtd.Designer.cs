namespace teste
{
    partial class FrmPedidoEditQtd
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
            this.dgwPedidoItem = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPedidoItem
            // 
            this.dgwPedidoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPedidoItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTipo,
            this.colSabor,
            this.colQtd,
            this.colValorUn,
            this.colValorTotal});
            this.dgwPedidoItem.Location = new System.Drawing.Point(12, 150);
            this.dgwPedidoItem.Name = "dgwPedidoItem";
            this.dgwPedidoItem.Size = new System.Drawing.Size(643, 150);
            this.dgwPedidoItem.TabIndex = 0;
            this.dgwPedidoItem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwPedidoItem_CellFormatting);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Produto.Codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "Produto.Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colSabor
            // 
            this.colSabor.DataPropertyName = "Produto.Sabor";
            this.colSabor.HeaderText = "Sabor";
            this.colSabor.Name = "colSabor";
            // 
            // colQtd
            // 
            this.colQtd.DataPropertyName = "QtdProduto";
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.Name = "colQtd";
            // 
            // colValorUn
            // 
            this.colValorUn.DataPropertyName = "ValorUn";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colValorUn.DefaultCellStyle = dataGridViewCellStyle1;
            this.colValorUn.HeaderText = "ValorUn";
            this.colValorUn.Name = "colValorUn";
            this.colValorUn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colValorTotal
            // 
            this.colValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colValorTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colValorTotal.HeaderText = "Total";
            this.colValorTotal.Name = "colValorTotal";
            // 
            // FrmPedidoEditQtd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.dgwPedidoItem);
            this.Name = "FrmPedidoEditQtd";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidoItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPedidoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
    }
}