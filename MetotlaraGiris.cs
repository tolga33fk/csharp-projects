using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraGiris
{
    internal class Program
    {
        // Parametresiz-geriye değer döndürmeyen metot tanımlama
        static void Main(string[] args)
        {
            selamver();
            selamver();
            selamver();
            
            adımız();
        }

        static void selamver()       // yüzlerce kodu yazdırmaya yarayan metotdur
        {
            Console.WriteLine("SELAMIN ALEYKUM");
            

        }
        static void adımız()
        {
            Console.WriteLine("TOLGA FERHAN KÜÇÜK");
            Console.ReadLine();
        }
    }
}
