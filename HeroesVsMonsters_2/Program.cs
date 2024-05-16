using HeroesVsMonsters_2.Classes;

namespace HeroesVsMonsters_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Début d'une nouvelle partie
            Shorewood shorewood = new Shorewood();

            // Introduction
            shorewood.DefisAccepte = Partie.Introduction();
            shorewood.PartieTerminee = !shorewood.DefisAccepte;

            // Si le défi est accepté, la partie continue
            while(!shorewood.PartieTerminee)
            {
                // Choix du héros
                shorewood.SelectionDuHeros();

                // Présentation du nouvel héros
                Partie.PresentationHeros(shorewood.Heros);

                // Lancement des combats tant que la partie est en cours et que le héros est vivant
                while (!shorewood.PartieTerminee && shorewood.Heros.PointDeVie > 0)
                {
                    // Sélection du monstre
                    shorewood.SelectionDuMonstre();

                    // Présentation du combat
                    Partie.PresentationCombat(shorewood.Heros, shorewood.Monstre);

                    // Début du combat tant que la partie est en cours et que le héros et le monstre sont vivants
                    Console.Clear();
                    bool tourDuHeros = true;
                    while (!shorewood.PartieTerminee && shorewood.Heros.PointDeVie > 0 && shorewood.Monstre.PointDeVie > 0)
                    {
                        Thread.Sleep(1000);
                        if (tourDuHeros)
                        {
                            shorewood.Heros.Frappe(shorewood.Monstre);
                        }
                        else
                        {
                            shorewood.Monstre.Frappe(shorewood.Heros);
                        }
                        tourDuHeros = !tourDuHeros;
                    }
                    if (shorewood.Heros.PointDeVie <= 0)
                    {
                        shorewood.PartieTerminee = true;
                        Partie.Perdu(shorewood.Heros);
                    }
                    else
                    {
                        Partie.CombatGagne(shorewood.Heros, shorewood.Monstre);
                    }
                }

                shorewood.PartieTerminee = true;
            }

            // Si le défi à été refusé
            if (!shorewood.DefisAccepte)
            {
                Partie.Refus();
            }

            // Fin de la partie
            Partie.Terminee();

            Console.WriteLine(shorewood.DefisAccepte);
        }
    }
}
