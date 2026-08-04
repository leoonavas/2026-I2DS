using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(1);
        Exercicio01();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio01()
    {
        int celsius;
        Console.Write("Digite uma temperatura em graus celsius: ");
        celsius = int.Parse(Console.ReadLine());

        double frn = (celsius * 9 / 5) + 32;
        string resultado = celsius + " graus celsius são " + frn + " em fahrenheit";

        Console.WriteLine(resultado);
    }
}