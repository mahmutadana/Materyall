using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Materyall
{
    public partial class Form1 : Form
    {

        OgretmenBilgileriSnf BirOgt;
        Bayibilgileri BirBayi;


        //Üstteki seçili bayinin bilgisini tutuyor. Buradaki tüm bayilerin bilgilerini tutuyor.
        List<Bayibilgileri> tum_bayi_bilgileris;


        //Filtrelenen verilerle ilgili id vs bilgileri tutan sınıflar.
        List<FiltrelenenAnaDersler> filtrelenenAnaDerslers = new List<FiltrelenenAnaDersler>();
        List<FiltrelenenGunlukPlaniOlanDersler> filtrelenenGunlukPlaniOlanDerslers = new List<FiltrelenenGunlukPlaniOlanDersler>();
        List<FiltrelenenSerbestEtkinlikDersleri> filtrelenenSerbestEtkinlikDerslers = new List<FiltrelenenSerbestEtkinlikDersleri>();


        List<FiltrelenenSosyalKulupler> filtrelenenSosyalKuluplers = new List<FiltrelenenSosyalKulupler>();
        List<FiltrelenenDefterler> filtrelenenDefterlers = new List<FiltrelenenDefterler>();

        List<FiltrelenenEkUrunler> filtrelenenEkUrunler = new List<FiltrelenenEkUrunler>();



        Vtislemleri vtislemleri = new Vtislemleri();
        Metinler metinler = new Metinler();
        YardimciSnf yrdsnf = new YardimciSnf();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            varsayilanDegerleriGuncelleAsync();

            dgv_talep_anadersler_yillik.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_anadersler_gunluk.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_serbestdersler_yillik.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_defterler.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_digerzumreogretmenleri.Font = linklbl_talep_kulup_sil.Font;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


      


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lbl_bekleyin.Text = "Veriler alınıyor...";
               

            SunucuSnf sunucuSnf = new SunucuSnf ();

            sunucuSnf.sunucudanTalepleriAl_Listele(datagridSunucuTalepleri);


            lbl_bekleyin.Text = "İşlem bitti. (" + datagridSunucuTalepleri.Rows.Count + ")";

        }

        private void btn_varsayilanlariguncelle_Click(object sender, EventArgs e)
        {

             varsayilanDegerleriGuncelleAsync();


        }


        private void varsayilanDegerleriGuncelleAsync()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

             vars_bilgiBolumu();

             varsa_talepBolumu();





        }


        private void vars_bilgiBolumu()
        {


            //Bu veriler daha önce girişi yapılmış kayıtlardan alındı. (tlp_ogretmenverileri_tbl)
             varsayilanDegerler_1_yil();
             varsayilanDegerler_2_brans();
             varsayilanDegerler_3_iller(); //Bu sis_iller_tbl tablosundan alıyor.
             varsayilanDegerler_4_mudurunvani();
             varsayilanDegerler_5_siniflar();

            varsayilanDegerler_bayiler();


        }


        private void varsa_talepBolumu()
        {

            //Sosyal kulüpleri kendi tablosundan alacağız.
            //Bu bilgileri bayi ve il seçildiğinde yeniden çağırabiliriz.
            if (BirOgt != null && BirOgt.bayibilgileri != null && BirOgt.bayibilgileri.ucretgrubu != null)
            {

                varsayilanDegerler_tumdersler();
                varsayilanDegerler_gunlukplaniolandersler();
                varsayilanDegerler_serbestetkinlikdersler();

                varsayilanDegerler_6_sosyalkulupler();
                varsayilanDegerler_7_defterler();

                varsayilanDegerlerEkUrunler();

                lbl_bilgi.Text = metinler.ogretmenverisivar;


                //Grid viewlerde ve ilgili yerlerde girilen talepleri göstereceğiz.
                talepleri_goster_gridViewlerde();

            } else
            {

                lbl_bilgi.Text = metinler.ogretmenverisiyok;

            }


        }


        private void talepleri_goster_gridViewlerde()
        {


            //Ek ürünleri en başa alıyoruz. Aradan çıkarmak için. Aşağıdakiler birbirine benzer kodlar olduğu için bir arada tutuyoruz.
            //CD ve PDF var mı diye bakacağız.

            foreach (FiltrelenenEkUrunler urun in filtrelenenEkUrunler)
            {
                //Şimdilik 2 ürün. Daha sonra eklenirse ekürünler buraya eklenecek.

                if (urun.urunadi == "CD") {

                    bool cddurumu = vtislemleri.ek_urun_talepEdilmismi(BirOgt.oid, urun.urunkodu);
                    cb_talep_CD.Checked = cddurumu;
                    BirOgt.cd_istiyor = cddurumu;
                }
                else if (urun.urunadi == "PDF")
                {

                    bool pdfdurumu = vtislemleri.ek_urun_talepEdilmismi(BirOgt.oid, urun.urunkodu);
                    cb_talep_pdf.Checked = pdfdurumu;
                    BirOgt.pdf_istiyor = pdfdurumu;

                }


            }



            //Sosyal kulüp bilgisini çekiyoruz.
            BirOgt.sosyalkuluptalebi = vtislemleri.talepedilensosyalKulup(BirOgt.oid);

            //Kulüp adını bulacağız ve ikinci öğretmenin adını yazacağız.
            lbl_talep_sosyalkuluptaleptatihi.Text = "Talep Tarihi:";
            lbl_talep_sosyalkulupbasimtarihi.Text = "Basım Tarihi:";

            if (BirOgt.sosyalkuluptalebi.kulupkodu > -1)
            {
                int cbindeksi = 0;

                foreach (FiltrelenenSosyalKulupler urun in filtrelenenSosyalKuluplers)
                {

                    if (urun.kulupkodu == BirOgt.sosyalkuluptalebi.kulupkodu)
                    {

                        cb_talep_sosyalkulupadi.SelectedIndex = cbindeksi;
                        break;
                    }

                    cbindeksi++;
                }

                lbl_talep_sosyalkuluptaleptatihi.Text = "Talep Tarihi: " + BirOgt.sosyalkuluptalebi.taleptarihi;
                lbl_talep_sosyalkulupbasimtarihi.Text = "Basım Tarihi: " + BirOgt.sosyalkuluptalebi.basimtarihi;


            } else
            {
                cb_talep_sosyalkulupadi.SelectedIndex = -1;
            }

            //Öğretmen adını her türlü yazıyoruz.
            tb_talep_sosyalkulupikinciogretmen.Text = BirOgt.sosyalkuluptalebi.sosyalkulupikinciogretmen;




            //Yıllık plan ana dersleri göster.
            dgv_talep_anadersler_yillik.DataSource = vtislemleri.dgv_icin_y_anaderleri_getir(BirOgt.oid, BirOgt.yili);

            //Günlük plan ana dersleri göster.
            dgv_talep_anadersler_gunluk.DataSource = vtislemleri.dgv_icin_g_anaderleri_getir(BirOgt.oid, BirOgt.yili);


            //Serbest etkinlik derslerini göster.
            dgv_talep_serbestdersler_yillik.DataSource = vtislemleri.dgv_icin_s_dersleri_getir(BirOgt.oid, BirOgt.yili);


            //Defter taleplerini göster.
            dgv_talep_defterler.DataSource = vtislemleri.dgv_icin_defterleri_getir(BirOgt.oid, BirOgt.yili);

            //Diğer zümre öğretmenlerinin isimlerini göster.
            dgv_talep_digerzumreogretmenleri.DataSource = vtislemleri.dgv_icin_digerzumreogretmenlerini_getir(BirOgt.oid);


        }





        //1. eğitim öğretim yılı.
        private void varsayilanDegerler_1_yil()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_yili.Items.Clear();

            string[] yillar = vtislemleri.filtre_eoyillari();

            foreach (string s in yillar)
            {
                //  MessageBox.Show(s, "yillar");
                cb_yili.Items.Add(s);
            }

           
        }

        private void varsayilanDegerler_2_brans()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_bransi.Items.Clear();

            string[] veriler = vtislemleri.filtre_branslar();

            foreach (string s in veriler)
            {
                
                cb_bilgi_bransi.Items.Add(s);
            }

           
        }

        private void varsayilanDegerler_3_iller()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.
            
            cb_bilgi_ili.Items.Clear();

            string[] veriler = vtislemleri.filtre_iller();

            foreach (string s in veriler)
            {
                
                cb_bilgi_ili.Items.Add(s);
            }



            
        }

        private void varsayilanDegerler_3_1_ilceler()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_ilcesi.Items.Clear();

            string[] veriler = vtislemleri.filtre_ilceler(cb_bilgi_ili.Text);

            foreach (string s in veriler)
            {

                cb_bilgi_ilcesi.Items.Add(s);
            }

        }

        private void varsayilanDegerler_4_mudurunvani()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_mudurunvani.Items.Clear();

            string[] veriler = vtislemleri.filtre_mudurunvanlar();

            foreach (string s in veriler)
            {

                cb_bilgi_mudurunvani.Items.Add(s);
            }

            
        }

        private void varsayilanDegerler_5_siniflar()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_sinifi.Items.Clear();

            string[] veriler = vtislemleri.filtre_siniflar();

            foreach (string s in veriler)
            {

                cb_bilgi_sinifi.Items.Add(s);
            }

         
        }



        private void varsayilanDegerler_bayiler()
        {
            //Bayi bilgilerini hafızada tutalım.

            cb_bilgi_bayiadi.Items.Clear();

            tum_bayi_bilgileris = vtislemleri.getir_bayiler();

            foreach (Bayibilgileri s in tum_bayi_bilgileris)
            {

                cb_bilgi_bayiadi.Items.Add(s.bayiadi + "-" + s.bayikodu);
            }


        }




        private void varsayilanDegerler_6_sosyalkulupler()
        {
           
            cb_talep_sosyalkulupadi.Items.Clear();

           // string[] veriler = vtislemleri.filtre_sosyalkulupler();

            filtrelenenSosyalKuluplers = vtislemleri.filtre_sosyalkulupler(BirOgt.yili, BirOgt.bayibilgileri.ucretgrubu.ToString());


            foreach (FiltrelenenSosyalKulupler s in filtrelenenSosyalKuluplers)
            {

                cb_talep_sosyalkulupadi.Items.Add(s.kulupadi);
            }

           
        }


        private void varsayilanDegerler_7_defterler()
        {

            cb_talep_defter.Items.Clear();

            // string[] veriler = vtislemleri.filtre_sosyalkulupler();

            filtrelenenDefterlers = vtislemleri.filtre_defterler(BirOgt.yili, BirOgt.bayibilgileri.ucretgrubu.ToString());


            foreach (FiltrelenenDefterler s in filtrelenenDefterlers)
            {

                cb_talep_defter.Items.Add(s.defteradi + " (" + s.defterkodu + ") " + s.sinif + " - " + s.ozellik);
            }


        }



        private void varsayilanDegerlerEkUrunler()
        {

           //Ek ürünlerin bilgilerini bellekte tutuyoruz.

            filtrelenenEkUrunler = vtislemleri.filtre_ekurunler(BirOgt.yili, BirOgt.bayibilgileri.ucretgrubu.ToString());


        }



        //Tüm dersleri listeleyelim.
        private void varsayilanDegerler_tumdersler()
        {

            cb_talep_anadersler_yillik.Items.Clear();

            filtrelenenAnaDerslers = vtislemleri.filtre_tumdersler(BirOgt.yili, BirOgt.ili, BirOgt.bayibilgileri.ucretgrubu.ToString());

            foreach (FiltrelenenAnaDersler s in filtrelenenAnaDerslers)
            {

                cb_talep_anadersler_yillik.Items.Add(s.dersadi);
            }

          
        }


        //Günlük planı olan dersleri ilgili yere ekleyelim.
        private void varsayilanDegerler_gunlukplaniolandersler()
        {

            cb_talep_anadersler_gunluk.Items.Clear();

            filtrelenenGunlukPlaniOlanDerslers = vtislemleri.filtre_gunlukplaniolandersler(BirOgt.yili, BirOgt.ili, BirOgt.bayibilgileri.ucretgrubu.ToString());

            foreach (FiltrelenenGunlukPlaniOlanDersler s in filtrelenenGunlukPlaniOlanDerslers)
            {

                cb_talep_anadersler_gunluk.Items.Add(s.dersadi);
            }


        }


        //Serbest etkinlik yıllık planı olan dersleri ilgili yere ekleyelim.
        private void varsayilanDegerler_serbestetkinlikdersler()
        {

            cb_talep_serbestdersler_yillik.Items.Clear();

            filtrelenenSerbestEtkinlikDerslers = vtislemleri.filtre_serbestetkinlikdersleri(BirOgt.yili, BirOgt.ili, BirOgt.bayibilgileri.ucretgrubu.ToString());

            foreach (FiltrelenenSerbestEtkinlikDersleri s in filtrelenenSerbestEtkinlikDerslers)
            {

                cb_talep_serbestdersler_yillik.Items.Add(s.serbestdersadi);
            }


        }





        private void bt_yenikayit_Click(object sender, EventArgs e)
        {
            yeniKayitYapveyaGuncelle(true);
        }



        private void yeniKayitYapveyaGuncelle(bool yenikayitmi)
        {


            if (!tumAlanlarDoldurulmusmu())
            {
                MessageBox.Show("Öğretmen bilgilerinde tüm alanların doldurulmuş olması gerekir.");
                return;
            }


            //Eğer güncelleme işlemi yapılacaksa müşreti numarası girilmiş mi diye kontrol ediyoruz. Güncelleme bu müşreti numarası üzerinden yapılacak.
            if (!yenikayitmi)
            {

                if (tb_bilgi_musterino.Text == "")
                {
                    MessageBox.Show("Güncelleme yapmak için bir müşteri kaydı çağırmış olmanız gerekir.");
                    return;
                }

            }



            OgretmenBilgileriSnf ogrblg = new OgretmenBilgileriSnf ();
            

            ogrblg.yili = cb_yili.Text;


            tb_bilgi_adisoyadi.Text = yrdsnf.ismiduzelt(tb_bilgi_adisoyadi.Text, "isim");
            ogrblg.adisoyadi = tb_bilgi_adisoyadi.Text;
            
            
            
            
            ogrblg.bransi = cb_bilgi_bransi.Text;

            ogrblg.ili = cb_bilgi_ili.Text;

            cb_bilgi_ilcesi.Text = yrdsnf.ismiduzelt(cb_bilgi_ilcesi.Text, "ilce");

            ogrblg.ilcesi = cb_bilgi_ilcesi.Text;
            ogrblg.kurumkodu = tb_bilgi_okulkodu.Text;
            ogrblg.okuladi = tb_bilgi_okulu.Text;
            ogrblg.sinifi = int.Parse(cb_bilgi_sinifi.Text);
            ogrblg.subesi = tb_bilgi_subesi.Text;

            ogrblg.muduradi = tb_bilgi_muduradi.Text;
            ogrblg.mudurunvani = cb_bilgi_mudurunvani.Text;

            ogrblg.telefon = tb_bilgi_telefon.Text;
            ogrblg.eposta = tb_bilgi_eposta.Text;
            ogrblg.adres = tb_bilgi_adres.Text;

            ogrblg.aciklama = tb_bilgi_aciklama.Text;

            ogrblg.ogretmenlogo = tb_bilgi_logo.Text;

            ogrblg.bayikodu = tb_bilgi_bayikodu.Text;
           


            if (yenikayitmi)
            {

                string kayitsonucu = vtislemleri.yeniKayit(ogrblg);

                if (kayitsonucu.All(char.IsNumber))
                {
                    ogrblg.oid = int.Parse(kayitsonucu);
                    tb_bilgi_musterino.Text = kayitsonucu;

                }
                else
                {
                    MessageBox.Show(kayitsonucu);
                }

            } else
            {
                //Yeni kayıt değil, yani güncelleme ise...

                ogrblg.oid = int.Parse( tb_bilgi_musterino.Text);

                string kayitsonucu = vtislemleri.kaydiGuncelle(ogrblg);

                    MessageBox.Show(kayitsonucu);
                

            }

           





            //Öğretmen sınıfı genel değişkenimize atadık.

            //Bayi bilgilerini tanımlıyoruz.
            ogrblg.bayibilgileri = BirBayi;

            BirOgt = ogrblg;


        }


        // Tüm alanlar doldurulmuş mu diye bakıyoruz.

        private bool tumAlanlarDoldurulmusmu ()
        {

            //Telefon, adres ve açıklama zorunlu değil.
          //  || tb_bilgi_telefon.Text == "" || tb_bilgi_eposta.Text == "" || tb_bilgi_adres.Text == "" || tb_bilgi_aciklama.Text == ""


          if  (cb_yili.Text == "" || tb_bilgi_adisoyadi.Text == "" || cb_bilgi_bransi.Text == "" || cb_bilgi_ili.Text == "" ||
               cb_bilgi_ilcesi.Text == "" || tb_bilgi_okulkodu.Text == "" || tb_bilgi_okulu.Text == "" || cb_bilgi_sinifi.Text == "" ||
               tb_bilgi_subesi.Text == "" || tb_bilgi_muduradi.Text == "" || cb_bilgi_mudurunvani.Text == "" || tb_bilgi_bayikodu.Text == "" || lbl_bilgi_kayittarihi.Text == "")
            {
                return false;  
            } else
            {
                return true;
            }

            

        }




        private void tumTalepverileriniTemizle()
        {

            BirOgt = null;

            cb_talep_anadersler_yillik.Text = "";
            cb_talep_anadersler_yillik.Items.Clear();

            cb_talep_anadersler_gunluk.Text = "";
            cb_talep_anadersler_gunluk.Items.Clear();

            cb_talep_serbestdersler_yillik.Text = "";
            cb_talep_serbestdersler_yillik.Items.Clear();


            filtrelenenSosyalKuluplers.Clear();
            cb_talep_sosyalkulupadi.Text = "";
            cb_talep_sosyalkulupadi.Items.Clear();





        }


        private void musteriBilgisiGetir()
        {

            BirOgt = null;
            BirBayi = null;

            OgretmenBilgileriSnf ogrblg = vtislemleri.ogretmenBilgisiGetir(tb_bilgi_musterino.Text);


            cb_yili.Text = ogrblg.yili;

            ogrblg.oid = int.Parse(tb_bilgi_musterino.Text);
            ogrblg.adisoyadi = yrdsnf.ismiduzelt(ogrblg.adisoyadi, "isim");

            tb_bilgi_adisoyadi.Text = ogrblg.adisoyadi;
            cb_bilgi_bransi.Text = ogrblg.bransi;
            cb_bilgi_ili.Text = ogrblg.ili;
            cb_bilgi_ilcesi.Text = ogrblg.ilcesi;
            

            tb_bilgi_okulkodu.Text = ogrblg.kurumkodu;
            tb_bilgi_okulu.Text = ogrblg.okuladi;

            if (ogrblg.sinifi != 0)
            {
                cb_bilgi_sinifi.Text = ogrblg.sinifi.ToString();
            } else
            {
                cb_bilgi_sinifi.Text = "";
            }
           

            tb_bilgi_subesi.Text = ogrblg.subesi;

            tb_bilgi_muduradi.Text = ogrblg.muduradi;
            cb_bilgi_mudurunvani.Text = ogrblg.mudurunvani;

            tb_bilgi_telefon.Text = ogrblg.telefon;
            tb_bilgi_eposta.Text = ogrblg.eposta;
            tb_bilgi_adres.Text = ogrblg.adres;

            tb_bilgi_aciklama.Text = ogrblg.aciklama;

            
            tb_bilgi_logo.Text = ogrblg.ogretmenlogo;
            ogretmenlogosu_Goster();

            tb_bilgi_bayikodu.Text = ogrblg.bayikodu;

            lbl_bilgi_kayittarihi.Text = ogrblg.kayittarihi;

            //Diğer bağlı sınıflardan bilgiler.
            cb_bilgi_bayiadi.Text = ogrblg.bayibilgileri.bayiadi;


            BirOgt = ogrblg;


            secimizrenginikaldir();

        }

        private void secimizrenginikaldir()
        {

            this.BeginInvoke(new Action(() => {

                cb_bilgi_bransi.Select(0, 0);
                cb_bilgi_ili.Select(0, 0);
                cb_bilgi_ilcesi.Select(0, 0);
                cb_bilgi_sinifi.Select(0, 0);
                cb_bilgi_mudurunvani.Select(0, 0);
                cb_bilgi_bayiadi.Select(0, 0);

                cb_yili.Select(0, 0);

            }));

        }

        private void linklbl_kurumkodundanbul_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Kurum kodundan il, ilçe, okul adı ve daha önce girilmişse müdür bilgilerini getireceğiz.

            kurumKodundanOkulBilgileriniGetir();


        }


        private void kurumKodundanOkulBilgileriniGetir()
        {
            /*
            string kurumkodu;
            string ili;
            string ilcesi;
            string okuladi;
            string muduradi;
            string mudurunvani;
            */

            Okulbilgileri okulbilgileri = vtislemleri.okulbilgisinigetir_kurumkodundan(tb_bilgi_okulkodu.Text);


            cb_bilgi_ili.Text = okulbilgileri.ili;
            cb_bilgi_ilcesi.Text = okulbilgileri.ilcesi;
            tb_bilgi_okulu.Text = okulbilgileri.okuladi;

            tb_bilgi_muduradi.Text = okulbilgileri.muduradi;
            cb_bilgi_mudurunvani.Text = okulbilgileri.mudurunvani;


        }

        private void cb_bilgi_musterinokilitli_CheckedChanged(object sender, EventArgs e)
        {

            tb_bilgi_musterino.Enabled = !cb_bilgi_musterinokilitli.Checked;

        }

        private void linklbl_musteri_no_ogrt_bilgisi_getir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (tb_bilgi_musterino.Text == "")
            {
                MessageBox.Show("Müşteri numarası girmelisiniz.");
                return;
            }
                

            //Tüm getirme işlemleri. Varsayılan talep verilerini temizleme hariç.
            //Fiyat ve ders farklıkları olduğu için her ilin ve bayinin fiyat ve dersleri farklı oluyor. Bulunamayan veri olursa önceki kayıt kalmasın.


            //Ana dersler(yıllık, günlük), seçmeli dersler, kulüpler, derfterler vs.
            tumTalepverileriniTemizle();

            musteriBilgisiGetir();


            if (cb_bilgi_bayiadi.Text == metinler.veribulunamadi)
            {
                return;
            }



            varsa_talepBolumu();

        }

       

        private void linklbl_logo_gozat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          tb_bilgi_logo.Text =  ogretmenLogosuSec();

            ogretmenlogosu_Goster();
        }


        private string ogretmenLogosuSec()
        {

            string dosyaadi = "";

            OpenFileDialog res = new OpenFileDialog();

            //Filter
            res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            res.InitialDirectory = metinler.ogretmenlogo_ustyolu; // @"C:\";

            //When the user select the file
            if (res.ShowDialog() == DialogResult.OK)
            {
                //Get the file's path
              //  var filePath = res.FileName;

                dosyaadi = res.SafeFileName;
                
            }

            return dosyaadi;

        }

        private void ogretmenlogosu_Goster()
        {

            if (tb_bilgi_logo.Text != "")
            {
                pb_logo.Image = Image.FromFile(metinler.ogretmenlogo_ustyolu + @"\" + tb_bilgi_logo.Text);

            } else
            {
                pb_logo.Image = null;
            }

        }


        private void bayikodundanBayiBilgileriniGetir()
        {
            
            int indeks = tum_bayi_bilgileris.FindIndex(a => a.bayikodu == tb_bilgi_bayikodu.Text);

            //  BirBayi = vtislemleri.bayiaBilgileriniGetir_bayikodundan(tb_bilgi_bayikodu.Text);

            if (indeks != -1)
            {

                BirBayi = tum_bayi_bilgileris[indeks];
                cb_bilgi_bayiadi.Text = BirBayi.bayiadi + "-" + BirBayi.bayikodu;

            } else
            {
                BirBayi = null;
                cb_bilgi_bayiadi.Text = metinler.veribulunamadi;
            }

           

        }

        private void tb_bilgi_bayikodu_TextChanged(object sender, EventArgs e)
        {

            bayikodundanBayiBilgileriniGetir();

        }

        private void cb_bilgi_ili_SelectedIndexChanged(object sender, EventArgs e)
        {

           if (BirOgt != null) {
                BirOgt.ili = cb_bilgi_ili.Text;
            }

            varayilanTalepleilgiliVeriler();

        }


        private void varayilanTalepleilgiliVeriler()
        {


            varsayilanDegerler_3_1_ilceler();

            varsa_talepBolumu();




        }




      

        private void cb_yili_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (BirOgt != null)
            {
                BirOgt.yili = cb_yili.Text;
            }

        }

        private void cb_bilgi_bayiadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_bilgi_bayikodu.Text = tum_bayi_bilgileris[cb_bilgi_bayiadi.SelectedIndex].bayikodu;

            //Test ettik, kısır döngüye girmiyor. Bayi kodu değşince burayı tetikliyor çünkü.
           
        }

        private void bt_guncelle_Click(object sender, EventArgs e)
        {

            //Güncelleme işlemi yapılacak.
           yeniKayitYapveyaGuncelle(false);

        }

        private void linklbl_talep_anadersler_secimiekle_yillik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (cb_talep_anadersler_yillik.SelectedIndex < 0)
            {
                MessageBox.Show("Ders seçmelisiniz.");
                return;
            }

            //Yıllık ana dersler ekle.
            y_anaders_ekle_secim();

        }

        private void y_anaders_ekle_secim()
        {


            //  MessageBox.Show(filtrelenenAnaDerslers[cb_talep_anadersler_yillik.SelectedIndex].anadersid.ToString() + " " + filtrelenenAnaDerslers[cb_talep_anadersler_yillik.SelectedIndex].dersadi);


         string kayitsonucu = vtislemleri.ekle_y_anaders(BirOgt.oid, filtrelenenAnaDerslers[cb_talep_anadersler_yillik.SelectedIndex].anadersid, filtrelenenAnaDerslers[cb_talep_anadersler_yillik.SelectedIndex].fiyat);

            if (kayitsonucu.All(char.IsNumber))
            {

              //  MessageBox.Show("başarılı: " + kayitsonucu);
                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }


        }

        private void dgv_talep_anadersler_yillik_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string dersid = dgv_talep_anadersler_yillik.Rows[e.RowIndex].Cells[metinler.neyebakalim_y_anaders_urunid_adi].Value.ToString();

          //  MessageBox.Show(dersid);

            anaders_yillik_plan_talep_sil(dersid);

        }





        private void anaders_yillik_plan_talep_sil (string dersid)
        {

            if (dersid.Length < 1)
            {
                return;
            }

            string sonuc = vtislemleri.sil_y_anaders(BirOgt.oid, int.Parse(dersid));

           if (sonuc == metinler.islembasarili)
            {

                varsa_talepBolumu();

            } else
            {
                MessageBox.Show(dersid + " silinemedi.");
            }


        }

        private void linklabel_talep_tumanadersleriekle_yillik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            y_anaders_ekle_sinif_duzeyi_tum_dersler();
        }


        private void y_anaders_ekle_sinif_duzeyi_tum_dersler()
        {


            //Döngü ile sınıf düzeylerine bakalım ve seçili sınıf düzeyine uygun olan ana dersleri ekleyelim.

            int derssayac = 0;    

            foreach (FiltrelenenAnaDersler drs in filtrelenenAnaDerslers)
            {

                if (drs.anadersmi && drs.dersadi.Substring(0,BirOgt.sinifi.ToString().Length) == BirOgt.sinifi.ToString())
                {

                    string kayitsonucu = vtislemleri.ekle_y_anaders(BirOgt.oid, filtrelenenAnaDerslers[derssayac].anadersid, filtrelenenAnaDerslers[derssayac].fiyat);

                    if (!kayitsonucu.All(char.IsNumber))
                  
                    {
                        MessageBox.Show(kayitsonucu);
                    }


                }

                derssayac++;
            }


            //  MessageBox.Show("başarılı: " + kayitsonucu);
            varsa_talepBolumu();



        }

        //Change olayı gibi olsa da click olayına tanımla.
        private void cb_talep_CD_CheckedChanged(object sender, EventArgs e)
        {

            CD_PDF_islemi_yap(cb_talep_CD.Checked, "CD");

        }

        private void cb_talep_pdf_CheckedChanged(object sender, EventArgs e)
        {

            CD_PDF_islemi_yap(cb_talep_pdf.Checked, "PDF");

        }

        private void CD_PDF_islemi_yap(bool eklensinmi, string urunadi)
        {

            foreach (FiltrelenenEkUrunler urun in filtrelenenEkUrunler)
            {


                    if (urun.urunadi == urunadi)
                    {

                         if (eklensinmi)
                         {


                            string kayitsonucu = vtislemleri.ekle_ek_urunler(BirOgt.oid, urun.urunkodu, urun.fiyat);

                            if (kayitsonucu.All(char.IsNumber))
                            {

                                //  MessageBox.Show("başarılı: " + kayitsonucu);
                                varsa_talepBolumu();

                            }
                            else
                            {
                                MessageBox.Show(kayitsonucu);
                            }



                        }
                        else
                        {
                        //Silinsin.

                            string kayitsonucu = vtislemleri.sil_ekurunler(BirOgt.oid, urun.urunkodu);

                            if (kayitsonucu == metinler.islembasarili)
                            {

                                //  MessageBox.Show("başarılı: " + kayitsonucu);
                                varsa_talepBolumu();

                            }
                            else
                            {
                                MessageBox.Show(kayitsonucu);
                            }


                        }



                    //Ürünü bulduysak işlem yapıp çıkıyoruz.
                    return;

                    }



            }


        }



        private void linklbl_talep_secimiekle_anadersler_gunluk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (cb_talep_anadersler_gunluk.SelectedIndex < 0)
            {
                MessageBox.Show("Ders seçmelisiniz.");
                return;
            }


            g_anaders_ekle_secim();

        }



        private void g_anaders_ekle_secim()
        {



            string kayitsonucu = vtislemleri.ekle_g_anaders(BirOgt.oid, filtrelenenGunlukPlaniOlanDerslers[cb_talep_anadersler_gunluk.SelectedIndex].gunlukdersid, filtrelenenGunlukPlaniOlanDerslers[cb_talep_anadersler_gunluk.SelectedIndex].fiyat);

            if (kayitsonucu.All(char.IsNumber))
            {

                //  MessageBox.Show("başarılı: " + kayitsonucu);
                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }


        }





        private void linklbl_talep_tumanadersleriekle_gunluk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            g_anaders_ekle_sinif_duzeyi_tum_dersler();


        }



        private void dgv_talep_anadersler_gunluk_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            string dersid = dgv_talep_anadersler_gunluk.Rows[e.RowIndex].Cells[metinler.neyebakalim_g_anaders_urunid_adi].Value.ToString();

            //  MessageBox.Show(dersid);

            anaders_gunluk_plan_talep_sil(dersid);

        }



        private void anaders_gunluk_plan_talep_sil(string dersid)
        {

            if (dersid.Length < 1)
            {
                return;
            }

            string sonuc = vtislemleri.sil_g_anaders(BirOgt.oid, int.Parse(dersid));

            if (sonuc == metinler.islembasarili)
            {

                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(dersid + " silinemedi.");
            }


        }



        private void g_anaders_ekle_sinif_duzeyi_tum_dersler()
        {


            //Döngü ile sınıf düzeylerine bakalım ve seçili sınıf düzeyine uygun olan ana dersleri ekleyelim.

            int derssayac = 0;

            foreach (FiltrelenenGunlukPlaniOlanDersler drs in filtrelenenGunlukPlaniOlanDerslers)
            {

                if (drs.dersadi.Substring(0, BirOgt.sinifi.ToString().Length) == BirOgt.sinifi.ToString())
                {

                    string kayitsonucu = vtislemleri.ekle_g_anaders(BirOgt.oid, filtrelenenGunlukPlaniOlanDerslers[derssayac].gunlukdersid, filtrelenenGunlukPlaniOlanDerslers[derssayac].fiyat);

                    if (!kayitsonucu.All(char.IsNumber))

                    {
                        MessageBox.Show(kayitsonucu);
                    }


                }

                derssayac++;
            }


            //  MessageBox.Show("başarılı: " + kayitsonucu);
            varsa_talepBolumu();



        }






        //serbest etkinliklerle ilgili işlemler.


        private void linklbl_talep_secimiekle_serbest_yillik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cb_talep_serbestdersler_yillik.SelectedIndex < 0)
            {
                MessageBox.Show("Ders seçmelisiniz.");
                return;
            }


            serbest_etkinlik_ekle_secim();
        }



        private void serbest_etkinlik_ekle_secim()
        {



            string kayitsonucu = vtislemleri.ekle_s_ders(BirOgt.oid, filtrelenenSerbestEtkinlikDerslers[cb_talep_serbestdersler_yillik.SelectedIndex].serbestdersid);

            if (kayitsonucu.All(char.IsNumber))
            {

                //  MessageBox.Show("başarılı: " + kayitsonucu);
                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }


        }

        private void linklbl_talep_tumdersleriekle_serbest_yillik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            serbest_ders_ekle_tum_dersler();

        }


        private void serbest_ders_ekle_tum_dersler()
        {


            //Döngü ile sınıf düzeylerine bakalım ve seçili sınıf düzeyine uygun olan ana dersleri ekleyelim.

            int derssayac = 0;

            foreach (FiltrelenenSerbestEtkinlikDersleri drs in filtrelenenSerbestEtkinlikDerslers)
            {

                

                    string kayitsonucu = vtislemleri.ekle_s_ders(BirOgt.oid, filtrelenenSerbestEtkinlikDerslers[derssayac].serbestdersid);

                    if (!kayitsonucu.All(char.IsNumber))

                    {
                        MessageBox.Show(kayitsonucu);
                    }


                derssayac++;
            }


            //  MessageBox.Show("başarılı: " + kayitsonucu);
            varsa_talepBolumu();



        }










        private void dgv_talep_serbestdersler_doubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }


            string dersid = dgv_talep_serbestdersler_yillik.Rows[e.RowIndex].Cells[metinler.neyebakalim_s_ders_urunid_adi].Value.ToString();

            //  MessageBox.Show(dersid);

            serbest_dersler_talep_sil(dersid);

        }



        private void serbest_dersler_talep_sil(string dersid)
        {

            if (dersid.Length < 1)
            {
                return;
            }

            string sonuc = vtislemleri.sil_s_anaders(BirOgt.oid, int.Parse(dersid));

            if (sonuc == metinler.islembasarili)
            {

                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(dersid + " silinemedi.");
            }


        }

        private void linklbl_talep_defterekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cb_talep_defter.SelectedIndex < 0)
            {
                MessageBox.Show("Ders seçmelisiniz.");
                return;
            }


            defter_ekle_secim();

        
        }


        
           



        private void defter_ekle_secim()
        {



            string kayitsonucu = vtislemleri.ekle_defter(BirOgt.oid, filtrelenenDefterlers[cb_talep_defter.SelectedIndex].defterkodu, filtrelenenDefterlers[cb_talep_defter.SelectedIndex].fiyat);

            if (kayitsonucu.All(char.IsNumber))
            {

                //  MessageBox.Show("başarılı: " + kayitsonucu);
                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }


        }





        private void dgv_talep_defter_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string dersid = dgv_talep_defterler.Rows[e.RowIndex].Cells[metinler.neyebakalim_defter_urunid_adi].Value.ToString();

            //  MessageBox.Show(dersid);

            defter_talep_sil(dersid);

        }



        private void defter_talep_sil(string dersid)
        {

            if (dersid.Length < 1)
            {
                return;
            }

            string sonuc = vtislemleri.sil_defter(BirOgt.oid, int.Parse(dersid));

            if (sonuc == metinler.islembasarili)
            {

                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(dersid + " silinemedi.");
            }


        }

        private void linklbl_talep_kulup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            kulup_talebi_kaydet();
        }


        private void kulup_talebi_kaydet()
        {

            int indeks = cb_talep_sosyalkulupadi.SelectedIndex;

            //  MessageBox.Show(filtrelenenSosyalKuluplers[indeks].kulupadi + " " + filtrelenenSosyalKuluplers[indeks].kulupkimliktablo);


            string kayitsonucu = vtislemleri.ekle_sosyalkulup(BirOgt.oid, filtrelenenSosyalKuluplers[indeks].kulupkodu, tb_talep_sosyalkulupikinciogretmen.Text, filtrelenenSosyalKuluplers[indeks].fiyat);

            if (kayitsonucu.All(char.IsNumber))
            {

                //  MessageBox.Show("başarılı: " + kayitsonucu);
                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }



        }

        private void linklbl_talep_kulup_sil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BirOgt == null || tb_bilgi_adisoyadi.Text.Trim() == "")
            {
              
                return;
            }

            sosyal_kulup_talebi_sil();
        }

        private void sosyal_kulup_talebi_sil()
        {

            string islemsonucu = vtislemleri.sil_sosyalkulup(BirOgt.oid);

            if (islemsonucu == metinler.islembasarili)
            {
                cb_talep_sosyalkulupadi.SelectedIndex = -1;
                tb_talep_sosyalkulupikinciogretmen.Text = "";

                varsa_talepBolumu();

            } else
            {

                MessageBox.Show(islemsonucu);

            }

        }

        private void linklbl_talep_digerzumreogretmeniekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            diger_zumre_ogretmeni_ekle();

        }


        private void diger_zumre_ogretmeni_ekle()
        {

            if (BirOgt == null || tb_bilgi_adisoyadi.Text.Trim() == "")
            {
                MessageBox.Show("Bir müşteri oluşturun veya seçin.");
                return;
            }



            string kayitsonucu = vtislemleri.ekle_digerzumreogretmeni(BirOgt.oid,  tb_talep_digerzumreogretmenleri.Text);

            if (kayitsonucu.All(char.IsNumber))
            {

                //  MessageBox.Show("başarılı: " + kayitsonucu);
                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }



        }




        private void dgv_talep_digerzumreogretmenleri_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string dersid = dgv_talep_digerzumreogretmenleri.Rows[e.RowIndex].Cells["ogretmenadi"].Value.ToString();

            //  MessageBox.Show(dersid);

            digerzumreogretmenleri_talep_sil(dersid);

        }



        private void digerzumreogretmenleri_talep_sil(string ogretmenadi)
        {

            if (ogretmenadi.Length < 1)
            {
                return;
            }

            string sonuc = vtislemleri.sil_digerzumreogretmeni(BirOgt.oid, ogretmenadi);

            if (sonuc == metinler.islembasarili)
            {

                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(ogretmenadi + " silinemedi.");
            }


        }












        //Sınıf sonu.
    }


}
