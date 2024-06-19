using System;
using System.Collections.Generic;
using System.Collections;//pra usar o queue sem tipar, remover o generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            //Fila aceita repetições

            var fila = new Queue<string>();

            fila.Enqueue("Fulano");//Enqueue -> adiciona um item na fila
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//pega o primeiro elemento da fila
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());//remove o primeiro item da fila
            Console.WriteLine(fila.Count);

            //percorremos a fila com foreach
            foreach(var i in fila)
            {
                Console.WriteLine($"{i}");
            }

            var salada = new Queue();//olhar a importação no topo da página
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Count);
        }
    }
}
