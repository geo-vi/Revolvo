namespace Revolvo
{
    partial class Loader
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
            this.closeBttn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.loadingProgress = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.baseTimer = new System.Windows.Forms.Timer(this.components);
            this.logoRotation = new System.Windows.Forms.Timer(this.components);
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBttn
            // 
            this.closeBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBttn.FlatAppearance.BorderSize = 0;
            this.closeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBttn.Location = new System.Drawing.Point(397, 0);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(57, 27);
            this.closeBttn.TabIndex = 1;
            this.closeBttn.Text = "X";
            this.closeBttn.UseVisualStyleBackColor = false;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.contentPanel.Controls.Add(this.icon);
            this.contentPanel.Controls.Add(this.loadingProgress);
            this.contentPanel.Location = new System.Drawing.Point(0, 27);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(453, 237);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // icon
            // 
            this.icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.icon.Location = new System.Drawing.Point(171, 51);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(112, 115);
            this.icon.TabIndex = 5;
            this.icon.TabStop = false;
            // 
            // loadingProgress
            // 
            this.loadingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingProgress.AutoSize = true;
            this.loadingProgress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadingProgress.Location = new System.Drawing.Point(168, 173);
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.Size = new System.Drawing.Size(88, 13);
            this.loadingProgress.TabIndex = 4;
            this.loadingProgress.Text = "Loading progress";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(12, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(110, 13);
            this.title.TabIndex = 4;
            this.title.Text = "Revolvo Experimental";
            // 
            // baseTimer
            // 
            this.baseTimer.Enabled = true;
            this.baseTimer.Tick += new System.EventHandler(this.baseTimer_Tick);
            // 
            // logoRotation
            // 
            this.logoRotation.Enabled = true;
            this.logoRotation.Tick += new System.EventHandler(this.logoRotation_Tick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(455, 263);
            this.Controls.Add(this.title);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.closeBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.Opacity = 0.9D;
            this.Text = "Loader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loader_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loader_MouseDown);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBttn;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label loadingProgress;
        private System.Windows.Forms.Timer baseTimer;
        private System.Windows.Forms.Timer logoRotation;
        private System.Windows.Forms.PictureBox icon;
    }
}