namespace PlebQuest
{
    partial class MainMenu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.freGame = new PlebQuest.Frames.FreGame();
            this.freMainMenu = new PlebQuest.Frames.FreMainMenu();
            this.frePlebCreation = new PlebQuest.Frames.FrePlebCreation();
            this.SuspendLayout();
            // 
            // freGame1
            // 
            this.freGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freGame.Location = new System.Drawing.Point(0, 0);
            this.freGame.Name = "freGame1";
            this.freGame.Size = new System.Drawing.Size(784, 562);
            this.freGame.TabIndex = 0;
            // 
            // freMainMenu1
            // 
            this.freMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freMainMenu.Location = new System.Drawing.Point(0, 0);
            this.freMainMenu.Name = "freMainMenu1";
            this.freMainMenu.Size = new System.Drawing.Size(784, 562);
            this.freMainMenu.TabIndex = 1;
            // 
            // frePlebCreation1
            // 
            this.frePlebCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frePlebCreation.Location = new System.Drawing.Point(0, 0);
            this.frePlebCreation.Name = "frePlebCreation1";
            this.frePlebCreation.Size = new System.Drawing.Size(784, 562);
            this.frePlebCreation.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.freMainMenu);
            this.Controls.Add(this.freGame);
            this.Controls.Add(this.frePlebCreation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "PlebQuest 2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Frames.FreGame freGame;
        private Frames.FreMainMenu freMainMenu;
        private Frames.FrePlebCreation frePlebCreation;
    }
}

