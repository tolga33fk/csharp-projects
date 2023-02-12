using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVePrivateErişimBelirleyicileri
{
    public class musteri
    {
        public string isim;
        public string soyisim;
        public int maas;
        
        private string memleket;


        public void musteribilgisi()
        {
            Console.WriteLine("müşteri ismi: "+isim);
            Console.WriteLine("müşteri soyismi: "+soyisim);
            Console.WriteLine("müşteri maaşı: "+maas);
            Console.WriteLine("musteri memleketi: "+memleket);
           
        }
        public musteri()
        {
            Console.WriteLine("müşteri sınıfının yapıcı metodu çalıştı...");
           
        }

        private void isimsoyisimyazdir(string isim1,string soyisim1)
        {
            Console.WriteLine("müşterinin ismi ve soyismi: "+isim1+" "+soyisim1);
             
        }
        

    }
}
