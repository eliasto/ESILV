using System;

namespace CMO_ALGO_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[10];

            for(int i = 0;i<=tableau.Length-1;i++)
            {
                Console.WriteLine("Quelle valeur a affecté sur la case " + i+1 + " ?");
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int a in tableau)
            {
                Console.WriteLine(a);
            }


        }
    }
}
