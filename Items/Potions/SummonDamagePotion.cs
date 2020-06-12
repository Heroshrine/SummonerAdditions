using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using SummonerAdditions.Buffs;

namespace SummonerAdditions.Items.Potions
{
    class SummonDamagePotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Minion Strength Potion");
            Tooltip.SetDefault("Increase minion damage by 20%");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;

            item.value = Item.sellPrice(0, 0, 3, 0);
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.rare = ItemRarityID.Blue;
            item.maxStack = 30;

            item.useTime = 18;
            item.useAnimation = 18;

            item.UseSound = SoundID.Item3;
            item.noMelee = true;
            item.consumable = true;

            item.buffType = ModContent.BuffType<SummonDamage>();
            item.buffTime = 21600;
        }

        /*
        public override bool UseItem(Player player)
        {
            player.AddBuff(ModContent.BuffType<SummonDamage>(), 21600);
            return true;
        }
        */

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.VariegatedLardfish);
            recipe.AddIngredient(ItemID.CrystalShard, 3);
            recipe.AddIngredient(ItemID.Deathweed);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}