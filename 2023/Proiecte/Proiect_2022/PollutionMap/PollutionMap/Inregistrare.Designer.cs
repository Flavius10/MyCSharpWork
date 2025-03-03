namespace PollutionMap
{
    partial class Inregistrare
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
            this.gbCreeazaCont = new System.Windows.Forms.GroupBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmare = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfirmare = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.gbCreeazaCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreeazaCont
            // 
            this.gbCreeazaCont.BackColor = System.Drawing.Color.Wheat;
            this.gbCreeazaCont.Controls.Add(this.btnRenunta);
            this.gbCreeazaCont.Controls.Add(this.btnSalvare);
            this.gbCreeazaCont.Controls.Add(this.txtEmail);
            this.gbCreeazaCont.Controls.Add(this.txtConfirmare);
            this.gbCreeazaCont.Controls.Add(this.txtParola);
            this.gbCreeazaCont.Controls.Add(this.txtNume);
            this.gbCreeazaCont.Controls.Add(this.lblEmail);
            this.gbCreeazaCont.Controls.Add(this.lblConfirmare);
            this.gbCreeazaCont.Controls.Add(this.lblParola);
            this.gbCreeazaCont.Controls.Add(this.lblNume);
            this.gbCreeazaCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreeazaCont.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gbCreeazaCont.Location = new System.Drawing.Point(104, 29);
            this.gbCreeazaCont.Name = "gbCreeazaCont";
            this.gbCreeazaCont.Size = new System.Drawing.Size(454, 396);
            this.gbCreeazaCont.TabIndex = 0;
            this.gbCreeazaCont.TabStop = false;
            this.gbCreeazaCont.Text = "Creeaza cont";
            // 
            // btnRenunta
            // 
            this.btnRenunta.ForeColor = System.Drawing.Color.Red;
            this.btnRenunta.Location = new System.Drawing.Point(291, 320);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(124, 53);
            this.btnRenunta.TabIndex = 3;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvare.Location = new System.Drawing.Point(35, 320);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(124, 53);
            this.btnSalvare.TabIndex = 3;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(35, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // txtConfirmare
            // 
            this.txtConfirmare.Location = new System.Drawing.Point(35, 186);
            this.txtConfirmare.Name = "txtConfirmare";
            this.txtConfirmare.PasswordChar = '*';
            this.txtConfirmare.Size = new System.Drawing.Size(380, 24);
            this.txtConfirmare.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(35, 121);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(380, 24);
            this.txtParola.TabIndex = 2;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(35, 55);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(380, 24);
            this.txtNume.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(6, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblConfirmare
            // 
            this.lblConfirmare.AutoSize = true;
            this.lblConfirmare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblConfirmare.Location = new System.Drawing.Point(6, 165);
            this.lblConfirmare.Name = "lblConfirmare";
            this.lblConfirmare.Size = new System.Drawing.Size(127, 18);
            this.lblConfirmare.TabIndex = 0;
            this.lblConfirmare.Text = "Confirmare parola";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblParola.Location = new System.Drawing.Point(6, 99);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(51, 18);
            this.lblParola.TabIndex = 0;
            this.lblParola.Text = "Parola";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNume.Location = new System.Drawing.Point(6, 34);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(127, 18);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume de utilizator";
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.gbCreeazaCont);
            this.Name = "Inregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.gbCreeazaCont.ResumeLayout(false);
            this.gbCreeazaCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreeazaCont;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmare;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConfirmare;
    }
}