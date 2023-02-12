using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraOrnekTekCiftOlduğunuBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("BİR SAYI GİRİNİZ:");
            int sayi=int.Parse(Console.ReadLine());
            tekcift(sayi);
            Console.ReadLine(); 


        }
        static void tekcift(int sayi1)
        {
            if(sayi1%2==0)
            {
                Console.WriteLine("SAYI ÇİFTTİR");


            }
            else
            {

                Console.WriteLine("SAYI TEKTİR");
            }

        }
    }
}
