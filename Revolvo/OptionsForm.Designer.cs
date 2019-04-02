namespace Revolvo
{
    partial class OptionsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 27D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 28D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 24D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 30D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 15D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 4D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pvp = new System.Windows.Forms.TabPage();
            this.anticamoBox = new System.Windows.Forms.GroupBox();
            this.anticamo_title = new System.Windows.Forms.CheckBox();
            this.anticamo_npc = new System.Windows.Forms.CheckBox();
            this.anticamo_friendly = new System.Windows.Forms.CheckBox();
            this.anticamo = new System.Windows.Forms.CheckBox();
            this.miscBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.autoRocket = new System.Windows.Forms.CheckBox();
            this.rsbchanger = new System.Windows.Forms.CheckBox();
            this.autolockBox = new System.Windows.Forms.GroupBox();
            this.autolock_closer_prior = new System.Windows.Forms.RadioButton();
            this.autolock_hp_prior = new System.Windows.Forms.RadioButton();
            this.autolock_allies = new System.Windows.Forms.CheckBox();
            this.autolock_npc = new System.Windows.Forms.CheckBox();
            this.lockrangelabel = new System.Windows.Forms.Label();
            this.lockrange = new System.Windows.Forms.TrackBar();
            this.autolock = new System.Windows.Forms.CheckBox();
            this.bot = new System.Windows.Forms.TabPage();
            this.collectableCollectorGroup = new System.Windows.Forms.GroupBox();
            this.collectablesList = new System.Windows.Forms.CheckedListBox();
            this.collector_Enabled = new System.Windows.Forms.CheckBox();
            this.ggGroup = new System.Windows.Forms.GroupBox();
            this.gg_DroneFormationGroup = new System.Windows.Forms.GroupBox();
            this.dflabel2 = new System.Windows.Forms.Label();
            this.dflabel1 = new System.Windows.Forms.Label();
            this.GG_EndFormation = new System.Windows.Forms.ComboBox();
            this.GG_BattleFormation = new System.Windows.Forms.ComboBox();
            this.dflabel3 = new System.Windows.Forms.Label();
            this.GG_RunFormation = new System.Windows.Forms.ComboBox();
            this.gg_Config = new System.Windows.Forms.ComboBox();
            this.ggConfigLabel = new System.Windows.Forms.Label();
            this.gg_Enabled = new System.Windows.Forms.CheckBox();
            this.NpcKillerGroup = new System.Windows.Forms.GroupBox();
            this.npcKiller_Config = new System.Windows.Forms.ComboBox();
            this.npcKiller_ConfigLabel = new System.Windows.Forms.Label();
            this.npcKiller_AutoCubiGroup = new System.Windows.Forms.GroupBox();
            this.autoCubi_Flee = new System.Windows.Forms.CheckBox();
            this.autoCubi_UseKami = new System.Windows.Forms.CheckBox();
            this.autoCubi_Abilities = new System.Windows.Forms.CheckBox();
            this.autoCubi_Enabled = new System.Windows.Forms.CheckBox();
            this.npcKiller_Flee = new System.Windows.Forms.CheckBox();
            this.NpcListlabel = new System.Windows.Forms.Label();
            this.npcList = new System.Windows.Forms.CheckedListBox();
            this.npcKiller_Enabled = new System.Windows.Forms.CheckBox();
            this.visuals = new System.Windows.Forms.TabPage();
            this.showingLog = new System.Windows.Forms.CheckBox();
            this.performance = new System.Windows.Forms.TabPage();
            this.networkUsage = new System.Windows.Forms.Label();
            this.runtime = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.ramUsage = new System.Windows.Forms.Label();
            this.performanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.info = new System.Windows.Forms.TabPage();
            this.info_6 = new System.Windows.Forms.Label();
            this.info_changelog = new System.Windows.Forms.RichTextBox();
            this.info_5 = new System.Windows.Forms.Label();
            this.info_4 = new System.Windows.Forms.LinkLabel();
            this.info_3 = new System.Windows.Forms.Label();
            this.info_2 = new System.Windows.Forms.Label();
            this.info_1 = new System.Windows.Forms.Label();
            this.profiles = new System.Windows.Forms.TabPage();
            this.loadProfile = new System.Windows.Forms.Button();
            this.profileTextBox = new System.Windows.Forms.TextBox();
            this.deleteProfile = new System.Windows.Forms.Button();
            this.saveProfile = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.profilesBox = new System.Windows.Forms.ListBox();
            this.performanceTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.pvp.SuspendLayout();
            this.anticamoBox.SuspendLayout();
            this.miscBox.SuspendLayout();
            this.autolockBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockrange)).BeginInit();
            this.bot.SuspendLayout();
            this.collectableCollectorGroup.SuspendLayout();
            this.ggGroup.SuspendLayout();
            this.gg_DroneFormationGroup.SuspendLayout();
            this.NpcKillerGroup.SuspendLayout();
            this.npcKiller_AutoCubiGroup.SuspendLayout();
            this.visuals.SuspendLayout();
            this.performance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceChart)).BeginInit();
            this.info.SuspendLayout();
            this.profiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pvp);
            this.tabControl.Controls.Add(this.bot);
            this.tabControl.Controls.Add(this.visuals);
            this.tabControl.Controls.Add(this.performance);
            this.tabControl.Controls.Add(this.info);
            this.tabControl.Controls.Add(this.profiles);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(400, 300);
            this.tabControl.TabIndex = 0;
            // 
            // pvp
            // 
            this.pvp.Controls.Add(this.anticamoBox);
            this.pvp.Controls.Add(this.miscBox);
            this.pvp.Controls.Add(this.autolockBox);
            this.pvp.Location = new System.Drawing.Point(4, 22);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(392, 274);
            this.pvp.TabIndex = 2;
            this.pvp.Text = "PVP";
            this.pvp.UseVisualStyleBackColor = true;
            // 
            // anticamoBox
            // 
            this.anticamoBox.Controls.Add(this.anticamo_title);
            this.anticamoBox.Controls.Add(this.anticamo_npc);
            this.anticamoBox.Controls.Add(this.anticamo_friendly);
            this.anticamoBox.Controls.Add(this.anticamo);
            this.anticamoBox.Enabled = false;
            this.anticamoBox.Location = new System.Drawing.Point(196, 15);
            this.anticamoBox.Name = "anticamoBox";
            this.anticamoBox.Size = new System.Drawing.Size(185, 99);
            this.anticamoBox.TabIndex = 2;
            this.anticamoBox.TabStop = false;
            this.anticamoBox.Text = "Anti camo";
            // 
            // anticamo_title
            // 
            this.anticamo_title.AutoSize = true;
            this.anticamo_title.Location = new System.Drawing.Point(102, 29);
            this.anticamo_title.Name = "anticamo_title";
            this.anticamo_title.Size = new System.Drawing.Size(46, 17);
            this.anticamo_title.TabIndex = 3;
            this.anticamo_title.Text = "Title";
            this.anticamo_title.UseVisualStyleBackColor = true;
            // 
            // anticamo_npc
            // 
            this.anticamo_npc.AutoSize = true;
            this.anticamo_npc.Location = new System.Drawing.Point(102, 61);
            this.anticamo_npc.Name = "anticamo_npc";
            this.anticamo_npc.Size = new System.Drawing.Size(53, 17);
            this.anticamo_npc.TabIndex = 2;
            this.anticamo_npc.Text = "NPCs";
            this.anticamo_npc.UseVisualStyleBackColor = true;
            // 
            // anticamo_friendly
            // 
            this.anticamo_friendly.AutoSize = true;
            this.anticamo_friendly.Location = new System.Drawing.Point(18, 61);
            this.anticamo_friendly.Name = "anticamo_friendly";
            this.anticamo_friendly.Size = new System.Drawing.Size(62, 17);
            this.anticamo_friendly.TabIndex = 1;
            this.anticamo_friendly.Text = "Friendly";
            this.anticamo_friendly.UseVisualStyleBackColor = true;
            // 
            // anticamo
            // 
            this.anticamo.AutoSize = true;
            this.anticamo.Location = new System.Drawing.Point(18, 29);
            this.anticamo.Name = "anticamo";
            this.anticamo.Size = new System.Drawing.Size(65, 17);
            this.anticamo.TabIndex = 0;
            this.anticamo.Text = "Enabled";
            this.anticamo.UseVisualStyleBackColor = true;
            // 
            // miscBox
            // 
            this.miscBox.Controls.Add(this.checkBox1);
            this.miscBox.Controls.Add(this.autoRocket);
            this.miscBox.Controls.Add(this.rsbchanger);
            this.miscBox.Enabled = false;
            this.miscBox.Location = new System.Drawing.Point(196, 120);
            this.miscBox.Name = "miscBox";
            this.miscBox.Size = new System.Drawing.Size(185, 148);
            this.miscBox.TabIndex = 1;
            this.miscBox.TabStop = false;
            this.miscBox.Text = "Misc";
            this.miscBox.Enter += new System.EventHandler(this.miscBox_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Auto Rocket Launcher";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // autoRocket
            // 
            this.autoRocket.AutoSize = true;
            this.autoRocket.Location = new System.Drawing.Point(35, 69);
            this.autoRocket.Name = "autoRocket";
            this.autoRocket.Size = new System.Drawing.Size(86, 17);
            this.autoRocket.TabIndex = 1;
            this.autoRocket.Text = "Auto Rocket";
            this.autoRocket.UseVisualStyleBackColor = true;
            // 
            // rsbchanger
            // 
            this.rsbchanger.AutoSize = true;
            this.rsbchanger.Location = new System.Drawing.Point(35, 35);
            this.rsbchanger.Name = "rsbchanger";
            this.rsbchanger.Size = new System.Drawing.Size(91, 17);
            this.rsbchanger.TabIndex = 0;
            this.rsbchanger.Text = "RSB Changer";
            this.rsbchanger.UseVisualStyleBackColor = true;
            // 
            // autolockBox
            // 
            this.autolockBox.Controls.Add(this.autolock_closer_prior);
            this.autolockBox.Controls.Add(this.autolock_hp_prior);
            this.autolockBox.Controls.Add(this.autolock_allies);
            this.autolockBox.Controls.Add(this.autolock_npc);
            this.autolockBox.Controls.Add(this.lockrangelabel);
            this.autolockBox.Controls.Add(this.lockrange);
            this.autolockBox.Controls.Add(this.autolock);
            this.autolockBox.Enabled = false;
            this.autolockBox.Location = new System.Drawing.Point(8, 15);
            this.autolockBox.Name = "autolockBox";
            this.autolockBox.Size = new System.Drawing.Size(185, 256);
            this.autolockBox.TabIndex = 0;
            this.autolockBox.TabStop = false;
            this.autolockBox.Text = "AutoLock";
            // 
            // autolock_closer_prior
            // 
            this.autolock_closer_prior.AutoSize = true;
            this.autolock_closer_prior.Location = new System.Drawing.Point(35, 139);
            this.autolock_closer_prior.Name = "autolock_closer_prior";
            this.autolock_closer_prior.Size = new System.Drawing.Size(83, 17);
            this.autolock_closer_prior.TabIndex = 6;
            this.autolock_closer_prior.TabStop = true;
            this.autolock_closer_prior.Text = "Closer to me";
            this.autolock_closer_prior.UseVisualStyleBackColor = true;
            // 
            // autolock_hp_prior
            // 
            this.autolock_hp_prior.AutoSize = true;
            this.autolock_hp_prior.Location = new System.Drawing.Point(35, 115);
            this.autolock_hp_prior.Name = "autolock_hp_prior";
            this.autolock_hp_prior.Size = new System.Drawing.Size(114, 17);
            this.autolock_hp_prior.TabIndex = 5;
            this.autolock_hp_prior.TabStop = true;
            this.autolock_hp_prior.Text = "Priority to lower HP";
            this.autolock_hp_prior.UseVisualStyleBackColor = true;
            // 
            // autolock_allies
            // 
            this.autolock_allies.AutoSize = true;
            this.autolock_allies.Location = new System.Drawing.Point(29, 73);
            this.autolock_allies.Name = "autolock_allies";
            this.autolock_allies.Size = new System.Drawing.Size(50, 17);
            this.autolock_allies.TabIndex = 4;
            this.autolock_allies.Text = "Allies";
            this.autolock_allies.UseVisualStyleBackColor = true;
            // 
            // autolock_npc
            // 
            this.autolock_npc.AutoSize = true;
            this.autolock_npc.Location = new System.Drawing.Point(100, 73);
            this.autolock_npc.Name = "autolock_npc";
            this.autolock_npc.Size = new System.Drawing.Size(53, 17);
            this.autolock_npc.TabIndex = 3;
            this.autolock_npc.Text = "NPCs";
            this.autolock_npc.UseVisualStyleBackColor = true;
            // 
            // lockrangelabel
            // 
            this.lockrangelabel.AutoSize = true;
            this.lockrangelabel.Location = new System.Drawing.Point(59, 192);
            this.lockrangelabel.Name = "lockrangelabel";
            this.lockrangelabel.Size = new System.Drawing.Size(61, 13);
            this.lockrangelabel.TabIndex = 2;
            this.lockrangelabel.Text = "Lock range";
            // 
            // lockrange
            // 
            this.lockrange.BackColor = System.Drawing.Color.White;
            this.lockrange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lockrange.Location = new System.Drawing.Point(3, 208);
            this.lockrange.Name = "lockrange";
            this.lockrange.Size = new System.Drawing.Size(179, 45);
            this.lockrange.TabIndex = 1;
            // 
            // autolock
            // 
            this.autolock.AutoSize = true;
            this.autolock.Location = new System.Drawing.Point(15, 29);
            this.autolock.Name = "autolock";
            this.autolock.Size = new System.Drawing.Size(65, 17);
            this.autolock.TabIndex = 0;
            this.autolock.Text = "Enabled";
            this.autolock.UseVisualStyleBackColor = true;
            // 
            // bot
            // 
            this.bot.Controls.Add(this.collectableCollectorGroup);
            this.bot.Controls.Add(this.ggGroup);
            this.bot.Controls.Add(this.NpcKillerGroup);
            this.bot.Location = new System.Drawing.Point(4, 22);
            this.bot.Name = "bot";
            this.bot.Size = new System.Drawing.Size(392, 274);
            this.bot.TabIndex = 3;
            this.bot.Text = "Bot";
            this.bot.UseVisualStyleBackColor = true;
            // 
            // collectableCollectorGroup
            // 
            this.collectableCollectorGroup.Controls.Add(this.collectablesList);
            this.collectableCollectorGroup.Controls.Add(this.collector_Enabled);
            this.collectableCollectorGroup.Enabled = false;
            this.collectableCollectorGroup.Location = new System.Drawing.Point(216, 139);
            this.collectableCollectorGroup.Name = "collectableCollectorGroup";
            this.collectableCollectorGroup.Size = new System.Drawing.Size(168, 127);
            this.collectableCollectorGroup.TabIndex = 2;
            this.collectableCollectorGroup.TabStop = false;
            this.collectableCollectorGroup.Text = "Collectable Collector";
            // 
            // collectablesList
            // 
            this.collectablesList.FormattingEnabled = true;
            this.collectablesList.Items.AddRange(new object[] {
            "Bonus Boxes,",
            "Palladium,",
            "Green Pirate Booty,",
            "Gold Pirate Booty,",
            "Blue Pirate Booty,",
            "Red Pirate Booty,",
            "Pink Pirate Booty"});
            this.collectablesList.Location = new System.Drawing.Point(16, 49);
            this.collectablesList.Name = "collectablesList";
            this.collectablesList.Size = new System.Drawing.Size(139, 64);
            this.collectablesList.TabIndex = 1;
            // 
            // collector_Enabled
            // 
            this.collector_Enabled.AutoSize = true;
            this.collector_Enabled.Location = new System.Drawing.Point(16, 25);
            this.collector_Enabled.Name = "collector_Enabled";
            this.collector_Enabled.Size = new System.Drawing.Size(65, 17);
            this.collector_Enabled.TabIndex = 0;
            this.collector_Enabled.Text = "Enabled";
            this.collector_Enabled.UseVisualStyleBackColor = true;
            // 
            // ggGroup
            // 
            this.ggGroup.Controls.Add(this.gg_DroneFormationGroup);
            this.ggGroup.Controls.Add(this.gg_Config);
            this.ggGroup.Controls.Add(this.ggConfigLabel);
            this.ggGroup.Controls.Add(this.gg_Enabled);
            this.ggGroup.Enabled = false;
            this.ggGroup.Location = new System.Drawing.Point(215, 4);
            this.ggGroup.Name = "ggGroup";
            this.ggGroup.Size = new System.Drawing.Size(169, 128);
            this.ggGroup.TabIndex = 1;
            this.ggGroup.TabStop = false;
            this.ggGroup.Text = "GG";
            // 
            // gg_DroneFormationGroup
            // 
            this.gg_DroneFormationGroup.Controls.Add(this.dflabel2);
            this.gg_DroneFormationGroup.Controls.Add(this.dflabel1);
            this.gg_DroneFormationGroup.Controls.Add(this.GG_EndFormation);
            this.gg_DroneFormationGroup.Controls.Add(this.GG_BattleFormation);
            this.gg_DroneFormationGroup.Controls.Add(this.dflabel3);
            this.gg_DroneFormationGroup.Controls.Add(this.GG_RunFormation);
            this.gg_DroneFormationGroup.Location = new System.Drawing.Point(6, 42);
            this.gg_DroneFormationGroup.Name = "gg_DroneFormationGroup";
            this.gg_DroneFormationGroup.Size = new System.Drawing.Size(157, 86);
            this.gg_DroneFormationGroup.TabIndex = 15;
            this.gg_DroneFormationGroup.TabStop = false;
            this.gg_DroneFormationGroup.Text = "Drone Formations";
            // 
            // dflabel2
            // 
            this.dflabel2.AutoSize = true;
            this.dflabel2.Location = new System.Drawing.Point(89, 25);
            this.dflabel2.Name = "dflabel2";
            this.dflabel2.Size = new System.Drawing.Size(26, 13);
            this.dflabel2.TabIndex = 14;
            this.dflabel2.Text = "End";
            // 
            // dflabel1
            // 
            this.dflabel1.AutoSize = true;
            this.dflabel1.Location = new System.Drawing.Point(11, 25);
            this.dflabel1.Name = "dflabel1";
            this.dflabel1.Size = new System.Drawing.Size(34, 13);
            this.dflabel1.TabIndex = 9;
            this.dflabel1.Text = "Battle";
            // 
            // GG_EndFormation
            // 
            this.GG_EndFormation.FormattingEnabled = true;
            this.GG_EndFormation.Items.AddRange(new object[] {
            "Standard"});
            this.GG_EndFormation.Location = new System.Drawing.Point(118, 22);
            this.GG_EndFormation.Name = "GG_EndFormation";
            this.GG_EndFormation.Size = new System.Drawing.Size(32, 21);
            this.GG_EndFormation.TabIndex = 13;
            // 
            // GG_BattleFormation
            // 
            this.GG_BattleFormation.FormattingEnabled = true;
            this.GG_BattleFormation.Items.AddRange(new object[] {
            "Standard"});
            this.GG_BattleFormation.Location = new System.Drawing.Point(48, 22);
            this.GG_BattleFormation.Name = "GG_BattleFormation";
            this.GG_BattleFormation.Size = new System.Drawing.Size(32, 21);
            this.GG_BattleFormation.TabIndex = 10;
            // 
            // dflabel3
            // 
            this.dflabel3.AutoSize = true;
            this.dflabel3.Location = new System.Drawing.Point(18, 52);
            this.dflabel3.Name = "dflabel3";
            this.dflabel3.Size = new System.Drawing.Size(27, 13);
            this.dflabel3.TabIndex = 12;
            this.dflabel3.Text = "Run";
            // 
            // GG_RunFormation
            // 
            this.GG_RunFormation.FormattingEnabled = true;
            this.GG_RunFormation.Items.AddRange(new object[] {
            "Standard"});
            this.GG_RunFormation.Location = new System.Drawing.Point(48, 49);
            this.GG_RunFormation.Name = "GG_RunFormation";
            this.GG_RunFormation.Size = new System.Drawing.Size(32, 21);
            this.GG_RunFormation.TabIndex = 11;
            // 
            // gg_Config
            // 
            this.gg_Config.FormattingEnabled = true;
            this.gg_Config.Items.AddRange(new object[] {
            "1",
            "2"});
            this.gg_Config.Location = new System.Drawing.Point(131, 15);
            this.gg_Config.Name = "gg_Config";
            this.gg_Config.Size = new System.Drawing.Size(32, 21);
            this.gg_Config.TabIndex = 8;
            // 
            // ggConfigLabel
            // 
            this.ggConfigLabel.AutoSize = true;
            this.ggConfigLabel.Location = new System.Drawing.Point(88, 19);
            this.ggConfigLabel.Name = "ggConfigLabel";
            this.ggConfigLabel.Size = new System.Drawing.Size(37, 13);
            this.ggConfigLabel.TabIndex = 7;
            this.ggConfigLabel.Text = "Config";
            // 
            // gg_Enabled
            // 
            this.gg_Enabled.AutoSize = true;
            this.gg_Enabled.Location = new System.Drawing.Point(17, 19);
            this.gg_Enabled.Name = "gg_Enabled";
            this.gg_Enabled.Size = new System.Drawing.Size(65, 17);
            this.gg_Enabled.TabIndex = 0;
            this.gg_Enabled.Text = "Enabled";
            this.gg_Enabled.UseVisualStyleBackColor = true;
            // 
            // NpcKillerGroup
            // 
            this.NpcKillerGroup.Controls.Add(this.npcKiller_Config);
            this.NpcKillerGroup.Controls.Add(this.npcKiller_ConfigLabel);
            this.NpcKillerGroup.Controls.Add(this.npcKiller_AutoCubiGroup);
            this.NpcKillerGroup.Controls.Add(this.npcKiller_Flee);
            this.NpcKillerGroup.Controls.Add(this.NpcListlabel);
            this.NpcKillerGroup.Controls.Add(this.npcList);
            this.NpcKillerGroup.Controls.Add(this.npcKiller_Enabled);
            this.NpcKillerGroup.Enabled = false;
            this.NpcKillerGroup.Location = new System.Drawing.Point(9, 4);
            this.NpcKillerGroup.Name = "NpcKillerGroup";
            this.NpcKillerGroup.Size = new System.Drawing.Size(200, 262);
            this.NpcKillerGroup.TabIndex = 0;
            this.NpcKillerGroup.TabStop = false;
            this.NpcKillerGroup.Text = "NPC Killer";
            // 
            // npcKiller_Config
            // 
            this.npcKiller_Config.FormattingEnabled = true;
            this.npcKiller_Config.Items.AddRange(new object[] {
            "1",
            "2"});
            this.npcKiller_Config.Location = new System.Drawing.Point(85, 46);
            this.npcKiller_Config.Name = "npcKiller_Config";
            this.npcKiller_Config.Size = new System.Drawing.Size(32, 21);
            this.npcKiller_Config.TabIndex = 6;
            // 
            // npcKiller_ConfigLabel
            // 
            this.npcKiller_ConfigLabel.AutoSize = true;
            this.npcKiller_ConfigLabel.Location = new System.Drawing.Point(17, 49);
            this.npcKiller_ConfigLabel.Name = "npcKiller_ConfigLabel";
            this.npcKiller_ConfigLabel.Size = new System.Drawing.Size(66, 13);
            this.npcKiller_ConfigLabel.TabIndex = 5;
            this.npcKiller_ConfigLabel.Text = "Battle config";
            // 
            // npcKiller_AutoCubiGroup
            // 
            this.npcKiller_AutoCubiGroup.Controls.Add(this.autoCubi_Flee);
            this.npcKiller_AutoCubiGroup.Controls.Add(this.autoCubi_UseKami);
            this.npcKiller_AutoCubiGroup.Controls.Add(this.autoCubi_Abilities);
            this.npcKiller_AutoCubiGroup.Controls.Add(this.autoCubi_Enabled);
            this.npcKiller_AutoCubiGroup.Location = new System.Drawing.Point(6, 143);
            this.npcKiller_AutoCubiGroup.Name = "npcKiller_AutoCubiGroup";
            this.npcKiller_AutoCubiGroup.Size = new System.Drawing.Size(188, 113);
            this.npcKiller_AutoCubiGroup.TabIndex = 4;
            this.npcKiller_AutoCubiGroup.TabStop = false;
            this.npcKiller_AutoCubiGroup.Text = "Auto Cubi";
            // 
            // autoCubi_Flee
            // 
            this.autoCubi_Flee.AutoSize = true;
            this.autoCubi_Flee.Location = new System.Drawing.Point(85, 20);
            this.autoCubi_Flee.Name = "autoCubi_Flee";
            this.autoCubi_Flee.Size = new System.Drawing.Size(73, 17);
            this.autoCubi_Flee.TabIndex = 3;
            this.autoCubi_Flee.Text = "Flee if low";
            this.autoCubi_Flee.UseVisualStyleBackColor = true;
            // 
            // autoCubi_UseKami
            // 
            this.autoCubi_UseKami.AutoSize = true;
            this.autoCubi_UseKami.Location = new System.Drawing.Point(40, 75);
            this.autoCubi_UseKami.Name = "autoCubi_UseKami";
            this.autoCubi_UseKami.Size = new System.Drawing.Size(95, 17);
            this.autoCubi_UseKami.TabIndex = 2;
            this.autoCubi_UseKami.Text = "Use PET Kami";
            this.autoCubi_UseKami.UseVisualStyleBackColor = true;
            // 
            // autoCubi_Abilities
            // 
            this.autoCubi_Abilities.AutoSize = true;
            this.autoCubi_Abilities.Location = new System.Drawing.Point(40, 52);
            this.autoCubi_Abilities.Name = "autoCubi_Abilities";
            this.autoCubi_Abilities.Size = new System.Drawing.Size(83, 17);
            this.autoCubi_Abilities.TabIndex = 1;
            this.autoCubi_Abilities.Text = "Use Abilities";
            this.autoCubi_Abilities.UseVisualStyleBackColor = true;
            // 
            // autoCubi_Enabled
            // 
            this.autoCubi_Enabled.AutoSize = true;
            this.autoCubi_Enabled.Location = new System.Drawing.Point(14, 20);
            this.autoCubi_Enabled.Name = "autoCubi_Enabled";
            this.autoCubi_Enabled.Size = new System.Drawing.Size(65, 17);
            this.autoCubi_Enabled.TabIndex = 0;
            this.autoCubi_Enabled.Text = "Enabled";
            this.autoCubi_Enabled.UseVisualStyleBackColor = true;
            // 
            // npcKiller_Flee
            // 
            this.npcKiller_Flee.AutoSize = true;
            this.npcKiller_Flee.Location = new System.Drawing.Point(88, 19);
            this.npcKiller_Flee.Name = "npcKiller_Flee";
            this.npcKiller_Flee.Size = new System.Drawing.Size(96, 17);
            this.npcKiller_Flee.TabIndex = 3;
            this.npcKiller_Flee.Text = "Flee on Enemy";
            this.npcKiller_Flee.UseVisualStyleBackColor = true;
            // 
            // NpcListlabel
            // 
            this.NpcListlabel.AutoSize = true;
            this.NpcListlabel.Location = new System.Drawing.Point(17, 72);
            this.NpcListlabel.Name = "NpcListlabel";
            this.NpcListlabel.Size = new System.Drawing.Size(34, 13);
            this.NpcListlabel.TabIndex = 2;
            this.NpcListlabel.Text = "NPCs";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Items.AddRange(new object[] {
            "-= [Kristallin] =-",
            "-= [Boss Kristallin] =-",
            "-= [Kristallon] =-",
            "-= [Protegit] =-"});
            this.npcList.Location = new System.Drawing.Point(17, 88);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(143, 49);
            this.npcList.TabIndex = 1;
            // 
            // npcKiller_Enabled
            // 
            this.npcKiller_Enabled.AutoSize = true;
            this.npcKiller_Enabled.Location = new System.Drawing.Point(17, 19);
            this.npcKiller_Enabled.Name = "npcKiller_Enabled";
            this.npcKiller_Enabled.Size = new System.Drawing.Size(65, 17);
            this.npcKiller_Enabled.TabIndex = 0;
            this.npcKiller_Enabled.Text = "Enabled";
            this.npcKiller_Enabled.UseVisualStyleBackColor = true;
            // 
            // visuals
            // 
            this.visuals.Controls.Add(this.showingLog);
            this.visuals.Location = new System.Drawing.Point(4, 22);
            this.visuals.Name = "visuals";
            this.visuals.Padding = new System.Windows.Forms.Padding(3);
            this.visuals.Size = new System.Drawing.Size(392, 274);
            this.visuals.TabIndex = 0;
            this.visuals.Text = "Visuals";
            this.visuals.UseVisualStyleBackColor = true;
            // 
            // showingLog
            // 
            this.showingLog.AutoSize = true;
            this.showingLog.Location = new System.Drawing.Point(23, 21);
            this.showingLog.Name = "showingLog";
            this.showingLog.Size = new System.Drawing.Size(84, 17);
            this.showingLog.TabIndex = 0;
            this.showingLog.Text = "Showing log";
            this.showingLog.UseVisualStyleBackColor = true;
            this.showingLog.CheckedChanged += new System.EventHandler(this.showingLog_CheckedChanged);
            // 
            // performance
            // 
            this.performance.Controls.Add(this.networkUsage);
            this.performance.Controls.Add(this.runtime);
            this.performance.Controls.Add(this.cpuUsage);
            this.performance.Controls.Add(this.ramUsage);
            this.performance.Controls.Add(this.performanceChart);
            this.performance.Location = new System.Drawing.Point(4, 22);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(392, 274);
            this.performance.TabIndex = 1;
            this.performance.Text = "Performance";
            this.performance.UseVisualStyleBackColor = true;
            // 
            // networkUsage
            // 
            this.networkUsage.AutoSize = true;
            this.networkUsage.Location = new System.Drawing.Point(39, 73);
            this.networkUsage.Name = "networkUsage";
            this.networkUsage.Size = new System.Drawing.Size(122, 13);
            this.networkUsage.TabIndex = 5;
            this.networkUsage.Text = "Network Usage: 0 Mbps";
            // 
            // runtime
            // 
            this.runtime.AutoSize = true;
            this.runtime.Location = new System.Drawing.Point(290, 10);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(94, 13);
            this.runtime.TabIndex = 4;
            this.runtime.Text = "Runtime: 00-00-00";
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Location = new System.Drawing.Point(39, 49);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(83, 13);
            this.cpuUsage.TabIndex = 3;
            this.cpuUsage.Text = "CPU Usage: 0%";
            // 
            // ramUsage
            // 
            this.ramUsage.AutoSize = true;
            this.ramUsage.Location = new System.Drawing.Point(39, 25);
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.Size = new System.Drawing.Size(96, 13);
            this.ramUsage.TabIndex = 2;
            this.ramUsage.Text = "RAM Usage: 0 MB";
            // 
            // performanceChart
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 5D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Gray;
            this.performanceChart.ChartAreas.Add(chartArea1);
            this.performanceChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.performanceChart.Legends.Add(legend1);
            this.performanceChart.Location = new System.Drawing.Point(0, 135);
            this.performanceChart.Name = "performanceChart";
            this.performanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Silver;
            series1.Legend = "Legend1";
            series1.Name = "CPU Usage %";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "RAM Usage %";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Network Usage %";
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            this.performanceChart.Series.Add(series1);
            this.performanceChart.Series.Add(series2);
            this.performanceChart.Series.Add(series3);
            this.performanceChart.Size = new System.Drawing.Size(392, 139);
            this.performanceChart.TabIndex = 1;
            this.performanceChart.Text = "performanceChart";
            // 
            // info
            // 
            this.info.Controls.Add(this.info_6);
            this.info.Controls.Add(this.info_changelog);
            this.info.Controls.Add(this.info_5);
            this.info.Controls.Add(this.info_4);
            this.info.Controls.Add(this.info_3);
            this.info.Controls.Add(this.info_2);
            this.info.Controls.Add(this.info_1);
            this.info.Location = new System.Drawing.Point(4, 22);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(392, 274);
            this.info.TabIndex = 4;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = true;
            // 
            // info_6
            // 
            this.info_6.AutoSize = true;
            this.info_6.Location = new System.Drawing.Point(157, 162);
            this.info_6.Name = "info_6";
            this.info_6.Size = new System.Drawing.Size(58, 13);
            this.info_6.TabIndex = 6;
            this.info_6.Text = "Changelog";
            // 
            // info_changelog
            // 
            this.info_changelog.Location = new System.Drawing.Point(8, 181);
            this.info_changelog.Name = "info_changelog";
            this.info_changelog.Size = new System.Drawing.Size(376, 85);
            this.info_changelog.TabIndex = 5;
            this.info_changelog.Text = resources.GetString("info_changelog.Text");
            // 
            // info_5
            // 
            this.info_5.AutoSize = true;
            this.info_5.Location = new System.Drawing.Point(24, 122);
            this.info_5.Name = "info_5";
            this.info_5.Size = new System.Drawing.Size(169, 13);
            this.info_5.TabIndex = 4;
            this.info_5.Text = "We wish you a smooth experience\r\n";
            // 
            // info_4
            // 
            this.info_4.AutoSize = true;
            this.info_4.Location = new System.Drawing.Point(185, 92);
            this.info_4.Name = "info_4";
            this.info_4.Size = new System.Drawing.Size(64, 13);
            this.info_4.TabIndex = 3;
            this.info_4.TabStop = true;
            this.info_4.Text = "Renew now";
            // 
            // info_3
            // 
            this.info_3.AutoSize = true;
            this.info_3.Location = new System.Drawing.Point(24, 92);
            this.info_3.Name = "info_3";
            this.info_3.Size = new System.Drawing.Size(155, 13);
            this.info_3.TabIndex = 2;
            this.info_3.Text = "License expiring in 91259 days.\r\n";
            // 
            // info_2
            // 
            this.info_2.AutoSize = true;
            this.info_2.Location = new System.Drawing.Point(24, 48);
            this.info_2.Name = "info_2";
            this.info_2.Size = new System.Drawing.Size(155, 26);
            this.info_2.TabIndex = 1;
            this.info_2.Text = "Copyrights 2017,\r\nDevloped by Yuuki and Shock.\r\n";
            // 
            // info_1
            // 
            this.info_1.AutoSize = true;
            this.info_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info_1.Location = new System.Drawing.Point(24, 21);
            this.info_1.Name = "info_1";
            this.info_1.Size = new System.Drawing.Size(163, 13);
            this.info_1.TabIndex = 0;
            this.info_1.Text = "Revolvo v0.01 EXPERIMENTAL";
            // 
            // profiles
            // 
            this.profiles.Controls.Add(this.loadProfile);
            this.profiles.Controls.Add(this.profileTextBox);
            this.profiles.Controls.Add(this.deleteProfile);
            this.profiles.Controls.Add(this.saveProfile);
            this.profiles.Controls.Add(this.label16);
            this.profiles.Controls.Add(this.profilesBox);
            this.profiles.Location = new System.Drawing.Point(4, 22);
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(392, 274);
            this.profiles.TabIndex = 5;
            this.profiles.Text = "Profiles";
            this.profiles.UseVisualStyleBackColor = true;
            // 
            // loadProfile
            // 
            this.loadProfile.Location = new System.Drawing.Point(228, 236);
            this.loadProfile.Name = "loadProfile";
            this.loadProfile.Size = new System.Drawing.Size(75, 23);
            this.loadProfile.TabIndex = 5;
            this.loadProfile.Text = "Load";
            this.loadProfile.UseVisualStyleBackColor = true;
            // 
            // profileTextBox
            // 
            this.profileTextBox.Location = new System.Drawing.Point(8, 238);
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.Size = new System.Drawing.Size(135, 20);
            this.profileTextBox.TabIndex = 4;
            // 
            // deleteProfile
            // 
            this.deleteProfile.Location = new System.Drawing.Point(309, 236);
            this.deleteProfile.Name = "deleteProfile";
            this.deleteProfile.Size = new System.Drawing.Size(75, 23);
            this.deleteProfile.TabIndex = 3;
            this.deleteProfile.Text = "Delete";
            this.deleteProfile.UseVisualStyleBackColor = true;
            // 
            // saveProfile
            // 
            this.saveProfile.Location = new System.Drawing.Point(149, 236);
            this.saveProfile.Name = "saveProfile";
            this.saveProfile.Size = new System.Drawing.Size(75, 23);
            this.saveProfile.TabIndex = 2;
            this.saveProfile.Text = "Save";
            this.saveProfile.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Profiles";
            // 
            // profilesBox
            // 
            this.profilesBox.FormattingEnabled = true;
            this.profilesBox.Items.AddRange(new object[] {
            "Profile1",
            "Profile2",
            "Profile3"});
            this.profilesBox.Location = new System.Drawing.Point(8, 31);
            this.profilesBox.Name = "profilesBox";
            this.profilesBox.Size = new System.Drawing.Size(376, 199);
            this.profilesBox.TabIndex = 0;
            // 
            // performanceTimer
            // 
            this.performanceTimer.Enabled = true;
            this.performanceTimer.Interval = 1000;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.OptionsForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OptionsForm_MouseDown);
            this.tabControl.ResumeLayout(false);
            this.pvp.ResumeLayout(false);
            this.anticamoBox.ResumeLayout(false);
            this.anticamoBox.PerformLayout();
            this.miscBox.ResumeLayout(false);
            this.miscBox.PerformLayout();
            this.autolockBox.ResumeLayout(false);
            this.autolockBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockrange)).EndInit();
            this.bot.ResumeLayout(false);
            this.collectableCollectorGroup.ResumeLayout(false);
            this.collectableCollectorGroup.PerformLayout();
            this.ggGroup.ResumeLayout(false);
            this.ggGroup.PerformLayout();
            this.gg_DroneFormationGroup.ResumeLayout(false);
            this.gg_DroneFormationGroup.PerformLayout();
            this.NpcKillerGroup.ResumeLayout(false);
            this.NpcKillerGroup.PerformLayout();
            this.npcKiller_AutoCubiGroup.ResumeLayout(false);
            this.npcKiller_AutoCubiGroup.PerformLayout();
            this.visuals.ResumeLayout(false);
            this.visuals.PerformLayout();
            this.performance.ResumeLayout(false);
            this.performance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceChart)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.profiles.ResumeLayout(false);
            this.profiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage visuals;
        private System.Windows.Forms.CheckBox showingLog;
        private System.Windows.Forms.TabPage performance;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.DataVisualization.Charting.Chart performanceChart;
        private System.Windows.Forms.Timer performanceTimer;
        private System.Windows.Forms.TabPage pvp;
        private System.Windows.Forms.GroupBox anticamoBox;
        private System.Windows.Forms.CheckBox anticamo_title;
        private System.Windows.Forms.CheckBox anticamo_npc;
        private System.Windows.Forms.CheckBox anticamo_friendly;
        private System.Windows.Forms.CheckBox anticamo;
        private System.Windows.Forms.GroupBox miscBox;
        private System.Windows.Forms.CheckBox rsbchanger;
        private System.Windows.Forms.GroupBox autolockBox;
        private System.Windows.Forms.RadioButton autolock_closer_prior;
        private System.Windows.Forms.RadioButton autolock_hp_prior;
        private System.Windows.Forms.CheckBox autolock_allies;
        private System.Windows.Forms.CheckBox autolock_npc;
        private System.Windows.Forms.Label lockrangelabel;
        private System.Windows.Forms.TrackBar lockrange;
        private System.Windows.Forms.CheckBox autolock;
        private System.Windows.Forms.TabPage bot;
        private System.Windows.Forms.Label networkUsage;
        private System.Windows.Forms.TabPage info;
        private System.Windows.Forms.GroupBox collectableCollectorGroup;
        private System.Windows.Forms.CheckBox collector_Enabled;
        private System.Windows.Forms.GroupBox ggGroup;
        private System.Windows.Forms.CheckBox gg_Enabled;
        private System.Windows.Forms.GroupBox NpcKillerGroup;
        private System.Windows.Forms.Label npcKiller_ConfigLabel;
        private System.Windows.Forms.GroupBox npcKiller_AutoCubiGroup;
        private System.Windows.Forms.CheckBox npcKiller_Flee;
        private System.Windows.Forms.Label NpcListlabel;
        private System.Windows.Forms.CheckedListBox npcList;
        private System.Windows.Forms.CheckBox npcKiller_Enabled;
        private System.Windows.Forms.ComboBox npcKiller_Config;
        private System.Windows.Forms.Label dflabel3;
        private System.Windows.Forms.ComboBox GG_RunFormation;
        private System.Windows.Forms.ComboBox GG_BattleFormation;
        private System.Windows.Forms.Label dflabel1;
        private System.Windows.Forms.ComboBox gg_Config;
        private System.Windows.Forms.Label ggConfigLabel;
        private System.Windows.Forms.CheckBox autoCubi_Flee;
        private System.Windows.Forms.CheckBox autoCubi_UseKami;
        private System.Windows.Forms.CheckBox autoCubi_Abilities;
        private System.Windows.Forms.CheckBox autoCubi_Enabled;
        private System.Windows.Forms.CheckedListBox collectablesList;
        private System.Windows.Forms.GroupBox gg_DroneFormationGroup;
        private System.Windows.Forms.Label dflabel2;
        private System.Windows.Forms.ComboBox GG_EndFormation;
        private System.Windows.Forms.Label info_6;
        private System.Windows.Forms.RichTextBox info_changelog;
        private System.Windows.Forms.Label info_5;
        private System.Windows.Forms.LinkLabel info_4;
        private System.Windows.Forms.Label info_3;
        private System.Windows.Forms.Label info_2;
        private System.Windows.Forms.Label info_1;
        private System.Windows.Forms.TabPage profiles;
        private System.Windows.Forms.TextBox profileTextBox;
        private System.Windows.Forms.Button deleteProfile;
        private System.Windows.Forms.Button saveProfile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox profilesBox;
        private System.Windows.Forms.Button loadProfile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox autoRocket;
    }
}