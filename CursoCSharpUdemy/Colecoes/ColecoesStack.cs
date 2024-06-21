using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var i in pilha)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");//remove da pilha

            foreach (var i in pilha)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");//apenas recupera o valor, mas não remove.
            Console.WriteLine(pilha.Count);
        }
    }
}
