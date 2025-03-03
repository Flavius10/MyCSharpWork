namespace PuzzleImage
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImageBrowse = new System.Windows.Forms.Button();
            this.textboxImagePath = new System.Windows.Forms.TextBox();
            this.groupboxPuzzle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLevel4 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImageBrowse);
            this.groupBox1.Controls.Add(this.textboxImagePath);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alege Imagine";
            // 
            // buttonImageBrowse
            // 
            this.buttonImageBrowse.Location = new System.Drawing.Point(698, 20);
            this.buttonImageBrowse.Name = "buttonImageBrowse";
            this.buttonImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonImageBrowse.TabIndex = 1;
            this.buttonImageBrowse.Text = "...";
            this.buttonImageBrowse.UseVisualStyleBackColor = true;
            this.buttonImageBrowse.Click += new System.EventHandler(this.buttonImageBrowse_Click);
            // 
            // textboxImagePath
            // 
            this.textboxImagePath.Location = new System.Drawing.Point(7, 20);
            this.textboxImagePath.Name = "textboxImagePath";
            this.textboxImagePath.Size = new System.Drawing.Size(685, 22);
            this.textboxImagePath.TabIndex = 0;
            // 
            // groupboxPuzzle
            // 
            this.groupboxPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPuzzle.Location = new System.Drawing.Point(20, 102);
            this.groupboxPuzzle.Name = "groupboxPuzzle";
            this.groupboxPuzzle.Size = new System.Drawing.Size(444, 444);
            this.groupboxPuzzle.TabIndex = 1;
            this.groupboxPuzzle.TabStop = false;
            this.groupboxPuzzle.Text = "Puzzle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLevel4);
            this.groupBox2.Controls.Add(this.btnLevel2);
            this.groupBox2.Controls.Add(this.btnLevel3);
            this.groupBox2.Controls.Add(this.btnLevel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play Mode";
            // 
            // btnLevel4
            // 
            this.btnLevel4.Location = new System.Drawing.Point(72, 153);
            this.btnLevel4.Name = "btnLevel4";
            this.btnLevel4.Size = new System.Drawing.Size(137, 30);
            this.btnLevel4.TabIndex = 0;
            this.btnLevel4.Text = "Level 4";
            this.btnLevel4.UseVisualStyleBackColor = true;
            this.btnLevel4.Click += new System.EventHandler(this.btnLevel4_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Location = new System.Drawing.Point(72, 81);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(137, 30);
            this.btnLevel2.TabIndex = 0;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.Location = new System.Drawing.Point(72, 117);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(137, 30);
            this.btnLevel3.TabIndex = 0;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = true;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.Location = new System.Drawing.Point(72, 45);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(137, 30);
            this.btnLevel1.TabIndex = 0;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelStatus);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(496, 371);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(290, 175);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(29, 16);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Idle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 563);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupboxPuzzle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Puzzle Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImageBrowse;
        private System.Windows.Forms.TextBox textboxImagePath;
        private System.Windows.Forms.GroupBox groupboxPuzzle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLevel4;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelStatus;
    }
}

