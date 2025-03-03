namespace Turismul_de_pretutindeni
{
    partial class FrmInregistrare
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
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbVerificare = new System.Windows.Forms.PictureBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtConfirmare = new System.Windows.Forms.TextBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerificare)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanner
            // 
            this.pbBanner.Image = global::Turismul_de_pretutindeni.Properties.Resources.Banner;
            this.pbBanner.Location = new System.Drawing.Point(13, 8);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(541, 135);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBanner.TabIndex = 0;
            this.pbBanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirmare parola:";
            // 
            // pbVerificare
            // 
            this.pbVerificare.Location = new System.Drawing.Point(182, 321);
            this.pbVerificare.Name = "pbVerificare";
            this.pbVerificare.Size = new System.Drawing.Size(179, 80);
            this.pbVerificare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerificare.TabIndex = 2;
            this.pbVerificare.TabStop = false;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(104, 165);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(367, 20);
            this.txtNume.TabIndex = 3;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(104, 196);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(367, 20);
            this.txtPrenume.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(104, 261);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(367, 20);
            this.txtParola.TabIndex = 3;
            // 
            // txtConfirmare
            // 
            this.txtConfirmare.Location = new System.Drawing.Point(104, 295);
            this.txtConfirmare.Name = "txtConfirmare";
            this.txtConfirmare.PasswordChar = '*';
            this.txtConfirmare.Size = new System.Drawing.Size(367, 20);
            this.txtConfirmare.TabIndex = 3;
            // 
            // btnRenunta
            // 
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(12, 451);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(110, 39);
            this.btnRenunta.TabIndex = 4;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(446, 451);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(110, 39);
            this.btnInregistrare.TabIndex = 4;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cod captcha:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(104, 418);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(367, 20);
            this.txtCod.TabIndex = 6;
            // 
            // FrmInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.txtConfirmare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.pbVerificare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBanner);
            this.Name = "FrmInregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInregistrare";
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerificare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbVerificare;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtConfirmare;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCod;
    }
}