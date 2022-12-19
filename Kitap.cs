namespace KitapUygulaması.Models
{
    public class Kitap
    {
        private int Id { get; set; }
        public string KitapAd { get; set; }    
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public int Puan { get; set; }

    }
}
