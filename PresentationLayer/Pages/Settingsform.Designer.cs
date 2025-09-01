namespace PresentationLayer
{
    partial class Settingsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settingsform));
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.openMusicBtn = new System.Windows.Forms.Button();
            this.closeMusicBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(879, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 76);
            this.label1.TabIndex = 15;
            this.label1.Text = "MUSIC";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitBtn.Location = new System.Drawing.Point(568, 334);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(250, 80);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(111, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 91);
            this.label2.TabIndex = 20;
            this.label2.Text = "Barn Management";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logOutBtn.Location = new System.Drawing.Point(568, 233);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(250, 80);
            this.logOutBtn.TabIndex = 21;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // openMusicBtn
            // 
            this.openMusicBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openMusicBtn.BackgroundImage")));
            this.openMusicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openMusicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openMusicBtn.Location = new System.Drawing.Point(127, 334);
            this.openMusicBtn.Name = "openMusicBtn";
            this.openMusicBtn.Size = new System.Drawing.Size(100, 80);
            this.openMusicBtn.TabIndex = 22;
            this.openMusicBtn.UseVisualStyleBackColor = true;
            this.openMusicBtn.Click += new System.EventHandler(this.openMusicBtn_Click);
            // 
            // closeMusicBtn
            // 
            this.closeMusicBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeMusicBtn.BackgroundImage")));
            this.closeMusicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeMusicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeMusicBtn.Location = new System.Drawing.Point(267, 334);
            this.closeMusicBtn.Name = "closeMusicBtn";
            this.closeMusicBtn.Size = new System.Drawing.Size(100, 80);
            this.closeMusicBtn.TabIndex = 23;
            this.closeMusicBtn.UseVisualStyleBackColor = true;
            this.closeMusicBtn.Click += new System.EventHandler(this.closeMusicBtn_Click);
            // 
            // Settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.closeMusicBtn);
            this.Controls.Add(this.openMusicBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settingsform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settingsform";
            this.Load += new System.EventHandler(this.Settingsform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button openMusicBtn;
        private System.Windows.Forms.Button closeMusicBtn;
    }
}