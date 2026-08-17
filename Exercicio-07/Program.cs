using System;
using System.Collections.Generic;
using System.Linq;

class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Teclado", Preco = 80.00 },
            new Produto { Id = 2, Nome = "Mouse", Preco = 35.00 },
            new Produto { Id = 3, Nome = "Monitor", Preco = 750.00 },
            new Produto { Id = 4, Nome = "Cabo USB", Preco = 20.00 },
            new Produto { Id = 5, Nome = "Headset", Preco = 120.00 }
        };

        List<Produto> produtosFiltrados = produtos
            .Where(p => p.Preco > 50)
            .ToList();

        foreach (Produto produto in produtosFiltrados)
        {
            Console.WriteLine($"Id: {produto.Id} | Nome: {produto.Nome} | Preço: R$ {produto.Preco:F2}");
        }
    }
}