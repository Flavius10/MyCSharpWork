namespace AplicatieFreeBook
{
    partial class MeniuFreeBook
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailUt = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwCarti = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbNrCarti = new System.Windows.Forms.ProgressBar();
            this.lblDisponibilitate = new System.Windows.Forms.Label();
            this.dgwCartiImprumutate = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChartImprumut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnIesire = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarti)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCartiImprumutate)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImprumut)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(144, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(127, 29);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailUt
            // 
            this.lblEmailUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUt.Location = new System.Drawing.Point(12, 9);
            this.lblEmailUt.Name = "lblEmailUt";
            this.lblEmailUt.Size = new System.Drawing.Size(126, 29);
            this.lblEmailUt.TabIndex = 0;
            this.lblEmailUt.Text = "Email utilizator:";
            this.lblEmailUt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 408);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwCarti);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carti disponibile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwCarti
            // 
            this.dgwCarti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCarti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCarti.Location = new System.Drawing.Point(3, 3);
            this.dgwCarti.Name = "dgwCarti";
            this.dgwCarti.Size = new System.Drawing.Size(786, 376);
            this.dgwCarti.TabIndex = 0;
            this.dgwCarti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCarti_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbNrCarti);
            this.tabPage2.Controls.Add(this.lblDisponibilitate);
            this.tabPage2.Controls.Add(this.dgwCartiImprumutate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carti imprumutate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbNrCarti
            // 
            this.pbNrCarti.Location = new System.Drawing.Point(359, 318);
            this.pbNrCarti.Name = "pbNrCarti";
            this.pbNrCarti.Size = new System.Drawing.Size(403, 54);
            this.pbNrCarti.Step = 1;
            this.pbNrCarti.TabIndex = 3;
            this.pbNrCarti.Value = 3;
            // 
            // lblDisponibilitate
            // 
            this.lblDisponibilitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilitate.Location = new System.Drawing.Point(7, 318);
            this.lblDisponibilitate.Name = "lblDisponibilitate";
            this.lblDisponibilitate.Size = new System.Drawing.Size(291, 44);
            this.lblDisponibilitate.TabIndex = 2;
            this.lblDisponibilitate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwCartiImprumutate
            // 
            this.dgwCartiImprumutate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCartiImprumutate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCartiImprumutate.Location = new System.Drawing.Point(3, 3);
            this.dgwCartiImprumutate.Name = "dgwCartiImprumutate";
            this.dgwCartiImprumutate.ReadOnly = true;
            this.dgwCartiImprumutate.Size = new System.Drawing.Size(786, 293);
            this.dgwCartiImprumutate.TabIndex = 0;
            this.dgwCartiImprumutate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwCartiImprumutate_CellMouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistici biblioteca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(7, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(782, 370);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.ChartImprumut);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 344);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Numar utilizatori";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "2017";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ChartImprumut
            // 
            this.ChartImprumut.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartImprumut.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartImprumut.Legends.Add(legend1);
            this.ChartImprumut.Location = new System.Drawing.Point(15, 44);
            this.ChartImprumut.Name = "ChartImprumut";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Luna";
            this.ChartImprumut.Series.Add(series1);
            this.ChartImprumut.Size = new System.Drawing.Size(667, 300);
            this.ChartImprumut.TabIndex = 2;
            this.ChartImprumut.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "An imprumut";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(774, 344);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Carti populare";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnIesire
            // 
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(655, 12);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(132, 43);
            this.btnIesire.TabIndex = 2;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 17);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "CartiImprumut";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(745, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 470);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblEmailUt);
            this.Controls.Add(this.lblEmail);
            this.Name = "MeniuFreeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuFreeBook";
            this.Load += new System.EventHandler(this.MeniuFreeBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarti)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCartiImprumutate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartImprumut)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailUt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgwCarti;
        private System.Windows.Forms.DataGridView dgwCartiImprumutate;
        private System.Windows.Forms.Label lblDisponibilitate;
        private System.Windows.Forms.ProgressBar pbNrCarti;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartImprumut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}