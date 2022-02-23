namespace Projeto_de_Apresentar_Console_App.Classes.Menu
{
    public class Menu_Principal
    {
        public static string Obter_Opcao_Usuario()
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

        public static string Obter_Opcao_Usuario_Calculadora()
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
    }
}