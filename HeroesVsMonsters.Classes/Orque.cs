using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Orque : Monstre
    {
        public override int Force => base.Force + 1;
        public Orque(string nom) : base(nom) {
            Race = "Orque";
            Or = D6.lance();
        }
    }
}
