using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolvo.UI
{
    static class DragAndDrop
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void Initiate(Form tab, Form parent, object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tab == parent)
                {
                    ReleaseCapture();
                    SendMessage(parent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
                else
                {
                    parent.Hide();
                    ReleaseCapture();
                    SendMessage(tab.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    parent.Location = tab.Location;
                    parent.Show();
                    tab.Focus();
                }
            }
        }
    }
}
