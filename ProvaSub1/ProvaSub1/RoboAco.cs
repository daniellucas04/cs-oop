using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSub1
{
    public class RoboAco : Robo
    {
        public RoboAco(string nome, int atk, int def, int spd, int hp) : base(nome, atk, def, spd, hp)
        {
        }

        public override void Special()
        {
            if (HP == 0)
                throw new Exception("O robô não possui energia");

            if (HP + SPD <= HPMAX && ATK > 1)
            {
                HP += SPD;
                ATK /= 2;
            }
            else
                throw new Exception("Não é possível utilizar o Special");
        }
    }
}
