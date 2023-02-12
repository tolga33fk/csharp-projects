using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContiuneAnahtarKelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

          /*  for (int a = 1;a <= 10;a++)
            {
                if (a == 7)
                {
                    break; //döngüyü bozar

                }

                Console.WriteLine("a nın değeri:" + a);


            }
            
            Console.ReadLine(); */



            
            for(int a = 0; a<=10;a++)
            {

                if(a==7)
                {

                    continue;  //döngüyü bir kereliğine bozar
                }
                Console.WriteLine(a);

            }

            Console.ReadLine();











        }
    }
}
