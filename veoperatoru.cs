using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veoperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ve operatoru : && mantıktadaki ve gibi  düşün durumlardan biri yanlışsa yanlıştır


            int sayi1 = 4;

            int sayi2 = 10;


            int sayi3 = 35;



                bool kontrol = sayi1 == sayi2 && sayi3 < sayi1;


            Console.WriteLine(kontrol);
            Console.ReadLine(); 









        }
    }
}
