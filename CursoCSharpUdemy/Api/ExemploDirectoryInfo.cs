using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharpUdemy.Api
{
    internal class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivo =======================");
            var arquivos = dirInfo.GetFiles();
            foreach(var a in arquivos)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n== Diretórios =======================");
            var pastas = dirInfo.GetDirectories();
            foreach (var p in pastas)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
