using System;

namespace le_juste_prix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modifier l'onglet 
            Console.Title = "le_juste_prix";

            // Personnaliser la bannière du nom du jeu
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Nom du jeu : 'Le jeu du Juste Prix'");

            // Personnaliser la bannière du but
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Le but du jeu est de trouver le prix de chaque objet !");

            // Personnaliser la bannière des règles
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Règles sont simple:");
            Console.WriteLine("Tous les prix sont entre 1 et 100 euros !");
            Console.WriteLine("Vous pouvez donner autant de valeur possible pour trouver");
            Console.WriteLine("Tous les prix sont des nombres entiers");

            // Encouragement
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bonne chance à tous");

            // Début du jeu
            // Déclaration du prix de la boite magnifique en int
            // Déclaration du prix en entier en random entre 1 à 100
            Random rand = new Random();
            int prix1 = rand.Next(1,101);
            //Console.WriteLine(prix1);
            int nombreDeTentatives = 0;

            // Boucle pour permettre plusieurs tentatives
            while (true)
            {
                // Déclaration de la variable de réception de la saisie opérateur
                Console.WriteLine("Le prix de la boite magnifique est de : ");
                string nb = Console.ReadLine();

                // Incrémenter le nombre de tentatives ici on peut le mettre ici, si on veut compter tous les coups
                // sinon, on met nombreDetentatives++ dans le try
                //nombreDeTentatives++;

                // Attention, le type prix et nb sont différents, il faudra caster nb en int
                // Gérer les exceptions 
                try
                {
                    int prix2 = Int32.Parse(nb);
                    nombreDeTentatives++;
                    // Faire la comparaison entre les 2 :
                    // Faire if  / else if  / else
                    if (prix1 < prix2)
                    {
                        Console.WriteLine(prix2 + " est trop grand");
                    }
                    else if (prix1 > prix2)
                    {
                        Console.WriteLine(prix2 + " est trop petit");
                    }
                    else
                    {
                        Console.WriteLine("Bravo vous avez trouvé le prix de l'objet !");
                        break; // Sortir de la boucle si le prix est correct
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Veuillez saisir un nombre ?");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Le nombre est trop grand !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur est survenue !");
                    Console.WriteLine(ex);
                }
            }

            // Afficher le nombre de tentatives utilisées
            Console.WriteLine("Nombre de tentatives utilisées : " + nombreDeTentatives);
            string message = nombreDeTentatives < 3 ? "Tu es un super champion !" : "Tu es un Champion !";
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
