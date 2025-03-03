namespace Olimpiada_2023_Nationala_Cerinta5
{
    partial class Cerinta
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
            this.components = new System.ComponentModel.Container();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.lblSecunde = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPanou = new System.Windows.Forms.PictureBox();
            this.lblCuvant = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanou)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(255, 375);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(129, 102);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Location = new System.Drawing.Point(438, 375);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(129, 102);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            // 
            // lblSecunde
            // 
            this.lblSecunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecunde.Location = new System.Drawing.Point(12, 9);
            this.lblSecunde.Name = "lblSecunde";
            this.lblSecunde.Size = new System.Drawing.Size(144, 32);
            this.lblSecunde.TabIndex = 1;
            this.lblSecunde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbPanou
            // 
            this.pbPanou.Location = new System.Drawing.Point(16, 60);
            this.pbPanou.Name = "pbPanou";
            this.pbPanou.Size = new System.Drawing.Size(851, 309);
            this.pbPanou.TabIndex = 2;
            this.pbPanou.TabStop = false;
            // 
            // lblCuvant
            // 
            this.lblCuvant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuvant.Location = new System.Drawing.Point(678, 399);
            this.lblCuvant.Name = "lblCuvant";
            this.lblCuvant.Size = new System.Drawing.Size(151, 62);
            this.lblCuvant.TabIndex = 3;
            this.lblCuvant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCuvant.TextChanged += new System.EventHandler(this.lblCuvant_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 62);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextChanged += new System.EventHandler(this.lblCuvant_TextChanged);
            // 
            // Cerinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuvant);
            this.Controls.Add(this.pbPanou);
            this.Controls.Add(this.lblSecunde);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Cerinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cerinta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lblSecunde;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPanou;
        private System.Windows.Forms.Label lblCuvant;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}

