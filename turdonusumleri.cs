using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turdonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  VERİLERİN HANGİ ÇEŞİTTE OLDUĞUNU GÖSTERİR: GetType
            /* int sayi = 3;

             Console.WriteLine(sayi.GetType()) ;
             Console.WriteLine(sayi) ;
             Console.ReadLine(); 
            */



            //DÖNÜŞTÜRME BİRİMLERİ :  ToString();  Convert.ToInt();  int.Parse();  double.Parse();  (int)  






            //STRİNG DEĞERLERİ İNT VERİSİNE DÖNÜŞTÜRME


            /*string sayi1 = "3";
            string sayi2 = "5";

            int a = Convert.ToInt32(sayi1); 
            int b = Convert.ToInt32(sayi2); 
            Console.WriteLine(a + b);   
            Console.ReadLine();
            */


            //İNT VERİ TİPİNDEN STRİNG VERİSİNE DÖNÜŞTÜRME 
            // sting veri tipinde veriler yan yana yazdırılır
            /* int sayi1 = 4;
             int sayi2 = 18;

             string a= sayi1.ToString();
             string b= sayi2.ToString();
             Console.WriteLine(a+b);
            Console.ReadLine();
            */




           
            
            //DOUBLE VERİ TİPİNDEN İNT VERİSİNE DÖNÜŞTÜRME 
            // sayının ondalıklı kısmı silinir çünkü int verisi ondalıklı tutamaz

            /*double sayi1 = 5.16;

            int a = Convert.ToInt32(sayi1);
            
            Console.WriteLine(a);   
            Console.ReadLine(); 
            */




            
            
            // KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR BUNLARI DÖNÜŞTÜRME


            /*Console.WriteLine("yaşınızı giriniz");
            string kullanıcıyas = Console.ReadLine();

            int kullaniciyasint= int.Parse(kullanıcıyas);
            int kullaniciyasint2 = Convert.ToInt32(kullanıcıyas);
            

            Console.WriteLine("kullaniciyas:"+kullaniciyasint);
            Console.WriteLine("kullaniciyas2:"+kullaniciyasint2);   
            Console.ReadLine ();
            */

            
            
            
            
            
            
            
            //KULLANICIDAN 2 SAYI ALAN VE BUNLARI TOPLAYAN PROJE STRİNGTEN İNT DÖNÜŞMELİ

            /*Console.WriteLine("birincisayi");

            string sayi1 = Console.ReadLine();
            Console.WriteLine("ikincisayi");
             
            string sayi2 = Console.ReadLine();

           int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            int a = int.Parse(sayi1);
            int b = int.Parse(sayi2);

            Console.WriteLine("toplam:"+(a+b));
            Console.ReadLine(); 
            */

            


















        }
    }
}
