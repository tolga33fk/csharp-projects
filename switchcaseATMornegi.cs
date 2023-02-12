using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcaseATMornegi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1500;
            Console.WriteLine("GARANTİBANK ATMSİNE HOŞGELDİNİZ İŞLEMİNİZİ BELİRTİNİZ");
            Console.WriteLine("1-BAKİYE SORGULAMA");
            Console.WriteLine("2-PARA ÇEKME");
            Console.WriteLine("3-PARA YATIRMA");
            Console.WriteLine("4-ÇIKIŞ");
            string secim = (Console.ReadLine());

            switch(secim)
            {

                case "1":
                    Console.WriteLine("BAKİYENİZ:"+bakiye); 
                    Console.ReadLine(); 
                    break;  

                    case "2":
                    Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ TUTARI GİRİNİZ:");
                    int cekme=Convert.ToInt32(Console.ReadLine());

                    if (cekme<=1500)
                    {
                        Console.WriteLine("KALAN BAKİYENİZ:"+(bakiye-cekme));
                        Console.ReadLine(); 

                    }

                    else
                    {

                        Console.WriteLine("BAKİYENİZDEN FAZLA PARA ÇEKEMEZSİNİZ");
                        Console.ReadLine();
                    }
                    break;

                    case "3":
                    Console.WriteLine("YATIRMA TUTARINIZI GİRİNİZ:");
                    int yatır=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("YENİ BAKİYENİZ:"+(bakiye+yatır));    
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("ÇIKIŞINIZ YAPILDI BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜRLER");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("İŞLEMİNİZ DOĞRULANAMADI");
                    Console.ReadLine();
                    break;




            }











        }
    }
}
