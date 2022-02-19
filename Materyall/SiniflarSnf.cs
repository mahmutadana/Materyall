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
        public string bransi { get; set; }
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


        public bool cd_istiyor { get; set; }
        public bool pdf_istiyor { get; set; }

      //Buna gerek olmayabilir. Sadece bilgileri hafızada tutup diğerlerini öğretmen id'si ile çekeceğiz.
      //public talepedilenAnaDerslerYillik[] anaDerslers { get; set; }






        
    }



    public class talepedilenAnaDerslerYillik
    {
        public int anaderskimliktablo { get; set; }
        public int anadersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }

    public class talepedilenAnaDerslerGunluk
    {
        public int anaderskimliktablo { get; set; }
        public int anadersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }


    public class talepedilenSerbestDerslerYillik
    {
        public int serbestderskimliktablo { get; set; }
        public int serbestdersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }


    public class talepedilensosyalKulup
    {
        public int sosyalkulupkimliktablo { get; set; }
        public int kulupid { get; set; }
        public string sosyalkulupikinciogretmen { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }



    public class digerZumreOgretmenlerininAdlari
    {
        public int serbestderskimliktablo { get; set; }
        public string digerogretmeninadi { get; set; }
       

    }



    public class talepedilendefterler
    {
        public int defterkimliktablo { get; set; }
        public int defterid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }



    public class nobetyeribilgisi
    {
        public int nobetyerikimliktablo { get; set; }
        public string sablonadi { get; set; }
       
    }



    public class okulbilgileri
    {
      
        public string kurumkodu { get; set; }
        public string ili { get; set; }
        public string ilcesi { get; set; }
        public string okuladi { get; set; }
        public string muduradi { get; set; }
        public string mudurunvani { get; set; }


    }





}
