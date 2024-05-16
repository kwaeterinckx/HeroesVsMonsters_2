using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Nain : Hero
    {
        public override int Endurance => base.Endurance + 2;
        public Nain(string nom) : base(nom) {
            Race = "Nain";
        }
    }
}
