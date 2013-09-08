using System;

namespace THE_LEGEND_OF_GODROD_HAIRYBREEKS
{
	public abstract class Hero
	{
		protected Random RND = new Random ();
		//stats
		public int health;
		public int magicka;
		public int encumbrance;
		public int stat_agility;
		public int stat_endurance;
		public int stat_intelligence;
		public int stat_luck;
		public int stat_personality;
		public int stat_speed;
		public int stat_strength;
		public int stat_willpower;
		public string myname;
		public Hero ()
		{
		}
		public void Die ()
		{
			throw new Exception("u ded");
		}
	}

	public class Warrior : Hero
	{
		public Warrior (string name)
		{
			stat_strength = RND.Next (8, 17);
			stat_intelligence = RND.Next (2, 9);
			stat_agility = RND.Next (2, 9);
			myname = name;
		}
	}

	public class Mage : Hero
	{
		public Mage (string name)
		{
			stat_strength = RND.Next (2, 9);
			stat_intelligence = RND.Next (8, 17);
			stat_agility = RND.Next (2, 9);
			myname = name;
		}
	}

	public class Thief : Hero
	{
		public Thief (string name)
		{
			stat_strength = RND.Next (2, 9);
			stat_intelligence = RND.Next (2, 9);
			stat_agility = RND.Next (8, 17);
			myname = name;
		}
	}
}

