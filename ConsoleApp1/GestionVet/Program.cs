namespace Veterinaire;

class Program
{

    string[,] data = new string[10, 7];

    public static void Main(string[] a)
    {
        Program p = new Program();
        p.GestionVet();
    }
    void GestionVet()
    {
        string ligne = new string('-', 70);
        string choix;
        bool afficheMenu = true;
        while (afficheMenu)
        {
            Console.Clear();
            Console.WriteLine("GestionVet beta");
            Console.WriteLine("1. Ajouter animal");
            Console.WriteLine("2. Liste des animaux");
            Console.WriteLine("3. Liste des propriétaires");
            Console.WriteLine("4. Nombre total d'animaux");
            Console.WriteLine("5. Poids total");
            Console.WriteLine("6. Lister selon la couleur");
            Console.WriteLine("7. Retirer un animal");
            Console.WriteLine("8. Quiter");
            Console.Write("Entrez votre choix: ");
            choix = Console.ReadLine();

            Menu(choix);
        }
    }

    void Menu(string choix)
    {

        switch (choix)
        {
            case "1":
                AjouterAnimal();
                break;
            case "2":
                ListerAni();
                break;
            case "3":
                ListerProp();
                break;
            case "4":
                NombreAni();
                break;
            case "5":
                PoidsAni();
                break;
            case "6":
                ListerCoul();
                break;
            case "7":
                RetirerAni();
                break;
            case "8":
                Quitter();
                break;
        }

    }

    void AjouterAnimal()
    {
        Console.Clear();

        for (int i = 0; i < 10; i++)
        {
            if (data[i, 0] == null)
            {
                data[i, 0] = (Convert.ToString(i));

                Console.WriteLine("Veuillez saisir le type d'animal: ");
                data[i, 1] = Console.ReadLine();
                Console.WriteLine("Veuillez saisir le nom de l'animal: ");
                data[i, 2] = Console.ReadLine();
                Console.WriteLine("Veuillez saisir l'âge de l'animal: ");
                data[i, 3] = Console.ReadLine();
                Console.WriteLine("Veuillez saisir le poids de l'animal: ");
                data[i, 4] = Console.ReadLine();
                Console.WriteLine("Veuillez saisir la couleur de l'animal.");
                string coul = Console.ReadLine();
                if (coul == "rouge")
                {
                    data[i, 5] = "rouge";
                }
                else if (coul == "bleu")
                {
                    data[i, 5] = "bleu";
                }
                else if (coul == "violet")
                {
                    data[i, 5] = "violet";
                }
                else
                {
                    Console.WriteLine("Vous pouvez seulement entrer rouge, bleu ou violet");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Veuillez saisir le nom du propriétaire de l'animal: ");
                data[i, 6] = Console.ReadLine();
                break;
            }

        }
        return;
    }


    void ListerAni()
    {
        Console.Clear();
        string ligne = new string('-', 70);
        Console.WriteLine(ligne);
        Console.WriteLine("ID " + "|" + "TYPE ANIMAL" + "|" + "  NOM   " + "|" + " AGE " + "|" + " POIDS " + "|" + "COULEUR" + "|" + "PROPRIÉTAIRE" + "|");
        Console.WriteLine(ligne);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (data[i, 0] != null)
            {
                Console.Write(string.Format("{0,-5} | {1,-10} | {2,-10} | {3, 5} | {4,5} | {5,-10} | {6,-10} \r\n", data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6]));

            }
        }
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }


    void ListerProp()
    {
        Console.Clear();
        string ligne = new string('-', 70);
        Console.WriteLine(ligne);
        Console.WriteLine("|" + "PROPRIÉTAIRE" + "|");
        Console.WriteLine(ligne);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (data[i, 0] != null)
            {
                Console.Write(string.Format("{0,-5}  \r\n", data[i, 6]));
            }
        }
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }

    void NombreAni()
    {
        int nbAni = 0;
        Console.Clear();
        string ligne = new string('-', 70);
        Console.WriteLine(ligne);
        Console.WriteLine("|" + "  NOMBRE ANIMAUX  " + "|");
        Console.WriteLine(ligne);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (data[i, 2] != null)
            {
                nbAni = nbAni + 1;
            }
        }
        Console.WriteLine(nbAni);
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }


    void PoidsAni()
    {
        int poidsAni = 0;
        Console.Clear();
        string ligne = new string('-', 70);
        Console.WriteLine(ligne);
        Console.WriteLine("|" + "  POIDS TOTAL  " + "|");
        Console.WriteLine(ligne);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            poidsAni = (poidsAni + Convert.ToInt32(data[i, 4]));
        }
        Console.WriteLine(poidsAni);
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }


    void ListerCoul()
    {
        Console.Clear();
        Console.WriteLine("VEUILLEZ SAISIR LA COULEUR DE RECHERCHE");
        string coulutil = Console.ReadLine();
        string ligne = new string('-', 70);
        Console.WriteLine(ligne);
        Console.WriteLine("ID " + "|" + "TYPE ANIMAL" + "|" + "  NOM   " + "|" + "COULEUR" + "|");
        Console.WriteLine(ligne);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (coulutil == data[i, 5])
            {

                Console.Write(string.Format("{0,-5} | {1,-5} | {2,-10} | {3, 5} \r\n", data[i, 0], data[i, 1], data[i, 2], data[i, 5]));
            }
        }
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }


    void RetirerAni()
    {
        Console.Clear();
        Console.WriteLine("VEUILLEZ SAISIR LE ID DE L'ANIMAL");
        string delnum = Console.ReadLine();
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (Convert.ToInt32(delnum) == i)
            {
                data[i, 0] = null;
                data[i, 1] = null;
                data[i, 2] = null;
                data[i, 3] = null;
                data[i, 4] = null;
                data[i, 5] = null;
                data[i, 6] = null;
                break;
            }

        }
        string ligne = new string('-', 70);
        Console.WriteLine(ligne);
        Console.WriteLine("ID " + "|" + "TYPE ANIMAL" + "|" + "  NOM   " + "|" + " AGE " + "|" + " POIDS " + "|" + "COULEUR" + "|" + "PROPRIÉTAIRE" + "|");
        Console.WriteLine(ligne);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            Console.Write(string.Format("{0,-5} | {1,-10} | {2,-10} | {3, 5} | {4,5} | {5,-10} | {6,-10} \r\n", data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6]));
        }

        Console.WriteLine("Appuyez sur une touche pour continuer");
        Console.ReadKey();
    }


    void Quitter()
    {
        Environment.Exit(0);

    }
}
