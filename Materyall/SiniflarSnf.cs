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


    public class VarsayilanYilBayivbBossaSnf
    {
        //Eğer yıl veya bayi seçilmezse varsayılan olarak bu değerler yazılacak.

        public int varsayilankimliktablo { get; set; }
        public int yilkodu { get; set; }
        public string yilgorunen { get; set; }


        public string bayikodu { get; set; }
        public string bayigorunen { get; set; }


    }


    //Bunun içine alt sınıflar ekleyeceğiz. Mesela anaderslerSnf ögesi ekleyip verileri orada tutacağız. (İnşallah)
    public class OgretmenBilgileriSnf
    {
        public int oid { get; set; }
        public string yili { get; set; }
        public string adisoyadi { get; set; }
        public string bransi { get; set; }
        public string ili { get; set; }
        public string ilcesi { get; set; }
        public string kurumkodu { get; set; }
        public string okuladi { get; set; }
        public string sinifi { get; set; }
        public string subesi { get; set; }
        public string muduradi { get; set; }
        public string mudurunvani { get; set; }
        public string eposta { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
       
       
        public string aciklama { get; set; }
        public string kayittarihi { get; set; }

        public string ogretmenlogo { get; set; }

        public string bayikodu { get; set; }

        public bool cd_istiyor { get; set; }
        public bool pdf_istiyor { get; set; }


        public Bayibilgileri bayibilgileri { get; set; }


      //Buna gerek olmayabilir. Sadece bilgileri hafızada tutup diğerlerini öğretmen id'si ile çekeceğiz.
      //public talepedilenAnaDerslerYillik[] anaDerslers { get; set; }

        public TalepedilensosyalKulup sosyalkuluptalebi { get; set; }





    }



    public class TalepedilenAnaDerslerYillik
    {
        public int anaderskimliktablo { get; set; }
        public int anadersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }

    public class TalepedilenAnaDerslerGunluk
    {
        public int anaderskimliktablo { get; set; }
        public int anadersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }


    public class TalepedilenSerbestDerslerYillik
    {
        public int serbestderskimliktablo { get; set; }
        public int serbestdersid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }


    public class TalepedilensosyalKulup
    {
        public int sosyalkulupkimliktablo { get; set; }
        public int kulupkodu { get; set; }
        public string sosyalkulupikinciogretmen { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }



    public class DigerZumreOgretmenlerininAdlari
    {
        public int serbestderskimliktablo { get; set; }
        public string digerogretmeninadi { get; set; }
       

    }



    public class Talepedilendefterler
    {
        public int defterkimliktablo { get; set; }
        public int defterid { get; set; }
        public double fiyat { get; set; }
        public string taleptarihi { get; set; }
        public string basimtarihi { get; set; }


    }



    public class Nobetyeribilgisi
    {
        public int nobetyerikimliktablo { get; set; }
        public string sablonadi { get; set; }
       
    }



    public class Okulbilgileri
    {
      
        public string kurumkodu { get; set; }
        public string ili { get; set; }
        public string ilcesi { get; set; }
        public string okuladi { get; set; }
        public string muduradi { get; set; }
        public string mudurunvani { get; set; }


    }




    public class Bayibilgileri
    {

        public string bayikodu { get; set; }
        public string bayiadi { get; set; }
        public string iladi { get; set; }
        public string ilceadi { get; set; }
        public string ucretgrubu { get; set; }
       

    }






    //Ana ekranda listelenenverilerle ilgili sınıflar.


    public class FiltrelenenAnaDersler
    {
        public int anaderskimliktablo { get; set; }
        public int anadersid { get; set; }
        public string dersadi { get; set; }
        public string bolum { get; set; }
        public double fiyat { get; set; }

        public bool anadersmi { get; set; }

    }

        public class FiltrelenenGunlukPlaniOlanDersler
        {
        public int gunlukkimliktablo { get; set; }
        public int gunlukdersid { get; set; }
        public string dersadi { get; set; }
        public string bolum { get; set; }
        public double fiyat { get; set; }

    }



    public class FiltrelenenSerbestEtkinlikDersleri
    {
        public int serbestkimliktablo { get; set; }
        public int serbestdersid { get; set; }
        public string serbestdersadi { get; set; }

        //Bu derslerde bölüm ve ücret yok. Yıllık planda SERBEST ETKİNLİKLER seçilince fiyatlandırmayı oradan yapıyor.
      //  public string bolum { get; set; }
      //  public double fiyat { get; set; }

    }





    public class FiltrelenenSosyalKulupler
    {
        public int kulupkimliktablo { get; set; }
        public int kulupkodu { get; set; }
        public string kulupadi { get; set; }
        public string bolum { get; set; }
        public double fiyat { get; set; }

    }



    public class FiltrelenenDefterler
    {
        public int defterkimliktablo { get; set; }
        public int defterkodu { get; set; }
        public string defteradi { get; set; }
        public string sayfasayisi { get; set; }
        public string sinif { get; set; }
        public int derssayisi { get; set; }
        public string ozellik { get; set; }
        public string kapak { get; set; }
        public double fiyat { get; set; }

    }





    public class FiltrelenenEkUrunler
    {
        public int ekurunkimliktablo { get; set; }
        public int urunkodu { get; set; }
        public string urunadi { get; set; }
        public double fiyat { get; set; }

    }


    public class FiltrelenenNobetYeriSablonlari
    {
        public int nobetyerikimliktablo { get; set; }
        public string nobetyerisablonadi { get; set; }
        public string nobetyeri_1 { get; set; }
        public string nobetyeri_2 { get; set; }
        public string nobetyeri_3 { get; set; }
        public string nobetyeri_4 { get; set; }
        public string nobetyeri_5 { get; set; }
        public string nobetyeri_6 { get; set; }
        public string nobetyeri_7 { get; set; }
        public string nobetyeri_8 { get; set; }
        public string nobetyeri_9 { get; set; }
        public string nobetyeri_10 { get; set; }
        public string nobetyeri_11 { get; set; }
        public string nobetyeri_12 { get; set; }


    }




    public class OgrenciListesiSnf
    {
        public int ogrencikimliktablo { get; set; }
        public int numara { get; set; }
        public string adisoyadi { get; set; }
       

    }



    public class MuhasebeGenelDurumSnf
    {
       
        public double toplamborc { get; set; }
        public double toplamodeme { get; set; }
        public double toplambakiye { get; set; }


    }



    public class ExcelSutunEslestir_Bilgi_Snf
    {
        //Eğer yıl veya bayi seçilmezse varsayılan olarak bu değerler yazılacak.

       
        public int bayikodu_stn { get; set; }
        public int aciklama_stn { get; set; }
        public int okulkodu_stn { get; set; }
        public int il_stn { get; set; }
        public int ilce_stn { get; set; }
        public int okuladi_stn { get; set; }
        public int sinif_stn { get; set; }
        public int sube_stn { get; set; }
        public int adisoyadi_stn { get; set; }
        public int bransgorevi_stn { get; set; }
        public int muduradi_stn { get; set; }
        public int mudurunvani_stn { get; set; }
        public int eposta_stn { get; set; }
        public int telefon_stn { get; set; }


    }




}
