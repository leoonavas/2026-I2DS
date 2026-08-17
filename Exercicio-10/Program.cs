using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>
        {
            new Aluno { Nome = "Ana", Nota = 8.5 },
            new Aluno { Nome = "Bruno", Nota = 6.0 },
            new Aluno { Nome = "Carlos", Nota = 9.2 },
            new Aluno { Nome = "Daniel", Nota = 7.0 },
            new Aluno { Nome = "Eduardo", Nota = 5.5 },
            new Aluno { Nome = "Fernanda", Nota = 8.0 }
        };

        var aprovados = from aluno in alunos
                        where aluno.Nota >= 7
                        orderby aluno.Nota descending
                        select aluno;

        foreach (Aluno aluno in aprovados)
        {
            Console.WriteLine($"Nome: {aluno.Nome} | Nota: {aluno.Nota:F1}");
        }
    }
