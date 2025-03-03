namespace PollutionMap
{
    partial class Vizualizare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizualizare));
            this.tabHarta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFiltru = new System.Windows.Forms.Label();
            this.cmbFiltru = new System.Windows.Forms.ComboBox();
            this.pbHarti = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbHarta = new System.Windows.Forms.ComboBox();
            this.tbTraseu = new System.Windows.Forms.TabPage();
            this.btnIesire = new System.Windows.Forms.Button();
            this.lblCerintaTitlu = new System.Windows.Forms.Label();
            this.lblCerinta = new System.Windows.Forms.Label();
            this.pbHartiTraseu = new System.Windows.Forms.PictureBox();
            this.tabHarta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHarti)).BeginInit();
            this.tbTraseu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHartiTraseu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHarta
            // 
            this.tabHarta.Controls.Add(this.tabPage1);
            this.tabHarta.Controls.Add(this.tbTraseu);
            this.tabHarta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHarta.Location = new System.Drawing.Point(0, 0);
            this.tabHarta.Name = "tabHarta";
            this.tabHarta.SelectedIndex = 0;
            this.tabHarta.Size = new System.Drawing.Size(950, 522);
            this.tabHarta.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::PollutionMap.Properties.Resources.back4;
            this.tabPage1.Controls.Add(this.btnFiltrare);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.lblFiltru);
            this.tabPage1.Controls.Add(this.cmbFiltru);
            this.tabPage1.Controls.Add(this.pbHarti);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cmbHarta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VeziHarta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrare.Location = new System.Drawing.Point(35, 365);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(117, 51);
            this.btnFiltrare.TabIndex = 5;
            this.btnFiltrare.Text = "Filtrare";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            this.btnFiltrare.Click += new System.EventHandler(this.btnFiltrare_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(35, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 51);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reseteaza flitru";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFiltru
            // 
            this.lblFiltru.AutoSize = true;
            this.lblFiltru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltru.Location = new System.Drawing.Point(20, 257);
            this.lblFiltru.Name = "lblFiltru";
            this.lblFiltru.Size = new System.Drawing.Size(40, 18);
            this.lblFiltru.TabIndex = 4;
            this.lblFiltru.Text = "Filtru";
            this.lblFiltru.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltru
            // 
            this.cmbFiltru.FormattingEnabled = true;
            this.cmbFiltru.Location = new System.Drawing.Point(23, 278);
            this.cmbFiltru.Name = "cmbFiltru";
            this.cmbFiltru.Size = new System.Drawing.Size(141, 21);
            this.cmbFiltru.TabIndex = 3;
            this.cmbFiltru.Text = "Niciun filtru";
            // 
            // pbHarti
            // 
            this.pbHarti.Location = new System.Drawing.Point(288, 10);
            this.pbHarti.Name = "pbHarti";
            this.pbHarti.Size = new System.Drawing.Size(640, 470);
            this.pbHarti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHarti.TabIndex = 2;
            this.pbHarti.TabStop = false;
            this.pbHarti.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHarti_Paint);
            this.pbHarti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbHarti_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd    dd/MM/yyyy hh:mm";
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbHarta
            // 
            this.cmbHarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHarta.FormattingEnabled = true;
            this.cmbHarta.Location = new System.Drawing.Point(23, 38);
            this.cmbHarta.Name = "cmbHarta";
            this.cmbHarta.Size = new System.Drawing.Size(182, 24);
            this.cmbHarta.TabIndex = 0;
            this.cmbHarta.Text = "Selecteaza o harta";
            this.cmbHarta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbTraseu
            // 
            this.tbTraseu.Controls.Add(this.btnIesire);
            this.tbTraseu.Controls.Add(this.lblCerintaTitlu);
            this.tbTraseu.Controls.Add(this.lblCerinta);
            this.tbTraseu.Controls.Add(this.pbHartiTraseu);
            this.tbTraseu.Location = new System.Drawing.Point(4, 22);
            this.tbTraseu.Name = "tbTraseu";
            this.tbTraseu.Padding = new System.Windows.Forms.Padding(3);
            this.tbTraseu.Size = new System.Drawing.Size(942, 496);
            this.tbTraseu.TabIndex = 1;
            this.tbTraseu.Text = "Traseu";
            this.tbTraseu.UseVisualStyleBackColor = true;
            // 
            // btnIesire
            // 
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(62, 411);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(129, 53);
            this.btnIesire.TabIndex = 3;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblCerintaTitlu
            // 
            this.lblCerintaTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerintaTitlu.ForeColor = System.Drawing.Color.Red;
            this.lblCerintaTitlu.Location = new System.Drawing.Point(25, 44);
            this.lblCerintaTitlu.Name = "lblCerintaTitlu";
            this.lblCerintaTitlu.Size = new System.Drawing.Size(80, 36);
            this.lblCerintaTitlu.TabIndex = 2;
            this.lblCerintaTitlu.Text = "Cerinta";
            this.lblCerintaTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCerinta
            // 
            this.lblCerinta.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerinta.Location = new System.Drawing.Point(26, 80);
            this.lblCerinta.Name = "lblCerinta";
            this.lblCerinta.Size = new System.Drawing.Size(227, 220);
            this.lblCerinta.TabIndex = 1;
            this.lblCerinta.Text = resources.GetString("lblCerinta.Text");
            this.lblCerinta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbHartiTraseu
            // 
            this.pbHartiTraseu.Image = global::PollutionMap.Properties.Resources.default_harta;
            this.pbHartiTraseu.Location = new System.Drawing.Point(294, 6);
            this.pbHartiTraseu.Name = "pbHartiTraseu";
            this.pbHartiTraseu.Size = new System.Drawing.Size(640, 480);
            this.pbHartiTraseu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHartiTraseu.TabIndex = 0;
            this.pbHartiTraseu.TabStop = false;
            this.pbHartiTraseu.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHartiTraseu_Paint);
            this.pbHartiTraseu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbHartiTraseu_MouseClick);
            // 
            // Vizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 522);
            this.Controls.Add(this.tabHarta);
            this.Name = "Vizualizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare";
            this.Load += new System.EventHandler(this.Vizualizare_Load);
            this.tabHarta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHarti)).EndInit();
            this.tbTraseu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHartiTraseu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHarta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbTraseu;
        private System.Windows.Forms.ComboBox cmbHarta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFiltru;
        private System.Windows.Forms.ComboBox cmbFiltru;
        private System.Windows.Forms.PictureBox pbHarti;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFiltrare;
        private System.Windows.Forms.PictureBox pbHartiTraseu;
        private System.Windows.Forms.Label lblCerintaTitlu;
        private System.Windows.Forms.Label lblCerinta;
        private System.Windows.Forms.Button btnIesire;
    }
}