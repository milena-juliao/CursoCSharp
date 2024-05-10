using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var bolleano = true;

            Console.WriteLine(-valorNegativo);//faz jogo de sinal e converte para positivo (- - = + | - + = -)
            Console.WriteLine(!bolleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            //quando o sinal -- ou ++ vem antes da variável, o incrmento ou decrementação ocorre antes da comparação, podendo resultar em uma confusão no código
            Console.WriteLine(numero1++ == --numero2); //um exemplo de código complexo de entender. Tentar fazer o código o mais legível possível
        }
    }
}
