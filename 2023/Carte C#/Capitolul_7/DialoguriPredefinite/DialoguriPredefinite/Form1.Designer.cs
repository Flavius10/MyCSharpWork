namespace DialoguriPredefinite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setarePaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previzualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideToolStripMenuItem,
            this.salveazaCaToolStripMenuItem,
            this.setarePaginaToolStripMenuItem,
            this.imprimareToolStripMenuItem,
            this.previzualizareToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "&Fisier";
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschideToolStripMenuItem.Text = "&Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // salveazaCaToolStripMenuItem
            // 
            this.salveazaCaToolStripMenuItem.Name = "salveazaCaToolStripMenuItem";
            this.salveazaCaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazaCaToolStripMenuItem.Text = "&Salveaza ca";
            this.salveazaCaToolStripMenuItem.Click += new System.EventHandler(this.salveazaCaToolStripMenuItem_Click);
            // 
            // setarePaginaToolStripMenuItem
            // 
            this.setarePaginaToolStripMenuItem.Name = "setarePaginaToolStripMenuItem";
            this.setarePaginaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setarePaginaToolStripMenuItem.Text = "S&etare pagina";
            this.setarePaginaToolStripMenuItem.Click += new System.EventHandler(this.setarePaginaToolStripMenuItem_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimareToolStripMenuItem.Text = "&Imprimare";
            this.imprimareToolStripMenuItem.Click += new System.EventHandler(this.imprimareToolStripMenuItem_Click);
            // 
            // previzualizareToolStripMenuItem
            // 
            this.previzualizareToolStripMenuItem.Name = "previzualizareToolStripMenuItem";
            this.previzualizareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.previzualizareToolStripMenuItem.Text = "&Previzualizare";
            this.previzualizareToolStripMenuItem.Click += new System.EventHandler(this.previzualizareToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.culoriToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // culoriToolStripMenuItem
            // 
            this.culoriToolStripMenuItem.Name = "culoriToolStripMenuItem";
            this.culoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.culoriToolStripMenuItem.Text = "&Culori";
            this.culoriToolStripMenuItem.Click += new System.EventHandler(this.culoriToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setarePaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previzualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoriToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

