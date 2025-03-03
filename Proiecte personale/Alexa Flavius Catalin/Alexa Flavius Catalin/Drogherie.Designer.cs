namespace Alexa_Flavius_Catalin
{
    partial class Drogherie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPretNou = new System.Windows.Forms.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICAMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPENSATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCCOMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmacieDBDataSet = new Alexa_Flavius_Catalin.FarmacieDBDataSet();
            this.medicamenteTableAdapter = new Alexa_Flavius_Catalin.FarmacieDBDataSetTableAdapters.MedicamenteTableAdapter();
            this.btnCompensat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmacieDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mEDICAMENTDataGridViewTextBoxColumn,
            this.cOMPENSATDataGridViewTextBoxColumn,
            this.pROCCOMPDataGridViewTextBoxColumn,
            this.pRETDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farmacie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPretNou);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnModifica);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(462, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifica Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID medicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pret nou";
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(82, 183);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 32);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(66, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtPretNou
            // 
            this.txtPretNou.Location = new System.Drawing.Point(97, 139);
            this.txtPretNou.Name = "txtPretNou";
            this.txtPretNou.Size = new System.Drawing.Size(79, 20);
            this.txtPretNou.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mEDICAMENTDataGridViewTextBoxColumn
            // 
            this.mEDICAMENTDataGridViewTextBoxColumn.DataPropertyName = "MEDICAMENT";
            this.mEDICAMENTDataGridViewTextBoxColumn.HeaderText = "MEDICAMENT";
            this.mEDICAMENTDataGridViewTextBoxColumn.Name = "mEDICAMENTDataGridViewTextBoxColumn";
            // 
            // cOMPENSATDataGridViewTextBoxColumn
            // 
            this.cOMPENSATDataGridViewTextBoxColumn.DataPropertyName = "COMPENSAT";
            this.cOMPENSATDataGridViewTextBoxColumn.HeaderText = "COMPENSAT";
            this.cOMPENSATDataGridViewTextBoxColumn.Name = "cOMPENSATDataGridViewTextBoxColumn";
            // 
            // pROCCOMPDataGridViewTextBoxColumn
            // 
            this.pROCCOMPDataGridViewTextBoxColumn.DataPropertyName = "PROC_COMP";
            this.pROCCOMPDataGridViewTextBoxColumn.HeaderText = "PROC_COMP";
            this.pROCCOMPDataGridViewTextBoxColumn.Name = "pROCCOMPDataGridViewTextBoxColumn";
            // 
            // pRETDataGridViewTextBoxColumn
            // 
            this.pRETDataGridViewTextBoxColumn.DataPropertyName = "PRET";
            this.pRETDataGridViewTextBoxColumn.HeaderText = "PRET";
            this.pRETDataGridViewTextBoxColumn.Name = "pRETDataGridViewTextBoxColumn";
            // 
            // medicamenteBindingSource
            // 
            this.medicamenteBindingSource.DataMember = "Medicamente";
            this.medicamenteBindingSource.DataSource = this.farmacieDBDataSet;
            // 
            // farmacieDBDataSet
            // 
            this.farmacieDBDataSet.DataSetName = "FarmacieDBDataSet";
            this.farmacieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamenteTableAdapter
            // 
            this.medicamenteTableAdapter.ClearBeforeFill = true;
            // 
            // btnCompensat
            // 
            this.btnCompensat.Location = new System.Drawing.Point(572, 324);
            this.btnCompensat.Name = "btnCompensat";
            this.btnCompensat.Size = new System.Drawing.Size(117, 75);
            this.btnCompensat.TabIndex = 3;
            this.btnCompensat.Text = "Compensat";
            this.btnCompensat.UseVisualStyleBackColor = true;
            this.btnCompensat.Click += new System.EventHandler(this.btnCompensat_Click);
            // 
            // Drogherie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompensat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Drogherie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacie";
            this.Load += new System.EventHandler(this.Drogherie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmacieDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FarmacieDBDataSet farmacieDBDataSet;
        private System.Windows.Forms.BindingSource medicamenteBindingSource;
        private FarmacieDBDataSetTableAdapters.MedicamenteTableAdapter medicamenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICAMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPENSATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCCOMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRETDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPretNou;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompensat;
    }
}

