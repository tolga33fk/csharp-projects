using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetotKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   YAPICI METOTLAR: classlardan obje oluşturduğum sırada oluşan , geriye dönüş tipi olmayan metottur.
            //  ctor tabtab yaparak hızlıca yapıcı metodu açabilirsin

            İnsanÖzellikleri insan1=new İnsanÖzellikleri(1.70,"mavi","mehmet");
            Console.WriteLine("insanın boyu: "+insan1.boy);
            Console.WriteLine("insanın göz rengi: "+insan1.gözrengi);
            Console.WriteLine("insanın ismi: "+insan1.ismi);
            Console.ReadLine(); 
            

        }
    }
}
