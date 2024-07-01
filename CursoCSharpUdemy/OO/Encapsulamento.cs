using System;
using Encapsulamento;

namespace CursoCSharpUdemy.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido: ");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);//não está visível
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);//não está visível
            //Console.WriteLine(UsaMuitoPhotoshop);//não está visível
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigoDistante = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("Amigo distante: ");
            Console.WriteLine(amigoDistante.InfoPublica);
            //Console.WriteLine(amigoDistante.CorDoOlho);//não está visível
            //Console.WriteLine(amigoDistante.NumeroCelular);//não está visível
            //Console.WriteLine(amigoDistante.JeitoDeFalar);//não está visível
            //Console.WriteLine(amigoDistante.SegredoDeFamilia);//não está visível
            //Console.WriteLine(amigoDistante.UsaMuitoPhotoshop);//não está visível
        }
    }
    internal class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();
        }
    }
}
