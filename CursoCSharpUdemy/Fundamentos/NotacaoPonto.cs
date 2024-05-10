using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá ".ToUpper().Insert(3, "World!").Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine(saudacao.Length);

            //a notação ponto não deve ser usada em variáveis vazias. Por isso usamos o "?", pois é verificado se a variável não está vazia.
            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length);
        }
    }
}
