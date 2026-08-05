using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(4);
        Exercicio04();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio04()
    {
        int valor;

        Console.Write("Digite o valor do saque: ");
        valor = int.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2 };

        for (int i = 0; i < notas.Length; i++)
        {
            int quantidadenotas = valor / notas[i];

            valor = valor % notas[i];

            if (quantidadenotas > 0)
            {
                if (quantidadenotas == 1)
                {
                    Console.WriteLine(quantidadenotas + " nota de " + notas[i]);
                }
            }
        }


    }
}