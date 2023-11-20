namespace Exo_P192_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equation2ndDegre eq = new Equation2ndDegre();
            eq.A = 2;
            eq.B = 9;
            eq.C = -5;

            if (eq.Resoudre())
            {
                string result = (eq.X1 == eq.X2) ? $"\n\tx = {eq.X1}" : $"\n\tx1 = {eq.X1} \n\tx2 = {eq.X2}";
                Console.WriteLine($"Pour l'équation du 2nd degré : {eq.A}x² + {eq.B}x + {eq.C}, {result}");
            }
            else
            {
                Console.WriteLine("L'équation n'admet pas de solution réelle.") ;
            }
        }
    }

    public struct Equation2ndDegre
    { 
        public double A, B, C;
        public double? X1, X2;

        public bool Resoudre()
        {
            X1 = X2 = null;
            double delta = B * B - 4 * A * C;

            if(delta >= 0) 
            {
                X1 = (-B - Math.Sqrt(delta)) / (2 * A);
                X2 = (-B + Math.Sqrt(delta)) / (2 * A);
                return true;
            }

            return false;
        }
    }
}