namespace Exo_P148_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            do {
                Console.WriteLine("Veuillez entrer un nombre :");
            } while (!int.TryParse(Console.ReadLine(), out nombre));

            long resultat = nombre;

            for (int i = nombre-1; i > 1; i--)
            {
                //resultat = resultat * i;
                resultat *= i;
            }

            Console.WriteLine(resultat);
        }
    }
}