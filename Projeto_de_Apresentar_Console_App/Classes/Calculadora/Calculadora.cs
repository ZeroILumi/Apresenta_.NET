namespace Projeto_de_Apresentar_Console_App.Classes.NameSpace_Calculadora
{
    public class Calculadora
    {
        private int _valor1;
        public int Valor1 { 
            get => _valor1;
            set => _valor1 = value; 
        }
        private int _valor2;
        public int Valor2 
        { 
            get => _valor2;
            set => _valor2 = value; 
        }
        public Calculadora(int valor1, int valor2)
        {
            this._valor1 = valor1;
            this._valor2 = valor2;
        }
        public static string Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            string mensagem = $"{valor1} + {valor2} = {resultado}";
            return mensagem;
        }

        public static string Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            string mensagem = $"{valor1} x {valor2} = {resultado}";
            return mensagem;
        }
        public static string Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            string mensagem = $"{valor1} - {valor2} = {resultado}";
            return mensagem;
        }
        public static string Dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            string mensagem = $"{valor1} / {valor2} = {resultado}";
            return mensagem; 
        }
        public static string Resto_da_Divisão(int valor1, int valor2)
        {
            int resultado = valor1 % valor2;
            string mensagem = $"{valor1} % {valor2} = {resultado}";
            return mensagem;  
        }
        public static void Executar_Todos_os_Calculos()
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
            
        }
    }
}