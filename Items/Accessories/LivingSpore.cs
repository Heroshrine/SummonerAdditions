using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SummonerAdditions.Items.Accessories
{
    public class LivingSpore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases minion damage");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(24);
            item.value = Item.sellPrice(0, 0, 63, 46);
            item.rare = ItemRarityID.Green;

            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {

            player.minionDamage *= 1.1f;

        }

    }

}
