using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numeros = new List<int>
        {
            -10, 5, 8, -3, 12, -7, 20, 0, -15, 4
        };

        List<int> resultado = numeros
            .Where(n => n > 0)
            .Select(n => n * 2)
            .ToList();

        foreach (int numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
}