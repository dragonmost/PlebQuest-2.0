namespace PlebQuest.Frames
{
    partial class FreGame
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
            this.pnlGame.Size = new System.Drawing.Size(784, 567);
            this.pnlGame.TabIndex = 13;
            // 
            // stbAction
            // 
            this.stbAction.Location = new System.Drawing.Point(0, 543);
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
            this.pgbMP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            this.pgbEncumbrance.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbEncumbrance.TabIndex = 14;
            // 
            // pgbAction
            // 
            this.pgbAction.Location = new System.Drawing.Point(3, 508);
            this.pgbAction.Name = "pgbAction";
            this.pgbAction.Size = new System.Drawing.Size(776, 27);
            this.pgbAction.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            this.pgbExp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            this.pgbHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            // FreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGame);
            this.Name = "FreGame";
            this.Size = new System.Drawing.Size(784, 567);
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

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.StatusStrip stbAction;
        private System.Windows.Forms.GroupBox grpMP;
        private System.Windows.Forms.ProgressBar pgbMP;
        private System.Windows.Forms.GroupBox gpbQuest;
        private System.Windows.Forms.ListView lstQuest;
        private System.Windows.Forms.ColumnHeader colQuest;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.RichTextBox txtCurrentObjective;
        private System.Windows.Forms.GroupBox grpSpeels;
        private System.Windows.Forms.ListBox lstSpeel;
        private System.Windows.Forms.GroupBox gpbInventory;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.ProgressBar pgbEncumbrance;
        private System.Windows.Forms.ProgressBar pgbAction;
        private System.Windows.Forms.GroupBox grpEquipment;
        private System.Windows.Forms.ListView lstEquipment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox grpRegion;
        private System.Windows.Forms.RichTextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.ProgressBar pgbExp;
        private System.Windows.Forms.GroupBox grpHP;
        private System.Windows.Forms.ProgressBar pgbHP;
        private System.Windows.Forms.GroupBox grpPlebSheet;
        private System.Windows.Forms.ListView lstPlebSheet;
        private System.Windows.Forms.ColumnHeader colTrait;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}
