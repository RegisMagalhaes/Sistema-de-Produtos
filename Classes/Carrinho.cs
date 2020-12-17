using System;
using System.Collections.Generic;


namespace Exercicio_Completo.Classes
{
    public class Carrinho 
    {
        //0 - Criamos uma propriedade para guardar o valor total do carrinho

        public float valorTotal {get;set;}

        //1 - Criamos uma lista que representará nosso carrinho
        List<Produto> carrinho = new List<Produto>();

        //2 - Criamos um método que adiciona o produto ao carrinho, passando o objeto como argumento

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        //3 - Criamos o método que remove o produto do carrinho

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        // 4 - Podemos criar um método para listar os produtos que estão no carrinho
        public void MostrarProdutos()
        {
            if (carrinho!= null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R${p.Preco.ToString("n2)} - {p.Nome}");
                    Console.ResetColor();
                }

                MostrarTotal();
            }
        }

        // 5 - Criamos um método para calcular o total da compra:

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;

                }
                Console.WriteLine($"Total do carrinho R${ValorTotal.ToString("n2)}");
            }else{
                Console.WriteLine("Seu carrinho ainda está vazio!");

            }
            Console.ResetColor();
        }

        //Podemos alterar um determinado produto
        public void Alteraritem(int _codigo,Produto _novoProduto){

            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
        

    }
}