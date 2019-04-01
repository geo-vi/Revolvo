using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.objects;
using Revolvo.Bot.objects.map;
using Revolvo.Main;

namespace Revolvo.UI.map.objects
{
    class CollectablePaint : IPaintable
    {
        private Collectable Collectable;

        public CollectablePaint(Bot.objects.map.Collectable collectable) : base(System.Drawing.Color.Black, collectable.Position.ToMapPoint())
        {
            Collectable = collectable;
        }

        public override void Paint(Graphics gfx)
        {
            var pos = Collectable.Position.ToMapPoint();
            switch (Collectable.Type)
            {
                case Collectables.BONUS_BOX:
                    gfx.FillEllipse(Brushes.Orange, pos.X, pos.Y, 5, 5);
                    using (Font myFont = new Font("Arial", 7, FontStyle.Bold))
                    {
                        gfx.DrawString("BB", myFont, new SolidBrush(Color.FromArgb(200, Color.Orange)), pos.X, pos.Y - 5f);
                    }
                    break;
                case Collectables.PIRATE_BOOTY_BOX:
                    gfx.FillEllipse(Brushes.GreenYellow, pos.X, pos.Y, 5, 5);
                    using (Font myFont = new Font("Arial", 7, FontStyle.Bold))
                    {
                        gfx.DrawString("PB", myFont, new SolidBrush(Color.FromArgb(200, Color.GreenYellow)), pos.X, pos.Y - 5f);
                    }
                    break;
            }
        }
    }
}
