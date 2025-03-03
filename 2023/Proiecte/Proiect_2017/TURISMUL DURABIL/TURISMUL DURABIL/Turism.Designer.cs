namespace TURISMUL_DURABIL
{
    partial class TurismForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurismForm));
            this.btnInit = new System.Windows.Forms.Button();
            this.btnGenPost = new System.Windows.Forms.Button();
            this.btnVizualExc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.Location = new System.Drawing.Point(54, 323);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(119, 49);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Initializare";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnGenPost
            // 
            this.btnGenPost.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGenPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPost.ImageKey = "(none)";
            this.btnGenPost.Location = new System.Drawing.Point(329, 323);
            this.btnGenPost.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenPost.Name = "btnGenPost";
            this.btnGenPost.Size = new System.Drawing.Size(127, 49);
            this.btnGenPost.TabIndex = 1;
            this.btnGenPost.Text = "Genereaza Poster";
            this.btnGenPost.UseVisualStyleBackColor = false;
            // 
            // btnVizualExc
            // 
            this.btnVizualExc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVizualExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizualExc.Location = new System.Drawing.Point(578, 323);
            this.btnVizualExc.Name = "btnVizualExc";
            this.btnVizualExc.Size = new System.Drawing.Size(131, 49);
            this.btnVizualExc.TabIndex = 2;
            this.btnVizualExc.Text = "Vizualizare excursie";
            this.btnVizualExc.UseVisualStyleBackColor = false;
            // 
            // TurismForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TURISMUL_DURABIL.Properties.Resources.tourism;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(783, 393);
            this.Controls.Add(this.btnVizualExc);
            this.Controls.Add(this.btnGenPost);
            this.Controls.Add(this.btnInit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TurismForm";
            this.Text = "Turism";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnGenPost;
        private System.Windows.Forms.Button btnVizualExc;
    }
}

