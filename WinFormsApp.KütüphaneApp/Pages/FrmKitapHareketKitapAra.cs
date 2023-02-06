using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.Repository;

namespace WinFormsApp.KütüphaneApp.Pages
{
    public partial class FrmKitapHareketKitapAra : Form
    {
        private KitapAraRepository rep = new KitapAraRepository();
        private KitapIslemRepository kitapIslem = new KitapIslemRepository();
        public FrmKitapHareketKitapAra()
        {
          
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (radKitapTeslimEdenler.Checked)
                {
                    var datasource = rep.KitapAra(int.Parse(txtKitapAra.SelectedValue.ToString()!), "Teslim Edildi");
                    dataGridView1.DataSource = datasource;
                }
                else if (radKitapTeslimEtmeyenler.Checked)
                {
                    var datasource = rep.KitapAra(int.Parse(txtKitapAra.SelectedValue.ToString()!), "Teslim Edilmedi");
                    dataGridView1.DataSource = datasource;
                }
                else
                {
                    MessageBox.Show("Lütfen bi tanesini seçinizi.");
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void FrmKitapHareketKitapAra_Load(object sender, EventArgs e)
        {
            var getValue = kitapBindingSource.DataSource = kitapIslem.List();
            if (getValue != null)
            {
                txtKitapAra.DataSource = getValue;
            }
            else
                return;
        }
    }
}
