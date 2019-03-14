using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolvo.UI.map
{
    static class Draw
    {
        /// <summary>
        /// Draws log
        /// </summary>
        /// <param name="e"></param>
        public static void Log(PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 7))
            {
                int lastY = 2;
                SizeF size = e.Graphics.MeasureString("H", myFont);

                var log = Output.Log.Skip(Math.Max(0, Output.Log.Count() - 10));
                foreach (var loggedText in log)
                {
                    e.Graphics.DrawString(loggedText.Text, myFont, new SolidBrush(loggedText.Color), new Point(2, (int)(lastY + size.Height + 2)));
                    lastY = (int)(lastY + size.Height);
                }
            }
        }

        /// <summary>
        /// Draws command (/asd)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="e"></param>
        public static void Command(string text, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 8))
            {
                SizeF size = e.Graphics.MeasureString("H", myFont);
                e.Graphics.DrawString(text, myFont, new SolidBrush(Color.Aqua), new Point(2, (int)(269 - size.Height - 2)));
            }
        }

        /// <summary>
        /// Draws the logo
        /// </summary>
        /// <param name="image"></param>
        /// <param name="e"></param>
        public static void Logo(Image image, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, new PointF((float)158.5, (float)107.5));
        }

        public static void MapText(string mapName, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 12))
            {
                StringFormat format = new StringFormat();
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString(mapName, myFont, new SolidBrush(Color.White), new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height + 100), format);
            }
        }
    }
}
