using System.Collections;

namespace Exo_P164_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbLimit;
            do
            {
                Console.WriteLine("Veuillez indiquer une limite pour la récupération de nombres premier :");
            }while (!int.TryParse(Console.ReadLine(), out nbLimit));

            int nbTest = 2;

            ArrayList listPrimeNbs = new ArrayList();

            while (nbLimit >= nbTest) {
                bool isPrime = true;
                int diviseur = 2;
                while(diviseur < nbTest && isPrime)
                {
                    if(nbTest % diviseur == 0)
                    {
                        isPrime = false;
                    }
                    diviseur++;
                }

                if(isPrime) listPrimeNbs.Add(nbTest);
                nbTest++;
            }

            foreach (int nbPrime in listPrimeNbs)
            {
                Console.WriteLine($"{nbPrime} est un nombre premier.");
            }

        }
    }
}