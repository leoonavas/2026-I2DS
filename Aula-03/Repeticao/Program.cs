internal class Program
{
    private static void Main(string[] args)
    {



        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        string senha = "";

        while (senha != "2444")
        {
            Console.Write("Digite a sua senha: ");
            senha = Console.ReadLine();



        }
        Console.WriteLine("Acesso Permitido!");
    }
}