using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provas
{
    public abstract class Conta
    {
        public string Nome {  get; set; }
        public decimal Saldo { get; set; }

        protected Conta(string nome, decimal saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }

        public decimal Deposito(decimal valor)
        {
            return Saldo += valor;
        }
    }
}
