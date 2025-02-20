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

        int numero = 2;
        string letra = "a";
        string concatenacao1 = letra + numero;    
        string concatenacao2 = "abc" + numero;    

        string texto = "programação";
        string concatenacao3 = "Eu gosto de " + texto + "!"; 

        
        int x = 5;
        int y = 10;
        string interpolacao1 = $"O valor de x é {x}";
        string interpolacao2 = $"{x} mais {y} é igual a {x + y}";
        string interpolacao3 = $"O dobro de {x} é {x * 2}";

        
        Console.WriteLine("### Strings Simples ###");
        Console.WriteLine(simpleString);
        Console.WriteLine(stringComAspas);
        Console.WriteLine(stringComNovaLinha);
        Console.WriteLine(stringComTab);
        Console.WriteLine();

        Console.WriteLine("### Strings com Unicode ###");
        Console.WriteLine(stringComUnicode);
        Console.WriteLine(stringComEmoji);
        Console.WriteLine();

        Console.WriteLine("### Concatenação de Strings ###");
        Console.WriteLine(concatenacao1);
        Console.WriteLine(concatenacao2);
        Console.WriteLine(concatenacao3);
        Console.WriteLine();

        Console.WriteLine("### Interpolação de Strings ###");
        Console.WriteLine(interpolacao1);
        Console.WriteLine(interpolacao2);
        Console.WriteLine(interpolacao3);
        }
    }
}
