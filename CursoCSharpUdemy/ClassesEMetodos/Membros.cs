using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa humano = new Pessoa();
            humano.Nome = "Milena";
            humano.Idade = 24;

            //Console.WriteLine($"{humano.Nome} tem {humano.Idade} anos.");
            humano.ApresentarNoConsole();

            Pessoa humano2 = new Pessoa();
            humano2.Nome = "Luiz";
            humano2.Idade = 24;

            humano2.ApresentarNoConsole();
        }
    }
}
