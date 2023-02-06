namespace _01.DatabasebEntity.Entity
{
    public class KitapHareket
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int OgrenciId { get; set; }
        public string? durum { get; set; }

        public DateTime KitapVerilisTarihi { get; set; }
        public DateTime KitapSonTeslimTarihi { get; set; }
        public Guid KitapTakipKod { get; set; }
    }
}
