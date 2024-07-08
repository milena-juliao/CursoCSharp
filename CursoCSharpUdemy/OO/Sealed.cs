using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.OO
{
    sealed class SemFilho//Não pode ser herdado
    {
        public double ValorDaFortuna()
        {
            return 1_000_000.90;
        }
    }

    //class SouFilho : SemFilho//Não pode herdar
    //{

    //}

    class Avo
    {
        public virtual bool NomeFamilia()
        {
            return true;
        }
    }

    class Mae : Avo
    {
        public sealed override bool NomeFamilia()
        {
            return true;
        }
    }

    class FilhaRebelde : Mae
    {
        //public override bool NomeFamilia()//não é possível sobrescrever sealed
        //{
        //    return false;
        //}
    }

    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhaRebelde filha = new FilhaRebelde();
            Console.WriteLine(filha.NomeFamilia());
        }
    }
}