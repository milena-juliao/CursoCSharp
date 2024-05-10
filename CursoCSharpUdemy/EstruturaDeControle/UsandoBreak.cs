using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturaDeControle
{
    internal class UsandoBreak
    {
        public static void Executar() { 
            Random numero_aleatorio = new Random();
            int numero = numero_aleatorio.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}. ", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o número que queremos? ", i);
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;//faz com que saia do laço for, indo para próxima linha de código.
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Número encontrado!");
        }
    }
}
