using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);//se for um valor válido (um número) ele vai converter para double

            Console.WriteLine("Possui um bom comportamento?");
            entrada = Console.ReadLine();

            //Forma 1
            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";//armazena a compararção direta na variável
            bomComportamento = entrada.ToLower() == "s";//converte sempre o que usuário digitou em letra minúscula e compara se é s ou n

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
