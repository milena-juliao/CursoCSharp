using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            //Ou

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            //Ou

            Console.WriteLine($"A marca {marca} é legal!");

            //Outra forma de usar

            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
