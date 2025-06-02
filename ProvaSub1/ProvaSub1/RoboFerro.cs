using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSub1
{
    public class RoboFerro : Robo
    {
        public RoboFerro(string nome, int atk, int def, int spd, int hp) : base(nome, atk, def, spd, hp)
        {
        }

        public override void Special()
        {
            if (HP == 0)
                throw new Exception("O robô não possui energia");

            if (ATK <= 50 && HP > 0)
            {
                ATK *= 2;
                HP /= 2;
            }
            else
                throw new Exception("Não é possível utilizar o Special");
        }
    }
}
