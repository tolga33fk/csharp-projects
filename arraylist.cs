using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList koleksiyon = new ArrayList();     //arrraylist bir kütüphanenin classıdır oradan kullanır

            koleksiyon.Add("tolga");
            koleksiyon.Add("ferhan");
            koleksiyon.Add("mustafa");
            koleksiyon.Add("ilyada");



            //  Console.WriteLine("kapasite: "+koleksiyon.Capacity);   kaç kişi olduğunu yazdı

            //koleksiyon.Remove("ferhan");  ferhanı çıkardı

            //int sayım = koleksiyon.Count;  kaç kişi olduğunu yazdı

            // koleksiyon.Clear();  kişilerin hepsini sildi

            // bool varmı = koleksiyon.Contains("ferhan");  ferhanın var mı yokmu olduğunu sorgular.

            //int indexi =koleksiyon.IndexOf("ferhan");   indexi nedir onu yazar

           // koleksiyon.Insert(2, "sercan");  2. indexin altına sercan koydu

           // koleksiyon.Reverse();    diziyi ters döndürür


            foreach (var i in koleksiyon)
            {

                Console.WriteLine(i);   
            }



            ArrayList rakamlar= new ArrayList();
            rakamlar.Add(3);
            rakamlar.Add(2);
            rakamlar.Add(100);
            rakamlar.Add(35);

            //rakamlar.Sort(); diziyi küçükten büyüğe sıralar  
            foreach (int i in rakamlar)
            {
                Console.WriteLine(i);

            }

            

           
            Console.ReadLine();



        }
    }
}
