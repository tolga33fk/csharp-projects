using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraOrnekHangiSayıBuyuk
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("LÜTFEN 1. SAYIYI GİRİNİZ:");
            int sayi1=int.Parse(Console.ReadLine());
            Console.Write("LÜTFEN 2. SAYIYI GİRİNİZ");
            int sayi2=int.Parse(Console.ReadLine());
            buyukkucuk(sayi1,sayi2);
            Console.ReadLine(); 




        }

        static void buyukkucuk(int sayi1,int sayi2)
        {
            if(sayi1<sayi2)
            {
                Console.WriteLine("ilk girdiğiniz sayı ikincisinden küçüktür");
            }
            else if(sayi1==sayi2)
            {
                Console.WriteLine("girdiğiniz sayılar birbirine eşittir");
            }
            else
            {

                Console.WriteLine("ilk girdiğiniz sayı ikincisinden büyüktür");
            }
        }
    }
}
