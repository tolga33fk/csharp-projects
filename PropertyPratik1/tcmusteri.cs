using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPratik1
{
    public class tcmusteri
    {
        private string tckimlikno;
        public string musteri
        {

            get

            {

                return tckimlikno.Substring(0, 4)+"******";  // girdiği tc nin 0. indexinden başla 4. indexine kadar al demek istiyor
                
            }


            set
            {

                bool kontrol=false;
                if (value.Length==11)
                {
                    for(int i=0; i<value.Length; i++)
                    {
                        bool sayimi=char.IsNumber(value[i]);   //sayı mı değil mi kontrolü

                    if(sayimi)
                        {
                            //yapmam gereken birşey yok
                        }

                        else
                        {

                            kontrol = true;
                            break;
                        }

                    }
                    if(kontrol) 
                    {
                        Console.WriteLine("hatalı karakter bulunmakta");

                    }
                    else
                    {

                        tckimlikno = value;
                    }


                }


                else
                {

                    Console.WriteLine("HATALI İŞLEM YAPTINIZ TEKRAR DENEYİNİZ");
                }


            }







            
        }



        


           









    }
}
