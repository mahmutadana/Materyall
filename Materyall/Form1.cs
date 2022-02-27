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

        //Filtrelenen verilerle ilgili id vs bilgileri tutan sınıflar.
        List<FiltrelenenAnaDersler> filtrelenenAnaDerslers = new List<FiltrelenenAnaDersler>();
        List<FiltrelenenSosyalKulupler> filtrelenenSosyalKuluplers = new List<FiltrelenenSosyalKulupler>();



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

            _ = varsayilanDegerleriGuncelleAsync();


        }


        private async Task varsayilanDegerleriGuncelleAsync()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.
           
            //Bu veriler daha önce girişi yapılmış kayıtlardan alındı. (tlp_ogretmenverileri_tbl)
            await varsayilanDegerler_1_yil();
            await varsayilanDegerler_2_brans();
            await varsayilanDegerler_3_iller(); //Bu sis_iller_tbl tablosundan alıyor.
            await varsayilanDegerler_4_mudurunvani();
            await varsayilanDegerler_5_siniflar();

            //Sosyal kulüpleri kendi tablosundan alacağız.
            await varsayilanDegerler_6_sosyalkulupler();







        }


        //1. eğitim öğretim yılı.
        private Task varsayilanDegerler_1_yil()
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

            return Task.CompletedTask;
        }

        private Task varsayilanDegerler_2_brans()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_bransi.Items.Clear();

            string[] veriler = vtislemleri.filtre_branslar();

            foreach (string s in veriler)
            {
                
                cb_bilgi_bransi.Items.Add(s);
            }

            return Task.CompletedTask;
        }

        private Task varsayilanDegerler_3_iller()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_ili.Items.Clear();

            string[] veriler = vtislemleri.filtre_iller();

            foreach (string s in veriler)
            {
                
                cb_bilgi_ili.Items.Add(s);
            }

            return Task.CompletedTask;
        }

        private Task varsayilanDegerler_3_1_ilceler()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_ilcesi.Items.Clear();

            string[] veriler = vtislemleri.filtre_ilceler(cb_bilgi_ili.Text);

            foreach (string s in veriler)
            {

                cb_bilgi_ilcesi.Items.Add(s);
            }

            return Task.CompletedTask;
        }

        private Task varsayilanDegerler_4_mudurunvani()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_mudurunvani.Items.Clear();

            string[] veriler = vtislemleri.filtre_mudurunvanlar();

            foreach (string s in veriler)
            {

                cb_bilgi_mudurunvani.Items.Add(s);
            }

            return Task.CompletedTask;
        }

        private Task varsayilanDegerler_5_siniflar()
        {
            //Yıl, il, ilçe, müdür adı, unvanlar, nönet yerleri vs için distinc güncellemesi yaparak açılan kutulara veri atacağız.

            //Eğitim öğretim yılı.

            cb_bilgi_sinifi.Items.Clear();

            string[] veriler = vtislemleri.filtre_siniflar();

            foreach (string s in veriler)
            {

                cb_bilgi_sinifi.Items.Add(s);
            }

            return Task.CompletedTask;
        }

        private Task varsayilanDegerler_6_sosyalkulupler()
        {
           
            cb_talep_sosyalkulupadi.Items.Clear();

           // string[] veriler = vtislemleri.filtre_sosyalkulupler();

            filtrelenenSosyalKuluplers = vtislemleri.filtre_sosyalkulupler();


            foreach (FiltrelenenSosyalKulupler s in filtrelenenSosyalKuluplers)
            {

                cb_talep_sosyalkulupadi.Items.Add(s.kulupadi);
            }

            return Task.CompletedTask;
        }




        //Tüm dersleri listeleyelim.
        private Task varsayilanDegerler_tumdersler()
        {

            cb_talep_anadersler_yillik.Items.Clear();

            string[] veriler = vtislemleri.filtre_tumdersler(cb_yili.Text, cb_bilgi_ili.Text);

            foreach (string s in veriler)
            {

                cb_talep_anadersler_yillik.Items.Add(s);
            }

            return Task.CompletedTask;
        }








        private void bt_yenikayit_Click(object sender, EventArgs e)
        {
            yeniKayitYap();
        }



        private void yeniKayitYap()
        {

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
           


            string kayitsonucu = vtislemleri.yeniKayit(ogrblg);

            if (kayitsonucu.All(char.IsNumber))
            {
                tb_bilgi_musterino.Text = kayitsonucu;

            } else
            {
                MessageBox.Show(vtislemleri.yeniKayit(ogrblg));
            }




            //Öğretmen sınıfı genel değişkenimize atadık.

            //Bayi bilgilerini tanımlıyoruz.
            ogrblg.bayibilgileri = BirBayi;

            BirOgt = ogrblg;


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
            cb_bilgi_sinifi.Text = ogrblg.sinifi.ToString();
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
            musteriBilgisiGetir();
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


        private void bayidundanBayiBilgileriniGetir()
        {
            
            BirBayi = vtislemleri.bayiaBilgileriniGetir_bayikodundan(tb_bilgi_bayikodu.Text);

            cb_bilgi_bayiadi.Text = BirBayi.bayiadi;

        }

        private void tb_bilgi_bayikodu_TextChanged(object sender, EventArgs e)
        {

            bayidundanBayiBilgileriniGetir();

        }

        private void cb_bilgi_ili_SelectedIndexChanged(object sender, EventArgs e)
        {

            varsayilanDegerler_3_1_ilceler();

            varsayilanDegerler_tumdersler();

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




        //Sınıf sonu.
    }






}
