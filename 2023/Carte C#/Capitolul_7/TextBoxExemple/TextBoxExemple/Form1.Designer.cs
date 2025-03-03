namespace TextBoxExemple
{
    partial class TextBoxEx
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.cnpLabel1 = new System.Windows.Forms.Label();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.autentifButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID-ul:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(203, 76);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.idTextBox_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Location = new System.Drawing.Point(203, 118);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaTextBox.TabIndex = 3;
            this.parolaTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.parolaTextBox_PreviewKeyDown);
            // 
            // cnpLabel1
            // 
            this.cnpLabel1.AutoSize = true;
            this.cnpLabel1.Location = new System.Drawing.Point(75, 173);
            this.cnpLabel1.Name = "cnpLabel1";
            this.cnpLabel1.Size = new System.Drawing.Size(32, 13);
            this.cnpLabel1.TabIndex = 4;
            this.cnpLabel1.Text = "CNP:";
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(203, 173);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpTextBox.TabIndex = 5;
            this.cnpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnpTextBox_KeyPress);
            // 
            // autentifButton
            // 
            this.autentifButton.Location = new System.Drawing.Point(227, 230);
            this.autentifButton.Name = "autentifButton";
            this.autentifButton.Size = new System.Drawing.Size(75, 23);
            this.autentifButton.TabIndex = 6;
            this.autentifButton.Text = "Autentificare";
            this.autentifButton.UseVisualStyleBackColor = true;
            this.autentifButton.Click += new System.EventHandler(this.autentifButton_Click);
            // 
            // TextBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autentifButton);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(this.cnpLabel1);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TextBoxEx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Label cnpLabel1;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.Button autentifButton;
    }
}

