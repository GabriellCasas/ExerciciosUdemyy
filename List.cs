using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class List
    {
 
        public static void Executar()
        {
            var livro = new Produto("The Lord of The Rings", 54.36);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa By Gordão", 9),
                new Produto("Camisa P", 18),
                new Produto("Camisa G", 15)
            };

            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

        }
    }

    class Produto
    {
        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome;
        public double Preco;

    }
}
