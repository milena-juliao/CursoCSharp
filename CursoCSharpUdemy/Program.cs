using System;
using System.Collections.Generic;

using CursoCSharpUdemy.Fundamentos;
using CursoCSharpUdemy.EstruturaDeControle;
using CursoCSharpUdemy.ClassesEMetodos;
using CursoCSharpUdemy.Colecoes;
using CursoCSharpUdemy.OO;
using CursoCSharpUdemy.MetodosEFuncoes;
using CursoCSharpUdemy.Excecoes;
using CursoCSharpUdemy.Api;

namespace CursoCSharp
{
    /// <summary>
    /// Isso é um xml para comentários de várias linhas
    /// </summary>
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados do Console - Fundamentos", LendoDadosConsole.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributo.Executar},
                {"Parâmetros Variáveis - Classes e Métodos", ParametrosVariaveis.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters & Setters - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Propriedades.Executar},
                {"Atributos Readonly - Classes e Métodos", Readonly.Executar},
                {"Enumerações (Enum) - Classes e Métodos", EnumeracoesEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs. Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs. Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetro Padrão - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", CursoCSharpUdemy.Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary Movies - Coleções", DictionaryMovies.Executar},

                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", CursoCSharpUdemy.OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                //Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate com Funções Anônimas - Métodos e Funções", FuncaoAnonimaDelegate.Executar},
                {"Delegate como Parâmetro  - Métodos e Funções", DelegateParametro.Executar},
                {"Métodos de Extensão  - Métodos e Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Exceções e Tratamento de Erro  - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas  - Exceções", ExcecoesPersonalizadas.Executar},

                //API
                {"Arquivo: Descrevendo Dados  - Api", PrimeiroArquivo.Executar},
                {"Arquivo: Lendo Dados  - Api", LendoArquivos.Executar},
                {"Arquivo: Usando FileInfo  - Api", ExemploFileInfo.Executar},
                {"Arquivo: Diretorios  - Api", Diretorios.Executar},
                {"Arquivo: Diretorios Info - Api", ExemploDirectoryInfo.Executar},
                {"Arquivo: Usando Path - Api", UsandoPath.Executar},
                {"Arquivo: Exemplo DateTime - Api", ExemploDateTime.Executar},
                {"Arquivo: Exemplo TimeSpan - Api", ExemploTimeSpan.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}