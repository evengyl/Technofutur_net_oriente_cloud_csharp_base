namespace Demo_enums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TypeHero userHeroType = TypeHero.War;
            Console.WriteLine(userHeroType.ToString());
            Console.WriteLine((int)userHeroType);
            Console.WriteLine("----------------------------------------------");


            //lister tout ce qu'il y a dans l'enum (PRATIQUE POUR LES SELECT HTML INPUT)
            foreach (string s in Enum.GetNames(typeof(TypeHero)))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------------------------");

            //parse dans l'autre sens, -> de la KEY vers la VALUE
            string userInput = "Paladin";
            TypeHero varUserParsed = (TypeHero) Enum.Parse(typeof(TypeHero), userInput);
            Console.WriteLine(varUserParsed);
            Console.WriteLine((int)varUserParsed);


            Console.WriteLine("----------------------------------------------");
            string userInputTry = "Mageg";
            TypeHero resultEnumTry;
            if(Enum.TryParse<TypeHero>(userInputTry, out resultEnumTry))
            {
                Console.WriteLine(resultEnumTry.ToString());
                Console.WriteLine((int)resultEnumTry);
            }
            else
            {
                Console.WriteLine("Cette Classe n'existe pas, Pignouf!!!");
            }
        }


        public enum TypeHero
        {
            Hunter = 0,
            War = 1,
            Mage = 2,
            Warlock = 3,
            Rogue = 4,
            Paladin = 5
        }
    }
}