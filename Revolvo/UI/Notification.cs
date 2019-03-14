using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolvo.UI
{
    public partial class Notification : Form
    {
        public Notification(Form parent, string text, Image image, Color bgColor)
        {
            InitializeComponent();
            
            label1.Text = text;
            if (image != null)
                icon.Image = image;
            if (bgColor != null)
                icon.BackColor = bgColor;

            timer.Enabled = true;
            Show();

            Notifications++;

            var pLocation = parent.Location;

            if (Notifications > 1)
                pLocation.Y -= 32 * Notifications;
            else pLocation.Y -= 32;
            Location = pLocation;
            parent.Focus();
        }

        public static int Notifications = 0;

        public static void Error(Form parent, string text = "Error")
        {
            new Notification(parent, text, Properties.Resources.error, Color.IndianRed);
        }

        public static void Success(Form parent, string text = "Success")
        {
            new Notification(parent, text, Properties.Resources.tick, Color.LightGreen);
        }

        public static void Custom(Form parent, string text, Color color = new Color(), Image img = null)
        {
            new Notification(parent, text, img, color);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                HideNotification();
                return;
            }
            Opacity -= 0.01;
            Refresh();
        }

        private void Notification_MouseDown(object sender, MouseEventArgs e)
        {
            HideNotification();
        }

        public void HideNotification()
        {
            timer.Enabled = false;
            Hide();
            Notifications--;
        }
    }
}
