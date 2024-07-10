using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharpUdemy.Api
{
    internal class UsandoPath
    {
        public static void Executar()
        {
            var arquivo = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/usando_path.txt".ParseHome();
            var pasta = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/usando_path".ParseHome();

            if (!File.Exists(arquivo))
            {
                using(StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
