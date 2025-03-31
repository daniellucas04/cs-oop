using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Horario
    {
        public int Horas {  get; set; }
        public int Minutos { get; set; }

        public Horario(int horas, int minutos)
        {
            Horas = horas;
            Minutos = minutos;
        }

        public static Horario operator + (Horario h1, Horario h2)
        {
            int horario1 = h1.Horas * 60 + h1.Minutos;
            int horario2 = h2.Horas * 60 + h2.Minutos;

            int horas = (int)((horario1 + horario2) / 60);
            int minutos = (horario1 + horario2) - horas * 60;

            return new Horario(horas, minutos);
        }

        public static Horario operator + (Horario h1, int minutos)
        {
            return h1 + new Horario(0, minutos);
        }

        public static Horario operator + (int horas, Horario h1)
        {
            return h1 + new Horario(horas, 0);
        }

        public static bool operator >= (Horario h1, Horario h2)
        {
            int horario1 = h1.Horas * 60 + h1.Minutos;
            int horario2 = h2.Horas * 60 + h2.Minutos;

            if (horario1 >= horario2)
            {
                return true;
            }

            return false;
        }

        public static bool operator <= (Horario h1, Horario h2)
        {
            int horario1 = h1.Horas * 60 + h1.Minutos;
            int horario2 = h2.Horas * 60 + h2.Minutos;

            if (horario1 <= horario2)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return Horas.ToString("00") + ":" + Minutos.ToString("00");
        }
    }
}
