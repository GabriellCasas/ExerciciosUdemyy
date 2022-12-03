using System;
using System.Collections;
using System.Text;

namespace Exercicios_Udemy
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
            //aaaaaaaaaaaaaaaaaaaaaaaaaaa
            Console.WriteLine($"\nPick: {pilha.Peek()}");
            Console.WriteLine($"\nPick: {pilha.Count}");
        }
    }
}
