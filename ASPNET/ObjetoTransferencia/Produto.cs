using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Codigo { get; set; }
        public int IdTipo { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Sabor { get; set; }
    }
}
