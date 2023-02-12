using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMetotTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre Alan - Geriye Değer Dönmeyen Metod Kullanma

            //toplama(7,10);
            // carpma(12, 28, 89);
            isimsoyisimyazdirma("TOLGA", "KÜÇÜK");
            Console.ReadLine(); 

        }

        /*static void toplama(int sayi1 ,int sayi2)
        {
            Console.WriteLine("GÖNDERİLEN SAYILARIN TOPLAMI: "+(sayi1+sayi2));

        }*/
        /*static void carpma(int sayi1, int sayi2, int sayi3)
        {

            Console.WriteLine("3 SAYININ ÇARPIMININ SONUCU: " + (sayi1 * sayi2 * sayi3));
        }*/

        static void isimsoyisimyazdirma(string isim1, string isim2)
        {

            Console.WriteLine("İSMİNİZ SOYİSMİNİZ:" +(isim1)+" "+(isim2));
        }
    }
}
