using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CursoCSharpUdemy.TopicosAvancados
{
    internal class LINQ1
    {
        public class Aluno
        {
            public string Nome;
            public int Idade;
            public double Nota;
        }

        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados ==============================");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);

            foreach(var a in aprovados)
            {
                Console.WriteLine(a.Nome);
            }

            Console.WriteLine("\n== Chamada ==============================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach (var c in chamada)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\n== Aprovados (por idade) ==============================");
            var alunosAprovadosIdade = 
                from a in alunos 
                where a.Nota >= 7 
                orderby a.Idade 
                select a.Nome;

            foreach (var a in alunosAprovadosIdade)
            {
                Console.WriteLine(a);
            }
        }
    }
}
