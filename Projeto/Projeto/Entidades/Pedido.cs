

using System.Collections.Generic;

namespace Projeto.Entidades
{
    class Pedido
    {
        public int CodigoPedido { get; private set; }
        public List<Item> Items { get; private set; } = new List<Item>();

        public Pedido() 
        {

        }

        public Pedido (int codigoPedido)
        {
            CodigoPedido = codigoPedido;
        }
        public void addItem (Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
           
    }
}
