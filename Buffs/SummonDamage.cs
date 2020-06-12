using Terraria;
using Terraria.ModLoader;

namespace SummonerAdditions.Buffs
{
    class SummonDamage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Strengthened Minions");
            Description.SetDefault("Minion damage increased by 20%");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.minionDamage *= 1.2f;
        }

    }
}
