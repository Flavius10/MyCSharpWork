namespace Trex
{
    partial class TREX
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trex1 = new System.Windows.Forms.PictureBox();
            this.obs1 = new System.Windows.Forms.PictureBox();
            this.obs2 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Trex1
            // 
            this.Trex1.Image = global::Trex.Properties.Resources.running;
            this.Trex1.Location = new System.Drawing.Point(105, 370);
            this.Trex1.Name = "Trex1";
            this.Trex1.Size = new System.Drawing.Size(50, 49);
            this.Trex1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trex1.TabIndex = 1;
            this.Trex1.TabStop = false;
            // 
            // obs1
            // 
            this.obs1.Image = global::Trex.Properties.Resources.obstacle_1;
            this.obs1.Location = new System.Drawing.Point(444, 374);
            this.obs1.Name = "obs1";
            this.obs1.Size = new System.Drawing.Size(26, 50);
            this.obs1.TabIndex = 1;
            this.obs1.TabStop = false;
            this.obs1.Tag = "obstacle";
            // 
            // obs2
            // 
            this.obs2.Image = global::Trex.Properties.Resources.obstacle_2;
            this.obs2.Location = new System.Drawing.Point(583, 370);
            this.obs2.Name = "obs2";
            this.obs2.Size = new System.Drawing.Size(40, 49);
            this.obs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs2.TabIndex = 1;
            this.obs2.TabStop = false;
            this.obs2.Tag = "obstacle";
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(13, 13);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(271, 23);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 35;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // TREX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obs2);
            this.Controls.Add(this.obs1);
            this.Controls.Add(this.Trex1);
            this.Name = "TREX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TREX_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TREX_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Trex1;
        private System.Windows.Forms.PictureBox obs1;
        private System.Windows.Forms.PictureBox obs2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
    }
}

