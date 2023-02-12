using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 2000;
            Console.WriteLine("ZİRAAT ATMSİNE HOŞGELDİNİZ YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ");
            Console.WriteLine("1 BAKİYE SORGULAMA");
            Console.WriteLine("2 PARA ÇEKME");
            Console.WriteLine("3 PARA YATIRMA");
            Console.WriteLine("4 ÇIKIŞ");
            string secim = Console.ReadLine();

            if (secim== "1")

            {
                Console.WriteLine("ŞU ANKİ BAKİYENİZ:" + bakiye);
                Console.ReadLine();


            }

            else if (secim== "2")
            {

                Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ TUTARI GİRİNİZ");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar <= bakiye)
                {

                    Console.WriteLine("KALAN BAKİYENİZ:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();

                }

                else
                {
                    Console.WriteLine("BAKİYENİZDEKİ PARAYI AŞIYOR");
                    Console.ReadLine();
                }
                 }

                else if (secim== "3")
                {

                    Console.WriteLine("YATIRMAK İSTEDİĞİNİZ TUTARI GİRİNİZ");
                    int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("KALAN BAKİYENİZ:" + (bakiye + yatırılacak_tutar));

                    Console.ReadLine();


                }

                else if (secim == "4") 
                { 
            
                Console.WriteLine("ÇIKIŞINIZ YAPILIYOR BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜRLER");
                Console.ReadLine();

                 }

                else
                {


                    Console.WriteLine("LÜTFEN SEÇİM YAPINIZ");

                    Console.ReadLine();

                }




            














        }
    }
}
