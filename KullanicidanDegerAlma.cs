using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdandegeralma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Readline hem ekranın kalmasını sağlar hem de kullanıcıdan değerler alınmasını sağlar




            Console.WriteLine("adınızı giriniz");
            string isim = Console.ReadLine();

            Console.WriteLine("soyadinizi giriniz");
            string soyisim= Console.ReadLine();

            Console.WriteLine("kullanicinin ismi  :" +  isim );
            Console.WriteLine("kullanicinin soyismi  :"    +    soyisim    );
            Console.ReadLine();







        }
    }
}
