using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewValley.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpMultiplayer.UI
{
    class Confirm
    {
        public Farmer farmer;
        public long PlayerID { get; set; }
        public ClickableComponent confirmButton;
        public ClickableComponent cancelButton;
        public ClickableComponent section;
        public bool online;

        public Confirm(Farmer f)
        {
            farmer = f;
            checkOnline();
        }

        private void checkOnline()
        {
            online = Game1.getOnlineFarmers().Any(o => o == farmer);
        }

        public void draw(SpriteBatch b)
        {
            checkOnline();

            IClickableMenu.drawTextureBox(b, Game1.mouseCursors, new Rectangle(384, 396, 15, 15),
                section.bounds.X, section.bounds.Y, section.bounds.Width, section.bounds.Height, Color.White, 4f, false);

            string nameT = $"Bring request from {farmer.Name}";
            string locaT = "Confirm ?";

            Utility.drawTextWithShadow(b, nameT, Game1.smallFont, new Vector2(section.bounds.Center.X, section.bounds.Y + 22), Game1.textColor);
            Utility.drawTextWithShadow(b, locaT, Game1.smallFont, new Vector2(section.bounds.Center.X, section.bounds.Y + 22 + 50), Game1.textColor);

            if (Game1.player == farmer) return;
            Color color = (confirmButton.containsPoint(Game1.getMouseX(), Game1.getMouseY())) ? Color.Wheat : Color.White;
            UtilityPlus.drawButtonWithText(b, confirmButton.bounds, (online) ? color : Color.Gray, "Accept", Game1.smallFont, Game1.textColor);
            UtilityPlus.drawButtonWithText(b, cancelButton.bounds, (online) ? color : Color.Gray, "Decline", Game1.smallFont, Game1.textColor);

        }
    }
}
