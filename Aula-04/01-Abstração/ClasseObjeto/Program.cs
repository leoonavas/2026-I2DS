using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Classe -> é a abstracao de um objeto do mundo real para o mundo computacional
        // Objeto -> E a instancia de uma classe
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        aluno01.Nome = "Cristiano de Paula";
        aluno01.RM = 4096;
        aluno01.DataNascimento = new DateOnly(2010, 01, 15);

        aluno02.Nome = "Cristian de Paula";
        aluno02.RM = 2444;
        aluno02.DataNascimento = new DateOnly(1995, 10, 10);

        aluno01.ApresentarSe();
        aluno02.ApresentarSe();

    }
    public class Aluno // Declaracao de uma classe
    {
        // Atributos -> Caracteristicas
        public string Nome { get; set; }
        public int RM { get; set; }
        public DateOnly DataNascimento { get; set; }

        // Metodos -> Acoes ou funcionalidades

        public void ApresentarSe()
        {
            Console.WriteLine($"Meu nome é {Nome}, Meu RM é {RM}, nasci na data {DataNascimento}");

        }

    }
}