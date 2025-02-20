using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
    {
        byte a = 255;
        short b = -32768;
        int c = 2147483647;
        long d = 9223372036854775807;

        // Imprimir valores das variáveis inteiras
        Console.WriteLine($"Byte: {a}");
        Console.WriteLine($"Short: {b}");
        Console.WriteLine($"Int: {c}");
        Console.WriteLine($"Long: {d}");

        char char1 = '\u2665'; // ♥
        char char2 = '\u2600'; // ☀
        char char3 = '\u263A'; // ☺

        Console.WriteLine($"Char 1: {char1}");
        Console.WriteLine($"Char 2: {char2}");
        Console.WriteLine($"Char 3: {char3}");  
        
        float e = 3.14f;
        double f = 2.718281828;
        decimal g = 1.618033988749895m;

     Console.WriteLine("### Variáveis Reais ###");
        Console.WriteLine($"Float: {e}");
        Console.WriteLine($"Double: {f}");
        Console.WriteLine($"Decimal: {g}");
        Console.WriteLine();
        }
    }
}
