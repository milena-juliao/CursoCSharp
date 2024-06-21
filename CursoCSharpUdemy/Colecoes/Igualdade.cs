using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.50);
            var p2 = new Produto("Caneta", 1.50);
            var p3 = p2;

            Console.WriteLine(p1 == p2);//Falso pois não apontam pro mesmo local de memória
            Console.WriteLine(p3 == p2);//verdadeiro pois apontam pro mesmo local de memória. Atribuição por referência.

            Console.WriteLine(p1.Equals(p2));//na declaração do produto (em ColecoesList) fazemos a vericação dos valores para retornar se eles são iguais ou não
        }
    }
}
