namespace Timer_Test
{
    partial class Iesire
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
            this.lblIesire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIesire
            // 
            this.lblIesire.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIesire.Location = new System.Drawing.Point(12, 9);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(569, 167);
            this.lblIesire.TabIndex = 0;
            this.lblIesire.Text = "Multumim pentru folosirea aplicatiei!!";
            this.lblIesire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Iesire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(593, 185);
            this.Controls.Add(this.lblIesire);
            this.Name = "Iesire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iesire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIesire;
    }
}