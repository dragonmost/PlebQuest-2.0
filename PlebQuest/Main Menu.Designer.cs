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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCharacterCreation.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.pnlCharacterCreation.Size = new System.Drawing.Size(624, 442);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
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
            this.Name = "Form1";
            this.Text = "PlebQuest 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCharacterCreation.ResumeLayout(false);
            this.pnlCharacterCreation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

