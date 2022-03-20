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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

             vars_talepBolumu();





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


        private void vars_talepBolumu()
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

                lbl_bilgi.Text = metinler.ogretmenverisivar;

            } else
            {

                lbl_bilgi.Text = metinler.ogretmenverisiyok;

            }


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



            vars_talepBolumu();

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

            vars_talepBolumu();




        }



        private void cb_talep_sosyalkulupadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SosyalKulupSecildi();
        }


        private void SosyalKulupSecildi ()
        {

            int indeks = cb_talep_sosyalkulupadi.SelectedIndex;

            MessageBox.Show(filtrelenenSosyalKuluplers[indeks].kulupadi + " " + filtrelenenSosyalKuluplers[indeks].kulupkimliktablo);


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


       




        //Sınıf sonu.
    }






}
