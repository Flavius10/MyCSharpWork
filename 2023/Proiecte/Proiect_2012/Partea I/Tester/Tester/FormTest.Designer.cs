namespace Tester
{
    partial class FormTest
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
            this.txtCerinta = new System.Windows.Forms.TextBox();
            this.grpPrimaIntrebare = new System.Windows.Forms.GroupBox();
            this.patru = new System.Windows.Forms.CheckBox();
            this.trei = new System.Windows.Forms.CheckBox();
            this.doi = new System.Windows.Forms.CheckBox();
            this.unu = new System.Windows.Forms.CheckBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnValidare = new System.Windows.Forms.Button();
            this.btnFinalizareTest = new System.Windows.Forms.Button();
            this.btnInchidere = new System.Windows.Forms.Button();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.unu1 = new System.Windows.Forms.RadioButton();
            this.doi2 = new System.Windows.Forms.RadioButton();
            this.trei3 = new System.Windows.Forms.RadioButton();
            this.patru4 = new System.Windows.Forms.RadioButton();
            this.grpRadio = new System.Windows.Forms.GroupBox();
            this.grpPrimaIntrebare.SuspendLayout();
            this.grpRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCerinta
            // 
            this.txtCerinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerinta.ForeColor = System.Drawing.Color.Blue;
            this.txtCerinta.Location = new System.Drawing.Point(14, 14);
            this.txtCerinta.Margin = new System.Windows.Forms.Padding(5);
            this.txtCerinta.Multiline = true;
            this.txtCerinta.Name = "txtCerinta";
            this.txtCerinta.Size = new System.Drawing.Size(806, 31);
            this.txtCerinta.TabIndex = 0;
            this.txtCerinta.Text = "Care dintre tipurile de date de mai jos nu apartin limbajului C++?";
            this.txtCerinta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPrimaIntrebare
            // 
            this.grpPrimaIntrebare.Controls.Add(this.patru);
            this.grpPrimaIntrebare.Controls.Add(this.trei);
            this.grpPrimaIntrebare.Controls.Add(this.doi);
            this.grpPrimaIntrebare.Controls.Add(this.unu);
            this.grpPrimaIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrimaIntrebare.Location = new System.Drawing.Point(413, 116);
            this.grpPrimaIntrebare.Margin = new System.Windows.Forms.Padding(0);
            this.grpPrimaIntrebare.Name = "grpPrimaIntrebare";
            this.grpPrimaIntrebare.Size = new System.Drawing.Size(188, 220);
            this.grpPrimaIntrebare.TabIndex = 1;
            this.grpPrimaIntrebare.TabStop = false;
            this.grpPrimaIntrebare.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // patru
            // 
            this.patru.AutoSize = true;
            this.patru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patru.Location = new System.Drawing.Point(7, 118);
            this.patru.Name = "patru";
            this.patru.Size = new System.Drawing.Size(95, 21);
            this.patru.TabIndex = 2;
            this.patru.Text = "checkBox4";
            this.patru.UseVisualStyleBackColor = true;
            // 
            // trei
            // 
            this.trei.AutoSize = true;
            this.trei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trei.Location = new System.Drawing.Point(7, 88);
            this.trei.Name = "trei";
            this.trei.Size = new System.Drawing.Size(95, 21);
            this.trei.TabIndex = 2;
            this.trei.Text = "checkBox3";
            this.trei.UseVisualStyleBackColor = true;
            // 
            // doi
            // 
            this.doi.AutoSize = true;
            this.doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doi.Location = new System.Drawing.Point(7, 57);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(95, 21);
            this.doi.TabIndex = 1;
            this.doi.Text = "checkBox2";
            this.doi.UseVisualStyleBackColor = true;
            // 
            // unu
            // 
            this.unu.AutoSize = true;
            this.unu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unu.Location = new System.Drawing.Point(7, 30);
            this.unu.Name = "unu";
            this.unu.Size = new System.Drawing.Size(95, 21);
            this.unu.TabIndex = 0;
            this.unu.Text = "checkBox1";
            this.unu.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(24, 417);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(144, 48);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(663, 417);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 48);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnValidare
            // 
            this.btnValidare.Location = new System.Drawing.Point(305, 411);
            this.btnValidare.Name = "btnValidare";
            this.btnValidare.Size = new System.Drawing.Size(198, 54);
            this.btnValidare.TabIndex = 3;
            this.btnValidare.Text = "Validare";
            this.btnValidare.UseVisualStyleBackColor = true;
            this.btnValidare.Click += new System.EventHandler(this.btnValidare_Click);
            // 
            // btnFinalizareTest
            // 
            this.btnFinalizareTest.Location = new System.Drawing.Point(663, 306);
            this.btnFinalizareTest.Name = "btnFinalizareTest";
            this.btnFinalizareTest.Size = new System.Drawing.Size(144, 60);
            this.btnFinalizareTest.TabIndex = 4;
            this.btnFinalizareTest.Text = "Finalizare test";
            this.btnFinalizareTest.UseVisualStyleBackColor = true;
            this.btnFinalizareTest.Click += new System.EventHandler(this.btnFinalizareTest_Click);
            // 
            // btnInchidere
            // 
            this.btnInchidere.Location = new System.Drawing.Point(24, 306);
            this.btnInchidere.Name = "btnInchidere";
            this.btnInchidere.Size = new System.Drawing.Size(144, 60);
            this.btnInchidere.TabIndex = 5;
            this.btnInchidere.Text = "Inchidere";
            this.btnInchidere.UseVisualStyleBackColor = true;
            this.btnInchidere.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.Location = new System.Drawing.Point(628, 86);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(143, 59);
            this.lblPunctaj.TabIndex = 6;
            this.lblPunctaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unu1
            // 
            this.unu1.AutoSize = true;
            this.unu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unu1.Location = new System.Drawing.Point(6, 26);
            this.unu1.Name = "unu1";
            this.unu1.Size = new System.Drawing.Size(107, 21);
            this.unu1.TabIndex = 3;
            this.unu1.TabStop = true;
            this.unu1.Text = "radioButton1";
            this.unu1.UseVisualStyleBackColor = true;
            // 
            // doi2
            // 
            this.doi2.AutoSize = true;
            this.doi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doi2.Location = new System.Drawing.Point(6, 58);
            this.doi2.Name = "doi2";
            this.doi2.Size = new System.Drawing.Size(107, 21);
            this.doi2.TabIndex = 4;
            this.doi2.TabStop = true;
            this.doi2.Text = "radioButton2";
            this.doi2.UseVisualStyleBackColor = true;
            // 
            // trei3
            // 
            this.trei3.AutoSize = true;
            this.trei3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trei3.Location = new System.Drawing.Point(6, 86);
            this.trei3.Name = "trei3";
            this.trei3.Size = new System.Drawing.Size(107, 21);
            this.trei3.TabIndex = 5;
            this.trei3.TabStop = true;
            this.trei3.Text = "radioButton3";
            this.trei3.UseVisualStyleBackColor = true;
            // 
            // patru4
            // 
            this.patru4.AutoSize = true;
            this.patru4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patru4.Location = new System.Drawing.Point(6, 115);
            this.patru4.Name = "patru4";
            this.patru4.Size = new System.Drawing.Size(107, 21);
            this.patru4.TabIndex = 6;
            this.patru4.TabStop = true;
            this.patru4.Text = "radioButton4";
            this.patru4.UseVisualStyleBackColor = true;
            // 
            // grpRadio
            // 
            this.grpRadio.Controls.Add(this.patru4);
            this.grpRadio.Controls.Add(this.unu1);
            this.grpRadio.Controls.Add(this.trei3);
            this.grpRadio.Controls.Add(this.doi2);
            this.grpRadio.Location = new System.Drawing.Point(190, 116);
            this.grpRadio.Name = "grpRadio";
            this.grpRadio.Size = new System.Drawing.Size(200, 220);
            this.grpRadio.TabIndex = 7;
            this.grpRadio.TabStop = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.grpRadio);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.btnInchidere);
            this.Controls.Add(this.btnFinalizareTest);
            this.Controls.Add(this.btnValidare);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.grpPrimaIntrebare);
            this.Controls.Add(this.txtCerinta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIA 2012 – Etapa județeană";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.grpPrimaIntrebare.ResumeLayout(false);
            this.grpPrimaIntrebare.PerformLayout();
            this.grpRadio.ResumeLayout(false);
            this.grpRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCerinta;
        private System.Windows.Forms.GroupBox grpPrimaIntrebare;
        private System.Windows.Forms.CheckBox patru;
        private System.Windows.Forms.CheckBox trei;
        private System.Windows.Forms.CheckBox doi;
        private System.Windows.Forms.CheckBox unu;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnValidare;
        private System.Windows.Forms.Button btnFinalizareTest;
        private System.Windows.Forms.Button btnInchidere;
        private System.Windows.Forms.Label lblPunctaj;
        private System.Windows.Forms.RadioButton patru4;
        private System.Windows.Forms.RadioButton trei3;
        private System.Windows.Forms.RadioButton doi2;
        private System.Windows.Forms.RadioButton unu1;
        private System.Windows.Forms.GroupBox grpRadio;
    }
}