using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
          
        string simpleString = "Olá, mundo!";
        string stringComAspas = "Ele disse: \"C# é incrível!\"";
        string stringComNovaLinha = "Linha 1\nLinha 2\nLinha 3";
        string stringComTab = "Nome\tIdade\tPaís";

        
        string stringComUnicode = "Símbolos Unicode: \u2665 \u2600 \u263A"; // ♥ ☀ ☺
        string stringComEmoji = "Emojis: 😀🚀🔥";

        
        Console.WriteLine("### Strings Simples ###");
        Console.WriteLine(simpleString);
        Console.WriteLine(stringComAspas);
        Console.WriteLine(stringComNovaLinha);
        Console.WriteLine(stringComTab);
        Console.WriteLine();

        Console.WriteLine("### Strings com Unicode ###");
        Console.WriteLine(stringComUnicode);
        Console.WriteLine(stringComEmoji);
        }
    }
}
