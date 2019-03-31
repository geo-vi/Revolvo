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

        private void DownloadSWF()
        {
            Console.WriteLine("Downloading main.swf");
            WebClient client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += (o, e) => 
            {
                Console.WriteLine("Download completed.");
                ChecksumSWF();
            };
            client.DownloadFileAsync(new Uri("http://play.univ3rse.com/spacemap/main.swf"), Directory.GetCurrentDirectory() + "/main.swf");
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            Console.WriteLine("Completed %: " + percentage);
        }

        private async void ChecksumSWF()
        {
            //var swf = Directory.GetCurrentDirectory() + "/main.swf";
            //var hash = MD5.Get(swf);
            //var file = new FileInfo(swf);
            //if (file.Length == 0)
            //{
            //    Console.WriteLine("Failed to download swf");
            //    File.Delete(swf);
            //    for (int i= 5; i != 0; i--)
            //    {
            //        Console.WriteLine("Closing in " + i);
            //        await Task.Delay(1000);
            //    }
            //    Close();
            //    return;
            //}

            //if (hash == RevolvoCore.Properties.Core.SUPPORTED_MD5_VER)
            //{
                MainController.Instance.Init();
                Console.WriteLine("Waiting for MapRevolution");
            //}
            //else Console.WriteLine("Please wait for the update to get confirmed");
            //File.Delete(swf);
        }

        public bool Initiated = false;

        private void baseTimer_Tick(object sender, EventArgs e)
        {
            if (!Initiated)
            {
                DownloadSWF();
                Initiated = true;
            }
            if (MainController.Instance.MapId != 0)
            {
                var mainForm = new MainForm();
                mainForm.Show();
                Hide();
                baseTimer.Enabled = false;
            }
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
            MainController.Instance.CloseProxy();
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
