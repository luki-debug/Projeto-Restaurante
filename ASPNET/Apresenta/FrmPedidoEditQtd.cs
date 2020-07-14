using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace teste
{
    public partial class FrmPedidoEditQtd : Form
    {
        int idPedido;
        public FrmPedidoEditQtd(int id)
        {
            InitializeComponent();
            idPedido = id;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();
            PedidoItemColletion pedidoItemCollection = new PedidoItemColletion();

            pedidoItemCollection = pedidoItemNegocios.Consultar(idPedido);

            dgwPedidoItem.DataSource = null;
            dgwPedidoItem.AutoGenerateColumns = false;
            dgwPedidoItem.DataSource = pedidoItemCollection;
            dgwPedidoItem.Update();
            dgwPedidoItem.Refresh();
        }

        private void dgwPedidoItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgwPedidoItem.Rows[e.RowIndex].DataBoundItem != null) && (dgwPedidoItem.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgwPedidoItem.Rows[e.RowIndex].DataBoundItem, dgwPedidoItem.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object carregarPropriedade(object propriedade, string nomePropriedade)
        {
            try
            {
                object retorno = "";

                if (nomePropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;
                    propriedadeAntesDoPonto = nomePropriedade.Substring(0, nomePropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = carregarPropriedade(propertyInfo.GetValue(propriedade, null), nomePropriedade.Substring(nomePropriedade.IndexOf(".") + 1));
                            }
                        }
                    }
                }
                else
                {
                    Type type;
                    PropertyInfo prfInfo;

                    if (propriedade != null)
                    {
                        type = propriedade.GetType();
                        prfInfo = type.GetProperty(nomePropriedade);
                        retorno = prfInfo.GetValue(propriedade, null);
                    }
                }

                return retorno;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
    }
}
