using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PedidoItem
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int QtdProduto { get; set; }
        public decimal PorcentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorUn { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
