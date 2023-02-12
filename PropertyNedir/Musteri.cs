using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNedir
{
    public class Musteri
    {



        /*
        public int kilo;//DEĞİŞKEN 
        public int KILO { get; set; } // ÜSTTEKİ YAPIYLA AYNI ÖZELLİKTE YANİ DEĞİŞKEN  ama aşağıdaki örnek field değil propertydir 
                                      // çünkü get ve set blokları açılmıştır.
        */

        private int kilo;

        public int KILO
        {
            set
            {
                kilo=value;

            }

            get
            {

                return kilo;

            }


            


        }



    }
}
