/* 
    Vamos importar a biblioteca System com a palavra chave using, 
    a palavra chave using nos permite importa bibliotecas, pacotes, arquivos, pastas 
    entre outras coisas para o arquivo da qual ela esta presente escrevendo 
    "using "namespace_do_que_vai_ser_importado_para_o_arquivo_atual"" 
    depois no lugar de "namespace_do_que_vai_ser_importado_para_o_arquivo_atual" 
    coloca-se o namespace da biblioteca, pacote, arquivo ou pasta que se deseja importar
    para o arquivo atual.
*/ 

using System;

/*
    Importando classe Calculadora 
    pelo namespace do da pasta Calculadora 
    no arquivo Calculadora.cs
*/

using Projeto_de_Apresentar_Console_App.Classes.NameSpace_Calculadora;
using Projeto_de_Apresentar_Console_App.Classes.NameSpace_Pilha;
using Projeto_de_Apresentar_Console_App.Classes.NameSpace_Repetidor_de_Textos;

/*
    Para permitir a importação do conteúdo de nosso arquivo Program.cs utilizaremos 
    um namespace que e criado com a palavra chave "namespace "nome_do_namespace"" 
    no lugar de "nome_do_namespace" coloca-se o nome do qual devera ser escrito no 
    using para importar o conteúdo deste arquivo em outros arquivos. 
*/

namespace Projeto_de_Apresentar_Console_App
{
    /*
        Vamos criar um ponto de "start\inicio" 
        para a nosso projeto no arquivo Program.cs com a class Program 
        e seu método static void Main(string[] args), isso para quando 
        dermos o comando dotnet run execute o que estiver dentro do método Main() 
        da class Program no arquivo Program.cs, o retorno desse método Main() se da 
        nessa execução de código.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string opcao_usuario = Obter_Opcao_Usuario();

            while(opcao_usuario.ToUpper() != "X")
            {
                switch(opcao_usuario)
                {
                    case "1":
                        Calculadora.Executar_Todos_os_Calculos();
                        break;
                    case "2":
                        Repetidor_de_Textos.Repetir_Textos();
                        break;
                    default:
                        System.Console.WriteLine("Digite um valor valido");
                        System.Console.WriteLine();
                        break;
                }

                opcao_usuario = Obter_Opcao_Usuario();
            }
            /*  
                Execução de uma Impresão\Escrita de dados no 
                terminal ou CLI(Command-Line Interface) com 
                o comando "System.Console.WriteLine("texto")".
            */

            /*
                System.Console.WriteLine("Ola Mundo");
            */

            /* Execução Pilha
                var s = new Pilha_Classe();
                s.Empilha(10);
                s.Desempilha();
            */

        }
        private static string Obter_Opcao_Usuario()
        {
            System.Console.WriteLine("Digite a opção desejada");
            System.Console.WriteLine("1- Realizar todos os calculos da Calculadora");
            System.Console.WriteLine("2- Criar um loop");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcao_usuario = System.Console.ReadLine();
            return opcao_usuario;
        }
    }
}
