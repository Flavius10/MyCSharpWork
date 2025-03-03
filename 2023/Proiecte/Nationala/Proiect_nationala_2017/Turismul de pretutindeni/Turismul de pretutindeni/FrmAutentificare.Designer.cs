namespace Turismul_de_pretutindeni
{
    partial class FrmAutentificare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.cbRetine = new System.Windows.Forms.CheckBox();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnAutientificare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(469, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(87, 283);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(464, 20);
            this.txtParola.TabIndex = 2;
            // 
            // cbRetine
            // 
            this.cbRetine.AutoSize = true;
            this.cbRetine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRetine.Location = new System.Drawing.Point(451, 340);
            this.cbRetine.Name = "cbRetine";
            this.cbRetine.Size = new System.Drawing.Size(108, 22);
            this.cbRetine.TabIndex = 3;
            this.cbRetine.Text = "Retine email";
            this.cbRetine.UseVisualStyleBackColor = true;
            this.cbRetine.CheckedChanged += new System.EventHandler(this.cbRetine_CheckedChanged);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(97, 401);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(115, 37);
            this.btnInregistrare.TabIndex = 4;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnAutientificare
            // 
            this.btnAutientificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutientificare.Location = new System.Drawing.Point(414, 401);
            this.btnAutientificare.Name = "btnAutientificare";
            this.btnAutientificare.Size = new System.Drawing.Size(115, 37);
            this.btnAutientificare.TabIndex = 4;
            this.btnAutientificare.Text = "Autentificare";
            this.btnAutientificare.UseVisualStyleBackColor = true;
            this.btnAutientificare.Click += new System.EventHandler(this.btnAutientificare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Turismul_de_pretutindeni.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(575, 477);
            this.Controls.Add(this.btnAutientificare);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.cbRetine);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAutentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutentificare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.CheckBox cbRetine;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnAutientificare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

