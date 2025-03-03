namespace Bursa_Nume_Prenume
{
    partial class formPrincipalBusra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiunileMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeschideBursa = new System.Windows.Forms.Button();
            this.btnInchideBursa = new System.Windows.Forms.Button();
            this.lblRata = new System.Windows.Forms.Label();
            this.nudRata = new System.Windows.Forms.NumericUpDown();
            this.dgBursa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBursa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilizatorToolStripMenuItem
            // 
            this.utilizatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actiunileMeleToolStripMenuItem,
            this.graficProfitToolStripMenuItem});
            this.utilizatorToolStripMenuItem.Name = "utilizatorToolStripMenuItem";
            this.utilizatorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.utilizatorToolStripMenuItem.Text = "Utilizator";
            // 
            // actiunileMeleToolStripMenuItem
            // 
            this.actiunileMeleToolStripMenuItem.Name = "actiunileMeleToolStripMenuItem";
            this.actiunileMeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actiunileMeleToolStripMenuItem.Text = "Actiunile mele";
            this.actiunileMeleToolStripMenuItem.Click += new System.EventHandler(this.actiunileMeleToolStripMenuItem_Click);
            // 
            // graficProfitToolStripMenuItem
            // 
            this.graficProfitToolStripMenuItem.Name = "graficProfitToolStripMenuItem";
            this.graficProfitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graficProfitToolStripMenuItem.Text = "Grafic profit";
            this.graficProfitToolStripMenuItem.Click += new System.EventHandler(this.graficProfitToolStripMenuItem_Click);
            // 
            // btnDeschideBursa
            // 
            this.btnDeschideBursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeschideBursa.Location = new System.Drawing.Point(12, 27);
            this.btnDeschideBursa.Name = "btnDeschideBursa";
            this.btnDeschideBursa.Size = new System.Drawing.Size(128, 53);
            this.btnDeschideBursa.TabIndex = 1;
            this.btnDeschideBursa.Text = "Deschide Bursa";
            this.btnDeschideBursa.UseVisualStyleBackColor = true;
            this.btnDeschideBursa.Click += new System.EventHandler(this.btnDeschideBursa_Click);
            // 
            // btnInchideBursa
            // 
            this.btnInchideBursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchideBursa.Location = new System.Drawing.Point(166, 28);
            this.btnInchideBursa.Name = "btnInchideBursa";
            this.btnInchideBursa.Size = new System.Drawing.Size(131, 52);
            this.btnInchideBursa.TabIndex = 2;
            this.btnInchideBursa.Text = "Inchide Bursa";
            this.btnInchideBursa.UseVisualStyleBackColor = true;
            this.btnInchideBursa.Click += new System.EventHandler(this.btnInchideBursa_Click);
            // 
            // lblRata
            // 
            this.lblRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRata.Location = new System.Drawing.Point(323, 42);
            this.lblRata.Name = "lblRata";
            this.lblRata.Size = new System.Drawing.Size(160, 23);
            this.lblRata.TabIndex = 3;
            this.lblRata.Text = "Rata reimprospatare:";
            this.lblRata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRata
            // 
            this.nudRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRata.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudRata.Location = new System.Drawing.Point(519, 45);
            this.nudRata.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRata.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudRata.Name = "nudRata";
            this.nudRata.Size = new System.Drawing.Size(182, 22);
            this.nudRata.TabIndex = 4;
            this.nudRata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRata.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudRata.ValueChanged += new System.EventHandler(this.nudRata_ValueChanged);
            // 
            // dgBursa
            // 
            this.dgBursa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBursa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBursa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBursa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgBursa.Location = new System.Drawing.Point(0, 86);
            this.dgBursa.Name = "dgBursa";
            this.dgBursa.Size = new System.Drawing.Size(800, 363);
            this.dgBursa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // formPrincipalBusra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgBursa);
            this.Controls.Add(this.nudRata);
            this.Controls.Add(this.lblRata);
            this.Controls.Add(this.btnInchideBursa);
            this.Controls.Add(this.btnDeschideBursa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipalBusra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bursa";
            this.Load += new System.EventHandler(this.formPrincipalBusra_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBursa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actiunileMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficProfitToolStripMenuItem;
        private System.Windows.Forms.Button btnDeschideBursa;
        private System.Windows.Forms.Button btnInchideBursa;
        private System.Windows.Forms.Label lblRata;
        private System.Windows.Forms.NumericUpDown nudRata;
        private System.Windows.Forms.DataGridView dgBursa;
        private System.Windows.Forms.Label label1;
    }
}

