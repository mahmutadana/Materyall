using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materyall
{
    internal class Metinler
    {


        //Tablo adları ve ürünid isimleri. neyebakalim bölümü için.
        public string neyebakalim_y_anaders_tablo = "tlp_y_anadersler_tbl";
        public string neyebakalim_y_anaders_urunid_adi = "dersid";

        public string neyebakalim_ekurunler_cd_pdf_tablo = "tlp_ekurunler_tbl";
        public string neyebakalim_ekurunler_cd_pdf_urunid_adi = "urunkodu";

        public string neyebakalim_g_anaders_tablo = "tlp_g_anadersler_tbl";
        public string neyebakalim_g_anaders_urunid_adi = "dersid";


        public string neyebakalim_serbest_ders_tablo = "tlp_y_serbestler_tbl";
        public string neyebakalim_s_ders_urunid_adi = "dersid";


        public string neyebakalim_defter_tablo = "tlp_defterler_tbl";
        public string neyebakalim_defter_urunid_adi = "defterkodu";

        public string neyebakalim_sosyalkulup_tablo = "tlp_sosyalkulup_tbl";
        public string neyebakalim_sosyalkulup_urunid_adi = "kulupkodu";

        //Bunda id yok. Sadece bağladığımız öğretmen id'si var.
        public string neyebakalim_digerzumreogretmenleri_tablo = "tlp_zumreogretmenleri_tbl";

        //Bunda id yok. Sadece bağladığımız öğretmen id'si var.
        public string neyebakalim_nobetyerisablonu_tablo = "tlp_nobetyeri_tbl";

        public string neyebakalim_muhasebe_odeme_tablo = "odemeler_tbl";

        public string neyebakalim_ogrenci_listesi_tablo = "tlp_ogrencilistesi_tbl";

        public string neyebakalim_bilgi_ogretmen_tablo = "tlp_ogretmenbilgileri_tbl";






        public string ogretmenlogo_ustyolu = @"C:\Materyall\Logolar";

        public string islembasarili = "Başarılı";
        public string mukerrerkayitbilgisiogretmen = "Bu okul, sınıf, şube ve öğretmen adına daha önce açılmış bir hesap bulunmaktadır.";
        public string mukerrerkayitbilgisitalep = "Bu daha önce eklenmiş.";
        public string guncellemeyapacakidyokuyarisi = "Bu müşteri numarasına ait herhangi bir kayıt bulunamadığı için işlem yapılamadı.";
        public string yenikayit_bilinmeyenhata = "Bilgiler kaydedilemedi.";

        public string veribulunamadi = "BULUNAMADI"; //İsim düzeltmeye çalıştığında hata vermesin diye 2 kelime. Arada boşluk var.
        public string ogretmenverisiyok = "Öğretmen bilgilerini kaydetmeden talep işlemi yapılamaz.";
        public string ogretmenverisivar = "İşlem için hazır.";



        public string bilgi_metni_ogrenci_listesi = "Her kaydetme işleminde öğretmene (müşteri no) kayıtlı tüm öğrenci listesi silinir ve buradaki liste kaydedilir. Değişiklikleri buradaki liste üzerinde yapıp kaydedebilirsiniz. Listeyi silip kaydederseniz tüm liste silinmiş olur.";

    }
}
