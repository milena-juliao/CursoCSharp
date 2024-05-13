using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar (int a, int b)
        {
            return a * b;
        }
    }

    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            //Estático
            var resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            //Instância
            CalculadoraEstatica calc = new CalculadoraEstatica();
            int resultado2 = calc.Multiplicar(3, 3);
            Console.WriteLine("Resultado: {0}", resultado2);
        }
    }
}
