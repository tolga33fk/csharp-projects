using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KapsüllemeyeGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // getter setter metotlar
            // property ile 


            tckimlik tckimlik1=new tckimlik();
            tckimlik1.setTc(28750773616);
            tckimlik1.getTc();
           
           long tcgelen=tckimlik1.getTc();
            Console.WriteLine(tcgelen);
            Console.ReadLine();




        }
    }
}
