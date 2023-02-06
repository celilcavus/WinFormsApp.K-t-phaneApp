using _01.DatabasebEntity.View;
using _02.DatabaseModel.Repository;

namespace WinFormsApp.KütüphaneApp.Pages.PageDetails
{
    public partial class FrmOgrenciDetaylari : Form
    {
        private OgrenciDetayRepository rep = new OgrenciDetayRepository();
        public int getId { get; set; }
        public FrmOgrenciDetaylari(int id)
        {
            getId = id;
            InitializeComponent();
        }

        private void FrmOgrenciDetaylari_Load(object sender, EventArgs e)
        {
            List<ViewOgrenciDetaylari> views =  rep.Search(getId);
            if (views.Count >= 1)
            {
                foreach (var item in views)
                {
                    lblOgrenciAdi.Text = item.OgrenciAdi!.ToString();
                    lblOgrenciSoyadi.Text = item.OgrenciSoyadi!.ToString();
                    lblKitapSayisi.Text = item.KitapId.ToString();
                }
            }
            else
            {
                List<ViewOgrenciDetaylari> view = rep.getId(getId);
                foreach (var item in view)
                {
                    lblOgrenciAdi.Text = item.OgrenciAdi!.ToString();
                    lblOgrenciSoyadi.Text = item.OgrenciSoyadi!.ToString();
                    lblKitapSayisi.Text = item.KitapId.ToString();
                }
            }
           
        }
    }
}
