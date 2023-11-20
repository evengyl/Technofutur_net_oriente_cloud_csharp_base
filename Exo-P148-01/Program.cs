namespace Exo_P148_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXIOUTPUT = 25;
            int x1 = 0;
            int x2 = 1;
            Console.WriteLine($"Les {MAXIOUTPUT} de la suite de Fibonacci : ");
            Console.Write($"{x1} {x2} ");
            for (int i = 2; i < MAXIOUTPUT; i++)
            {
                int nextFib = x1 + x2;
                Console.Write($"{nextFib} ");
                x1 = x2;
                x2 = nextFib;
            }
        }
    }
}