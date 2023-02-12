using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();


            musteri1.KILO = 85;  //değer atama yapıyorum o zaman set blokları çalışır 
                                 //değer ataması yapmasaydım get blokları çalışır

            Console.WriteLine(musteri1.KILO);
            Console.ReadLine();

            //ingiliz anahtarı sembolü property normal mavili ise fielddır



        }
    }
}
