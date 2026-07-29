internal class Program
{
    private static void Main(string[] args)
    {
        // Escreve uma linha de texto na tela
        Console.WriteLine("Programacao orientada a objetos\n By Cristiano de Paula");
        
        Console.WriteLine("Abstracai - 1o Pilar da POO");

        Pet pet1 = new Pet();
        pet1.nome = "Toto";
        pet1.tipo = "Cachorro";
        pet1.idade = 3;

        pet1.MostrarNome();

        Pet pet2 = new Pet();
        pet2.nome = "Mingau";
        pet2.tipo = "Gato";
        pet2.idade = 8;

        pet2.MostrarNome();

    }
}

    // Criar uma classe em C#
    // A classe deve ser declarada fora do bloco de programa
    public class Pet { // Nome da classe sempre inicia com letras Maiusculas    
      // Declaracao dos atributos

      public string nome;

      public string tipo;

      public int idade;
      // Declaracao dos metodos   

      public void MostrarNome() {
        Console.WriteLine("Meu nome é " + this.nome);
      }
    }

