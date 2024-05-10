using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturaDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if(i % 2 == 1)//se o módulo do valor for igual a 1 ele vai entrar no if
                {
                    continue;//se o if for verdadeiro o CONTINUE interrompe o if e volta para o laço de repetição
                }

                Console.WriteLine(i + " ");
            }
        }
    }
}
