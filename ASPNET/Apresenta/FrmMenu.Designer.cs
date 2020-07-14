namespace teste
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.barraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.labelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconProjeto = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonConfig = new FontAwesome.Sharp.IconButton();
            this.iconButtonCliente = new FontAwesome.Sharp.IconButton();
            this.iconButtonProduto = new FontAwesome.Sharp.IconButton();
            this.iconButtonPedido = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panelTitlePrincipal = new System.Windows.Forms.Panel();
            this.labelTituloHome = new System.Windows.Forms.Label();
            this.iconPictureBoxChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.barraStatusPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panelTitlePrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxChild)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            this.barraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelVersao});
            this.barraStatusPrincipal.Location = new System.Drawing.Point(0, 589);
            this.barraStatusPrincipal.Name = "barraStatusPrincipal";
            this.barraStatusPrincipal.Size = new System.Drawing.Size(784, 22);
            this.barraStatusPrincipal.TabIndex = 1;
            this.barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(59, 17);
            this.labelVersao.Text = "Versao 1.0";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuUsuario});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "&Cadastro";
            this.menuCadastro.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(114, 22);
            this.menuCliente.Text = "C&liente";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(114, 22);
            this.menuUsuario.Text = "&Usuario";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "&Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_click);
            // 
            // notifyIconProjeto
            // 
            this.notifyIconProjeto.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconProjeto.Icon")));
            this.notifyIconProjeto.Text = "Projeto Agenda";
            this.notifyIconProjeto.Visible = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(12)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.iconButtonConfig);
            this.panelMenu.Controls.Add(this.iconButtonCliente);
            this.panelMenu.Controls.Add(this.iconButtonProduto);
            this.panelMenu.Controls.Add(this.iconButtonPedido);
            this.panelMenu.Controls.Add(this.iconButtonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 565);
            this.panelMenu.TabIndex = 9;
            // 
            // iconButtonConfig
            // 
            this.iconButtonConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonConfig.FlatAppearance.BorderSize = 0;
            this.iconButtonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonConfig.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonConfig.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonConfig.IconSize = 32;
            this.iconButtonConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfig.Location = new System.Drawing.Point(0, 380);
            this.iconButtonConfig.Name = "iconButtonConfig";
            this.iconButtonConfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonConfig.Rotation = 0D;
            this.iconButtonConfig.Size = new System.Drawing.Size(220, 60);
            this.iconButtonConfig.TabIndex = 5;
            this.iconButtonConfig.Text = "Configuração";
            this.iconButtonConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonConfig.UseVisualStyleBackColor = true;
            this.iconButtonConfig.Click += new System.EventHandler(this.iconButtonConfig_Click);
            // 
            // iconButtonCliente
            // 
            this.iconButtonCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCliente.FlatAppearance.BorderSize = 0;
            this.iconButtonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCliente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButtonCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCliente.IconSize = 32;
            this.iconButtonCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCliente.Location = new System.Drawing.Point(0, 320);
            this.iconButtonCliente.Name = "iconButtonCliente";
            this.iconButtonCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCliente.Rotation = 0D;
            this.iconButtonCliente.Size = new System.Drawing.Size(220, 60);
            this.iconButtonCliente.TabIndex = 4;
            this.iconButtonCliente.Text = "Clientes";
            this.iconButtonCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCliente.UseVisualStyleBackColor = true;
            this.iconButtonCliente.Click += new System.EventHandler(this.iconButtonCliente_Click);
            // 
            // iconButtonProduto
            // 
            this.iconButtonProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProduto.FlatAppearance.BorderSize = 0;
            this.iconButtonProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProduto.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButtonProduto.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProduto.IconSize = 32;
            this.iconButtonProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProduto.Location = new System.Drawing.Point(0, 260);
            this.iconButtonProduto.Name = "iconButtonProduto";
            this.iconButtonProduto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonProduto.Rotation = 0D;
            this.iconButtonProduto.Size = new System.Drawing.Size(220, 60);
            this.iconButtonProduto.TabIndex = 3;
            this.iconButtonProduto.Text = "Produtos";
            this.iconButtonProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProduto.UseVisualStyleBackColor = true;
            this.iconButtonProduto.Click += new System.EventHandler(this.iconButtonProduto_Click);
            // 
            // iconButtonPedido
            // 
            this.iconButtonPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonPedido.FlatAppearance.BorderSize = 0;
            this.iconButtonPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPedido.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonPedido.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonPedido.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonPedido.IconSize = 32;
            this.iconButtonPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPedido.Location = new System.Drawing.Point(0, 200);
            this.iconButtonPedido.Name = "iconButtonPedido";
            this.iconButtonPedido.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPedido.Rotation = 0D;
            this.iconButtonPedido.Size = new System.Drawing.Size(220, 60);
            this.iconButtonPedido.TabIndex = 2;
            this.iconButtonPedido.Text = "Pedidos";
            this.iconButtonPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPedido.UseVisualStyleBackColor = true;
            this.iconButtonPedido.Click += new System.EventHandler(this.iconButtonPedido_Click);
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconSize = 32;
            this.iconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 140);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDashboard.Rotation = 0D;
            this.iconButtonDashboard.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDashboard.TabIndex = 1;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = true;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(177, 96);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // panelTitlePrincipal
            // 
            this.panelTitlePrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(9)))), ((int)(((byte)(34)))));
            this.panelTitlePrincipal.Controls.Add(this.labelTituloHome);
            this.panelTitlePrincipal.Controls.Add(this.iconPictureBoxChild);
            this.panelTitlePrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlePrincipal.Location = new System.Drawing.Point(220, 24);
            this.panelTitlePrincipal.Name = "panelTitlePrincipal";
            this.panelTitlePrincipal.Size = new System.Drawing.Size(564, 75);
            this.panelTitlePrincipal.TabIndex = 11;
            this.panelTitlePrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlePrincipal_MouseDown);
            // 
            // labelTituloHome
            // 
            this.labelTituloHome.AutoSize = true;
            this.labelTituloHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTituloHome.Location = new System.Drawing.Point(60, 32);
            this.labelTituloHome.Name = "labelTituloHome";
            this.labelTituloHome.Size = new System.Drawing.Size(35, 13);
            this.labelTituloHome.TabIndex = 1;
            this.labelTituloHome.Text = "Home";
            // 
            // iconPictureBoxChild
            // 
            this.iconPictureBoxChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(9)))), ((int)(((byte)(34)))));
            this.iconPictureBoxChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxChild.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxChild.Location = new System.Drawing.Point(22, 22);
            this.iconPictureBoxChild.Name = "iconPictureBoxChild";
            this.iconPictureBoxChild.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxChild.TabIndex = 0;
            this.iconPictureBoxChild.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 99);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(564, 9);
            this.panelShadow.TabIndex = 13;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 108);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(564, 481);
            this.panelDesktop.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 56);
            this.panel1.TabIndex = 0;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // FrmMenu
            // 
            this.AccessibleName = "Menu Principal";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitlePrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.barraStatusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto de Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraStatusPrincipal.ResumeLayout(false);
            this.barraStatusPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panelTitlePrincipal.ResumeLayout(false);
            this.panelTitlePrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxChild)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel labelVersao;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.NotifyIcon notifyIconProjeto;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonConfig;
        private FontAwesome.Sharp.IconButton iconButtonCliente;
        private FontAwesome.Sharp.IconButton iconButtonProduto;
        private FontAwesome.Sharp.IconButton iconButtonPedido;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel panelTitlePrincipal;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxChild;
        private System.Windows.Forms.Label labelTituloHome;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    }
}