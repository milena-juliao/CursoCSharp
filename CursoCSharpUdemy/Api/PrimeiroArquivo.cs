using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharpUdemy.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Criando");
                    sw.WriteLine("o primeiro");
                    sw.WriteLine("arquivo de texto!");
                }
            }

            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("Adicionando");
                sw.WriteLine("Mais Texto!");
            }
        }
    }
}
