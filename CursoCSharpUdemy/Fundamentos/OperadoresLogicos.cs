using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var trabalheiSegunda = false;
            var trabalheiTerca = false;

            bool receboTodoSalario = trabalheiSegunda && trabalheiTerca;
            Console.WriteLine("Recebo o salário integral? {0}", receboTodoSalario);

            var compreiLanche = trabalheiSegunda || trabalheiTerca;
            Console.WriteLine("Vou comprar o lanche? {0}", compreiLanche);

            var compreiTv = trabalheiSegunda ^ trabalheiTerca;
            Console.WriteLine("Comprei uma TV nova? {0}", compreiTv);//Apenas um pode ser verdadeiro

            Console.WriteLine("Comprei o lanche? {0} É mais saudável? {1}", compreiLanche, !compreiLanche);
        }
    }
}
