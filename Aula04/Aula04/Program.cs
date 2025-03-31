using System.Security.Cryptography;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroComplexo a = new NumeroComplexo(3, 2);
            NumeroComplexo b = new NumeroComplexo(5, -4);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);   
            Console.WriteLine(a * b);
        }
    }
}
