using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];   // diziler [] ile gösterilir 4 ün anlamı 4 karakter tutabilir anlamında
            sayilar[0] = 10;              // diziler 0 dan başlar
            sayilar[1] = 20;    
            sayilar[2] = 30;
            sayilar[3] = 40;

            for(int i=0; i<sayilar.Length; i++)    // sayilar.lenght  anlamı döngü 4 e kadar dönmesini sağlar
            {
                Console.WriteLine(sayilar[i]);


            }
            Console.ReadLine(); 


        }
    }
}
