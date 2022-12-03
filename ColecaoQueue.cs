using System;
using System.Collections.Generic;
using System.Collections;

namespace Exercicios_Udemy
{
    class ColecaoQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Taldo");
            fila.Enqueue("Naldo");
            fila.Enqueue("Saldo");

            Console.WriteLine($"{fila.Peek()}"); //pega primeiro item da queue sem romover
            Console.WriteLine($"{fila.Count}");

            Console.WriteLine($"{fila.Dequeue()}"); //tira da queue
            Console.WriteLine($"{fila.Count}");

            foreach (var pessoa in fila)
            {
                Console.WriteLine($"{pessoa}");
            }

            var salada = new Queue();

            salada.Enqueue("Cenoura");
            salada.Enqueue(3);
            salada.Enqueue(true);


            Console.WriteLine(salada.Contains("Cenoura")); ;
        }
    }
}
