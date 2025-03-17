namespace ConsoleApp
{
    using BibliotecaProdutos.Services;

    file class Program
    {
        static void Main()
        {
            ProdutoService produtoService = new();

            while (true)
            {
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                var opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine() ?? "";
                        Console.Write("Preço do produto: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal preco))
                        {
                            produtoService.CadastrarProduto(nome, preco);
                        }
                        else
                        {
                            Console.WriteLine("Preço inválido.\n");
                        }
                        break;

                    case "2":
                        produtoService.MostrarProdutos();
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.\n");
                        break;
                }
            }
        }
    }
}