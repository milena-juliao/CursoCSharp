using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            //int i = 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //    i++;
            //}

            //Mesma coisa só que usando For
            //for(i = 1; i<=10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            //Média da turma
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine(); //recebe o tamanho da turma
            int.TryParse(entrada, out int tamanhoTurma);//verifica se é um número válido senão atribui 0

            for(int i = 1; i <= tamanhoTurma; i++)//enquanto i for menor que o tamanho da turma digitado ele vai continuar entrando no bloco
            {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();//recebe a nota do respectivo aluno
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;//guarda no somatório a nota de todos os aluno, que em cada interação é somada ao valor anterior dele
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Média da turma: {0}", media);
        }
    }
}
