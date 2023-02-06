using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.Repository;
using _03.HelperClass;

namespace WinFormsApp.KütüphaneApp.Pages
{
    public partial class FrmYazarIslemleri : Form
    {
        private YazarRepository rep = new YazarRepository();
        private Yazar yazar = new Yazar();

        public int ListCount { get => rep.List().Count; }
        private int Id { get => int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()!); }
        public FrmYazarIslemleri()
        {
            InitializeComponent();
        }
        private void getlist()
        {
            var getdata = yazarBindingSource.DataSource = rep.List();
            if (getdata != null)
            {
                dataGridView1.DataSource = getdata;
            }
            txtKayitSayisi.Text = ListCount.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtYazarAdi.Text != "" && txtYazarSoyad.Text != "")
            {
                try
                {
                    yazar.YazarAdi = txtYazarAdi.Text;
                    yazar.YazarSoyadi = txtYazarSoyad.Text;
                    int i = rep.Add(yazar);
                    if (i >= 1)
                    {
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız");
                    }
                }
                catch (Exception)
                {
                    throw;
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

        private void FrmYazarIslemleri_Load(object sender, EventArgs e)
        {
            getlist();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtYazarAdi.Text != "" && txtYazarSoyad.Text != "")
            {
                string? isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string? soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string? fullisim = string.Concat(isim, " ", soyisim);
                try
                {
                    DialogResult dialog = MessageBox.Show($"{fullisim} isimli yazarı silmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        yazar.Id = Id;
                        int i = rep.Delete(yazar);
                        if (i >= 1)
                        {
                            MessageBox.Show("İşlem Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız");
                        }
                    }
                    else
                        return;

                }
                catch (Exception)
                {
                    throw;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYazarAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazarSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYazarAdi.Text != "" && txtYazarSoyad.Text != "")
            {
                try
                {
                    yazar.Id = Id;
                    yazar.YazarAdi = txtYazarAdi.Text;
                    yazar.YazarSoyadi = txtYazarSoyad.Text;
                    int i = rep.Update(yazar);
                    if (i >= 1)
                    {
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız");
                    }
                }
                catch (Exception)
                {
                    throw;
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
}
