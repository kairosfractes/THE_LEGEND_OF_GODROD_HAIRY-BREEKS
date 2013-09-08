using System;
using System.IO;

namespace THE_LEGEND_OF_GODROD_HAIRYBREEKS
{
	class MainClass
	{
		public static void Main ()
		{
			//string classname;
			string playername;
			bool classchosen = false;
			bool characterchosen = false;
			Hero player = new Warrior ("satan");
			while (!characterchosen) {
				Console.WriteLine ("WHAT IS YOUR NAME, HERO?");
				playername = Console.ReadLine ();
				Console.Clear ();
				while (!classchosen) {
					Console.WriteLine ("Being an individual of determination and skill, you can pick up pretty much anything and be good at it." +
						"\nHowever, time and lifestyle changes have forced you to pick a specific skillset.");
					Console.WriteLine ("=============================================");
					Console.WriteLine ("PICK YOUR CLASS: WARRIOR, MAGE, THIEF (W,M,T)");
					switch (Console.ReadKey ().Key) {
					case ConsoleKey.W:
						player = new Warrior (playername);
						classchosen = true;
						//classname = "warrior";
						break;
					case ConsoleKey.M:
						player = new Mage (playername);
						classchosen = true;
						//classname = "mage";
						break;
					case ConsoleKey.T:
						player = new Thief (playername);
						classchosen = true;
						//classname = "thief";
						break;
					default:
						Console.WriteLine ("DAS NOT A CALSS SIR");
						break;
					}
				}
				Console.Clear ();
				Console.WriteLine ("============");
				Console.WriteLine ("PLAYER STATS");
				Console.WriteLine ("============");
				Console.WriteLine ("Name: {0}", player.myname);
				Console.WriteLine ("Health: {0}", player.health);
				Console.WriteLine ("Magicka: {0}", player.magicka);
				Console.WriteLine ("Encumbrance: {0}", player.encumbrance);
				Console.WriteLine ("============");
				Console.WriteLine ("Agility: {0}", player.stat_agility);
				Console.WriteLine ("Endurance: {0}", player.stat_endurance);
				Console.WriteLine ("Intelligence: {0}", player.stat_intelligence);
				Console.WriteLine ("Luck: {0}", player.stat_luck);
				Console.WriteLine ("Personality: {0}", player.stat_personality);
				Console.WriteLine ("Speed: {0}", player.stat_speed);
				Console.WriteLine ("Strength: {0}", player.stat_strength);
				Console.WriteLine ("Willpower: {0}", player.stat_willpower);
				Console.WriteLine ("============");
				Console.WriteLine ("Block: {0}", player.skill_block);
				Console.WriteLine ("Heavy Weapon: {0}", player.skill_heavyweap);
				Console.WriteLine ("Light Weapon: {0}", player.skill_lightweap);
				Console.WriteLine ("Destruction: {0}", player.skill_destruction);
				Console.WriteLine ("Restoration: {0}", player.skill_restoration);
				Console.WriteLine ("Alteration: {0}", player.skill_alteration);
				Console.WriteLine ("============");
				Console.WriteLine ("ARE YOU THE HERO YOU SAY YOU ARE? (y/n)");
				switch (Console.ReadKey ().Key) {
				case ConsoleKey.N:
					Console.WriteLine ("WHO ARE YOU, REALLY?");
					break;
				default:
					characterchosen = true;
					break;
				}
			}
			Console.Clear ();
			Console.WriteLine ("You begin in the dungeons of Detroit, in a cell only big enough for you and the eight corpses you're being smothered with. " +
				"However, fate has shone upon you, for Lord Godrod Hairy-Breeks summons you to Castle Frankenbaum for an audience. " +
				"'You are one lucky peasant {0}, for we have had to place another corpse in the dungeon cell you occupied. Since we have no other cells, " +
				"you will be my personal courier and knight. As of now, I have no tasks for you to complete. Rather, you should gather experience for yourself " +
				"out in the world. Find princesses to fuck, merchants to hustle out of their money, or animals to practice sexual intercourse with!\n" +
				"Anyways, get the fuck out of my castle.\n'" +
				"==========================================\n" +
				"1. Exit the castle doors\n" +
				"2. Stare at Lord Godrod\n" +
				"3. Say 'ok, mom'", player.myname);
			switch (Console.ReadKey(false).Key) {
			case ConsoleKey.D1:
				Console.WriteLine ("case 1");
				goto default;
			case ConsoleKey.D2:
				Console.WriteLine ("case 2");
				goto default;
			case ConsoleKey.D3:
				Console.WriteLine ("case 3");
				goto default;
			default:
				Console.WriteLine ("Godrod Hairy-Breeks: 'YOU DARE TO BE SNIPPY WITH ME?! \nYOU WILL BE TAUGHT BY MY FAT WIENER WHAT RESPECT IS! \nPREPARE FOR THE ANAL RAVAGING OF YOUR LIFETIME, PEASANT!'\n" +
					"Lord Godrod tears off his leathers in fury, and begins to storm towards you with his dong dragging across the carpeted floor...");
				player.Die ();
				break;
				}
			}
		}
	}