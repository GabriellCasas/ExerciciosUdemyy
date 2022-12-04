using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Udemyy
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
            /*var produto = obj as Produto;
            return produto != null &&
                Nome == produto.Nome &&
                Preco == produto.Preco;*/

            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            //var hashCode = -347481536;
            //hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default();

            return Nome.Length;
        }
    }
}
