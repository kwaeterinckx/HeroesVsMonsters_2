using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public static class Partie
    {
        public static void Introduction()
        {
            Console.WriteLine("Bienvenue dans la forêt de Shorewood, forêt enchantée du pays de Stormwall.");
            Console.WriteLine("Dans cette forêt, se livre un combat acharné entre les héros et les monstre !");
            Console.Write("Souhaitez-vous prendre part à cette aventure et repousser les envahisseurs ? (o/n): ");

            bool estChoixValide = char.TryParse(Console.ReadLine(), out char choix);
            while (!estChoixValide || (choix != 'o' && choix != 'n'))
            {
                Console.Write("Veuillez répondre 'o' ou 'n' ! (o/n): ");
                estChoixValide = char.TryParse(Console.ReadLine(), out choix);
            }
        }
    }
}
