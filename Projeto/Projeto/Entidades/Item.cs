

namespace Projeto.Entidades
{
    class Item
    {
        public int CodigoItem { get; private set; }
        public Produto Produto { get; private set; }
        public double Quantidade { get; private set; }
        public double Preco { get; private set; }

        public Item()
        {

        }

        public Item (Produto produto, double quantidade, double preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double subTotal()
        {
            return Preco * Quantidade;
        }
    }
}
