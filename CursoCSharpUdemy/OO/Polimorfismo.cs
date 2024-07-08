using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharpUdemy.OO.Polimorfismo;

namespace CursoCSharpUdemy.OO
{
    internal class Polimorfismo
    {
        public class Comida//classe base para o peso recuperar o peso
        {
            public double Peso;

            public Comida(double peso)
            {
                Peso = peso;
            }
        }

        public class Feijao : Comida
        {
            public Feijao(double peso) : base(peso) { }
        }

        public class Arroz : Comida
        {
            public Arroz(double peso) : base(peso) { }
        }

        public class Carne : Comida
        {
            public Carne(double peso) : base(peso) { }
        }
        public class Pessoa
        {
            public double Peso;

            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }
        public static void Executar()
        {
            Feijao refeicao1 = new Feijao(0.3);
            Arroz refeicao2 = new Arroz(0.5);
            Carne refeicao3 = new Carne(0.6);

            Pessoa cliente = new Pessoa();
            cliente.Peso = 60.5;
            cliente.Comer(refeicao1);
            cliente.Comer(refeicao2);
            cliente.Comer(refeicao3);

            Console.WriteLine($"Meu peso atual é {cliente.Peso}");
        }
    }
}