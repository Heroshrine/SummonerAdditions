using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SummonerAdditions.Items.Accessories
{
    class PygmyTotem : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases minion damage by 15%" + "\nSlightly increases minion knockback" + "\nIncreases maximum number of minions by 2" + "\nIncreased life regeneration" + "\nCannot be used with other totems");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;

            item.rare = ItemRarityID.Lime;
            item.value = Item.sellPrice(0, 16, 25, 0);

            item.accessory = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<PygmyTotem>())
            {
                foreach (TooltipLine line in tooltips)
                {
                    if (line.Name == "Tooltip4")
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
            player.minionDamage *= 1.15f;
            player.minionKB *= 1.06f;
            player.maxMinions += 2;

            player.GetModPlayer<PlayerTotemValues>().modTotemEquipped = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<LivingTotem>());
            recipe.AddIngredient(ItemID.PygmyNecklace);
            recipe.AddIngredient(ItemID.ChlorophyteOre, 12);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
