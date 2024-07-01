using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
        
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}m de altura!";
        }
    }

    internal class ConstrutorThis
    {
        public static void Executar()
        {
            var Lilie = new Cachorro("Lilie");
            var Cacau = new Cachorro("Cacau", 1.25);

            Console.WriteLine(Lilie);
            Console.WriteLine(Cacau);
        }
    }
}
