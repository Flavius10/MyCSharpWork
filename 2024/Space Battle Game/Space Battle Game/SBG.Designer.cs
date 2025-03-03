namespace Space_Battle_Game
{
    partial class SBG
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
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // enemy1
            // 
            this.enemy1.Location = new System.Drawing.Point(29, 13);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(140, 140);
            this.enemy1.TabIndex = 0;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Location = new System.Drawing.Point(226, 13);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(140, 140);
            this.enemy2.TabIndex = 0;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Location = new System.Drawing.Point(414, 13);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(140, 140);
            this.enemy3.TabIndex = 0;
            this.enemy3.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Location = new System.Drawing.Point(601, 12);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(140, 140);
            this.enemy4.TabIndex = 0;
            this.enemy4.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.Location = new System.Drawing.Point(796, 13);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(140, 140);
            this.enemy5.TabIndex = 0;
            this.enemy5.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Location = new System.Drawing.Point(244, 355);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(36, 76);
            this.bullet.TabIndex = 1;
            this.bullet.TabStop = false;
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(414, 551);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(140, 140);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // SBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 703);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy1);
            this.Name = "SBG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Battle Game";
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer playTimer;
    }
}

