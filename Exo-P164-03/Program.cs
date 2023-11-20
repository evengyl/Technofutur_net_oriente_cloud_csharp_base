namespace Exo_P164_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nb1, nb2;

            do
            {
                Console.WriteLine("Veuillez entrer un premier nombre :");
                nb1 = Console.ReadLine();
            } while (!int.TryParse(nb1, out _));

            do
            {
                Console.WriteLine("Veuillez entrer un second nombre :");
                nb2 = Console.ReadLine();
            } while (!int.TryParse(nb2, out _));

            while (nb1.Length < nb2.Length)
            {
                nb1 = $"0{nb1}";
            }

            while (nb2.Length < nb1.Length)
            {
                nb2 = $"0{nb2}";
            }

            char[] nb1Array = nb1.ToCharArray();
            char[] nb2Array = nb2.ToCharArray();
            string result = "";
            int report = 0;
            for (int i = nb1Array.Length - 1; i >= 0; i--)
            {
                int nb1Int = (int)nb1Array[i]-48; //On obtient le code ASCII d'où le -48 qui permet d'obtenit le bon nombre
                int nb2Int = (int)char.GetNumericValue(nb2Array[i]);

                int somme = nb1Int + nb2Int + report;
                int unite = somme % 10;
                report = somme / 10;
                result = unite + result;
            }

            Console.WriteLine((report != 0)?report + result : result);
        }
    }
}