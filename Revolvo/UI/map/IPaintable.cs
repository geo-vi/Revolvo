using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.UI.map
{
    abstract class IPaintable
    {
        public Color Color { get; }

        public Point Position { get; }

        public IPaintable(Color color, Point pos)
        {
            Color = color;
            Position = pos;
        }

        public abstract void Paint(Graphics gfx);
    }
}
