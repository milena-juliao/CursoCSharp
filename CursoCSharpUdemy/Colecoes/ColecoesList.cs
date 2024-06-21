﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //aula sobre Igualdade
        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);//Adiciona na lista

            var combo = new List<Produto>//Também adiciona na lista, é apenas uma outra opção
            {
                new Produto("Camisa", 29.9),
                new Produto("Poster", 10),
                new Produto("Boné", 30.5),
            };

            carrinho.AddRange(combo);//Adiciona todos de uma vez à lista
            Console.WriteLine(carrinho.Count);//Exibe os itens da lista
            carrinho.RemoveAt(0);//Remove o item de índice 0

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);//Adiciona um item de valor repetido
            Console.WriteLine(carrinho.LastIndexOf(livro));//Exibe o último item da lista
        }
    }
}
