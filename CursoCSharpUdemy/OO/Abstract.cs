using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();//método abstrato

        public string Tocar()
        {
            return "Trim Trim Trim";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá mneu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá mneu nome é Siri!";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            //Celular c = new Celular();//não é possível instânciar, pois abstract não é algo concreto e sim um conceito.

            var celulares = new List<Celular>
            {
                new Samsung(),
                new Iphone()
            };

            foreach (var c in celulares)
            {
                Console.WriteLine(c.Assistente());
            }
        }
    }
}