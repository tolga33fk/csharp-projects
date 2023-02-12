using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_miras_alma_Kullanımı
{
    public class kedi : hayvan      //miras almak için iki nokta konur  kedi hayvan sınıfını miras aldı yani onu kullanıyor
    {
       // buraya hiçbir şey yazılmıyor... ama istersen metot tanımlarsın ve çalışır
       // bir class sadece bir classı miras alabilir


        public void miyav()
        {

            Console.WriteLine("kedi miyavlıyor...");
        }



    }
}
