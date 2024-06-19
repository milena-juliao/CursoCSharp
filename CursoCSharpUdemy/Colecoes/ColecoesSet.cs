using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    internal class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();//HashSet não aceita repetição de itens
            carrinho.Add(livro);//Adiciona na lista

            var combo = new HashSet<Produto>//Também adiciona na lista, é apenas uma outra opção
            {
                new Produto("Camisa", 29.9),
                new Produto("Poster", 10),
                new Produto("Boné", 30.5),
            };

            carrinho.UnionWith(combo);//une uma lista ao set, somente os itens que não sejam duplicados
            //carrinho.AddRange(combo);//Adiciona todos de uma vez à lista
            Console.WriteLine(carrinho.Count);//Exibe os itens da lista
            //carrinho.RemoveAt(0);//Remove o item de índice 0

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);//Adiciona um item de valor repetido
            //Console.WriteLine(carrinho.LastIndexOf(livro));//Exibe o último item da lista
        }
    }
}
