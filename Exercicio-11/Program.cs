using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public string Prioridade { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Queue<Cliente> fila = new Queue<Cliente>();

        fila.Enqueue(new Cliente { Nome = "Ana", Prioridade = "Normal" });
        fila.Enqueue(new Cliente { Nome = "Bruno", Prioridade = "Preferencial" });
        fila.Enqueue(new Cliente { Nome = "Carlos", Prioridade = "Normal" });
        fila.Enqueue(new Cliente { Nome = "Daniel", Prioridade = "Urgente" });
        fila.Enqueue(new Cliente { Nome = "Eduardo", Prioridade = "Normal" });
        fila.Enqueue(new Cliente { Nome = "Fernanda", Prioridade = "Preferencial" });

        Stack<string> historico = new Stack<string>();

        for (int i = 0; i < 4; i++)
        {
            Cliente clienteAtendido = fila.Dequeue();

            historico.Push(clienteAtendido.Nome);

            Console.WriteLine($"Atendendo: {clienteAtendido.Nome}");
        }

        Console.WriteLine("\n📌 Clientes que ainda estão na fila:");

        foreach (Cliente cliente in fila)
        {
            Console.WriteLine($"Nome: {cliente.Nome} | Prioridade: {cliente.Prioridade}");
        }

        Console.WriteLine("\n📜 Histórico de atendimentos:");

        foreach (string cliente in historico)
        {
            Console.WriteLine(cliente);
        }
    }
}