using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi + " " + "İsimli Müşteri eklenmiştir. ");
        }
        public void Del(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi+ " " + "İsimli Müşteri silinmiştir. ");
        }
         

    }
}
