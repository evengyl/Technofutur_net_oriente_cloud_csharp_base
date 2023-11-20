namespace Exo_P148_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int table = 1; table <= 5; table++)
            {
                Console.WriteLine($"Table de {table}:");
                for (int multi = 1; multi < 21; multi++)
                {
                    Console.WriteLine($"{table} x {multi} = {table*multi}");
                }
            }
        }
    }
}