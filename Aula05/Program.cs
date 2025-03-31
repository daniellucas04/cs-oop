namespace Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());

                if (a < 0)
                    throw new NumeroException(Error.CalculadoraEntradaNegativa);

                Console.Write("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());

                if (a < 0)
                    throw new NumeroException(Error.CalculadoraEntradaNegativa);

                Console.Write($"| {a} + {b} = {Calculadora.Somar(a, b)} |\t");
                Console.Write($"| {a} - {b} = {Calculadora.Subtrair(a, b)} |\t");
                Console.Write($"| {a} * {b} = {Calculadora.Multiplicar(a, b)} |\t");
                Console.Write($"| {a} / {b} = {Calculadora.Dividir(a, b)} |\t\n");
            }
            catch (NumeroException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("\n" + Error.CalculadoraEntradaNumeroInvalido);
            }
            catch
            {
                Console.WriteLine("\n" + Error.SistemaErroGeral);
            }
        }
    }
}
