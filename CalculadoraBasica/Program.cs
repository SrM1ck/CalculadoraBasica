using System;

class Program
{
    static void Main()
    {
        double x, y;

        Console.WriteLine("Entre com o primeiro valor:");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o segundo valor:");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine($"A seguir os números {x} e {y} nas quatro operações principais\n");

        Console.WriteLine($"Adição: {x + y}\nSubtração: {x - y}\nMultiplicação: {x * y}\nDivisão: {x / y}");

        Console.ReadLine();
    }

}