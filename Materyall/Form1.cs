﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;

namespace Materyall
{
    public partial class Form1 : Form
    {

        string ikaz_metni;

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

        List<FiltrelenenEkUrunler> filtrelenenEkUrunlers = new List<FiltrelenenEkUrunler>();

        List<FiltrelenenNobetYeriSablonlari> filtrelenenNobetyerisablonlars = new List<FiltrelenenNobetYeriSablonlari>();

        List<OgrenciListesiSnf> talepOgrencilistesis = new List<OgrenciListesiSnf>();




        Vtislemleri vtislemleri = new Vtislemleri();
        Metinler metinler = new Metinler();
        YardimciSnf yrdsnf = new YardimciSnf();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          //  sekmeRengiAyarla();

            varsayilanDegerleriGuncelleAsync();

            /*
             * Muhasebe sekmesinin rengini kırmızı yapmak için kullanmak istedik ama görünrü kötüleşti. Vazgeçtik.
            dgv_talep_anadersler_yillik.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_anadersler_gunluk.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_serbestdersler_yillik.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_defterler.Font = linklbl_talep_kulup_sil.Font;
            dgv_talep_digerzumreogretmenleri.Font = linklbl_talep_kulup_sil.Font;
            */

        }

        /*
        private void sekmeRengiAyarla()
        {

            SetTabHeader(tab_planbasim, Form1.DefaultBackColor);
            SetTabHeader(tab_defterbasim, Form1.DefaultBackColor);
            SetTabHeader(tab_talepgiris, Form1.DefaultBackColor);
            SetTabHeader(tab_hizlitalep, Form1.DefaultBackColor);
            SetTabHeader(tab_digerislemler, Form1.DefaultBackColor);
            SetTabHeader(tab_muhasebe, Form1.DefaultBackColor);



           this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
           this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);

        }
        */
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            tabControl1.Invalidate();
        }


        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            using (Brush br = new SolidBrush(TabColors[tabControl1.TabPages[e.Index]]))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

             //   Rectangle rect = e.Bounds;
             //   rect.Offset(0, 1);
             //   rect.Inflate(0, -1);
              //  e.Graphics.DrawRectangle(Pens.DarkGray, rect);
             //   e.DrawFocusRectangle();
            }
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

            //İkazı sıfırlayalım.
            ikaz_metni = "İkaz";
            btn_ikaz_lambasi.BackColor = DefaultBackColor;
            toolTip1.SetToolTip(btn_ikaz_lambasi, ikaz_metni);

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

                varsayilanNobetYeriSablonlari();

                varsayilanDegerler_Odemeturleri();


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

            foreach (FiltrelenenEkUrunler urun in filtrelenenEkUrunlers)
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



            //Nöbet yeri şablon bilgisine bakıyoruz.
            string talepedilen_nobetyeri_sablonu_adi = vtislemleri.talepedilennobetyerisablonunugetir(BirOgt.oid);
            dgv_talep_nobetyerleri.DataSource = null;
            int nbtsblsayac = 0;
            foreach (FiltrelenenNobetYeriSablonlari s in filtrelenenNobetyerisablonlars)
            {

                if (s.nobetyerisablonadi == talepedilen_nobetyeri_sablonu_adi)
                {
                    cb_talep_nobetyerisablon.SelectedIndex = nbtsblsayac;
                }

                nbtsblsayac++;

            }


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






            //Öğrenci Listesi gridde değil. Burada alınıp işlem yapılacak.
            talepOgrencilistesis = vtislemleri.getirOgrenciListesi(BirOgt.oid);

            //Öğrenci bilgilerini aralarına TAB koyarak ilgili textbox içinde satır satır göstereceğiz.
            tb_ogrencilistesi_multiline.Text = "";
            StringBuilder sb = new StringBuilder();
            foreach (OgrenciListesiSnf s in talepOgrencilistesis)
            {
               sb.Append(s.numara).Append("\t").Append(s.adisoyadi);
                sb.AppendLine();

            }

            tb_ogrencilistesi_multiline.Text = sb.ToString();



            //Muhasebe bölümünü ayrı bir yöntem içinde göstereceğiz.
            muhasebe_durumunu_goster();

        }



        private void muhasebe_durumunu_goster()
        {

            MuhasebeGenelDurumSnf geneldurum = vtislemleri.getirMuhasebeGenelDurum(BirOgt.oid);

            tb_muhasebe_toplam_borc.Text = geneldurum.toplamborc.ToString();
            tb_muhasebe_toplam_odeme.Text = geneldurum.toplamodeme.ToString();
            tb_muhasebe_toplam_bakiye.Text = geneldurum.toplambakiye.ToString();


            //Aynı verileri hesap özeti bölümünde de gösterelim.

            tb_hesapozeti_toplamborc.Text = tb_muhasebe_toplam_borc.Text;
            tb_hesapozeti_toplamodeme.Text = tb_muhasebe_toplam_odeme.Text;
            tb_hesapozeti_toplambakiye.Text = tb_muhasebe_toplam_bakiye.Text;




            if (tb_muhasebe_toplam_bakiye.Text != "0")
            {
                //Bunu görüntülerken sıfırlıyoruz. Birden fazla ikazı aynı yerde gösterebiliriz.
                ikaz_metni += "\n" + "Bakiye: " + tb_muhasebe_toplam_bakiye.Text;
               btn_ikaz_lambasi.BackColor = Color.Red;
               toolTip1.SetToolTip(btn_ikaz_lambasi,ikaz_metni);

            }




            //Ödemelerin DGV'si. (Data Grid View)

            //Yapılan tüm ödemeleri göster.
            dgv_muhasebe_odemeler.DataSource = vtislemleri.dgv_icin_muhasebe_tum_odemeleri_getir(BirOgt.oid);

            //Borçlanmaları göster.
            dgv_muhasebe_borclanmalar.DataSource = vtislemleri.dgv_icin_muhasebe_tum_borclanmalari_getir(BirOgt.oid);










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

            filtrelenenEkUrunlers = vtislemleri.filtre_ekurunler(BirOgt.yili, BirOgt.bayibilgileri.ucretgrubu.ToString());


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



        private void varsayilanNobetYeriSablonlari()
        {

            //Ek ürünlerin bilgilerini bellekte tutuyoruz.

            filtrelenenNobetyerisablonlars = vtislemleri.filtre_nobetyerisablonlari();

            cb_talep_nobetyerisablon.Items.Clear();

            foreach (FiltrelenenNobetYeriSablonlari s in filtrelenenNobetyerisablonlars)
            {

                cb_talep_nobetyerisablon.Items.Add(s.nobetyerisablonadi);
            }


        }




        private void varsayilanDegerler_Odemeturleri()
        {
            
            //Eğitim öğretim yılı.

            cb_muhasebe_odemeal_odeme_turu.Items.Clear();

            string[] veriler = vtislemleri.filtre_odemeturleri();

            foreach (string s in veriler)
            {

                cb_muhasebe_odemeal_odeme_turu.Items.Add(s);
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

            foreach (FiltrelenenEkUrunler urun in filtrelenenEkUrunlers)
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

        private void linklbl_talep_nobetyeri_ekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {




            if (cb_talep_nobetyerisablon.SelectedIndex < 0)
            {
                dgv_talep_nobetyerleri.DataSource = null;
                // MessageBox.Show("Nöbet yeri şablonu seçmelisiniz.");
                return;
            }

            nobetSablonu_talep_kaydet();
        }

        private void nobetSablonu_talep_kaydet()
        {


            string kayitsonucu = vtislemleri.ekle_nobetyerisablonu(BirOgt.oid, filtrelenenNobetyerisablonlars[cb_talep_nobetyerisablon.SelectedIndex].nobetyerisablonadi);

            if (kayitsonucu.All(char.IsNumber))
            {

                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(kayitsonucu);
            }



        }




        private void nobetyeriSablonu_talep_sil()
        {

            if (BirOgt == null || BirOgt.oid < 1)
            {
                return;
            }


            cb_talep_nobetyerisablon.SelectedIndex = -1;


            string sonuc = vtislemleri.sil_nobetyerisablonu(BirOgt.oid);

            if (sonuc == metinler.islembasarili)
            {

                varsa_talepBolumu();

            }
            else
            {
                MessageBox.Show(" silinemedi.");
            }


        }

        private void cb_talep_nobetyerisablon_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_talep_nobetyerisablon.SelectedIndex < 0)
            {
                dgv_talep_nobetyerleri.DataSource = null;
                // MessageBox.Show("Nöbet yeri şablonu seçmelisiniz.");
                return;
            }

            int indeks = cb_talep_nobetyerisablon.SelectedIndex;


            dgv_talep_nobetyerleri.DataSource = vtislemleri.dgv_icin_nobetyerisablondetayi_getir(filtrelenenNobetyerisablonlars[indeks].nobetyerisablonadi);


        }

        private void linklbl_talep_nobetyeri_sil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nobetyeriSablonu_talep_sil();
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void linklbl_sablon_nobetyeri_sablonukaydet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yeni_bir_nobet_sablonu_olustur();
        }

        private void yeni_bir_nobet_sablonu_olustur()
        {

            //Şablon adı daha önceden var mı diye bakacağız. Şablon isminin olması zorunlu.

            if (tb_sablon_nobetyeri_yeni_sablonadi.Text.Trim().Length < 1)
            {
                MessageBox.Show("Bu nöbet düzeni için bir şablon adı girmelisiniz.");
                return;
            }

            //Birinci sırada şablon adı olacak.
            string[] sablonbilgisi = new string[13];

            sablonbilgisi[0] = tb_sablon_nobetyeri_yeni_sablonadi.Text;
            sablonbilgisi[1] = tb_sablon_nobetyeri_1.Text;
            sablonbilgisi[2] = tb_sablon_nobetyeri_2.Text;
            sablonbilgisi[3] = tb_sablon_nobetyeri_3.Text;
            sablonbilgisi[4] = tb_sablon_nobetyeri_4.Text;
            sablonbilgisi[5] = tb_sablon_nobetyeri_5.Text;
            sablonbilgisi[6] = tb_sablon_nobetyeri_6.Text;
            sablonbilgisi[7] = tb_sablon_nobetyeri_7.Text;
            sablonbilgisi[8] = tb_sablon_nobetyeri_8.Text;
            sablonbilgisi[9] = tb_sablon_nobetyeri_9.Text;
            sablonbilgisi[10] = tb_sablon_nobetyeri_10.Text;
            sablonbilgisi[11] = tb_sablon_nobetyeri_11.Text;
            sablonbilgisi [12] = tb_sablon_nobetyeri_12.Text;
                

            string kayitsonucu = vtislemleri.ekle_yeni_nobet_sablonu_olustur(sablonbilgisi);

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



        private void linklbl_ogrencilistesikaydet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrenciListesiKontrolveAktarma();

            ogrencilistesikaydedildiyaz();
        }


        private async void ogrencilistesikaydedildiyaz()
        {
            //Kaydedildi yazısı sürekli ekranda kalmayacak.
            lbl_ogrencilistesikaydedildi.Text = "Kaydedildi";

            await Task.Delay(TimeSpan.FromSeconds(1));

            lbl_ogrencilistesikaydedildi.Text = "";

        }

        private void ogrenciListesiKontrolveAktarma()
        {

            //Öncelikle öğretmene kayıtlı tüm öğrencileri siliyoruz.
            vtislemleri.sil_ogrencilistesi(BirOgt.oid);

            for (int i = 0;i < tb_ogrencilistesi_multiline.Lines.Length; i++)
            {
                string[] bilgi = tb_ogrencilistesi_multiline.Lines[i].Split('\t');

                if (bilgi.Length == 2)
                {

                    //  MessageBox.Show("Adı: " + bilgi[1] + " ve numarası: " + bilgi[0]);

                    vtislemleri.ekle_ogrencilistesi(BirOgt.oid, int.Parse(bilgi[0]), bilgi[1]);

                }

               

            }

            varsa_talepBolumu();

        }

        private void btn_bilgi_ogrencilistesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(metinler.bilgi_metni_ogrenci_listesi);
        }

        private void tb_muhasebe_odemeal_odeme_tarihi_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            tb_muhasebe_odemeal_odeme_tarihi.Text = DateTime.Now.ToString();

        }

        private void linklbl_muhasebe_odemeal_odeme_kaydet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Odeme_Kaydet();
        }

        private void Odeme_Kaydet()
        {

            //Virgül girilmişse onu noktaya çevirelim.
            string odenentutarnoktali = tb_muhasebe_odemeal_odenen_miktar.Text.Replace(",", ".");


            string kayitsonucu = vtislemleri.ekle_odeme(BirOgt.oid, odenentutarnoktali, cb_muhasebe_odemeal_odeme_turu.Text, tb_muhasebe_odemeal_odeme_tarihi.Text, tb_muhasebe_odemeal_aciklama.Text);


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

        private void btn_muhasebe_miktar_uyari_bilgi_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Binlik ayırıcısı KULLANMAYIN. Ondalık değerler için virgül veya nokta kullanın.");

        }





















        //Sınıf sonu.
    }


}
