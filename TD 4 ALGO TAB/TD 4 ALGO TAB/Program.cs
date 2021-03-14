using System;

namespace TD_4_ALGO_TAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                BIENVENUE A CE JEU DE NIM !");
            Console.WriteLine(" ");
            Console.WriteLine("Règles: \nCe jeu très simple se joue à deux.");
            Console.WriteLine("On dispose des paquets d'allumettes sur une table. Chaque\njoueur, à tour de rôle, prend le nombre d'allumettes \nqu'il veut (au moins une) dans un des paquets. \nLe gagnant est celui qui prend la dernière allumette.");
            Console.WriteLine(" ");
            Console.WriteLine("Appuyez sur n'importe quelle touche pour commencer.");
            Console.WriteLine("-------------------------------------------------------------");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Combien d'allumettes voulez-vous utiliser ?");

            int allumettes = Convert.ToInt32(Console.ReadLine());

            while (allumettes < 1)
            {
                Console.WriteLine("Il faut au moins 1 allumette.");
                allumettes = Convert.ToInt32(Console.ReadLine());
            }

            bool[] CreerTasAllumettes(int taille)
            {
                bool[] tab = new bool[taille];
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = true;
                }
                return tab;
            }
            void AfficherTasAlumettes(bool[] tasAlumettes)
            {
                int longueur = tasAlumettes.Length;
                for (int i = 1; i < longueur; i++)
                {
                    Console.Write(" " + i + " |");
                }
                Console.Write(" " + longueur + " ");
                Console.WriteLine("");
                for (int i = 1; i <= longueur; i++)
                {
                    if (i >= 10)
                    {
                        Console.Write("-----");
                    }
                    else
                    {
                        Console.Write("----");
                    }
                }
                Console.WriteLine("");
                for (int i = 0; i < longueur - 1; i++)
                {
                    if (i >= 10)
                    {
                        if (tasAlumettes[i] == true)
                        {
                            Console.Write("  * |");
                        }
                        else
                        {
                            Console.Write("    |");
                        }
                    }
                    else
                    {
                        if (tasAlumettes[i] == true)
                        {
                            Console.Write(" * |");
                        }
                        else
                        {
                            Console.Write("   |");
                        }
                    }
                }
                //fin allumettes
                if (tasAlumettes.Length >= 10)
                {
                    if (tasAlumettes[longueur - 1] == true)
                    {
                        Console.Write(" *  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                else
                {
                    if (tasAlumettes[longueur - 1] == true)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                //
                Console.WriteLine("");
                for (int i = 1; i <= longueur; i++)
                {
                    if (i >= 10)
                    {
                        Console.Write("-----");
                    }
                    else
                    {
                        Console.Write("----");
                    }
                }
                Console.WriteLine("");

            }
            bool PositionValide(bool[] tableau, int index)
            {
                if (tableau != null && tableau.Length != 0 && index >= 0 && tableau.Length > index)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            bool RetirerUneAllumette(bool[] tasAllumettes, int index)
            {
                if (PositionValide(tasAllumettes, index) == true)
                {
                    tasAllumettes[index] = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            int NombreAllumettesRestantes(bool[] tasAllumettes)
            {
                if (tasAllumettes != null && tasAllumettes.Length != 0)
                {
                    int compteur = 0;
                    foreach (bool i in tasAllumettes)
                    {
                        if (i == true)
                        {
                            compteur++;
                        }
                    }
                    return compteur;
                }
                else
                {
                    return 0;
                }
            }
            int DemanderNombreAllumettesARetirer(int max)
            {
                Console.WriteLine("Combien d'allumettes voulez-vous retirer (1-" + max + ") ?");
                int choix = Convert.ToInt32(Console.ReadLine());
                while (choix > max || choix < 1)
                {
                    Console.WriteLine("Combien d'allumettes voulez-vous retirer (1-" + max + ") ?");
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                return choix;

            }
            bool PartieGagnee(bool[] tasAllumettes)
            {
                if (tasAllumettes == null || tasAllumettes.Length == 0)
                {
                    return false;
                }
                else
                {
                    if (NombreAllumettesRestantes(tasAllumettes) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            bool PartiePerdue(bool[] tasAllumettes)
            {
                if (tasAllumettes == null || tasAllumettes.Length == 0)
                {
                    return true;
                }
                else
                {
                    if (NombreAllumettesRestantes(tasAllumettes) == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            bool FinPartie(bool[] tasAllumettes)
            {
                if (PartiePerdue(tasAllumettes) == true || PartieGagnee(tasAllumettes) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool[] allumettesTab = CreerTasAllumettes(allumettes);

            int noJoueur = 0;
            Console.Clear();
            AfficherTasAlumettes(allumettesTab);

            int allumettesRetire;
            int allumettesRestantes;
            while (!FinPartie(allumettesTab))
            {
                noJoueur = (noJoueur % 2) + 1;
                Console.WriteLine("C'est au tour du joueur n°" + noJoueur);
                Console.WriteLine(" ");
                allumettesRetire = DemanderNombreAllumettesARetirer(3);
                allumettesRestantes = NombreAllumettesRestantes(allumettesTab);
                for (int i = 1; i <=allumettesRetire; i++)
                {
                    allumettesTab[allumettesRestantes - i] = false;
                }
                Console.Clear();
                AfficherTasAlumettes(allumettesTab);
            }
            Console.Clear();
            Console.WriteLine("");
            Console.Write("Le joueur " + noJoueur + " a ");
            if (PartieGagnee(allumettesTab))
            {
                Console.Write("gagné !");
            } else
            {
                Console.Write("perdu.");
            }

        }
        static void exo1()
        {
            bool[] CreerTasAllumettes(int taille)
            {
                bool[] tab = new bool[taille];
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = true;
                }
                return tab;
            }

            void AfficherTasAlumettes(bool[] tasAlumettes)
            {
                int longueur = tasAlumettes.Length;
                for (int i = 1; i < longueur; i++)
                {
                    Console.Write(" " + i + " |");
                }
                Console.Write(" " + longueur + " ");
                Console.WriteLine("");
                for (int i = 1; i <= longueur; i++)
                {
                    if (i >= 10)
                    {
                        Console.Write("-----");
                    }
                    else
                    {
                        Console.Write("----");
                    }
                }
                Console.WriteLine("");
                for (int i = 0; i < longueur - 1; i++)
                {
                    if (i >= 10)
                    {
                        if (tasAlumettes[i] == true)
                        {
                            Console.Write("  * |");
                        }
                        else
                        {
                            Console.Write("    |");
                        }
                    }
                    else
                    {
                        if (tasAlumettes[i] == true)
                        {
                            Console.Write(" * |");
                        }
                        else
                        {
                            Console.Write("   |");
                        }
                    }
                }
                //fin allumettes
                if (tasAlumettes.Length >= 10)
                {
                    if (tasAlumettes[longueur - 1] == true)
                    {
                        Console.Write(" *  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                else
                {
                    if (tasAlumettes[longueur - 1] == true)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                //
                Console.WriteLine("");
                for (int i = 1; i <= longueur; i++)
                {
                    if (i >= 10)
                    {
                        Console.Write("-----");
                    }
                    else
                    {
                        Console.Write("----");
                    }
                }

            }

            bool[] allumettes = CreerTasAllumettes(11);
            allumettes[1] = false;
            allumettes[10] = true;

            AfficherTasAlumettes(allumettes);

        }
        static void exo2()
        {
            bool[] allumettes = new bool[10];
            allumettes[0] = true;

            bool PositionValide(bool[] tableau, int index)
            {
                if(tableau != null && tableau.Length!=0 && index>=0 && tableau.Length > index)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            bool RetirerUneAllumette(bool[] tasAllumettes, int index)
            {
                if(PositionValide(tasAllumettes,index) == true)
                {
                    tasAllumettes[index] = false;
                    return true;
                } else
                {
                    return false;
                }
            }
            int NombreAllumettesRestantes(bool[] tasAllumettes)
            {
                if(tasAllumettes != null && tasAllumettes.Length != 0)
                {
                    int compteur = 0;
                    foreach (bool i in tasAllumettes)
                    {
                        if (i == true)
                        {
                            compteur++;
                        }
                    }
                    return compteur;
                } else
                {
                    return 0;
                }
            }

            Console.WriteLine(RetirerUneAllumette(allumettes, 10));
        }
        static void exo3()
        {
            int NombreAllumettesRestantes(bool[] tasAllumettes)
            {
                if (tasAllumettes != null && tasAllumettes.Length != 0)
                {
                    int compteur = 0;
                    foreach (bool i in tasAllumettes)
                    {
                        if (i == true)
                        {
                            compteur++;
                        }
                    }
                    return compteur;
                }
                else
                {
                    return 0;
                }
            }

            int DemanderNombreAllumettesARetirer(int max)
            {
                Console.WriteLine("Combien d'allumettes voulez-vous retirer (1-"+max+") ?");
                int choix = Convert.ToInt32(Console.ReadLine());
                while (choix > max || choix<1) {
                    Console.WriteLine("Combien d'allumettes voulez-vous retirer (1-"+max+") ?");
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                return choix;

            }
            bool PartieGagnee(bool[] tasAllumettes)
            {
                if(tasAllumettes == null || tasAllumettes.Length == 0)
                {
                    return false;
                } else
                {
                    if (NombreAllumettesRestantes(tasAllumettes) == 1)
                    {
                        return true;
                    } else
                    {
                        return false;

                    }
                }
            }
            bool PartiePerdue(bool[] tasAllumettes)
            {
                if (tasAllumettes == null || tasAllumettes.Length == 0)
                {
                    return true;
                }
                else
                {
                    if (NombreAllumettesRestantes(tasAllumettes) == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            bool FinPartie(bool[] tasAllumettes){
                if(PartiePerdue(tasAllumettes) == true || PartieGagnee(tasAllumettes) == true)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            bool[] tab = new bool[2];
            tab[0] = true;
            tab[1] = true;
            Console.WriteLine(FinPartie(tab));
        }
    }
}
