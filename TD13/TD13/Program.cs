using System;

namespace TD13
{
    class Program
    {
        static void Main(string[] args)
        {
            exo6();
        }

        static void exo1()
        {
            int NombreDeJours(int o)
            {
                switch (o)
                {
                    case 1:
                        return 31;
                        break;
                    case 2:
                        return 28;
                        break;
                    case 3:
                        return 31;
                        break;
                    case 4:
                        return 30;
                        break;
                    case 5:
                        return 31;
                        break;
                    case 6:
                        return 30;
                        break;
                    case 7:
                        return 31;
                        break;
                    case 8:
                        return 31;
                        break;
                    case 9:
                        return 30;
                        break;
                    case 10:
                        return 31;
                        break;
                    case 11:
                        return 30;
                        break;
                    case 12:
                        return 31;
                        break;
                    default:
                        return 0;
                        break;
                }
            }

            bool Anneebissextile(int o)
            {
                if(( (o/4)%1==0 && (o / 100) % 1 != 0) || (o / 400) % 1 == 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }

            int NombreDeJoursAnnee(double annee, int mois)
            {
                if (((annee / 4) % 1 == 0 && (annee / 100) % 1 != 0) || (annee / 400) % 1 == 0)
                {
                    switch (mois)
                    {
                        case 1:
                            return 31;
                            break;
                        case 2:
                            return 29;
                            break;
                        case 3:
                            return 31;
                            break;
                        case 4:
                            return 30;
                            break;
                        case 5:
                            return 31;
                            break;
                        case 6:
                            return 30;
                            break;
                        case 7:
                            return 31;
                            break;
                        case 8:
                            return 31;
                            break;
                        case 9:
                            return 30;
                            break;
                        case 10:
                            return 31;
                            break;
                        case 11:
                            return 30;
                            break;
                        case 12:
                            return 31;
                            break;
                        default:
                            return 0;
                            break;
                    }

                }
                else
                {
                    switch (mois)
                    {
                        case 1:
                            return 31;
                            break;
                        case 2:
                            return 28;
                            break;
                        case 3:
                            return 31;
                            break;
                        case 4:
                            return 30;
                            break;
                        case 5:
                            return 31;
                            break;
                        case 6:
                            return 30;
                            break;
                        case 7:
                            return 31;
                            break;
                        case 8:
                            return 31;
                            break;
                        case 9:
                            return 30;
                            break;
                        case 10:
                            return 31;
                            break;
                        case 11:
                            return 30;
                            break;
                        case 12:
                            return 31;
                            break;
                        default:
                            return 0;
                            break;
                    }

                }
            }

            Console.WriteLine(NombreDeJoursAnnee(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        }
        static void exo2()
        {
            string Gauss(double o, int type)
            {
                if (type == 0)
                {
                    double a = o % 19;
                    double b = o % 4;
                    double c = o % 7;

                    double k = (o - (o % 100)) / 100;
                    double p = ((8 * k + 13) - ((8 * k + 13) % 25)) / 25;
                    double q = (k - (k % 4)) / 4;

                    double M = (15 - p + k - q) % 30;
                    double N = (4 + k - q) % 7;
                    double d = (19 * a + M) % 30;
                    double e = (2 * b + 4 * c + 6 * d + N) % 7;

                    double H = 22 + d + e;
                    double Q = d + e - 9;

                    double day;
                    double month;

                    if (d == 29 && e == 6)
                    {
                        day = 19;
                        month = 4;
                    }
                    if (d == 28 && (((11 * M + 11) % 30) < 19))
                    {
                        day = 18;
                        month = 4;
                    }

                    if (H <= 31)
                    {
                        day = H;
                        month = 3;
                    }
                    else
                    {
                        day = Q;
                        month = 4;
                    }

                    return day + "/" + month;
                } else
                {
                    double a = o % 19;
                    double b = o % 4;
                    double c = o % 7;

                    double M = 15;
                    double N = 6;

                    double d = (19 * a + M) % 30;
                    double e = (2 * b + 4 * c + 6*d + N) % 7;

                    double H = 22 + d + e;
                    double Q = d + e - 9;

                    double day;
                    double month;

                    if (H <= 31)
                    {
                        day = H;
                        month = 3;
                    }
                    else
                    {
                        day = Q;
                        month = 4;
                    }

                    return day + "/" + month;

                }
            }

            string Meeus(double o, int type)
            {
                if (type == 0)
                {
                    if(o >= 1583)
                    {
                        double n = o % 19;
                        double u = o % 100;
                        double c = (o - (o % 100)) / 100;
                        double s = (c - (c % 4)) / 4;
                        double t = c % 4;
                        double p = ((c+8) - ((c+8) % 25)) / 25;
                        double q = ((c - p + 1) - ((c - p + 1) % 3)) / 3;
                        double e = (19* n + c - s - q + 15)% 30;
                        double b = (u - (u % 4)) / 4;
                        double d = u % 4;
                        double L = (2 * t + 2 * b - e - d + 32) % 7;
                        double h = ((n + 11* e + 22 *L) - ((n + 11* e + 22* L   ) % 451)) / 451;
                        double m = ((e + L - 7 * h + 114) - ((e + L - 7 * h + 114) % 31)) / 31;
                        double J = (e + L - 7 * h + 114) % 31;

                        return (J + 1) + "/" + m;



                    } else
                    {
                        return "Impossible de calculer la date";
                    }
                } 
                else
                {
                    if (o >= 326)
                    {
                        double A = o % 19;
                        double B = o % 7;
                        double C = o % 4;

                        double D = (19 * A + 15) % 30;
                        double E = (2 * C + 4 * B - D + 32) % 7;
                        double F = ((D + E+ 114) - ((D + E + 114) % 31)) / 31;
                        double G = (D + E + 114) % 31;

                        return (G + 1) + "/" + F;

                    }
                    else
                    {
                        return "Impossible de calculer la date";

                    }
                }
            }

            string Conway(double o , int type)
            {
                if (type == 0){

                    if(o >= 1583)
                    {
                        double t = o % 100;
                        double s = (o - (o % 100)) / 100;
                        double a = (t - (t % 4)) / 4;
                        double p = s % 4;
                        double jps = (9 - 2 * p) % 7;
                        double jp = (jps + t + a) % 7;
                        double g = o % 19;
                        double G = g + 1;
                        double b = (s - (s % 4)) / 4;
                        double r = ((8*(s+11)) - ((8*(s+11)) % 25)) / 25;
                        double C = -s + b + r;
                        double d = (11 * G + C) % 30;
                        d = (d + 30) % 30;
                        double h = ((551-19*d+G) - ((551-19*d+G) % 544)) / 544;
                        double e = (50 - d - h) % 7;
                        double f = (e + jp) % 7;
                        double R = 57 - d - f - h;



                        if (R <= 31)
                        {
                            return R + "/" + 3;
                        } else
                        {
                            return (R - 31) + "/" + 4;
                        }

                    } else
                    {
                        return "Impossible de calculer cette année";
                    }

                } else
                {
                    return "Impossible de calculer dans le calendrier Julien";
                }
            }

            Console.WriteLine("Veuillez entre l'année pour calcul la date de Pâques.");

            string a = Console.ReadLine();
            int.TryParse(a, out int b);

            Console.WriteLine(Conway(b, 0));

            
        }
        static void exo3()
        {
            Console.WriteLine("Entrez une année pour voir les dates de pâques de cette décénie.");

            string Conway(double o, int type)
            {
                if (type == 0)
                {

                    if (o >= 1583)
                    {
                        double t = o % 100;
                        double s = (o - (o % 100)) / 100;
                        double a = (t - (t % 4)) / 4;
                        double p = s % 4;
                        double jps = (9 - 2 * p) % 7;
                        double jp = (jps + t + a) % 7;
                        double g = o % 19;
                        double G = g + 1;
                        double b = (s - (s % 4)) / 4;
                        double r = ((8 * (s + 11)) - ((8 * (s + 11)) % 25)) / 25;
                        double C = -s + b + r;
                        double d = (11 * G + C) % 30;
                        d = (d + 30) % 30;
                        double h = ((551 - 19 * d + G) - ((551 - 19 * d + G) % 544)) / 544;
                        double e = (50 - d - h) % 7;
                        double f = (e + jp) % 7;
                        double R = 57 - d - f - h;



                        if (R <= 31)
                        {
                            return R + "/" + 3;
                        }
                        else
                        {
                            return (R - 31) + "/" + 4;
                        }

                    }
                    else
                    {
                        return "Impossible de calculer cette année";
                    }

                }
                else
                {
                    return "Impossible de calculer dans le calendrier Julien";
                }
            }

            int annee = Convert.ToInt32(Console.ReadLine());

            int a = annee - (annee % 10);
            int b = annee + (10 - (annee % 10));

            for(int i = a; i <= b; i++)
            {
                Console.WriteLine("Année "+i+" : "+Conway(i, 0));
            }
            

        }
        static void exo4()
        {
            int divergence = 0;


            Console.WriteLine("Entrez la date de début et la date de fin.");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Veuillez entrer la première méthode à vérifier:\n1. Gauss\n2. Meeus\n3.Conway");

            string c = Console.ReadLine();
            int.TryParse(c, out int d);

            switch (d)
            {
                case 1:
                    Console.WriteLine("Veuillez entrer la deuxième méthode à vérifier:\n1. Meeus\n2.Conway");
                    string c1 = Console.ReadLine();
                    int.TryParse(c1, out int d1);
                    switch (d1)
                    {
                        case 1:
                            for (int i = a; i <= b; i++)
                            {
                                if (Gauss(i, 0) != Meeus(i, 0))
                                {
                                    Console.WriteLine("Divergence pour l'année " + i + " ! Méthode de Gauss: " + Gauss(i, 0) + " et Meeus: " + Meeus(i, 0) + "");
                                    divergence++;
                                }
                            }
                            break;
                        case 2:
                            for (int i = a; i <= b; i++)
                            {
                                if (Gauss(i, 0) != Conway(i, 0))
                                {
                                    Console.WriteLine("Divergence pour l'année " + i + " ! Méthode de Gauss: " + Gauss(i, 0) + " et Conway: " + Conway(i, 0) + "");
                                    divergence++;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Erreur, commande non reconnue.");
                            exo4();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Veuillez entrer la deuxième méthode à vérifier:\n1. Gauss\n2.Conway");
                    string c2 = Console.ReadLine();
                    int.TryParse(c2, out int d2);
                    switch (d2)
                    {
                        case 1:
                            for (int i = a; i <= b; i++)
                            {
                                if (Meeus(i, 0) != Gauss(i, 0))
                                {
                                    Console.WriteLine("Divergence pour l'année " + i + " ! Méthode de Meeus: " + Meeus(i, 0) + " et Gauss: " + Gauss(i, 0) + "");
                                    divergence++;
                                }
                            }
                            break;
                        case 2:
                            for (int i = a; i <= b; i++)
                            {
                                if (Meeus(i, 0) != Conway(i, 0))
                                {
                                    Console.WriteLine("Divergence pour l'année " + i + " ! Méthode de Meeus: " + Meeus(i, 0) + " et Conway: " + Conway(i, 0) + "");
                                    divergence++;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Erreur, commande non reconnue.");
                            exo4();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Veuillez entrer la deuxième méthode à vérifier:\n1. Gauss\n2. Meeus");
                    string c3 = Console.ReadLine();
                    int.TryParse(c3, out int d3);
                    switch (d3)
                    {
                        case 1:
                            for (int i = a; i <= b; i++)
                            {
                                if (Conway(i, 0) != Gauss(i, 0))
                                {
                                    Console.WriteLine("Divergence pour l'année " + i + " ! Méthode de Conway: " + Conway(i, 0) + " et Gauss: " + Gauss(i, 0) + "");
                                    divergence++;
                                }
                            }
                            break;
                        case 2:
                            for (int i = a; i <= b; i++)
                            {
                                if (Conway(i, 0) != Meeus(i, 0))
                                {
                                    Console.WriteLine("Divergence pour l'année " + i + " ! Méthode de Conway: " + Conway(i, 0) + " et Meeus: " + Meeus(i, 0) + "");
                                    divergence++;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Erreur, commande non reconnue.");
                            exo4();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Erreur, commande non reconnue.");
                    exo4();
                    break;

            }

            string Conway(double o, int type)
            {
                if (type == 0)
                {

                    if (o >= 1583)
                    {
                        double t = o % 100;
                        double s = (o - (o % 100)) / 100;
                        double a = (t - (t % 4)) / 4;
                        double p = s % 4;
                        double jps = (9 - 2 * p) % 7;
                        double jp = (jps + t + a) % 7;
                        double g = o % 19;
                        double G = g + 1;
                        double b = (s - (s % 4)) / 4;
                        double r = ((8 * (s + 11)) - ((8 * (s + 11)) % 25)) / 25;
                        double C = -s + b + r;
                        double d = (11 * G + C) % 30;
                        d = (d + 30) % 30;
                        double h = ((551 - 19 * d + G) - ((551 - 19 * d + G) % 544)) / 544;
                        double e = (50 - d - h) % 7;
                        double f = (e + jp) % 7;
                        double R = 57 - d - f - h;



                        if (R <= 31)
                        {
                            return R + "/" + 3;
                        }
                        else
                        {
                            return (R - 31) + "/" + 4;
                        }

                    }
                    else
                    {
                        return "Impossible de calculer cette année";
                    }

                }
                else
                {
                    return "Impossible de calculer dans le calendrier Julien";
                }
            }
            string Gauss(double o, int type)
            {
                if (type == 0)
                {
                    double a = o % 19;
                    double b = o % 4;
                    double c = o % 7;

                    double k = (o - (o % 100)) / 100;
                    double p = ((8 * k + 13) - ((8 * k + 13) % 25)) / 25;
                    double q = (k - (k % 4)) / 4;

                    double M = (15 - p + k - q) % 30;
                    double N = (4 + k - q) % 7;
                    double d = (19 * a + M) % 30;
                    double e = (2 * b + 4 * c + 6 * d + N) % 7;

                    double H = 22 + d + e;
                    double Q = d + e - 9;

                    double day;
                    double month;

                    if (H <= 31)
                    {
                        day = H;
                        month = 3;
                    }
                    else
                    {
                        day = Q;
                        month = 4;

                        if ((d == 29) && (e == 6))
                        {
                            day = 19;
                            month = 4;
                        }
                        if (d == 28 && (((11 * M + 11) % 30) < 19) &&(e==6))
                        {
                            day = 18;
                            month = 4;
                        }
                    }

                    return day + "/" + month;
                }
                else
                {
                    double a = o % 19;
                    double b = o % 4;
                    double c = o % 7;

                    double M = 15;
                    double N = 6;

                    double d = (19 * a + M) % 30;
                    double e = (2 * b + 4 * c + 6 * d + N) % 7;

                    double H = 22 + d + e;
                    double Q = d + e - 9;

                    double day;
                    double month;

                    if (H <= 31)
                    {
                        day = H;
                        month = 3;
                    }
                    else
                    {
                        day = Q;
                        month = 4;
                    }

                    return day + "/" + month;

                }
            }
            string Meeus(double o, int type)
            {
                if (type == 0)
                {
                    if (o >= 1583)
                    {
                        double n = o % 19;
                        double u = o % 100;
                        double c = (o - (o % 100)) / 100;
                        double s = (c - (c % 4)) / 4;
                        double t = c % 4;
                        double p = ((c + 8) - ((c + 8) % 25)) / 25;
                        double q = ((c - p + 1) - ((c - p + 1) % 3)) / 3;
                        double e = (19 * n + c - s - q + 15) % 30;
                        double b = (u - (u % 4)) / 4;
                        double d = u % 4;
                        double L = (2 * t + 2 * b - e - d + 32) % 7;
                        double h = ((n + 11 * e + 22 * L) - ((n + 11 * e + 22 * L) % 451)) / 451;
                        double m = ((e + L - 7 * h + 114) - ((e + L - 7 * h + 114) % 31)) / 31;
                        double J = (e + L - 7 * h + 114) % 31;

                        return (J + 1) + "/" + m;



                    }
                    else
                    {
                        return "Impossible de calculer la date";
                    }
                }
                else
                {
                    if (o >= 326)
                    {
                        double A = o % 19;
                        double B = o % 7;
                        double C = o % 4;

                        double D = (19 * A + 15) % 30;
                        double E = (2 * C + 4 * B - D + 32) % 7;
                        double F = ((D + E + 114) - ((D + E + 114) % 31)) / 31;
                        double G = (D + E + 114) % 31;

                        return (G + 1) + "/" + F;

                    }
                    else
                    {
                        return "Impossible de calculer la date";

                    }
                }
            }

            Console.WriteLine("Il y a eu " + divergence + " divergences entre les années "+a+" et "+b+".");
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur 1. pour retourner au menu principal ou n'importe quelle touche pour quitter le programme.");
string textetaper = Console.ReadLine(); Int32.TryParse(textetaper, out int resultat); if(resultat ==1)
            {
                Console.Clear();
                exo6();
            }


        }
        static void exo5()
        {
            double Conway(double o, int type)
            {
                if (type == 0)
                {

                    if (o >= 1583)
                    {
                        double t = o % 100;
                        double s = (o - (o % 100)) / 100;
                        double a = (t - (t % 4)) / 4;
                        double p = s % 4;
                        double jps = (9 - 2 * p) % 7;
                        double jp = (jps + t + a) % 7;
                        double g = o % 19;
                        double G = g + 1;
                        double b = (s - (s % 4)) / 4;
                        double r = ((8 * (s + 11)) - ((8 * (s + 11)) % 25)) / 25;
                        double C = -s + b + r;
                        double d = (11 * G + C) % 30;
                        d = (d + 30) % 30;
                        double h = ((551 - 19 * d + G) - ((551 - 19 * d + G) % 544)) / 544;
                        double e = (50 - d - h) % 7;
                        double f = (e + jp) % 7;
                        double R = 57 - d - f - h;



                        return R;

                    }
                    else
                    {
                        return 0;
                    }

                }
                else
                {
                    return 0;
                }
            }

            string Fete(double o)
            {
                if (o >= 0)
                {

                    if (o <= 31)
                    {
                        return o + "/" + 1;
                    }
                    else
                    {
                        if (Anneebissextile(o) == true)
                        {
                            if (o <= 60)
                            {
                                return o - 31 + "/" + 2;
                            }
                            else
                            {
                                if (o <= 91)
                                {
                                    return o - 60 + "/" + 3;
                                }
                                else
                                {
                                    if (o <= 121)
                                    {
                                        return o - 91 + "/" + 4;
                                    }
                                    else
                                    {
                                        if (o <= 152)
                                        {
                                            return o - 121 + "/" + 5;
                                        }
                                        else
                                        {
                                            if (o <= 183)
                                            {
                                                return o - 152 + "/" + 6;
                                            }
                                            else
                                            {
                                                return o - 183 + "/" + 7;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (o <= 59)
                            {
                                return o - 31 + "/" + 2;
                            }
                            else
                            {
                                if (o <= 90)
                                {
                                    return o - 59 + "/" + 3;
                                }
                                else
                                {
                                    if (o <= 120)
                                    {
                                        return o - 90 + "/" + 4;
                                    }
                                    else
                                    {
                                        if (o <= 151)
                                        {
                                            return o - 120 + "/" + 5;
                                        }
                                        else
                                        {
                                            if (o <= 182)
                                            {
                                                return o - 151 + "/" + 6;
                                            }
                                            else
                                            {
                                                return o - 182 + "/" + 7;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else
                {
                    return (31 + o) + "/" + 12;
                }
            }

            bool Anneebissextile(double o)
            {
                if (((o / 4) % 1 == 0 && (o / 100) % 1 != 0) || (o / 400) % 1 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("Entrez une année pour avoir les dates mobiles.");

            int o = Convert.ToInt32(Console.ReadLine());
            if (o <= 33)
            {
                Console.Clear();
                Console.WriteLine("Impossible, pâques n'existait pas avant cette date.");
                exo5();
            }
            bool bi = Anneebissextile(o);
            double paque = Conway(o, 0);
            int jour;
            if(bi == true)
            {
                jour = 60;
            }
            else
            {
                jour = 59;
            }

            Console.WriteLine("Triodion: " + Fete(((jour + paque) - 70)));
            Console.WriteLine("Septuagésime: " + Fete(((jour + paque) - 63)));
            Console.WriteLine("Samedi des âmes: " + Fete(((jour + paque) - 57)));
            Console.WriteLine("Sexagésime: " + Fete(((jour +paque)-56)));
            Console.WriteLine("Quinquagésime: " + Fete(((jour +paque)-49)));
            Console.WriteLine("Lundi Gras: " + Fete(((jour +paque)-48)));
            Console.WriteLine("Mardi Gras: " + Fete(((jour +paque)-47)));
            Console.WriteLine("Mercredi des Cendres: " + Fete(((jour +paque)-46)));
            Console.WriteLine("Dimanche de l'Orthodoxie: " + Fete(((jour +paque)-42)));
            Console.WriteLine("People's Sunday: " + Fete(((jour +paque)-41)));
            Console.WriteLine("Mothering Sunday: " + Fete(((jour +paque)-21)));
            Console.WriteLine("Dimanche de la Passion: " + Fete(((jour +paque)-14)));
            Console.WriteLine("Samedi de Lazare: " + Fete(((jour +paque)-8)));
            Console.WriteLine("Dimanche des Rameaux: " + Fete(((jour +paque)-7)));
            Console.WriteLine("Jeudi saint: " + Fete(((jour +paque)-3)));
            Console.WriteLine("Vendredi saint: " + Fete(((jour +paque)-2)));
            Console.WriteLine("Samedi saint: " + Fete(((jour +paque)-1)));
            Console.WriteLine("Pâques: " + Fete(((jour +paque)-0)));
            Console.WriteLine("Fête de la saint Grégoire: " + Fete(((jour +paque)+3)));
            Console.WriteLine("Quasimodo: " + Fete(((jour +paque)+7)));
            Console.WriteLine("Radonitsa: " + Fete(((jour + paque) + 8)));
            Console.WriteLine("Ascension: " + Fete(((jour + paque) + 39)));
            Console.WriteLine("Pentecôte: " + Fete(((jour + paque) + 49)));
            Console.WriteLine("Lundi de Pentecôte: " + Fete(((jour + paque) + 50)));
            Console.WriteLine("Fête de la SAinte Trinité: " + Fete(((jour + paque) + 56)));
            Console.WriteLine("Toussaint: " + Fete(((jour + paque) + 56)));
            Console.WriteLine("Fête-Dieu: " + Fete(((jour + paque) + 60)));
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur 1. pour retourner au menu principal ou n'importe quelle touche pour quitter le programme.");
            string textetaper = Console.ReadLine(); Int32.TryParse(textetaper, out int resultat); if (resultat == 1)
            {
                Console.Clear();
                exo6();
            } else
            {
                quitter();
            }
        }
        static void exo6()
        {
            int restart = 0;

            Console.WriteLine("Bonjour, veuillez sélectionner votre choix (1-5):");
            Console.WriteLine("\n1. Voir la date de pâques par l'une par les méthodes proposées\n2. Date de Paque pour la décennie\n3. Date des fêtes mobiles\n4. Contrôle de la validité des trois algorithmes\n5. Quitter.");
            string a = Console.ReadLine();
            int.TryParse(a, out int b);
            while(restart == 0)
            {
                switch (b)
                {

                    case 34567:
                        exo2();
                        break;
                    case 1:
                        Console.WriteLine("Voulez-vous tester la méthode de:\n1. Gauss\n2. Meeus\n3. Conway");
                        string c = Console.ReadLine();
                        int.TryParse(c, out int d);
                        Console.Clear();
                        calcul(d);
                        break;
                    case 2:
                        exo3();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        exo5();
                        break;
                    case 4:
                        Console.Clear();
                        exo4();
                        break;
                    case 5:
                        restart = 1;
                        break;
                    default:
                        Console.WriteLine("Commande non reconnue.");
                        exo6();
                        break;
                }
            }
        }
        static void calcul(int o)
        {
            string Gauss(double o, int type)
            {
                if (type == 0)
                {
                    double a = o % 19;
                    double b = o % 4;
                    double c = o % 7;

                    double k = (o - (o % 100)) / 100;
                    double p = ((8 * k + 13) - ((8 * k + 13) % 25)) / 25;
                    double q = (k - (k % 4)) / 4;

                    double M = (15 - p + k - q) % 30;
                    double N = (4 + k - q) % 7;
                    double d = (19 * a + M) % 30;
                    double e = (2 * b + 4 * c + 6 * d + N) % 7;

                    double H = 22 + d + e;
                    double Q = d + e - 9;

                    double day;
                    double month;

                    if (d == 29 && e == 6)
                    {
                        day = 19;
                        month = 4;
                    }
                    if (d == 28 && (((11 * M + 11) % 30) < 19))
                    {
                        day = 18;
                        month = 4;
                    }

                    if (H <= 31)
                    {
                        day = H;
                        month = 3;
                    }
                    else
                    {
                        day = Q;
                        month = 4;
                    }

                    return day + "/" + month;
                }
                else
                {
                    double a = o % 19;
                    double b = o % 4;
                    double c = o % 7;

                    double M = 15;
                    double N = 6;

                    double d = (19 * a + M) % 30;
                    double e = (2 * b + 4 * c + 6 * d + N) % 7;

                    double H = 22 + d + e;
                    double Q = d + e - 9;

                    double day;
                    double month;

                    if (H <= 31)
                    {
                        day = H;
                        month = 3;
                    }
                    else
                    {
                        day = Q;
                        month = 4;
                    }

                    return day + "/" + month;

                }
            }

            string Meeus(double o, int type)
            {
                if (type == 0)
                {
                    if (o >= 1583)
                    {
                        double n = o % 19;
                        double u = o % 100;
                        double c = (o - (o % 100)) / 100;
                        double s = (c - (c % 4)) / 4;
                        double t = c % 4;
                        double p = ((c + 8) - ((c + 8) % 25)) / 25;
                        double q = ((c - p + 1) - ((c - p + 1) % 3)) / 3;
                        double e = (19 * n + c - s - q + 15) % 30;
                        double b = (u - (u % 4)) / 4;
                        double d = u % 4;
                        double L = (2 * t + 2 * b - e - d + 32) % 7;
                        double h = ((n + 11 * e + 22 * L) - ((n + 11 * e + 22 * L) % 451)) / 451;
                        double m = ((e + L - 7 * h + 114) - ((e + L - 7 * h + 114) % 31)) / 31;
                        double J = (e + L - 7 * h + 114) % 31;

                        return (J + 1) + "/" + m;



                    }
                    else
                    {
                        return "Impossible de calculer la date";
                    }
                }
                else
                {
                    if (o >= 326)
                    {
                        double A = o % 19;
                        double B = o % 7;
                        double C = o % 4;

                        double D = (19 * A + 15) % 30;
                        double E = (2 * C + 4 * B - D + 32) % 7;
                        double F = ((D + E + 114) - ((D + E + 114) % 31)) / 31;
                        double G = (D + E + 114) % 31;

                        return (G + 1) + "/" + F;

                    }
                    else
                    {
                        return "Impossible de calculer la date";

                    }
                }
            }

            string Conway(double o, int type)
            {
                if (type == 0)
                {

                    if (o >= 1583)
                    {
                        double t = o % 100;
                        double s = (o - (o % 100)) / 100;
                        double a = (t - (t % 4)) / 4;
                        double p = s % 4;
                        double jps = (9 - 2 * p) % 7;
                        double jp = (jps + t + a) % 7;
                        double g = o % 19;
                        double G = g + 1;
                        double b = (s - (s % 4)) / 4;
                        double r = ((8 * (s + 11)) - ((8 * (s + 11)) % 25)) / 25;
                        double C = -s + b + r;
                        double d = (11 * G + C) % 30;
                        d = (d + 30) % 30;
                        double h = ((551 - 19 * d + G) - ((551 - 19 * d + G) % 544)) / 544;
                        double e = (50 - d - h) % 7;
                        double f = (e + jp) % 7;
                        double R = 57 - d - f - h;



                        if (R <= 31)
                        {
                            return R + "/" + 3;
                        }
                        else
                        {
                            return (R - 31) + "/" + 4;
                        }

                    }
                    else
                    {
                        return "Impossible de calculer cette année";
                    }

                }
                else
                {
                    return "Impossible de calculer dans le calendrier Julien";
                }
            }
            int valeur = o;

            switch (o)
            {
                case 1:
                    Console.WriteLine("Veuillez entre l'année pour calcul la date de Pâques.");

                    string a = Console.ReadLine();
                    int.TryParse(a, out int b);

                    if (b <= 33)
                    {
                        Console.WriteLine("Erreur, pâques n'existait pas avant l'an 33.");
                        calcul(valeur);
                    }

                    Console.WriteLine("La date de pâques l'année " + b + " est le: " + Gauss(b, 0));

                    break;
                case 2:
                    Console.WriteLine("Veuillez entre l'année pour calcul la date de Pâques.");

                    string a1 = Console.ReadLine();
                    int.TryParse(a1, out int b1);

                    if (b1 <= 33)
                    {
                        Console.WriteLine("Erreur, pâques n'existait pas avant l'an 33.");
                        calcul(valeur);
                    }

                    Console.WriteLine("La date de pâques l'année " + b1 + " est le: " + Meeus(b1, 0));

                    break;
                case 3:
                    Console.WriteLine("Veuillez entre l'année pour calcul la date de Pâques.");

                    string a2 = Console.ReadLine();
                    int.TryParse(a2, out int b2);

                    if (b2 <= 33)
                    {
                        Console.WriteLine("Erreur, pâques n'existait pas avant l'an 33.");
                        calcul(valeur);
                    }

                    Console.WriteLine("La date de pâques l'année "+b2+" est le: "+Conway(b2, 0));

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Commande non reconnue.");
                    exo6();
                    break;

            }

            Console.WriteLine("");
            Console.WriteLine("Appuyez sur 1. pour retourner au menu principal ou n'importe quelle touche pour quitter le programme.");
string textetaper = Console.ReadLine(); Int32.TryParse(textetaper, out int resultat); if(resultat ==1)
            {
                Console.Clear();
                exo6();
            }
        }
        static void quitter() { }
    }
}
