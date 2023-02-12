using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDegerDondurenMetotTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametre alan- geriye değer döndüren metot tanımlama
            //return anahtar kelimesi
            //metot sonu
            toplama(9, 7);
            Console.WriteLine(toplama(9, 7));
            
            isimsoy("tolga", "küçük");
            Console.WriteLine(isimsoy("tolga","küçük"));
            Console.ReadLine();
        }
        static int toplama(int sayi1,int sayi2)
        {
          int sonuc=  sayi1 + sayi2;
            return sonuc;
        }

        static string isimsoy(string isim1,string isim2)
        {
            string isimsoy = isim1 + isim2;
            return isimsoy;

        }
    }
}
