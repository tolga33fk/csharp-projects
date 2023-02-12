using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba araba1 = new araba();

            araba1.arabarengi = "kırmızı";
            araba1.arabamodeli = "lamborghini";
            araba1.kapisayisi = 2;

            araba1.arabacalıstır();
            araba1.kapilarikilitle();
            Console.WriteLine("kapı sayısı:"+araba1.kapisayisi);
            Console.WriteLine("araba modeli:"+araba1.arabamodeli);
            Console.WriteLine("araba rengi:"+araba1.arabarengi);
            Console.ReadLine();


        }
    }
}
