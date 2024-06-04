using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1; //mesmo sem colocar private na frente, essa variável é privada

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }

            set
            {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Propriedades
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op2.PrecoComDesconto);

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
        }
    }
}