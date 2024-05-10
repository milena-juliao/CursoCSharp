using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double numeroQuebrado = inteiro;
            Console.WriteLine(numeroQuebrado);

            //-------------------------------------------------------------------------------------------

            double nota = 9.7;
            int notaTruncada = (int)nota; //não arredonda, ele remove a casa decimal
            Console.WriteLine($"Nota Truncada: {notaTruncada}");

            //-------------------------------------------------------------------------------------------

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);//converte a string para int
            Console.WriteLine("A idade inserida é: {0}", idadeInteiro);

            //-------------------------------------------------------------------------------------------

            idadeInteiro = Convert.ToInt32(idadeString);//também converte a string para int
            Console.WriteLine("Resultado usando toInt32: {0}", idadeInteiro);

            //-------------------------------------------------------------------------------------------

            Console.WriteLine("Digite o primeiro número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);//ele tenta fazer a conversão de string para número, mas se for letra ele mostra o resultado 0
            Console.WriteLine("Resultado 1: {0}", numero);

            //-------------------------------------------------------------------------------------------

            //faz a mesma função anterior só que escrito de maneira sucinta
            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int numero2);//leio o número digitado pelo usuário e declaro a variável numero2 diretamente aqui
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
