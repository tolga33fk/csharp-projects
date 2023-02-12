using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kararyapilariIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // öğrencinin notu 50 den büyükse başarılı küçükse başarısız olan proje 


            int not =Convert.ToInt32(Console.ReadLine());

                if (not>50)
            {
                Console.WriteLine("öğrenci sınavı başarılı bir şekilde geçmiştir");
                Console.ReadLine();


            }

                else

                    {
                Console.WriteLine("öğrenci sınavdan kalmıştır");   // eğer not 30 olsaydı else çalışırdı 
                Console.ReadLine();

            }












        }
    }
}
