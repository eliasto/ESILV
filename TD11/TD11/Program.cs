using System;

namespace TD11
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void exo1()
        {
            Console.WriteLine("Ecrire 1. pour méthode for ou 2. pour méthode while");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    for(int j = 1; j<= 5; j++)
                    {
                        Console.WriteLine("Ca tourne");
                    }
                    break;
                case 2:
                    int i = 1;
                    while (i <= 5)
                    {
                        i++;
                        Console.WriteLine("Ca tourne");
                    }
                    break;
                default:
                    exo1();
                    break;
            }
        }
        static void exo2et3()
        {
            Console.WriteLine(SurfCarre(Convert.ToInt32(Console.ReadLine())));
            static int SurfCarre(int cote)
            {
                return cote*cote;
            }
        }
        static void exo4()
        {
            Console.WriteLine(SurfaceCercle(Convert.ToDouble(Console.ReadLine())));
            double SurfaceCercle(double r)
            {
                return Math.PI * r * r;
            }
        }
        static void exo5()
        {
            Console.WriteLine(Surface(Convert.ToDouble(Console.ReadLine())));
            double Surface(double r)
            {
                return Math.Sqrt(r);
            }
        }
        static void exo6()
        {
            double CoucouLesLoulous(double n)
            {
                return Math.Sqrt(Math.PI * n * n);
            }

            double CoucouLesDoudous(double i)
            {
                return Math.Sqrt((i*i)/Math.PI);
            }
            

        }
        static void exo7()
        {
           bool isPositive(double n)
            {
                if (n > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
        static void exo8()
        {
            bool isPositive(double n)
            {
                if (n > 0)
                {
                    Console.WriteLine("true");
                    return true;
                }
                else
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
            for (int i = -10; i<=10;i++) {
                isPositive(i);
            }
        }
        static void exo9()
        {
            int Max2(int value1, int value2)
            {
                return((value1 + value2 + Math.Abs(value1 - value2)) / 2);
            }
        }
        static void exo10()
        {
            int Max3(int value1, int value2, int value3)
            {
                return Math.Max(Math.Max(value1, value2), value3);
            }

        }
        static void exo12()
        {
            int Abs(int value)
            {
                return Math.Abs(value);
            }
        }
        static void exo13()
        {
            string posNeg(int a, int b)
            {
                if(a>0 && b > 0)
                {
                    return "+1";
                }
                if((a>0 && b<0) || (a<0 && b > 0))
                {
                    return "-1";
                }
                return "0";
            }
        }
        static void exo14()
        {
            int moyenne(int a, int b)
            {
                return (a + b) / 2;
            }
        }
        static void exo15()
        {
            int factorielle(int n)
            {
                int a = 1;
               for(int i = 1; i <= n; i++)
                {
                    a = a * i;
                }
                return a;
            }
        }
        static void exo16()
        {

            double Puissance2(double nombre1, double nombre2)
            {
                double a = 1;
                for(int i = 1; i <= nombre2; i++)
                {
                    a = nombre1 * a;
                }
                return a;
            }

            double Puissance(double nombre1, double nombre2)
            {
                return Math.Pow(nombre1,nombre2);
            }



        }
    }
}
