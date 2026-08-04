internal class Program
{
    private static void Main(string[] args)
    {
        string[] listaFrutas = { "Maca", "Manga", "Morango", "Melancia", "Melao" };

        Console.WriteLine("Acessar o terceiro elemento da lista: ");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("Alterar o segundo elemento da lista: ");
        listaFrutas[1] = "Banana";

        Console.WriteLine("Alterado com sucesso!");

        Console.WriteLine("\n==============================================\n");

        for (int indice = 0; indice < listaFrutas.Length; indice++)
        {
            Console.WriteLine(listaFrutas[indice]);
        }

        Console.WriteLine("\n==============================================\n");

        foreach (string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }

    }
}