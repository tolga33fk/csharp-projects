using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlara_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan değer alıp karesini alalım
            // karesi 25 ten büyükse 25 ten büyük , küçükse tam tersini yazdıralım

            /*Console.Write("BİR SAYI GİRİNİZ:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi * sayi;

            if(sonuc>25)
            {
                Console.WriteLine("SAYINIZIN KARESİ="+sonuc);
                Console.WriteLine("İŞLEMİNİZ 25'TEN BÜYÜKTÜR");
                Console.ReadLine(); 
                
            }

            else if(sonuc==25)
            {
                Console.WriteLine("İŞLEMİNİZ 25'E EŞİTTİR");
                Console.ReadLine() ;    
            }
            else
            {
                Console.WriteLine("SAYINIZIN KARESİ="+sonuc);
                Console.WriteLine("İŞLEMİNİZ 25'TEN KÜÇÜKTÜR");
                Console.ReadLine();

            }*/


            Console.Write("BİR SAYI GİRİNİZ:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int karedeger=karesi(sayi);
            
            if(karedeger>=25)
            {
                Console.WriteLine("25 ten büyük veya eşit");
                Console.ReadLine();
            }

            else
            {

                Console.WriteLine("25 ten küçük");
                Console.ReadLine(); 
            }



        }

        static int karesi(int a)
        {

            return  a * a;
            
        }


        
    }
}
