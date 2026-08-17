using System;
using System.Collections.Generic;
using System.Linq;

class Funcionario
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, Funcionario> funcionarios = new Dictionary<int, Funcionario>
        {
            { 101, new Funcionario { Matricula = 101, Nome = "Ana", Salario = 2500.00 } },
            { 102, new Funcionario { Matricula = 102, Nome = "Bruno", Salario = 4200.00 } },
            { 103, new Funcionario { Matricula = 103, Nome = "Carlos", Salario = 1800.00 } },
            { 104, new Funcionario { Matricula = 104, Nome = "Daniel", Salario = 3500.00 } },
            { 105, new Funcionario { Matricula = 105, Nome = "Eduardo", Salario = 5000.00 } }
        };

        var funcionariosOrdenados = funcionarios.Values
            .OrderBy(f => f.Salario);

        foreach (Funcionario funcionario in funcionariosOrdenados)
        {
            Console.WriteLine(
                $"Matrícula: {funcionario.Matricula} | Nome: {funcionario.Nome} | Salário: R$ {funcionario.Salario:F2}"
            );
        }
    }
}