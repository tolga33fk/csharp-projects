using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPratik1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* personelin TC kimliğini al ve:

              set şartı: 11 haneli olmalı tc si  , tüm karakterleri sayısal olmalı
            get şartı: tc kimliğinin ilk 5 hanesini alacağız
            */

            Console.WriteLine("TC KİMLİĞİNİZİ GİRİNİZ");
            string tckimlik=Console.ReadLine();

            tcmusteri musteri1=new tcmusteri();

            musteri1.musteri = tckimlik;
            Console.WriteLine("tc kimliğinizin numarası: "+musteri1.musteri);
            Console.ReadLine();





        }
    }
}
