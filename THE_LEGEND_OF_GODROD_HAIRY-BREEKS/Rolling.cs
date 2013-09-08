using System;

namespace THE_LEGEND_OF_GODROD_HAIRYBREEKS
{
	public abstract class Hero
	{
		protected Random RND = new Random ();
		//
		public string myname;
		public int health;
		public int magicka;
		public int encumbrance;
		//
		public int stat_agility;
		public int stat_endurance;
		public int stat_intelligence;
		public int stat_luck;
		public int stat_personality;
		public int stat_speed;
		public int stat_strength;
		public int stat_willpower;
		//
		public int skill_block;
		public int skill_heavyweap;
		public int skill_lightweap;
		public int skill_restoration;
		public int skill_destruction;
		public int skill_alteration;
		//
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
			myname = name;
			health = 150;
			magicka = 50;
			encumbrance = 200;
			//major stats
			stat_endurance = 20;
			stat_strength = 20;
			skill_heavyweap = 20;
			//minor stats
			stat_personality = 10;
			stat_willpower = 10;
			skill_block = 10;
			skill_lightweap = 10;
			skill_restoration = 10;
			//other stats
			stat_agility = 5;
			stat_intelligence = 5;
			stat_luck = 5;
			stat_speed = 5;
			skill_destruction = 5;
			skill_alteration = 5;
		}
	}

	public class Mage : Hero
	{
		public Mage (string name)
		{
			myname = name;
			health = 100;
			magicka = 200;
			encumbrance = 50;
			//major stats
			stat_intelligence = 20;
			stat_willpower = 20;
			skill_restoration = 15;
			skill_destruction = 15;
			skill_alteration = 15;
			//minor stats
			stat_agility = 10;
			stat_endurance = 10;
			stat_speed = 10;
			skill_lightweap = 10;
			//other stats
			stat_luck = 5;
			stat_personality = 5;
			stat_strength = 5;
			skill_block = 5;
			skill_heavyweap = 5;
		}
	}

	public class Thief : Hero
	{
		public Thief (string name)
		{
			myname = name;
			health = 100;
			magicka = 50;
			encumbrance = 100;
			//major stats
			stat_agility = 20;
			stat_speed = 20;
			skill_lightweap = 20;
			//minor stats
			stat_luck = 10;
			stat_personality = 10;
			stat_strength = 10;
			skill_heavyweap = 10;
			skill_alteration = 10;
			//other stats
			stat_endurance = 5;
			stat_intelligence = 5;
			stat_willpower = 5;
			skill_block = 5;
			skill_restoration = 5;
			skill_destruction = 5;
		}
	}
}

