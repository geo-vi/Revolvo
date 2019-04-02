using Revolvo.Main;
using Revolvo.UI;
using Revolvo.Utils;
using RevolvoCore.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolvo
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            LogoRotation.SetLogo(Revolvo);
            Output.MaxLenght = 420;
        }

        /// <summary>
        /// Resized logo
        /// </summary>
        public Image Revolvo => RevolvoImg.ScaleImage(Properties.Resources.icon, 115, 115);

        private void baseTimer_Tick(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
            baseTimer.Enabled = false;

            if (Output.Log.Count > 0)
                loadingProgress.Text = Output.Log.LastOrDefault().Text;

        }

        private DateTime LastSlowdown = new DateTime();
        private double RotationSpeed = 1.0;
        private void logoRotation_Tick(object sender, EventArgs e)
        {
            if (!Visible) logoRotation.Enabled = false;
            logoRotation.Interval = (int)(RotationSpeed * 0.74 + 10);
            if (LastSlowdown.AddSeconds(1) >= DateTime.Now)
            {
                RotationSpeed = 0.175;
            }
            else if (LastSlowdown.AddSeconds(2) >= DateTime.Now)
            {
                RotationSpeed = 0.1;
            }
            else if (LastSlowdown.AddSeconds(3) >= DateTime.Now)
            {
                RotationSpeed = 0.175;
            }
            else
            {
                RotationSpeed = 0.25;
                LastSlowdown = DateTime.Now;
            }

            LogoRotation.Rotate(Revolvo, RotationSpeed);
            icon.Image = LogoRotation.Logo;
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loader_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Loader_MouseDown(object sender, MouseEventArgs e)
        {
            DragAndDrop.Initiate(this, this, sender, e);
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
