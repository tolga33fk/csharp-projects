using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //long veri tipi -9.223.372.036.854.775.807 +9.223.372.036.854.775.807 tutar. 8 byte yer kaplar

            
            long birinci = 20000844775796957;
            long maxdeger= long.MaxValue;
            long mindeger= long.MinValue;

            Console.WriteLine(birinci);
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();








        }
    }
}
