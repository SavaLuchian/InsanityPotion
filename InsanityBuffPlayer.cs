using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace InsanityBuff
{
	public class InsanityBuffPlayer : ModPlayer
	{
		public bool Insanity;

		public override void ResetEffects()
		{
			Insanity = false;
		}

		public override void UpdateDead()
		{
			Insanity = false;
		}
	}
}
