using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(6);
        Exercicio06();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio06()
    {
        while (true)
        {
            int numero = 0;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===============================================\n");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));

            }

            Console.WriteLine("\n===============================================\n");

        }

    }
}