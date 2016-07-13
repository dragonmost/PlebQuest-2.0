namespace PlebQuest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butMenuPlay = new System.Windows.Forms.Button();
            this.butMenuNew = new System.Windows.Forms.Button();
            this.butMenuCreate = new System.Windows.Forms.Button();
            this.txtMenuPassword = new System.Windows.Forms.TextBox();
            this.txtMenuUsername = new System.Windows.Forms.TextBox();
            this.butMenuJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCharacterCreation = new System.Windows.Forms.Panel();
            this.butCreationMale = new System.Windows.Forms.RadioButton();
            this.butCreationFemale = new System.Windows.Forms.RadioButton();
            this.butCancelCreation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCreationTotalStats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCreationStat = new System.Windows.Forms.ListView();
            this.colCreationStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreationStatValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butRoll = new System.Windows.Forms.Button();
            this.butGenerate = new System.Windows.Forms.Button();
            this.lstCreationClass = new System.Windows.Forms.ListBox();
            this.txtCreationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCreationRace = new System.Windows.Forms.ListBox();
            this.butCreationStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.stbAction = new System.Windows.Forms.StatusStrip();
            this.grpMP = new System.Windows.Forms.GroupBox();
            this.pgbMP = new System.Windows.Forms.ProgressBar();
            this.gpbQuest = new System.Windows.Forms.GroupBox();
            this.lstQuest = new System.Windows.Forms.ListView();
            this.colQuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblObjective = new System.Windows.Forms.Label();
            this.txtCurrentObjective = new System.Windows.Forms.RichTextBox();
            this.grpSpeels = new System.Windows.Forms.GroupBox();
            this.lstSpeel = new System.Windows.Forms.ListBox();
            this.gpbInventory = new System.Windows.Forms.GroupBox();
            this.lblGold = new System.Windows.Forms.Label();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.pgbEncumbrance = new System.Windows.Forms.ProgressBar();
            this.pgbAction = new System.Windows.Forms.ProgressBar();
            this.grpEquipment = new System.Windows.Forms.GroupBox();
            this.lstEquipment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpRegion = new System.Windows.Forms.GroupBox();
            this.txtRegion = new System.Windows.Forms.RichTextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.pgbExp = new System.Windows.Forms.ProgressBar();
            this.grpHP = new System.Windows.Forms.GroupBox();
            this.pgbHP = new System.Windows.Forms.ProgressBar();
            this.grpPlebSheet = new System.Windows.Forms.GroupBox();
            this.lstPlebSheet = new System.Windows.Forms.ListView();
            this.colTrait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCharacterCreation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.grpMP.SuspendLayout();
            this.gpbQuest.SuspendLayout();
            this.grpSpeels.SuspendLayout();
            this.gpbInventory.SuspendLayout();
            this.grpEquipment.SuspendLayout();
            this.grpRegion.SuspendLayout();
            this.grpLevel.SuspendLayout();
            this.grpHP.SuspendLayout();
            this.grpPlebSheet.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butMenuPlay
            // 
            this.butMenuPlay.Location = new System.Drawing.Point(12, 378);
            this.butMenuPlay.Name = "butMenuPlay";
            this.butMenuPlay.Size = new System.Drawing.Size(121, 23);
            this.butMenuPlay.TabIndex = 5;
            this.butMenuPlay.Text = "Browse Plebs";
            this.butMenuPlay.UseVisualStyleBackColor = true;
            this.butMenuPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butMenuNew
            // 
            this.butMenuNew.Location = new System.Drawing.Point(12, 407);
            this.butMenuNew.Name = "butMenuNew";
            this.butMenuNew.Size = new System.Drawing.Size(121, 23);
            this.butMenuNew.TabIndex = 6;
            this.butMenuNew.Text = "new Pleb";
            this.butMenuNew.UseVisualStyleBackColor = true;
            this.butMenuNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // butMenuCreate
            // 
            this.butMenuCreate.Location = new System.Drawing.Point(512, 378);
            this.butMenuCreate.Name = "butMenuCreate";
            this.butMenuCreate.Size = new System.Drawing.Size(100, 23);
            this.butMenuCreate.TabIndex = 4;
            this.butMenuCreate.Text = "Create Account";
            this.butMenuCreate.UseVisualStyleBackColor = true;
            this.butMenuCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // txtMenuPassword
            // 
            this.txtMenuPassword.Location = new System.Drawing.Point(278, 381);
            this.txtMenuPassword.Name = "txtMenuPassword";
            this.txtMenuPassword.Size = new System.Drawing.Size(100, 20);
            this.txtMenuPassword.TabIndex = 2;
            this.txtMenuPassword.UseSystemPasswordChar = true;
            // 
            // txtMenuUsername
            // 
            this.txtMenuUsername.Location = new System.Drawing.Point(278, 352);
            this.txtMenuUsername.Name = "txtMenuUsername";
            this.txtMenuUsername.Size = new System.Drawing.Size(100, 20);
            this.txtMenuUsername.TabIndex = 1;
            // 
            // butMenuJoin
            // 
            this.butMenuJoin.Location = new System.Drawing.Point(512, 407);
            this.butMenuJoin.Name = "butMenuJoin";
            this.butMenuJoin.Size = new System.Drawing.Size(100, 23);
            this.butMenuJoin.TabIndex = 3;
            this.butMenuJoin.Text = "Join";
            this.butMenuJoin.UseVisualStyleBackColor = true;
            this.butMenuJoin.Click += new System.EventHandler(this.butJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // pnlCharacterCreation
            // 
            this.pnlCharacterCreation.Controls.Add(this.butCreationMale);
            this.pnlCharacterCreation.Controls.Add(this.butCreationFemale);
            this.pnlCharacterCreation.Controls.Add(this.butCancelCreation);
            this.pnlCharacterCreation.Controls.Add(this.groupBox1);
            this.pnlCharacterCreation.Controls.Add(this.butGenerate);
            this.pnlCharacterCreation.Controls.Add(this.lstCreationClass);
            this.pnlCharacterCreation.Controls.Add(this.txtCreationName);
            this.pnlCharacterCreation.Controls.Add(this.label3);
            this.pnlCharacterCreation.Controls.Add(this.lstCreationRace);
            this.pnlCharacterCreation.Controls.Add(this.butCreationStart);
            this.pnlCharacterCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCharacterCreation.Location = new System.Drawing.Point(0, 0);
            this.pnlCharacterCreation.Name = "pnlCharacterCreation";
            this.pnlCharacterCreation.Size = new System.Drawing.Size(784, 562);
            this.pnlCharacterCreation.TabIndex = 11;
            this.pnlCharacterCreation.Visible = false;
            // 
            // butCreationMale
            // 
            this.butCreationMale.Appearance = System.Windows.Forms.Appearance.Button;
            this.butCreationMale.AutoSize = true;
            this.butCreationMale.Checked = true;
            this.butCreationMale.Location = new System.Drawing.Point(295, 4);
            this.butCreationMale.Name = "butCreationMale";
            this.butCreationMale.Size = new System.Drawing.Size(29, 23);
            this.butCreationMale.TabIndex = 9;
            this.butCreationMale.TabStop = true;
            this.butCreationMale.Text = "\t♂";
            this.butCreationMale.UseVisualStyleBackColor = true;
            // 
            // butCreationFemale
            // 
            this.butCreationFemale.Appearance = System.Windows.Forms.Appearance.Button;
            this.butCreationFemale.AutoSize = true;
            this.butCreationFemale.Location = new System.Drawing.Point(330, 4);
            this.butCreationFemale.Name = "butCreationFemale";
            this.butCreationFemale.Size = new System.Drawing.Size(29, 23);
            this.butCreationFemale.TabIndex = 8;
            this.butCreationFemale.Text = "♀";
            this.butCreationFemale.UseVisualStyleBackColor = true;
            // 
            // butCancelCreation
            // 
            this.butCancelCreation.Location = new System.Drawing.Point(12, 407);
            this.butCancelCreation.Name = "butCancelCreation";
            this.butCancelCreation.Size = new System.Drawing.Size(75, 23);
            this.butCancelCreation.TabIndex = 7;
            this.butCancelCreation.Text = "Cancel";
            this.butCancelCreation.UseVisualStyleBackColor = true;
            this.butCancelCreation.Click += new System.EventHandler(this.butCancelCreation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCreationTotalStats);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstCreationStat);
            this.groupBox1.Controls.Add(this.butRoll);
            this.groupBox1.Location = new System.Drawing.Point(365, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 355);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stat Generation";
            // 
            // txtCreationTotalStats
            // 
            this.txtCreationTotalStats.Location = new System.Drawing.Point(83, 322);
            this.txtCreationTotalStats.Name = "txtCreationTotalStats";
            this.txtCreationTotalStats.ReadOnly = true;
            this.txtCreationTotalStats.Size = new System.Drawing.Size(45, 20);
            this.txtCreationTotalStats.TabIndex = 3;
            this.txtCreationTotalStats.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreationTotalStats_KeyDown);
            this.txtCreationTotalStats.Leave += new System.EventHandler(this.txtCreationTotalStats_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Stats:";
            // 
            // lstCreationStat
            // 
            this.lstCreationStat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCreationStat,
            this.colCreationStatValue});
            this.lstCreationStat.Location = new System.Drawing.Point(6, 19);
            this.lstCreationStat.Name = "lstCreationStat";
            this.lstCreationStat.Size = new System.Drawing.Size(235, 292);
            this.lstCreationStat.TabIndex = 1;
            this.lstCreationStat.UseCompatibleStateImageBehavior = false;
            this.lstCreationStat.View = System.Windows.Forms.View.Details;
            // 
            // colCreationStat
            // 
            this.colCreationStat.Text = "Stats";
            this.colCreationStat.Width = 133;
            // 
            // colCreationStatValue
            // 
            this.colCreationStatValue.Text = "Value";
            this.colCreationStatValue.Width = 98;
            // 
            // butRoll
            // 
            this.butRoll.Location = new System.Drawing.Point(166, 320);
            this.butRoll.Name = "butRoll";
            this.butRoll.Size = new System.Drawing.Size(75, 23);
            this.butRoll.TabIndex = 0;
            this.butRoll.Text = "Roll";
            this.butRoll.UseVisualStyleBackColor = true;
            this.butRoll.Click += new System.EventHandler(this.butRoll_Click);
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(194, 4);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(75, 23);
            this.butGenerate.TabIndex = 5;
            this.butGenerate.Text = "Generate Pleb";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // lstCreationClass
            // 
            this.lstCreationClass.FormattingEnabled = true;
            this.lstCreationClass.Location = new System.Drawing.Point(194, 32);
            this.lstCreationClass.Name = "lstCreationClass";
            this.lstCreationClass.Size = new System.Drawing.Size(165, 355);
            this.lstCreationClass.TabIndex = 4;
            this.lstCreationClass.SelectedIndexChanged += new System.EventHandler(this.SetControlState);
            // 
            // txtCreationName
            // 
            this.txtCreationName.Location = new System.Drawing.Point(77, 6);
            this.txtCreationName.Name = "txtCreationName";
            this.txtCreationName.Size = new System.Drawing.Size(100, 20);
            this.txtCreationName.TabIndex = 3;
            this.txtCreationName.TextChanged += new System.EventHandler(this.SetControlState);
            this.txtCreationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreationName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pleb Name";
            // 
            // lstCreationRace
            // 
            this.lstCreationRace.FormattingEnabled = true;
            this.lstCreationRace.Location = new System.Drawing.Point(12, 32);
            this.lstCreationRace.Name = "lstCreationRace";
            this.lstCreationRace.Size = new System.Drawing.Size(165, 355);
            this.lstCreationRace.TabIndex = 1;
            this.lstCreationRace.SelectedIndexChanged += new System.EventHandler(this.SetControlState);
            // 
            // butCreationStart
            // 
            this.butCreationStart.Enabled = false;
            this.butCreationStart.Location = new System.Drawing.Point(537, 407);
            this.butCreationStart.Name = "butCreationStart";
            this.butCreationStart.Size = new System.Drawing.Size(75, 23);
            this.butCreationStart.TabIndex = 0;
            this.butCreationStart.Text = "Start";
            this.butCreationStart.UseVisualStyleBackColor = true;
            this.butCreationStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGame.Controls.Add(this.stbAction);
            this.pnlGame.Controls.Add(this.grpMP);
            this.pnlGame.Controls.Add(this.gpbQuest);
            this.pnlGame.Controls.Add(this.grpSpeels);
            this.pnlGame.Controls.Add(this.gpbInventory);
            this.pnlGame.Controls.Add(this.pgbAction);
            this.pnlGame.Controls.Add(this.grpEquipment);
            this.pnlGame.Controls.Add(this.grpRegion);
            this.pnlGame.Controls.Add(this.grpLevel);
            this.pnlGame.Controls.Add(this.grpHP);
            this.pnlGame.Controls.Add(this.grpPlebSheet);
            this.pnlGame.Controls.Add(this.menuStrip1);
            this.pnlGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(784, 562);
            this.pnlGame.TabIndex = 12;
            // 
            // stbAction
            // 
            this.stbAction.Location = new System.Drawing.Point(0, 538);
            this.stbAction.Name = "stbAction";
            this.stbAction.Size = new System.Drawing.Size(782, 22);
            this.stbAction.TabIndex = 17;
            this.stbAction.Text = "statusStrip1";
            // 
            // grpMP
            // 
            this.grpMP.Controls.Add(this.pgbMP);
            this.grpMP.Location = new System.Drawing.Point(9, 292);
            this.grpMP.Name = "grpMP";
            this.grpMP.Size = new System.Drawing.Size(200, 40);
            this.grpMP.TabIndex = 16;
            this.grpMP.TabStop = false;
            this.grpMP.Text = "Magic Point";
            // 
            // pgbMP
            // 
            this.pgbMP.Location = new System.Drawing.Point(9, 19);
            this.pgbMP.Name = "pgbMP";
            this.pgbMP.Size = new System.Drawing.Size(184, 12);
            this.pgbMP.TabIndex = 0;
            // 
            // gpbQuest
            // 
            this.gpbQuest.Controls.Add(this.lstQuest);
            this.gpbQuest.Controls.Add(this.lblObjective);
            this.gpbQuest.Controls.Add(this.txtCurrentObjective);
            this.gpbQuest.Location = new System.Drawing.Point(572, 27);
            this.gpbQuest.Name = "gpbQuest";
            this.gpbQuest.Size = new System.Drawing.Size(200, 337);
            this.gpbQuest.TabIndex = 15;
            this.gpbQuest.TabStop = false;
            this.gpbQuest.Text = "Quest";
            // 
            // lstQuest
            // 
            this.lstQuest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colQuest});
            this.lstQuest.FullRowSelect = true;
            this.lstQuest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstQuest.Location = new System.Drawing.Point(6, 19);
            this.lstQuest.Name = "lstQuest";
            this.lstQuest.Size = new System.Drawing.Size(187, 215);
            this.lstQuest.TabIndex = 17;
            this.lstQuest.UseCompatibleStateImageBehavior = false;
            this.lstQuest.View = System.Windows.Forms.View.Details;
            // 
            // colQuest
            // 
            this.colQuest.Text = "Quests";
            this.colQuest.Width = 182;
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Location = new System.Drawing.Point(6, 237);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(89, 13);
            this.lblObjective.TabIndex = 16;
            this.lblObjective.Text = "Current Objective";
            // 
            // txtCurrentObjective
            // 
            this.txtCurrentObjective.BackColor = System.Drawing.Color.White;
            this.txtCurrentObjective.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentObjective.Location = new System.Drawing.Point(6, 257);
            this.txtCurrentObjective.Name = "txtCurrentObjective";
            this.txtCurrentObjective.ReadOnly = true;
            this.txtCurrentObjective.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCurrentObjective.Size = new System.Drawing.Size(188, 74);
            this.txtCurrentObjective.TabIndex = 9;
            this.txtCurrentObjective.Text = "";
            // 
            // grpSpeels
            // 
            this.grpSpeels.Controls.Add(this.lstSpeel);
            this.grpSpeels.Location = new System.Drawing.Point(214, 27);
            this.grpSpeels.Name = "grpSpeels";
            this.grpSpeels.Size = new System.Drawing.Size(200, 213);
            this.grpSpeels.TabIndex = 14;
            this.grpSpeels.TabStop = false;
            this.grpSpeels.Text = "SpeelBook";
            // 
            // lstSpeel
            // 
            this.lstSpeel.FormattingEnabled = true;
            this.lstSpeel.Location = new System.Drawing.Point(9, 19);
            this.lstSpeel.Name = "lstSpeel";
            this.lstSpeel.Size = new System.Drawing.Size(184, 186);
            this.lstSpeel.TabIndex = 0;
            // 
            // gpbInventory
            // 
            this.gpbInventory.Controls.Add(this.lblGold);
            this.gpbInventory.Controls.Add(this.lstInventory);
            this.gpbInventory.Controls.Add(this.pgbEncumbrance);
            this.gpbInventory.Location = new System.Drawing.Point(213, 246);
            this.gpbInventory.Name = "gpbInventory";
            this.gpbInventory.Size = new System.Drawing.Size(200, 257);
            this.gpbInventory.TabIndex = 13;
            this.gpbInventory.TabStop = false;
            this.gpbInventory.Text = "Inventory";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(6, 16);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(32, 13);
            this.lblGold.TabIndex = 15;
            this.lblGold.Text = "Gold:";
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(5, 33);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(190, 199);
            this.lstInventory.TabIndex = 15;
            // 
            // pgbEncumbrance
            // 
            this.pgbEncumbrance.Location = new System.Drawing.Point(5, 237);
            this.pgbEncumbrance.Name = "pgbEncumbrance";
            this.pgbEncumbrance.Size = new System.Drawing.Size(190, 12);
            this.pgbEncumbrance.TabIndex = 14;
            // 
            // pgbAction
            // 
            this.pgbAction.Location = new System.Drawing.Point(3, 508);
            this.pgbAction.Name = "pgbAction";
            this.pgbAction.Size = new System.Drawing.Size(776, 27);
            this.pgbAction.TabIndex = 6;
            // 
            // grpEquipment
            // 
            this.grpEquipment.Controls.Add(this.lstEquipment);
            this.grpEquipment.Location = new System.Drawing.Point(8, 386);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Size = new System.Drawing.Size(199, 117);
            this.grpEquipment.TabIndex = 5;
            this.grpEquipment.TabStop = false;
            this.grpEquipment.Text = "Equipment";
            // 
            // lstEquipment
            // 
            this.lstEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstEquipment.FullRowSelect = true;
            this.lstEquipment.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstEquipment.Location = new System.Drawing.Point(6, 19);
            this.lstEquipment.Name = "lstEquipment";
            this.lstEquipment.Size = new System.Drawing.Size(187, 90);
            this.lstEquipment.TabIndex = 1;
            this.lstEquipment.UseCompatibleStateImageBehavior = false;
            this.lstEquipment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stats";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 102;
            // 
            // grpRegion
            // 
            this.grpRegion.Controls.Add(this.txtRegion);
            this.grpRegion.Controls.Add(this.lblRegion);
            this.grpRegion.Location = new System.Drawing.Point(572, 370);
            this.grpRegion.Name = "grpRegion";
            this.grpRegion.Size = new System.Drawing.Size(200, 133);
            this.grpRegion.TabIndex = 4;
            this.grpRegion.TabStop = false;
            this.grpRegion.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.Color.White;
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegion.Location = new System.Drawing.Point(6, 32);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.ReadOnly = true;
            this.txtRegion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtRegion.Size = new System.Drawing.Size(187, 95);
            this.txtRegion.TabIndex = 9;
            this.txtRegion.Text = "";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(6, 16);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(52, 13);
            this.lblRegion.TabIndex = 6;
            this.lblRegion.Text = "PlebLand";
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.pgbExp);
            this.grpLevel.Location = new System.Drawing.Point(8, 338);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(200, 40);
            this.grpLevel.TabIndex = 3;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level:";
            // 
            // pgbExp
            // 
            this.pgbExp.Location = new System.Drawing.Point(9, 19);
            this.pgbExp.Name = "pgbExp";
            this.pgbExp.Size = new System.Drawing.Size(184, 12);
            this.pgbExp.TabIndex = 0;
            // 
            // grpHP
            // 
            this.grpHP.Controls.Add(this.pgbHP);
            this.grpHP.Location = new System.Drawing.Point(8, 246);
            this.grpHP.Name = "grpHP";
            this.grpHP.Size = new System.Drawing.Size(200, 40);
            this.grpHP.TabIndex = 2;
            this.grpHP.TabStop = false;
            this.grpHP.Text = "Health Point";
            // 
            // pgbHP
            // 
            this.pgbHP.Location = new System.Drawing.Point(9, 19);
            this.pgbHP.Name = "pgbHP";
            this.pgbHP.Size = new System.Drawing.Size(184, 12);
            this.pgbHP.TabIndex = 0;
            // 
            // grpPlebSheet
            // 
            this.grpPlebSheet.Controls.Add(this.lstPlebSheet);
            this.grpPlebSheet.Location = new System.Drawing.Point(9, 27);
            this.grpPlebSheet.Name = "grpPlebSheet";
            this.grpPlebSheet.Size = new System.Drawing.Size(199, 213);
            this.grpPlebSheet.TabIndex = 0;
            this.grpPlebSheet.TabStop = false;
            this.grpPlebSheet.Text = "Character sheet";
            // 
            // lstPlebSheet
            // 
            this.lstPlebSheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrait,
            this.colValue});
            this.lstPlebSheet.FullRowSelect = true;
            this.lstPlebSheet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPlebSheet.Location = new System.Drawing.Point(6, 19);
            this.lstPlebSheet.Name = "lstPlebSheet";
            this.lstPlebSheet.Size = new System.Drawing.Size(187, 185);
            this.lstPlebSheet.TabIndex = 1;
            this.lstPlebSheet.UseCompatibleStateImageBehavior = false;
            this.lstPlebSheet.View = System.Windows.Forms.View.Details;
            // 
            // colTrait
            // 
            this.colTrait.Text = "Stats";
            this.colTrait.Width = 80;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 102;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlCharacterCreation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMenuJoin);
            this.Controls.Add(this.txtMenuUsername);
            this.Controls.Add(this.txtMenuPassword);
            this.Controls.Add(this.butMenuCreate);
            this.Controls.Add(this.butMenuNew);
            this.Controls.Add(this.butMenuPlay);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PlebQuest 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCharacterCreation.ResumeLayout(false);
            this.pnlCharacterCreation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.grpMP.ResumeLayout(false);
            this.gpbQuest.ResumeLayout(false);
            this.gpbQuest.PerformLayout();
            this.grpSpeels.ResumeLayout(false);
            this.gpbInventory.ResumeLayout(false);
            this.gpbInventory.PerformLayout();
            this.grpEquipment.ResumeLayout(false);
            this.grpRegion.ResumeLayout(false);
            this.grpRegion.PerformLayout();
            this.grpLevel.ResumeLayout(false);
            this.grpHP.ResumeLayout(false);
            this.grpPlebSheet.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butMenuPlay;
        private System.Windows.Forms.Button butMenuNew;
        private System.Windows.Forms.Button butMenuCreate;
        private System.Windows.Forms.TextBox txtMenuPassword;
        private System.Windows.Forms.TextBox txtMenuUsername;
        private System.Windows.Forms.Button butMenuJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCharacterCreation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butRoll;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.ListBox lstCreationClass;
        private System.Windows.Forms.TextBox txtCreationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCreationRace;
        private System.Windows.Forms.Button butCreationStart;
        private System.Windows.Forms.Button butCancelCreation;
        private System.Windows.Forms.ListView lstCreationStat;
        private System.Windows.Forms.ColumnHeader colCreationStat;
        private System.Windows.Forms.ColumnHeader colCreationStatValue;
        private System.Windows.Forms.TextBox txtCreationTotalStats;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton butCreationMale;
        private System.Windows.Forms.RadioButton butCreationFemale;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.GroupBox grpPlebSheet;
        private System.Windows.Forms.ListView lstPlebSheet;
        private System.Windows.Forms.ColumnHeader colTrait;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRegion;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.ProgressBar pgbExp;
        private System.Windows.Forms.GroupBox grpHP;
        private System.Windows.Forms.ProgressBar pgbHP;
        private System.Windows.Forms.GroupBox grpEquipment;
        private System.Windows.Forms.ListView lstEquipment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ProgressBar pgbAction;
        private System.Windows.Forms.RichTextBox txtRegion;
        private System.Windows.Forms.GroupBox gpbInventory;
        private System.Windows.Forms.ProgressBar pgbEncumbrance;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.GroupBox grpSpeels;
        private System.Windows.Forms.ListBox lstSpeel;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.GroupBox gpbQuest;
        private System.Windows.Forms.RichTextBox txtCurrentObjective;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.ListView lstQuest;
        private System.Windows.Forms.ColumnHeader colQuest;
        private System.Windows.Forms.GroupBox grpMP;
        private System.Windows.Forms.ProgressBar pgbMP;
        private System.Windows.Forms.StatusStrip stbAction;
    }
}

