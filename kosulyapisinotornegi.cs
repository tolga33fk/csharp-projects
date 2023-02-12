using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosulyapisinotornegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan sınav sonucu alınıp puanına göre not verme projesi


            Console.WriteLine("notlarınızı giriniz");
            int birinci= Convert.ToInt32(Console.ReadLine());
            int ikinci = Convert.ToInt32(Console.ReadLine());   
            int ucuncu =Convert.ToInt32(Console.ReadLine()) ;

            int sonuc = (birinci + ikinci + ucuncu) / 3;
            


            if (sonuc > 80 && sonuc < 100)
                
            {
                Console.WriteLine("sınavı A+ ile geçtiniz");

            }




            else if (sonuc < 80 && sonuc > 60)
            {
                Console.WriteLine("sınavı A ile geçtiniz");

            }
            else if (sonuc > 40 && sonuc < 60)
            {

                Console.WriteLine("sınavı B ile geçtiniz");


            }


            else
             {

                Console.WriteLine("sınavı F ile geçtiniz");




            }

            Console.ReadLine();



    }
    }
}
