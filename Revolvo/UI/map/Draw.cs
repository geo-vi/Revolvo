using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Revolvo.Bot.controllers;
using Revolvo.Bot.managers;
using Revolvo.Main;
using Revolvo.UI.map.objects;

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
            using (Font myFont = new Font("Arial", 12, FontStyle.Bold))
            {
                StringFormat format = new StringFormat();
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString(mapName, myFont, new SolidBrush(Color.FromArgb(100, Color.White)), new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height), format);
            }
        }

        public static void Position(PaintEventArgs e)
        {
            var pos = MovementController.ActualPosition(MainController.Instance.Player);
            var drawX = pos.X / 52;
            var drawY = (int)(pos.Y / 47.58364312267658);

            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, Color.White)), drawX, 0, drawX, e.ClipRectangle.Height); // y axis
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, Color.White)), 0, drawY, e.ClipRectangle.Width, drawY); // x axis
        }

        public static void MapAssets(PaintEventArgs e)
        {
            foreach (var portal in StorageManager.CurrentSpacemap.Portals)
            {
                var pos = portal.Value.Position.ToMapPoint();

                e.Graphics.DrawEllipse(new Pen(Color.White), pos.X - 5f, pos.Y - 5f, 15, 15);
                e.Graphics.FillEllipse(Brushes.White, pos.X, pos.Y, 5, 5);
            }

            foreach (var collectable in StorageManager.CurrentSpacemap.Collectables)
            {
                var collectablePaint = new CollectablePaint(collectable.Value);
                collectablePaint.Paint(e.Graphics);
            }
        }

        public static void PlayerInfo(PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 7, FontStyle.Bold))
            {
                StringFormat format = new StringFormat();
                format.LineAlignment = StringAlignment.Far;
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString(MainController.Instance.Player.Name, myFont, new SolidBrush(Color.FromArgb(200, Color.Cyan)), new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height), format);
            }

        }
    }
}
