using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Desafio: exibir a variável a sem trazer ela para dentro do Executar.

            var desafio = new DesafioAtributo();

            Console.WriteLine(desafio.a);

        }
    }
}