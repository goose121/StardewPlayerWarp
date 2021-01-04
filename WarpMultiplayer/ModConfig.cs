using Microsoft.Xna.Framework.Input;
using StardewModdingAPI;
using System.Collections.Generic;

namespace WarpMultiplayer
{
	public class ModConfig
	{

		[OptionDisplay("Open Menu Key")]
		public SButton OpenMenuKey { get; set; } = SButton.J;
        
        [OptionDisplay("Allow Console Warp")]
		public bool CanConsoleWarp { get; set; } = true;
        
        [OptionDisplay("Key binding with format Key = quick click (1 or 0)")]
        public Dictionary<SButton, int> KeyBinding { get; set; } = new Dictionary<SButton, int>
        {
            [SButton.J] = 0,
            [SButton.RightStick] = 1
        };

    }
}
