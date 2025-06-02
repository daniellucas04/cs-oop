namespace ProvaSub1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Robo> robos = new List<Robo>();
            robos.Add(new RoboFerro("X", 60, 50, 60, 500));
            robos.Add(new RoboAco("Zero", 80, 30, 70, 300));
            robos.Add(new RoboTitanio("Bass", 40, 90, 40, 900));

            foreach (Robo robo in robos)
            {
                Console.WriteLine(robo.ToString());
            }
        }
    }
}
