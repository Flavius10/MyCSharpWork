namespace ClickEvent
{
    partial class FormaMea
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
            this.buton = new System.Windows.Forms.Button();
            this.verif = new System.Windows.Forms.CheckBox();
            this.edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buton
            // 
            this.buton.Location = new System.Drawing.Point(290, 69);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(142, 76);
            this.buton.TabIndex = 0;
            this.buton.Text = "Apasare";
            this.buton.UseVisualStyleBackColor = true;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // verif
            // 
            this.verif.AutoSize = true;
            this.verif.Location = new System.Drawing.Point(290, 174);
            this.verif.Name = "verif";
            this.verif.Size = new System.Drawing.Size(64, 17);
            this.verif.TabIndex = 1;
            this.verif.Text = "Validare";
            this.verif.UseVisualStyleBackColor = true;
            this.verif.Click += new System.EventHandler(this.buton_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(290, 239);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(142, 20);
            this.edit.TabIndex = 2;
            this.edit.Click += new System.EventHandler(this.buton_Click);
            this.edit.Validated += new System.EventHandler(this.buton_Click);
            // 
            // FormaMea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.verif);
            this.Controls.Add(this.buton);
            this.Name = "FormaMea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton;
        private System.Windows.Forms.CheckBox verif;
        private System.Windows.Forms.TextBox edit;
    }
}

