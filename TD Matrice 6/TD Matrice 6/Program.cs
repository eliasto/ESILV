using System;

namespace TD_Matrice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            exo7();
        }
        static void AfficherMatrice(int[,] matrice)
        {
            if (matrice == null)
            {
                Console.WriteLine("Matrice null");
            }
            else
            {
                if (matrice.Length == 0)
                {
                    Console.WriteLine("Matrice vide");
                }
                else
                {
                    if (matrice != null & matrice.Length != 0)
                    {
                        for (int i = 0; i < matrice.GetLength(0); i++)
                        {
                            Console.WriteLine("");
                            for (int j = 0; j < matrice.GetLength(1); j++)
                            {
                                Console.Write(matrice[i, j] + " ");
                            }
                        }
                    }
                }
            }
            
        }
        static void AfficherTableau(double[] tab)
        {
            if (tab != null)
            {
                int compteur = 0;
                if (tab == null)
                {
                    Console.WriteLine("tableau null");
                    return;
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


        static void exo1()
        {
            int[] Rechercher(int[,] matrice, int valeur)
            {
                int[] tab = new int[2];
                if(matrice != null && matrice.Length != 0)
                {
                    for (int i = 0; i < matrice.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrice.GetLength(1); j++)
                        {
                            if(matrice[i,j] == valeur)
                            {
                                tab[0] = i+1;
                                tab[1] = j+1;
                            }
                        }
                    }
                    return tab;

                }
                else
                {
                    return null;
                }
            }
            int[,] matrice = null;
            int[] tab = Rechercher(matrice, 11);
            foreach(int i in tab)
            {
                Console.Write(i + " ");
            }

        }
        static void exo2()
        {
            int[] PositionMinimum(int[,] matrice)
            {
                int valeur = matrice[0, 0];
                int[] tab = { 1, 1 };
                if (matrice != null && matrice.Length != 0)
                {
                    for (int i = 0; i < matrice.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrice.GetLength(1); j++)
                        {
                            if (matrice[i, j] < valeur)
                            {
                                tab[0] = i + 1;
                                tab[1] = j + 1;
                                valeur = matrice[i, j];
                            }
                        }
                    }
                    return tab;

                }
                else
                {
                    return null;
                }
            }
            int[,] matrice = {{ 1, 2, 3, 4 },{ 5,-6,7,8},{ 9,10,11,12} };
            int[] tab = PositionMinimum(matrice);
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }

        }
        static void exo3()
        {
            bool AjouterValeur(int[,] matrice, int valeur)
            {
                if(matrice!=null && matrice.Length != 0)
                {
                    for (int i = 0; i < matrice.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrice.GetLength(1); j++)
                        {
                            matrice[i, j] = matrice[i, j] + valeur;
                        }
                    }
                    AfficherMatrice(matrice);
                    return true;
                } else
                {
                    return false;
                }
            }
            int[,] matrice = { { 1, 2, 3, 4 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 } };
            Console.WriteLine("Entrez le nombre à ajouter.");
            Console.WriteLine("\nEtat de l'ajout: " + AjouterValeur(matrice, Convert.ToInt32(Console.ReadLine())));
        }
        static void exo4()
        {
            int[,] AdditionnerMatrices(int[,] matrice1, int[,] matrice2)
            {
                if(matrice1 !=null&&matrice2!=null&&matrice1.GetLength(1) !=0&&matrice1.GetLength(0)!=0&&matrice1.GetLength(1) == matrice2.GetLength(1) && matrice1.GetLength(0) == matrice2.GetLength(0))
                {
                    int[,]matrice = new int[matrice1.GetLength(0), matrice1.GetLength(1)];
                    for(int i = 0; i < matrice1.GetLength(0); i++)
                    {
                        for(int j = 0; j < matrice1.GetLength(1); j++)
                        {
                            matrice[i, j] = matrice2[i, j] + matrice1[i, j];
                        }
                    }
                    return matrice;
                } else
                {
                    return null;
                }

            }
            int[,] matrice2 = { { 1, 2, 3, 4 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] matrice1 = { { 1, 2, 3, 4 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 } };

            AfficherMatrice(AdditionnerMatrices(matrice1, matrice2));

        }
        static void exo5()
        {
            double[] calcul_moyenne_matiere(int[,] matrice)
            {
                double[] tab = new double[matrice.GetLength(1)];
                if (matrice != null && matrice.Length != 0)
                {
                    for(int i = 0; i < matrice.GetLength(1); i++)
                    {
                        double compteur = 0;
                        for(int j = 0; j < matrice.GetLength(0); j++)
                        {
                            compteur = compteur + matrice[j, i];
                        }
                        tab[i] = compteur / matrice.GetLength(0);
                    }
                    return tab;
                } else
                {
                    return null;
                }
            }
            int[,] matrice = { { 1, 2, 3, 4 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 } };
            AfficherTableau(calcul_moyenne_matiere(matrice));

        }
        static void exo6()
        {
            int[,] MatriceTransposee(int[,] matrice)
            {
                if (matrice != null && matrice.Length != 0 && matrice.GetLength(0) == matrice.GetLength(1))
                {
                    int[,] mat = new int[matrice.GetLength(0), matrice.GetLength(1)];

                    for(int i = 0; i < matrice.GetLength(0); i++)
                    {
                        for(int j = 0; j < matrice.GetLength(1); j++)
                        {
                            mat[i, j] = matrice[j, i];
                        }
                    }
                    return mat;
                }
                else
                {
                    return null;
                }
            }
            int[,] matrice = { { 1, 2, 3, 4 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 },{ 2, 5, 7, 1 } };
            AfficherMatrice(MatriceTransposee(matrice));
        }
        static void exo7()
        {
            int[,] ProduitMatriciel(int[,]m1,int[,]m2)
            {
                if (m1 != null && m1.Length != 0 &&m2!=null&&m2.Length!=0)
                {
                    int[,] matrice = new int[m1.GetLength(0), m1.GetLength(1)];
                    for(int i = 0; i < m1.GetLength(0); i++)
                    {
                        for(int j = 0; j < m1.GetLength(1); j++)
                        {

                        }
                    }
                    return matrice;
                }else
                {
                    return null;
                }
                }
            int[,] m2 = { { 9, 10, 11, 12 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] m1 = { { 5, -6, 7, 8 }, { 5, -6, 7, 8 }, { 9, 10, 11, 12 } };
            AfficherMatrice(ProduitMatriciel(m1, m2));
        }

    }
}
