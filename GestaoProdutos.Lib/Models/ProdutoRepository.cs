using BibliotecaProdutos.Models;

namespace BibliotecaProdutos.Repositories
{
    internal class ProdutoRepository
    {
        private readonly List<Produto> produtos = new();
        private int contadorId = 1;

        protected internal void AdicionarProduto(string nome, decimal preco)
        {
            var produto = new Produto(contadorId++, nome, preco);
            produtos.Add(produto);
        }

        internal List<Produto> ListarProdutos() => produtos;
    }
}