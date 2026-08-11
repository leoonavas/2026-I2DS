using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Carro carro1 = new Carro();

        carro1.Marca = "Ferrari";
        carro1.Modelo = "SF90";
        carro1.Velocidade = 90;
        int option = 0;
        while (true)
        {
            Console.WriteLine($"Marca: {carro1.Marca} | Modelo: {carro1.Modelo} | Velocidade: {carro1.Velocidade}km/h");
            Console.Write("[1] - Acelerar\n[2] - Desacelerar\nDigite uma opção: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    carro1.Acelerar();
                    break;
                case 2:
                    carro1.Desacelerar();
                    break;
            }
        }
    }

    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 10;
        }
    }
}