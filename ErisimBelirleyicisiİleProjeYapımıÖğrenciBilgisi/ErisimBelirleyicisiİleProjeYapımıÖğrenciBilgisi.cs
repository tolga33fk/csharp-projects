using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicisiİleProjeYapımıÖğrenciBilgisi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* 
             bir tane öğrencimiz olucak; öğrencinin öğrencino,isim,soyisim,vize1,vize2,final,okulismi  adında 
             değişkenleri olucak erişim belirleyicileri private yapacaz.Yapıcı metot kullanarak değişkenlere değerler
            atayacağız.

            ogrencibilgilerigoster() metodu olacak ogrencinin bilgilerini gorebilecez.
            ogrenciortalamasıbul() metodu olacak.(vize1%20 si , vize2%20 si , final%60 ını alınıp ortalaması alınacak.
            okulgetir() metodu olacak okulunu göreceğiz.

            öğrencinin seçimine göre işlemler yapılacak

            1_öğrenci bilgileri göster
            2_öğrenci ortalaması göster
            3_öğrencinin okulunu göster
            4_çıkış yap

            */

            ogrenciuygulamasi ogrenci1 = new ogrenciuygulamasi(271, "tolga", "küçük", 60, 80, 70, "kocaeli üniversitesi");

            Console.WriteLine("ADAY İŞLEMLERİNE HOŞGELDİNİZ LÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ...");
            ogrencibilgilerigoster();

            bool kontrol = true;

            while(kontrol)
            {

                string secim = Console.ReadLine();

                switch (secim)
                {
                    
                    
                    case "1":
                        ogrenci1.ogrencibilgileri();
                        break;



                        case "2":
                        ogrenci1.sonucort();
                        
                        break;

                    case "3":
                        ogrenci1.okulgetir();
                        break;


                    case "4":
                        kontrol = false;
                        
                        break;

                    





                        
                }
            }

           
        }
            static void ogrencibilgilerigoster()
            {


                
                Console.WriteLine("1_ÖĞRENCİ BİLGİLERİNİ GÖSTER");
                Console.WriteLine("2_ÖĞRENCİ ORTALAMASI GÖSTER");
                Console.WriteLine("3_ÖĞRENCİNİN OKULUNU GÖSTER");
                Console.WriteLine("4_ÇIKIŞ YAP");


            }



        
    }
}
