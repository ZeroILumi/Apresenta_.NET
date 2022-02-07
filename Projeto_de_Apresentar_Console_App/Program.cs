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
                Execução da Calculadora.
            */

                System.Console.WriteLine("Digite o valor 1:");
                int valor1;

                /*
                    Para só aceitar valores int\inteiros do System.Console.ReadLine() 
                    utilizaremos um laço de repetição 
                    while("condição") com a condição infinita 
                    no caso Verdadeiro\TRUE e só se quebrara o loop quando 
                    a condição for FALSA\FALSE devido a palavra chave break 
                    a qual quebrara e sairá do laço de repetição While(true).
                */

                /*
                    Para testar se o input\entrada de dados 
                    do usuário e um número int\inteiro 
                    para que possamos realizar cálculos 
                    dentro do laço de repetição While("condição") 
                    anteriormente citado utilizaremos 
                    um laço de decisão if("condição") cuja 
                    sua "condição" deve ser um valor booleano(TRUE ou FALSE)
                    que nesse caso vira do método do objeto\tipo int 
                    o chamado 
                    "int.TryParce("valor_a_ser_convertido_em_int", 
                    out "nome_da_variavel_que_recebera_esse_valor")", 
                    o "valor_a_ser_convertido_em_int" 
                    e o input\entrada de dados do usuário no terminal 
                    a ser convertido em int\inteiro e o out passara 
                    esse valor para a var cujo o nome seja informado 
                    no lugar de "nome_da_variavel_que_recebera_esse_valor" 
                    se a conversão tiver sido bem sucedida, caso a Conversão 
                    para int\inteiro seja possível o retorno do método int.TryParce() 
                    sera a conversão do valor de "valor_a_ser_convertido_em_int" 
                    e o armazenamento do mesmo na var com o nome digitado no lugar 
                    de "nome_da_variavel_que_recebera_esse_valor" e retornara um TRUE 
                    para o laço de decisão if("condição") permitindo assim a execução 
                    de seu bloco de código, que caso seja executado executara 
                    a operação da palavra chave "break" quebrando o loop 
                    do laço de repetição While(true), caso a conversão 
                    do valor em int\inteiro pelo método int.TryParce() 
                    não seja possível ele retorna um FALSE para 
                    o laço de decisão if("condição") do qual não executara 
                    seu bloco de código e passara para a execução da próxima linha 
                    que no caso sera um System.Console.WriteLine("texto") 
                    cujo o "texto" sera ""Valor Invalido\n"+"Digite um número inteiro:"" 
                    e esse "\n" da um espaço entre as partes do texto o "+" 
                    com strings as concatena ou seja torna essas partes de string 
                    uma só string, depois o loop de While(true) ira se repetir 
                    enquanto a condição de if(int.TryParce()) não for Verdadeira\TRUE, 
                    e ela só sera Verdadeira\TRUE caso o input\entrada 
                    de dados seja convertível em inteiro, no método int.TryParce() 
                    esse input vem de um System.Console.ReadLine() 
                    no lugar de "valor_a_ser_convertido_em_int" e esse valor 
                    vem do Retorno do System.Console.ReadLine().
                */

                while(true)
                {
                    if(int.TryParse(System.Console.ReadLine(), out valor1))
                    {
                        break;
                    }
                    System.Console.WriteLine("Valor Invalido\n"+
                                             "Digite um número inteiro:");
                }
                System.Console.WriteLine("Digite o valor 2:");
                int valor2;
                while(true)
                {
                    if(int.TryParse(System.Console.ReadLine(), out valor2))
                    {
                        break;
                    }
                    System.Console.WriteLine("Valor Invalido\n"+
                                             "Digite um número inteiro:");
                }
                System.Console.WriteLine(Calculadora.Somar(valor1, valor2));
                System.Console.WriteLine(Calculadora.Multiplicar(valor1, valor2));
                System.Console.WriteLine(Calculadora.Subtrair(valor1, valor2));
                System.Console.WriteLine(Calculadora.Dividir(valor1, valor2));
                System.Console.WriteLine(Calculadora.Resto_da_Divisão(valor1, valor2));
            

            /*  
                Execução de uma Impresão\Escrita de dados no 
                terminal ou CLI(Command-Line Interface) com 
                o comando "System.Console.WriteLine("texto")".
            */

            /*
                System.Console.WriteLine("Ola Mundo");
            */

            /*
                Para controlar quantas vezes um loop de for(para) 
                vai repetir o bloco de código atrelado a ele vamos utilizar 
                um variável aqui chamada de "numero_de_vezes" e seu valor sera a 
                quantidade de vezes que o loop sera repetido.
            */

            /*
                Para controlar quantas vezes um loop de for(para) 
                vai repetir o bloco de código atrelado a ele vamos 
                utilizar um variável aqui chamada de "numero_de_vezes"
                e seu valor sera a quantidade de vezes que o loop sera repetido.
            */
            System.Console.WriteLine("Digite um número inteiro para controlar\n"+
                                     "o número de vezes que o loop sera repetido:");
            int numero_de_vezes;
            while(true)
            {
                if(int.TryParse(System.Console.ReadLine(), out numero_de_vezes))
                {
                    break;
                }
                System.Console.WriteLine("Valor Invalido\n"+
                                         "Digite um número inteiro:");
            }
            
            /*
                Para criar um loop de um bloco de código 
                controlando o inicio e fim desse loop nos 
                utilizamos o laço de repetição for(para) 
                que na pratica e assim 
                "for(int inicio = "valor_inicial_do_loop"; inicio < "valor_final_do_loop"; 
                inicio++)" 
                geralmente o var\int que armazena 
                o valor inicial do loop aqui "inicio" 
                e chamada de "i" esse int "i" recebe 
                um valor numérico inteiro aqui chamado de "valor_inicial_do_loop" 
                no qual representa o valor de onde o loop se iniciara; 
                Depois temos o controle do número de vezes que o loop repetira com o 
                valor final aqui chamado de "valor_final_do_loop" que também e 
                um valor numérico inteiro e uma comparação que deve ser 
                FALSA\FALSE para que o loop seja quebrado aqui representa 
                pelo menor que "<" nesse caso o loop só acabara quando o 
                "valor_inicial_do_loop" for igual ou maior que o "valor_final_do_loop" 
                pois isso torna a condição da comparação FALSA\FALSE
                e o loop só ocorrera quando ela for Verdadeira\TRUE; 
                Por ultimo mais não menos importante temos 
                o "quebrador de loop" ou incremento ou decremento nesse caso 
                incremento do qual a responsabilidade se da em aumentar 
                o diminuir o valor do "valor_inicial_do_loop" que esta na 
                var "inicio" a fim de quebrar a condição do loop de for 
                tornando-a FALSA\FALSE e assim encerrando o loop de for 
                sem isso o loop seria eterno, caso a condição não seja quebrada 
                pelo "quebrador de loop" devido a uma situação por exemplo 
                onde o loop só se quebrara caso o "valor_inicial_do_loop" 
                seja maior que o "valor_final_do_loop" um ação de 
                decremento ou "--" geraria também um loop eterno, 
                sendo necessário nessa situação um incremento ou "++" 
                para quebrar esse loop de for.  
            */

            
            for(int i = 0; i < numero_de_vezes; i++)
            {
                /*
                    Para interpolar\juntar um texto 
                    com o valor de uma ou mais 
                    variáveis no C# em uma impressão\escrita no 
                    terminal ou na CLI(Command-Line Interface) 
                    utilizamos um interpolador de string 
                    no System.Console.WriteLine que e representado 
                    no C# pelo simbolo de "$" e o valor das variáveis 
                    entre chaves "{"}" o comando interpolando valor 
                    de variáveis e texto\string fica assim 
                    "System.Console.WriteLine(""texto_a_ser_escrito_na_CLI
                    (Command-Line Interface)"{"nome_da_variavel}")" 
                    onde colocamos no lugar de 
                    "texto_a_ser_escrito_na_CLI(Command-Line Interface)"
                    o texto\string que queremos que seja escrito no termina 
                    ou na CLI(Command-Line Interface) e no lugar de "{"nome_da_variavel"}" 
                    colocamos o nome_da_variavel cujo o valor queremos que seja 
                    interpolado e impreso junto com o texto\string no terminal 
                    ou na CLI(Command-Line Interface);
                */

                System.Console.WriteLine($"Um número atual do loop e {i}.");
            }

            /* Execução Pilha
                var s = new Pilha_Classe();
                s.Empilha(10);
                s.Desempilha();
            */


        }
    }
}
