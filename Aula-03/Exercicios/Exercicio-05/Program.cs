using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(5);
        Exercicio05();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio05()
    {
        string[] produtos = new string[100];
        int[] precos = new int[100];
        int quantidadeProdutos = 0;


        while (true) {
        Console.WriteLine("1 - Cadastrar Produto\n2 - Listar Produtos\n3 - Pesquisar Produtos\n4 - Sair");
        Console.Write("Digite a opcao desejada: ");

        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                    string produto = "";
                    Console.Write("Digite o nome do produto: ");
                    produto = Console.ReadLine();


                    int preco;
                    Console.Write("Digite o valor do produto: ");
                    preco = int.Parse(Console.ReadLine());

                    produtos[quantidadeProdutos] = produto;
                    precos[quantidadeProdutos] = preco;

                    quantidadeProdutos++;

                    Console.WriteLine("Produto cadastrado com sucesso!");

                break;
                case 2:
                    Console.WriteLine("\n===============================================\n");

                    if (quantidadeProdutos == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado");
                        Console.WriteLine("\n===============================================\n");

                        break;
                    }

                    for (int i = 0; i < quantidadeProdutos; i++)
                    {
                        Console.WriteLine("Nome: " + produtos[i] + " | Valor: R$" + precos[i]);
                    }
                    Console.WriteLine("\n===============================================\n");
                break;
            case 3:

                break;
            case 4:

                break;

        }
    }

    }
}