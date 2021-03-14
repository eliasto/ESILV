using System;

namespace TD10
{
    class Program
    {
        /*
         * TOURNEUX Elias
         * TD C - ESILV PROMO 2025
         */

        static void Main(string[] args)
        {
            /*Console.WriteLine("Entrez le numéro de l'exercice.");
            switch (Convert.ToInt32(Console.ReadLine())){
                case 1:
                    e1();
                    break;
                default:
                    Main(args);
                    break;
            }*/
            e16();
        }

        static void e1()
        {
            int n = 1;
            while (n <= 20)
            {
                Console.WriteLine(n + ": ça tourne");
                n = n + 1;
            }
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + ": ça tourne");
            }
        }
        static void e2()
        {
            for(int i = 10; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void e3()
        {
            for(int i = 10; i <= 20; i++)
            {
                if (i == 20)
                {
                    Console.Write(i);
                } else
                {
                    Console.Write(i + " ; ");

                }
            }
        }
        static void e4()
        {
            for(int i = 20; i <= 40; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        static void e5()
        {
            for (int i = 60; i >= 40; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
        static void e6()
        {
            int somme = 0;
            int n = 0;
            while (somme <= 100)
            {
                Console.WriteLine("Entrer un nombre entier (somme actuelle: "+somme+") ");
                n = Convert.ToInt32(Console.ReadLine());
                somme = somme + n;
            }
            Console.WriteLine("La somme est de: " + somme);
        }
        static void e7()
        {
            int somme = 0;
            int n = 0;
            for (somme = 0; somme <= 100; somme = somme + n)
            {
                Console.Write("Entrez des nombres entiers (somme actuelle: " + somme + ") ");
                n = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("La somme est de : " + somme);

        }
        static void e8()
        {
            int xx = Convert.ToInt32(Console.ReadLine());
            int yy = Convert.ToInt32(Console.ReadLine());
            while (xx == yy || xx >= 99 || xx <= 10 || yy >= 99 || yy <= 10)
            {
                Console.WriteLine("Veuillez entrer deux entiers différents");
                xx = Convert.ToInt32(Console.ReadLine());
                yy = Convert.ToInt32(Console.ReadLine());

            }

            if (xx > yy)
            {
                Console.WriteLine("Le nombre " + xx + " est supérieur à " + yy);
            }
            else
            {
                Console.WriteLine("Le nombre " + yy + " est supérieur à " + xx);
            }

        }

        static void e13()
        {
            string saisi;
            int nombre;
            bool test = true;

            do
            {
                Console.WriteLine("Entrez un nombre si vous souhaitez son carré. Entrez fin pour arrêter le programme");
                saisi = Console.ReadLine();
                if (saisi != "fin")
                {
                    nombre = Convert.ToInt32(saisi);
                    nombre = nombre * nombre;
                    Console.WriteLine("Le carré est " + nombre);
                }
                else
                {
                    test = false;
                }
            }
            while (test == true);
            Console.WriteLine("finn de programme");
        }

        static void e14()
        {
            Console.WriteLine("Saisir deux entiers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir un troisième entier.");
            int s = Convert.ToInt32(Console.ReadLine());

            if (s == a + b)
            {
                Console.WriteLine("gagné");
            } else
            {
                Console.WriteLine("retourne en primaire");
            }

        }
        static void e15()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void e16()
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%3==0 && i%7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void e17()
        {

        }

    }
}
