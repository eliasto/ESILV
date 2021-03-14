using System;
using System.Collections.Generic;

namespace TD12
{
    class Program
    {
        static void Main(string[] args)
        {
            exo111();
        }

        static void exo111()
        {
            string mot = Console.ReadLine();
            char letter = Convert.ToChar(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < mot.Length; i++)
            {
                char letter1 = mot[i];
                if (letter1 == letter){
                    count++;
                }
            }
            Console.WriteLine("Il existe " + count + " occurrences de la lettre " + letter + " dans le mot " + mot + "");
        }

        static void exo0()
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    Console.WriteLine("zéro");
                    break;
                case 1:
                    Console.WriteLine("un");
                    break;
                case 2:
                    Console.WriteLine("deux");
                    break;
                case 3:
                    Console.WriteLine("trois");
                    break;
                case 4:
                    Console.WriteLine("quatre");
                    break;
                case 5:
                    Console.WriteLine("cinq");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("sept");
                    break;
                case 8:
                    Console.WriteLine("huit");
                    break;
                case 9:
                    Console.WriteLine("neuf");
                    break;
                default:
                    Console.WriteLine("Veuillez écrire un chiffre entre 0 et 9.");
                    break;

            }
        }
        static void exo1()
        {
             bool estPremier(int value)
            {
                int o = 0;
                for (int i = 2; i <= value/2; i++)
                {
                    if (value % i == 0)
                    {
                        o = 1;
                    }
                }
                if (o == 0) {
                    return true;
                   } else
                {
                    return false;
                }
                }

            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i+": "+estPremier(i));
            }
        }
        static void exo2et3()
        {
            bool estPremier(int value)
            {
                int o = 0;
                for (int i = 2; i <= value / 2; i++)
                {
                    if (value % i == 0)
                    {
                        o = 1;
                    }
                }
                if (o == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            List<int> nbrePremier(int a, int b)
            {
                List<int> PrimeNumber = new List<int>();

                for(int i = a; i <= b; i++)
                {
                    if (estPremier(i) == true)
                    {
                        PrimeNumber.Add(i); 
                    }
                }
                return PrimeNumber;
            }

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            List<int> prime = nbrePremier(a, b);

            Console.WriteLine("Il y a "+prime.Count +" nombres premiers.");
            for(int i = 1; i< prime.Count; i++)
            {
                Console.WriteLine(prime[i]);
            }

        }
        static void exo4()
        {
            double arrondi(double a)
            {
                return ((a * 100)-(a*100)%1)/100;
            }
            Console.WriteLine(arrondi(Convert.ToDouble(Console.ReadLine())));
        }
        static void exo5()
        {
            double arrondi(double a)
            {
                double b = ( (a%1)*100 ) % 10;

                if (b > 5)
                {
                    return (((a * 100) - (a * 100) % 1) / 100)+0.01;
                } else
                {
                    return ((a * 100) - (a * 100) % 1) / 100;
                }

            }
            Console.WriteLine(arrondi(Convert.ToDouble(Console.ReadLine())));

        }
        static void exo6()
        {

        }
        static void exo7()
        {
            void triangle(int a)
            {
                for(int i = 1; i <= a; i++)
                {
                    for(int o = 1; o<=i; o++)
                    {
                        Console.Write(o + " ");
                    }
                    Console.WriteLine("");
                }
            }
            triangle(Convert.ToInt32(Console.ReadLine()));
        }
        static void exo8()
        {
            Console.WriteLine("Veuillez écrire le coefficient a, b et c de l'équation ax²+bx+c");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("Pas de solution sur R");
            } else
            {
                if (d == 0)
                {
                    Console.WriteLine("Une solution: " + -b / 2*a);
                } else
                {
                    Console.WriteLine("Deux solutions: " + (-b + Math.Sqrt(d)) / 2 * a +" et "+ (-b - Math.Sqrt(d)) / 2 * a);
                }
            }

        }
        static void exo9()
        {
            Random generateurAlea = new Random();
            int nombreAleatoire = generateurAlea.Next(0,100);

            int c = 5;

            Console.WriteLine("Trouvez le nombre secret entre 0 et 100 en 5 coups !");

            for(int i = 1; i <= c; i++)
            {
                Console.WriteLine("Entrez votre essai. (Essai #"+i+")");

                int a = Convert.ToInt32(Console.ReadLine());
                if (a != nombreAleatoire) {
                    if (a > nombreAleatoire)
                    {
                        Console.WriteLine("Votre nombre ("+a+") est supérieur au nombre secret.");
                    } else
                    {
                        Console.WriteLine("Votre nombre (" + a + ") est inférieur au nombre secret.");

                    }
                } else
                {
                    Console.WriteLine("Trouvé !");
                    break;
                }
            }
            Console.WriteLine("Partie terminé, la réponse était " + nombreAleatoire + ".");
        }
        static void exo10()
        {
            string word = Console.ReadLine();
            for(int i = 0; i < word.Length; i++)
            {
                Console.Write(word[word.Length-1-i]);
            }
        }
        static void exo11()
        {
            void carre(int a)
            {
                for(int i = 1; i <= a; i++)
                {
                    for (int o = 1; o <= a; o++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                
            }
            carre(6);
        }
        static void exo12()
        {
            void carre(int a)
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int o = 1; o <= i; o++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

            }
            carre(8);
        }
        static void exo13()
        {
            void FabString(int a, char c)
            {
                for(int i =1; i <= a; i++)
                {
                    Console.Write(c);
                }
            }
            FabString(5, '*');
        }
    }
    }

