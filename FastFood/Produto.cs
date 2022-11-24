using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Pedido;

namespace FastFood.Produtos
{
    public class Produtos
    {
        public int idproduto;
        public string categoria;
        public string descricaocategoria;
        public string nomeproduto;
        public string descricaoproduto;
        public double valor;
        public string marca;
        public int quantidade;

        public Pedidos solicitante;
    }
}
