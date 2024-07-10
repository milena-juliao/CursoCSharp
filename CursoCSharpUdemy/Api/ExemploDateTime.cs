using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Api
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            var hojeSemHora = DateTime.Today;
            Console.WriteLine(hojeSemHora);

            var hojeComHora = DateTime.Now;
            Console.WriteLine(hojeComHora);
            Console.WriteLine("Hora: " + hojeComHora.Hour);
            Console.WriteLine("Minutes: " + hojeComHora.Minute);

            var amanha = hojeComHora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = hojeComHora.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(hojeComHora.ToString("dd"));
            Console.WriteLine(hojeComHora.ToString("d"));
            Console.WriteLine(hojeComHora.ToString("D"));
            Console.WriteLine(hojeComHora.ToString("g"));
            Console.WriteLine(hojeComHora.ToString("G"));
            Console.WriteLine(hojeComHora.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
