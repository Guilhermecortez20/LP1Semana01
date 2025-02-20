using System;

namespace ManyStrings
{
    public class Program
    {
        // Novas variáveis numéricas
        double xx = 1.23456;
        int ii = 19;

        // Formatação de xx
        string realDuasCasas = xx.ToString("F2", CultureInfo.InvariantCulture);
        string percentagem = (xx * 100).ToString("F1") + "%";

        // Formatação de ii
        string hexadecimal = ii.ToString("X");
        string moeda = ii.ToString("C", CultureInfo.CurrentCulture);

        // Strings simples
        string simpleString = "Olá, mundo!";
        string stringComAspas = "Ele disse: \"C# é incrível!\"";
        string stringComNovaLinha = "Linha 1\nLinha 2\nLinha 3";
        string stringComTab = "Nome\tIdade\tPaís";

        // Strings com caracteres Unicode
        string stringComUnicode = "Símbolos Unicode: \u2665 \u2600 \u263A"; // ♥ ☀ ☺
        string stringComEmoji = "Emojis: 😀🚀🔥";

        // Concatenação de strings
        int numero = 2;
        string letra = "a";
        string concatenacao1 = letra + numero;    // "a2"
        string concatenacao2 = "abc" + numero;    // "abc2"
        string texto = "programação";
        string concatenacao3 = "Eu gosto de " + texto + "!"; // "Eu gosto de programação!"

        // Interpolação de strings
        int x = 5;
        int y = 10;
        string interpolacao1 = $"O valor de x é {x}";
        string interpolacao2 = $"{x} mais {y} é igual a {x + y}";
        string interpolacao3 = $"O dobro de {x} é {x * 2}";

        // Imprimir todas as strings
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
        Console.WriteLine();

        Console.WriteLine("### Formatação de Número Real ###");
        Console.WriteLine($"Número real com duas casas decimais: {realDuasCasas}");
        Console.WriteLine($"Percentagem com uma casa decimal: {percentagem}");
        Console.WriteLine();

        Console.WriteLine("### Formatação de Número Inteiro ###");
        Console.WriteLine($"Hexadecimal: {hexadecimal}");
        Console.WriteLine($"Moeda: {moeda}");
      
        }
    }
}
