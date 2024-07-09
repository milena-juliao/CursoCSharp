using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Action não possui retorno");
            };

            algoNoConsole();

            //----------------------------------------------------------------------------

            Func<int> jogarDdado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);//obrigatóriamente precisa de um retorno
            };

            Console.WriteLine(jogarDdado());

            //----------------------------------------------------------------------------

            Func<int, string> conversorHex = numero => numero.ToString("X"); //Função em apenas uma linha. <int (é o tipo de parâmetro que vai receber), string (é o tipo de retorno)>
            Console.WriteLine(conversorHex(4321));//converte para hexadecimal

            //----------------------------------------------------------------------------

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 1999));
        }
    }
}
