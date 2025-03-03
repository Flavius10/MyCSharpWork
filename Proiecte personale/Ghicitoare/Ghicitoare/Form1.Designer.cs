namespace Ghicitoare
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
            this.txtNumarGhicit = new System.Windows.Forms.TextBox();
            this.txtNumarRandom = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnGhiceste = new System.Windows.Forms.Button();
            this.btnReseteaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumarGhicit
            // 
            this.txtNumarGhicit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumarGhicit.Location = new System.Drawing.Point(249, 12);
            this.txtNumarGhicit.Name = "txtNumarGhicit";
            this.txtNumarGhicit.Size = new System.Drawing.Size(100, 80);
            this.txtNumarGhicit.TabIndex = 0;
            this.txtNumarGhicit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumarRandom
            // 
            this.txtNumarRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumarRandom.Location = new System.Drawing.Point(12, 12);
            this.txtNumarRandom.Name = "txtNumarRandom";
            this.txtNumarRandom.ReadOnly = true;
            this.txtNumarRandom.Size = new System.Drawing.Size(100, 80);
            this.txtNumarRandom.TabIndex = 1;
            this.txtNumarRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(12, 120);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(120, 53);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // btnGhiceste
            // 
            this.btnGhiceste.BackColor = System.Drawing.Color.Cyan;
            this.btnGhiceste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiceste.Location = new System.Drawing.Point(229, 120);
            this.btnGhiceste.Name = "btnGhiceste";
            this.btnGhiceste.Size = new System.Drawing.Size(120, 53);
            this.btnGhiceste.TabIndex = 2;
            this.btnGhiceste.Text = "Giceste";
            this.btnGhiceste.UseVisualStyleBackColor = false;
            this.btnGhiceste.Click += new System.EventHandler(this.btnGhiceste_Click);
            // 
            // btnReseteaza
            // 
            this.btnReseteaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReseteaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseteaza.Location = new System.Drawing.Point(122, 179);
            this.btnReseteaza.Name = "btnReseteaza";
            this.btnReseteaza.Size = new System.Drawing.Size(116, 54);
            this.btnReseteaza.TabIndex = 3;
            this.btnReseteaza.Text = "Reseteaza";
            this.btnReseteaza.UseVisualStyleBackColor = false;
            this.btnReseteaza.Click += new System.EventHandler(this.btnReseteaza_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(139, 36);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 4;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 243);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReseteaza);
            this.Controls.Add(this.btnGhiceste);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtNumarRandom);
            this.Controls.Add(this.txtNumarGhicit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumarGhicit;
        private System.Windows.Forms.TextBox txtNumarRandom;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnGhiceste;
        private System.Windows.Forms.Button btnReseteaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
    }
}

