using SummonerAdditions.Items.Generic;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SummonerAdditions.Items.Accessories
{
    class RainbowTotem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increase minion damage by 10%" + "\nIncreases maximum number of minions" + "\nCannot be used with other totems");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;

            item.rare = ItemRarityID.LightRed;
            item.value = Item.sellPrice(0, 8, 24, 0);

            item.accessory = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<RainbowTotem>())
            {
                foreach (TooltipLine line in tooltips)
                {
                    if (line.Name == "Tooltip2")
                    {
                        line.overrideColor = Colors.RarityRed;
                    }
                }

            }
        }

        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (player.GetModPlayer<PlayerTotemValues>().modTotemEquipped)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage *= 1.1f;
            player.maxMinions += 1;

            player.GetModPlayer<PlayerTotemValues>().modTotemEquipped = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.Pearlwood, 26);
            recipe.AddIngredient(ItemID.CrystalShard, 16);
            recipe.AddIngredient(ItemID.PixieDust, 8);
            recipe.AddIngredient(ItemID.SoulofLight, 4);
            recipe.AddIngredient(ModContent.ItemType<UnicornHairTuft>());

            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
