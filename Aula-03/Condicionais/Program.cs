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
        }
        else
        {
            Console.WriteLine("Reprovado");

        }

        bool bloqueado = false;

        if (!bloqueado)
        {
            Console.WriteLine("Acesso permitido");
        }



        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Consultar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Sair");

        Console.Write("Escolha uma opcao: ");
        int opcao = int.Parse(Console.ReadLine());
        
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Cadastro selecionado");
                break;
            case 2:
                Console.WriteLine("Consulta selecionada");
                break;
            case 3:
                Console.WriteLine("Exclusao selecionada");
                break;
            case 4:
                Console.WriteLine("Encerrando sistema");
                break;
            default:
                Console.WriteLine("Opcao invalida");

                break;
        }
    }
}