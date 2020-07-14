using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataHora { get; set; }
        public Situacao Situacao { get; set; }
        public Cliente Pessoa { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalValor { get; set; }
    }
}
