using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Shorewood
    {
        public bool DefisAccepte {  get; set; }
        public bool PartieTerminee { get; set; }
        public Heros Heros { get; set; }
        public Monstre Monstre { get; set; }
        public void SelectionDuHeros()
        {
            string[] choixHeros = Partie.ChoixHeros();
            Heros = (choixHeros[0] == "h") ? new Humain(choixHeros[1]) : new Nain(choixHeros[1]);
        }
        public void SelectionDuMonstre()
        {
            Random random = new Random();
            int numeroAleatoire = random.Next(3) + 1;
            Monstre = (numeroAleatoire == 1) ? new Loup("Griffe d'Argent") :
                (numeroAleatoire == 2) ? new Orque("Korog le Destructeur") :
                new Dragonnet("Écailles d'Émeraude");
        }
    }
}
