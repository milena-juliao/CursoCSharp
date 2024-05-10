using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpUdemy.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome; //publico ou privado, tipo e o nome da variável
        public int Idade;

        public string Apresentar()//Método para reutilizar frase
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()//Método para exibir a frase
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()//Método para limpar as variáveis, zerando seus valores
        {
            Nome = "";
            Idade = 0;
        }
    }
}
