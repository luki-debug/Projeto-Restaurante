namespace teste
{
    partial class FrmProdutoTipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoTipo));
            this.dgwTipo = new System.Windows.Forms.DataGridView();
            this.bDagendaDataSet = new teste.BDagendaDataSet();
            this.produtoTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTipoTableAdapter = new teste.BDagendaDataSetTableAdapters.ProdutoTipoTableAdapter();
            this.textBoxInserirTipo = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.colIdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDagendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTipo
            // 
            this.dgwTipo.AllowUserToAddRows = false;
            this.dgwTipo.AllowUserToDeleteRows = false;
            this.dgwTipo.AllowUserToOrderColumns = true;
            this.dgwTipo.AllowUserToResizeColumns = false;
            this.dgwTipo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgwTipo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTipo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTipo.ColumnHeadersHeight = 30;
            this.dgwTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTipo,
            this.colTipo,
            this.Editar,
            this.Excluir});
            this.dgwTipo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwTipo.EnableHeadersVisualStyles = false;
            this.dgwTipo.Location = new System.Drawing.Point(16, 50);
            this.dgwTipo.MultiSelect = false;
            this.dgwTipo.Name = "dgwTipo";
            this.dgwTipo.RowHeadersVisible = false;
            this.dgwTipo.RowHeadersWidth = 15;
            this.dgwTipo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTipo.Size = new System.Drawing.Size(405, 213);
            this.dgwTipo.TabIndex = 0;
            this.dgwTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTipo_CellContentClick);
            this.dgwTipo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTipo_CellEndEdit);
            this.dgwTipo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwTipo_CellFormatting);
            // 
            // bDagendaDataSet
            // 
            this.bDagendaDataSet.DataSetName = "BDagendaDataSet";
            this.bDagendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTipoBindingSource
            // 
            this.produtoTipoBindingSource.DataMember = "ProdutoTipo";
            this.produtoTipoBindingSource.DataSource = this.bDagendaDataSet;
            // 
            // produtoTipoTableAdapter
            // 
            this.produtoTipoTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxInserirTipo
            // 
            this.textBoxInserirTipo.Location = new System.Drawing.Point(16, 24);
            this.textBoxInserirTipo.Name = "textBoxInserirTipo";
            this.textBoxInserirTipo.Size = new System.Drawing.Size(129, 20);
            this.textBoxInserirTipo.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(145, 22);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 25);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(346, 276);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // colIdTipo
            // 
            this.colIdTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIdTipo.DataPropertyName = "IdTipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.colIdTipo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIdTipo.HeaderText = "Código";
            this.colIdTipo.Name = "colIdTipo";
            this.colIdTipo.ReadOnly = true;
            this.colIdTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 200;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.ToolTipText = "Click para editar Tipo";
            this.Editar.Width = 40;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.ToolTipText = "Click para excluir Tipo";
            this.Excluir.Width = 40;
            // 
            // FrmProdutoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.textBoxInserirTipo);
            this.Controls.Add(this.dgwTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutoTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoTipo";
            this.Load += new System.EventHandler(this.FrmProdutoTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDagendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoTipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTipo;
        private BDagendaDataSet bDagendaDataSet;
        private System.Windows.Forms.BindingSource produtoTipoBindingSource;
        private BDagendaDataSetTableAdapters.ProdutoTipoTableAdapter produtoTipoTableAdapter;
        private System.Windows.Forms.TextBox textBoxInserirTipo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
    }
}