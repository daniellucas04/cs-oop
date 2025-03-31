using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provas
{
    public class ContaSalario : Conta
    {
        public float Rendimento = 2 / 100;
        public float TaxaRetirada = 0.5f / 100;

        public ContaSalario(string nome, decimal saldo) : base(nome, saldo)
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
