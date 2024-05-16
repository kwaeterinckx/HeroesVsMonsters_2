using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Shorewood
    {
        public Hero Hero { get; set; }

        public Shorewood()
        {
            Partie.Introduction();

            Hero = new Humain("Kévin");
        }
    }
}
