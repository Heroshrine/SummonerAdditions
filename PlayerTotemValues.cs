using Terraria.ModLoader;

namespace SummonerAdditions
{
    class PlayerTotemValues : ModPlayer
    {
        public bool modTotemEquipped;

        public override void ResetEffects()
        {
            modTotemEquipped = false;
        }

    }
}
