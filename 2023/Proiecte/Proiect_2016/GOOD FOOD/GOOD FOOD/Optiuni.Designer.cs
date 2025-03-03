namespace GOOD_FOOD
{
    partial class Optiuni
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNecesar = new System.Windows.Forms.TextBox();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.txtGreutate = new System.Windows.Forms.TextBox();
            this.txtInaltime = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnComanda = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtKcal = new System.Windows.Forms.TextBox();
            this.txtNecesar1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNecesarZilnic = new System.Windows.Forms.Label();
            this.dgwDate = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgwGenerare = new System.Windows.Forms.DataGridView();
            this.btnGenereaza = new System.Windows.Forms.Button();
            this.txtBuget = new System.Windows.Forms.TextBox();
            this.txtNecesarMeniu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerare)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNecesar);
            this.tabPage1.Controls.Add(this.btnCalculeaza);
            this.tabPage1.Controls.Add(this.txtGreutate);
            this.tabPage1.Controls.Add(this.txtInaltime);
            this.tabPage1.Controls.Add(this.txtVarsta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CalculatorKcal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNecesar
            // 
            this.txtNecesar.Location = new System.Drawing.Point(539, 152);
            this.txtNecesar.Name = "txtNecesar";
            this.txtNecesar.ReadOnly = true;
            this.txtNecesar.Size = new System.Drawing.Size(100, 20);
            this.txtNecesar.TabIndex = 5;
            this.txtNecesar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeaza.Location = new System.Drawing.Point(93, 282);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(175, 66);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // txtGreutate
            // 
            this.txtGreutate.Location = new System.Drawing.Point(167, 177);
            this.txtGreutate.Name = "txtGreutate";
            this.txtGreutate.Size = new System.Drawing.Size(161, 20);
            this.txtGreutate.TabIndex = 3;
            this.txtGreutate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInaltime
            // 
            this.txtInaltime.Location = new System.Drawing.Point(167, 113);
            this.txtInaltime.Name = "txtInaltime";
            this.txtInaltime.Size = new System.Drawing.Size(161, 20);
            this.txtInaltime.TabIndex = 2;
            this.txtInaltime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(167, 43);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(161, 20);
            this.txtVarsta.TabIndex = 1;
            this.txtVarsta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inaltime(cm)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Greutate(kg)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Necesar zilnic";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta(ani)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnComanda);
            this.tabPage2.Controls.Add(this.txtPret);
            this.tabPage2.Controls.Add(this.txtKcal);
            this.tabPage2.Controls.Add(this.txtNecesar1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblNecesarZilnic);
            this.tabPage2.Controls.Add(this.dgwDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comanda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnComanda
            // 
            this.btnComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.Location = new System.Drawing.Point(327, 303);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(146, 53);
            this.btnComanda.TabIndex = 5;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(128, 353);
            this.txtPret.Name = "txtPret";
            this.txtPret.ReadOnly = true;
            this.txtPret.Size = new System.Drawing.Size(125, 20);
            this.txtPret.TabIndex = 4;
            this.txtPret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKcal
            // 
            this.txtKcal.Location = new System.Drawing.Point(128, 320);
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.ReadOnly = true;
            this.txtKcal.Size = new System.Drawing.Size(125, 20);
            this.txtKcal.TabIndex = 3;
            this.txtKcal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNecesar1
            // 
            this.txtNecesar1.Location = new System.Drawing.Point(128, 285);
            this.txtNecesar1.Name = "txtNecesar1";
            this.txtNecesar1.ReadOnly = true;
            this.txtNecesar1.Size = new System.Drawing.Size(125, 20);
            this.txtNecesar1.TabIndex = 2;
            this.txtNecesar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Kcal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pret total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNecesarZilnic
            // 
            this.lblNecesarZilnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNecesarZilnic.Location = new System.Drawing.Point(6, 285);
            this.lblNecesarZilnic.Name = "lblNecesarZilnic";
            this.lblNecesarZilnic.Size = new System.Drawing.Size(115, 23);
            this.lblNecesarZilnic.TabIndex = 1;
            this.lblNecesarZilnic.Text = "Necesar zilnic";
            this.lblNecesarZilnic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwDate
            // 
            this.dgwDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDate.Location = new System.Drawing.Point(3, 3);
            this.dgwDate.Name = "dgwDate";
            this.dgwDate.Size = new System.Drawing.Size(761, 279);
            this.dgwDate.TabIndex = 0;
            this.dgwDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDate_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgwGenerare);
            this.tabPage3.Controls.Add(this.btnGenereaza);
            this.tabPage3.Controls.Add(this.txtBuget);
            this.tabPage3.Controls.Add(this.txtNecesarMeniu);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generare Meniu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgwGenerare
            // 
            this.dgwGenerare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGenerare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenerare.Location = new System.Drawing.Point(3, 52);
            this.dgwGenerare.Name = "dgwGenerare";
            this.dgwGenerare.Size = new System.Drawing.Size(761, 347);
            this.dgwGenerare.TabIndex = 4;
            this.dgwGenerare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGenerare_CellContentClick);
            // 
            // btnGenereaza
            // 
            this.btnGenereaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenereaza.Location = new System.Drawing.Point(639, 6);
            this.btnGenereaza.Name = "btnGenereaza";
            this.btnGenereaza.Size = new System.Drawing.Size(122, 39);
            this.btnGenereaza.TabIndex = 3;
            this.btnGenereaza.Text = "Genereaza";
            this.btnGenereaza.UseVisualStyleBackColor = true;
            this.btnGenereaza.Click += new System.EventHandler(this.btnGenereaza_Click);
            // 
            // txtBuget
            // 
            this.txtBuget.Location = new System.Drawing.Point(447, 9);
            this.txtBuget.Name = "txtBuget";
            this.txtBuget.Size = new System.Drawing.Size(100, 20);
            this.txtBuget.TabIndex = 2;
            this.txtBuget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuget.TextChanged += new System.EventHandler(this.txtBuget_TextChanged);
            // 
            // txtNecesarMeniu
            // 
            this.txtNecesarMeniu.Location = new System.Drawing.Point(174, 7);
            this.txtNecesarMeniu.Name = "txtNecesarMeniu";
            this.txtNecesarMeniu.ReadOnly = true;
            this.txtNecesarMeniu.Size = new System.Drawing.Size(100, 20);
            this.txtNecesarMeniu.TabIndex = 1;
            this.txtNecesarMeniu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buget:\r\n\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Necesarul zilnic de kcal:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grafic Kcal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(7, 7);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Comanda";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(757, 386);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Grafic Kcal";
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Optiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenerare)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.TextBox txtGreutate;
        private System.Windows.Forms.TextBox txtInaltime;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtNecesar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwDate;
        private System.Windows.Forms.Label lblNecesarZilnic;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtKcal;
        private System.Windows.Forms.TextBox txtNecesar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.DataGridView dgwGenerare;
        private System.Windows.Forms.Button btnGenereaza;
        private System.Windows.Forms.TextBox txtBuget;
        private System.Windows.Forms.TextBox txtNecesarMeniu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}