using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    public class TemelTip
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public TemelTip()
        {
            Console.WriteLine("Temel Tip nesnesinin yapıcı metodu çalıştı");
            IdatamaIslemi();
        }

        private void IdatamaIslemi() //Private -kalıtım yapılan diğer sınıfda kullanılamaz
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 9000);
        }

        public void TemelTipMetod1()
        {
            Console.WriteLine("Temel Tip= Metod 1");
           // TemelTipMetod2();  //Protected olduğu için class içerisiinde private gibi davranır
        }

        protected void TemelTipMetod2() //protected kalıtım yapılınca erişilebilir oluyor.
        {
            Console.WriteLine("Protected Metod");
        }
    }
}
