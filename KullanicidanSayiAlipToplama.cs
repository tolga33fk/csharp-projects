using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdan_sayı_alıp_toplama_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* kullanıcıdan bir sayı alacağız ve 0 dan başlayıp aldığımız 
             sayıya kadar toplayacaz ve girdiği sayıya bölecez eğer ortalama 50 den büyükse
            ortalama 50 den büyük küçükse ortalama 50 den küçük yazdıracaz*/


            int a = 0;
            Console.Write("lütfen sayı giriniz:");
            int sayi =Convert.ToInt32( Console.ReadLine());

            int toplam = 0;

            for(int i =1;i<=sayi;i++)
            {
                toplam += i;  //toplam=toplam+i
               

            }

            double ortalama=toplam/sayi;
            if (ortalama >= 50)
            {
                Console.WriteLine("ortalamanız 50 den büyüktür="+ortalama);
            }
            else
            {

                Console.WriteLine("ortalamanız 50 den küçüktür="+ortalama);
            }


           
            Console.ReadLine();
          
        }
    }
}
