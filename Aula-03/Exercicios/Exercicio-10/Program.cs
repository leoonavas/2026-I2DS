using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(10);
        Exercicio10();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio10()
    {
        string[] livros = new string[100];
        bool[] disponivel = new bool[100];
        int indice = 0;
        int opcao;
        while (true)
        {
            Console.WriteLine("1 - Cadastrar Livro\n2 - Listar Livros\n3 - Pesquisar Livros\n4 - Emprestar livro\n5 - Devolver Livro\n6 - Sair");
            Console.Write("Selecione uma opcao: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    string livro = "";
                    Console.Write("Nome do Livro: ");
                    livro = Console.ReadLine();
                    livros[indice] = livro;
                    indice++;
                    break;
                case 2:
                    for (int i = 0; i < indice; i++)
                    {
                        Console.WriteLine("Livro: " + livros[i] + " | Emprestado: " + disponivel[i]);
                    }
                    break;
                case 3:

                    break;
                case 4:
                    string emprestar = "";
                    int indiceEncontrado = 0;
                    Console.Write("Digite o nome do livro: ");
                    emprestar = Console.ReadLine();

                    for (int i = 0; i < livros.Length; i++)
                    {
                        if (livros[i] == emprestar && !disponivel[i])
                        {
                            Console.WriteLine("Livro Emprestado com Sucesso!");
                            disponivel[i] = true;
                        }
                    }

                    break;
                case 5:
                    string devolver = "";
                    Console.Write("Digite o nome do livro: ");
                    devolver = Console.ReadLine();

                    for (int i = 0; i < livros.Length; i++)
                    {
                        if (livros[i] == devolver && disponivel[i])
                        {
                            Console.WriteLine("Livro devolvido com Sucesso!");
                            disponivel[i] = false;
                        }
                    }

                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    return;
                    break;
            }
        }

    }
}