using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Provas
{
    public class Lote
    {
        public float Largura {  get; set; }
        public float Profundidade {  get; set; }
        public string Codigo { get; set; }
        public char Letra { get; set; }

        public Lote(float largura, float profundidade, char letra)
        {
            Largura = largura;
            Profundidade = profundidade;
            Letra = letra;
            Codigo = codigo();
        }

        public static Lote operator + (Lote a, Lote b)
        {
            if (a.Profundidade != b.Profundidade)
                throw new Exception("Não é possível juntar lotes de profundidades diferentes");

            float novaLargura = a.Largura + b.Largura;

            char letra = (a.Letra < b.Letra) ? a.Letra : b.Letra;

            return new Lote(novaLargura, a.Profundidade, letra);
        }

        public static List<Lote> operator / (Lote a, int qtd)
        {
            if (a.Largura % qtd != 0)
                throw new Exception("Não é possível dividir o lote igualmente");

            char novaLetra = a.Letra;
            float novaLargura = a.Largura / qtd;
            List<Lote> lotes = new List<Lote>();

            for (int i = 0; i < qtd; i++)
            {
                lotes.Add(new Lote(novaLargura, a.Profundidade, novaLetra));
                novaLetra = (novaLetra == 'Z') ? '@' : novaLetra;
                novaLetra++;
            }

            return lotes;
        }

        private string codigo()
        {
            float area = Largura * Profundidade;

            return Letra.ToString() + area;
        }
    }
}
