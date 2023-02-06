using _01.DatabasebEntity.Entity;
using _01.DatabasebEntity.View;
using _02.DatabaseModel.Repository;
using _03.HelperClass;

namespace WinFormsApp.KütüphaneApp.Pages
{
    public partial class FrmKitapIslemleri : Form
    {

        private KitapIslemRepository rep = new KitapIslemRepository();
        private YayinEviRepository yayinEvi = new YayinEviRepository();
        private YazarRepository yazar = new YazarRepository();
        private Kitap kitap = new Kitap();

        public int Id { get => int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()!); }
        public int RecordCount { get => rep.getViewList().Count; }
        public FrmKitapIslemleri()
        {
            InitializeComponent();
        }
        #region Metots
        private List<ViewKitap> getlist()
        {
            var bndSource = rep.getViewList();
            var list = dataGridView1.DataSource = bndSource;

            //Label'daki kayıt toplam kayıt sayısını güncelliyor.
            //Not:Return ifadesi altında kullanamadığım için bir üst satırda kullanmak zorundaydım :)
            lblKayitSayisi.Text = RecordCount.ToString();
            return (List<ViewKitap>)list;
        }
        private bool ClearAll(bool clear = false)
        {
            if (clear == true)
            {
                txtKitapAdi.Clear();
                txtKitapSayfaSayisi.Clear();
                txtYayinEviAdi.Text = "";
                txtYazarAdi.Text = "";
                return true;
            }
            return false;
        }
        private void GetCellValue()
        {
            try
            {
                txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtKitapSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtYayinEviAdi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtYazarAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void GetYayinEvi()
        {
            var yayinEviValue = yayinEviBindingSource.DataSource = yayinEvi.List();
            txtYayinEviAdi.DataSource = yayinEviValue;
        }
        private void getYazarAdi()
        {
            var yazarAdiValue = yazarBindingSource.DataSource = yazar.List();
            txtYazarAdi.DataSource = yazarAdiValue;
        }
        #endregion
        private void FrmKitapIslemleri_Load(object sender, EventArgs e)
        {
         
            getYazarAdi();
            GetYayinEvi();
            getlist();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool returnControl = TextControl.Control(txtKitapAdi.Text, txtKitapSayfaSayisi.Text, txtYayinEviAdi.SelectedValue.ToString()!, txtYazarAdi.SelectedValue.ToString()!);
            if (returnControl == true)
            {
                try
                {
                    kitap.KitapAdi = txtKitapAdi.Text;
                    kitap.KitapSayfasi = double.Parse(txtKitapSayfaSayisi.Text);
                    kitap.KitapYayinEviId = int.Parse(txtYayinEviAdi.SelectedValue.ToString()!);
                    kitap.KitapYazarId = int.Parse(txtYazarAdi.SelectedValue.ToString()!);
                    int i = rep.Add(kitap);
                    if (true)
                    {
                        bool returnBoolControl = i >= 1 ? ClearAll(true) : ClearAll();
                        if (returnBoolControl == true)
                        {
                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız");
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
                finally
                {
                    getlist();
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool returnControl = TextControl.Control(txtKitapAdi.Text, txtKitapSayfaSayisi.Text, txtYayinEviAdi.SelectedValue.ToString()!, txtYazarAdi.SelectedValue.ToString()!);
            if (returnControl == true)
            {
                string? isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show($"{isim} İsimli Kitap Silinsin mi".ToString(), "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        kitap.Id = Id;
                        int i = rep.Delete(kitap);
                        if (true)
                        {
                            bool returnBoolControl = i >= 1 ? ClearAll(true) : ClearAll();
                            if (returnBoolControl == true)
                            {
                                MessageBox.Show("İşlem Başarılı");
                            }
                            else
                            {
                                MessageBox.Show("İşlem Başarısız");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return;
                    }
                    finally
                    {
                        getlist();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                kitap.Id = Id;
                kitap.KitapAdi = txtKitapAdi.Text;
                kitap.KitapSayfasi = double.Parse(txtKitapSayfaSayisi.Text);
                kitap.KitapYayinEviId = int.Parse(txtYayinEviAdi.SelectedValue.ToString()!);
                kitap.KitapYazarId = int.Parse(txtYazarAdi.SelectedValue.ToString()!);
                int i = rep.Update(kitap);
                if (true)
                {
                    bool returnBoolControl = i >= 1 ? ClearAll(true) : ClearAll();
                    if (returnBoolControl == true)
                    {
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız");
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                getlist();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getlist();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetCellValue();
        }

    }
}