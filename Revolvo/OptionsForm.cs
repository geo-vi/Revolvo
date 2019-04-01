using Revolvo.UI;
using Revolvo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolvo
{
    public partial class OptionsForm : Form
    {
        private Form parentForm { get; }

        public OptionsForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void OptionsForm_Shown(object sender, EventArgs e)
        {
            Location = parentForm.Location;
            UpdateVariables();
        }

        private void UpdateVariables()
        {
            showingLog.Checked = Properties.Visuals.SHOWING_LOG;
        }

        private void OptionsForm_MouseDown(object sender, MouseEventArgs e)
        {
            DragAndDrop.Initiate(this, parentForm, sender, e);
        }

        private void showingLog_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Visuals.SHOWING_LOG = showingLog.Checked;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            (parentForm as MainForm).openMenu_Click(sender, e);
        }
    }
}
