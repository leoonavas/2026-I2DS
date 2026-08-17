using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> historico = new Stack<string>();

        historico.Push("Digitar");
        historico.Push("Colar");
        historico.Push("Negrito");
        historico.Push("Apagar");

        string acaoDesfeita1 = historico.Pop();
        Console.WriteLine($"Ação desfeita: {acaoDesfeita1}");

        string acaoDesfeita2 = historico.Pop();
        Console.WriteLine($"Ação desfeita: {acaoDesfeita2}");
    }
}