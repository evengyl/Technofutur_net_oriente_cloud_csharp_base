namespace Exo_P148_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            do
            {
                Console.WriteLine("Veuillez entrer un nombre :");
            } while (!int.TryParse(Console.ReadLine(), out nombre));

            for (int counter = 0, nbTest = 2; counter < nombre; nbTest++)
            {
                bool isPrime = true;
                for (int diviseur = 2; diviseur < nbTest && isPrime; diviseur++) {
                    if(nbTest % diviseur == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    counter++;
                    Console.WriteLine($"{nbTest} est un nombre premier.");
                }
            }
        }
    }
}