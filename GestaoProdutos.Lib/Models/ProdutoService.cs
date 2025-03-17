using BibliotecaProdutos.Repositories;

namespace BibliotecaProdutos.Services
{
    public class ProdutoService
    {
        private readonly ProdutoRepository produtoRepository = new();

        public void CadastrarProduto(string nome, decimal preco)
        {
            produtoRepository.AdicionarProduto(nome, preco);
            Console.WriteLine("Produto cadastrado com sucesso!\n");
        }

        public void MostrarProdutos()
        {
            var produtos = produtoRepository.ListarProdutos();
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.\n");
                return;
            }
            foreach (var produto in produtos)
            {
                produto.ExibirDetalhes();
            }
        }
    }
}
