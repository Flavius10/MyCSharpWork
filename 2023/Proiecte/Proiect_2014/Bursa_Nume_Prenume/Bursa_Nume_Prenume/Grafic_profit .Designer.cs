namespace Bursa_Nume_Prenume
{
    partial class Grafic_profit
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
            this.lblY = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblY
            // 
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(2, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(100, 23);
            this.lblY.TabIndex = 0;
            this.lblY.Text = "Valoare";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.Location = new System.Drawing.Point(13, 395);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(14, 16);
            this.lbl0.TabIndex = 0;
            this.lbl0.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(601, 395);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(38, 16);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "Timp";
            // 
            // Grafic_profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lblY);
            this.Name = "Grafic_profit";
            this.Text = "Grafic_profit";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Grafic_profit_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lblX;
    }
}