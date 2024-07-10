using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Api
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/NovoDir".ParseHome();
            var novoDirDestino = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/NovoDirDestino".ParseHome();
            var dirProjeto = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ========================");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach( var p in pastas )
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n\n== Arquivos ========================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var a in arquivos)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n\n== Raiz ========================");
            Console.WriteLine(Directory.GetDirectoryRoot(dirProjeto));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
