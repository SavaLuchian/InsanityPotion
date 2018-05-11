using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace InsanityBuff.Buffs
{
	public class Insanity : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Insanity");
			Description.SetDefault("Greatly boosted spawn rates");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = false;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<InsanityBuffPlayer>(mod).Insanity = true;
		}
	}
}
