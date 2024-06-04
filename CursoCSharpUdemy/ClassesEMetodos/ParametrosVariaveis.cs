using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    internal class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)//recebe um parâmetro variável, armazena em um array chamado pessoas
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");

        }
    }
}