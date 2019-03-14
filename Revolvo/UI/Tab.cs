using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolvo.UI
{
    class Tab
    {
        private const short MAP = 0;
        private const short OPTIONS = 1;
        private const short SETTINGS = 2;

        private static int Current = 0;

        private static Form FormShown = null;

        public static void Activate(Form parent, int id)
        {
            switch (id)
            {
                case OPTIONS:
                    new Slider(parent, Properties.Resources.options).Show();
                    FormShown = new OptionsForm(parent);
                    FormShown.Show();
                    break;
                default:
                    new Slider(parent, Properties.Resources.home).Show();
                    parent.Focus();
                    if (FormShown != null)
                    {
                        FormShown.Hide();
                        FormShown = null;
                    }
                    break;
            }
        }

        public static void HandleKey(Form current, Form parent, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                if (Current == 2)
                    Current = 0;
                else Current++;

                Activate(parent, Current);
            }
        }
    }
}
