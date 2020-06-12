using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SummonerAdditions.Items.Generic
{
    public class UnicornHairTuft : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tuft of Unicorn Hair");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 24;

            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = ItemRarityID.LightRed;
            item.maxStack = 99;
        }

    }

}