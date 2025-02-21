using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
             
        Console.Write("Digite um número inteiro: ");
        string inputInt = Console.ReadLine();
        
        int numeroInteiro = int.Parse(inputInt);

        Console.Write("Digite um número real: ");
        string inputFloat = Console.ReadLine();

        float numeroReal = float.Parse(inputFloat);

        float soma = numeroInteiro + numeroReal;
        Console.WriteLine($"A soma de {numeroInteiro} e {numeroReal} é {soma}");
    
        }
    }
}
