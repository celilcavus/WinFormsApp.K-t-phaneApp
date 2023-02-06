using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.Repository;

namespace WinFormsApp.KütüphaneApp.Pages
{
    public partial class FrmKitapHareket : Form
    {
        private KitapIslemRepository kitapIslem = new KitapIslemRepository();
        private OgrenciRepository ogrenciRepository = new OgrenciRepository();
        private KitapHareketRepository rep = new KitapHareketRepository();
        private KitapHareket kitap = new KitapHareket();

        public int KitapHareketId { get => int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()!); }
        public int ListCount { get => rep.List().Count; }
        public FrmKitapHareket()
        {
            InitializeComponent();
        }
        #region Methods
        private void GetKitapAdi()
        {
            var getdata = kitapBindingSource.DataSource = kitapIslem.List();
            if (getdata != null)
            {
                txtKitapAdi.DataSource = getdata;
            }

        }
        private void GetOgrenciAdi()
        {
            var getdata = ogrenciBindingSource.DataSource = ogrenciRepository.List();
            if (getdata != null)
            {
                txtOgrenciAdi.DataSource = getdata;
            }
        }

        private void GetList()
        {
            var getList = rep.List();
            dataGridView1.DataSource = getList;

            lblKayitSayisi.Text = ListCount.ToString();
        }
        #endregion
        private void FrmKitapHareket_Load(object sender, EventArgs e)
        {
            GetOgrenciAdi();
            GetKitapAdi();
            GetList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                kitap.KitapId = int.Parse(txtKitapAdi.SelectedValue.ToString()!);
                kitap.OgrenciId = int.Parse(txtOgrenciAdi.SelectedValue.ToString()!);
                kitap.KitapVerilisTarihi = DateTime.Parse(dateKitapVerilisTarih.Text.ToString());
                kitap.KitapSonTeslimTarihi = DateTime.Parse(dateKitapSonTeslimTarih.Text.ToString());
                kitap.durum = txtDurum.Text;
                int i = rep.Add(kitap);
                if (i >= 1)
                {
                    MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                GetList();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
              string? isim = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                kitap.Id = KitapHareketId;
                int i = rep.Delete(kitap);
                DialogResult result = MessageBox.Show($"{isim} isimli Öğrencinin Kitap Hareketi Silinsinmi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (i >= 1)
                    {
                        MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception)
            {

                throw;
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
                kitap.Id = KitapHareketId;
                kitap.KitapId = int.Parse(txtKitapAdi.SelectedValue.ToString()!);
                kitap.OgrenciId = int.Parse(txtOgrenciAdi.SelectedValue.ToString()!);
                kitap.KitapVerilisTarihi = DateTime.Parse(dateKitapVerilisTarih.Text.ToString());
                kitap.KitapSonTeslimTarihi = DateTime.Parse(dateKitapSonTeslimTarih.Text.ToString());
                kitap.durum = txtDurum.Text;
                int i = rep.Update(kitap);
                if (i >= 1)
                {
                    MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                GetList();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetList();
            this.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDurum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateKitapVerilisTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateKitapSonTeslimTarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
