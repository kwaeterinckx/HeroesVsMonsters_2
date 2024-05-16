using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public abstract class Hero : Personnage
    {
        public Hero(string nom) : base(nom) { 
        }

        public void loot(Hero monstre)
        {
            Or += monstre.Or;
            Cuir += monstre.Cuir;
            Console.WriteLine($"Vous récupérez {monstre.Or} pièce(s) d'or et {monstre.Cuir} morceau(x) de cuir");
        }
    }
}
