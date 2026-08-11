internal class Program
{
    private static void Main(string[] args)
    {

    }

    public class ContaBancaria
    {
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double SaldoAtual { get; set; }

        public void Depositar(double Valor)
        {
            SaldoAtual += Valor;
            // SaldoAtual = SaldoAtual + Valor 
        }

        public virtual void Sacar(double Valor)
        {
            if (Valor < SaldoAtual)
            {
                SaldoAtual -= Valor;
                // SaldoAtual = SaldoAtual -= Valor;
            }
            else
            {
                Console.WriteLine("\nSALDO INSUFICIENTE!");
            }
        }
    }
    public class ContaCorrente : ContaBancaria
    {
        public double Limite { get; set; }

        public override void Sacar(double Valor)
        {
            if (Valor < (SaldoAtual + Limite))
            {
                SaldoAtual -= Valor;
                // SaldoAtual = SaldoAtual -= Valor;
            }
            else
            {
                Console.WriteLine("\nLIMITE E SALDO INSUFICIENTE!");
            }
        }
    }
}