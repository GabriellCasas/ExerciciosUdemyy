using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Udemyy
{
    class OutERef
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero, out int numero2)
        {
            numero = 0;
            numero = numero + 15;

            numero2 = 0;
            numero2 = numero2 + 30;
        }

        public static void Executar() {

            //REF altera o valor passado como parametro, pois foi passado por referencia logo a alteração é visivel mesmo depois de sair do metodo
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

           // OUT "Retorna" um valor pelo parametro que foi passado pra ele, usado pra "retornar" mais de um valor
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }

    }
}
