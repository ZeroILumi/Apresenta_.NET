namespace Projeto_de_Apresentar_Console_App.Classes.Repetidor_de_Textos.NameSpace_Repetidor_de_Textos
{
    public class Repetidor_de_Textos
    {
        public static void Repetir_Textos()
        {
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

            
            for(int i = 1; i < numero_de_vezes+1; i++)
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
        }
    }
}