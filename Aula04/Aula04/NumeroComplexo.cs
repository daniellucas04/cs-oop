using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class NumeroComplexo
    {
        public double Real {  get; set; }
        public double Imaginario { get; set; }

        public NumeroComplexo(double real, double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }

        public static NumeroComplexo operator + (NumeroComplexo a, NumeroComplexo b)
        {
            double real = a.Real + b.Real;
            double imaginario = a.Imaginario + b.Imaginario;

            return new NumeroComplexo(real, imaginario);
        }

        public static NumeroComplexo operator - (NumeroComplexo a, NumeroComplexo b)
        {
            double real = a.Real - b.Real;
            double imaginario = a.Imaginario - b.Imaginario;

            return new NumeroComplexo(real, imaginario);
        }

        public static NumeroComplexo operator * (NumeroComplexo a, NumeroComplexo b)
        {
            double real = a.Real * b.Real - (a.Imaginario * b.Imaginario);
            double imaginario = a.Real * b.Imaginario + (a.Imaginario * b.Real);

            return new NumeroComplexo(real, imaginario);
        }

        public override string ToString()
        {
            if (Imaginario > 0)
            {
                return Real + "+" + Imaginario + "i";
            }
            else if(Imaginario < 0)
            {
                return Real + "" + Imaginario + "i";
            } else
            {
                return Real + " +0i";
            }
        }
    }
}
