using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.Repository;
using _03.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.KütüphaneApp.Pages
{
    public partial class FrmYayinEviIslemleri : Form
    {
        private YayinEviRepository rep = new YayinEviRepository();
        private YayinEvi yayinEvi = new YayinEvi();
        public int Id { get => int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()!); }
        public int ListCount { get => rep.List().Count; }
        public FrmYayinEviIslemleri()
        {
            InitializeComponent();
        }
        private void getlist()
        {
            var getdata = yayinEviBindingSource.DataSource = rep.List();
            if (getdata != null)
            {
                dataGridView1.DataSource = getdata;
            }
            txtKayitSayisi.Text = ListCount.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtYayinEviAdi.Text != "")
            {
                try
                {
                    yayinEvi.YayinEviAdi = txtYayinEviAdi.Text;
                    int i = rep.Add(yayinEvi);
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
                MessageBox.Show("Lütfen Boş Bırakmayın");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string? isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (txtYayinEviAdi.Text != "")
            {
                try
                {
                    DialogResult dialog = MessageBox.Show($"{isim} isimli yayin evi silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        yayinEvi.Id = Id;
                        int i = rep.Delete(yayinEvi);
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
                MessageBox.Show("Lütfen Boş Bırakmayın");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            if (txtYayinEviAdi.Text != "")
            {
                try
                {
                    yayinEvi.Id = Id;
                    yayinEvi.YayinEviAdi = txtYayinEviAdi.Text;
                    int i = rep.Update(yayinEvi);
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
                MessageBox.Show("Lütfen Boş Bırakmayın");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            getlist();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYayinEviAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmYayinEviIslemleri_Load(object sender, EventArgs e)
        {
            getlist();
        }
    }
}
