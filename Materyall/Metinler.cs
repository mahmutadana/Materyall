using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materyall
{
    internal class Metinler
    {


        //  public string siparisci_tam_yolu = @"C:\Materyall\SistemDosyaları\siparisci2022\siparisci_2022.xlsx";
        public string siparisci_tam_yolu = @"C:\Materyall\siparisci.xlsx";

        

        //sERBEST ETKİNLİK DERSİNİ otomatik olarak eklerken kullanacağız.
        public string serbestetkinlikdersininadi = "SERBEST ETKİNLİKLER";



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

        public string bilgi_mukerrer_cb_secimi = "Sadece Defter için Hızlı Talep olarak girişlerde mükerrer kayıtlara izin verilir. Aynı okul, sınıf ve şubeye birden fazla bilgi kaydı açabilirsiniz. Aynı koda sahip defter talebi aynı öğretmene sadece 1 kez yapılabilir. Aynı koda sahip Sınıf Defteri talebini birden fazla girmek için farklı mükerrer kayıtlar açmanız gerekir. Sadece şubesinde nokta nokta işareti olan kayıtlara izin verilir.";

        public string bilgi_defterbas_rb_secenekleri = "Eğer ekranda bilgilerini gördüğünüz öğretmen için işlem yapacaksanız üstteki seçeneği seçin. " +
            "Eğer ekranın alt bölümündeki arama listesindeki seçili kayıtlar için sırayla işlem yapmak isterseniz alttaki seçeneği işaretleyin. Listeden aralık seçilebilir veya ctrl ile farklı satırlar seçilebilir.";

        public string bilgi_defterbas_rb_baskisecenekleri_1 = "Basma işlemi başlatıldığında ne basmak istediğinizi seçin. Kapak ve Defter art arda baskı seçildiğinde önce kapak ve hemen arkasından defter baskısı hazırlanır.";

        public string bilgi_defterbas_rb_baskisecenekleri_2_teklitoplu1 = "Bu bölüm listeden baskı işlemi yapıyorsanız geçerlidir. Her kayıt için ayrı ayrı PDF dosyası oluşturabilirsiniz." +
            " Tek dosyada birleştir seçeneği seçildiğinde listedeki tüm kayıtların yapılan baskıları tek bir PDF dosyasında birleştirilir. Mesela 45 öğretmen için kapak basımı tek dosyada istenirse 45 sayfalık tek bir PDF oluşur. Tek tek basımda her kayıt için 1 tane olmak üzere 45 tane PDF oluşur. ";


        public string bilgi_defterbas_rb_baskisecenekleri_sonislem = "Hazırlanan dosyalar PDF olarak tutulur. Doğrudan yazdırmak isterseniz ilgili seçeneği seçebilirsiniz.";




        //Şube kısmında üç nokta varsa mükerrer için izin vereceğiz.
        public string ucnokta = "...";
        public string ucnokta_bitisik = "…";

        //Yatay pdf'leri dikeye çevirirken aynı ismi kullanamıyoruz. Bu yüzden dikey pdf yaparken dikey pdf'nin adından aşağıdaki metni replace ile sileceğiz.
        public string pdf_yatay_bilgisi = "xpdfyatayx";


        public string anasinifi_okuloncesi_yazimi = "Ana Sınıfı";

    }
}
