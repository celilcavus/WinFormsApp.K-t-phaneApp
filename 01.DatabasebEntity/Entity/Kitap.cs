namespace _01.DatabasebEntity.Entity
{
    public class Kitap
    {
        public int Id { get; set; }
        public string? KitapAdi { get; set; }
        public double KitapSayfasi { get; set; }
        public int KitapYayinEviId { get; set; }
        public int KitapYazarId { get; set; }
        
    }
}
