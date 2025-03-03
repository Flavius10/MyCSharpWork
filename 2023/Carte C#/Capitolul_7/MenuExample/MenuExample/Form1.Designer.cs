namespace MenuExample
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decupeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lipesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decupeazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lipesteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.editareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "&Fisier";
            // 
            // nouToolStripMenuItem
            // 
            this.nouToolStripMenuItem.Name = "nouToolStripMenuItem";
            this.nouToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouToolStripMenuItem.Text = "&Nou";
            this.nouToolStripMenuItem.Click += new System.EventHandler(this.nouToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iesireToolStripMenuItem.Text = "&Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiazaToolStripMenuItem,
            this.decupeazaToolStripMenuItem,
            this.lipesteToolStripMenuItem});
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editareToolStripMenuItem.Text = "&Editare";
            // 
            // copiazaToolStripMenuItem
            // 
            this.copiazaToolStripMenuItem.Name = "copiazaToolStripMenuItem";
            this.copiazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiazaToolStripMenuItem.Text = "&Copiaza";
            this.copiazaToolStripMenuItem.Click += new System.EventHandler(this.copiazaToolStripMenuItem_Click);
            // 
            // decupeazaToolStripMenuItem
            // 
            this.decupeazaToolStripMenuItem.Name = "decupeazaToolStripMenuItem";
            this.decupeazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decupeazaToolStripMenuItem.Text = "&Decupeaza";
            this.decupeazaToolStripMenuItem.Click += new System.EventHandler(this.decupeazaToolStripMenuItem_Click);
            // 
            // lipesteToolStripMenuItem
            // 
            this.lipesteToolStripMenuItem.Name = "lipesteToolStripMenuItem";
            this.lipesteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lipesteToolStripMenuItem.Text = "&Lipeste";
            this.lipesteToolStripMenuItem.Click += new System.EventHandler(this.lipesteToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.textBox1.Location = new System.Drawing.Point(0, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 254);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiazaToolStripMenuItem1,
            this.decupeazaToolStripMenuItem1,
            this.lipesteToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // copiazaToolStripMenuItem1
            // 
            this.copiazaToolStripMenuItem1.Name = "copiazaToolStripMenuItem1";
            this.copiazaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.copiazaToolStripMenuItem1.Text = "&Copiaza";
            this.copiazaToolStripMenuItem1.Click += new System.EventHandler(this.copiazaToolStripMenuItem1_Click);
            // 
            // decupeazaToolStripMenuItem1
            // 
            this.decupeazaToolStripMenuItem1.Name = "decupeazaToolStripMenuItem1";
            this.decupeazaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.decupeazaToolStripMenuItem1.Text = "&Decupeaza";
            this.decupeazaToolStripMenuItem1.Click += new System.EventHandler(this.decupeazaToolStripMenuItem1_Click);
            // 
            // lipesteToolStripMenuItem1
            // 
            this.lipesteToolStripMenuItem1.Name = "lipesteToolStripMenuItem1";
            this.lipesteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lipesteToolStripMenuItem1.Text = "&Lipeste";
            this.lipesteToolStripMenuItem1.Click += new System.EventHandler(this.lipesteToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decupeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lipesteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copiazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decupeazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lipesteToolStripMenuItem1;
    }
}

