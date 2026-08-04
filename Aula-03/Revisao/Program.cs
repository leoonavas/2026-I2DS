using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        // criar uma variavel

        // sintaxe: tipo variavel nome-variavel = valor

        // tipos de dados primarios
        /*
            int -> Representa numeros inteiros
            double/float -> Representa numeros com valores decimais
            string -> Representa textos alphanumericos
            char -> Representa uma caractere
            bool -> Representa um valor de verdadeiro/falso (true/false)
            DateTime -> Representacao de data e hora
        
        */

        int idade = 21;

        float altura = 1.75f;

        double salario = 10352.25;

        string nome = "Cristiano de Páula";

        bool cristiano_e_professor = true;

        bool cristiano = true;


        /* ********************************************************************************************* */
        /* Operadores Matematicos

        */

        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        // Calcular  a soma: 
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois numeros é: " + resultado);

        // Calcular  a subtracao: 
        resultado = n1 - n2;
        Console.WriteLine("A subtração dos dois numeros é: " + resultado);

        // Calcular  a multiplicação: 
        resultado = n1 * n2;
        Console.WriteLine("A multiplicação dos dois numeros é: " + resultado);

        // Calcular  a divisão: 
        resultado = n1 / n2;
        Console.WriteLine("A divisão dos dois numeros é: " + resultado);


        // Operadores relacionais -> Realizam comparacoes

        /*
        > -> maior que
        < -> menor que
        >= -> Maior ou igual
        <= Menor ou igual
        == -> Igual
        != Diferente

        */

        idade = 13;
        Console.WriteLine("");
        

    }
}