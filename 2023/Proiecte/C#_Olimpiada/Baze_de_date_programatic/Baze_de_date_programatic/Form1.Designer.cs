namespace Baze_de_date_programatic
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
            this.dgwAngajati = new System.Windows.Forms.DataGridView();
            this.gbInsereaza = new System.Windows.Forms.GroupBox();
            this.btnInsereaza = new System.Windows.Forms.Button();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.txtPozitie = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.dgwInsereaza = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPozitieU = new System.Windows.Forms.TextBox();
            this.txtSalariuU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwUpdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAngajati)).BeginInit();
            this.gbInsereaza.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAngajati
            // 
            this.dgwAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAngajati.Location = new System.Drawing.Point(13, 12);
            this.dgwAngajati.Name = "dgwAngajati";
            this.dgwAngajati.Size = new System.Drawing.Size(815, 309);
            this.dgwAngajati.TabIndex = 0;
            this.dgwAngajati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAngajati_CellContentClick);
            // 
            // gbInsereaza
            // 
            this.gbInsereaza.Controls.Add(this.btnInsereaza);
            this.gbInsereaza.Controls.Add(this.txtSalariu);
            this.gbInsereaza.Controls.Add(this.txtPozitie);
            this.gbInsereaza.Controls.Add(this.txtNume);
            this.gbInsereaza.Controls.Add(this.dgwInsereaza);
            this.gbInsereaza.Controls.Add(this.label4);
            this.gbInsereaza.Controls.Add(this.label3);
            this.gbInsereaza.Controls.Add(this.label2);
            this.gbInsereaza.Controls.Add(this.label1);
            this.gbInsereaza.Location = new System.Drawing.Point(13, 328);
            this.gbInsereaza.Name = "gbInsereaza";
            this.gbInsereaza.Size = new System.Drawing.Size(355, 181);
            this.gbInsereaza.TabIndex = 1;
            this.gbInsereaza.TabStop = false;
            this.gbInsereaza.Text = "Insereaza Angajat";
            // 
            // btnInsereaza
            // 
            this.btnInsereaza.Location = new System.Drawing.Point(238, 122);
            this.btnInsereaza.Name = "btnInsereaza";
            this.btnInsereaza.Size = new System.Drawing.Size(102, 53);
            this.btnInsereaza.TabIndex = 3;
            this.btnInsereaza.Text = "Insereaza";
            this.btnInsereaza.UseVisualStyleBackColor = true;
            this.btnInsereaza.Click += new System.EventHandler(this.btnInsereaza_Click);
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(49, 87);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(231, 20);
            this.txtSalariu.TabIndex = 2;
            // 
            // txtPozitie
            // 
            this.txtPozitie.Location = new System.Drawing.Point(49, 54);
            this.txtPozitie.Name = "txtPozitie";
            this.txtPozitie.Size = new System.Drawing.Size(231, 20);
            this.txtPozitie.TabIndex = 2;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(49, 20);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(231, 20);
            this.txtNume.TabIndex = 2;
            // 
            // dgwInsereaza
            // 
            this.dgwInsereaza.Location = new System.Drawing.Point(6, 126);
            this.dgwInsereaza.Name = "dgwInsereaza";
            this.dgwInsereaza.Size = new System.Drawing.Size(200, 20);
            this.dgwInsereaza.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salariu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pozitie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.txtId);
            this.gbUpdate.Controls.Add(this.label8);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.txtPozitieU);
            this.gbUpdate.Controls.Add(this.txtSalariuU);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.txtNumeU);
            this.gbUpdate.Controls.Add(this.label7);
            this.gbUpdate.Controls.Add(this.dgwUpdate);
            this.gbUpdate.Location = new System.Drawing.Point(473, 328);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(355, 181);
            this.gbUpdate.TabIndex = 1;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "UpdateAngajat";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(209, 20);
            this.txtId.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Id_angajator";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPozitieU
            // 
            this.txtPozitieU.Location = new System.Drawing.Point(66, 87);
            this.txtPozitieU.Name = "txtPozitieU";
            this.txtPozitieU.Size = new System.Drawing.Size(231, 20);
            this.txtPozitieU.TabIndex = 2;
            // 
            // txtSalariuU
            // 
            this.txtSalariuU.Location = new System.Drawing.Point(66, 122);
            this.txtSalariuU.Name = "txtSalariuU";
            this.txtSalariuU.Size = new System.Drawing.Size(172, 20);
            this.txtSalariuU.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pozitie";
            // 
            // txtNumeU
            // 
            this.txtNumeU.Location = new System.Drawing.Point(66, 54);
            this.txtNumeU.Name = "txtNumeU";
            this.txtNumeU.Size = new System.Drawing.Size(231, 20);
            this.txtNumeU.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salariu";
            // 
            // dgwUpdate
            // 
            this.dgwUpdate.Location = new System.Drawing.Point(6, 155);
            this.dgwUpdate.Name = "dgwUpdate";
            this.dgwUpdate.Size = new System.Drawing.Size(200, 20);
            this.dgwUpdate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbInsereaza);
            this.Controls.Add(this.dgwAngajati);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAngajati)).EndInit();
            this.gbInsereaza.ResumeLayout(false);
            this.gbInsereaza.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAngajati;
        private System.Windows.Forms.GroupBox gbInsereaza;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.DateTimePicker dgwInsereaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnInsereaza;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.TextBox txtPozitie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPozitieU;
        private System.Windows.Forms.TextBox txtSalariuU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dgwUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
    }
}

