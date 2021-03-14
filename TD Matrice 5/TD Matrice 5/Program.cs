using System;

namespace TD_Matrice_5
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
            if (matrice.Length == 0)
            {
                Console.WriteLine("Matrice vide");
            }
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
        static void AfficherMatrice2(int[,] matrice)
        {
            if (matrice == null)
            {
                Console.WriteLine("Matrice null");
            }
            if (matrice.Length == 0)
            {
                Console.WriteLine("Matrice vide");
            }
            if (matrice != null & matrice.Length != 0)
            {
                //affichage nombre dessus
                Console.WriteLine("");
                Console.Write("  ");
                for(int nb = 0; nb < matrice.GetLength(1); nb++)
                {
                    if (nb < 9)
                    {
                        Console.Write("  " + (nb+1) + "");
                    } else
                    {
                        Console.Write(" " + (nb+1) + "");
                    }
                }
                //affichage trait
                Console.WriteLine("");
                Console.Write("X");
                for(int l = 0; l <= matrice.GetLength(0); l++)
                {
                    Console.Write("---");
                }
                Console.Write("--");

                //
                for (int i = 0; i < matrice.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    Console.Write(i + 1);
                    for (int j = 0; j < matrice.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(" |");

                        }
                        if (matrice[i, j] < 10)
                        {
                            Console.Write(" "+matrice[i, j] + "|");
                        } else
                        {
                            Console.Write(matrice[i, j] + "|");
                        }
                    }
                }

                //affichage trait
                Console.WriteLine("");
                Console.Write(" ");
                for (int l = 0; l <= matrice.GetLength(0); l++)
                {
                    Console.Write("---");
                }
                Console.Write("--");


            }
        }
        static void AfficherTableau(int[] tab)
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


        static void exo1()
        {
            int[,] matrice2D = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            AfficherMatrice(matrice2D);

        }
        static void exo2()
        {
            int[,] CreerMatriceNombresPairs(int nbLignes, int nbcolonnes)
            {
                int[,] matrice = new int[nbLignes,nbcolonnes];
                int k = 2;
                for(int i = 0; i < nbLignes;i++)
                {
                    for(int j = 0; j < nbcolonnes; j++)
                    {
                        matrice[i, j] = k;
                        k=k+2;
                    }
                }
                return matrice;
            }
            int nbLignes = 3; // valeur pouvant être demandée à l’ utilisateur
            int nbColonnes = 5; // idem
            int[,] matrice = CreerMatriceNombresPairs(nbLignes, nbColonnes);
            AfficherMatrice(matrice);
        }
        static void exo3()
        {
            int[] ExtraireColonne(int[,] matrice, int indexColonne)
            {
                int[] tab = new int[matrice.GetLength(0)];
                if(matrice == null && matrice.GetLength(0) == 0)
                {
                    return null;
                } else
                {
                    for(int i = 0; i < matrice.GetLength(0); i++)
                    {
                        tab[i] = matrice[i, indexColonne];
                    }
                    return tab;
                }
            }
            int[,] matrice = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[] colonne3 = ExtraireColonne(matrice, 2);
            AfficherTableau(colonne3);
        }
        static void exo4()
        {
            void AfficherDiagonale1(int[,] matrice)
            {
                Console.WriteLine("\n");
                int j = 0;
                for(int i = 0; i < matrice.GetLength(0); i++)
                {
                    Console.Write(matrice[i, j] + " ");
                    j++;
                }
            }
            void AfficherDiagonale2(int[,] matrice)
            {
                int j = matrice.GetLength(1)-1;
                Console.WriteLine("\n");
                for (int i = 0; i < matrice.GetLength(0); i++)
                {
                    Console.Write(matrice[i, j] + " ");
                    j--;
                }
            }

            int[,] matrice = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            AfficherDiagonale1(matrice);
            AfficherDiagonale2(matrice);
        }
        static void exo5()
        {
            int[,] TableMultiplication(int nombreMax, int multiplicateurMax)
            {
                int[,] matrice = new int[nombreMax, multiplicateurMax];
                for(int i = 0; i < multiplicateurMax; i++)
                {
                    matrice[0, i] = i+1;
                }
                for(int j = 0; j < nombreMax; j++)
                {
                    matrice[j, 0] = j + 1;
                }
                for(int k = 1; k < nombreMax; k++)
                {
                    for(int v = 1; v < multiplicateurMax; v++)
                    {
                        matrice[k, v] = matrice[0, v] * matrice[k, 0];
                    }
                }
                return matrice;
            }
            int[,] multiplication = TableMultiplication(9, 10);
            AfficherMatrice2(multiplication);
        }
        static void exo6()
        {
            int[][] CreerTableau2DNombresPairs(int nbLignes, int nbColonnes)
            {
                int k = 2;
                int[][] tab = new int[nbLignes][];
                for(int o = 0; o < nbLignes; o++)
                {
                    tab[o] = new int[nbColonnes];
                }
                for(int i = 0; i < nbLignes; i++)
                {
                    for(int j = 0; j < nbColonnes; j++)
                    {
                        tab[i][j] = k;
                        k=k+2;
                    }
                }
                return tab;
            }
            void AfficherTableau2D(int[][] tab)
            {
                for(int i = 0; i < tab.Length; i++)
                {
                    for(int j = 0; j < tab[i].Length; j++)
                    {
                        Console.Write(tab[i][j] + " ");
                    }
                    Console.WriteLine("");
                }
            }
            int nbLignes = 3;
            int nbColonnes = 5;
            int[][] tab2D = CreerTableau2DNombresPairs(nbLignes, nbColonnes);
            AfficherTableau2D(tab2D);

        }
        static void exo7()
        {
            int[] ExtraireLigne(int[,] matrice, int indexLigne)
            {
                int[] tab = new int[matrice.GetLength(1)];
                for(int i = 0; i < matrice.GetLength(1); i++)
                {
                    tab[i] = matrice[indexLigne, i];
                }
                return tab;
            }
            int[,] matrice = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[] ligne2 = ExtraireLigne(matrice, 1);
            AfficherTableau(ligne2);

        }
    }
}
