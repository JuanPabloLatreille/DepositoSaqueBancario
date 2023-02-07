using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoSaque
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string TitularBancario { get; set; }
        public double ValorInicial { get; set; }

        public ContaBancaria(int numeroconta, string titularbancario, double valorinicial)
        {
            NumeroConta = numeroconta;

            TitularBancario = titularbancario;

            ValorInicial = valorinicial;
        }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numeroconta, string titularbancario)
        {
            NumeroConta = numeroconta;
            TitularBancario = titularbancario;
        }

        public ContaBancaria(double valorinicial)
        {
            ValorInicial = valorinicial;
        }

        public void ValorDeposito(double valorinserido)
        {
            ValorInicial = ValorInicial + valorinserido;
        }

        public void ValorSaque(double valorsaquado)
        {
            ValorInicial = ValorInicial - valorsaquado;
        }

        public override string ToString()
        {
            return "Dados da conta: " + NumeroConta + " Titular: " + TitularBancario + ", " + "Saldo: " + ValorInicial.ToString("F2");
        }
    }
}
