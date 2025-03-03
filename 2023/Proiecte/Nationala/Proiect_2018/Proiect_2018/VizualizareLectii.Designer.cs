namespace Proiect_2018
{
    partial class VizualizareLectii
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
            this.lblDescriere = new System.Windows.Forms.Label();
            this.lbLectii = new System.Windows.Forms.ListBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.pbImagine = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescriere
            // 
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriere.Location = new System.Drawing.Point(129, 9);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(473, 80);
            this.lblDescriere.TabIndex = 0;
            this.lblDescriere.Text = "Centenarul Marii Uniri de la 1918 - aceasta platforma este dedicata\r\naprofundarii" +
    " cunostintelor despre regiunile Marii Uniri de la 1918";
            this.lblDescriere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLectii
            // 
            this.lbLectii.FormattingEnabled = true;
            this.lbLectii.Location = new System.Drawing.Point(13, 90);
            this.lbLectii.Name = "lbLectii";
            this.lbLectii.Size = new System.Drawing.Size(167, 264);
            this.lbLectii.TabIndex = 1;
            this.lbLectii.SelectedIndexChanged += new System.EventHandler(this.lbLectii_SelectedIndexChanged);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.Location = new System.Drawing.Point(52, 361);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(85, 39);
            this.btnAfiseaza.TabIndex = 2;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // pbImagine
            // 
            this.pbImagine.Location = new System.Drawing.Point(199, 90);
            this.pbImagine.Name = "pbImagine";
            this.pbImagine.Size = new System.Drawing.Size(589, 284);
            this.pbImagine.TabIndex = 3;
            this.pbImagine.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(199, 385);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(589, 53);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // VizualizareLectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pbImagine);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.lbLectii);
            this.Controls.Add(this.lblDescriere);
            this.Name = "VizualizareLectii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareLectii";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.ListBox lbLectii;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.PictureBox pbImagine;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}