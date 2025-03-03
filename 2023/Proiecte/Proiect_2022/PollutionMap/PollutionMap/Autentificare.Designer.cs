namespace PollutionMap
{
    partial class Autentificare
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLogare = new System.Windows.Forms.Button();
            this.btnContNou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.White;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(218, 152);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(218, 210);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(47, 16);
            this.lblParola.TabIndex = 0;
            this.lblParola.Text = "Parola";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(221, 171);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(222, 20);
            this.txtNume.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(221, 229);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(222, 20);
            this.txtParola.TabIndex = 2;
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(202, 291);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(120, 56);
            this.btnLogare.TabIndex = 3;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // btnContNou
            // 
            this.btnContNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContNou.Location = new System.Drawing.Point(363, 291);
            this.btnContNou.Name = "btnContNou";
            this.btnContNou.Size = new System.Drawing.Size(107, 56);
            this.btnContNou.TabIndex = 3;
            this.btnContNou.Text = "Cont Nou";
            this.btnContNou.UseVisualStyleBackColor = true;
            this.btnContNou.Click += new System.EventHandler(this.btnContNou_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PollutionMap.Properties.Resources.back3;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnContNou);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblNume);
            this.Name = "Autentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Logare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Button btnContNou;
    }
}

