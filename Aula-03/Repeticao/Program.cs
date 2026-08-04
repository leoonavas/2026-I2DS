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

        int num;
        do
        {
            Console.Write("Digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());
        } while (num <= 0);
    }
}