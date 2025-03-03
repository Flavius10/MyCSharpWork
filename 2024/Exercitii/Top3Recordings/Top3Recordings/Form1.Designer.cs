namespace Top3Recordings
{
    partial class MainPage
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
            this.btnDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDate
            // 
            this.dgwDate.AllowUserToOrderColumns = true;
            this.dgwDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDate.Location = new System.Drawing.Point(12, 12);
            this.dgwDate.Name = "dgwDate";
            this.dgwDate.Size = new System.Drawing.Size(776, 220);
            this.dgwDate.TabIndex = 0;
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(670, 385);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(118, 53);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.dgwDate);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDate;
        private System.Windows.Forms.Button btnDate;
    }
}

