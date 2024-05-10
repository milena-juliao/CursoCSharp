using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturaDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Hello!";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Milena", "André", "Pamela", "Yasmin", "Sara" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
