using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];

            alunos[0] = "Gabriel";
            alunos[1] = "Amora";
            alunos[2] = "Lauany";
            alunos[3] = "Marica";
            alunos[4] = "Nego do Borel";


            foreach (var aluno in alunos)
            {
                Console.WriteLine($" {aluno}");
            }
        }

    }
}
