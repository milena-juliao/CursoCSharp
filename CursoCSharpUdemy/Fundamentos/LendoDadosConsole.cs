using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class LendoDadosConsole
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();//readline é usado para ler/pedir para o usuário escrever algo

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());//transforma em número inteiro

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//transforma em double e ignora se foi usado vírgula ou ponto para separar casa decimais.

            Console.WriteLine($"Nome: {nome}, Idade: {idade} anos, Salário {salario}");

        }
    }
}
