using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirisProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı giriş uygulaması yap
            //kullanıcı adını ve şifresini doğru girerse başarılı olacak
            //şifresini yanlış girme hakkı 3 kere olacak

            int hak = 3;
           while(true) //true yazdım ki döngü hep sağlansın diye
            {
                Console.WriteLine("adınızı giriniz");
                string ad= Console.ReadLine();

                Console.WriteLine("şifrenizi giriniz");
                string sifre= Console.ReadLine();

                if (ad=="tolga"&&sifre=="patates33")
                {
                    Console.WriteLine("tebrikler giriş yaptınız");
                    break;
                    Console.ReadLine();

                 

                }

                else
                {

                    Console.WriteLine("kullanıcı adınız veya şifreniz yanlıştır ");
                    if (hak <= 3)
                    {
                        hak -= 1;

                    }
                    if(hak==0)
                    {
                        Console.WriteLine("hakkınız dolmuştur giriş yapamazsınız");
                        break ;

                    }


                }


            }
            Console.ReadLine();

        }
    }
}
