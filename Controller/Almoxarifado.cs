namespace Controller
{
    public class Almoxarifado
    {
        public static void CriarAlx(
            string nome,
            double preco
        ) {
            new Model.Produto(nome, preco);
        }
        public static List<Model.Almoxarifado> ListarAlx()
        {
            return Model.Almoxarifado.ListarAlx();
        }
    }
}