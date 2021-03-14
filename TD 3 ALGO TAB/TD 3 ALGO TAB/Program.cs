using System;

namespace TD_3_ALGO_TAB
{
    class Program
    {
        static void Main(string[] args)
        {
            exo8();
        }
        static void exo1()
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

            int[] GenererTableauAleatoire(int taille, int valeurMin, int valeurMax) {
                Random aleatoire = new Random();

                int[] tab = new int[taille];
                for(int i = 0; i < tab.Length; i++)
                {
                    tab[i] = aleatoire.Next(1, 100);
                }
                return tab;
            }
            int[] tab = GenererTableauAleatoire(10, 1, 100);
            AfficherTableau(tab); // tableau de 10 entiers entre 1 et 100
        }
        static void exo2()
        {
            int Rechercher(int[] tableau, int valeur)
            {
                int[] tab = tableau;
                int compteur = 0;
                int ok = -1;
                foreach(int i in tab)
                {
                    if(i == valeur)
                    {
                        ok=compteur;
                    }
                    compteur++;
                }
                return ok;

            }

            int[] tab1 = { 1, 23, 45, 6, 7, 89 };
            int[] tab2 = { 1, 23, 45, 6, 7,23, 89 };
            Console.WriteLine(Rechercher(tab2, 23));
        }
        static void exo3()
        {
            void AfficherTableau(int[] tab)
            {
               if(tab != null)
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

            }
            int PositionMaximum(int[] tableau)
            {
                if(tableau == null || tableau.Length == 0)
                {
                    return -1;
                }
                else
                {
                    int o = 0;
                    foreach(int i in tableau)
                    {
                        if (i > o)
                        {
                            o= i;
                        }
                    }
                    return o;
                }
            }

            int[] tab = null;
            AfficherTableau(tab);
            Console.WriteLine("\nLa plus grande valeur est: "+PositionMaximum(tab));
        }
        static void exo4()
        {
            bool EstPresent(int[] tableau, int valeur)
            {
                if(tableau == null || tableau.Length == 0)
                {
                    return false;
                } else
                {
                    int ok = 0;
                    foreach (int i in tableau)
                    {
                        if (i == valeur)
                        {
                            ok++;
                        }
                    }
                    if (ok != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            int[] tableau = { 1, 2, 3, 4,  6 };
            Console.WriteLine(EstPresent(tableau, 5));
        }
        static void exo5()
        {
            int NombreOccurrences(int[] tableau, int valeur)
            {
                if(tableau== null || tableau.Length == 0)
                {
                    return 0;
                } else
                {
                    int compteur = 0;
                    foreach(int i in tableau)
                    {
                        if (i == valeur)
                        {
                            compteur++;
                        }
                    }
                    return compteur;
                }
            }
            int[] tableau = { 5, 2, 3, 5, 6 };
            Console.WriteLine(NombreOccurrences(tableau, 5));

        }
        static void exo6()
        {
            void AfficherTableau(int[] tab)
            {
                if (tab != null)
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

            }

            bool AdditionnerValeur(int[] tableau, int valeur)
            {
                if(tableau == null || tableau.Length == 0)
                {
                    return false;
                } else
                {
                    int[] tab = new int[tableau.Length];
                    for (int i = 0; i < tab.Length; i++)
                    {
                        tab[i] = tableau[i] + valeur;
                    }
                    AfficherTableau(tab);
                    return true;
                }
            }

            int[] tab = { 1, 23, 45, 6, 7, 89 };
            AdditionnerValeur(tab, 10); // valeur retournée non utilisée ici

        }
        static void exo7() {
            int[] AdditionnerTableaux(int[] tableau1, int[] tableau2)
            {
                if(tableau1 == null || tableau2 == null || tableau1.Length != tableau2.Length)
                {
                    return null;
                } else
                {
                    int[] tab = new int[tableau1.Length];
                    for(int i = 0; i < tab.Length; i++)
                    {
                        tab[i] = tableau1[i] + tableau2[i];
                    }
                    return tab;
                }
            }
            void AfficherTableau(int[] tab)
            {
                if (tab != null)
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

            }

            int[] tab1 = { 1, 23, 45, 6, 7, 89 };
            int[] tab2 = { 10, 230, 450, 60, 70, 890 };

            AfficherTableau(AdditionnerTableaux(tab1, tab2));          

        }
        static void exo8()
        {
            int NombreValeursDifferentes(int[] tableau)
            {
                int taille = tableau.Length;
                int compteur = 0;
                int different;

                for(int i = 1; i < taille; i++)
                {
                    Console.WriteLine("Recherche en cours sur " + tableau[i]);
                    different = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (tableau[i] == tableau[j])
                        {
                            different++;
                        }
                    }
                    if(different > 0)
                    {
                        compteur++;
                    }
                }
                return taille-compteur;
            }

            int[] tab1 = { 1, 2, 2, 1, 100, 2};
            Console.WriteLine(NombreValeursDifferentes(tab1));
        }
        static void exo9()
        {
            void AfficherTableau(int[] tab)
            {
                if (tab != null)
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

            }
            int[] Echange(int[] tableau, int indice1, int indice2)
            {
                if(tableau == null || tableau.Length == 0)
                {
                    return null;
                } else
                {
                    int[] tab = new int[tableau.Length];
                    for(int i = 0; i < tableau.Length; i++)
                    {
                        tab[i] = tableau[i];
                            if (tableau[i] == indice1)
                            {
                                tab[i] = indice2;
                            }
                            if (tableau[i] == indice2)
                            {
                                tab[i] = indice1;
                            }
                        
                    }
                    return tab;

                }
            }

            int[] tab1 = { 1, 23, 45, 6, 7, 8 };
            AfficherTableau(Echange(tab1, 23, 8));

        }
    }
}
 