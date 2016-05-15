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
            this.butPlay = new System.Windows.Forms.Button();
            this.butNew = new System.Windows.Forms.Button();
            this.butCreate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.butJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCharacterCreation = new System.Windows.Forms.Panel();
            this.butCancelCreation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCreationTotalStats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCreationStat = new System.Windows.Forms.ListView();
            this.colCreationStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreationStatValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butRoll = new System.Windows.Forms.Button();
            this.butGenerate = new System.Windows.Forms.Button();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.txtCreationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRace = new System.Windows.Forms.ListBox();
            this.butStart = new System.Windows.Forms.Button();
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
            // butPlay
            // 
            this.butPlay.Location = new System.Drawing.Point(12, 378);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(121, 23);
            this.butPlay.TabIndex = 5;
            this.butPlay.Text = "Browse Plebs";
            this.butPlay.UseVisualStyleBackColor = true;
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butNew
            // 
            this.butNew.Location = new System.Drawing.Point(12, 407);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(121, 23);
            this.butNew.TabIndex = 6;
            this.butNew.Text = "new Pleb";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(512, 378);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(100, 23);
            this.butCreate.TabIndex = 4;
            this.butCreate.Text = "Create Account";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(278, 381);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(278, 352);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // butJoin
            // 
            this.butJoin.Location = new System.Drawing.Point(512, 407);
            this.butJoin.Name = "butJoin";
            this.butJoin.Size = new System.Drawing.Size(100, 23);
            this.butJoin.TabIndex = 3;
            this.butJoin.Text = "Join";
            this.butJoin.UseVisualStyleBackColor = true;
            this.butJoin.Click += new System.EventHandler(this.butJoin_Click);
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
            this.pnlCharacterCreation.Controls.Add(this.butCancelCreation);
            this.pnlCharacterCreation.Controls.Add(this.groupBox1);
            this.pnlCharacterCreation.Controls.Add(this.butGenerate);
            this.pnlCharacterCreation.Controls.Add(this.lstClass);
            this.pnlCharacterCreation.Controls.Add(this.txtCreationName);
            this.pnlCharacterCreation.Controls.Add(this.label3);
            this.pnlCharacterCreation.Controls.Add(this.lstRace);
            this.pnlCharacterCreation.Controls.Add(this.butStart);
            this.pnlCharacterCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCharacterCreation.Location = new System.Drawing.Point(0, 0);
            this.pnlCharacterCreation.Name = "pnlCharacterCreation";
            this.pnlCharacterCreation.Size = new System.Drawing.Size(624, 442);
            this.pnlCharacterCreation.TabIndex = 11;
            this.pnlCharacterCreation.Visible = false;
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
            this.butGenerate.Location = new System.Drawing.Point(194, 6);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(75, 23);
            this.butGenerate.TabIndex = 5;
            this.butGenerate.Text = "Generate Pleb";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.Location = new System.Drawing.Point(194, 32);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(165, 355);
            this.lstClass.TabIndex = 4;
            // 
            // txtCreationName
            // 
            this.txtCreationName.Location = new System.Drawing.Point(77, 6);
            this.txtCreationName.Name = "txtCreationName";
            this.txtCreationName.Size = new System.Drawing.Size(100, 20);
            this.txtCreationName.TabIndex = 3;
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
            // lstRace
            // 
            this.lstRace.FormattingEnabled = true;
            this.lstRace.Location = new System.Drawing.Point(12, 32);
            this.lstRace.Name = "lstRace";
            this.lstRace.Size = new System.Drawing.Size(165, 355);
            this.lstRace.TabIndex = 1;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(537, 407);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.pnlCharacterCreation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butJoin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.butPlay);
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
        private System.Windows.Forms.Button butPlay;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button butJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCharacterCreation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butRoll;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.TextBox txtCreationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRace;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butCancelCreation;
        private System.Windows.Forms.ListView lstCreationStat;
        private System.Windows.Forms.ColumnHeader colCreationStat;
        private System.Windows.Forms.ColumnHeader colCreationStatValue;
        private System.Windows.Forms.TextBox txtCreationTotalStats;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

