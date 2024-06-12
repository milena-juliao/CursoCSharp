using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Maria";
            alunos[2] = "Cleber";
            alunos[3] = "Renata";
            alunos[4] = "João";

            foreach (string a in alunos)
            {
                Console.WriteLine(a);
            }

            //Média da turma

            double somatorio = 0;
            double[] notas = { 2, 3.8, 10, 9.5, 6.5 };

            foreach (double n in notas)
            {
                somatorio += n;
            }

            //ou

            for (int i = 0; i < notas.Length; i++)
            {
                somatorio += notas[i];
            }

            double media = somatorio/notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'R', 'A', 'Y' };
            string palavra = new string(letras);

            Console.WriteLine(palavra);
        }
    }
}
