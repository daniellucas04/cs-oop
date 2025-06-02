using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSub1
{
    public abstract class Robo
    {
        private string nome;
        private int atk;
        private int def;
        private int spd;
        private int hp;
        private int hpMAX;

        public string Nome
        {
            get { return nome; }
            protected set
            {
                nome = value;
            }
        }
        public int ATK
        {
            get { return atk; }
            protected set
            {
                if (value >= 1 && value <= 100)
                    atk = value;
                else
                    throw new Exception("Valor inválido");
            }
        }
        public int DEF
        {
            get { return def; }
            protected set
            {
                if (value >= 1 && value <= 100)
                    def = value;
                else
                    throw new Exception("Valor inválido");
            }
        }
        public int SPD
        {
            get { return spd; }
            protected set
            {
                if (value >= 1 && value <= 100)
                    spd = value;
                else
                    throw new Exception("Valor inválido");
            }
        }

        public int HP
        {
            get { return hp; }
            protected set
            {
                if (value >= 0)
                    hp = value;
                else
                    throw new Exception("Valor inválido");
            }
        }

        public int HPMAX
        {
            get { return hpMAX; }
            protected set
            {
                if (value >= 0)
                    hpMAX = value;
                else
                    throw new Exception("Valor inválido");
            }
        }

        public Robo(string nome, int atk, int def, int spd, int hp)
        {
            Nome = nome;
            ATK = atk;
            DEF = def;
            SPD = spd;
            HP = hp;
            HPMAX = hp;
        }

        public static bool operator * (Robo atacante, Robo defensor)
        {
            if (atacante.HP == 0)
            {
                throw new Exception("O robô não possui energia");
            }

            if (defensor.HP == 0)
            {
                throw new Exception("O robô já foi derrotado");
            }

            int dano = atacante.ATK - defensor.DEF;

            if (dano > 0)
            {
                if (atacante.SPD > 2 * defensor.SPD)
                    dano *= 2;

                if (dano < defensor.HP)
                    defensor.HP -= dano;
                else
                    defensor.HP = 0;

                return true;
            }

            return false;
        }

        public abstract void Special();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string tipo = "???";
            if (this is RoboAco)
                tipo = "Aço";
            else if (this is RoboFerro)
                tipo = "Ferro";
            else if (this is RoboTitanio)
                tipo = "Titanio";

            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Tipo: {tipo}");
            sb.AppendLine($"HP: {HP}/{HPMAX}");
            sb.AppendLine($"ATK: {ATK}");
            sb.AppendLine($"DEF: {DEF}");
            sb.AppendLine($"SPD: {SPD}");

            return sb.ToString();
        }
    }
}
