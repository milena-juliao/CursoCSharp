using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            dynamic MeuObjeto = "teste";
            MeuObjeto = 3;

            MeuObjeto++;
            Console.WriteLine(MeuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Milena";
            aluno.nota = 10;
            aluno.idade = 25;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");

        }
    }
}
