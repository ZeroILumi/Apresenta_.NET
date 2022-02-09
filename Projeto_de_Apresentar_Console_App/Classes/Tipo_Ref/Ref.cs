namespace Projeto_de_Apresentar_Console_App.Classes.Tipo_Ref.NameSpace_Tipo_Ref
{
    public class Ref
    {
        // Aqui os parametros são referencia ao nome\espaço das vars não ao valor das mesmas,
        // ou seja se eu alterar o valor do parametro no método isso alterara também o valor
        // das vars que forão pasadas por parametro pois teoricamente elas ocuparão o mesmo 
        // espaço na memoria.
        private static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
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
            // O parametro deve ser um referencia ao espaço de memoria onde estão os dados
            // de i e j e não os valores de i e j.
            Inverter(ref i, ref j);
            System.Console.WriteLine($"O primeiro valor {i} agora é {j}.\n"+
                                     $"O segundo valor {j} agora é {i}.");
        }
    }
}