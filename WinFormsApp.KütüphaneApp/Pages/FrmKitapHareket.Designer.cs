namespace WinFormsApp.KütüphaneApp.Pages
{
    partial class FrmKitapHareket
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapVerilisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewKitapAraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDurum = new System.Windows.Forms.ComboBox();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.ComboBox();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtOgrenciAdi = new System.Windows.Forms.ComboBox();
            this.dateKitapSonTeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.dateKitapVerilisTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKitapAraBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KitapAdi,
            this.ogrenciAdiDataGridViewTextBoxColumn,
            this.durum,
            this.kitapVerilisTarihiDataGridViewTextBoxColumn,
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewKitapAraBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 423);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "KitapAdi";
            this.KitapAdi.Name = "KitapAdi";
            // 
            // ogrenciAdiDataGridViewTextBoxColumn
            // 
            this.ogrenciAdiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAdi";
            this.ogrenciAdiDataGridViewTextBoxColumn.HeaderText = "OgrenciAdi";
            this.ogrenciAdiDataGridViewTextBoxColumn.Name = "ogrenciAdiDataGridViewTextBoxColumn";
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "durum";
            this.durum.Name = "durum";
            // 
            // kitapVerilisTarihiDataGridViewTextBoxColumn
            // 
            this.kitapVerilisTarihiDataGridViewTextBoxColumn.DataPropertyName = "KitapVerilisTarihi";
            this.kitapVerilisTarihiDataGridViewTextBoxColumn.HeaderText = "KitapVerilisTarihi";
            this.kitapVerilisTarihiDataGridViewTextBoxColumn.Name = "kitapVerilisTarihiDataGridViewTextBoxColumn";
            // 
            // kitapSonTeslimTarihiDataGridViewTextBoxColumn
            // 
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "KitapSonTeslimTarihi";
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn.HeaderText = "KitapSonTeslimTarihi";
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn.Name = "kitapSonTeslimTarihiDataGridViewTextBoxColumn";
            // 
            // viewKitapAraBindingSource
            // 
            this.viewKitapAraBindingSource.DataSource = typeof(_01.DatabasebEntity.View.ViewKitapAra);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56467F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.43533F));
            this.tableLayoutPanel2.Controls.Add(this.lblKayitSayisi, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnListele, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEkle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuncelle, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(943, 36);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(494, 1);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblKayitSayisi.Size = new System.Drawing.Size(13, 25);
            this.lblKayitSayisi.TabIndex = 6;
            this.lblKayitSayisi.Text = "0";
            // 
            // btnListele
            // 
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Location = new System.Drawing.Point(325, 4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 28);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 28);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(218, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 28);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(111, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kayıt Sayısı";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKitapAdi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateKitapSonTeslimTarih, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateKitapVerilisTarih, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDurum, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOgrenciAdi, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 45);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtDurum
            // 
            this.txtDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDurum.FormattingEnabled = true;
            this.txtDurum.Items.AddRange(new object[] {
            "Teslim Edildi",
            "Teslim Edilmedi"});
            this.txtDurum.Location = new System.Drawing.Point(399, 18);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(184, 23);
            this.txtDurum.TabIndex = 12;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataSource = typeof(_01.DatabasebEntity.Entity.Ogrenci);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.DataSource = this.kitapBindingSource;
            this.txtKitapAdi.DisplayMember = "KitapAdi";
            this.txtKitapAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKitapAdi.FormattingEnabled = true;
            this.txtKitapAdi.Location = new System.Drawing.Point(3, 18);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(200, 23);
            this.txtKitapAdi.TabIndex = 1;
            this.txtKitapAdi.ValueMember = "Id";
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(_01.DatabasebEntity.Entity.Kitap);
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.DataSource = this.ogrenciBindingSource;
            this.txtOgrenciAdi.DisplayMember = "OgrenciAdi";
            this.txtOgrenciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtOgrenciAdi.FormattingEnabled = true;
            this.txtOgrenciAdi.Location = new System.Drawing.Point(209, 18);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(184, 23);
            this.txtOgrenciAdi.TabIndex = 9;
            this.txtOgrenciAdi.ValueMember = "Id";
            // 
            // dateKitapSonTeslimTarih
            // 
            this.dateKitapSonTeslimTarih.CustomFormat = "dd/MM/yyyy";
            this.dateKitapSonTeslimTarih.Location = new System.Drawing.Point(795, 18);
            this.dateKitapSonTeslimTarih.Name = "dateKitapSonTeslimTarih";
            this.dateKitapSonTeslimTarih.Size = new System.Drawing.Size(145, 23);
            this.dateKitapSonTeslimTarih.TabIndex = 11;
            // 
            // dateKitapVerilisTarih
            // 
            this.dateKitapVerilisTarih.CustomFormat = "dd/MM/yyyy";
            this.dateKitapVerilisTarih.Enabled = false;
            this.dateKitapVerilisTarih.Location = new System.Drawing.Point(589, 18);
            this.dateKitapVerilisTarih.Name = "dateKitapVerilisTarih";
            this.dateKitapVerilisTarih.Size = new System.Drawing.Size(200, 23);
            this.dateKitapVerilisTarih.TabIndex = 10;
            this.dateKitapVerilisTarih.Value = new System.DateTime(2023, 2, 6, 12, 50, 19, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Son Teslim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Veriliş Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kitap Durum";
            // 
            // FrmKitapHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmKitapHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Hareket";
            this.Load += new System.EventHandler(this.FrmKitapHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKitapAraBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblKayitSayisi;
        private Button btnListele;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox txtOgrenciAdi;
        private ComboBox txtKitapAdi;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker dateKitapSonTeslimTarih;
        private DateTimePicker dateKitapVerilisTarih;
        private BindingSource kitapBindingSource;
        private BindingSource ogrenciBindingSource;
        private BindingSource viewKitapAraBindingSource;
        private ComboBox txtDurum;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn KitapAdi;
        private DataGridViewTextBoxColumn ogrenciAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durum;
        private DataGridViewTextBoxColumn kitapVerilisTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapSonTeslimTarihiDataGridViewTextBoxColumn;
    }
}