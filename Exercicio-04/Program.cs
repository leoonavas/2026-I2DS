using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("Ana");
        fila.Enqueue("Bruno");
        fila.Enqueue("Carlos");
        fila.Enqueue("Daniel");
        fila.Enqueue("Eduardo");

        fila.Dequeue();
        fila.Dequeue();

        foreach (string pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }
    }
}