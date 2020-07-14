using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace teste
{
    public partial class FrmMenu : Form
    {
        //FontAwesome
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FrmMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
           public static Color color1 = Color.FromArgb(172, 126, 241);
           public static Color color2 = Color.FromArgb(249, 118, 176);
           public static Color color3 = Color.FromArgb(253, 138, 114);
           public static Color color4 = Color.FromArgb(95, 77, 221);
           public static Color color5 = Color.FromArgb(249, 88, 155);
           public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitlePrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodos FontAwesome
        private void ActiveButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icone current TituloHome
                iconPictureBoxChild.IconChar = currentBtn.IconChar;
                iconPictureBoxChild.IconColor = color;

            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTituloHome.Text = childForm.Text;
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(29, 12, 48);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

            private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuSair_click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Finalizar aplicação ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      
            if (resultado == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar();
            //frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar();
            //frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.ShowDialog();
        }

        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FrmDashBoard());
        }

        private void iconButtonPedido_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new FrmPedido());
        }

        private void iconButtonProduto_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FrmProduto());
        }

        private void iconButtonCliente_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FrmClienteSelecionar());
        }

        private void iconButtonConfig_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new FrmConfiguracao());
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBoxChild.IconChar = IconChar.Home;
            iconPictureBoxChild.IconColor = Color.MediumPurple;
            labelTituloHome.Text = "Home";
        }
    }
}
