using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters_2.Classes
{
    public static class Partie
    {
        public static bool Introduction()
        {
            Console.Clear();
            DefilementTexte("Bienvenue dans la forêt de Shorewood, un sanctuaire mystique niché dans le coeur battant du pays de Stormwall.", "");
            DefilementTexte("Ici, la brume matinale danse entre les arbres centenaires et les chants mélodieux des créatures féeriques", "");
            DefilementTexte("résonnent sous la voûte céleste. Mais ne vous y trompez pas, car sous cette sérénité apparente se cache une", "");
            DefilementTexte("lutte éternelle pour la survie et la souveraineté.", "");
            DefilementTexte("", "");
            DefilementTexte("Vous êtes sur le point d’entrer dans un monde où chaque choix forge votre destinée, où les héros et les monstres", "");
            DefilementTexte("se disputent chaque parcelle de terre sacrée. Votre courage sera mis à l’épreuve, vos alliances seront cruciales, et", "");
            DefilementTexte("votre force d’âme déterminera l’avenir de Shorewood.", "");
            DefilementTexte("", "");
            DefilementTexte("Préparez-vous à brandir votre épée, à invoquer la magie ancestrale et à écrire votre propre légende. Que vous", "");
            DefilementTexte("soyez un guerrier intrépide, un mage érudit ou un rôdeur des ombres, votre aventure commence maintenant.", "");
            DefilementTexte("Rejoignez la bataille, défendez l’honneur de la forêt et devenez le héros que Stormwall mérite.", "");
            DefilementTexte("", "");
            DefilementTexte("L’heure est venue de prendre part à l’épopée de Shorewood. Êtes-vous prêt à relever le défi? (o/n): ");
            bool ChoixEstValable = char.TryParse(Console.ReadLine().Trim().ToLower(), out char choix);
            while (!ChoixEstValable || (choix != 'o' && choix != 'n'))
            {
                DefilementTexte("Veuillez répondre 'o' ou 'n' (o/n): ");
                ChoixEstValable = char.TryParse(Console.ReadLine().Trim().ToLower(), out choix);
            }
            return (choix == 'o') ? true : false;
        }

        public static string[] ChoixHeros()
        {
            Console.Clear();
            DefilementTexte("Dans la salle commune de la taverne de Shorewood, plusieurs héritages vous appellent. Chaque race possède ses", "");
            DefilementTexte("propres dons, forgés par les épreuves du temps et les batailles ancestrales. Votre choix déterminera non", "");
            DefilementTexte("seulement votre apparence, mais aussi vos capacités intrinsèques qui vous accompagneront tout au long de", "");
            DefilementTexte("votre quête.", "");
            DefilementTexte("", "");
            // Nain
            DefilementTexte("Le Nain, descendant des anciens rois sous la montagne, apporte avec lui la robustesse de son peuple. Sa", "");
            DefilementTexte("constitution est telle qu’il bénéficie de 2 points d’endurance supplémentaires, lui permettant de résister aux", "");
            DefilementTexte("assauts les plus rudes et de persévérer là où d’autres flancheraient.", "");
            DefilementTexte("", "");
            // Humain
            DefilementTexte("L’Humain, quant à lui, est un symbole de diversité et d’ambition. Il tire sa force de sa volonté de fer et de son", "");
            DefilementTexte("esprit indomptable, ce qui se traduit par 1 point de force et 1 point d’endurance supplémentaires. Cela lui confère", "");
            DefilementTexte("une polyvalence sur le champ de bataille, capable de porter des coups puissants tout en restant résilient face à", "");
            DefilementTexte("l’adversité.", "");
            DefilementTexte("", "");
            DefilementTexte("La balance de votre destin est en jeu. Choisissez-vous la résistance inébranlable du Nain, ou la force équilibrée et", "");
            DefilementTexte("la ténacité de l’Humain ? (h/n): ");
            bool ChoixEstValable = char.TryParse(Console.ReadLine().Trim().ToLower(), out char choixRace);
            while (!ChoixEstValable || (choixRace != 'h' && choixRace != 'n'))
            {
                DefilementTexte("Veuillez répondre 'h' ou 'n' (h/n): ");
                ChoixEstValable = char.TryParse(Console.ReadLine().Trim().ToLower(), out choixRace);
            }
            DefilementTexte("", "");
            DefilementTexte("Bien sûr ! Avant de poursuivre, puis-je connaître votre nom, noble aventurier ? Comment devrais-je vous appeler", "");
            DefilementTexte("dans les chants et les récits qui raconteront vos exploits à travers Stormwall ?", "");
            string choixNom = Console.ReadLine().Trim();
            while (choixNom is null || choixNom == "")
            {
                DefilementTexte("Veuillez entrer votre nom: ");
                choixNom = Console.ReadLine().Trim();
            }
            return [choixRace.ToString(), choixNom];
        }

        public static void Refus()
        {
            Console.Clear();
            DefilementTexte("Face à l'entrée ombragée de la forêt de Shorewood, le héros s'arrêta, contemplant le chemin qui", "");
            DefilementTexte("s'enfonçait dans l'inconnu. Les légendes parlaient de batailles épiques et de créatures terrifiantes,", "");
            DefilementTexte("mais aussi d'une paix trouvée seulement au-delà du courage.", "");
            DefilementTexte("", "");
            DefilementTexte("Pourtant, en cet instant, le héros sentit le poids du doute peser sur ses épaules. Le vent portait", "");
            DefilementTexte("des murmures de danger, et chaque feuille qui tombait semblait un présage. Avec un soupir qui se", "");
            DefilementTexte("mêlait à la brise, il tourna le dos à la forêt, choisissant un autre destin.", "");
            DefilementTexte("", "");
            DefilementTexte("Shorewood resta silencieuse, ses secrets cachés une fois de plus. Le héros, quant à lui, marcha", "");
            DefilementTexte("vers un avenir différent, peut-être moins glorieux, mais tout aussi important. Car chaque chemin non", "");
            DefilementTexte("pris est une histoire qui attend son heure pour être racontée.", "");
            DefilementTexte("", "");
            DefilementTexte("Appuyez sur une touche pour continuer ");
            Console.ReadKey();
        }

        public static void CombatGagne(Heros heros, Monstre monstre)
        {
            DefilementTexte("", "");
            if (monstre.Race == "Loup")
            {
                DefilementTexte($"Le combat fut rude, mais la ruse et la bravoure ont triomphé. {monstre.Nom} gît à présent, vaincu,", "");
                DefilementTexte("tandis que le héros lève son arme en signe de victoire. La forêt retient son souffle, reconnaissante.", "");
            }
            else if (monstre.Race == "Orque")
            {
                DefilementTexte($"{monstre.Nom} est tombé, sa hache brisée à ses côtés. Le héros se tient debout, fier et", "");
                DefilementTexte("inébranlable, sous les acclamations silencieuses des arbres millénaires.", "");
            }
            else
            {
                DefilementTexte($"La flamme de {monstre.Nom} s'est éteinte, et le ciel est clair une fois de plus. Le héros,", "");
                DefilementTexte("émergeant sans une égratignure, savoure le doux goût de la victoire face à ce jeune dragon.", "");
            }
            DefilementTexte("", "");
            heros.loot(monstre);
            heros.SoignerHeros();
            DefilementTexte("", "");
            DefilementTexte("Le tumulte du combat s'estompe, laissant place au calme réconfortant de la forêt de Shorewood.", "");
            DefilementTexte("Notre héros, victorieux mais épuisé, s'accorde un instant pour panser ses blessures et restaurer ses", "");
            DefilementTexte("forces vitales.", "");
            DefilementTexte("", "");
            DefilementTexte("Appuyez sur une touche pour continuer votre aventure ");
            Console.ReadKey();
        }

        public static void Perdu(Heros heros)
        {
            DefilementTexte("", "");
            DefilementTexte("Sous le voile de la nuit, le héros de Stormwall s'aventura dans les profondeurs de la forêt de", "");
            DefilementTexte("Shorewood, guidé par la promesse d'une gloire éternelle. Mais dans ce labyrinthe de verdure, où", "");
            DefilementTexte("chaque ombre cache un danger mortel, même le coeur le plus vaillant peut être brisé.", "");
            DefilementTexte("", "");
            DefilementTexte("Les monstres, tapis dans l'obscurité, guettaient chaque pas du voyageur intrépide. Un combat féroce", "");
            DefilementTexte("s'ensuivit, où l'éclat de l'épée et le grondement des sortilèges déchiraient le silence sacré de la", "");
            DefilementTexte($"forêt. Hélas, malgré sa bravoure et sa force, {heros.Nom} fut submergé par la horde impitoyable.", "");
            DefilementTexte("", "");
            DefilementTexte("Son dernier souffle s'échappa comme un murmure parmi les feuilles, et son esprit s'envola vers les", "");
            DefilementTexte("cieux, laissant derrière lui un corps sans vie, enveloppé par la mousse et les racines. La forêt de", "");
            DefilementTexte("Shorewood réclama ainsi une autre âme, ajoutant une page sombre à son histoire millénaire.", "");
            DefilementTexte("", "");
            DefilementTexte("Le lendemain, le soleil se leva, indifférent au destin du héros tombé. La nature reprit ses droits,", "");
            DefilementTexte("et le cycle éternel de la vie et de la mort continua, imperturbable. Dans le coeur de ceux qui se", "");
            DefilementTexte("souviennent, le héros de Shorewood vit toujours, un rappel poignant que même dans la défaite, il", "");
            DefilementTexte("y a de la noblesse et du courage.", "");
            DefilementTexte("", "");
            DefilementTexte("Appuyez sur une touche pour continuer ");
            Console.ReadKey();
        }

        public static void Terminee()
        {
            Console.Clear();
            DefilementTexte("Merci d’avoir joué !", "");
            DefilementTexte("", "");
            DefilementTexte("Appuyez sur une touche pour continuer ");
            Console.ReadKey();
        }

        public static void PresentationHeros(Heros heros)
        {
            Console.Clear();
            if (heros.Race == "Humain")
            {
                DefilementTexte("Bienvenue, vaillant Humain ! Votre choix témoigne d'un équilibre entre la force et la capacité à", "");
                DefilementTexte("persévérer. Votre polyvalence sera votre plus grand atout dans les terres mystérieuses de Stormwall.", "");
                DefilementTexte("", "");
                FichePersonnage(heros);
                DefilementTexte("", "");
                DefilementTexte($"Portez haut et fort le nom de {heros.Nom}, car il deviendra synonyme de bravoure et de grandeur.", "");
                DefilementTexte("Votre quête est noble, et votre histoire est sur le point de s'écrire.", "");
            }
            else
            {
                DefilementTexte("Félicitations, noble Nain ! Vous avez choisi la voie de la résilience et de la force inébranlable.", "");
                DefilementTexte("Avec votre endurance légendaire, vous êtes prêt à affronter les défis les plus ardus de Shorewood.", "");
                DefilementTexte("", "");
                FichePersonnage(heros);
                DefilementTexte("", "");
                DefilementTexte("Votre nom résonnera dans les halls de pierre de votre peuple, et votre courage sera un phare d'espoir", "");
                DefilementTexte($"dans la lutte contre les forces des ténèbres. Préparez-vous, {heros.Nom}, votre aventure commence maintenant !", "");
            }
            DefilementTexte("", "");
            DefilementTexte("Appuyez sur une touche pour commencer l'aventure ");
            Console.ReadKey();
        }

        public static void PresentationCombat(Heros heros, Monstre monstre)
        {
            Console.Clear();
            DefilementTexte("Vous vous aventurez dans la forêt quand, soudain,", "");
            if (monstre.Race == "Loup")
            {
                DefilementTexte("un grondement sourd se fait entendre alors que les buissons s'agitent. Les yeux perçants d'un loup de", "");
                DefilementTexte("Shorewood fixent le héros, prêt à bondir. La bataille pour la domination commence !", "");
            }
            else if (monstre.Race == "Orque")
            {
                DefilementTexte("avec un cri de guerre retentissant, un orque massif émerge de l'ombre, sa hache levée. La", "");
                DefilementTexte("confrontation est inévitable, le choc des armes imminent.", "");
            }
            else
            {
                DefilementTexte("un sifflement aigu traverse les airs tandis qu'un jeune dragonnet déploie ses ailes flamboyantes. Le", "");
                DefilementTexte("feu rencontre l'acier dans un affrontement qui décidera du sort du héros.", "");
            }
            DefilementTexte("", "");
            FichePersonnage(heros);
            DefilementTexte("", "");
            DefilementTexte("vs", "");
            DefilementTexte("", "");
            FichePersonnage(monstre);
            DefilementTexte("", "");
            DefilementTexte("Appuyez sur une touche commencer le combat ");
            Console.ReadKey();
        }

        public static void FichePersonnage(Personnage personnage)
        {
            DefilementTexte($"Nom: {personnage.Nom}", "");
            DefilementTexte($"Race: {personnage.Race}", "");
            DefilementTexte($"Attributs:", "");
            DefilementTexte($"  - Endurance: {personnage.Endurance}", "");
            DefilementTexte($"  - Force: {personnage.Force}", "");
            DefilementTexte($"  - Points de vie: {personnage.PointDeVie}/{personnage.PointDeVieMax}", "");
            DefilementTexte($"Richesse:", "");
            DefilementTexte($"  - Or: {personnage.Or}", "");
            DefilementTexte($"  - Cuir: {personnage.Cuir}", "");
        }

        public static void DefilementTexte(string texte)
        {
            for (int i = 0; i < texte.Length; i++)
            {
                Console.Write(texte[i]);
                //Thread.Sleep(10);
            }
        }
        public static void DefilementTexte(string texte, string line)
        {
            DefilementTexte(texte);
            Console.WriteLine();
        }
    }
}
