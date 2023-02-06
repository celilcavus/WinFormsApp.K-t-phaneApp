namespace WinFormsApp.KütüphaneApp.Pages
{
    partial class FrmKitapHareketKitapAra
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.ComboBox();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAra = new System.Windows.Forms.Button();
            this.radKitapTeslimEdenler = new System.Windows.Forms.RadioButton();
            this.radKitapTeslimEtmeyenler = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapVerilisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTakipKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewKitapAraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKitapAraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKitapAra, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 45);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Kod";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.DataSource = this.kitapBindingSource;
            this.txtKitapAra.DisplayMember = "KitapAdi";
            this.txtKitapAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKitapAra.FormattingEnabled = true;
            this.txtKitapAra.Location = new System.Drawing.Point(3, 18);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(1082, 23);
            this.txtKitapAra.TabIndex = 1;
            this.txtKitapAra.ValueMember = "Id";
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(_01.DatabasebEntity.Entity.Kitap);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Controls.Add(this.btnAra, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radKitapTeslimEdenler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radKitapTeslimEtmeyenler, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1088, 36);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnAra
            // 
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // radKitapTeslimEdenler
            // 
            this.radKitapTeslimEdenler.AutoSize = true;
            this.radKitapTeslimEdenler.Location = new System.Drawing.Point(111, 4);
            this.radKitapTeslimEdenler.Name = "radKitapTeslimEdenler";
            this.radKitapTeslimEdenler.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radKitapTeslimEdenler.Size = new System.Drawing.Size(178, 24);
            this.radKitapTeslimEdenler.TabIndex = 2;
            this.radKitapTeslimEdenler.Text = "Kitap Teslim Eden Öğrenciler ";
            this.radKitapTeslimEdenler.UseVisualStyleBackColor = true;
            // 
            // radKitapTeslimEtmeyenler
            // 
            this.radKitapTeslimEtmeyenler.AutoSize = true;
            this.radKitapTeslimEtmeyenler.Checked = true;
            this.radKitapTeslimEtmeyenler.Location = new System.Drawing.Point(297, 4);
            this.radKitapTeslimEtmeyenler.Name = "radKitapTeslimEtmeyenler";
            this.radKitapTeslimEtmeyenler.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radKitapTeslimEtmeyenler.Size = new System.Drawing.Size(198, 24);
            this.radKitapTeslimEtmeyenler.TabIndex = 3;
            this.radKitapTeslimEtmeyenler.TabStop = true;
            this.radKitapTeslimEtmeyenler.Text = "Kitap Teslim Etmeyen Öğrenciler ";
            this.radKitapTeslimEtmeyenler.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.kitapIdDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.kitapVerilisTarihiDataGridViewTextBoxColumn,
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn,
            this.kitapTakipKodDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.ogrenciAdiDataGridViewTextBoxColumn,
            this.ogrenciSoyadiDataGridViewTextBoxColumn,
            this.ogrenciTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewKitapAraBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 369);
            this.dataGridView1.TabIndex = 6;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // kitapIdDataGridViewTextBoxColumn
            // 
            this.kitapIdDataGridViewTextBoxColumn.DataPropertyName = "KitapId";
            this.kitapIdDataGridViewTextBoxColumn.HeaderText = "Kitap Id";
            this.kitapIdDataGridViewTextBoxColumn.Name = "kitapIdDataGridViewTextBoxColumn";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // kitapVerilisTarihiDataGridViewTextBoxColumn
            // 
            this.kitapVerilisTarihiDataGridViewTextBoxColumn.DataPropertyName = "KitapVerilisTarihi";
            this.kitapVerilisTarihiDataGridViewTextBoxColumn.HeaderText = "Kitap Veriliş Tarihi";
            this.kitapVerilisTarihiDataGridViewTextBoxColumn.Name = "kitapVerilisTarihiDataGridViewTextBoxColumn";
            // 
            // kitapSonTeslimTarihiDataGridViewTextBoxColumn
            // 
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "KitapSonTeslimTarihi";
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn.HeaderText = "Kitap Son Teslim Tarihi";
            this.kitapSonTeslimTarihiDataGridViewTextBoxColumn.Name = "kitapSonTeslimTarihiDataGridViewTextBoxColumn";
            // 
            // kitapTakipKodDataGridViewTextBoxColumn
            // 
            this.kitapTakipKodDataGridViewTextBoxColumn.DataPropertyName = "KitapTakipKod";
            this.kitapTakipKodDataGridViewTextBoxColumn.HeaderText = "KitapTakipKod";
            this.kitapTakipKodDataGridViewTextBoxColumn.Name = "kitapTakipKodDataGridViewTextBoxColumn";
            this.kitapTakipKodDataGridViewTextBoxColumn.Visible = false;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // ogrenciAdiDataGridViewTextBoxColumn
            // 
            this.ogrenciAdiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAdi";
            this.ogrenciAdiDataGridViewTextBoxColumn.HeaderText = "Ögrenci Adı";
            this.ogrenciAdiDataGridViewTextBoxColumn.Name = "ogrenciAdiDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadiDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyadi";
            this.ogrenciSoyadiDataGridViewTextBoxColumn.HeaderText = "Ögrenci Soyadı";
            this.ogrenciSoyadiDataGridViewTextBoxColumn.Name = "ogrenciSoyadiDataGridViewTextBoxColumn";
            // 
            // ogrenciTelefonDataGridViewTextBoxColumn
            // 
            this.ogrenciTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTelefon";
            this.ogrenciTelefonDataGridViewTextBoxColumn.HeaderText = "Ögrenci Telefon";
            this.ogrenciTelefonDataGridViewTextBoxColumn.Name = "ogrenciTelefonDataGridViewTextBoxColumn";
            // 
            // viewKitapAraBindingSource
            // 
            this.viewKitapAraBindingSource.DataSource = typeof(_01.DatabasebEntity.View.ViewKitapAra);
            // 
            // FrmKitapHareketKitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(777, 489);
            this.Name = "FrmKitapHareketKitapAra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ara";
            this.Load += new System.EventHandler(this.FrmKitapHareketKitapAra_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKitapAraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAra;
        private DataGridView dataGridView1;
        private RadioButton radKitapTeslimEdenler;
        private RadioButton radKitapTeslimEtmeyenler;
        private BindingSource viewKitapAraBindingSource;
        private ComboBox txtKitapAra;
        private BindingSource kitapBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapVerilisTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapSonTeslimTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapTakipKodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ogrenciAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ogrenciSoyadiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ogrenciTelefonDataGridViewTextBoxColumn;
    }
}