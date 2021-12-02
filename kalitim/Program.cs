using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            TemelTip t1 = new TemelTip();
            Egitmen e1 = new Egitmen();


            e1.TemelTipMetod1();
            t1.TemelTipMetod1();

            //Özel Tiplerde Boxing Unboxing
            //temeltip
            //
            //TemelTip T2;
            //T2 = e1;

            //e1 = (Egitmen)T2;

            //Personel p1 = new Personel();
            //T2 = p1;
            //p1 = (Personel)T2;

            //Ogrenci o1 = new Ogrenci();
            //T2 = o1;
            //o1 = (Ogrenci)T2;

            object O1 = e1;
            e1 = (Egitmen)O1;

            Personel P1 = new Personel();
            P1.TemelTipMetod1();

            object obj1 = O1;
            O1 = (Ogrenci)obj1;

            obj1 = P1;
            P1 = (Personel)obj1;








            Console.ReadLine();
        }
    }
}
