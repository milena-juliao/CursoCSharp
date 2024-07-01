using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();//diz que não é uma herança mas sim itens do mesmo projeto.

        public new void MeusAcessos()
        {
            Console.WriteLine("Amigo Próximo: ");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);//não está visível
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);//não está visível
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);//não está visível

        }
    }
}
