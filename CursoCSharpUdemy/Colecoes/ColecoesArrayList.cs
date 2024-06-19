using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach (var i in arrayList)
            {
                Console.WriteLine("{0} -> {1}", i , i.GetType());
            }
        }
    }
}
