using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    public class Egitmen:TemelTip
    {

        public string Brans { get; set; }
        public string BransSeviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin yapıcı metodu çalıştı");
        }
    }
}
