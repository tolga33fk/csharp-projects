using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int veri tipi -2.147.483.648 +2.147.483.648 arası değerleri tutar

            /*
             8 bit=1byte
            1024 byte = 1 kilobyte
                1024 kb= 1 megabyte
                1024 mb= 1 gigabyte
                1024 gb = 1 terabyte
                1024 tb = 1 petabyte(pt)
            */


            int birinci = 1000000;
            int ikinci = 54673572;
            int ucuncu = 2000000000;
            int maxdeger= int.MaxValue;
            int mindeger= int.MinValue;

            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);

            Console.ReadLine(); 









        }
    }
}
