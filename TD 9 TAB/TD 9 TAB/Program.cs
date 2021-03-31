using System;
using System.Collections.Generic;
using System.Linq;

namespace TD_9_TAB
{
    class Program
    {
        static void Main(string[] args)
        {
            exo4();
        }
        static void AfficherListEntiers(List<int> liste)
        {
            if(liste == null)
            {
                Console.WriteLine("Liste null");
            } else
            {
                if(liste.Count == 0)
                {
                    Console.WriteLine("Liste vide");
                } else
                {
                    for(int i = 0; i < liste.Count; i++)
                    {
                        Console.Write(liste[i]);
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
        static void exo2()
        {
            List<int> tab = new List<int>();
            Console.WriteLine("Bonjour ! Veuillez entrer les nombres à rentrer dans votre liste, Dès que c'est terminé, écrivez 'fin'.");
            string valeur = "0";
            while(valeur != "fin")
            {
                try
                {
                    valeur = Console.ReadLine();
                    tab.Add(Convert.ToInt32(valeur));
                } catch
                {
                    Console.WriteLine("Vouliez-vous terminer le programme ? Si oui, écrivez 'fin'");
                }
                
            }

            Console.WriteLine("");
            for(int i = 0; i < tab.Count; i++)
            {
                Console.Write(tab[i] + " ; ");
            }
        }
        static void exo3() {
            int[] tab = new int[] { 3, 5, 1, 2, 7, 2, 8, 5, 2, 4 };

            List<int> liste = new List<int>(tab);
            AfficherListEntiers(liste);

            int indexDe8 = liste.IndexOf(8);
            Console.WriteLine("indexDE8 = " + indexDe8);

            int dernierIndexDE5 = liste.LastIndexOf(5);
            Console.WriteLine("dernierIndexDE5 = " + dernierIndexDE5);

            Console.WriteLine("indexDe42 = "+liste.IndexOf(42) );

            int valeurIndex4 = liste.ElementAt(4);
            Console.WriteLine("valeurIndex4 = " + valeurIndex4);

            int min = liste.Min();
            int max = liste.Max();

            Console.WriteLine("min = " + min + ", max = " + max);

            liste.Reverse();
            AfficherListEntiers(liste);

            liste.Remove(2);
            AfficherListEntiers(liste);

            liste.Sort();
            AfficherListEntiers(liste);

            liste.Clear();
            AfficherListEntiers(liste);

        }
        static void exo4()
        {
             List<List<int>> GenererTrianglePascal (int n)
            {
                List<List<int>> valeurs = new List<List<int>>();
                List<int> valeurInitial = new List<int>();
                valeurInitial.Add(1);

                valeurs.Add(valeurInitial);

                for (int i = 1; i < n; i++)
                {
                    
                    List<int> valeur = new List<int>();
                    valeur.Add(1);

                    for (int j = 0; j <= valeurs[i - 1].Count - 2; j++)
                    {
                        valeur.Add(valeurs[i - 1][j] + valeurs[i - 1][j + 1]);
                    }

                    valeur.Add(1);
                    valeurs.Add(valeur);
                }
                return valeurs;
            }

            Console.WriteLine("Combien de ligne voulez-vous générer ?");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            List<List<int>> list = GenererTrianglePascal(o);

            foreach(List<int> i in list)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
