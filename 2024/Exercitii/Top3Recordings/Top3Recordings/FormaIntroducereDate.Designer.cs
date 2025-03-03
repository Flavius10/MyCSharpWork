namespace Top3Recordings
{
    partial class FormaIntroducereDate
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPunctaj = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(162, 112);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(214, 20);
            this.txtNume.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPunctaj
            // 
            this.txtPunctaj.Location = new System.Drawing.Point(162, 280);
            this.txtPunctaj.Name = "txtPunctaj";
            this.txtPunctaj.Size = new System.Drawing.Size(214, 20);
            this.txtPunctaj.TabIndex = 0;
            // 
            // lblNume
            // 
            this.lblNume.Location = new System.Drawing.Point(73, 112);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(50, 20);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume:";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(70, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.Location = new System.Drawing.Point(73, 270);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(50, 20);
            this.lblPunctaj.TabIndex = 1;
            this.lblPunctaj.Text = "Punctaj:";
            this.lblPunctaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSumbit
            // 
            this.btnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.Location = new System.Drawing.Point(195, 360);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(131, 61);
            this.btnSumbit.TabIndex = 2;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // FormaIntroducereDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtPunctaj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNume);
            this.Name = "FormaIntroducereDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroduceDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPunctaj;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPunctaj;
        private System.Windows.Forms.Button btnSumbit;
    }
}