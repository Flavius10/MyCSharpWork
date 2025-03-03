namespace Tester
{
    partial class FormLogare
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lansareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeUtilizator = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtNumeUtilizator = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogare = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ati venit! Mult succes!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testerToolStripMenuItem
            // 
            this.testerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lansareToolStripMenuItem,
            this.inchidereToolStripMenuItem});
            this.testerToolStripMenuItem.Name = "testerToolStripMenuItem";
            this.testerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.testerToolStripMenuItem.Text = "Tester";
            // 
            // lansareToolStripMenuItem
            // 
            this.lansareToolStripMenuItem.Name = "lansareToolStripMenuItem";
            this.lansareToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.lansareToolStripMenuItem.Text = "Lansare test";
            this.lansareToolStripMenuItem.Click += new System.EventHandler(this.lansareToolStripMenuItem_Click);
            // 
            // inchidereToolStripMenuItem
            // 
            this.inchidereToolStripMenuItem.Name = "inchidereToolStripMenuItem";
            this.inchidereToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.inchidereToolStripMenuItem.Text = "Inchidere";
            this.inchidereToolStripMenuItem.Click += new System.EventHandler(this.inchidereToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 93);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pentru a lansa testul selectati meniul Tester\r\ndupa care submeniul Lansare test";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeUtilizator
            // 
            this.lblNumeUtilizator.AutoSize = true;
            this.lblNumeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeUtilizator.Location = new System.Drawing.Point(166, 222);
            this.lblNumeUtilizator.Name = "lblNumeUtilizator";
            this.lblNumeUtilizator.Size = new System.Drawing.Size(102, 17);
            this.lblNumeUtilizator.TabIndex = 3;
            this.lblNumeUtilizator.Text = "Nume utilizator";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(166, 268);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(49, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Parola";
            // 
            // txtNumeUtilizator
            // 
            this.txtNumeUtilizator.Location = new System.Drawing.Point(298, 222);
            this.txtNumeUtilizator.Name = "txtNumeUtilizator";
            this.txtNumeUtilizator.Size = new System.Drawing.Size(244, 20);
            this.txtNumeUtilizator.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(298, 268);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(244, 20);
            this.txtPass.TabIndex = 5;
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(440, 339);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(102, 41);
            this.btnLogare.TabIndex = 6;
            this.btnLogare.Text = "Log In";
            this.btnLogare.UseVisualStyleBackColor = true;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // FormLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNumeUtilizator);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNumeUtilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIA 2012 – Etapa județeană";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lansareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchidereToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeUtilizator;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtNumeUtilizator;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogare;
    }
}

