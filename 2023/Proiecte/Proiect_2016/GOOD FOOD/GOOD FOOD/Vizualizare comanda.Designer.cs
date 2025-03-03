namespace GOOD_FOOD
{
    partial class Vizualizare_comanda
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
            this.dgwDate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNecesar = new System.Windows.Forms.TextBox();
            this.txtKcal = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnFinalizare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDate
            // 
            this.dgwDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDate.Location = new System.Drawing.Point(2, 3);
            this.dgwDate.Name = "dgwDate";
            this.dgwDate.Size = new System.Drawing.Size(797, 302);
            this.dgwDate.TabIndex = 0;
            this.dgwDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDate_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Necesar kcal zilnice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total kcal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pret total\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNecesar
            // 
            this.txtNecesar.Location = new System.Drawing.Point(151, 314);
            this.txtNecesar.Name = "txtNecesar";
            this.txtNecesar.ReadOnly = true;
            this.txtNecesar.Size = new System.Drawing.Size(111, 20);
            this.txtNecesar.TabIndex = 2;
            this.txtNecesar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKcal
            // 
            this.txtKcal.Location = new System.Drawing.Point(126, 348);
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.ReadOnly = true;
            this.txtKcal.Size = new System.Drawing.Size(111, 20);
            this.txtKcal.TabIndex = 2;
            this.txtKcal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(126, 382);
            this.txtPret.Name = "txtPret";
            this.txtPret.ReadOnly = true;
            this.txtPret.Size = new System.Drawing.Size(122, 20);
            this.txtPret.TabIndex = 2;
            this.txtPret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizare.Location = new System.Drawing.Point(362, 346);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(139, 68);
            this.btnFinalizare.TabIndex = 3;
            this.btnFinalizare.Text = "Finalizare \r\n";
            this.btnFinalizare.UseVisualStyleBackColor = true;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // Vizualizare_comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtKcal);
            this.Controls.Add(this.txtNecesar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwDate);
            this.Name = "Vizualizare_comanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare_comanda";
            this.Load += new System.EventHandler(this.Vizualizare_comanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNecesar;
        private System.Windows.Forms.TextBox txtKcal;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnFinalizare;
    }
}