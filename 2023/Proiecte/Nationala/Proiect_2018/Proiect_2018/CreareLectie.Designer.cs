namespace Proiect_2018
{
    partial class CreareLectie
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtRegiune = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRand = new System.Windows.Forms.Button();
            this.btnStergeRand = new System.Windows.Forms.Button();
            this.btnColoanaNoua = new System.Windows.Forms.Button();
            this.btnStergeColoana = new System.Windows.Forms.Button();
            this.btnCresteLatime = new System.Windows.Forms.Button();
            this.btnScadeLatimea = new System.Windows.Forms.Button();
            this.btnCresteInaltime = new System.Windows.Forms.Button();
            this.btnScadeInaltime = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnImagine = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu lectie:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Regiune lectie:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(17, 55);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(193, 20);
            this.txtTitlu.TabIndex = 1;
            // 
            // txtRegiune
            // 
            this.txtRegiune.Location = new System.Drawing.Point(17, 135);
            this.txtRegiune.Name = "txtRegiune";
            this.txtRegiune.Size = new System.Drawing.Size(193, 20);
            this.txtRegiune.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(349, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 559);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(28, 170);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(85, 59);
            this.btnRand.TabIndex = 3;
            this.btnRand.Text = "Rand nou";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // btnStergeRand
            // 
            this.btnStergeRand.Location = new System.Drawing.Point(161, 170);
            this.btnStergeRand.Name = "btnStergeRand";
            this.btnStergeRand.Size = new System.Drawing.Size(85, 57);
            this.btnStergeRand.TabIndex = 3;
            this.btnStergeRand.Text = "Sterge Rand";
            this.btnStergeRand.UseVisualStyleBackColor = true;
            // 
            // btnColoanaNoua
            // 
            this.btnColoanaNoua.Location = new System.Drawing.Point(28, 235);
            this.btnColoanaNoua.Name = "btnColoanaNoua";
            this.btnColoanaNoua.Size = new System.Drawing.Size(85, 59);
            this.btnColoanaNoua.TabIndex = 3;
            this.btnColoanaNoua.Text = "Coloana Noua";
            this.btnColoanaNoua.UseVisualStyleBackColor = true;
            // 
            // btnStergeColoana
            // 
            this.btnStergeColoana.Location = new System.Drawing.Point(161, 235);
            this.btnStergeColoana.Name = "btnStergeColoana";
            this.btnStergeColoana.Size = new System.Drawing.Size(85, 59);
            this.btnStergeColoana.TabIndex = 3;
            this.btnStergeColoana.Text = "Sterge Coloana";
            this.btnStergeColoana.UseVisualStyleBackColor = true;
            // 
            // btnCresteLatime
            // 
            this.btnCresteLatime.Location = new System.Drawing.Point(161, 315);
            this.btnCresteLatime.Name = "btnCresteLatime";
            this.btnCresteLatime.Size = new System.Drawing.Size(85, 59);
            this.btnCresteLatime.TabIndex = 3;
            this.btnCresteLatime.Text = "Creste latimea coloana";
            this.btnCresteLatime.UseVisualStyleBackColor = true;
            // 
            // btnScadeLatimea
            // 
            this.btnScadeLatimea.Location = new System.Drawing.Point(28, 315);
            this.btnScadeLatimea.Name = "btnScadeLatimea";
            this.btnScadeLatimea.Size = new System.Drawing.Size(85, 59);
            this.btnScadeLatimea.TabIndex = 3;
            this.btnScadeLatimea.Text = "Scade latimea coloana";
            this.btnScadeLatimea.UseVisualStyleBackColor = true;
            // 
            // btnCresteInaltime
            // 
            this.btnCresteInaltime.Location = new System.Drawing.Point(161, 380);
            this.btnCresteInaltime.Name = "btnCresteInaltime";
            this.btnCresteInaltime.Size = new System.Drawing.Size(85, 59);
            this.btnCresteInaltime.TabIndex = 3;
            this.btnCresteInaltime.Text = "Creste inaltime rand";
            this.btnCresteInaltime.UseVisualStyleBackColor = true;
            // 
            // btnScadeInaltime
            // 
            this.btnScadeInaltime.Location = new System.Drawing.Point(28, 380);
            this.btnScadeInaltime.Name = "btnScadeInaltime";
            this.btnScadeInaltime.Size = new System.Drawing.Size(85, 59);
            this.btnScadeInaltime.TabIndex = 3;
            this.btnScadeInaltime.Text = "Reduce inaltimea rand";
            this.btnScadeInaltime.UseVisualStyleBackColor = true;
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(28, 460);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(85, 59);
            this.btnText.TabIndex = 3;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            // 
            // btnImagine
            // 
            this.btnImagine.Location = new System.Drawing.Point(136, 460);
            this.btnImagine.Name = "btnImagine";
            this.btnImagine.Size = new System.Drawing.Size(85, 59);
            this.btnImagine.TabIndex = 3;
            this.btnImagine.Text = "Imagine";
            this.btnImagine.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 59);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salveaza Imagine";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CreareLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 583);
            this.Controls.Add(this.btnStergeRand);
            this.Controls.Add(this.btnStergeColoana);
            this.Controls.Add(this.btnScadeLatimea);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImagine);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnScadeInaltime);
            this.Controls.Add(this.btnCresteInaltime);
            this.Controls.Add(this.btnCresteLatime);
            this.Controls.Add(this.btnColoanaNoua);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtRegiune);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreareLectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreareLectie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtRegiune;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnStergeRand;
        private System.Windows.Forms.Button btnColoanaNoua;
        private System.Windows.Forms.Button btnStergeColoana;
        private System.Windows.Forms.Button btnCresteLatime;
        private System.Windows.Forms.Button btnScadeLatimea;
        private System.Windows.Forms.Button btnCresteInaltime;
        private System.Windows.Forms.Button btnScadeInaltime;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnImagine;
        private System.Windows.Forms.Button btnSave;
    }
}