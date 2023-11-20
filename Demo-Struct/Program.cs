namespace Demo_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Localisation bruxelle;
            bruxelle.longitude.direction = "Nord";
            bruxelle.longitude.degre = 50;
            bruxelle.longitude.minutes = 51;
            bruxelle.longitude.secondes = 1;

            bruxelle.latitude.direction = "Est";
            bruxelle.latitude.degre = 4;
            bruxelle.latitude.minutes = 20;
            bruxelle.latitude.secondes = 55;

            bruxelle.altitude = 20;


            bruxelle.latitude.ShowDirection();
            bruxelle.longitude.ShowDirection();

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Bruxelles - Altitude : {0}", bruxelle.altitude);
            Console.WriteLine("Latitude : {0:D2}°{1:D2}'{2:D2}\"{3:D2}", bruxelle.latitude.degre, bruxelle.latitude.minutes, bruxelle.latitude.secondes, bruxelle.latitude.direction);
            Console.WriteLine("Longitude : {0:D2}°{1:D2}'{2:D2}\"{3:D2}", bruxelle.longitude.degre, bruxelle.longitude.minutes, bruxelle.longitude.secondes, bruxelle.longitude.direction);

        }
    }

    public struct MesureAngulaire
    {
        public int degre;
        public int minutes;
        public int secondes;
        public string direction;

      
    }

    public struct Localisation
    {
        public MesureAngulaire longitude;
        public MesureAngulaire latitude;
        public int altitude;
    }
}