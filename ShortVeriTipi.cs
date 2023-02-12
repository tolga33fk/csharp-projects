using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // short değişkeni -32768 +32768 değerlerini tutar
            short birinci = 10000;
            short ikinci = 31311;
                short maxdeger = short.MaxValue;
            short mindeger = short.MinValue;
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();
    

        }



    }
}
