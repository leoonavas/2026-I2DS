internal class Program
{
    private static void Main(string[] args)
    {
        int idade = 16;

        if (idade >= 18)
        {
            Console.WriteLine("O usuario e maior de 18 anos");
        }
        else
        {
            Console.WriteLine("O usuario e menor de 18 anos");
        }

        Console.Write("Digite a nota: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Aprovado");
        } else
        {
            Console.WriteLine("Reprovado");

        }
    }
}