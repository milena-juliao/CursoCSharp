using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //tipo | nome da variável = valor;
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45; //apenas 8 bites
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;// mostra o valor mínimo do sbyte que é -128. Byte sem sinal
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue; //apenas 16 bites
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; //apenas 32 bites
            Console.WriteLine("Menor valor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;//Inteiro sem sinal
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; //apenas 64 bites
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string conjuntodeCaracteres = "Armazena um conjunto de letra";
            Console.WriteLine("Conjunto de caracteres " + conjuntodeCaracteres);


        }
    }
}
