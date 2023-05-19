namespace Projeto.Controller
{
    class ItemController
    {
        public int CodigoItem { get; private set; }
        public ProdutoController Produto { get; private set; }
        public double Quantidade { get; private set; }
        public double Preco { get; private set; }

        public ItemController()
        {

        }

        public ItemController(ProdutoController produto, double quantidade, double preco)
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
