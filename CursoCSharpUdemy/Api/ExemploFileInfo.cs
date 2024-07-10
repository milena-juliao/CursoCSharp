using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharpUdemy.Api
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var i in caminhos)
            {
                FileInfo arquivo = new FileInfo(i);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }            
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);

        }
    }
}
