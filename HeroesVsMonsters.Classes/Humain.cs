using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Humain : Heros
    {
        public override int Endurance => base.Endurance + 1;
        public override int Force => base.Force + 1;
        public Humain(string nom) : base(nom) {
            Race = "Humain";
        }
    }
}
