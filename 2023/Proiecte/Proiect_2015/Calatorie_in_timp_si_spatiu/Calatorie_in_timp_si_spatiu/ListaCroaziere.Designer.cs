namespace Calatorie_in_timp_si_spatiu
{
    partial class ListaCroaziere
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
            this.cmbCroaziera = new System.Windows.Forms.ComboBox();
            this.btnInchidere = new System.Windows.Forms.Button();
            this.dgvCroaziere = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCroaziere)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectati tipul de croaziera:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCroaziera
            // 
            this.cmbCroaziera.FormattingEnabled = true;
            this.cmbCroaziera.Location = new System.Drawing.Point(446, 45);
            this.cmbCroaziera.Name = "cmbCroaziera";
            this.cmbCroaziera.Size = new System.Drawing.Size(200, 21);
            this.cmbCroaziera.TabIndex = 1;
            this.cmbCroaziera.TabStop = false;
            this.cmbCroaziera.SelectedIndexChanged += new System.EventHandler(this.cmbCroaziera_SelectedIndexChanged);
            // 
            // btnInchidere
            // 
            this.btnInchidere.Location = new System.Drawing.Point(663, 399);
            this.btnInchidere.Name = "btnInchidere";
            this.btnInchidere.Size = new System.Drawing.Size(125, 39);
            this.btnInchidere.TabIndex = 2;
            this.btnInchidere.Text = "Inchidere";
            this.btnInchidere.UseVisualStyleBackColor = true;
            this.btnInchidere.Click += new System.EventHandler(this.btnInchidere_Click);
            // 
            // dgvCroaziere
            // 
            this.dgvCroaziere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCroaziere.Location = new System.Drawing.Point(13, 84);
            this.dgvCroaziere.Name = "dgvCroaziere";
            this.dgvCroaziere.Size = new System.Drawing.Size(633, 354);
            this.dgvCroaziere.TabIndex = 3;
            // 
            // ListaCroaziere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCroaziere);
            this.Controls.Add(this.btnInchidere);
            this.Controls.Add(this.cmbCroaziera);
            this.Controls.Add(this.label1);
            this.Name = "ListaCroaziere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaCroaziere";
            this.Load += new System.EventHandler(this.ListaCroaziere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCroaziere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCroaziera;
        private System.Windows.Forms.Button btnInchidere;
        private System.Windows.Forms.DataGridView dgvCroaziere;
    }
}