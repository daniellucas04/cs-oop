namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etanol e = new Etanol("ABC1231", "Gol", 1999, 1998, 10000.00m);
            Gasolina g = new Gasolina("ABC4124", "Gol", 1998, 1999, 10000.00m);
            Flex f = new Flex("BAC2144", "Fusca", 2020, 2021, 1000.00m);

            Console.WriteLine(e.calcularIpva());

            Console.WriteLine(g.calcularIpva());

            Console.WriteLine(f.calcularIpva());
        }
    }
}
