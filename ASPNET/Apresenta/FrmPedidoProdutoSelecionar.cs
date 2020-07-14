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

namespace teste
{
    public partial class FrmPedidoProdutoSelecionar : Form
    {
        public Produto produtoSelecionado { get; set; }
        public FrmPedidoProdutoSelecionar()
        {
            InitializeComponent();
        }

        private void btnPedidoClienteCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnPedidoClientePesq_Click(object sender, EventArgs e)
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColletion produtoColletion = new ProdutoColletion();

            dgwPedidoProdutoSel.DataSource = null;
            produtoColletion = produtoNegocios.ProdutoConsultarPorTipo(null,null,textBoxPedidoConsul.Text);
            dgwPedidoProdutoSel.DataSource = produtoColletion;
            dgwPedidoProdutoSel.Update();
            dgwPedidoProdutoSel.Refresh();
        }

        private void btnPedidoClienteSel_Click(object sender, EventArgs e)
        {
            if(dgwPedidoProdutoSel.Rows.Count < 0)
            {
                MessageBox.Show("Nenhuma linha Selecionada.");
                return;
            }

            produtoSelecionado = dgwPedidoProdutoSel.SelectedRows[0].DataBoundItem as Produto;
            DialogResult = DialogResult.OK;
        }
    }
}
