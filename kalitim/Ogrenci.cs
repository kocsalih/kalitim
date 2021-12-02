using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    public class Ogrenci:TemelTip
    {

        public string Bolum { get; set; }

        public int seviye { get; set; }


        public Ogrenci()
        {
            Console.WriteLine("Öğrenci Nesnesi Çalıştı");
        }
    }
}
