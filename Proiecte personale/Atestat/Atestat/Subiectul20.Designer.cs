namespace Atestat
{
    partial class Subiectul20
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gupCos = new System.Windows.Forms.GroupBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.cODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dENUMIREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazieDataSet = new Atestat.MagazieDataSet();
            this.magazinTableAdapter = new Atestat.MagazieDataSetTableAdapters.MagazinTableAdapter();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gupCos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magazin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODDataGridViewTextBoxColumn,
            this.dENUMIREADataGridViewTextBoxColumn,
            this.pRETDataGridViewTextBoxColumn,
            this.dATAINDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // gupCos
            // 
            this.gupCos.Controls.Add(this.btnAdauga);
            this.gupCos.Controls.Add(this.txtPret);
            this.gupCos.Controls.Add(this.dtpData);
            this.gupCos.Controls.Add(this.txtDenumire);
            this.gupCos.Controls.Add(this.label4);
            this.gupCos.Controls.Add(this.label3);
            this.gupCos.Controls.Add(this.label2);
            this.gupCos.Location = new System.Drawing.Point(476, 48);
            this.gupCos.Name = "gupCos";
            this.gupCos.Size = new System.Drawing.Size(293, 253);
            this.gupCos.TabIndex = 2;
            this.gupCos.TabStop = false;
            this.gupCos.Text = "Cos de cumparaturi";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(106, 210);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(91, 94);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 3;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(91, 150);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 2;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(91, 42);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pret:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Denumire:";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(510, 335);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sorteaza";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cODDataGridViewTextBoxColumn
            // 
            this.cODDataGridViewTextBoxColumn.DataPropertyName = "COD";
            this.cODDataGridViewTextBoxColumn.HeaderText = "COD";
            this.cODDataGridViewTextBoxColumn.Name = "cODDataGridViewTextBoxColumn";
            this.cODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dENUMIREADataGridViewTextBoxColumn
            // 
            this.dENUMIREADataGridViewTextBoxColumn.DataPropertyName = "DENUMIREA";
            this.dENUMIREADataGridViewTextBoxColumn.HeaderText = "DENUMIREA";
            this.dENUMIREADataGridViewTextBoxColumn.Name = "dENUMIREADataGridViewTextBoxColumn";
            // 
            // pRETDataGridViewTextBoxColumn
            // 
            this.pRETDataGridViewTextBoxColumn.DataPropertyName = "PRET";
            this.pRETDataGridViewTextBoxColumn.HeaderText = "PRET";
            this.pRETDataGridViewTextBoxColumn.Name = "pRETDataGridViewTextBoxColumn";
            // 
            // dATAINDataGridViewTextBoxColumn
            // 
            this.dATAINDataGridViewTextBoxColumn.DataPropertyName = "DATA_IN";
            this.dATAINDataGridViewTextBoxColumn.HeaderText = "DATA_IN";
            this.dATAINDataGridViewTextBoxColumn.Name = "dATAINDataGridViewTextBoxColumn";
            // 
            // magazinBindingSource
            // 
            this.magazinBindingSource.DataMember = "Magazin";
            this.magazinBindingSource.DataSource = this.magazieDataSet;
            // 
            // magazieDataSet
            // 
            this.magazieDataSet.DataSetName = "MagazieDataSet";
            this.magazieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazinTableAdapter
            // 
            this.magazinTableAdapter.ClearBeforeFill = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(618, 338);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Subiectul20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.gupCos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Subiectul20";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazie";
            this.Load += new System.EventHandler(this.Subiectul20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gupCos.ResumeLayout(false);
            this.gupCos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazieDataSet magazieDataSet;
        private System.Windows.Forms.BindingSource magazinBindingSource;
        private MagazieDataSetTableAdapters.MagazinTableAdapter magazinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dENUMIREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gupCos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

