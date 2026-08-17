internal class Program
{
    private static void Main(string[] args)
    {
        List<string> cidades = new List<string>
        {
            "São Paulo",
            "Rio de Janeiro",
            "Belo Horizonte",
            "Salvador",
            "Jaú"
        };

        foreach (string cidade in cidades)
        {
            Console.WriteLine(cidade);
        }
    }
}