using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{

    internal class ValorVsReferencia
    {
        public class Dependente
        {
            public string Nome;
            public int Idade;
        }

        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20,
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"Nome: Dependente -> {dep.Nome} Cópia -> {copiaDep.Nome}");
            Console.WriteLine($"Idade: Dependente -> {dep.Idade} Cópia -> {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"Nome: Dependente -> {dep.Nome} Cópia -> {copiaDep.Nome}");
            Console.WriteLine($"Idade: Dependente -> {dep.Idade} Cópia -> {copiaDep.Idade}");

        }
    }

}