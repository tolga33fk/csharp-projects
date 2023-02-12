using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_miras_alma_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            kedi kedi1= new kedi();

            kedi1.isim="boncuk";
            kedi1.cinsiyet = "dişi";
            kedi1.renk = "beyaz";
            kedi1.miyav();
            

            kedi1.hayvanbilgisi();

            Console.ReadLine(); 
            
             






    }
    }
}
