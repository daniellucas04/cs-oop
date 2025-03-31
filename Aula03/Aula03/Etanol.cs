using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Aula03
{
    public sealed class Etanol : Automovel
    {
        public Etanol(string placa, string modelo, int anoFabricacao, int anoModelo, decimal valor) : base(placa, modelo, anoFabricacao, anoModelo, valor)
        {
            
        }

        public override decimal calcularIpva()
        {
            return Valor * (decimal)0.03;
        }
    }
}
