using System;

namespace TD_7_Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            exo3();
        }
        static void exo1()
        {
            bool Permuter(int[] tableau, int index1, int index2)
            {
                bool boolean = false;
                if (tableau != null && tableau.Length != 0 && tableau.Length-1 >= index1 && tableau.Length-1 >= index2 && !(index1>tableau.Length-1) && !(index2>tableau.Length-1))
                {
                    boolean = true;
                    int a = tableau[index1];
                    int b = tableau[index2];

                    tableau[index1] = b;
                    tableau[index2] = a;
                }
                foreach (int i in tableau)
                {
                    Console.Write(i+"; ");
                }

                return boolean;
            }

            int[] tab = new int[] { 1, 2, 3 };
            Console.WriteLine(Permuter(tab,1,2));
            
        }
        static void exo2()
        {
            int[] tab = { 3, 1, 10, 4, 56, 4, 3,29 };
            int[] TriBulles(int[] tab)
            {
                if(tab!=null && tab.Length != 0)
                {
                    int compteur = 1;
                    while (compteur != 0)
                    {
                        compteur = 0;
                        for (int i = 0; i < tab.Length-1; i++)
                        {
                            if (tab[i] > tab[i + 1])
                            {
                                compteur++;
                                int a = tab[i];
                                int b = tab[i + 1];

                                tab[i] = b;
                                tab[i + 1] = a;
                            }
                        }
                       
                    }
                }

                return tab;
            }

            Console.WriteLine("");
            foreach(int i in tab)
            {
                Console.Write(i + ";");
            }
            Console.WriteLine("");

            foreach (int i in TriBulles(tab))
            {
                Console.Write(i + ";");
            }

        }
        static void exo3()
        {
            int[] tab = { 3, 1, 10, 4, 56, 4, 3, 29 };
            int[] TriBulles(int[] tab)
            {
                if (tab != null && tab.Length != 0)
                {
                    
                    int compteur = 1;
                    int etat = 0;
                    while (compteur != 0)
                    {
                       
                        compteur = 0;
                        if(etat == 0)
                        {
                            etat++;
                            for (int i = 0; i < tab.Length - 1; i++)
                            {
                                if (tab[i] > tab[i + 1])
                                {
                                    compteur++;
                                    int a = tab[i];
                                    int b = tab[i + 1];

                                    tab[i] = b;
                                    tab[i + 1] = a;
                                }
                            }
                        } else
                        {
                            etat = 0;
                            for (int i = 1; i < tab.Length; i++)
                            {
                                if (tab[i] < tab[i - 1])
                                {
                                    compteur++;
                                    int a = tab[i];
                                    int b = tab[i - 1];

                                    tab[i] = b;
                                    tab[i - 1] = a;
                                }
                            }
                        }

                    }
                }

                return tab;
            }

            Console.WriteLine("");
            foreach (int i in tab)
            {
                Console.Write(i + ";");
            }
            Console.WriteLine("");

            foreach (int i in TriBulles(tab))
            {
                Console.Write(i + ";");
            }
        }
    }
}
