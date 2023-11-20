namespace Exo_P148_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demande de l'énoncé

            //for (double i = 0; i <= 20; i+=0.1)
            //{
            //    Console.WriteLine(i);
            //}


            //Solution Quasiment OK (convertion en string avec 2 décimals)

            //for (double i = 0; i <= 20; i += 0.1)
            //{
            //    Console.WriteLine(i.ToString("N2"));
            //}


            //Bonne solution

            for (decimal i = 0; i <= 20; i += 0.1M)
            {
                Console.WriteLine(i);
            }

        }
    }
}