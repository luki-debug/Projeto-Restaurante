using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocio;
using System.Reflection;

namespace teste
{
    public partial class FrmPedidoSelecionarCliente : Form
    {
        public Cliente clienteSelecionado { get; set; }
        public FrmPedidoSelecionarCliente()
        {
            InitializeComponent();
            dgwPedidoClienteSel.AutoGenerateColumns = false;
        }

        private void btnPedidoClienteCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnPedidoClientePesq_Click(object sender, EventArgs e)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteCollection clienteCollection = new ClienteCollection();
            
            dgwPedidoClienteSel.DataSource = null;
            clienteCollection = clienteNegocios.ConsultarNome(textBoxPedidoClienteConsul.Text);
            dgwPedidoClienteSel.DataSource = clienteCollection;
            dgwPedidoClienteSel.Update();
            dgwPedidoClienteSel.Refresh();

        }

        private void btnPedidoClienteSel_Click(object sender, EventArgs e)
        {
            if(dgwPedidoClienteSel.Rows.Count < 0)
            {
                MessageBox.Show("Nenhuma linha Selecionada.");
                return;
            }

            clienteSelecionado = dgwPedidoClienteSel.SelectedRows[0].DataBoundItem as Cliente;
            DialogResult = DialogResult.OK;
        }
    }
}
