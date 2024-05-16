using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Dragonnet : Monstre
    {
        public override int Endurance => base.Endurance + 1;
        public Dragonnet(string nom) : base(nom) {
            Race = "Dragonnet";
            Or = D6.lance();
            Cuir = D4.lance();
        }
    }
}
