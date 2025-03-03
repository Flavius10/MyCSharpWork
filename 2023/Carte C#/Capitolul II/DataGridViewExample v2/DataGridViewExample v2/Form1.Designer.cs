namespace DataGridViewExample_v2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sportiviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportDataSet = new DataGridViewExample_v2.SportDataSet();
            this.sportiviTableAdapter = new DataGridViewExample_v2.SportDataSetTableAdapters.SportiviTableAdapter();
            this.tableAdapterManager = new DataGridViewExample_v2.SportDataSetTableAdapters.TableAdapterManager();
            this.idSportivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportulPracticatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportiviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSportivDataGridViewTextBoxColumn,
            this.Varsta,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.sportulPracticatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sportiviBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // sportiviBindingSource
            // 
            this.sportiviBindingSource.DataMember = "Sportivi";
            this.sportiviBindingSource.DataSource = this.sportDataSet;
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "SportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportiviTableAdapter
            // 
            this.sportiviTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SportiviTableAdapter = this.sportiviTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataGridViewExample_v2.SportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idSportivDataGridViewTextBoxColumn
            // 
            this.idSportivDataGridViewTextBoxColumn.DataPropertyName = "IdSportiv";
            this.idSportivDataGridViewTextBoxColumn.HeaderText = "IdSportiv";
            this.idSportivDataGridViewTextBoxColumn.Name = "idSportivDataGridViewTextBoxColumn";
            // 
            // Varsta
            // 
            this.Varsta.HeaderText = "Varsta";
            this.Varsta.Name = "Varsta";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            // 
            // sportulPracticatDataGridViewTextBoxColumn
            // 
            this.sportulPracticatDataGridViewTextBoxColumn.DataPropertyName = "SportulPracticat";
            this.sportulPracticatDataGridViewTextBoxColumn.HeaderText = "SportulPracticat";
            this.sportulPracticatDataGridViewTextBoxColumn.Name = "sportulPracticatDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportiviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SportDataSet sportDataSet;
        private System.Windows.Forms.BindingSource sportiviBindingSource;
        private SportDataSetTableAdapters.SportiviTableAdapter sportiviTableAdapter;
        private SportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSportivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportulPracticatDataGridViewTextBoxColumn;
    }
}

