namespace Controller
{
    public class Produto
    {
        public static void CriarProduto(
            string nome,
            double preco
        ) {
            new Model.Produto(nome, preco);
        }
        public static List<Model.Produto> ListarProduto()
        {
            return Model.Produto.ListarProdutos();
        }
    }
}