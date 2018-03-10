namespace PlebQuest.Frames
{
    partial class FreMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreMainMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butMenuJoin = new System.Windows.Forms.Button();
            this.txtMenuUsername = new System.Windows.Forms.TextBox();
            this.txtMenuPassword = new System.Windows.Forms.TextBox();
            this.butMenuCreate = new System.Windows.Forms.Button();
            this.butMenuNew = new System.Windows.Forms.Button();
            this.butMenuPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username";
            // 
            // butMenuJoin
            // 
            this.butMenuJoin.Location = new System.Drawing.Point(503, 398);
            this.butMenuJoin.Name = "butMenuJoin";
            this.butMenuJoin.Size = new System.Drawing.Size(100, 23);
            this.butMenuJoin.TabIndex = 14;
            this.butMenuJoin.Text = "Join";
            this.butMenuJoin.UseVisualStyleBackColor = true;
            this.butMenuJoin.Click += new System.EventHandler(this.butMenuJoin_Click);
            // 
            // txtMenuUsername
            // 
            this.txtMenuUsername.Location = new System.Drawing.Point(269, 343);
            this.txtMenuUsername.Name = "txtMenuUsername";
            this.txtMenuUsername.Size = new System.Drawing.Size(100, 20);
            this.txtMenuUsername.TabIndex = 12;
            // 
            // txtMenuPassword
            // 
            this.txtMenuPassword.Location = new System.Drawing.Point(269, 372);
            this.txtMenuPassword.Name = "txtMenuPassword";
            this.txtMenuPassword.Size = new System.Drawing.Size(100, 20);
            this.txtMenuPassword.TabIndex = 13;
            this.txtMenuPassword.UseSystemPasswordChar = true;
            // 
            // butMenuCreate
            // 
            this.butMenuCreate.Location = new System.Drawing.Point(503, 369);
            this.butMenuCreate.Name = "butMenuCreate";
            this.butMenuCreate.Size = new System.Drawing.Size(100, 23);
            this.butMenuCreate.TabIndex = 15;
            this.butMenuCreate.Text = "Create Account";
            this.butMenuCreate.UseVisualStyleBackColor = true;
            this.butMenuCreate.Click += new System.EventHandler(this.butMenuCreate_Click);
            // 
            // butMenuNew
            // 
            this.butMenuNew.Location = new System.Drawing.Point(3, 398);
            this.butMenuNew.Name = "butMenuNew";
            this.butMenuNew.Size = new System.Drawing.Size(121, 23);
            this.butMenuNew.TabIndex = 17;
            this.butMenuNew.Text = "new Pleb";
            this.butMenuNew.UseVisualStyleBackColor = true;
            this.butMenuNew.Click += new System.EventHandler(this.butMenuNew_Click);
            // 
            // butMenuPlay
            // 
            this.butMenuPlay.Location = new System.Drawing.Point(3, 369);
            this.butMenuPlay.Name = "butMenuPlay";
            this.butMenuPlay.Size = new System.Drawing.Size(121, 23);
            this.butMenuPlay.TabIndex = 16;
            this.butMenuPlay.Text = "Browse Plebs";
            this.butMenuPlay.UseVisualStyleBackColor = true;
            this.butMenuPlay.Click += new System.EventHandler(this.butMenuPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 334);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FreMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMenuJoin);
            this.Controls.Add(this.txtMenuUsername);
            this.Controls.Add(this.txtMenuPassword);
            this.Controls.Add(this.butMenuCreate);
            this.Controls.Add(this.butMenuNew);
            this.Controls.Add(this.butMenuPlay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FreMainMenu";
            this.Size = new System.Drawing.Size(611, 438);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butMenuJoin;
        private System.Windows.Forms.TextBox txtMenuUsername;
        private System.Windows.Forms.TextBox txtMenuPassword;
        private System.Windows.Forms.Button butMenuCreate;
        private System.Windows.Forms.Button butMenuNew;
        private System.Windows.Forms.Button butMenuPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
