using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provas
{
    public abstract class Imovel
    {
        public string Codigo { get; set; }
        public int Comodos { get; set; }
        public float Aluguel {  get; set; }

        public bool Desconto(float valor)
        {
            throw new NotImplementedException();
        }
    }
}
