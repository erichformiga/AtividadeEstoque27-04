using Controller;

namespace Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(
            string nome,
            double preco
        ) {
            this.Nome = nome;
            this.Preco = preco;

            Conexao conexao = new Conexao();
            conexao.Produtos.Add(this);
            conexao.SaveChanges();
        }

        public Produto()
        {

        }

        public static List<Produto> ListarProdutos() {
            Conexao conexao = new Conexao();
            return conexao.Produtos.ToList();
        }

    }
}