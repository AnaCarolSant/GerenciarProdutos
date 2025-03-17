using System;
using System.Collections.Generic;

namespace BibliotecaProdutos.Interfaces
{
    public interface IProduto
    {
        int Id { get; }
        string Nome { get; }
        decimal Preco { get; }
        void ExibirDetalhes();
    }
}