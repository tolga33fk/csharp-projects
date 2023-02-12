using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1den 10 a kadar olan sayıları yazdırın
            // 1 den 100 e kadar olan sayıların toplamını yazın
            // do while dögüsünde sonuç yanlış olsa bile 1 kere de olsa değeri yazdırır

            /* int a = 1;

             do
             {
                 Console.WriteLine(a);
                 a++;    // a++ yazmasaydım sürekli 1 de takılırdı 1 artması zorunlu olduğu için yazılır
             } while (a<=10);

             Console.ReadLine(); */



            /* int a = 1;
             int toplam = 0;
             do
             {
                 toplam+=a;
                 a++;
             } while (a<=100);


             Console.WriteLine("1 den 100 e kadar olan sayıların toplamı:" + toplam);
             Console.ReadLine(); 
            */



           /* int a =1;
            int toplam = 0;
            do
            {
                toplam += a;
                a+=2;
               

            } while (a<=1000);
            Console.WriteLine("toplamı:"+toplam);
            Console.ReadLine(); 
           */


            

        }
    }
}
