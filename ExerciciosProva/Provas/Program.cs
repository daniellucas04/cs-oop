using System.Diagnostics.Contracts;

namespace Provas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lotes();
            // Contas();
            
        }

        static void Lotes()
        {
            Lote lote1 = new Lote(12, 20, 'Z');
            Lote lote2 = new Lote(10, 20, 'B');

            Lote novoLote = lote1 + lote2;
            Console.WriteLine("Sobrecarga +: " + lote1.Codigo);

            List<Lote> lotes = lote1 / 3;
            foreach (var item in lotes)
            {
                Console.WriteLine("Sobrecarga /: " + item.Codigo);
            }
        }

        static void Contas()
        {
            ContaSalario cs = new ContaSalario("Daniel", 500.00m);
            ContaPoupanca cp = new ContaPoupanca("Daniel", 500.00m);
            Console.WriteLine(cs.Saque(500));
            Console.WriteLine(cs.Deposito(10));

            Console.WriteLine(cp.Saque(100));
            Console.WriteLine(cp.Deposito(20));
        }
    }
}
