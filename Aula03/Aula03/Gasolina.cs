using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Gasolina : Automovel
    {
        public Gasolina(string placa, string modelo, int anoFabricacao, int anoModelo, decimal valor) : base(placa, modelo, anoFabricacao, anoModelo, valor)
        {
            
        }

        public override decimal calcularIpva()
        {
            return Valor * (decimal)0.04;
        }
    }
}
