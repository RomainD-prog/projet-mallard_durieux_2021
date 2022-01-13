using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Titre = "Iron Man",
                        Image="Iron-Man-2008.png.webp",
                        Datedesortie = DateTime.Parse("2008-4-30"),
                        Genre = "Action Aventure",
                        Phase = "1",
                        Resume = "Tony Stark, inventeur de génie, vendeur d'armes et playboy milliardaire, est kidnappé en Aghanistan. Forcé par ses ravisseurs de fabriquer une arme redoutable, il construit en secret une armure high-tech révolutionnaire qu'il utilise pour s'échapper. Comprenant la puissance de cette armure, il décide de l'améliorer et de l'utiliser pour faire régner la justice et protéger les innocents."
                    },

                    new Movie
                    {
                        Titre = "L'incroyable Hulk ",
                        Image="The-Incredible-Hulk-2008.png.webp",
                        Datedesortie = DateTime.Parse("2008-07-23"),
                        Genre = "Action SF",
                        Phase = "1",
                        Resume = "Le scientifique Bruce Banner cherche désespérément un antidote aux radiations gamma qui ont créé Hulk. Il vit dans l'ombre, toujours amoureux de la belle Betty Ross et parcourt la planète à la recherche d'un remède. La force destructrice de Hulk attire le Général Thunderbolt Ross et son bras droit Blonsky qui rêvent de l'utiliser à des fins militaires. Ils tentent de développer un sérum pour créer des soldats surpuissants. De retour aux Etats-Unis, Bruce Banner se découvre un nouvel ennemi. Après avoir essayé le sérum expérimental, Blonsky est devenu L'Abomination, un monstre incontrôlable dont la force pure est même supérieure à celle de Hulk. Devenu fou, il s'est transformé en plein coeur de New York. Pour sauver la ville de la destruction totale, Bruce Banner va devoir faire appel au monstre qui sommeille en lui..."
                    },

                    new Movie
                    {
                        Titre = "Iron Man 2",
                        Image="Iron-Man-2-2010.png.webp",
                        Datedesortie = DateTime.Parse("2010-04-28"),                        
                        Genre = "Action Aventure",
                        Phase ="1" ,
                        Resume = "Le monde sait désormais que l'inventeur milliardaire Tony Stark et le super-héros Iron Man ne font qu'un. Malgré la pression du gouvernement, de la presse et du public pour qu'il partage sa technologie avec l'armée, Tony n'est pas disposé à divulguer les secrets de son armure, redoutant que l'information atterrisse dans de mauvaises mains. Avec Pepper Potts et James Rhodes à ses côtés, Tony va forger de nouvelles alliances et affronter de nouvelles forces toutes-puissantes..."
                    },

                    new Movie
                    {
                        Titre = "Thor",
                        Image="Thor-2011.png",
                        Datedesortie = DateTime.Parse("2011-4-27"),
                        Genre = "Action Aventure",
                        Phase ="1",
                        Resume = "Au royaume d’Asgard, Thor est un guerrier aussi puissant qu’arrogant dont les actes téméraires déclenchent une guerre ancestrale. Banni et envoyé sur Terre, par son père Odin, il est condamné à vivre parmi les humains. Mais lorsque les forces du mal de son royaume s’apprêtent à se déchaîner sur la Terre, Thor va apprendre à se comporter en véritable héros…"
                    },

                    new Movie
                    {
                        Titre = "Captain America : First Avenger",
                        Image="Captain-America-The-First-Avenger-2011.jpg",
                        Datedesortie = DateTime.Parse("2011-08-27"),
                        Genre = "Action Aventure",
                        Phase ="1",
                        Resume = "Captain America: First Avenger nous plonge dans les premières années de l’univers Marvel. Steve Rogers, frêle et timide, se porte volontaire pour participer à un programme expérimental qui va le transformer en un Super Soldat connu sous le nom de Captain America. Allié à Bucky Barnes et Peggy Carter, il sera confronté à la diabolique organisation HYDRA dirigée par le redoutable Red Skull."
                    },

                    new Movie
                    {
                        Titre = "Avengers",
                        Image="The-Avengers-2012.png.webp",
                        Datedesortie = DateTime.Parse("2012-4-25"),
                        Genre = "Action Aventure",
                        Phase ="1",
                        Resume = "Lorsque Nick Fury, le directeur du S.H.I.E.L.D., l'organisation qui préserve la paix au plan mondial, cherche à former une équipe de choc pour empêcher la destruction du monde, Iron Man, Hulk, Thor, Captain America, Hawkeye et Black Widow répondent présents. Les Avengers ont beau constituer la plus fantastique des équipes, il leur reste encore à apprendre à travailler ensemble, et non les uns contre les autres, d'autant que le redoutable Loki a réussi à accéder au Cube Cosmique et à son pouvoir illimité..."
                    },

                    new Movie
                    {
                        Titre = "Iron Man 3",
                        Image="Iron-Man-3-2013.png.webp",
                        Datedesortie = DateTime.Parse("2013-4-24"),
                        Genre = "Action Aventure",
                        Phase ="2",
                        Resume = "Tony Stark, l’industriel flamboyant qui est aussi Iron Man, est confronté cette fois à un ennemi qui va attaquer sur tous les fronts. Lorsque son univers personnel est détruit, Stark se lance dans une quête acharnée pour retrouver les coupables. Plus que jamais, son courage va être mis à l’épreuve, à chaque instant. Dos au mur, il ne peut plus compter que sur ses inventions, son ingéniosité, et son instinct pour protéger ses proches. Alors qu’il se jette dans la bataille, Stark va enfin découvrir la réponse à la question qui le hante secrètement depuis si longtemps : est-ce l’homme qui fait le costume ou bien le costume qui fait l’homme ?"
                    },

                    new Movie
                    {
                        Titre = "Thor : Le monde des ténèbres",
                        Image="Thor-The-Dark-World-2013.png.webp",
                        Datedesortie = DateTime.Parse("2013-10-30"),
                        Genre = "Action Aventure",
                        Phase ="2",
                        Resume = "Thor : Le Monde des ténèbres nous entraîne dans les nouvelles aventures de Thor, le puissant Avenger, qui lutte pour sauver la Terre et les neuf mondes d’un mystérieux ennemi qui convoite l’univers tout entier… Après les films Marvel Thor et Avengers, Thor se bat pour restaurer l’ordre dans le cosmos, mais une ancienne race, sous la conduite du terrible Malekith, un être assoiffé de vengeance, revient pour répandre les ténèbres. Confronté à un ennemi que même Odin et Asgard ne peuvent contrer, Thor doit s’engager dans son aventure la plus dangereuse et la plus personnelle, au cours de laquelle il va devoir s’allier au traître Loki pour sauver non seulement son peuple et ceux qui lui sont chers, mais aussi l’univers lui-même."
                    },
                    new Movie
                    {
                        Titre = "Captain America: Le soldat de l'hiver",
                        Image="Captain-America-The-Winter-Soldier-2014.png.webp",
                        Datedesortie = DateTime.Parse("2014-04-14"),
                        Genre = "Action Aventure",
                        Phase ="2",
                        Resume = "Après les événements cataclysmiques de New York de The Avengers, Steve Rogers aka Captain America vit tranquillement à Washington, D.C. et essaye de s'adapter au monde moderne. Mais quand un collègue du S.H.I.E.L.D. est attaqué, Steve se retrouve impliqué dans un réseau d'intrigues qui met le monde en danger. S'associant à Black Widow, Captain America lutte pour dénoncer une conspiration grandissante, tout en repoussant des tueurs professionnels envoyés pour le faire taire. Quand l'étendue du plan maléfique est révélée, Captain America et Black Widow sollicite l'aide d'un nouvel allié, le Faucon. Cependant, ils se retrouvent bientôt face à un inattendu et redoutable ennemi - le Soldat de l'Hiver."
                    },

                    new Movie
                    {
                        Titre = "Les Gardiens de la Galaxie",
                        Image="Guardians-of-the-Galaxy-2014.png.webp",
                        Datedesortie = DateTime.Parse("2014-08-13"),
                        Genre = "Action Aventure",
                        Phase ="2",
                        Resume = "Peter Quill est un aventurier traqué par tous les chasseurs de primes pour avoir volé un mystérieux globe convoité par le puissant Ronan, dont les agissements menacent l’univers tout entier. Lorsqu’il découvre le véritable pouvoir de ce globe et la menace qui pèse sur la galaxie, il conclut une alliance fragile avec quatre aliens disparates : Rocket, un raton laveur fin tireur, Groot, un humanoïde semblable à un arbre, l’énigmatique et mortelle Gamora, et Drax le Destructeur, qui ne rêve que de vengeance. En les ralliant à sa cause, il les convainc de livrer un ultime combat aussi désespéré soit-il pour sauver ce qui peut encore l’être …"
                    },

                    new Movie
                    {
                        Titre = "Avengers : L'Ere d'Ultron",
                        Image="Avengers-Age-of-Ultron-2015.png.webp",
                        Datedesortie = DateTime.Parse("2015-4-22"),
                        Genre = "Action Aventure",
                        Phase ="2",
                        Resume = "Alors que Tony Stark tente de relancer un programme de maintien de la paix jusque-là suspendu, les choses tournent mal et les super-héros Iron Man, Captain America, Thor, Hulk, Black Widow et Hawkeye vont devoir à nouveau unir leurs forces pour combattre le plus puissant de leurs adversaires : le terrible Ultron, un être technologique terrifiant qui s’est juré d’éradiquer l’espèce humaine. Afin d’empêcher celui-ci d’accomplir ses sombres desseins, des alliances inattendues se scellent, les entraînant dans une incroyable aventure et une haletante course contre le temps…"
                    },

                    new Movie
                    {
                        Titre = "Ant-Man",
                        Image="Ant-Man-2015.png.webp",
                        Datedesortie = DateTime.Parse("2015-07-14"),
                        Genre = "Action Aventure",
                        Phase ="2",
                        Resume = "Scott Lang, cambrioleur de haut vol, va devoir apprendre à se comporter en héros et aider son mentor, le Dr Hank Pym, à protéger le secret de son spectaculaire costume d’Ant-Man, afin d’affronter une effroyable menace…"
                    },

                    new Movie
                    {
                        Titre = "Captain America : Civil War",
                        Image="civilwar.png",
                        Datedesortie = DateTime.Parse("2016-4-27"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Steve Rogers est désormais à la tête des Avengers, dont la mission est de protéger l'humanité. À la suite d'une de leurs interventions qui a causé d'importants dégâts collatéraux, le gouvernement décide de mettre en place un organisme de commandement et de supervision. Cette nouvelle donne provoque une scission au sein de l'équipe : Steve Rogers reste attaché à sa liberté de s'engager sans ingérence gouvernementale, tandis que d'autres se rangent derrière Tony Stark, qui contre toute attente, décide de se soumettre au gouvernement..."
                    },

                    new Movie
                    {
                        Titre = "Doctor Strange",
                        Image="dstrange.png",
                        Datedesortie = DateTime.Parse("2016-10-24"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Doctor Strange suit l'histoire du Docteur Stephen Strange, talentueux neurochirurgien qui, après un tragique accident de voiture, doit mettre son égo de côté et apprendre les secrets d'un monde caché de mysticisme et de dimensions alternatives. Basé à New York, dans le quartier de Greenwich Village, Doctor Strange doit jouer les intermédiaires entre le monde réel et ce qui se trouve au-delà, en utlisant un vaste éventail d'aptitudes métaphysiques et d'artefacts pour protéger le Marvel Cinematic Universe."
                    },

                    new Movie
                    {
                        Titre = "Les Gardiens de la Galaxie Vol.2",
                        Image="guardiangal2.jpg",
                        Datedesortie = DateTime.Parse("2017-4-27"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Musicalement accompagné de la Awesome Mixtape n°2 (la musique qu'écoute Star-Lord dans le film), Les Gardiens de la galaxie 2 poursuit les aventures de l'équipe alors qu'elle traverse les confins du cosmos. Les gardiens doivent combattre pour rester unis alors qu'ils découvrent les mystères de la filiation de Peter Quill. Les vieux ennemis vont devenir de nouveaux alliés et des personnages bien connus des fans de comics vont venir aider nos héros et continuer à étendre l'univers Marvel."
                    },

                    new Movie
                    {
                        Titre = "Spider-Man : Homecoming",
                        Image="spiderman.png",
                        Datedesortie = DateTime.Parse("2017-7-12"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Après ses spectaculaires débuts dans Captain America : Civil War, le jeune Peter Parker découvre peu à peu sa nouvelle identité, celle de Spider-Man, le super-héros lanceur de toile. Galvanisé par son expérience avec les Avengers, Peter rentre chez lui auprès de sa tante May, sous l’œil attentif de son nouveau mentor, Tony Stark. Il s’efforce de reprendre sa vie d’avant, mais au fond de lui, Peter rêve de se prouver qu’il est plus que le sympathique super héros du quartier. L’apparition d’un nouvel ennemi, le Vautour, va mettre en danger tout ce qui compte pour lui..."
                    },

                    new Movie
                    {
                        Titre = "Thor : Ragnarok",
                        Image="thor3.png",
                        Datedesortie = DateTime.Parse("2017-8-25"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Privé de son puissant marteau, Thor est retenu prisonnier sur une lointaine planète aux confins de l’univers. Pour sauver Asgard, il va devoir lutter contre le temps afin d’empêcher l’impitoyable Hela d’accomplir le Ragnarök – la destruction de son monde et la fin de la civilisation asgardienne. Mais pour y parvenir, il va d’abord devoir mener un combat titanesque de gladiateurs contre celui qui était autrefois son allié au sein des Avengers : l’incroyable Hulk…"
                    },

                    new Movie
                    {
                        Titre = "Black Panther",
                        Image="blackpanther.png",
                        Datedesortie = DateTime.Parse("2018-2-14"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Après les événements qui se sont déroulés dans Captain America : Civil War, T’Challa revient chez lui prendre sa place sur le trône du Wakanda, une nation africaine technologiquement très avancée. Mais lorsqu’un vieil ennemi resurgit, le courage de T’Challa est mis à rude épreuve, aussi bien en tant que souverain qu’en tant que Black Panther. Il se retrouve entraîné dans un conflit qui menace non seulement le destin du Wakanda, mais celui du monde entier…"
                    },

                    new Movie
                    {
                        Titre = "Avengers : Infinity War",
                        Image="avengersinfwar.png",
                        Datedesortie = DateTime.Parse("2018-4-25"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Les Avengers et leurs alliés devront être prêts à tout sacrifier pour neutraliser le redoutable Thanos avant que son attaque éclair ne conduise à la destruction complète de l’univers."
                    },

                    new Movie
                    {
                        Titre = "Ant-Man et la Guêpe",
                        Image="antman2.png",
                        Datedesortie = DateTime.Parse("2018-7-18"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Après les événements survenus dans Captain America : Civil War, Scott Lang a bien du mal à concilier sa vie de super-héros et ses responsabilités de père. Mais ses réflexions sur les conséquences de ses choix tournent court lorsque Hope van Dyne et le Dr Hank Pym lui confient une nouvelle mission urgente… Scott va devoir renfiler son costume et apprendre à se battre aux côtés de La Guêpe afin de faire la lumière sur des secrets enfouis de longue date…"
                    },

                    new Movie
                    {
                        Titre = "Captain Marvel",
                        Image="captainmarvel.png",
                        Datedesortie = DateTime.Parse("2019-3-6"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Captain Marvel raconte l’histoire de Carol Danvers qui va devenir l’une des super-héroïnes les plus puissantes de l’univers lorsque la Terre se révèle l’enjeu d’une guerre galactique entre deux races extraterrestres."
                    },

                    new Movie
                    {
                        Titre = "Avengers : Endgame",
                        Image="avengerendgame.png",
                        Datedesortie = DateTime.Parse("2019-4-24"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "Thanos ayant anéanti la moitié de l’univers, les Avengers restants resserrent les rangs dans ce vingt-deuxième film des Studios Marvel, grande conclusion d’un des chapitres de l’Univers Cinématographique Marvel."
                    },

                    new Movie
                    {
                        Titre = "Spider-Man : Far From Home",
                        Image="spiderman2.jpg",
                        Datedesortie = DateTime.Parse("2019-7-3"),
                        Genre = "Action Aventure",
                        Phase ="3",
                        Resume = "L'araignée sympa du quartier décide de rejoindre ses meilleurs amis Ned, MJ, et le reste de la bande pour des vacances en Europe. Cependant, le projet de Peter de laisser son costume de super-héros derrière lui pendant quelques semaines est rapidement compromis quand il accepte à contrecoeur d'aider Nick Fury à découvrir le mystère de plusieurs attaques de créatures, qui ravagent le continent !"
                    },

                    new Movie
                    {
                        Titre = "Black Widow",
                        Image="blackwidow.webp",
                        Datedesortie = DateTime.Parse("2021-7-7"),
                        Genre = "Action Aventure",
                        Phase ="4",
                        Resume = "Natasha Romanoff, alias Black Widow, voit resurgir la part la plus sombre de son passé pour faire face à une redoutable conspiration liée à sa vie d’autrefois. Poursuivie par une force qui ne reculera devant rien pour l’abattre, Natasha doit renouer avec ses activités d’espionne et avec des liens qui furent brisés, bien avant qu’elle ne rejoigne les Avengers."
                    },

                    new Movie
                    {
                        Titre = "Shang-Chi et la légende des Dix Anneaux",
                        Image="shang-chi.png.webp",
                        Datedesortie = DateTime.Parse("2021-9-1"),
                        Genre = "Action Aventure",
                        Phase ="4",
                        Resume = "Shang-Chi va devoir affronter un passé qu’il pensait avoir laissé derrière lui lorsqu’il est pris dans la toile de la mystérieuse organisation des dix anneaux."
                    },

                    new Movie
                    {
                        Titre = "Les Eternels",
                        Image="eternel.jpg.png",
                        Datedesortie = DateTime.Parse("2021-11-3"),
                        Genre = "Action Aventure",
                        Phase ="4",
                        Resume = "Depuis l’aube de l’humanité, les Éternels, un groupe de héros venus des confins de l’univers, protègent la Terre. Lorsque les Déviants, des créatures monstrueuses que l’on croyait disparues depuis longtemps, réapparaissent mystérieusement, les Éternels sont à nouveau obligés de se réunir pour défendre l’humanité…"
                    },

                    new Movie
                    {
                        Titre = "Spider-Man : No Way Home",
                        Image="spiderman3.webp",
                        Datedesortie = DateTime.Parse("2021-12-15"),
                        Genre = "Action Aventure",
                        Phase ="4",
                        Resume = "Pour la première fois dans son histoire cinématographique, Spider-Man, le héros sympa du quartier est démasqué et ne peut désormais plus séparer sa vie normale de ses lourdes responsabilités de super-héros. Quand il demande de l'aide à Doctor Strange, les enjeux deviennent encore plus dangereux, le forçant à découvrir ce qu'être Spider-Man signifie véritablement."
                    }

                
                );
                context.SaveChanges();
            }
        }
    }
}