using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SummonerAdditions.Items.Accessories
{
    [AutoloadEquip(EquipType.HandsOn)]
    class LivingBand : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increased minion damage and life regeneration");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 72, 0);
            item.rare = ItemRarityID.Orange;

            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.BandofRegeneration);
            recipe.AddIngredient(ItemID.Vine, 6);
            recipe.AddIngredient(ModContent.ItemType<LivingSpore>());
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {

            player.minionDamage *= 1.12f;
            player.lifeRegen += 2;

        }

    }
}
