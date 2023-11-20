namespace Exo_P171_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[,] grille = new Point[5,5];

            for(int i = 0; i < grille.GetLength(0);  i++)
            {
                grille[i, i].x = i + 1;
                grille[i, i].y = i + 1;
            }


            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(0); j++)
                {
                    Console.Write((i == j)? $"X : {grille[i,j].x} - Y : {grille[i, j].y}": "\t");
                }
                Console.WriteLine();
            }


        }



        public struct Point
        {
            public int x;
            public int y;
        }
    }
}