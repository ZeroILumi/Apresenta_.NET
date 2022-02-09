namespace Projeto_de_Apresentar_Console_App.Classes.Aluno.NameSpace_Aluno
{
    public struct Aluno
    {
        private string _nome = "";
        public string Nome 
        { 
            get => _nome; 
            set => _nome = value; 
        }
        private decimal _nota = 0;
        public decimal Nota 
        { 
            get => _nota; 
            set => _nota = value; 
        }

        public Aluno(string nome, decimal nota)
        {
            this._nome = nome;
            this._nota = nota;
        }
        public static Aluno Retornar_aluno()
        {
            System.Console.WriteLine("Informe o nome do aluno:");
            // Instanciando um objeto da classe Aluno.
            Aluno aluno = new Aluno();
            aluno.Nome = System.Console.ReadLine();
                        
            System.Console.WriteLine("Informe a nota do aluno:");
            // O var e um inferência de tipo c# que ajusta automaticamente
            // o tipo da variavel, pelo valor que ela armazena. 
            while(true)
            {
                try
                {
                    if(decimal.TryParse(System.Console.ReadLine(), out decimal nota))
                    {
                        if(nota > 10)
                        {
                            System.Console.WriteLine("Valor Invalido\n"+
                                                    "Digite uma nota que\n"+
                                                    "seja igual ou menor a 10");
                        }
                        else
                        {
                            aluno.Nota = nota;
                            break;
                        }
                    }
                    
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Nota Invalida\n "+
                                             "Digite um número decimal");
                }
            }
            return aluno;
        }
    }
}