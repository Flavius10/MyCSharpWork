namespace Puzzle_Nume_Prenume
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jucatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnLogare = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logare";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 85);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pt a va loga alegeti din meniu \r\nintre cont de jucator sau in caz contrar adminis" +
    "trator\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logareToolStripMenuItem
            // 
            this.logareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jucatorToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.logareToolStripMenuItem.Name = "logareToolStripMenuItem";
            this.logareToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.logareToolStripMenuItem.Text = " Logare";
            // 
            // jucatorToolStripMenuItem
            // 
            this.jucatorToolStripMenuItem.Name = "jucatorToolStripMenuItem";
            this.jucatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jucatorToolStripMenuItem.Text = "Jucator";
            this.jucatorToolStripMenuItem.Click += new System.EventHandler(this.jucatorToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(289, 199);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(156, 20);
            this.txtNume.TabIndex = 4;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(292, 246);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(153, 20);
            this.txtParola.TabIndex = 4;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(231, 198);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(52, 18);
            this.lblNume.TabIndex = 5;
            this.lblNume.Text = "Nume:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(231, 245);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(55, 18);
            this.lblParola.TabIndex = 5;
            this.lblParola.Text = "Parola:";
            // 
            // btnLogare
            // 
            this.btnLogare.Location = new System.Drawing.Point(302, 288);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(132, 51);
            this.btnLogare.TabIndex = 6;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // FormLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jucatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnLogare;
    }
}

