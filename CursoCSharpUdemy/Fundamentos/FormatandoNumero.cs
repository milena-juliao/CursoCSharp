using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//número de casas decimais
            Console.WriteLine(valor.ToString("C"));//transforma o valor em real
            Console.WriteLine(valor.ToString("P"));//transforma o valor em percentual
            Console.WriteLine(valor.ToString("#.##"));//é uma forma de dizer que quero um valor com 2 casas decimais

            CultureInfo culturaBR = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", culturaBR));//transforma em moeda sem nenhuma casa decimal no formato real

            CultureInfo culturaEN = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", culturaEN));//transforma em moeda sem nenhuma casa decimal no formato americano

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//acrescenta 0 a esquerda

        }
    }
}
