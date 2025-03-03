namespace Table
{
    partial class Table
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
            this.btnJocNou = new System.Windows.Forms.Button();
            this.btnSchimba = new System.Windows.Forms.Button();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnJocNou
            // 
            this.btnJocNou.Location = new System.Drawing.Point(675, 13);
            this.btnJocNou.Name = "btnJocNou";
            this.btnJocNou.Size = new System.Drawing.Size(104, 51);
            this.btnJocNou.TabIndex = 0;
            this.btnJocNou.Text = "Joc Nou";
            this.btnJocNou.UseVisualStyleBackColor = true;
            this.btnJocNou.Click += new System.EventHandler(this.btnJocNou_Click);
            // 
            // btnSchimba
            // 
            this.btnSchimba.Location = new System.Drawing.Point(675, 84);
            this.btnSchimba.Name = "btnSchimba";
            this.btnSchimba.Size = new System.Drawing.Size(104, 51);
            this.btnSchimba.TabIndex = 0;
            this.btnSchimba.Text = "Schimba";
            this.btnSchimba.UseVisualStyleBackColor = true;
            this.btnSchimba.Click += new System.EventHandler(this.btnSchimba_Click);
            // 
            // table1
            // 
            this.table1.ColumnCount = 8;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.06742F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.93258F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.table1.Location = new System.Drawing.Point(13, 13);
            this.table1.Name = "table1";
            this.table1.RowCount = 7;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.52941F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.47059F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table1.Size = new System.Drawing.Size(656, 425);
            this.table1.TabIndex = 1;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.btnSchimba);
            this.Controls.Add(this.btnJocNou);
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJocNou;
        private System.Windows.Forms.Button btnSchimba;
        private System.Windows.Forms.TableLayoutPanel table1;
    }
}

