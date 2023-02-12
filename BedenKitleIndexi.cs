using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenkitleindeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //beden kitle endeksi = kilo/boy*boy
            // sonuç 18 e eşit veya küçükse zayıf
            // 18-25 arası ise normal
            // 25 ve üstü ise obez yazdıran program

            Console.WriteLine("MERHABA BEDEN KİTLE ENDEKSİ İÇİN İSTENİLEN VERİLERİ GİRİNİZ");
            Console.WriteLine("KİLONUZ:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("BOYUNUZ:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double sonuc = kilo/(boy*boy);
            Console.WriteLine(" BEDEN KİTLE ENDEKSİSİNİZ:" + (sonuc));

            if (sonuc<=18)
            {
                Console.WriteLine("ZAYIFSINIZ");
                Console.ReadLine(); 

            }

            else if(sonuc>18 && sonuc<25)
            {
                Console.WriteLine("ORTA KİLOYA SAHİPSİNİZ");
                Console.ReadLine();



            }

            else
            {
                Console.WriteLine("OBEZSİNİZ ACİL DESTEK ALMALISINIZ");
                Console.ReadLine();




            }







        }
    }
}
