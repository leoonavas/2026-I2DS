using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(2);
        Exercicio02();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio02()
    {
        int num1;
        int num2;
        int operacao;

        Console.Write("Numero 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Numero 2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("1 - Adicao\n2 - Subtracao\n3 - Multiplicacao\n4 - Divisao\nDigite o numero equivalente a operacao: ");
        operacao = int.Parse(Console.ReadLine());

        int valorfinal = 0;
        
        switch (operacao)
        {
            case 1:
                valorfinal = num1 + num2;
                break;

            case 2:
                valorfinal = num1 - num2;
                break;

            case 3:
                valorfinal = num1 * num2;
                break;

            case 4:
                valorfinal = num1 / num2;
                break;

            default:

                break;
        }

        Console.WriteLine("Resultado: " + valorfinal);

    }
}