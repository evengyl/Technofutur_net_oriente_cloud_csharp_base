namespace Demo_Tableau_Taille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temps;
            int taille;
            do {
                Console.WriteLine("Combien de température ?");
            } while (!int.TryParse(Console.ReadLine(), out taille));

            temps = new double[taille];

            Console.WriteLine($"Le tableau de températures contient {temps.Length} températures...");

            do
            {
                Console.WriteLine("Nouvelle taille ?");
            } while (!int.TryParse(Console.ReadLine(), out taille));

            temps = new double[taille];

            Console.WriteLine($"Le tableau de températures contient {temps.Length} températures...");

        }
    }
}