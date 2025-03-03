namespace Puzzle_Nume_Prenume
{
    partial class FormJoc4
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDeschideImagine = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.grbPuzzle = new System.Windows.Forms.GroupBox();
            this.grbOriginal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbOriginal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDeschideImagine
            // 
            this.btnDeschideImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeschideImagine.Location = new System.Drawing.Point(865, 12);
            this.btnDeschideImagine.Name = "btnDeschideImagine";
            this.btnDeschideImagine.Size = new System.Drawing.Size(135, 47);
            this.btnDeschideImagine.TabIndex = 2;
            this.btnDeschideImagine.Text = "Deschide IMG";
            this.btnDeschideImagine.UseVisualStyleBackColor = true;
            this.btnDeschideImagine.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(609, 426);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(391, 82);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbPuzzle
            // 
            this.grbPuzzle.Location = new System.Drawing.Point(22, 12);
            this.grbPuzzle.Name = "grbPuzzle";
            this.grbPuzzle.Size = new System.Drawing.Size(503, 486);
            this.grbPuzzle.TabIndex = 4;
            this.grbPuzzle.TabStop = false;
            this.grbPuzzle.Text = "Puzzle";
            // 
            // grbOriginal
            // 
            this.grbOriginal.Controls.Add(this.pictureBox1);
            this.grbOriginal.Location = new System.Drawing.Point(614, 62);
            this.grbOriginal.Name = "grbOriginal";
            this.grbOriginal.Size = new System.Drawing.Size(386, 319);
            this.grbOriginal.TabIndex = 5;
            this.grbOriginal.TabStop = false;
            this.grbOriginal.Text = "Original";
            // 
            // FormJoc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 555);
            this.Controls.Add(this.grbOriginal);
            this.Controls.Add(this.grbPuzzle);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnDeschideImagine);
            this.Name = "FormJoc4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbOriginal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeschideImagine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox grbPuzzle;
        private System.Windows.Forms.GroupBox grbOriginal;
    }
}