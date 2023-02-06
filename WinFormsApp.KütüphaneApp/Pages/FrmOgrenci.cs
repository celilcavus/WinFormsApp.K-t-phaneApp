using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.Repository;
using _03.HelperClass;
using WinFormsApp.KütüphaneApp.Pages.PageDetails;

namespace WinFormsApp.KütüphaneApp.Pages
{
    public partial class FrmOgrenci : Form
    {
        private OgrenciRepository ogrenci = new OgrenciRepository();
        private int GridCount { get => ogrenci.List().Count; }
        private int id { get; set; }
        //private int SelectCount { get => dataGridView1.Select(); }
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        //methods
        #region Methods


        private void GetList()
        {
            dataGridView1.DataSource = ogrenci.List();
            lblOgrenciSayisi.Text = GridCount.ToString();

        }
        private void GetSelectCell()
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()!);
                txtOgrenciAdi.Text = string.Format(dataGridView1.CurrentRow.Cells[1].Value.ToString()!);
                txtOgrenciSoyadi.Text = string.Format(dataGridView1.CurrentRow.Cells[2].Value.ToString()!);
                txtOgrenciTc.Text = string.Format(dataGridView1.CurrentRow.Cells[3].Value.ToString()!);
                txtOgrenciTel.Text = string.Format(dataGridView1.CurrentRow.Cells[4].Value.ToString()!);
                comboBox1.Text = string.Format(dataGridView1.CurrentRow.Cells[5].Value.ToString()!);
            }
            catch (Exception)
            {

                return;
            }

        }

        private bool ClearAll(bool clear = false)
        {
            if (clear == true)
            {
                txtOgrenciAdi.Clear();
                txtOgrenciSoyadi.Clear();
                txtOgrenciTc.Clear();
                txtOgrenciTel.Clear();
                comboBox1.Text = null;
            }
            return clear;
        }
        #endregion
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            //Her hangi bir öğe seçilmez ise çalışmaz.
            //Eğer seçilirse demekki kayıt var demektir
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            GetList();
        }
        bool returnBool;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                returnBool = TextControl.Control(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, txtOgrenciTel.Text, txtOgrenciTc.Text, comboBox1.Text);
                if (returnBool == true)
                {
                    Ogrenci ogr = new Ogrenci();
                    ogr.OgrenciAdi = txtOgrenciAdi.Text;
                    ogr.OgrenciSoyadi = txtOgrenciSoyadi.Text;
                    ogr.OgrenciTelefon = txtOgrenciTel.Text;
                    ogr.OgrenciTc = txtOgrenciTc.Text;
                    ogr.OgrenciCinsiyet = comboBox1.Text.ToString();
                    var i = ogrenci.Add(ogr);
                    var returnBoolValue = i >= 1 ? ClearAll(true) : ClearAll();
                    if (returnBoolValue == true)
                    {
                        MessageBox.Show("Öğrenci Başarıyla Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Ekleme Başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci Bilgilerini Lütfen Eksiksiz Doldurun.", "Eksik Bilgi", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                returnBool = false;
            }
            finally
            {
                GetList();

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string? isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string? soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string? fullName = string.Concat(" ", isim, " ", soyisim);

                Ogrenci ogr = new Ogrenci();
                ogr.Id = id;
                DialogResult returnResult = MessageBox.Show(string.Concat(fullName, " Kayıtlı Öğrenci Liste'den silinsin mi?"), "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (returnResult == DialogResult.Yes)
                {
                    var i = ogrenci.Delete(ogr);
                    var returnBoolValue = i >= 1 ? ClearAll(true) : ClearAll();
                    if (returnBoolValue == true)
                    {
                        //hücre silinirse buttonlar tekrar dan pasif olucak
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                        MessageBox.Show("Öğrenci Başarıyla Silindi");
                    }
                    else
                    {
                        MessageBox.Show("Başarısız");
                    }
                }
            }
            catch (Exception)
            {
                returnBool = false;
            }
            finally
            {
                GetList();

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                returnBool = TextControl.Control(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, txtOgrenciTel.Text, txtOgrenciTc.Text, comboBox1.Text);
                if (returnBool == true)
                {
                    Ogrenci ogr = new Ogrenci();
                    ogr.Id = id;
                    ogr.OgrenciAdi = txtOgrenciAdi.Text;
                    ogr.OgrenciSoyadi = txtOgrenciSoyadi.Text;
                    ogr.OgrenciTelefon = txtOgrenciTel.Text;
                    ogr.OgrenciTc = txtOgrenciTc.Text;
                    ogr.OgrenciCinsiyet = comboBox1.Text.ToString();
                    var i = ogrenci.Update(ogr);
                    var returnBoolValue = i >= 1 ? ClearAll(true) : ClearAll();
                    if (returnBoolValue == true)
                    {
                        //hücre silinirse buttonlar tekrar dan pasif olucak
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                        MessageBox.Show("Öğrenci Başarıyla Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci Bilgilerini Lütfen Eksiksiz Doldurun.", "Eksik Bilgi", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                returnBool = false;
            }
            finally
            {
                GetList();

            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelectCell();
            //hücre seçilirse buttonlar aktif olucak 
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }
        // Öğrenci Detaylarını göster seçilirse aktif olucak bunun dışında pasif
        private bool CheckOgrenciDetaylari;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                new FrmOgrenciDetaylari(id).ShowDialog();
            }
            else if (checkBox1.Checked == false)
            {
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                CheckOgrenciDetaylari = true;
            }
            else if (checkBox1.Checked == false)
            {
                CheckOgrenciDetaylari = false;
            }
        }
    }

}
