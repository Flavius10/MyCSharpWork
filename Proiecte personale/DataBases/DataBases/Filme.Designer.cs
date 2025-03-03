namespace DataBases
{
    partial class Filme
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
            this.dgwFilm = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGIZORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataSet = new DataBases.MovieDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtRegizor = new System.Windows.Forms.TextBox();
            this.txtAnAP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChooseRegizor = new System.Windows.Forms.TextBox();
            this.filmTableAdapter = new DataBases.MovieDataSetTableAdapters.FilmTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDurataUpdate = new System.Windows.Forms.TextBox();
            this.txtTitluUpdate = new System.Windows.Forms.TextBox();
            this.txtRegizorUpdate = new System.Windows.Forms.TextBox();
            this.txtAN_AP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLS = new System.Windows.Forms.TextBox();
            this.txtLD = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwFilm
            // 
            this.dgwFilm.AutoGenerateColumns = false;
            this.dgwFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rEGIZORDataGridViewTextBoxColumn,
            this.aNAPDataGridViewTextBoxColumn,
            this.tITLUDataGridViewTextBoxColumn,
            this.dURATADataGridViewTextBoxColumn});
            this.dgwFilm.DataSource = this.filmBindingSource;
            this.dgwFilm.Location = new System.Drawing.Point(12, 12);
            this.dgwFilm.Name = "dgwFilm";
            this.dgwFilm.Size = new System.Drawing.Size(497, 457);
            this.dgwFilm.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGIZORDataGridViewTextBoxColumn
            // 
            this.rEGIZORDataGridViewTextBoxColumn.DataPropertyName = "REGIZOR";
            this.rEGIZORDataGridViewTextBoxColumn.HeaderText = "REGIZOR";
            this.rEGIZORDataGridViewTextBoxColumn.Name = "rEGIZORDataGridViewTextBoxColumn";
            // 
            // aNAPDataGridViewTextBoxColumn
            // 
            this.aNAPDataGridViewTextBoxColumn.DataPropertyName = "AN_AP";
            this.aNAPDataGridViewTextBoxColumn.HeaderText = "AN_AP";
            this.aNAPDataGridViewTextBoxColumn.Name = "aNAPDataGridViewTextBoxColumn";
            // 
            // tITLUDataGridViewTextBoxColumn
            // 
            this.tITLUDataGridViewTextBoxColumn.DataPropertyName = "TITLU";
            this.tITLUDataGridViewTextBoxColumn.HeaderText = "TITLU";
            this.tITLUDataGridViewTextBoxColumn.Name = "tITLUDataGridViewTextBoxColumn";
            // 
            // dURATADataGridViewTextBoxColumn
            // 
            this.dURATADataGridViewTextBoxColumn.DataPropertyName = "DURATA";
            this.dURATADataGridViewTextBoxColumn.HeaderText = "DURATA";
            this.dURATADataGridViewTextBoxColumn.Name = "dURATADataGridViewTextBoxColumn";
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.movieDataSet;
            // 
            // movieDataSet
            // 
            this.movieDataSet.DataSetName = "MovieDataSet";
            this.movieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.txtDurata);
            this.groupBox1.Controls.Add(this.txtTitlu);
            this.groupBox1.Controls.Add(this.txtRegizor);
            this.groupBox1.Controls.Add(this.txtAnAP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(537, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga film";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(153, 275);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(116, 44);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(133, 183);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(183, 20);
            this.txtDurata.TabIndex = 1;
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(133, 133);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(183, 20);
            this.txtTitlu.TabIndex = 1;
            // 
            // txtRegizor
            // 
            this.txtRegizor.Location = new System.Drawing.Point(133, 48);
            this.txtRegizor.Name = "txtRegizor";
            this.txtRegizor.Size = new System.Drawing.Size(183, 20);
            this.txtRegizor.TabIndex = 1;
            // 
            // txtAnAP
            // 
            this.txtAnAP.Location = new System.Drawing.Point(133, 88);
            this.txtAnAP.Name = "txtAnAP";
            this.txtAnAP.Size = new System.Drawing.Size(183, 20);
            this.txtAnAP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Durata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Titlu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regizor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "AN_AP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Regizor:";
            // 
            // txtChooseRegizor
            // 
            this.txtChooseRegizor.Location = new System.Drawing.Point(623, 433);
            this.txtChooseRegizor.Name = "txtChooseRegizor";
            this.txtChooseRegizor.Size = new System.Drawing.Size(183, 20);
            this.txtChooseRegizor.TabIndex = 1;
            this.txtChooseRegizor.TextChanged += new System.EventHandler(this.txtChooseRegizor_TextChanged);
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtDurataUpdate);
            this.groupBox2.Controls.Add(this.txtTitluUpdate);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtRegizorUpdate);
            this.groupBox2.Controls.Add(this.txtAN_AP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(940, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adauga film";
            // 
            // txtDurataUpdate
            // 
            this.txtDurataUpdate.Location = new System.Drawing.Point(133, 229);
            this.txtDurataUpdate.Name = "txtDurataUpdate";
            this.txtDurataUpdate.Size = new System.Drawing.Size(183, 20);
            this.txtDurataUpdate.TabIndex = 1;
            // 
            // txtTitluUpdate
            // 
            this.txtTitluUpdate.Location = new System.Drawing.Point(133, 179);
            this.txtTitluUpdate.Name = "txtTitluUpdate";
            this.txtTitluUpdate.Size = new System.Drawing.Size(183, 20);
            this.txtTitluUpdate.TabIndex = 1;
            // 
            // txtRegizorUpdate
            // 
            this.txtRegizorUpdate.Location = new System.Drawing.Point(133, 94);
            this.txtRegizorUpdate.Name = "txtRegizorUpdate";
            this.txtRegizorUpdate.Size = new System.Drawing.Size(183, 20);
            this.txtRegizorUpdate.TabIndex = 1;
            // 
            // txtAN_AP
            // 
            this.txtAN_AP.Location = new System.Drawing.Point(133, 134);
            this.txtAN_AP.Name = "txtAN_AP";
            this.txtAN_AP.Size = new System.Drawing.Size(183, 20);
            this.txtAN_AP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durata";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Titlu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Regizor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "AN_AP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(183, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(144, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1009, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Durata:";
            // 
            // txtLS
            // 
            this.txtLS.Location = new System.Drawing.Point(927, 448);
            this.txtLS.Name = "txtLS";
            this.txtLS.Size = new System.Drawing.Size(73, 20);
            this.txtLS.TabIndex = 3;
            this.txtLS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLD
            // 
            this.txtLD.Location = new System.Drawing.Point(1084, 448);
            this.txtLD.Name = "txtLD";
            this.txtLD.Size = new System.Drawing.Size(76, 20);
            this.txtLD.TabIndex = 3;
            this.txtLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(988, 491);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(107, 41);
            this.btnCauta.TabIndex = 4;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 607);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtLD);
            this.Controls.Add(this.txtLS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwFilm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChooseRegizor);
            this.Name = "Filme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Filme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilm;
        private MovieDataSet movieDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private MovieDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGIZORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATADataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtRegizor;
        private System.Windows.Forms.TextBox txtAnAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChooseRegizor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDurataUpdate;
        private System.Windows.Forms.TextBox txtTitluUpdate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRegizorUpdate;
        private System.Windows.Forms.TextBox txtAN_AP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLS;
        private System.Windows.Forms.TextBox txtLD;
        private System.Windows.Forms.Button btnCauta;
    }
}

