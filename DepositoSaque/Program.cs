using System;
using System.Globalization;

namespace DepositoSaque // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com o numero da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com o nome do titular da conta: ");
            string titularbancario = Console.ReadLine();

            ContaBancaria contabancaria = new ContaBancaria(numeroconta, titularbancario);

            System.Console.WriteLine("Havera deposito inicial (s/n) ?");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                System.Console.WriteLine("Entre com o deposito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contabancaria.ValorDeposito(depositoinicial);
                System.Console.WriteLine(contabancaria);
            }
            else
            {
                System.Console.WriteLine(contabancaria);
            }

            System.Console.WriteLine("------------------------------------------------------------");

            System.Console.WriteLine("Entre um valor para deposito:");
            double valorinserido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabancaria.ValorDeposito(valorinserido);
            System.Console.WriteLine("Dados atualizados:");
            System.Console.WriteLine();
            System.Console.WriteLine(contabancaria);

            System.Console.WriteLine("-----------------------------------------------------------");

            System.Console.WriteLine("Entre um valor para saque: ");
            double valorsaquado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (contabancaria.ValorInicial > valorsaquado)
            {
                contabancaria.ValorSaque(valorsaquado);
                System.Console.WriteLine("Dados atualizados da conta:");
                System.Console.WriteLine();
                System.Console.WriteLine(contabancaria);
            }
            else
            {
                System.Console.WriteLine("-----------------------------------------------------------");
                System.Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}