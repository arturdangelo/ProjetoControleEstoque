using System.Collections.Generic;

namespace Projeto.Controller
{
    class PedidoController
    {
        public int CodigoPedido { get; private set; }
        public List<ItemController> Items { get; private set; } = new List<ItemController>();

        public PedidoController()
        {

        }

        public PedidoController(int codigoPedido)
        {
            CodigoPedido = codigoPedido;
        }
        public void addItem(ItemController item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItemController item)
        {
            Items.Remove(item);
        }

    }
}
