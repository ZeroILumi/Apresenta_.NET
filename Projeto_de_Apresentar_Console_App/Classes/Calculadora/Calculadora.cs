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
    }
}