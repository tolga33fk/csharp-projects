using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıcı  girdiği sayı dizide var mı varsa kaç tane olduğunu yoksa yok olduğunu söyleyen proje yapın
            int[] sayilar = { 10, 10, 30, 70, 89, 64, 108,70,85,50,12,12,90,45,89,12 };
            int adet = 0;
            int sayi;

            Console.Write("LÜTFEN SAYI GİRİNİZ: ");
            sayi=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;

                }
            }
                if( adet==0 )
                {
                    Console.WriteLine("GİRDİĞİNİZ SAYİ BULUNAMADI...");

                }
                else
                {
                    Console.WriteLine("GİRDİNİZ SAYI BULUNMUŞTUR");
                    Console.WriteLine("ADETİ: "+adet);

                }
                Console.ReadLine(); 
            




        }
    }
}
