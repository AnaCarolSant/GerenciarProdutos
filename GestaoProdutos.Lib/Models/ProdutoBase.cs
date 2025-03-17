using BibliotecaProdutos.Interfaces;

namespace BibliotecaProdutos.Models
{
    public abstract class ProdutoBase : IProduto
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public decimal Preco { get; protected set; }

        protected ProdutoBase(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public abstract void ExibirDetalhes();
    }
}