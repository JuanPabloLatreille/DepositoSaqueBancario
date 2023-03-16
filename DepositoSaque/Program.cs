using System.Globalization;

namespace DepositoSaque // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular da conta: ");
            string titularbancario = Console.ReadLine();

            ContaBancaria contabancaria = new ContaBancaria(numeroconta, titularbancario);

            Console.WriteLine("Haverá deposito inicial (s/n) ?");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Entre com o deposito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contabancaria.ValorDeposito(depositoinicial);
                Console.WriteLine(contabancaria);
            }
            else
            {
                Console.WriteLine(contabancaria);
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Entre um valor para deposito:");
            double valorinserido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabancaria.ValorDeposito(valorinserido);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine();
            Console.WriteLine(contabancaria);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Entre um valor para saque: ");
            double valorsaquado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (contabancaria.ValorInicial > valorsaquado)
            {
                contabancaria.ValorSaque(valorsaquado);
                Console.WriteLine("Dados atualizados da conta:");
                Console.WriteLine();
                Console.WriteLine(contabancaria);
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}