using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVePrivateErişimBelirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public -- private
            // public : herkese açıktır her kod görebilir
            // private : kendi classı hariç hiçbir yerde gözükmez kendi classında çalışır 


            musteri musteri1= new musteri();

            musteri1.isim = "tolga";
            musteri1.soyisim = "küçük";
            musteri1.maas = 2600;
            //musteri1.memleket="mersin"   işte burada memleket yazdıramazsın çünkü memleket private erişiminde sadece kendi classında çalışır

            
            


            




        }
    }
}
