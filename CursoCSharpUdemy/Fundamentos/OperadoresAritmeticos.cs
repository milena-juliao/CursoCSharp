using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);

            Console.WriteLine($"O preço final é: {totalDesconto}");

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); //elevado ao quadrado x²
            Console.WriteLine($"IMC: {imc}.");

            //Número par/impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);//pega o módulo de par/2, que no caso é 0, se for 0 ele é considerado par
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);//pega o módulo de impar/2, se for diferente 0 ele é considerado impar

        }
    }
}
