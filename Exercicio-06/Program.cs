using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Func<int, int, int> multiplicar = (a, b) => a * b;

        Console.WriteLine(multiplicar(2, 5));
        Console.WriteLine(multiplicar(10, 3));
        Console.WriteLine(multiplicar(7, 4));
    }
}