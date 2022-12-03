using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Udemy
{

    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            // para comparar o valor dos objetos e não o espaço de memoria
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    class ColecoesSet
    {
        public static void Executar()
        {

            //hashset usado para não ter itens duplicados mas tambem nao tem index
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Camisa b", 59.9),
                new Produto("Camisa c", 39.9),
                new Produto("Camisa c", 39.9)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
               // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }


            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }

}
