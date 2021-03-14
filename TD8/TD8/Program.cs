using System;

namespace TD8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lancer quel programme ?:\n1: Factoriel\n2: PGCD\n3: Premier\n4: Division euclidienne");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1: 
                    factoriel();
                    break;
                case 2:
                    euclide();
                    break;
                case 3:
                    premier();
                    break;
                case 4:
                    euclidienne();
                    break;
                default:
                    Console.WriteLine("Vous n'avez pas entré de nombre compris entre 1 et 3.");
                    break;
            }
            

        }

        static void factoriel()
        {
            Console.WriteLine("Saisir un nombre: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = i * f;
            }
            Console.WriteLine("Le factoriel de " + n + " est: " + f + ".");


        }

        static void euclide()
        {
            Console.WriteLine("Saisir deux nombres: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine("Le PGCD est " + a+".");

        }

        static void premier()
        {
            int j = 0;
            Console.WriteLine("Ecrire un nombre :");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    j = j + 1;
                }
            }
            if (j == 1)
            {
                Console.WriteLine("Nombre premier.");
            }
            else
            {
                Console.WriteLine("Nombre pas premier.");
            }
        }

        static void euclidienne()
        {
            Console.WriteLine("Ecrire deux nombres: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quotient: "+ Math.DivRem(a, b, out int r) + " et reste: "+r);
            //ou alors on sait que r=a-q*b avec q le quotient qu'on obtient avec Math.Floor((double) a/b)
            // (double) nécessaire pour passer les deux int en double pour utiliser cette fonction.

        }

    }
}
