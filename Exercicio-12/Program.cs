using System;
using System.Collections.Generic;
using System.Linq;

class Venda
{
    public string Produto { get; set; }
    public string Categoria { get; set; }
    public double Valor { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Venda> vendas = new List<Venda>
        {
            new Venda { Produto = "Notebook", Categoria = "Eletrônicos", Valor = 3500.00 },
            new Venda { Produto = "Mouse", Categoria = "Eletrônicos", Valor = 120.00 },
            new Venda { Produto = "Teclado", Categoria = "Eletrônicos", Valor = 250.00 },

            new Venda { Produto = "Camisa", Categoria = "Roupas", Valor = 90.00 },
            new Venda { Produto = "Tênis", Categoria = "Roupas", Valor = 450.00 },
            new Venda { Produto = "Jaqueta", Categoria = "Roupas", Valor = 300.00 },

            new Venda { Produto = "Arroz", Categoria = "Alimentos", Valor = 25.00 },
            new Venda { Produto = "Café", Categoria = "Alimentos", Valor = 35.00 }
        };

        var relatorio = vendas
            .GroupBy(v => v.Categoria)
            .Select(g => new
            {
                Categoria = g.Key,
                Total = g.Sum(v => v.Valor)
            });

        Console.WriteLine("📊 Relatório de vendas por categoria:\n");

        foreach (var categoria in relatorio)
        {
            Console.WriteLine(
                $"Categoria: {categoria.Categoria} | Total: R$ {categoria.Total:F2}"
            );
        }

        var categoriaVencedora = relatorio
            .OrderByDescending(c => c.Total)
            .First();

        Console.WriteLine("\n🏆 Categoria com maior faturamento:");

        Console.WriteLine(
            $"Categoria: {categoriaVencedora.Categoria} | Faturamento: R$ {categoriaVencedora.Total:F2}"
        );
    }
}