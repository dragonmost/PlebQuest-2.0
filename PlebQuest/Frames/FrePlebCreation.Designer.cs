namespace PlebQuest.Frames
{
    partial class FrePlebCreation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.pnlCharacterCreation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlCharacterCreation.Size = new System.Drawing.Size(626, 440);
            this.pnlCharacterCreation.TabIndex = 12;
            // 
            // butCreationMale
            // 
            this.butCreationMale.Appearance = System.Windows.Forms.Appearance.Button;
            this.butCreationMale.AutoSize = true;
            this.butCreationMale.Checked = true;
            this.butCreationMale.Location = new System.Drawing.Point(295, 4);
            this.butCreationMale.Name = "butCreationMale";
            this.butCreationMale.Size = new System.Drawing.Size(25, 23);
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
            this.butCreationFemale.Size = new System.Drawing.Size(23, 23);
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
            this.butCreationStart.Click += new System.EventHandler(this.butCreationStart_Click);
            // 
            // FrePlebCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCharacterCreation);
            this.Name = "FrePlebCreation";
            this.Size = new System.Drawing.Size(626, 440);
            this.pnlCharacterCreation.ResumeLayout(false);
            this.pnlCharacterCreation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCharacterCreation;
        private System.Windows.Forms.RadioButton butCreationMale;
        private System.Windows.Forms.RadioButton butCreationFemale;
        private System.Windows.Forms.Button butCancelCreation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCreationTotalStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstCreationStat;
        private System.Windows.Forms.ColumnHeader colCreationStat;
        private System.Windows.Forms.ColumnHeader colCreationStatValue;
        private System.Windows.Forms.Button butRoll;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.ListBox lstCreationClass;
        private System.Windows.Forms.TextBox txtCreationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCreationRace;
        private System.Windows.Forms.Button butCreationStart;
    }
}
