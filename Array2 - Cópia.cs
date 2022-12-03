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

            alunos[0] = "1AssemblyLoadEventArgs";
            alunos[1] = "2AssemblyLoadEventArgs";
            alunos[2] = "3AssemblyLoadEventArgs";
            alunos[3] = "4AssemblyLoadEventArgs";
            alunos[4] = "5AssemblyLoadEventArgs";


            foreach (var aluno in alunos)
            {
                Console.WriteLine($" {aluno}");
            }
        }

    }
}
