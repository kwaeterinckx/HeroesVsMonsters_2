using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class Loup : Monstre
    {
        public Loup(string nom) : base(nom) {
            Race = "Loup";
            Cuir = D4.lance();
        }
    }
}
