using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(3);
        Exercicio03();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio03()
    {
        string nome = "";
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + "! Seja bem-vindo!");

        int nota1;
        Console.Write("Digite o sua primeira nota: ");
        nota1 = int.Parse(Console.ReadLine());

        int nota2;
        Console.Write("Digite o sua segunda nota: ");
        nota2 = int.Parse(Console.ReadLine());

        int nota3;
        Console.Write("Digite o sua terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());

        int media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("Sua media final foi " + media + ".");
        if (media >= 7)
        {
            Console.WriteLine("Resultado Final: Aprovado");

        } else
        {
            Console.WriteLine("Resultado Final: Reprovado");

        }


    }
}