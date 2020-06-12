using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SummonerAdditions.Items.Accessories
{
    class LivingSporeDrop : GlobalTile
    {

        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (!noItem && type == TileID.JunglePlants && Main.tile[i, j].frameX == 144)
            {
                if (Main.rand.Next(25) < 2)
                {
                    Item.NewItem(i * 16, j * 16, 16, 16, ModContent.ItemType<LivingSpore>());
                    noItem = true;
                }
            }
        }

    }
}
