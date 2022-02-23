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

using Projeto_de_Apresentar_Console_App.Classes.Calculadora.NameSpace_Calculadora;
using Projeto_de_Apresentar_Console_App.Classes.Pilha.NameSpace_Pilha;
using Projeto_de_Apresentar_Console_App.Classes.Repetidor_de_Textos.NameSpace_Repetidor_de_Textos;
using Projeto_de_Apresentar_Console_App.Classes.Tipo_Ref.NameSpace_Tipo_Ref;
using Projeto_de_Apresentar_Console_App.Classes.Tipo_Out.NameSpace_Tipo_Out;
using Projeto_de_Apresentar_Console_App.Classes.Aluno.NameSpace_Aluno;
using Projeto_de_Apresentar_Console_App.Classes.Conceitos_de_Nota.NameSpace_Conceitos_de_Nota;

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
            /*
            // Criando um array do tipo aluno com o limite de 5 alunos no maximo.
            Aluno[] alunos = new Aluno[5];
            int indice_aluno = 0;
            string opcao_usuario = Obter_Opcao_Usuario();

            while(opcao_usuario.ToUpper() != "X")
            {
                switch(opcao_usuario)
                {
                    case "1":
                        string opcao_usuario_calculadora = Obter_Opcao_Usuario_Calculadora();
                        while(opcao_usuario_calculadora.ToUpper() != "X")
                        {
                            switch(opcao_usuario_calculadora)
                            {
                                case "1":
                                    decimal valor_1_soma;
                                    decimal valor_2_soma;
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 1");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor1))
                                        {
                                            valor_1_soma = valor1;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 2");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor2))
                                        {
                                            valor_2_soma = valor2;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    System.Console.WriteLine(Calculadora.Somar(
                                        valor_1_soma, valor_2_soma));
                                    break;
                                case "2":
                                    decimal valor_1_subtracao;
                                    decimal valor_2_subtracao;
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 1");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor1))
                                        {
                                            valor_1_subtracao = valor1;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 2");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor2))
                                        {
                                            valor_2_subtracao = valor2;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    System.Console.WriteLine(Calculadora.Subtrair(
                                        valor_1_subtracao, valor_2_subtracao));
                                    break;
                                case "3":
                                    decimal valor_1_multiplicacao;
                                    decimal valor_2_multiplicacao;
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 1");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor1))
                                        {
                                            valor_1_multiplicacao = valor1;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 2");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor2))
                                        {
                                            valor_2_multiplicacao = valor2;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    System.Console.WriteLine(Calculadora.Multiplicar(
                                        valor_1_multiplicacao, valor_2_multiplicacao));
                                    break;
                                case "4":
                                    decimal valor_1_divisao;
                                    decimal valor_2_divisao;
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 1");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor1))
                                        {
                                            valor_1_divisao = valor1;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 2");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor2))
                                        {
                                            valor_2_divisao = valor2;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    System.Console.WriteLine(Calculadora.Dividir(
                                        valor_1_divisao, valor_2_divisao));
                                    break;
                                case "5":
                                    decimal valor_1_resto_da_divisao;
                                    decimal valor_2_resto_da_divisao;
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 1");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor1))
                                        {
                                            valor_1_resto_da_divisao = valor1;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    while(true)
                                    {
                                        System.Console.WriteLine("Digite o valor 2");
                                        if(decimal.TryParse(System.Console.ReadLine(), 
                                        out decimal valor2))
                                        {
                                            valor_2_resto_da_divisao = valor2;
                                            break;
                                        }
                                        System.Console.WriteLine("\nValor Invalido\n"+ 
                                                                 "Digite um número decimal:");
                                    }
                                    System.Console.WriteLine(Calculadora.Resto_da_Divisão(
                                        valor_1_resto_da_divisao, valor_2_resto_da_divisao));
                                    break;
                                case "6":
                                    Calculadora.Executar_Todos_os_Calculos();
                                    break;
                                default:
                                    System.Console.WriteLine("\nDigite um valor valido:");
                                    break;
                            }
                            opcao_usuario_calculadora = Obter_Opcao_Usuario_Calculadora();
                        }
                        break;
                    case "2":
                        Repetidor_de_Textos.Repetir_Textos();
                        break;
                    case "3":
                        Ref.Inverter();
                        break;
                    case "4":
                        Out.Dividir();
                        break;
                    case "5":
                        alunos[indice_aluno] = Aluno.Retornar_aluno();
                        indice_aluno++;
                        break;
                    case "6":
                        foreach(var aluno in alunos)
                        {
                            if(!string.IsNullOrEmpty(aluno.Nome))
                            {
                                System.Console.WriteLine($"Aluno: {aluno.Nome} - Nota: {aluno.Nota}");
                            }
                        }
                        break;
                    case "7":
                        decimal notaTotal = 0;
                        var numero_de_alunos = 0;
                        for(int i =0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numero_de_alunos++;
                            }
                        }
                        decimal media_geral_de_todos_os_alunos = notaTotal / 
                        numero_de_alunos;
                        Conceito_de_Nota conceito_geral_das_notas = 0;
                        if(media_geral_de_todos_os_alunos <= 0)
                        {
                            conceito_geral_das_notas = (Conceito_de_Nota)6;
                        }
                        else if(media_geral_de_todos_os_alunos <= 2)
                        {
                            conceito_geral_das_notas = (Conceito_de_Nota)5;
                        }
                        else if(media_geral_de_todos_os_alunos <= 4)
                        {
                            conceito_geral_das_notas = (Conceito_de_Nota)4;
                        }
                        else if(media_geral_de_todos_os_alunos <= 5)
                        {
                            conceito_geral_das_notas = (Conceito_de_Nota)3;
                        }
                        else if(media_geral_de_todos_os_alunos <= 7)
                        {
                            conceito_geral_das_notas = (Conceito_de_Nota)2;
                        }
                        else if(media_geral_de_todos_os_alunos <= 10)
                        {
                            conceito_geral_das_notas = (Conceito_de_Nota)1;
                        }
                        System.Console.WriteLine($"A Media Geral de Todos os Alunos é: "+ 
                                                 $"{media_geral_de_todos_os_alunos:f2},\n"+
                                                 $"Conceito Geral: {conceito_geral_das_notas}");
                        break;
                    default:
                        System.Console.WriteLine("\nDigite um valor valido:");
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
        /*
        }
        private static string Obter_Opcao_Usuario()
        {
            System.Console.WriteLine("\nDigite a opção desejada");
            System.Console.WriteLine("1- Entrar no Menu da Calculadora");  
            System.Console.WriteLine("2- Criar um loop");
            System.Console.WriteLine("3- Inverter valores com tipos de ref");
            System.Console.WriteLine("4- Dividindo valores declarados em "+ 
                                     "uma chamada de um método "+
                                     "com tipos de out");
            System.Console.WriteLine("5- Adicionar novo aluno a lista de alunos");     
            System.Console.WriteLine("6- Listar todos os alunos na lista de alunos");
            System.Console.WriteLine("7- Calcular Media Geral dos alunos na lista de alunos");                    
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcao_usuario = System.Console.ReadLine();
            return opcao_usuario;
        }

        private static string Obter_Opcao_Usuario_Calculadora()
        {
            System.Console.WriteLine("\nDigite a opção desejada:");
            System.Console.WriteLine("1- Realizar somente a soma de 2 valores");
            System.Console.WriteLine("2- Realizar somente a subtração de 2 valores");
            System.Console.WriteLine("3- Realizar somente a multiplicação de 2 valores");
            System.Console.WriteLine("4- Realizar somente a divisão de 2 valores");
            System.Console.WriteLine("5- Realizar somente o resto da divisão de 2 valores");
            System.Console.WriteLine("6- Realizar todos os calculos da Calculadora");
            System.Console.WriteLine("X- Retornar ao Menu Principal");  
            string opcao_usuario_calculadora = System.Console.ReadLine();
            return opcao_usuario_calculadora;
        }
        */
        }
    }
}
