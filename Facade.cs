namespace Facade01
{
    class Facade
    {
        private MerkezBanka merkezbanka; // Sınıfları içermesini sağlıyoruz
        private Kredi kredi;
        private Banka banka;

        public Facade()
        {
            banka = new Banka(); // Sınıfları örnekliyoruz
            kredi = new Kredi();
            merkezbanka = new MerkezBanka();
        }
        public string KrediKullan(Musteri m,string talep) // Kredi kullanma durumunu kontrol ediyoruz
        {
            if (merkezbanka.KaraListeKontrol(m.TcNo) && kredi.KrediKullanmaDurumu(m)) // Karaliste kontrolu yapıyoruz
            {
                banka.KrediyiKullan(m, talep); // Kredi çektiriyoruz
                return talep;
            }
            else
            {
                return "Kredi Kullanılamadı"; // Hata mesajı gösteriyoruz
            }
        }
    }
}
