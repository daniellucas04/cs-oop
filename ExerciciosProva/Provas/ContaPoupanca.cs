using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provas
{
    public class ContaPoupanca : Conta
    {
        public float Rendimento = 4 / 100;
        public new float TaxaRetirada = 1 / 100;

        public ContaPoupanca(string nome, decimal saldo) : base(nome, saldo)
        {
        }

        public decimal Saque(decimal valor)
        {
            if (Saldo <= 0)
                throw new Exception("Não é possível realizar o saque. Saldo inválido");

            if (Saldo - valor < 0)
                throw new Exception("Saldo insuficiente.");

            decimal taxa = (decimal)TaxaRetirada * valor;

            Saldo = Saldo - valor;

            return Saldo;
        }
    }
}
