using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materyall
{
    internal class SiniflarSnf
    {



    }



    //Bunun içine alt sınıflar ekleyeceğiz. Mesela anaderslerSnf ögesi ekleyip verileri orada tutacağız. (İnşallah)
    public class ogretmenBilgileriSnf
    {
        public int oid { get; set; }
        public string yili { get; set; }
        public string adisoyadi { get; set; }
        public string biransi { get; set; }
        public string ili { get; set; }
        public string ilcesi { get; set; }
        public string kurumkodu { get; set; }
        public string okuladi { get; set; }
        public int sinifi { get; set; }
        public string subesi { get; set; }
        public string muduradi { get; set; }
        public string mudurunvani { get; set; }
        public string eposta { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string bayikodu { get; set; }
        public string bayiadi { get; set; }
        public string aciklama { get; set; }
        public string kayittarihi { get; set; }
        public string bayilogo { get; set; }

        public talepedilenAnaDersler[] anaDerslers { get; set; }

    }



    public class talepedilenAnaDersler
    {
        public int anaderskimlik { get; set; }
        public int anadersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }



}
