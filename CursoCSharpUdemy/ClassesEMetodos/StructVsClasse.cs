using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    public struct SPonto //Struct Ponto
    {
        public int X;
        public int Y;
    }

    public class CPonto //Classe Ponto
    {
        public int X;
        public int Y;
    }


    internal class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por valor - aponta para um local diferente na memória
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaPonto2 = ponto2; //Atribuição por referência - aponta para o mesmo local de memória
            ponto2.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto2.X);
        }
    }
}