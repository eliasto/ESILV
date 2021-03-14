using System;
using System.Collections.Generic;


namespace TD_2_ALGO_TAB
{
    class Program
    {
        static void Main(string[] args)
        {
            exo7();
        }

        static void exo1()
        {
            bool Palindrome(string mot) {
                int[] tab = new int[mot.Length];
                int j = 0;
                for(int i = 0; i < tab.Length; i++)
                {
                    tab[i] = mot[i];
                }
              
                   for(int k = 0; k < tab.Length/2; k++)
                    {
                        if(tab[k] != mot[mot.Length - k-1])
                        {
                            j++;
                        }
                    }
                if (j != 0)
                {
                    return false;
                } else
                {
                    return true;
                }

            }

            Console.WriteLine(Palindrome(Console.ReadLine()));
        }
        static void exo2()
        {
            void AfficherTableau(int[] tab)
            {
                int compteur = 0;
               if(tab == null)
                {
                    Console.WriteLine("tableau null");
                }
               foreach(int k in tab)
                {
                    compteur = k + compteur;
                }
               if(compteur == 0)
                {
                    Console.WriteLine("tableau vide");
                }
               if(compteur !=0 && tab != null)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (i == tab.Length - 1)
                        {
                            Console.Write(tab[i] + "");
                        }
                        else
                        {
                            Console.Write(tab[i] + "; ");
                        }
                    }
                }


            }
            int[] tab = { 1, 23, 45, 6, 7, 89 };

            AfficherTableau(tab);
        }
        static void exo3()
        {
            int[] tab1 = { 1, 23, 45, 6 };
            int[] tab2 = { 7, 89, 17 };

            int[] ConcatenerTableaux(int[] tableau1, int[] tableau2)
            {
                int[] tab = new int[tableau1.Length + tableau2.Length];
                if(tableau1 !=null && tableau2 != null)
                {
                    for(int i = 0; i < tableau1.Length; i++)
                    {
                        tab[i] = tableau1[i];
                    }
                    for(int i = 0; i < tableau2.Length; i++)
                    {
                        tab[i + tableau1.Length] = tableau2[i];
                    }
                    return tab;
                } else
                {
                    return null;
                }
            }
            void AfficherTableau(int[] tab)
            {
                int compteur = 0;
                if (tab == null)
                {
                    Console.WriteLine("tableau null");
                }
                foreach (int k in tab)
                {
                    compteur = k + compteur;
                }
                if (compteur == 0)
                {
                    Console.WriteLine("tableau vide");
                }
                if (compteur != 0 && tab != null)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (i == tab.Length - 1)
                        {
                            Console.Write(tab[i] + "");
                        }
                        else
                        {
                            Console.Write(tab[i] + "; ");
                        }
                    }
                }


            }

            AfficherTableau(ConcatenerTableaux(tab1, tab2));
        }
        static void exo4()
        {
            void AfficherTableau(int[] tab)
            {
                int compteur = 0;
                if (tab == null)
                {
                    Console.WriteLine("tableau null");
                }
                foreach (int k in tab)
                {
                    compteur = k + compteur;
                }
                if (compteur == 0)
                {
                    Console.WriteLine("tableau vide");
                }
                if (compteur != 0 && tab != null)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (i == tab.Length - 1)
                        {
                            Console.Write(tab[i] + "");
                        }
                        else
                        {
                            Console.Write(tab[i] + "; ");
                        }
                    }
                }


            }

            int[] NouveauTableauInverse(int[] tableau)
            {
                int[] tab = new int[tableau.Length];
                for(int i = 0; i < tableau.Length; i++)
                {
                    tab[tab.Length - i - 1] = tableau[i];
                }
                return tab;
            }
            int[] tab = { 1, 23, 45, 6, 7, 89 };
            int[] tab2 = NouveauTableauInverse(tab);
            AfficherTableau(tab2);
        }
        static void exo5()
        {
            void AfficherTableau(int[] tab)
            {
                int compteur = 0;
                if (tab == null)
                {
                    Console.WriteLine("tableau null");
                }
                foreach (int k in tab)
                {
                    compteur = k + compteur;
                }
                if (compteur == 0)
                {
                    Console.WriteLine("tableau vide");
                }
                if (compteur != 0 && tab != null)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (i == tab.Length - 1)
                        {
                            Console.Write(tab[i] + "");
                        }
                        else
                        {
                            Console.Write(tab[i] + "; ");
                        }
                    }
                }


            }
            int[] InverserTableau(int[] tableau)
            {
                int[] tab = new int[tableau.Length];
                for (int i = 0; i < tableau.Length; i++)
                {
                    tab[tab.Length - i - 1] = tableau[i];
                }
                return tab;
            }

            int[] tab = { 1, 23, 45, 6, 7, 89 };
            AfficherTableau(tab);
            Console.WriteLine("\n");
            tab = InverserTableau(tab);
            AfficherTableau(tab); 
        }
        static void exo6()
        {
            int[] tab = { 5, 8, 3, 2, 6, 4 };
            void AfficherEnTriangle(int[] tableau)
            {
                for(int i = 0; i <= tab.Length; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write(tab[j] + " ");
                    }

                    Console.WriteLine("");
                }
            }

            AfficherEnTriangle(tab);
        }
        static void exo7()
        {
            void AfficherTableau(int[] tab)
            {
                int compteur = 0;
                if (tab == null)
                {
                    Console.WriteLine("tableau null");
                }
                foreach (int k in tab)
                {
                    compteur = k + compteur;
                }
                if (compteur == 0)
                {
                    Console.WriteLine("tableau vide");
                }
                if (compteur != 0 && tab != null)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (i == tab.Length - 1)
                        {
                            Console.Write(tab[i] + "");
                        }
                        else
                        {
                            Console.Write(tab[i] + "; ");
                        }
                    }
                }


            }
            int[] AgrandirTableau(int[] tab, int i, int k)
            {
                int[] tab1 = new int[i+tab.Length];
                for(int l = 0; l < tab.Length; l++)
                {
                    tab1[l] = tab[l];
                }
                for(int o = tab.Length; o < tab1.Length; o++)
                {
                    tab1[o] = k;
                }
                return tab1;
            }

            int[] tab = { 1, 23, 45, 6, 7 };
            tab = AgrandirTableau(tab, 3, 10);
            AfficherTableau(tab);
        }
    }
}
