namespace Baze_de_date_programatic
{
    partial class UpdateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPozitie = new System.Windows.Forms.TextBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.dtpUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pozitie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salariu";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 53);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update Angajat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(61, 115);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(219, 20);
            this.txtNume.TabIndex = 1;
            // 
            // txtPozitie
            // 
            this.txtPozitie.Location = new System.Drawing.Point(64, 155);
            this.txtPozitie.Name = "txtPozitie";
            this.txtPozitie.Size = new System.Drawing.Size(216, 20);
            this.txtPozitie.TabIndex = 2;
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(58, 196);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(216, 20);
            this.txtSalariu.TabIndex = 3;
            // 
            // dtpUpdate
            // 
            this.dtpUpdate.Location = new System.Drawing.Point(61, 234);
            this.dtpUpdate.Name = "dtpUpdate";
            this.dtpUpdate.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdate.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(97, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 55);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id_angajat";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 81);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 20);
            this.txtId.TabIndex = 1;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 327);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpUpdate);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.txtPozitie);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPozitie;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.DateTimePicker dtpUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
    }
}