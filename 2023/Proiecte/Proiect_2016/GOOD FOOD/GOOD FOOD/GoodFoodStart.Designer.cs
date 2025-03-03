namespace GOOD_FOOD
{
    partial class GoodFoodStart
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
            this.lblDescriere = new System.Windows.Forms.Label();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnautentificare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescriere
            // 
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDescriere.Location = new System.Drawing.Point(5, 9);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(696, 61);
            this.lblDescriere.TabIndex = 0;
            this.lblDescriere.Text = "Meniuri diverse caracterizate de transparenta si\r\n excelenta\r\n";
            this.lblDescriere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(71, 337);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(136, 50);
            this.btnInregistrare.TabIndex = 1;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnautentificare
            // 
            this.btnautentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnautentificare.Location = new System.Drawing.Point(520, 337);
            this.btnautentificare.Name = "btnautentificare";
            this.btnautentificare.Size = new System.Drawing.Size(148, 50);
            this.btnautentificare.TabIndex = 1;
            this.btnautentificare.Text = "Autentificare";
            this.btnautentificare.UseVisualStyleBackColor = true;
            this.btnautentificare.Click += new System.EventHandler(this.btnautentificare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GOOD_FOOD.Properties.Resources.good_food_2;
            this.pictureBox1.Location = new System.Drawing.Point(128, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GoodFoodStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnautentificare);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.lblDescriere);
            this.Name = "GoodFoodStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnautentificare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

