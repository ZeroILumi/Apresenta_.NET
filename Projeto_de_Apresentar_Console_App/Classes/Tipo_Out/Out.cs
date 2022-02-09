namespace Projeto_de_Apresentar_Console_App.Classes.Tipo_Out.NameSpace_Tipo_Out
{
    public class Out
    {
        // A palavra chave out retorna a declaração do parametro com o tipo out atrelado
        // no final da execução do método aonde ele foi chamado.
        static void Dividir(int x, int y, out int resultado, out int resto_da_divisao)
        {
            resultado = x / y;
            resto_da_divisao = x % y;
        }
        public static void Dividir()
        {
            System.Console.WriteLine("Digite o primeiro Valor");
            int i;
            while(true)
            {
                if(int.TryParse(System.Console.ReadLine(), out i))
                {
                    break;
                }
                System.Console.WriteLine("Valor Invalido"+
                                         "\nDigite um número inteiro");
            }
            System.Console.WriteLine("Digite o segundo Valor");
            int j;
            while(true)
            {
                if(int.TryParse(System.Console.ReadLine(), out j))
                {
                    break;
                }
                System.Console.WriteLine("Valor Invalido"+
                                         "\nDigite um número inteiro");
            }
            // Recebe o valor de i e j para realizar a divisão e com o retorno da execução
            // desse método se da a declaração da var resultado e da var resto_da_divisao
            // como o mesmo valor que essas vars tinhão no final da execução do método
            
            Dividir(i, j, out int resultado, out int resto_da_divisao);
            System.Console.WriteLine("O resultado é {0}\n"+
                                     "O resto da divisão é {1}", 
                                     resultado, 
                                     resto_da_divisao);
        }
    }
}