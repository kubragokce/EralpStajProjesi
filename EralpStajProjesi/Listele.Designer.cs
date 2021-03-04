
namespace EralpStajProjesi
{
    partial class Listele
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
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eralpstajDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eralpstajDataSet = new EralpStajProjesi.eralpstajDataSet();
            this.departmanTableAdapter = new EralpStajProjesi.eralpstajDataSetTableAdapters.DepartmanTableAdapter();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new EralpStajProjesi.eralpstajDataSetTableAdapters.FirmaTableAdapter();
            this.firmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.firmaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.firmaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCalisan = new System.Windows.Forms.DataGridView();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter = new EralpStajProjesi.eralpstajDataSetTableAdapters.CalisanTableAdapter();
            this.calisanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eralpstajDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calisanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmanIDDataGridViewTextBoxColumn,
            this.departmanAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(293, 476);
            this.dataGridView1.TabIndex = 0;
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            this.departmanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmanAdiDataGridViewTextBoxColumn
            // 
            this.departmanAdiDataGridViewTextBoxColumn.DataPropertyName = "DepartmanAdi";
            this.departmanAdiDataGridViewTextBoxColumn.HeaderText = "DepartmanAdi";
            this.departmanAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanAdiDataGridViewTextBoxColumn.Name = "departmanAdiDataGridViewTextBoxColumn";
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "Departman";
            this.departmanBindingSource.DataSource = this.eralpstajDataSetBindingSource;
            // 
            // eralpstajDataSetBindingSource
            // 
            this.eralpstajDataSetBindingSource.DataSource = this.eralpstajDataSet;
            this.eralpstajDataSetBindingSource.Position = 0;
            // 
            // eralpstajDataSet
            // 
            this.eralpstajDataSet.DataSetName = "eralpstajDataSet";
            this.eralpstajDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmanTableAdapter
            // 
            this.departmanTableAdapter.ClearBeforeFill = true;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "Firma";
            this.firmaBindingSource.DataSource = this.eralpstajDataSetBindingSource;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // firmaBindingSource1
            // 
            this.firmaBindingSource1.DataMember = "Firma";
            this.firmaBindingSource1.DataSource = this.eralpstajDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaIDDataGridViewTextBoxColumn,
            this.firmaAdiDataGridViewTextBoxColumn,
            this.calisanSayisiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.firmaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(389, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(377, 476);
            this.dataGridView2.TabIndex = 1;
            // 
            // firmaIDDataGridViewTextBoxColumn
            // 
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
            this.firmaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmaAdiDataGridViewTextBoxColumn
            // 
            this.firmaAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.HeaderText = "FirmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmaAdiDataGridViewTextBoxColumn.Name = "firmaAdiDataGridViewTextBoxColumn";
            // 
            // calisanSayisiDataGridViewTextBoxColumn
            // 
            this.calisanSayisiDataGridViewTextBoxColumn.DataPropertyName = "CalisanSayisi";
            this.calisanSayisiDataGridViewTextBoxColumn.HeaderText = "CalisanSayisi";
            this.calisanSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calisanSayisiDataGridViewTextBoxColumn.Name = "calisanSayisiDataGridViewTextBoxColumn";
            // 
            // firmaBindingSource2
            // 
            this.firmaBindingSource2.DataMember = "Firma";
            this.firmaBindingSource2.DataSource = this.eralpstajDataSet;
            // 
            // firmaBindingSource3
            // 
            this.firmaBindingSource3.DataMember = "Firma";
            this.firmaBindingSource3.DataSource = this.eralpstajDataSet;
            // 
            // firmaBindingSource4
            // 
            this.firmaBindingSource4.DataMember = "Firma";
            this.firmaBindingSource4.DataSource = this.eralpstajDataSetBindingSource;
            // 
            // dataGridViewCalisan
            // 
            this.dataGridViewCalisan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCalisan.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalisan.Location = new System.Drawing.Point(835, 75);
            this.dataGridViewCalisan.Name = "dataGridViewCalisan";
            this.dataGridViewCalisan.RowHeadersWidth = 51;
            this.dataGridViewCalisan.RowTemplate.Height = 24;
            this.dataGridViewCalisan.Size = new System.Drawing.Size(539, 476);
            this.dataGridViewCalisan.TabIndex = 2;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "Calisan";
            this.calisanBindingSource.DataSource = this.eralpstajDataSet;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // calisanBindingSource1
            // 
            this.calisanBindingSource1.DataMember = "Calisan";
            this.calisanBindingSource1.DataSource = this.eralpstajDataSetBindingSource;
            // 
            // eralpstajDataSetBindingSource1
            // 
            this.eralpstajDataSetBindingSource1.DataSource = this.eralpstajDataSet;
            this.eralpstajDataSetBindingSource1.Position = 0;
            // 
            // calisanBindingSource2
            // 
            this.calisanBindingSource2.DataMember = "Calisan";
            this.calisanBindingSource2.DataSource = this.eralpstajDataSetBindingSource1;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(1223, 565);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(151, 33);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(69, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departman Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(483, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Firma Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(997, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Çalışan Listesi";
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1433, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridViewCalisan);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listele";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.Departman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eralpstajDataSetBindingSource;
        private eralpstajDataSet eralpstajDataSet;
        private System.Windows.Forms.BindingSource departmanBindingSource;
        private eralpstajDataSetTableAdapters.DepartmanTableAdapter departmanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private eralpstajDataSetTableAdapters.FirmaTableAdapter firmaTableAdapter;
        private System.Windows.Forms.BindingSource firmaBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource firmaBindingSource2;
        private System.Windows.Forms.BindingSource firmaBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource firmaBindingSource4;
        private System.Windows.Forms.DataGridView dataGridViewCalisan;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private eralpstajDataSetTableAdapters.CalisanTableAdapter calisanTableAdapter;
        private System.Windows.Forms.BindingSource calisanBindingSource2;
        private System.Windows.Forms.BindingSource eralpstajDataSetBindingSource1;
        private System.Windows.Forms.BindingSource calisanBindingSource1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}