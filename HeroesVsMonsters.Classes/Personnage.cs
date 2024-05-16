namespace HeroesVsMonsters_2.Classes
{
    public abstract class Personnage
    {
        public string Nom { get; init; }
        public string Race { get; init; }
        public virtual int Endurance { get; }
        public virtual int Force { get; }
        public int PointDeVieMax { get; private set; }
        public int PointDeVie { get; private set; }
        public int Or {  get; set; }
        public int Cuir { get; set; }
        public De D4 { get; }
        public De D6 { get; }

        public Personnage(string nom)
        {
            Nom = nom;
            Race = "";
            D4 = new De(4);
            D6 = new De(6);
            Endurance = CalculCaracteristique();
            Force = CalculCaracteristique();
            PointDeVieMax = Endurance + CalculModificateur(Endurance);
            PointDeVie = PointDeVieMax;
            Or = 0;
            Cuir = 0;
        }

        public int CalculCaracteristique()
        {
            List<int> lances = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                lances.Add(D6.lance());
            }
            lances.Sort();
            return (lances[1] + lances[2] + lances[3]);
        }
        public static int CalculModificateur(int score)
        {
            return (score < 5) ? -1 :
                (score < 10) ? 0 :
                (score < 15) ? 1 :
                2;
        }

        public void Frappe(Personnage adversaire)
        {
            int degats = D4.lance() + CalculModificateur(Force);
            adversaire.PointDeVie -= degats;
            Partie.DefilementTexte($"{Nom} inflige {degats} point(s) de dégats à {adversaire.Nom}", "");
        }

        private static void RecupererPointDeVie(Heros heros)
        {
            heros.PointDeVie = heros.PointDeVieMax;
        }
        public RecupererPointDeVieHandler soins = new(RecupererPointDeVie);
    }
}
