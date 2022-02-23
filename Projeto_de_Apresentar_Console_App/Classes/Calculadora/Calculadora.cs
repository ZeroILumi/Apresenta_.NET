namespace Projeto_de_Apresentar_Console_App.Classes.Calculadora.NameSpace_Calculadora
{
    public class Calculadora
    {
        private decimal _valor1;
        public decimal Valor1 
        { 
            get => _valor1;
            set => _valor1 = value; 
        }
        private decimal _valor2;
        public decimal Valor2 
        { 
            get => _valor2;
            set => _valor2 = value; 
        }
        public Calculadora(decimal valor1, decimal valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
        }
        public static string Somar(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 + valor2;
            string mensagem = "\nSoma:\n"+
                              $"{valor1} + {valor2} = {resultado:f2}";
            return mensagem;
        }

        public static string Multiplicar(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 * valor2;
            string mensagem = "\nMultiplicação:\n"+
                              $"{valor1} x {valor2} = {resultado:f2}";
            return mensagem;
        }
        public static string Subtrair(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 - valor2;
            string mensagem = "\nSubtração:\n"+
                              $"{valor1} - {valor2} = {resultado:f2}";
            return mensagem;
        }
        public static string Dividir(decimal valor1, decimal valor2)
        {
            try
            {
                decimal resultado = valor1 / valor2;
                string mensagem = "\nDivisão:\n"+
                                  $"{valor1} / {valor2} = {resultado:f2}";
                return mensagem; 
            }
            catch (DivideByZeroException)
            {
                return "\nDivisão\n"+
                       "Erro: Não pode haver divisão por 0";
            }
        }
        public static string Resto_da_Divisão(decimal valor1, decimal valor2)
        {
            try
            {
                decimal resultado = valor1 % valor2;
                string mensagem = "\nResto da Divisão:\n"+
                                  $"{valor1} % {valor2} = {resultado:f2}";
                return mensagem; 
            }
            catch (DivideByZeroException)
            {
                return "\nResto da Divisão\n"+
                       "Erro: Não pode haver divisão por 0"; 
            }
        }

        public static decimal Retornar_um_numero_decimal()
        {
            System.Console.WriteLine("Digite um valor");
            /*
                Para só aceitar valores decimal\decimals do System.Console.ReadLine() 
                utilizaremos um laço de repetição 
                while("condição") com a condição infinita 
                no caso Verdadeiro\TRUE e só se quebrara o loop quando 
                a condição for FALSA\FALSE devido a palavra chave break 
                a qual quebrara e sairá do laço de repetição While(true).
            */
            while(true)
            {
            /*
                Para testar se o input\entrada de dados 
                do usuário e um número decimal\decimal 
                para que possamos realizar cálculos 
                dentro do laço de repetição While("condição") 
                anteriormente citado utilizaremos 
                um laço de decisão if("condição") cuja 
                sua "condição" deve ser um valor booleano(TRUE ou FALSE)
                que nesse caso vira do método do objeto\tipo decimal 
                o chamado 
                "decimal.TryParce("valor_a_ser_convertido_em_decimal", 
                out "nome_da_variavel_que_recebera_esse_valor")", 
                o "valor_a_ser_convertido_em_decimal" 
                e o input\entrada de dados do usuário no terminal 
                a ser convertido em decimal\decimal e o out passara 
                esse valor para a var cujo o nome seja informado 
                no lugar de "nome_da_variavel_que_recebera_esse_valor" 
                se a conversão tiver sido bem sucedida, caso a Conversão 
                para decimal\decimal seja possível o retorno do método decimal.TryParce() 
                sera a conversão do valor de "valor_a_ser_convertido_em_decimal" 
                e o armazenamento do mesmo na var com o nome digitado no lugar 
                de "nome_da_variavel_que_recebera_esse_valor" e retornara um TRUE 
                para o laço de decisão if("condição") permitindo assim a execução 
                de seu bloco de código, que caso seja executado executara 
                a operação da palavra chave "break" quebrando o loop 
                do laço de repetição While(true), caso a conversão 
                do valor em decimal\decimal pelo método decimal.TryParce() 
                não seja possível ele retorna um FALSE para 
                o laço de decisão if("condição") do qual não executara 
                seu bloco de código e passara para a execução da próxima linha 
                que no caso sera um System.Console.WriteLine("texto") 
                cujo o "texto" sera ""Valor Invalido\n"+"Digite um número decimal:"" 
                e esse "\n" da um espaço entre as partes do texto o "+" 
                com strings as concatena ou seja torna essas partes de string 
                uma só string, depois o loop de While(true) ira se repetir 
                enquanto a condição de if(decimal.TryParce()) não for Verdadeira\TRUE, 
                e ela só sera Verdadeira\TRUE caso o input\entrada 
                de dados seja convertível em decimal, no método decimal.TryParce() 
                esse input vem de um System.Console.ReadLine() 
                no lugar de "valor_a_ser_convertido_em_decimal" e esse valor 
                vem do Retorno do System.Console.ReadLine().
            */
                if(decimal.TryParse(System.Console.ReadLine(), out decimal valor))
                {
                    return valor;
                }
                System.Console.WriteLine("Valor Invalido\n"+
                                        "Digite um número decimal:");
            }
        }
        public static void Executar_Todos_os_Calculos()
        {
            /*
                Execução da Calculadora.
            */
            decimal valor1 = Retornar_um_numero_decimal();
            decimal valor2 = Retornar_um_numero_decimal();
            System.Console.WriteLine(Calculadora.Somar(valor1, valor2));
            System.Console.WriteLine(Calculadora.Multiplicar(valor1, valor2));
            System.Console.WriteLine(Calculadora.Subtrair(valor1, valor2));
            System.Console.WriteLine(Calculadora.Dividir(valor1, valor2));
            System.Console.WriteLine(Calculadora.Resto_da_Divisão(valor1, valor2));
        }
    }
}