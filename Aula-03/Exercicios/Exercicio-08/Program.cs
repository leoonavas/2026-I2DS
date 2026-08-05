using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Line(8);
        Exercicio08();

    }

    public static void Line(int num)
    {
        Console.WriteLine("\nExercicio " + num + "  ============================================");
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static void Exercicio08()
    {
        string userCorreto = "admin";
        string senhaCorreto = "1234";
        int tentativas = 0;
        while (true)
        {
            string user = "";
            Console.Write("Digite seu usuario: ");
            user = Console.ReadLine();

            string senha = "";
            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();

            if (user == userCorreto && senha == senhaCorreto)
            {
                Console.WriteLine("Logado com sucesso!");
                break;
            }
            else
            {
                tentativas++;
                Console.WriteLine("Usuario ou senha incorretos");
                Console.WriteLine("Tentativas restantes: " + (3 - tentativas));
            }

            if (tentativas == 3)
            {
                Console.WriteLine("Voce atingiu o limite de tentativas. Tente novamente mais tarde.");
                break;
            }
        }

    }
}