using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace InsanityBuff
{
	public class InsanityBuffGlobalNPC : GlobalNPC
	{
		public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
		{
			if (player.GetModPlayer<InsanityBuffPlayer>(mod).Insanity)
			{
				spawnRate = (int) ((double) spawnRate * 0.01);
				maxSpawns = (int) ((float) maxSpawns * 5.0f);
			}
		}
	}
}
