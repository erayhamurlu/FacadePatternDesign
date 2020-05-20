using System;
using System.Windows.Forms;

namespace Facade01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ad; // Çektiğimiz verileri tutacak değişkenleri tanımlıyoruz
        private string tc;
        private string musterino;
        private string talep;
        private void KrediCek(object sender, EventArgs e)
        {
            ad = textBox1.Text; // textBox'dan verileri çekiyoruz
            tc = textBox2.Text;
            musterino = textBox3.Text;
            talep = textBox4.Text;

            Facade fcd = new Facade(); // Facade sınıfından nesnemizi gerçekliyoruz
            label1.Text = fcd.KrediKullan( // Musteri bilgilerini yolluyoruz 
                new Musteri { Ad = ad, TcNo = tc, MusteriNumarasi = musterino }
                , talep + " TL");
        }
    }
}
