using System;
using Exercicio_Completo.Classes;

namespace Exercicio_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criamos alguns produtos
            Produto p1 = new Produto(1, "Uncharted 4", 499f);
            Produto p2 = new Produto(2, "The last of us 2", 357f);
            Produto p3 = new Produto(3, "Super Mario Bros", 195f);
            Produto p4 = new Produto(4, "Horizon Zero Dawn", 327f);

            // Adicionamos eles ao carrinho

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            // Mostramos nosso carrinho completo
            carrinho.MostrarProdutos();
        }

    }
}
