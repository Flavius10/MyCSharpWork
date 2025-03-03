namespace TestListControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.comboButton = new System.Windows.Forms.Button();
            this.checkListButton1 = new System.Windows.Forms.Button();
            this.checkListButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(119, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 134);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ListBox";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ComboBox";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(586, 102);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 124);
            this.checkedListBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CheckedListBox";
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(122, 272);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(161, 23);
            this.listButton.TabIndex = 6;
            this.listButton.Text = "Incarca ListBox";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // comboButton
            // 
            this.comboButton.Location = new System.Drawing.Point(368, 272);
            this.comboButton.Name = "comboButton";
            this.comboButton.Size = new System.Drawing.Size(121, 23);
            this.comboButton.TabIndex = 7;
            this.comboButton.Text = "Incarca ComboBox";
            this.comboButton.UseVisualStyleBackColor = true;
            this.comboButton.Click += new System.EventHandler(this.comboButton_Click);
            // 
            // checkListButton1
            // 
            this.checkListButton1.Location = new System.Drawing.Point(589, 242);
            this.checkListButton1.Name = "checkListButton1";
            this.checkListButton1.Size = new System.Drawing.Size(147, 23);
            this.checkListButton1.TabIndex = 8;
            this.checkListButton1.Text = "Incarca o lista";
            this.checkListButton1.UseVisualStyleBackColor = true;
            this.checkListButton1.Click += new System.EventHandler(this.checkListButton1_Click);
            // 
            // checkListButton2
            // 
            this.checkListButton2.Location = new System.Drawing.Point(589, 272);
            this.checkListButton2.Name = "checkListButton2";
            this.checkListButton2.Size = new System.Drawing.Size(147, 23);
            this.checkListButton2.TabIndex = 9;
            this.checkListButton2.Text = "Incarca alta lista";
            this.checkListButton2.UseVisualStyleBackColor = true;
            this.checkListButton2.Click += new System.EventHandler(this.checkListButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkListButton2);
            this.Controls.Add(this.checkListButton1);
            this.Controls.Add(this.comboButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button comboButton;
        private System.Windows.Forms.Button checkListButton1;
        private System.Windows.Forms.Button checkListButton2;
    }
}

