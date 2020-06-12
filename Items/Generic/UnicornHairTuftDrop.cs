using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SummonerAdditions.Items.Generic
{
    class UnicornHairTuftDrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Unicorn)
            {
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width / 2, npc.height / 2, ModContent.ItemType<UnicornHairTuft>());
                }
            }
        }
    }
}
