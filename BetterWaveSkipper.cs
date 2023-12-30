using Terraria.ModLoader;

namespace BetterWaveSkipper
{
	public class BetterWaveSkipper : Mod
	{
        public static int WaveSkipperType;
        public static BetterWaveSkipper Instance;
        public override void Load() {
            Instance = this;
        }
        public override void PostSetupContent() {
            WaveSkipperType = ModContent.ItemType<CalamityMod.Items.Weapons.Rogue.WaveSkipper>();
        }
    }
}