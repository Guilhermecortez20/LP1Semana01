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
        }
    }
}
