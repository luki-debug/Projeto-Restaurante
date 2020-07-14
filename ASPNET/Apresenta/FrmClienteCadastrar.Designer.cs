namespace teste
{
    partial class FrmClienteCadastrar
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.buttonClienteSalvar = new System.Windows.Forms.Button();
            this.buttonClienteCancelar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelTelefone1 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxTelefone1 = new System.Windows.Forms.TextBox();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReferencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 11;
            this.labelCodigo.Text = "Código";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 60);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(82, 13);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "Nome Completo";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 115);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(12, 168);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 15;
            this.labelCPF.Text = "CPF";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Location = new System.Drawing.Point(239, 9);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(42, 13);
            this.labelRua.TabIndex = 18;
            this.labelRua.Text = "Rua Nº";
            this.labelRua.Click += new System.EventHandler(this.labelEndereco_Click);
            // 
            // buttonClienteSalvar
            // 
            this.buttonClienteSalvar.Location = new System.Drawing.Point(264, 276);
            this.buttonClienteSalvar.Name = "buttonClienteSalvar";
            this.buttonClienteSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonClienteSalvar.TabIndex = 9;
            this.buttonClienteSalvar.Text = "&Salvar";
            this.buttonClienteSalvar.UseVisualStyleBackColor = true;
            this.buttonClienteSalvar.Click += new System.EventHandler(this.buttonClienteSalvar_Click);
            // 
            // buttonClienteCancelar
            // 
            this.buttonClienteCancelar.Location = new System.Drawing.Point(351, 276);
            this.buttonClienteCancelar.Name = "buttonClienteCancelar";
            this.buttonClienteCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonClienteCancelar.TabIndex = 10;
            this.buttonClienteCancelar.Text = "&Cancelar";
            this.buttonClienteCancelar.UseVisualStyleBackColor = true;
            this.buttonClienteCancelar.Click += new System.EventHandler(this.buttonClienteCancelar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 23);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(63, 20);
            this.textBoxCodigo.TabIndex = 12;
            this.textBoxCodigo.TabStop = false;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 74);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(205, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 129);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(12, 182);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(81, 20);
            this.textBoxCPF.TabIndex = 2;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(239, 23);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(192, 20);
            this.textBoxRua.TabIndex = 5;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(12, 214);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 16;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelTelefone1
            // 
            this.labelTelefone1.AutoSize = true;
            this.labelTelefone1.Location = new System.Drawing.Point(12, 265);
            this.labelTelefone1.Name = "labelTelefone1";
            this.labelTelefone1.Size = new System.Drawing.Size(94, 13);
            this.labelTelefone1.TabIndex = 17;
            this.labelTelefone1.Text = "Telefone Opcional";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(12, 228);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefone.TabIndex = 3;
            // 
            // textBoxTelefone1
            // 
            this.textBoxTelefone1.Location = new System.Drawing.Point(12, 279);
            this.textBoxTelefone1.Name = "textBoxTelefone1";
            this.textBoxTelefone1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefone1.TabIndex = 4;
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Location = new System.Drawing.Point(239, 74);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(147, 20);
            this.textBoxMunicipio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Municipio";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(239, 125);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(147, 20);
            this.textBoxCidade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cidade";
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.Location = new System.Drawing.Point(239, 182);
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.Size = new System.Drawing.Size(147, 20);
            this.textBoxReferencia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Referência";
            // 
            // FrmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.textBoxReferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMunicipio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTelefone1);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone1);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.buttonClienteCancelar);
            this.Controls.Add(this.buttonClienteSalvar);
            this.Controls.Add(this.labelRua);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.Button buttonClienteSalvar;
        private System.Windows.Forms.Button buttonClienteCancelar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelTelefone1;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxTelefone1;
        private System.Windows.Forms.TextBox textBoxMunicipio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReferencia;
        private System.Windows.Forms.Label label3;
    }
}