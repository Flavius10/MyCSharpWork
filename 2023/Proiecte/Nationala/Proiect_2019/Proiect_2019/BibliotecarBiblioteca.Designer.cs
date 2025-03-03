namespace Proiect_2019
{
    partial class BibliotecarBiblioteca
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
            this.pbPoza = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbPozaCont = new System.Windows.Forms.PictureBox();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnInregistreaza = new System.Windows.Forms.Button();
            this.rbBib = new System.Windows.Forms.RadioButton();
            this.rbCit = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtResetare = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumePrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCititor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCititor = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgwImprumuturi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoza)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozaCont)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCititor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCititor)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImprumuturi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPoza
            // 
            this.pbPoza.Location = new System.Drawing.Point(13, 13);
            this.pbPoza.Name = "pbPoza";
            this.pbPoza.Size = new System.Drawing.Size(143, 151);
            this.pbPoza.TabIndex = 0;
            this.pbPoza.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbPozaCont);
            this.tabPage1.Controls.Add(this.btnIncarca);
            this.tabPage1.Controls.Add(this.btnRenunta);
            this.tabPage1.Controls.Add(this.btnInregistreaza);
            this.tabPage1.Controls.Add(this.rbBib);
            this.tabPage1.Controls.Add(this.rbCit);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtResetare);
            this.tabPage1.Controls.Add(this.txtParola);
            this.tabPage1.Controls.Add(this.txtNume);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "InregistreazaUtilizator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbPozaCont
            // 
            this.pbPozaCont.Location = new System.Drawing.Point(412, 78);
            this.pbPozaCont.Name = "pbPozaCont";
            this.pbPozaCont.Size = new System.Drawing.Size(163, 146);
            this.pbPozaCont.TabIndex = 22;
            this.pbPozaCont.TabStop = false;
            // 
            // btnIncarca
            // 
            this.btnIncarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncarca.Location = new System.Drawing.Point(467, 13);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(95, 33);
            this.btnIncarca.TabIndex = 21;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click_1);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(264, 338);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(104, 46);
            this.btnRenunta.TabIndex = 19;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnInregistreaza
            // 
            this.btnInregistreaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistreaza.Location = new System.Drawing.Point(14, 338);
            this.btnInregistreaza.Name = "btnInregistreaza";
            this.btnInregistreaza.Size = new System.Drawing.Size(104, 46);
            this.btnInregistreaza.TabIndex = 20;
            this.btnInregistreaza.Text = "Inregistreaza";
            this.btnInregistreaza.UseVisualStyleBackColor = true;
            this.btnInregistreaza.Click += new System.EventHandler(this.btnInregistreaza_Click);
            // 
            // rbBib
            // 
            this.rbBib.AutoSize = true;
            this.rbBib.Location = new System.Drawing.Point(32, 152);
            this.rbBib.Name = "rbBib";
            this.rbBib.Size = new System.Drawing.Size(73, 17);
            this.rbBib.TabIndex = 17;
            this.rbBib.TabStop = true;
            this.rbBib.Text = "bibliotecar";
            this.rbBib.UseVisualStyleBackColor = true;
            this.rbBib.CheckedChanged += new System.EventHandler(this.rbBib_CheckedChanged);
            // 
            // rbCit
            // 
            this.rbCit.AutoSize = true;
            this.rbCit.Location = new System.Drawing.Point(211, 152);
            this.rbCit.Name = "rbCit";
            this.rbCit.Size = new System.Drawing.Size(50, 17);
            this.rbCit.TabIndex = 18;
            this.rbCit.TabStop = true;
            this.rbCit.Text = "cititor";
            this.rbCit.UseVisualStyleBackColor = true;
            this.rbCit.CheckedChanged += new System.EventHandler(this.rbCit_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtResetare
            // 
            this.txtResetare.Location = new System.Drawing.Point(154, 281);
            this.txtResetare.Name = "txtResetare";
            this.txtResetare.PasswordChar = '*';
            this.txtResetare.Size = new System.Drawing.Size(214, 20);
            this.txtResetare.TabIndex = 14;
            this.txtResetare.TextChanged += new System.EventHandler(this.txtResetare_TextChanged);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(154, 215);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(214, 20);
            this.txtParola.TabIndex = 15;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(154, 26);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(214, 20);
            this.txtNume.TabIndex = 16;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "Repetare parola:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 42);
            this.label7.TabIndex = 9;
            this.label7.Text = "Parola:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 42);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 42);
            this.label9.TabIndex = 11;
            this.label9.Text = "Poza:\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 42);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nume si prenume:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtNumePrenume);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgwCititor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AfisareCititori";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(826, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cauta\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumePrenume
            // 
            this.txtNumePrenume.Location = new System.Drawing.Point(777, 50);
            this.txtNumePrenume.Name = "txtNumePrenume";
            this.txtNumePrenume.Size = new System.Drawing.Size(235, 20);
            this.txtNumePrenume.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(788, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume si prenume:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwCititor
            // 
            this.dgwCititor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCititor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCititor.Location = new System.Drawing.Point(7, 7);
            this.dgwCititor.Name = "dgwCititor";
            this.dgwCititor.Size = new System.Drawing.Size(760, 389);
            this.dgwCititor.TabIndex = 0;
            this.dgwCititor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCititor_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.pbCititor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1028, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cititor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdCititor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCititor
            // 
            this.pbCititor.Location = new System.Drawing.Point(7, 7);
            this.pbCititor.Name = "pbCititor";
            this.pbCititor.Size = new System.Drawing.Size(132, 128);
            this.pbCititor.TabIndex = 0;
            this.pbCititor.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(734, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(311, 42);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNume
            // 
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(172, 14);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(311, 42);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "label1";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(7, 141);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1015, 249);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgwImprumuturi);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1007, 223);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "CartiImprumutate";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1007, 223);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "CartiRezervate";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1007, 223);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "ImprumutaCarte";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1007, 223);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "PropunereLectura";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgwImprumuturi
            // 
            this.dgwImprumuturi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwImprumuturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwImprumuturi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwImprumuturi.Location = new System.Drawing.Point(3, 3);
            this.dgwImprumuturi.Name = "dgwImprumuturi";
            this.dgwImprumuturi.Size = new System.Drawing.Size(1001, 217);
            this.dgwImprumuturi.TabIndex = 0;
            // 
            // BibliotecarBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 604);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbPoza);
            this.Name = "BibliotecarBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BibliotecarBiblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.pbPoza)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozaCont)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCititor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCititor)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwImprumuturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoza;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.PictureBox pbPozaCont;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnInregistreaza;
        private System.Windows.Forms.RadioButton rbBib;
        private System.Windows.Forms.RadioButton rbCit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtResetare;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgwCititor;
        private System.Windows.Forms.TextBox txtNumePrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCititor;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dgwImprumuturi;
    }
}