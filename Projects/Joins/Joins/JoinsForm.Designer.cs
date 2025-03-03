namespace Joins
{
    partial class JoinsForm
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
            this.dgwTestJoins = new System.Windows.Forms.DataGridView();
            this.btnINNER = new System.Windows.Forms.Button();
            this.btnLEFT = new System.Windows.Forms.Button();
            this.btnRIGHT = new System.Windows.Forms.Button();
            this.btnFULLJOIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTestJoins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTestJoins
            // 
            this.dgwTestJoins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTestJoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTestJoins.Location = new System.Drawing.Point(12, 12);
            this.dgwTestJoins.Name = "dgwTestJoins";
            this.dgwTestJoins.Size = new System.Drawing.Size(388, 386);
            this.dgwTestJoins.TabIndex = 0;
            // 
            // btnINNER
            // 
            this.btnINNER.Location = new System.Drawing.Point(551, 12);
            this.btnINNER.Name = "btnINNER";
            this.btnINNER.Size = new System.Drawing.Size(130, 80);
            this.btnINNER.TabIndex = 1;
            this.btnINNER.Text = "INNER JOIN";
            this.btnINNER.UseVisualStyleBackColor = true;
            this.btnINNER.Click += new System.EventHandler(this.btnINNER_Click);
            // 
            // btnLEFT
            // 
            this.btnLEFT.Location = new System.Drawing.Point(551, 112);
            this.btnLEFT.Name = "btnLEFT";
            this.btnLEFT.Size = new System.Drawing.Size(130, 80);
            this.btnLEFT.TabIndex = 1;
            this.btnLEFT.Text = "LEFT JOIN";
            this.btnLEFT.UseVisualStyleBackColor = true;
            this.btnLEFT.Click += new System.EventHandler(this.btnLEFT_Click);
            // 
            // btnRIGHT
            // 
            this.btnRIGHT.Location = new System.Drawing.Point(551, 208);
            this.btnRIGHT.Name = "btnRIGHT";
            this.btnRIGHT.Size = new System.Drawing.Size(130, 80);
            this.btnRIGHT.TabIndex = 1;
            this.btnRIGHT.Text = "RIGHT JOIN";
            this.btnRIGHT.UseVisualStyleBackColor = true;
            this.btnRIGHT.Click += new System.EventHandler(this.btnRIGHT_Click);
            // 
            // btnFULLJOIN
            // 
            this.btnFULLJOIN.Location = new System.Drawing.Point(551, 318);
            this.btnFULLJOIN.Name = "btnFULLJOIN";
            this.btnFULLJOIN.Size = new System.Drawing.Size(130, 80);
            this.btnFULLJOIN.TabIndex = 1;
            this.btnFULLJOIN.Text = "FULL JOIN";
            this.btnFULLJOIN.UseVisualStyleBackColor = true;
            this.btnFULLJOIN.Click += new System.EventHandler(this.btnFULLJOIN_Click);
            // 
            // JoinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFULLJOIN);
            this.Controls.Add(this.btnRIGHT);
            this.Controls.Add(this.btnLEFT);
            this.Controls.Add(this.btnINNER);
            this.Controls.Add(this.dgwTestJoins);
            this.Name = "JoinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joins";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTestJoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTestJoins;
        private System.Windows.Forms.Button btnINNER;
        private System.Windows.Forms.Button btnLEFT;
        private System.Windows.Forms.Button btnRIGHT;
        private System.Windows.Forms.Button btnFULLJOIN;
    }
}

