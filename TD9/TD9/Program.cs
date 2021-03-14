using System;

namespace TD9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Veuillez rentrer le numéro de l'exercice (de 1 à 13)"); 
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    exo1();
                    break;
                case 2:
                    exo2();
                    break;
                case 3:
                    exo3();
                    break;
                case 4:
                    exo4();
                    break;
                case 5:
                    exo5();
                    break;
                case 6:
                    exo6();
                    break;
                case 7:
                    exo7();
                    break;
                case 8:
                    exo8();
                    break;
                case 9:
                    exo9();
                    break;
                case 10:
                    exo10();
                    break;
                case 11:
                    exo11();
                    break;
                case 12:
                    exo12();
                    break;
                case 13:
                    exo13();
                    break;
                case 14:
                    special();
                    break;
                default:
                    Console.WriteLine("Exercice inconnue.");
                    Main(args);
                    break;
            }//switch qui lance les exos correspondants. 
        }

        static void exo1()
        {
            Console.WriteLine("Merci d'écrire votre âge");
            string age = Console.ReadLine();
            int.TryParse(age, out int finalAge); //convertis la variable *string* en *int* ssi *string* comporte qu'un nombre, sinon finalAge=0
            if (finalAge <= 0)
            {
                Console.WriteLine("Votre âge n'est pas correct.");
                return;
            }
            if (finalAge < 25) // 0 < finalAge < 25
            {
                Console.WriteLine("Salut gamin");
            } else if(finalAge < 55) // 25 < finalAge < 55
            {
                Console.WriteLine("Bonjour monsieur.");
            } else // 55 < finalAge
            {
                Console.WriteLine("Je te vénère, Oh mon grand maitre !");
            }
        }
        static void exo2()
        {
            Console.WriteLine("Votre poids (en kg)");
            string kg = Console.ReadLine();
            float.TryParse(kg, out float finalKg);

            Console.WriteLine("Votre taille (en cm)");
            string cm = Console.ReadLine();
            float.TryParse(cm, out float finalCm);

            float IMC = finalKg/((finalCm/100)*(finalCm/100)); //Calcul de l'IMC (taille en m^2, c'est pourquoi on divise par
                                                               //d'abord par 100 pour cm -> m puis on double pour avoir m^2

            if (IMC <= 0) //soit le TryParse n'a pas fonctionné donc la valeur = 0, soit les valeurs rentrés sont <= 0 ce qui est impossible pour un calcul d'imc
            {
                Console.WriteLine("Les valeurs que vous avez rentré sont incorrect.");
                return;
            }
            if (IMC < 19) // 0 < IMC < 19
            {
                Console.WriteLine("Vous êtes maigre");
            }
            else if (IMC < 25)// 19 < IMC < 25
            {
                Console.WriteLine("Vous êtes sans intérêt.");
            }
            else // 25 < IMC
            {
                Console.WriteLine("Vous êtes gros.");
            }

        }
        static void exo3()
        {
            Console.WriteLine("Entrez deux nombres.");

            string x = Console.ReadLine();
            float.TryParse(x, out float a);

            string y = Console.ReadLine();
            float.TryParse(y, out float b);

            if (a > b)
            {
                Console.WriteLine(a + ">" + b);
            }else
            {
                Console.WriteLine(b + ">" + a);
            }
        }
        static void exo4()
        {
            Console.WriteLine("Entrer un nombre");
            string x = Console.ReadLine();
            float.TryParse(x, out float n);

            Console.WriteLine("Valeur absolu de " + n + " = " + Math.Abs(n)); //La fonction Math regorge de pleins d'options dont
                                                                              // Math.Abs(int) qui fait la valeur absolue d'un int.
        }
        static void exo5()
        {
            Console.WriteLine("Côté du carré:");
            string a = Console.ReadLine();
            float.TryParse(a, out float n);

            if (n < 0)
            {
                Console.WriteLine("nop");
                return;
            } else
            {
                Console.WriteLine("Surface du carré: " + n*n);
            }

        }
        static void exo6()
        {
            Console.WriteLine("Longueur du rectangle:");
            string a = Console.ReadLine();
            float.TryParse(a, out float n);

            Console.WriteLine("Largeur du rectangle:");
            string b = Console.ReadLine();
            float.TryParse(b, out float i);

            if (n < 0 || i < 0)
            {
                Console.WriteLine("nop");
                return;
            }
            else
            {
                Console.WriteLine("Surface du rectangle: " + n*i);
            }

        }
        static void exo7()
        {
            Console.WriteLine("Rayon du cercle:");
            string a = Console.ReadLine();
            float.TryParse(a, out float n);

            if (n < 0)
            {
                Console.WriteLine("nop");
                return;
            }
            else
            {
                Console.WriteLine("Surface du cercle: " + Math.PI*n*n); //Pour avoir PI on utilise Math.PI ou on écrit 3.14
            }

        }
        static void exo8()
        {
            Console.WriteLine("Rayon du cercle:");
            string a = Console.ReadLine();
            float.TryParse(a, out float n);

            if (n < 0)
            {
                Console.WriteLine("nop");
                return;
            }
            else
            {
                double surfaceCercle = Math.PI * n * n;
                Console.WriteLine("Côté d'un carré de même surface que d'un cercle de rayon " + n + " = " + Math.Sqrt(surfaceCercle)); //Math.Sqrt(int) pour faire la racine carré
            }

        }
        static void exo9()
        {
            int val1 = 1;
            int val2 = 2;

            Console.WriteLine("val1 = " + val1 + ". val2 = " + val2 + ".");

            //On aurait pu aussi créer une autre variable tel que *int c;* mais ce code fonctionne aussi (voir ci-dessus).
            val1 = val1 + val2; 
            val2 = val1 - val2;
            val1 = val1 - val2;

            /*
            int c = 0;
            c = val1;
            val1 = val2;
            val2 = c;
             */


            Console.WriteLine("val1 = " + val1 + ". val2 = " + val2 + ".");
        }
        static void exo10()
        {
            Console.WriteLine("Ecrire une syllabe:");
            string word = Console.ReadLine();

            Console.WriteLine(word + word);
        }
        static void exo11()
        {
            string word = "ah";
            string chain = "";

            for(int i = 1; i < 7; i++)
            {
                chain = word + chain;
            }
            Console.WriteLine(chain);
        }
        static void exo12()
        {

            Console.WriteLine("Entrer deux nombres:");

            string a = Console.ReadLine();
            double.TryParse(a, out double n);

            string b = Console.ReadLine();
            double.TryParse(b, out double i);

            if (n < 0 || i < 0 )
            {
                Console.WriteLine("nop");
                return;
            } else
            {
                Console.WriteLine((i + n) / 2);
            }

        }
        static void exo13()
        {
            Console.WriteLine("Saisir température en en degrés celsius.");
            string a = Console.ReadLine();
            float.TryParse(a, out float n);

            Console.WriteLine(a+" en F° donne: "+(32+1.8*n));   
        }
        static void special()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int k = 0;


            if (a > b)
            {
                k = 0;
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 2 == 0)
                    {
                        k = i + k;
                    }
                }
            }

            Console.WriteLine(k);
        }

    }
}
