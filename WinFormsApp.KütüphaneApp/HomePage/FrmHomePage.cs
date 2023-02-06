using WinFormsApp.KütüphaneApp.Pages;

namespace WinFormsApp.KütüphaneApp.HomePage
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            new FrmOgrenci().ShowDialog();
        }

        private void btnKitapIslemler_Click(object sender, EventArgs e)
        {
            new FrmKitapIslemleri().ShowDialog();
        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            new FrmKitapHareketKitapAra().ShowDialog();
        }

        private void btnKitapHareket_Click(object sender, EventArgs e)
        {
            new FrmKitapHareket().ShowDialog();
        }

        private void btnYazarIslemleri_Click(object sender, EventArgs e)
        {
            new FrmYazarIslemleri().ShowDialog();
        }

        private void btnYayinEviIslemleri_Click(object sender, EventArgs e)
        {
            new FrmYayinEviIslemleri().ShowDialog();
        }
    }
}
