using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.OO
{
    interface OperacaoBinaria //Todos os métodos de uma interface são abstratos e devem ser implementados em classes concretas(que possuem corpo)
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Divisao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a / b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var o in operacoes)
            {
                resultado += $"Usando {o.GetType().Name} = {o.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);

            Console.WriteLine(resultado);
        }
    }
}