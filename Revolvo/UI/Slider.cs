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
    public partial class Slider : Form
    {
        public Form parentForm { get; }
        public Slider(Form parent, Image pic)
        {
            InitializeComponent();
            parentForm = parent;
            pictureBox1.Image = pic;
        }

        private void Slider_Shown(object sender, EventArgs e)
        {
            Width = 50;
            var pLocation = parentForm.Location;
            pLocation.X -= 50;
            pLocation.Y += 250;
            Location = pLocation;
            Opacity = 1;
            OpacityTimer.Enabled = true;
        }

        private void OpacityTimer_Tick(object sender, EventArgs e)
        {
            Output.WriteLine(Opacity.ToString());
            if (Opacity == 0)
            {
                OpacityTimer.Enabled = false;
                Hide();
                return;
            }
            Opacity -= 0.1;
            Refresh();
        }
    }
}
