using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public class De
    {
        public int Minimum { get; }
        public int Maximum { get; }
        public De(int max)
        {
            Minimum = 1;
            Maximum = max;
        }

        public int lance()
        {
            Random rnd = new Random();
            return rnd.Next(Minimum, Maximum + 1);
        }
    }
}
