using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharpUdemy.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/OneDrive/Área de Trabalho/CursoCSharpUdemy/CursoCSharpUdemy/Api/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Azul;3.60;20");
                    sw.WriteLine("Estojo verde;12.50;10");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
