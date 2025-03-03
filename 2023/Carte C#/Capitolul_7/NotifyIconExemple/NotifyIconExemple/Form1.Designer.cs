namespace NotifyIconExemple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ascundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reafiseazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ascunde forma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascundeToolStripMenuItem,
            this.reafiseazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // ascundeToolStripMenuItem
            // 
            this.ascundeToolStripMenuItem.Name = "ascundeToolStripMenuItem";
            this.ascundeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ascundeToolStripMenuItem.Text = "Ascunde";
            this.ascundeToolStripMenuItem.Click += new System.EventHandler(this.ascundeToolStripMenuItem_Click);
            // 
            // reafiseazaToolStripMenuItem
            // 
            this.reafiseazaToolStripMenuItem.Name = "reafiseazaToolStripMenuItem";
            this.reafiseazaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.reafiseazaToolStripMenuItem.Text = "Reafiseaza";
            this.reafiseazaToolStripMenuItem.Click += new System.EventHandler(this.reafiseazaToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ascunde forma";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ascundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reafiseazaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

