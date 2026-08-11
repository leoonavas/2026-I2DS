internal class Program
{
    private static void Main(string[] args)
    {
        Personagem p = new Personagem();
        Console.Write("Digite o nome do seu personagem: ");
        p.Nome = Console.ReadLine();
        p.Vilao = "Cristiano";

        Random aleatorio = new Random();
        p.Vida = 100;
        p.Nivel = 1;
        p.Forca = aleatorio.Next(2, 9);
        p.Agilidade = aleatorio.Next(2, 9);
        p.Inteligencia = aleatorio.Next(2, 9);
        p.Energia = 200;

        Console.WriteLine("=======================\nSEUS ATRIBUTOS=======================\n");
        Console.WriteLine($"Vida: {p.Vida}\nEnergia: {p.Energia}\nNível: {p.Nivel}\nForca: {p.Forca}\nAgilidade: {p.Agilidade}\nInteligencia: {p.Inteligencia}");

        Console.WriteLine("=======================\nHISTORIA=======================\n");
        Console.WriteLine($"Voce caminhava lentamente pelo vale enquanto avistou pegadas de um ser desconhecido, voce pegou seu grimorio e comparou pegada por pegada, até descobrir que o ser desconhecido era {p.Vilao}...");
        Console.WriteLine($"Enquanto estava distraido, {p.Vilao}, Cristiano aparece em suas costas e joga uma Bola de Fogo em você, o que você faz?");
        Console.Write("[1] - Fica parado\n[2] - Tenta correr/desviar\n [3] - Ataca a bola de fogo");
        int option = 0;
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine($"As bolas de {p.Vilao} te atingem e você toma 30 de dano!");
                p.Vida -= 30;
                break;
            case 2:
                int chance = aleatorio.Next(3);
                if (chance == 1)
                {
                    Console.WriteLine($"Você corre como se não houvesse amanha e consegue desviar das bolas de {p.Vilao}");
                } else
                {
                    Console.WriteLine("Você tenta desviar mas acaba sendo atingido de raspão e tomando 20 de dano!");
                    p.Vida -= 20;
                }
                break;
            case 3:
                int prob = aleatorio.Next(3);
            
                break;
        }

    }

    public class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Vida { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public double XP { get; set; }
        public string Vilao { get; set; }
        public int Energia { get; set; }






    }
}