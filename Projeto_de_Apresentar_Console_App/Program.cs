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
using Projeto_de_Apresentar_Console_App.Calculadoras;

/*
    Para permitir a importação do conteúdo de nosso arquivo Program.cs utilizaremos 
    um namespace que e criado com a palavra chave "namespace "nome_do_namespace"" 
    no lugar de "nome_do_namespace" coloca-se o nome do qual devera ser escrito no 
    using para importar o conteúdo deste arquivo em outros arquivos. 
*/
namespace Projeto_de_Apresentar_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor 1");
            int valor1 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Digite o valor 2");
            int valor2 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Calculadora.Somar(valor1, valor2));
            System.Console.WriteLine(Calculadora.Multiplicar(valor1, valor2));
            System.Console.WriteLine(Calculadora.Subtrair(valor1, valor2));
            System.Console.WriteLine(Calculadora.Dividir(valor1, valor2));
            System.Console.WriteLine(Calculadora.Resto_da_Divisão(valor1, valor2));
        }
    }
}
