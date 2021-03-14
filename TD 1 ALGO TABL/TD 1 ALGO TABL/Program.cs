using System;

namespace TD_1_ALGO_TABL
{
    class Program
    {
        static void Main(string[] args)
        {
            exo99();
        }
        static void exo1()
        {
            int[] tab = new int[6] { 5, 8, 3, 2, 6, 4 };
            int i = 0;

            while (i < tab.Length)
            {
                Console.WriteLine(tab[i]);
                i++;
            }
            for(int j = 0; j < tab.Length; j++)
            {
                Console.WriteLine(tab[j]);
            }
            foreach(int a in tab)
            {
                Console.WriteLine(a);
            }
        }
        static void exo2()
        {
            int[] tab = new int[] { 5, 8, 3, 2, 6, 4 };

            for(int i = 0; i < tab.Length; i++)
            {
                if(i == tab.Length - 1)
                {
                    Console.Write(tab[i] + "");

                }
                else
                {
                    Console.Write(tab[i] + " ; ");

                }
            }
        }
        static void exo3()
        {
            int[] tab = { 5, 8, 3, 2, 6, 4 };

            for(int i = tab.Length-1; i >= 0; i = i - 1)
            {
                Console.Write(tab[i] + " ");
            }
        }
        static void exo4()
        {
            int[] tab = { 5, 8, 3, 2, 6, 4 };
            int j = 0;
            foreach(int i in tab)
            {
                if (j % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                j++;
            }
        }
        static void exo5()
        {
            int[] tab = { 5, 8, 3, 2, 6, 4 };
            foreach (int i in tab)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void exo6()
        {
            int[] tab = new int [Convert.ToInt32(Console.ReadLine())];
            int k = tab.Length;
            for(int i = 0; i<tab.Length; i++)
            {
                tab[i] = k;
                k--;
                
            }
            foreach(int j in tab)
            {
                Console.Write(j + " ");
            }

        }
        static void exo7()
        {
            int[] tab = new int[Convert.ToInt32(Console.ReadLine())];
            int j = 2;
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = j;
                j = j + 2;
            }
            foreach(int k in tab)
            {
                Console.Write(k + " ");
            }
        }
        static void exo8()
        {
            int[] tab = new int[Convert.ToInt32(Console.ReadLine())];
            int j = 1;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = j*2;
                j = j*2;
            }
            foreach (int k in tab)
            {
                Console.Write(k + " ");
            }
        }
        static void exo9()
        {
            int i = 0;
            while(i<=1 || i >= 6) {
                Console.WriteLine("Saisir un entier compris entre 2 et 5");
                int.TryParse(Console.ReadLine(), out i);
            }
            double[] tab = new double[i];
            for(int j = 0; j < tab.Length; j++)
            {
                tab[j] = Convert.ToDouble(Console.ReadLine());
            }
            double o = 0;
            foreach(int k in tab)
            {
                o = k + o;
                Console.Write(k + " ");
            }
            Console.WriteLine("Moyenne: " + o / tab.Length);
        }
        static void exo10()
        {
            int[] tab = { 1, 23, 45, 6, 7 };
            Console.WriteLine("---");
            for(int i = 0; i < tab.Length; i++)
            {
                if (tab[i] <= 9)
                {
                    Console.WriteLine("|0"+tab[i]+"|");
                } else
                {
                    Console.WriteLine("|" + tab[i] + "|");
                }
                Console.WriteLine("---");

            }
        }
        static void exo11()
        {
            int[] tab = { 1, 23, 45, 6, 7 };
            Console.WriteLine("---------------");
            Console.Write("|");
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] <= 9)
                {
                    Console.Write("0" + tab[i] + "|");
                }
                else
                {
                    Console.Write("" + tab[i] + "|");
                }

            }
            Console.WriteLine("\n---------------");
        }
        static void exo99()
        {
            int[] tab = new int[] { 5, 8, 4, 3 };
            Console.WriteLine(tab);
        }

    }
}
