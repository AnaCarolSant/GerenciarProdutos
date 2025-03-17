namespace BibliotecaProdutos.Models
{
    public class Produto : ProdutoBase
    {
        internal string Categoria { get; private set; } = "Geral";
        protected internal string CodigoInterno { get; set; } = "0000";
        private protected string DescricaoSecreta { get; set; } = "Confidencial";

        public Produto(int id, string nome, decimal preco) : base(id, nome, preco) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nPreço: R$ {Preco:F2}\nCategoria: {Categoria}\n");
        }
    }
}