using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 10 tane int değeri alınsın
            // çift değerlerin toplamı, tek değerlerin toplamı yazdırsın
            // eğer çift değerler toplamı tek değerlerden büyük ise çiftler>=tek diye yazdırsın aksi halde tam tersini yazdırsın

            int[] sayilar = new int[10];
            Console.WriteLine("lütfen tam sayı giriniz");


            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int TekSayilarinToplami=0;
            int CiftSayilarinToplami = 0;

            for(int i = 0; i < sayilar.Length; i++)
            {

                Console.Write((i+0)+"."+"İNDEX İNİ GİRİNİZ: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());    //convert.toınt32 yerine int.Parse ile de çevirebiliriz
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    CiftSayilarinToplami += sayilar[j];

                }
                else
                {

                    tekAdetToplam++;
                    TekSayilarinToplami += sayilar[j];
                }
            }
                if(CiftSayilarinToplami>=TekSayilarinToplami)
                {
                    Console.WriteLine("TEKLER TOPLAMI BÜYÜKTÜR ÇİFTLER TOPLAMINDAN");
                }
                else
                {
                    Console.WriteLine("ÇİFTLER TOPLAMI BÜYÜKTÜR TEKLER TOPLAMINDAN");
                }
           
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("TEK SAYI ADETİ: "+tekAdetToplam);
                Console.WriteLine("TEK SAYILARIN TOPLAMI: "+TekSayilarinToplami);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("ÇİFT SAYI ADETİ: "+ ciftAdetToplam);
                Console.WriteLine("ÇİFT SAYILARIN TOPLAMI: "+CiftSayilarinToplami);
                Console.ReadLine(); 
            
            

                


             





        }
    }
}
