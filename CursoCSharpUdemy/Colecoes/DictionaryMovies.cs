using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class DictionaryMovies
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();//recebe uma chave fixa que não pode ser repetida e um valor

            filmes.Add(2001, "Shrek");
            filmes.Add(2002, "Shrek 2");
            filmes.Add(2007, "Shrek 3");
            filmes.Add(2010, "Shrek para Sempre");

            if (filmes.ContainsKey(2002))
            {
                Console.WriteLine("2002: " + filmes[2002]);//se não encontra, ele quebra a aplicação
                Console.WriteLine("2002: " + filmes.GetValueOrDefault(2002));//se não encontra, apenas mostra vazio
            }

            Console.WriteLine(filmes.ContainsValue("Procurando Nemo"));//Busca pelo valor e não pela chave

            Console.WriteLine($"Removeu? {filmes.Remove(2010)}");

            filmes.TryGetValue(2002, out string filme2002);//confere se o valor existe e armazena na var
            Console.WriteLine($"Filme {filme2002}");

            foreach(var i in filmes.Keys)//percorre e recupera todas as chaves
            {
                Console.WriteLine(i);
            }

            foreach(var f in filmes.Values)//percorre e recupera todos os valores

            {
                Console.WriteLine(f);
            }

            foreach (var filme in filmes)//percorre e recupera tudo.
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
