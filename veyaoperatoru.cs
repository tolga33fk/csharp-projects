using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veyaoperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veya operatoru: || durumlardan biri doğruysa hep doğrudur

            int sayi1 = 12;

            int sayi2 = 34;


            int sayi3 = 48;


            bool kontrol = sayi1 >= sayi2 || sayi3 <= sayi1;

            Console.WriteLine(kontrol);
            Console.ReadLine(); 





        }
    }
}
