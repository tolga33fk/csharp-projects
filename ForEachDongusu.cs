using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach döngüsü dizileri daha hızlı yazdırmaya yarayan bir methotdur.


            /* foreach (var item in collection)
             {                                            foreach parantezi içindeki var = veri tipi"string,int,char vb."
                                                         item = herhangi birşey içine konmasını sağlıyor a,e gibi değerler verilebilir
                 Console.WriteLine(item);                collection = neye atadıysan ona yazarsın örnekteki gibi
             }

             */



            /* string[] isimler = { "tolga", "ali", "berke", "ilyada" };


             foreach (string a in isimler)
             {

                 Console.WriteLine(a);
             }

             Console.ReadLine(); */




            double[] ondalikli = { 1.7, 5.50, 6.89, 10.27 };
            foreach (double a in ondalikli)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();



        }
    }
}
