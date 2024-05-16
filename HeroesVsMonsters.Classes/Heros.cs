using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public abstract class Heros : Personnage
    {
        public Heros(string nom) : base(nom) { 
        }

        public void loot(Monstre monstre)
        {
            Or += monstre.Or;
            Cuir += monstre.Cuir;
            Partie.DefilementTexte($"Vous récupérez {monstre.Or} pièce(s) d'or et {monstre.Cuir} morceau(x) de cuir", "");
        }

        public void SoignerHeros()
        {
            soins(this);
        }
    }
}
