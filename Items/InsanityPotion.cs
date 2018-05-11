using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InsanityBuff.Items
{
	public class InsanityPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Insanity Potion");
			Tooltip.SetDefault("Greatly boosts spawn rates");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.useTurn = true;
			item.maxStack = 30;
			item.rare = 1;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
			item.buffType = mod.BuffType("Insanity");
			item.buffTime = 7 * (60 * 60); // 7 minutes
			item.value = Item.sellPrice(0, 0, 2, 50);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BattlePotion);
			recipe.AddIngredient(ItemID.Moonglow);
			recipe.AddIngredient(ItemID.VilePowder);
			recipe.AddIngredient(ItemID.Obsidian);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
