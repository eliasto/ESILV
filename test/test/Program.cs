using System;

namespace test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Somme(a, b);



        }

        public int Somme(int a, int b)
        {


            int i;
            if (a > b)
            {
                return 0;
            }
            for (i = a; i == b; i++)
            {
                
            }
            return i;
        }
    }
}
