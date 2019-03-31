using System;
using System.Drawing;
using System.Windows.Forms;
using Revolvo.Utils;
using Revolvo.UI.map;
using Revolvo.UI;
using Revolvo.Main;
using System.Threading.Tasks;

namespace Revolvo
{
    public partial class MainForm : Form
    {
        private KeyHandler ghk;

        public MainForm()
        {
            ghk = new KeyHandler(Keys.End, this);
            ghk.Register();

            InitializeComponent();
            InitializeBot();

            CommandMonitor.Add();
        }

        public void InitializeBot()
        {
            LogoRotation.SetLogo(Revolvo);
            //            map.ImageLocation = "http://darkorbit.bg/spacemap/graphics/minimaps/minimap-" + MainController.Instance.MapId + "-700.jpg";
        }

        /// <summary>
        /// Resized logo
        /// </summary>
        public Image Revolvo => RevolvoImg.ScaleImage(Properties.Resources.icon, 83, 85);

        #region Temp variables
        public static bool Connected = false;
        #endregion

        #region Map
        private void PaintMap(object sender, PaintEventArgs e)
        {
            if (Properties.Visuals.SHOWING_LOG)
                Draw.Log(e);
            if (CommandMode)
                Draw.Command(RecordedText, e);
            if (!Connected)
            {
                Draw.Logo(LogoRotation.Logo, e);
                Draw.MapText("PENDING", e);
                return;
            }
            //TODO:: ADD
        }

        private void TickMap(object sender, EventArgs e)
        {
            map.Refresh();
        }

        private DateTime LastSlowdown = new DateTime();
        private double RotationSpeed = 1.0;
        private void logoRotation_Tick(object sender, EventArgs e)
        {
            logoRotation.Interval = (int)(RotationSpeed * 0.74 + 1);
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
        }
        #endregion

        #region Form Utils
        private void OnLoad(object sender, EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            MainController.Instance.CloseProxy();
        }

        private void OnFormClosed(object s, EventArgs e)
        {
            MainController.Instance.CloseProxy();
        }

        private void MoveWindow(object sender, MouseEventArgs e)
        {
            DragAndDrop.Initiate(this, this, sender, e);
        }

        #region Hotkey Handler (Switching tabs)
        private void HandleHotkey()
        {
            if (Visible)
                MainForm_KeyDown(this, new KeyEventArgs(Keys.End));
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == KeyHandler.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
        #endregion
        #endregion

        #region Key Handler
        #region Command recognizer
        private bool CommandMode = false;
        private string RecordedText = "";

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                if (CommandMode)
                {
                    RecordedText = "";
                    CommandMode = false;
                }
                else
                {
                    CommandMode = true;
                    RecordedText = "/";
                }
            }
            if (CommandMode)
            {
                if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))
                {
                    RecordedText += e.KeyChar;
                }
            }
        }
        #endregion

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (CommandMode)
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (RecordedText.Length > 1)
                        RecordedText = RecordedText.Remove(RecordedText.Length - 1);
                }
                else if (e.KeyCode == Keys.Space)
                {
                    RecordedText += ' ';
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    CommandMode = false;
                    SubmitCommand();
                }
            }
            Tab.HandleKey(this, this, sender, e);
        }
        #endregion

        #region Command Handler
        public void SubmitCommand()
        {
            var cmd = RecordedText;
            CommandMonitor.Handle(cmd);
            RecordedText = "";
        }
        #endregion

        #region Buttons
        private void exitBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpBttn_Click(object sender, EventArgs e)
        {
            Notification.Custom(this, "To switch tabs press [END]");
        }
        #endregion

        private void map_Click(object sender, EventArgs e)
        {

        }
    }
}
