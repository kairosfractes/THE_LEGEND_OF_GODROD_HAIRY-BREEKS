using System;
using System.IO;

namespace THE_LEGEND_OF_GODROD_HAIRYBREEKS
{
	class MainClass
	{
		public static void Main ()
		{
			string playername;
			string playerclass;
			bool classchosen = false;
			bool characterchosen = false;
			string heroreroll;
			Hero player = new Warrior ("satan");
			while (!characterchosen) {
				Console.WriteLine ("WHAT IS YOUR NAME, HERO?");
				playername = Console.ReadLine ();
				while (!classchosen) {
					Console.WriteLine ("PICK YOUR CLASS: WARRIOR, MAGE, THIEF (W,M,T)");
					playerclass = Console.ReadLine ();
					switch (playerclass) {
					case "W":
						player = new Warrior (playername);
						classchosen = true;
						break;
					case "M":
						player = new Mage (playername);
						classchosen = true;
						break;
					case "T":
						player = new Thief (playername);
						classchosen = true;
						break;
					case "w":
						goto case "W";
					case "m":
						goto case "M";
					case "t":
						goto case "T";
					default:
						Console.WriteLine ("DAS NOT A CALSS SIR");
						break;
					}
				}
				rolled:
				Console.WriteLine ("============");
				Console.WriteLine ("PLAYER STATS");
				Console.WriteLine ("============");
				Console.WriteLine ("Name: {0}", player.myname);
				Console.WriteLine ("Strength: {0}", player.stat_strength);
				Console.WriteLine ("Intelligence: {0}", player.stat_intelligence);
				Console.WriteLine ("Agility: {0}", player.stat_agility);
				Console.WriteLine ("ARE YOU THE HERO YOU SAY YOU ARE? (y/n)");
				heroreroll = Console.ReadLine ();
				switch (heroreroll) {
				case "n":
					Console.WriteLine ("WHO ARE YOU, REALLY?");
					break;
				case "N":
					Console.WriteLine ("WHO ARE YOU, REALLY?");
					break;
				case "r":
					player = new Warrior (playername);
					goto rolled;
				default:
					Console.WriteLine ("THEN LET US BEGIN...");
					characterchosen = true;
					break;
				}
			}
			Console.Clear ();
			Console.WriteLine ("You begin in the dungeons of Detroit, in a cell only big enough for you and the eight corpses you're being smothered with.\n" +
				"However, fate has shone upon you, for Lord Godrod Hairy-Breeks summons you to Castle Frankenbaum for an audience.\n" +
				"'You are one lucky peasant, {0}, for we have had to place another corpse in the dungeon cell you occupied. As we have no other cells,\n" +
				"you will be my personal courier and knight. As of now, I have no tasks for you to complete. Rather, you should gather experience for yourself\n" +
				"out in the world. Find princesses to fuck, merchants to hustle out of their money, and horses to practice sexual intercourse with.\n" +
				"Basically, get the fuck out of my castle.\n'" +
				"==========================================\n" +
				"1. Exit the castle doors\n" +
				"2. Stare at Lord Godrod\n" +
				"3. Say 'ok, mom'", player.myname);
			int answer = Convert.ToInt32 (Console.ReadLine ());
			switch (answer) {
			case 1:
				goto default;
			case 2:
				goto default;
			case 3:
				goto default;
			default:
				Console.WriteLine ("Godrod Hairy-Breeks: 'YOU DARE TO BE SNIPPY WITH ME?! YOU WILL BE TAUGHT BY MY FAT WIENER WHAT RESPECT IS! PREPARE FOR THE ANAL RAVAGING OF YOUR LIFETIME, PEASANT!'\n" +
					"Lord Godrod tears off his leathers in fury, and begins to storm towards you with his dong dragging across the carpeted floor...");
				player.Die ();
				break;
			}
		}
	}
}