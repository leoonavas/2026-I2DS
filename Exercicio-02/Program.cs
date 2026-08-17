using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 10, 25, 8, 42, 15, 30 };

        numeros.Insert(2, 100);
        numeros.RemoveAt(numeros.Count - 1);

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}