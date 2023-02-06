namespace _01.DatabasebEntity.View
{
    public class ViewKitapAra
    {
        public int Id { get; set; }
        public DateTime? KitapVerilisTarihi { get; set; }
        public DateTime? KitapSonTeslimTarihi { get; set; }
        public Guid KitapTakipKod { get; set; }
        public int KitapId { get; set; }
        public string? KitapAdi { get; set; }
        public string? durum { get; set; }
        public string? OgrenciAdi { get; set; }
        public string? OgrenciSoyadi { get; set; }
        public string? OgrenciTelefon { get; set; }
    }
}
