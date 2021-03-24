using System;

namespace TD_8_MATRICE
{
    class Program
    {
        static void Main(string[] args)
        {
            exo3();
        }
        static void exo1()
        {
            int[] TriTableau(int[] tab)
            {
                if(tab!=null && tab.Length != 0)
                {

                    for (int i = 0; i < tab.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            if (tab[j - 1] > tab[j])
                            {
                                int valeur = tab[j - 1];
                                tab[j - 1] = tab[j];
                                tab[j] = valeur;
                            }
                        }
                    }

                }
                return tab;
            }

            int[] tab = { 1, 2, 3, 4, 6, 5, 9, 4, 2, 7, 13, 22, 3 };
            tab = TriTableau(tab);
            foreach(int i in tab)
            {
                Console.Write(i + ";");
            }
        }
        static void exo2()
        {
            int[] Melange(int[] tab)
            {
                if (tab != null & tab.Length != 0)
                {
                    Random random = new Random();
                    while(random.Next(0,100)!=3)
                    {
                        int aleat1 = random.Next(0, tab.Length);
                        int aleat2 = random.Next(0, tab.Length);
                        int a = tab[aleat1];
                        int b = tab[aleat2];

                        tab[aleat1] = b;
                        tab[aleat2] = a;
                    }

                }
                return tab;
            }

            int[] tab = { 1, 2, 3, 4, 6, 5, 9, 4, 2, 7, 13, 22, 3 };
            tab = Melange(tab);
            foreach(int i in tab)
            {
                Console.Write(i + ";");
            }
        }
        static void exo3()
        {
            int[] TriSelect(int[] tab)
            {
                if (tab != null & tab.Length != 0)
                {
                    int little;
                    int compteur = 0;
                    for(int i = 0; i < tab.Length; i++)
                    {
                        little = tab[i];
                        for(int j = i; j < tab.Length; j++)
                        {
                            if (tab[j] < little)
                            {
                                little = tab[j];
                                tab[j] = tab[compteur];
                                tab[compteur] = little;

                            }
                        }
                        compteur++;
                    }
                }
                return tab;
            }

            int[] tab = { 1, 2, 3, 4, 6, 5, 9, -3, 2, 7, 13, 22, 3 };
            tab = TriSelect(tab);
            foreach(int i in tab)
            {
                Console.Write(i + ";");
            }
        }
    }
}
