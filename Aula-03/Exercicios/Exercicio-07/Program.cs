using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(7);
        Exercicio07();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio07()
    {
        double[] notas = new double[100];
        double somaTotal = 0;
        double media;
        
        notas = [10, 7, 5, 8, 9, 7, 7, 7, 3, 1, 10, 9, 8];
        double maiorNota = notas[0];
        double menorNota = notas[0];

        Console.WriteLine("Notas:");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Aluno " + (i + 1) + ": " + notas[i]);
            somaTotal = somaTotal + notas[i];
            if (notas[i] > maiorNota)
            {
                maiorNota = notas[i];
            }
            if (notas[i] < menorNota)
            {
                menorNota = notas[i];
            }
        }
        Console.WriteLine("Média da Turma: " + (somaTotal / (notas.Length + 0)));
        Console.WriteLine("Menor Nota da Turma: " + menorNota);
        Console.WriteLine("Maior Nota da Turma: " + maiorNota);

    }
}