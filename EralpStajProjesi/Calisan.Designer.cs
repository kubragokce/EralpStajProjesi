
namespace EralpStajProjesi
{
    partial class Calisan
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
            this.calisanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanAdiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eralpstajDataSet = new EralpStajProjesi.eralpstajDataSet();
            this.calisanTableAdapter = new EralpStajProjesi.eralpstajDataSetTableAdapters.CalisanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxDepartmanID = new System.Windows.Forms.TextBox();
            this.textBoxFirmaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCalisanID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxYeniFirmaID = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calisanIDDataGridViewTextBoxColumn,
            this.calisanAdiSoyadiDataGridViewTextBoxColumn,
            this.firmaIDDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calisanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 555);
            this.dataGridView1.TabIndex = 0;
            // 
            // calisanIDDataGridViewTextBoxColumn
            // 
            this.calisanIDDataGridViewTextBoxColumn.DataPropertyName = "CalisanID";
            this.calisanIDDataGridViewTextBoxColumn.HeaderText = "CalisanID";
            this.calisanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calisanIDDataGridViewTextBoxColumn.Name = "calisanIDDataGridViewTextBoxColumn";
            this.calisanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calisanAdiSoyadiDataGridViewTextBoxColumn
            // 
            this.calisanAdiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "CalisanAdiSoyadi";
            this.calisanAdiSoyadiDataGridViewTextBoxColumn.HeaderText = "CalisanAdiSoyadi";
            this.calisanAdiSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calisanAdiSoyadiDataGridViewTextBoxColumn.Name = "calisanAdiSoyadiDataGridViewTextBoxColumn";
            // 
            // firmaIDDataGridViewTextBoxColumn
            // 
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "Calisan";
            this.calisanBindingSource.DataSource = this.eralpstajDataSet;
            // 
            // eralpstajDataSet
            // 
            this.eralpstajDataSet.DataSetName = "eralpstajDataSet";
            this.eralpstajDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(37, 79);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdSoyad.TabIndex = 2;
            // 
            // textBoxDepartmanID
            // 
            this.textBoxDepartmanID.Location = new System.Drawing.Point(313, 79);
            this.textBoxDepartmanID.Name = "textBoxDepartmanID";
            this.textBoxDepartmanID.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepartmanID.TabIndex = 4;
            // 
            // textBoxFirmaID
            // 
            this.textBoxFirmaID.Location = new System.Drawing.Point(179, 79);
            this.textBoxFirmaID.Name = "textBoxFirmaID";
            this.textBoxFirmaID.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirmaID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departman ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Firma ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(34, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Çalışan Ekleme";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(37, 126);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 27);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(37, 317);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 27);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Kaydet";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(34, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Çalışan Silme";
            // 
            // textBoxCalisanID
            // 
            this.textBoxCalisanID.Location = new System.Drawing.Point(37, 259);
            this.textBoxCalisanID.Name = "textBoxCalisanID";
            this.textBoxCalisanID.Size = new System.Drawing.Size(100, 22);
            this.textBoxCalisanID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Çalışan ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(34, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Çalışan Firma Güncelleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(37, 508);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 27);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Yeni Firma ID";
            // 
            // textBoxYeniFirmaID
            // 
            this.textBoxYeniFirmaID.Location = new System.Drawing.Point(179, 450);
            this.textBoxYeniFirmaID.Name = "textBoxYeniFirmaID";
            this.textBoxYeniFirmaID.Size = new System.Drawing.Size(100, 22);
            this.textBoxYeniFirmaID.TabIndex = 24;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(37, 450);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Çalışan ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxAdSoyad);
            this.panel1.Controls.Add(this.textBoxYeniFirmaID);
            this.panel1.Controls.Add(this.textBoxDepartmanID);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.textBoxFirmaID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCalisanID);
            this.panel1.Location = new System.Drawing.Point(654, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 555);
            this.panel1.TabIndex = 28;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(1026, 594);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(151, 33);
            this.btnGeri.TabIndex = 29;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1218, 667);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Calisan";
            this.Text = "Calisan";
            this.Load += new System.EventHandler(this.Calisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eralpstajDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private eralpstajDataSet eralpstajDataSet;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private eralpstajDataSetTableAdapters.CalisanTableAdapter calisanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanAdiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxDepartmanID;
        private System.Windows.Forms.TextBox textBoxFirmaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCalisanID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxYeniFirmaID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeri;
    }
}