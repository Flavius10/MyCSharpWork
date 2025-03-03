namespace Desenare_PictureBox
{
    partial class CropForm
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
            this.btnSelecteazaImagine = new System.Windows.Forms.Button();
            this.pbImagine = new System.Windows.Forms.PictureBox();
            this.pbImagineCrop = new System.Windows.Forms.PictureBox();
            this.btnSalveazaImaginea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecteazaImagine
            // 
            this.btnSelecteazaImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecteazaImagine.Location = new System.Drawing.Point(12, 12);
            this.btnSelecteazaImagine.Name = "btnSelecteazaImagine";
            this.btnSelecteazaImagine.Size = new System.Drawing.Size(123, 61);
            this.btnSelecteazaImagine.TabIndex = 0;
            this.btnSelecteazaImagine.Text = "Selecteaza imagine";
            this.btnSelecteazaImagine.UseVisualStyleBackColor = true;
            this.btnSelecteazaImagine.Click += new System.EventHandler(this.btnSelecteazaImagine_Click);
            // 
            // pbImagine
            // 
            this.pbImagine.Location = new System.Drawing.Point(13, 93);
            this.pbImagine.Name = "pbImagine";
            this.pbImagine.Size = new System.Drawing.Size(246, 244);
            this.pbImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagine.TabIndex = 1;
            this.pbImagine.TabStop = false;
            // 
            // pbImagineCrop
            // 
            this.pbImagineCrop.Location = new System.Drawing.Point(281, 13);
            this.pbImagineCrop.Name = "pbImagineCrop";
            this.pbImagineCrop.Size = new System.Drawing.Size(612, 552);
            this.pbImagineCrop.TabIndex = 2;
            this.pbImagineCrop.TabStop = false;
            // 
            // btnSalveazaImaginea
            // 
            this.btnSalveazaImaginea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaImaginea.Location = new System.Drawing.Point(13, 483);
            this.btnSalveazaImaginea.Name = "btnSalveazaImaginea";
            this.btnSalveazaImaginea.Size = new System.Drawing.Size(122, 82);
            this.btnSalveazaImaginea.TabIndex = 0;
            this.btnSalveazaImaginea.Text = "Salveaza imaginea feliata\r\n";
            this.btnSalveazaImaginea.UseVisualStyleBackColor = true;
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 577);
            this.Controls.Add(this.pbImagineCrop);
            this.Controls.Add(this.pbImagine);
            this.Controls.Add(this.btnSalveazaImaginea);
            this.Controls.Add(this.btnSelecteazaImagine);
            this.Name = "CropForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CropForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineCrop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecteazaImagine;
        private System.Windows.Forms.PictureBox pbImagine;
        private System.Windows.Forms.PictureBox pbImagineCrop;
        private System.Windows.Forms.Button btnSalveazaImaginea;
    }
}