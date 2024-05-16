using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public abstract class Monstre : Personnage
    {
        public Monstre(string nom) : base(nom) {
        }
    }
}
