using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSub1
{
    public class RoboTitanio : Robo
    {
        public RoboTitanio(string nome, int atk, int def, int spd, int hp) : base(nome, atk, def, spd, hp)
        {
        }

        public override void Special()
        {
            if (HP == 0)
                throw new Exception("O robô não possui energia");

            if (DEF <= 50 && HP > 1 && ATK > 1)
            {
                DEF *= 2;
                HP /= 2;
                ATK /= 2;
            }
            else
                throw new Exception("Não é possível utilizar o Special");
        }
    }
}
