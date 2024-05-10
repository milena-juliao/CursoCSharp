using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharpUdemy.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();//executa a randomização

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 20;
            int tentativa = 0;

            while(tentativasRestantes > 0 && !numeroEncontrado)//enquanto as tentativas restantes forem menor que 0 e o numero não for encontrado
            {
                Console.Write("Insira o palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativa++;//soma quantas tentativas foram necessárias para adivinhar o número
                tentativasRestantes--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;//diz que o número foi encontrado
                    var corAnterior = Console.BackgroundColor;//armazena a cor do background
                    Console.BackgroundColor = ConsoleColor.Green;//troca a cor para green
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativa);
                    Console.BackgroundColor = corAnterior;//retorna para cor inicial
                }else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor..Tente novamente");
                    Console.WriteLine("Numero de tentativas restantees: {0} tentativas", tentativasRestantes);
                }else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Numero de tentativas restantees: {0} tentativas", tentativasRestantes);
                }
            }
        }
    }
}
