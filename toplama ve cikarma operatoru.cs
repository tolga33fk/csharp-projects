using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama_ve_cikarma_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 35;
            int sayi3 = 78;
            int sayi4 = -50000;

            int sonuc = (sayi1+ sayi2+ sayi3) - sayi4;

            Console.WriteLine(sonuc);
            Console.ReadLine();



        }
    }
}
