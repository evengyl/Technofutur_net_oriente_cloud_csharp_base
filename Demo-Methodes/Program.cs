namespace Demo_Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoMethodeAll demo = new DemoMethodeAll();

            demo.ChangeDirection("Nord");
            demo.DemoReturn(5);
            demo.SumMinutesLatLong();
            demo.ShowDirection();

            Console.WriteLine("#######################################");
            string s = null;
            int? length = s?.Length;
            Console.WriteLine(length is null? "Null Value": "Bonjour");
            Console.WriteLine((length.HasValue)? length.ToString():"No Value");

            Console.WriteLine("#######################################");

            int res = demo.Multiplication(10, 20, 30);
            demo.Multiplication(10, 20, null);

            Console.WriteLine("#######################################");

            int resAdd = demo.Addition(10, 20);
            int resAdd2 = demo.Addition(15, 25, 36);

            Console.WriteLine("Res 1 addtion " + resAdd);
            Console.WriteLine("Res 2 addtion " + resAdd2);


            Console.WriteLine("#######################################");
            int nombre1 = 99;
            int nombre2 = 42;
            int resSous1 = demo.Soustraction(nb3:nombre1, nb1:nombre2);
            Console.WriteLine("Res 1 sousstraction : " + resSous1);


            Console.WriteLine("#######################################");
            demo.AdditionMegaParams('+', 2, 3, 4, 5, 6, 7, 84, 132, 1231, 56, 465, 132, 10, 5846, 514, 321, 58, 6451, 32);



            Console.WriteLine("#######################################");
            double tauxTVACurrent = 1.21;
            demo.CalculeTVASpecial(ref tauxTVACurrent);
            Console.WriteLine("TVA Courrante : " + tauxTVACurrent);
        }
    }


    public struct DemoMethodeAll
    {
        public string direction;
        public int minutes;
        public int secondes;


        public void CalculeTVASpecial(ref double tva)
        {
            Console.WriteLine("TVA de ce client VIP:  " + tva);
            //en réalite petit retour d'api, me donnant en réalité un avantage de 0.02 de tva,
            //donc ma tva passe a 1.19
            tva = 1.19;
            //suite non précises d'opération en tous genres !!!! blablabla
        }

        public void CalculeTVASpecial(ref int tva)
        {
            Console.WriteLine("TVA de ce client VIP:  " + tva);
            //en réalite petit retour d'api, me donnant en réalité un avantage de 0.02 de tva,
            //donc ma tva passe a 1.19
            tva = 119;
            //suite non précises d'opération en tous genres !!!! blablabla
        }


        public void CalculeTVASpecial(ref string tauxTva)
        {
            Console.WriteLine("TVA de ce client VIP:  " + tauxTva);
            //en réalite petit retour d'api, me donnant en réalité un avantage de 0.02 de tva,
            //donc ma tva passe a 1.19
            tauxTva = "rare";
            //suite non précises d'opération en tous genres !!!! blablabla
        }



        public void AdditionMegaParams(char opterator, params int[] nb)
        {
            int res = 0;

            foreach (int i in nb)
            {
                res += i;
            }


            Console.WriteLine(res);
        }



        public int Operation(in char operatori, int nb1, int nb2)
        {
            int res;
            //operatori = '-';

            if (operatori == '+')
                res = nb1 + nb2;
            else
                res = 0;

            return res;
        }

        public int Multiplication(int nb1, int nb2, int? nb3)
        {
            Console.WriteLine("Nb1 : " + nb1);
            Console.WriteLine("Nb2 : " + nb2);
            Console.WriteLine("Nb3 : " + nb3);

            int res = (nb3 is not null) ? nb1 * nb2 * ((int)nb3) : nb1 * nb2;
            Console.WriteLine(res);
            return res;
        }

        public int Addition(int nb1, int nb2, int nb3 = 12)
        {
            return nb1 + nb2 + nb3;
        }


        public int Soustraction(int nb1 = 15, int nb2 = 30, int nb3 = 45)
        {
            return nb1 - nb2 - nb3;
        }

        public int DemoReturn(int number)
        {
            if (number > 10)
                return 42;
            else if (number < 0)
                return -42;

            return 0;
        }

        public int SumMinutesLatLong()
        {
            return minutes + (secondes/60);
        }


        public void ShowDirection()
        {
            Console.WriteLine(direction);
        }

        public bool ChangeDirection(string newDirection)
        {
            direction = newDirection;
            return true;
        }
    }
}