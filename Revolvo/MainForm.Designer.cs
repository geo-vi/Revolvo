namespace Revolvo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.map = new System.Windows.Forms.PictureBox();
            this.mapTimer = new System.Windows.Forms.Timer(this.components);
            this.logoRotation = new System.Windows.Forms.Timer(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.openMenu = new System.Windows.Forms.Button();
            this.helpBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.Black;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Location = new System.Drawing.Point(0, 31);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(400, 269);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMap);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // mapTimer
            // 
            this.mapTimer.Enabled = true;
            this.mapTimer.Interval = 64;
            this.mapTimer.Tick += new System.EventHandler(this.TickMap);
            // 
            // logoRotation
            // 
            this.logoRotation.Enabled = true;
            this.logoRotation.Tick += new System.EventHandler(this.logoRotation_Tick);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.header.Controls.Add(this.openMenu);
            this.header.Controls.Add(this.helpBttn);
            this.header.Controls.Add(this.exitBttn);
            this.header.Controls.Add(this.title);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(400, 31);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // openMenu
            // 
            this.openMenu.FlatAppearance.BorderSize = 0;
            this.openMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.openMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMenu.ForeColor = System.Drawing.Color.White;
            this.openMenu.Location = new System.Drawing.Point(309, 2);
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(21, 28);
            this.openMenu.TabIndex = 3;
            this.openMenu.TabStop = false;
            this.openMenu.Text = ">";
            this.openMenu.UseVisualStyleBackColor = true;
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // helpBttn
            // 
            this.helpBttn.FlatAppearance.BorderSize = 0;
            this.helpBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.helpBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.helpBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBttn.ForeColor = System.Drawing.Color.White;
            this.helpBttn.Location = new System.Drawing.Point(336, 2);
            this.helpBttn.Name = "helpBttn";
            this.helpBttn.Size = new System.Drawing.Size(21, 28);
            this.helpBttn.TabIndex = 2;
            this.helpBttn.TabStop = false;
            this.helpBttn.Text = "?";
            this.helpBttn.UseVisualStyleBackColor = true;
            this.helpBttn.Click += new System.EventHandler(this.helpBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.FlatAppearance.BorderSize = 0;
            this.exitBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.exitBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBttn.ForeColor = System.Drawing.Color.White;
            this.exitBttn.Location = new System.Drawing.Point(360, 2);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(40, 28);
            this.exitBttn.TabIndex = 1;
            this.exitBttn.TabStop = false;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(10, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(136, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Revolvo Experimental Build";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.map);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "Revolvo";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Timer mapTimer;
        private System.Windows.Forms.Timer logoRotation;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Button helpBttn;
        private System.Windows.Forms.Button openMenu;
    }
}

