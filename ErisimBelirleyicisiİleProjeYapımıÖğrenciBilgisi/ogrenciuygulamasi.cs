using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicisiİleProjeYapımıÖğrenciBilgisi
{
    public class ogrenciuygulamasi
    {

        private int ogrno;
        private string ogrismi;
        private string ogrsoyismi;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public ogrenciuygulamasi(int _ogrno,string _ogrismi,string _ogrsoyismi,int _vize1,int _vize2,int _final,string _okulismi)
        {
            ogrno = _ogrno;
            ogrismi = _ogrismi;
            ogrsoyismi = _ogrsoyismi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }





        public void ogrencibilgileri()
        {
            Console.WriteLine("ÖĞRENCİNİN NUMARASI: "+ogrno);
            Console.WriteLine("ÖĞRENCİNİN İSMİ: "+ogrismi);
            Console.WriteLine("ÖĞRENCİNİN SOYİSMİ: "+ogrsoyismi);
            Console.WriteLine("ÖĞRENCİNİN VİZE1 NOTU : " + vize1);
            Console.WriteLine("ÖĞRENCİNİN VİZE2 NOTU : " + vize2);
            Console.WriteLine("ÖĞRENCİNİN FİNAL NOTU : " + final);
            Console.WriteLine("ÖĞRENCİNİN OKUL İSMİ: "+ okulismi);


        }

        public double sonucort() // değer dödüren yazdırdığım için return kullandım
        {
            double sonuc = (vize1 * 0.2 + vize2 * 0.2 + final * 0.6);
            Console.WriteLine("ÖĞRENCİNİN SONUÇ ORTALAMASI: "+sonuc);
            return sonuc;   

        }
        
        public void okulgetir()
        {
            Console.WriteLine("ÖĞRENCİNİN OKUL İSMİ: "+ okulismi);
        }
        
      

        
    }   

}
