using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik_inheritance
{
    public class BaseKisi
    {

        public string Ad {  get; set; }
        public string Soyad {  get; set; }
        
        public void Show()
        {
            Console.WriteLine($"Kişi adı ve soyadı = {Ad}{Soyad}");
        }

     

    }

    public class Ogrenci : BaseKisi
    {
        public int OgrNo { get; set; }

        public void OgrnShow()
        {
            Console.WriteLine($"Ogr adı soyadı ve numarası = {Ad}{Soyad}{OgrNo}");
        }



    }

    public class Ogretmen : BaseKisi
    {
        public int Maas { get; set; }


        public void OgrtShow()
        {
            Console.WriteLine($"Ogrt adı soyadı ve maas = {Ad}{Soyad}{Maas}");
        }


    }






}
