using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Cliente;

namespace FastFood.Pedido
{
    public class Pedidos
    {
        public int numpedido;
        public double total;
        public double frete;
        public string tipopagamento;
        public string datapedido;

        public Clientes solicitante;
    }
}
