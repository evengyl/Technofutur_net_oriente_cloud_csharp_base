namespace Exo_P164_02
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

            List<int> primeNbs = new List<int>();
            primeNbs.Add(2);

            for (int nbTest = 3; primeNbs.Count < nombre; nbTest++)
            {
                bool isPrime = true;
                for (int i = 0; i < primeNbs.Count && isPrime; i++)
                {
                    if (nbTest % primeNbs[i] == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primeNbs.Add(nbTest);
                }
            }

            foreach (int nb in primeNbs)
            {
                Console.WriteLine($"{nb} est un nombre premier.");
            }
        }
    }
}