using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziProjesiKullanıcıdanAdAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = new string[3];

            for(int i=0; i<adlar.Length; i++)

            {
                Console.Write("İSİMLER DİZİSİNİN "+(i+0)+"."+"İNDEXİ:");
                adlar[i]=Console.ReadLine();    

            }
            Console.WriteLine("----------------");

            for(int i=0; i<adlar.Length; i++)
            {
                Console.Write(adlar[i]);

            }
            Console.ReadLine(); 



        }
    }
}
