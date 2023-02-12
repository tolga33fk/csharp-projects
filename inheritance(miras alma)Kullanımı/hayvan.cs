using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_miras_alma_Kullanımı
{
    public class hayvan
    {
        public string isim;
        public string cinsiyet;
        public string renk;
        private int yas;   // private olduğu için yaşa erişemem

        public void hayvanbilgisi()
        {

            Console.WriteLine("hayvanın ismi: "+isim);
            Console.WriteLine("hayvanın cinsiyeti: "+cinsiyet);
            Console.WriteLine("hayvanın rengi: "+renk);
           
        }







    }
}
