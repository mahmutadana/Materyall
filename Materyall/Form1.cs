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
using System.Text;
using System.Data.OleDb;

using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Application = Microsoft.Office.Interop.Word.Application;
using System.Diagnostics;

namespace Materyall
{


    public partial class Form1 : Form
    {

        string ikaz_metni;

        VarsayilanYilBayivbBossaSnf varsayilanbossa = new VarsayilanYilBayivbBossaSnf();


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

        List<FiltrelenenDefterler> filtrelenenDefterlers_sadeceolanlar = new List<FiltrelenenDefterler>();

        List<FiltrelenenEkUrunler> filtrelenenEkUrunlers = new List<FiltrelenenEkUrunler>();

        List<FiltrelenenNobetYeriSablonlari> filtrelenenNobetyerisablonlars = new List<FiltrelenenNobetYeriSablonlari>();

        List<OgrenciListesiSnf> talepOgrencilistesis = new List<OgrenciListesiSnf>();


        //Excelden veri alırken hangi bilginin hangi sütunda olduğuna dair bilgileri tutacağız. İleride değişirse sadece VT'de değişiklik yapmak yeterli olsun.
        ExcelSutunEslestir_Bilgi_Snf excelbilgisutunlari = new ExcelSutunEslestir_Bilgi_Snf();


        Vtislemleri vtislemleri = new Vtislemleri();
        Metinler metinler = new Metinler();
        YardimciSnf yrdsnf = new YardimciSnf();
        ExcelSnf excelSnf = new ExcelSnf();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            YardimciSnf.TB_LOG_KAYITLARI = tb_logkayitlari;

            yrdsnf.log_yaz("Program başlatıldı.");

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


            SunucuSnf sunucuSnf = new SunucuSnf();

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

            bossa_varsayilanlarYilBayivs();

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
                //Şimdilik 1 ürün. Daha sonra eklenirse ekürünler buraya eklenecek.

                if (urun.urunadi == "PDF")
                {

                    bool pdfdurumu = vtislemleri.ek_urun_talepEdilmismi(BirOgt.oid, urun.urunkodu);
                    cb_talep_pdf.Checked = pdfdurumu;
                    BirOgt.pdf_istiyor = pdfdurumu;

                }
                else if(urun.urunadi == "DEFTER")
                {

                    bool pdfdurumu = vtislemleri.ek_urun_talepEdilmismi(BirOgt.oid, urun.urunkodu);
                    cb_talep_sinifdefteri.Checked = pdfdurumu;
                    BirOgt.defter_istiyor = pdfdurumu;

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
                    break;
                }

                nbtsblsayac++;

            }


            //Yıllık plan ana dersleri göster.
            dgv_talep_anadersler_yillik.DataSource = vtislemleri.dgv_icin_y_anaderleri_getir(BirOgt.oid, BirOgt.yili);
            dgv_talep_yillikplanlar_baski.DataSource = dgv_talep_anadersler_yillik.DataSource;

            //Günlük plan ana dersleri göster.
            dgv_talep_anadersler_gunluk.DataSource = vtislemleri.dgv_icin_g_anaderleri_getir(BirOgt.oid, BirOgt.yili);
            dgv_talep_gunlukplanlar_baski.DataSource = dgv_talep_anadersler_gunluk.DataSource;



            //Serbest etkinlik derslerini göster.
            dgv_talep_serbestdersler_yillik.DataSource = vtislemleri.dgv_icin_s_dersleri_getir(BirOgt.oid, BirOgt.yili);


            //Defter taleplerini göster.
            dgv_talep_defterler.DataSource = vtislemleri.dgv_icin_defterleri_getir(BirOgt.oid, BirOgt.yili);

            //Defter taleplerini göster.
            dgv_talep_defterler_baski.DataSource = dgv_talep_defterler.DataSource;

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
                toolTip1.SetToolTip(btn_ikaz_lambasi, ikaz_metni);

            }




            //Ödemelerin DGV'si. (Data Grid View)

            //Yapılan tüm ödemeleri göster.
            dgv_muhasebe_odemeler.DataSource = vtislemleri.dgv_icin_muhasebe_tum_odemeleri_getir(BirOgt.oid);

            //Borçlanmaları göster.
            dgv_muhasebe_borclanmalar.DataSource = vtislemleri.dgv_icin_muhasebe_tum_borclanmalari_getir(BirOgt.oid);










        }


        //0 Yıl ve bayi boş bırakılmışsa oralara yazmak için varsayılan değerleri hafızada tutacağız.
        private void bossa_varsayilanlarYilBayivs()
        {


            varsayilanbossa = vtislemleri.varsayilanlar_bossa();



            

            defter_ve_plan_kayit_konumlarini_yaz();



        }




        private void serbestEtkinliklerdeHangiSiniftaKacSaatDersOldugunuAl()
        {

            //Serbest etkinliklerde hangi sınıfta kaç saat serbest etkinlik dersi olduğu bilgisini de burada tutacağız.
            //Defterde ve belki birçok planda gerekmeyecek. Bu yüzden ilk gerektiğinde verileri okuyacağız.,

           

            if (varsayilanbossa.serbestderssaati_sinif_4 == 0)
            {
               int[] serbestsaatleri = vtislemleri.varsayilanlar_bossa_ek_serbestetkinlilkderssaatleri(BirOgt.yili);

                varsayilanbossa.serbestderssaati_sinif_1 = serbestsaatleri[0];
                varsayilanbossa.serbestderssaati_sinif_2 = serbestsaatleri[1];
                varsayilanbossa.serbestderssaati_sinif_3 = serbestsaatleri[2];
                varsayilanbossa.serbestderssaati_sinif_4 = serbestsaatleri[3];


                //Yine bu komut içinde serbest etkinlikleri listeleyeceğiz. Tabserbestler sekmesindeki dgv'ler içine alacağız.
                //Verileri her seferinde excelden okumak yerine dgv'lerden okuyacağız. Veri alınmışsa zaten o da bir daha okumayacak.

                serbestEtkinlikDersleriniSaatlericinDGVListele();

            }




        }



        private void defter_ve_plan_kayit_konumlarini_yaz()
        {

            tb_varsayilan_yillikplanyolu.Text = varsayilanbossa.yillikplanyolu;
            tb_varsayilan_gunlukplanyolu.Text = varsayilanbossa.gunlukplanyolu;
            tb_varsayilan_plankapakyolu.Text = varsayilanbossa.plankapakyolu;
            tb_varsayilan_kayit_planyolu_pdf.Text = varsayilanbossa.plan_kayit_yolu_pdf;


            tb_varsayilan_defteryolu.Text = varsayilanbossa.defteryolu;
            tb_varsayilan_defterkapakyolu.Text = varsayilanbossa.defterkapakyolu;
            tb_varsayilan_kayit_konumu_pdf.Text = varsayilanbossa.defter_kayit_yolu_pdf;

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
                cb_yil_ara.Items.Add(s);
                cb_yil_ara_defter.Items.Add(s);
                cb_yil_ara_bilgileregore.Items.Add(s);
            }

            //Arama için varsayılanı yazalım.
            cb_yil_ara.Text = varsayilanbossa.yilgorunen;
            cb_yil_ara_defter.Text = varsayilanbossa.yilgorunen;
            cb_yil_ara_bilgileregore.Text = varsayilanbossa.yilgorunen;

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


            if (filtrelenenAnaDerslers == null)
            {
                lbl_bilgi.Text = "Bu eğitim öğretim yılı, şehir için ders grubu oluşturulmamış.";
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
            yeniKayitYapveyaGuncelle(true, false);
        }



        private void yeniKayitYapveyaGuncelle(bool yenikayitmi, bool mukerrereizinverilsinmi)
        {


            //Yıl ve bayi adı kısımları boş ise o zaman varsayılanları yazacağız.
            if (cb_yili.Text == "")
            {

               foreach (string s in cb_yili.Items)
                {

                    if (s == varsayilanbossa.yilgorunen)
                    {
                        cb_yili.Text = s;
                        break;
                    }

                }

            }


            //Eğer bayi seçilmemişse...
            if (tb_bilgi_bayikodu.Text == "")
            {

                foreach (Bayibilgileri s in tum_bayi_bilgileris)
                {

                   if (s.bayikodu == varsayilanbossa.bayikodu)
                    {
                        tb_bilgi_bayikodu.Text = s.bayikodu;
                        break;
                    }
                }

            }




            //Bayi adı kısmında bulunamadı yazıyorsa ona göre uyarı verip işlemi sonlandıracağız.
            if (cb_bilgi_bayiadi.Text == metinler.veribulunamadi)
            {


                MessageBox.Show(tb_bilgi_bayikodu.Text + " kodlu bayi bulunamadı. İşlem yapılamadı. Öğretmen Adı: " + tb_bilgi_adisoyadi);
                return;
            }




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



            OgretmenBilgileriSnf ogrblg = new OgretmenBilgileriSnf();


            ogrblg.yili = cb_yili.Text;


            tb_bilgi_adisoyadi.Text = yrdsnf.ismiduzelt(tb_bilgi_adisoyadi.Text, "isim");
            ogrblg.adisoyadi = tb_bilgi_adisoyadi.Text;




            ogrblg.bransi = cb_bilgi_bransi.Text;

            ogrblg.ili = cb_bilgi_ili.Text;

            cb_bilgi_ilcesi.Text = yrdsnf.ismiduzelt(cb_bilgi_ilcesi.Text, "ilce");

            ogrblg.ilcesi = cb_bilgi_ilcesi.Text;
            ogrblg.kurumkodu = tb_bilgi_okulkodu.Text;
            ogrblg.okuladi = tb_bilgi_okulu.Text;
            ogrblg.sinifi = cb_bilgi_sinifi.Text;
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

                bool mukerrerizinickontrol = mukerrereizinverilsinmi;
                //Eğer şube kısmı sadece üç nokta ise mükerrere izin vereceğiz.
                if (!ogrblg.subesi.Contains(metinler.ucnokta) && !ogrblg.subesi.Contains(metinler.ucnokta_bitisik))
                {
                    mukerrerizinickontrol = false;
                }

                string kayitsonucu = vtislemleri.yeniKayit(ogrblg, mukerrerizinickontrol);

                if (kayitsonucu.All(char.IsNumber))
                {
                    //Kayıt sonucu başarılı ise müşteri numarasına id yazıyoruz, mesaj kutusu göstermiyoruz.
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

                ogrblg.oid = int.Parse(tb_bilgi_musterino.Text);

                string kayitsonucu = vtislemleri.kaydiGuncelle(ogrblg);

                MessageBox.Show(kayitsonucu);


            }







            //Öğretmen sınıfı genel değişkenimize atadık.

            //Bayi bilgilerini tanımlıyoruz.
            ogrblg.bayibilgileri = BirBayi;

            BirOgt = ogrblg;


        }


        // Tüm alanlar doldurulmuş mu diye bakıyoruz.

        private bool tumAlanlarDoldurulmusmu()
        {

            //Telefon, adres ve açıklama zorunlu değil.
            //  || tb_bilgi_telefon.Text == "" || tb_bilgi_eposta.Text == "" || tb_bilgi_adres.Text == "" || tb_bilgi_aciklama.Text == ""


            if (cb_yili.Text == "" || tb_bilgi_adisoyadi.Text == "" || cb_bilgi_bransi.Text == "" || cb_bilgi_ili.Text == "" ||
                 cb_bilgi_ilcesi.Text == "" || tb_bilgi_okulkodu.Text == "" || tb_bilgi_okulu.Text == "" || cb_bilgi_sinifi.Text == "" ||
                 tb_bilgi_subesi.Text == "" || tb_bilgi_muduradi.Text == "" || cb_bilgi_mudurunvani.Text == "" || tb_bilgi_bayikodu.Text == "" )
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

            dgv_talep_anadersler_yillik.DataSource = null;
            dgv_talep_anadersler_gunluk.DataSource = null;
            dgv_talep_serbestdersler_yillik.DataSource = null;
            dgv_talep_nobetyerleri.DataSource = null;
            dgv_talep_defterler.DataSource = null;

            //Baskı ekranı için.
            dgv_talep_defterler_baski.DataSource = null;

            dgv_talep_digerzumreogretmenleri.DataSource = null;


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


          

            if (ogrblg.sinifi != null && ogrblg.sinifi != "")
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
           

            tb_bilgi_bayikodu.Text = ogrblg.bayikodu;

            lbl_bilgi_kayittarihi.Text = ogrblg.kayittarihi;

            //Diğer bağlı sınıflardan bilgiler.
            cb_bilgi_bayiadi.Text = ogrblg.bayibilgileri.bayiadi;


            BirOgt = ogrblg;

            ogretmenlogosu_Goster();

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

            gosterDugmesineBasildi();

        }



        private void gosterDugmesineBasildi()
        {

            yrdsnf.log_yaz("GÖSTER komutu çalıştırıldı. Müşteri No:" + tb_bilgi_musterino.Text);

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
            tb_bilgi_logo.Text = ogretmenLogosuSec();

            ogretmenlogosu_Goster();
        }


        private string ogretmenLogosuSec()
        {

            string dosyaadi = "";

            OpenFileDialog res = new OpenFileDialog();

            //Filter
            res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            res.InitialDirectory = metinler.logo_wordbaglantili_klasor; // @"C:\";

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
                pb_logo.Image = Image.FromFile(metinler.logo_wordbaglantili_klasor + tb_bilgi_logo.Text);

            } else
            {
                pb_logo.Image = null;
            }

            logoyu_wordbaglantilidosya_olarak_kaydet();

        }


        //Logoyu basılacak isimle (logo.png) kaydediyoruz.

       private void logoyu_wordbaglantilidosya_olarak_kaydet()
        {
            //Logo varsa onu ilgili klasöre logo.png olarak kaydediyoruz. Böylece word belgesi güncel isimdeki logoyu gösterecek inşallah.
            //Worde resim eklerken "ekle bağla" seçeneği kullanılacak.


            yrdsnf.logoyuKlasoreKaydet(BirOgt.ogretmenlogo);

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

            varsayilanTalepleilgiliVeriler();

        }


        private void varsayilanTalepleilgiliVeriler()
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
            yeniKayitYapveyaGuncelle(false, false);

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



            DialogResult dialogResult = MessageBox.Show("Onaylayın", "Seçtiğiniz kayıt kalıcı olarak silinecektir. Onaylıyor musunuz?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                anaders_yillik_plan_talep_sil(dersid);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


           

        }





        private void anaders_yillik_plan_talep_sil(string dersid)
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

                if (drs.anadersmi && drs.dersadi.Substring(0, BirOgt.sinifi.ToString().Length) == BirOgt.sinifi.ToString())
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
       

        private void cb_talep_pdf_CheckedChanged(object sender, EventArgs e)
        {

            CD_PDF_islemi_yap(cb_talep_pdf.Checked, "PDF");

        }


        private void cb_talep_defter_CheckedChanged(object sender, EventArgs e)
        {

            CD_PDF_islemi_yap(cb_talep_sinifdefteri.Checked, "DEFTER");

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

            DialogResult dialogResult = MessageBox.Show("Onaylayın", "Seçtiğiniz kayıt kalıcı olarak silinecektir. Onaylıyor musunuz?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                anaders_gunluk_plan_talep_sil(dersid);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


           

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

        private void serbestEtkinlikSecildiAnaDersOlarakEkle()
        {

            //Eğer alt kısımdan herhangi bir seçmeli ders eklenirse ana dersler kısmından SERBEST ETKİNLİK dersini ekleyeceğiz.
            //Daha önce eklenmiş mi diye bakacağız, eklenmemişse ekleyeceğiz.

            string serbestetkinlikdersininadi = metinler.serbestetkinlikdersininadi;


            foreach (DataGridViewRow dr in dgv_talep_anadersler_yillik.Rows)
            {

                if (dr.Cells[0].Value.ToString().Contains(serbestetkinlikdersininadi)){
                    //Bu ders daha önce eklenmiş. İşlem yapmadan çıkalım.
                    return;
                }

            }


            //Döngüden çıktığımıza göre bu ders daha önce eklenmemiş. O zaman ekliyoruz.

            string eklenecekolanders = BirOgt.sinifi + "-" + serbestetkinlikdersininadi;

            for (int i = 0; i < filtrelenenAnaDerslers.Count; i++)
            {

                if (filtrelenenAnaDerslers[i].dersadi.Contains(eklenecekolanders))
                {
  
                    string kayitsonucu = vtislemleri.ekle_y_anaders(BirOgt.oid, filtrelenenAnaDerslers[i].anadersid, filtrelenenAnaDerslers[i].fiyat);

                    if (kayitsonucu.All(char.IsNumber))
                    {
                        //Kayıt başarılı.

                    }
                    else
                    {
                        MessageBox.Show("İşlem tamamlanmadı. Serbest etkinlik ana dersi eklenemedi. Öğretmen: " + BirOgt.adisoyadi + " Hata: " + kayitsonucu);
                        return;
                    }

                    //Bu dersi bulduysak kaydediyoruz ve döngüden çıkıyoruz.
                    break;

                }

            }


        }


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

                //Otomatik ekleme.
                serbestEtkinlikSecildiAnaDersOlarakEkle();

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

            DialogResult dialogResult = MessageBox.Show("Onaylayın", "Seçtiğiniz kayıt kalıcı olarak silinecektir. Onaylıyor musunuz?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                serbest_dersler_talep_sil(dersid);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

           

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

            DialogResult dialogResult = MessageBox.Show("Onaylayın", "Seçtiğiniz kayıt kalıcı olarak silinecektir. Onaylıyor musunuz?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                defter_talep_sil(dersid);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

           

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

            if (BirOgt == null || tb_bilgi_okulu.Text.Trim() == "")
            {
                MessageBox.Show("Bir müşteri oluşturun veya seçin.");
                return;
            }



            string kayitsonucu = vtislemleri.ekle_digerzumreogretmeni(BirOgt.oid, yrdsnf.ismiduzelt(tb_talep_digerzumreogretmenleri.Text,"isim"));

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
            DialogResult dialogResult = MessageBox.Show("Onaylayın", "Seçtiğiniz kayıt kalıcı olarak silinecektir. Onaylıyor musunuz?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                digerzumreogretmenleri_talep_sil(dersid);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            

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
            sablonbilgisi[12] = tb_sablon_nobetyeri_12.Text;


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

            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(1));

            lbl_ogrencilistesikaydedildi.Text = "";

        }

        private void ogrenciListesiKontrolveAktarma()
        {

            //Öncelikle öğretmene kayıtlı tüm öğrencileri siliyoruz.
            vtislemleri.sil_ogrencilistesi(BirOgt.oid);

            for (int i = 0; i < tb_ogrencilistesi_multiline.Lines.Length; i++)
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

        private void btn_taleplerial_excelden_Click(object sender, EventArgs e)
        {

            exceldenHizliTalepAl();
        }


        private void exceldenHizliTalepAl()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*| Excel Dosyası (xlsm) |*.xlsm| Excel Dosyası(xls) |*.xls| Excel Dosyası (xlsx)|*.xlsx";
            ofd.RestoreDirectory = true;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                yrdsnf.log_yaz("Excel hızlı talep. " + ofd.FileName);
                datagridSunucuTalepleri.DataSource = excelSecildiTalepleriGetir(ofd.FileName, "talep");


                if (datagridSunucuTalepleri.Rows.Count > 1)
                {
                    //Veri var, işleme devam edelim.

                    //Başlıkları içeren bilgileri alalım.
                    excelbilgisutunlari = vtislemleri.excelsutunbasliklari_bilgi();

                    lbl_bekleyin.Text = "Verileri kaydediliyor.";

                    verileriVtYeKaydet();

                    lbl_bekleyin.Text = "Tamamlandı. Adet: " + datagridSunucuTalepleri.RowCount;



                }
                else
                {
                    MessageBox.Show("Hiçbir veri yok. İşlem yapılmadı");
                }

            }

        }



        public static System.Data.DataTable excelSecildiTalepleriGetir(string strFileName, string tabloAdi)
        {
           // string Table = "talep";

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFileName + ";Extended Properties=Excel 12.0;");
            conn.Open();
            string strQuery = "SELECT * FROM [" + tabloAdi + "$]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(strQuery, conn);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds);

            } catch(Exception e) {
                    
                MessageBox.Show(e.Message);
            
                return null;
            }
            
           
            
            
            return ds.Tables[0];
        }


        private void excelSecildiTalepleriGoster(string secilentalepexceli)
        {

           ExcelSnf excelSnf = new ExcelSnf();

            excelSnf.excelHizliSiparisAl(secilentalepexceli, datagridSunucuTalepleri);

            //Talepler gridviewe alındı. Şimdi oradan ilgili yerlere yazarak işleme devam edelim.
            //1. Adım: Öğretmen bilgilerini gireceğiz. 2.adım olarak bilgi girişinin hemen sonrasında taleplerini ekleyeceğiz.


            if (datagridSunucuTalepleri.Rows.Count > 1)
            {
                //Veri var, işleme devam edelim.

                //Başlıkları içeren bilgileri alalım.
                excelbilgisutunlari = vtislemleri.excelsutunbasliklari_bilgi();

                lbl_bekleyin.Text = "Verileri kaydediliyor.";

                verileriVtYeKaydet();

                lbl_bekleyin.Text = "Tamamlandı. Adet: " + datagridSunucuTalepleri.RowCount;



            } else
            {
                MessageBox.Show("Hiçbir veri yok. İşlem yapılmadı");
            }


        }


        private void verileriVtYeKaydet()
        {

          //  MessageBox.Show(datagridSunucuTalepleri.Rows.Count.ToString(), "Satır");


            for (int i = 0; i < datagridSunucuTalepleri.Rows.Count; i++)
            {
                DataGridViewRow dr = datagridSunucuTalepleri.Rows[i];

                if (dr.Cells[excelbilgisutunlari.adisoyadi_stn].Value.ToString() != "")
                {
                  

                    //1. Adım- Öğretmen bilgilerini kaydet.

                    int ogretmenKayitID = vtYeKaydet_adim_1(dr);

                    if (ogretmenKayitID > 0)
                    {

                        bool talepkaydisonucu = vtYeKaydet_adim_2(dr);

                        if (!talepkaydisonucu)
                        {
                            string msjmtn = "Öğretmen talepleri kaydedilemedi. Satır: " + i;
                            yrdsnf.log_yaz(msjmtn);
                            MessageBox.Show(msjmtn);
                        }

                       

                    } else
                    {
                        string msjmtn = "Öğretmen talepleri kaydedilemedi. Satır: " + i;
                        yrdsnf.log_yaz(msjmtn);
                        MessageBox.Show(msjmtn);
                    }

                    //Denemek için tek kayıt ile yerlerine yazıp görme işlemi yapıyoruz. sonra çıkıyoruz.
                   // return;


                }
            }




        }


        //Bu bize yeni kaydolan öğretmenin kimlikno'sunu döndürecek ve o kayıt ile sipariş taleplerini gireceğiz.
        private int vtYeKaydet_adim_1(DataGridViewRow dr)
        {
            //Excelden alınan verilere göre bilgilerin hangi sütunlardan alınacağına VT'den bakacağız. (Sayı olarak) ilk sütun 1 gireceğiz, kodlarda -1 yaparız.

            //Eğer sınıf alanında 1-2-3 gibi bir giriş varsa sadece birincisini alacağız ama dersleri tüm sınıflara göre atayacağız. Döngü oradaki sınıf sayısı olacak.

            tb_bilgi_adisoyadi.Text = yrdsnf.ismiduzelt(dr.Cells[excelbilgisutunlari.adisoyadi_stn - 1].Value.ToString(), "isim");
           
            cb_bilgi_bransi.Text = dr.Cells[excelbilgisutunlari.bransgorevi_stn - 1].Value.ToString();
            cb_bilgi_ili.Text = dr.Cells[excelbilgisutunlari.il_stn - 1].Value.ToString();
            cb_bilgi_ilcesi.Text = dr.Cells[excelbilgisutunlari.ilce_stn - 1].Value.ToString();


            tb_bilgi_okulkodu.Text = dr.Cells[excelbilgisutunlari.okulkodu_stn - 1].Value.ToString();
            tb_bilgi_okulu.Text = dr.Cells[excelbilgisutunlari.okuladi_stn - 1].Value.ToString();

            //Sınıfı burada olduğu gibi alıyoruz.
            cb_bilgi_sinifi.Text = dr.Cells[excelbilgisutunlari.sinif_stn - 1].Value.ToString();
            
            tb_bilgi_subesi.Text = dr.Cells[excelbilgisutunlari.sube_stn - 1].Value.ToString();

            tb_bilgi_muduradi.Text = yrdsnf.ismiduzelt(dr.Cells[excelbilgisutunlari.muduradi_stn - 1].Value.ToString(), "isim");
            cb_bilgi_mudurunvani.Text = dr.Cells[excelbilgisutunlari.mudurunvani_stn - 1].Value.ToString();

            tb_bilgi_telefon.Text = dr.Cells[excelbilgisutunlari.telefon_stn - 1].Value.ToString();
            tb_bilgi_eposta.Text = dr.Cells[excelbilgisutunlari.eposta_stn - 1].Value.ToString();

            //Excelden adres bilgis gelmiyor.
            //  tb_bilgi_adres.Text = dr.Cells[excelbilgisutunlari.aciklama_stn - 1].Value.ToString();

            tb_bilgi_aciklama.Text = dr.Cells[excelbilgisutunlari.aciklama_stn - 1].Value.ToString();


           
            tb_bilgi_bayikodu.Text = dr.Cells[excelbilgisutunlari.bayikodu_stn - 1].Value.ToString();
            //Bayi adı otomatik gelecek inşallah.
           // bayikodundanBayiBilgileriniGetir();


            //Öğretmen bilgisi kaydedelim. //Bilgileri forma yazmıştık, bilgileri oradan okutup kaydettiyoruz.
            yeniKayitYapveyaGuncelle(true, false);

            //Dersleri vs getirelim. (ile, bayiye göre...)
            varsayilanTalepleilgiliVeriler();

            //Yeni kayıt soununda oluşan müşteri numarasını döndürüyoruz.
            return int.Parse(tb_bilgi_musterino.Text);
        }


        private bool vtYeKaydet_adim_2(DataGridViewRow dr)
        {
            //Eğer sınıf alanında 1-2-3 gibi bir giriş varsa sadece birincisini alacağız ama dersleri tüm sınıflara göre atayacağız. Döngü oradaki sınıf sayısı olacak.

            //Yıllıkların başında Yıllık veya Y yazıyor. Günlüklerin başında da Günlük veya G. Ona göre işlem yapacağız.

            //Yıllık plan sütun başlangıç 15-29 arası 14 sütun. Bunlar excel sütunları, yani burada -1 kullanmak gerekir.
            int yillik_ders_ilk = 15;
            int yillik_ders_adet = 14;

            int yillik_secmeliders_sutun = 31;

            int gunluk_ders_ilk = 32;
            int gunluk_ders_adet = 14;

            //PLANI YOK    int gunluk_secmeliders_sutun = 48;

            int serbest_etkinlik_dersleri_sutun = 30;


            int okumadefteri_talep_sutun = 51;
            int sosyalkulup_talep_sutun = 52;
            int cd_talep_sutun = 53;



            //Şimdi yıllık planı istenen derslerin adlarını EVET yazan sütunların ilk satırındaki güncel isimden alarak aralarında - ile birleştirelim.

            string yillikplanistenedersler = "";
            for (int i = 0; i < yillik_ders_adet; i++)
            {

                if (dr.Cells[i + yillik_ders_ilk - 1].Value.ToString().Trim() == "Evet")
                {
                    yillikplanistenedersler = yillikplanistenedersler + "-" + datagridSunucuTalepleri.Columns[i + yillik_ders_ilk - 1].HeaderText.Replace("Yıllık", "").Trim();
                }

            }

            //Aynı dizinin devamına 5-6-7-8 seçmeli dersleri ekleyelim. Peygambermimizin hayatı gibi ortaokul seçmeli dersleri.
            yillikplanistenedersler = yillikplanistenedersler + "-" + dr.Cells[yillik_secmeliders_sutun - 1].Value.ToString().Trim();



            //Günlük plan için istenen dersleri de aralarında tire - işaretiyle birleştirelim.
            string gunlukplanistenedersler = "";
            for (int i = 0; i < gunluk_ders_adet; i++)
            {

                if (dr.Cells[i + gunluk_ders_ilk - 1].Value.ToString().Trim() == "Evet")
                {
                    gunlukplanistenedersler = gunlukplanistenedersler + "-" + datagridSunucuTalepleri.Columns[i + gunluk_ders_ilk - 1].HeaderText.Replace("Günlük", "").Trim();
                }

            }


            //YILLIK ANA DERS EKLEMEK İÇİN İŞLEM YAPIYORUZ. Burada sınıf sayısı kadar döngü kuracağız.

            string[] siniflar = dr.Cells[excelbilgisutunlari.sinif_stn - 1].Value.ToString().Split('-');
            string[] yillik_istenen_dersler_dizi = yillikplanistenedersler.Split('-');
            string[] gunluk_istenen_dersler_dizi = gunlukplanistenedersler.Split('-');

            foreach (string snf in siniflar)
            {
                if (snf.Trim().Length > 0)
                {


                    foreach (string birders in yillik_istenen_dersler_dizi)
                    {

                        //Eğer ders varsa işlem yapıyoruz. En başa çizgi konmuş olabilir.
                        if (birders.Trim().Length > 0)
                        {


                            //Döngüde bu dersin adının bulunup bulunmadığına bakmak için kullanacağız.
                            bool ders_bulunup_islendimi = false;
                            string eklenecekolanders = snf + "-" + birders;

                            //Seçilen dersi ve sınıfı birleştirip filtrelenlerde var mı diye bakacağız. (İçeriyor mu diye bakacağız. Sonundaki yayınevi olmayacak çünkü.)
                            //filtrelenlerde ders adı sınıfla birlikte geliyor. 1-Hayat Bilgisi-MEB gibi

                            for (int i = 0; i < filtrelenenAnaDerslers.Count; i++)
                            {

                                if (filtrelenenAnaDerslers[i].dersadi.Contains(eklenecekolanders) || filtrelenenAnaDerslers[i].dersadi.Contains(eklenecekolanders.ToUpper()))
                                {

                                    //Dersi bulduysak ekliyoruz.
                                    ders_bulunup_islendimi = true;

                                    string kayitsonucu = vtislemleri.ekle_y_anaders(BirOgt.oid, filtrelenenAnaDerslers[i].anadersid, filtrelenenAnaDerslers[i].fiyat);

                                    if (kayitsonucu.All(char.IsNumber))
                                    {
                                        //Kayıt başarılı.

                                    }
                                    else
                                    {
                                        MessageBox.Show("İşlem tamamlanmadı. Çıkılıyor. Öğretmen: " + BirOgt.adisoyadi + " Hata: " + kayitsonucu);
                                        return false;
                                    }

                                    //Bu dersi bulduysak kaydediyoruz ve döngüden çıkıp diğer derse geçiyoruz.
                                    break;

                                }

                            }

                            if (!ders_bulunup_islendimi)
                            {
                                MessageBox.Show("İşlem tamamlanmadı. Ders bulunamadı: " + eklenecekolanders);
                                return false;
                            }

                        }


                    }

                    //Aynı Sınıf döngüsü içindeyiz. Günlük planı da bu döngü içinde halledelim.
                    //GÜNLÜK PLAN EKLEME KISMI.


                    foreach (string birders in gunluk_istenen_dersler_dizi)
                    {

                        //Eğer ders varsa işlem yapıyoruz. En başa çizgi konmuş olabilir.
                        if (birders.Trim().Length > 0)
                        {


                            //Döngüde bu dersin adının bulunup bulunmadığına bakmak için kullanacağız.
                            bool ders_bulunup_islendimi = false;
                            string eklenecekolanders = snf + "-" + birders;

                            //Seçilen dersi ve sınıfı birleştirip filtrelenlerde var mı diye bakacağız. (İçeriyor mu diye bakacağız. Sonundaki yayınevi olmayacak çünkü.)
                            //filtrelenlerde ders adı sınıfla birlikte geliyor. 1-Hayat Bilgisi-MEB gibi

                            for (int i = 0; i < filtrelenenGunlukPlaniOlanDerslers.Count; i++)
                            {

                                if (filtrelenenGunlukPlaniOlanDerslers[i].dersadi.Contains(eklenecekolanders))
                                {

                                    //Dersi bulduysak ekliyoruz.
                                    ders_bulunup_islendimi = true;


                                    string kayitsonucu = vtislemleri.ekle_g_anaders(BirOgt.oid, filtrelenenGunlukPlaniOlanDerslers[i].gunlukdersid, filtrelenenGunlukPlaniOlanDerslers[i].fiyat);

                                    if (kayitsonucu.All(char.IsNumber))
                                    {

                                        //Kayıt işlemi başarılı.

                                    }
                                    else
                                    {
                                        MessageBox.Show("İşlem tamamlanmadı. Çıkılıyor. Öğretmen: " + BirOgt.adisoyadi + " Hata: " + kayitsonucu);
                                        return false;
                                    }



                                    //Bu dersi bulduysak kaydediyoruz ve döngüden çıkıp diğer derse geçiyoruz.
                                    break;

                                }

                            }

                            if (!ders_bulunup_islendimi)
                            {
                                MessageBox.Show("İşlem tamamlanmadı. Ders bulunamadı: " + eklenecekolanders);
                                return false;
                            }

                        }


                    }
                }




                //Birden fazla sınıf seçilmişse onun döngüsü.
            }


            //Ana ders yılllık ve günlük kayıtları tamamlandı.


            // SERBEST ETKİNLİK DERSLERİ.

        //AÇ KAPA    return true;

            //Serbest etkinlik derslerini girelim.

            string[] yillik_istenen_serbestler_dizi = dr.Cells[serbest_etkinlik_dersleri_sutun - 1].Value.ToString().Split('-');

            foreach (string birders in yillik_istenen_serbestler_dizi)
            {

                //Eğer ders varsa işlem yapıyoruz. En başa çizgi konmuş olabilir.
                if (birders.Trim().Length > 0)
                {


                    //Döngüde bu dersin adının bulunup bulunmadığına bakmak için kullanacağız.
                    bool ders_bulunup_islendimi = false;
                    string eklenecekolanders = birders;

                    //Seçilen dersi ve sınıfı birleştirip filtrelenlerde var mı diye bakacağız. (İçeriyor mu diye bakacağız. Sonundaki yayınevi olmayacak çünkü.)
                    //filtrelenlerde ders adı sınıfla birlikte geliyor. 1-Hayat Bilgisi-MEB gibi

                    for (int i = 0; i < filtrelenenSerbestEtkinlikDerslers.Count; i++)
                    {

                        //Burada contains demiyoruz, doğrudan aynı olmasını istiyoruz. ==
                        if (filtrelenenSerbestEtkinlikDerslers[i].serbestdersadi == eklenecekolanders.ToUpper())
                        {

                            //Dersi bulduysak ekliyoruz.
                            ders_bulunup_islendimi = true;


                            string kayitsonucu = vtislemleri.ekle_s_ders(BirOgt.oid, filtrelenenSerbestEtkinlikDerslers[i].serbestdersid);

                            if (kayitsonucu.All(char.IsNumber))
                            {

                                //Otomatik ekleme.
                                serbestEtkinlikSecildiAnaDersOlarakEkle();


                            }
                            else
                            {
                                MessageBox.Show("İşlem tamamlanmadı Serbest ders. Çıkılıyor. Öğretmen: " + BirOgt.adisoyadi + " Hata: " + kayitsonucu);
                                return false;
                            }



                            //Bu dersi bulduysak kaydediyoruz ve döngüden çıkıp diğer derse geçiyoruz.
                            break;

                        }

                    }

                    if (!ders_bulunup_islendimi)
                    {
                        MessageBox.Show("İşlem tamamlanmadı. Ders bulunamadı: " + eklenecekolanders);
                        return false;
                    }

                }


            }



            //EK ÜRÜN İŞLEMLERİ. CD-PDF


            //Kulüp kaydı
            string kulupAdi = dr.Cells[sosyalkulup_talep_sutun - 1].Value.ToString();

            //Kulüp adı girilmişse işlem yapacağız.
            if (kulupAdi.Length > 0)
            {

                string ikinciogretmen = "...";
                bool kulupbulundumu = false;

                for (int i = 0; i < filtrelenenSosyalKuluplers.Count; i++)
                {

                    if (filtrelenenSosyalKuluplers[i].kulupadi.Contains(kulupAdi))
                    {
                        kulupbulundumu = true;

                        string kayitsonucu = vtislemleri.ekle_sosyalkulup(BirOgt.oid, filtrelenenSosyalKuluplers[i].kulupkodu, ikinciogretmen, filtrelenenSosyalKuluplers[i].fiyat);

                        if (kayitsonucu.All(char.IsNumber))
                        {

                            //  MessageBox.Show("başarılı: " + kayitsonucu);
                            // varsa_talepBolumu();

                        }
                        else
                        {
                            MessageBox.Show("Sosyal kulüp hızlı kaydı yapılamadı. " + kayitsonucu);
                            return false;
                        }

                        break;
                    }

                }

                if (!kulupbulundumu)
                {
                    MessageBox.Show("Sosyal kulüp bulunamadı. " + kulupAdi);
                    return false;
                }

            }



            // PDF kaydına ait excelde veri yok.

            // CD İŞLEMİ. Evet yazıyorsa işlem yapacağız.

            string cdTalebi = dr.Cells[cd_talep_sutun - 1].Value.ToString();

            if (cdTalebi.Length > 0)
            {
                foreach (FiltrelenenEkUrunler urun in filtrelenenEkUrunlers)
                {

                    if (urun.urunadi == "CD")
                    {


                        string kayitsonucu = vtislemleri.ekle_ek_urunler(BirOgt.oid, urun.urunkodu, urun.fiyat);

                        if (kayitsonucu.All(char.IsNumber))
                        {

                            //  MessageBox.Show("başarılı: " + kayitsonucu);
                            // varsa_talepBolumu();

                        }
                        else
                        {
                            MessageBox.Show(kayitsonucu);
                            return false;
                        }


                        break;

                    }
                }
            }


            return true;
        }

        private void bt_sil_seciliveriler_Click(object sender, EventArgs e)
        {
            sil_secilileri_sil();
        }


        private void sil_secilileri_sil()
        {


            if (tb_sil_sifre.Text != "1968")
            {
                MessageBox.Show("Şifreniz hatalı.)");
                return;
            }


            if (cb_sil_yillikplanlar.Checked)
            {
                yrdsnf.log_yaz("Yıllık plan talepleri bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_y_anaders_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }

            if (cb_sil_gunlukplanlar.Checked)
            {
                yrdsnf.log_yaz("Günlük plan talep bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_g_anaders_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }


            if (cb_sil_serbestetkinlikler.Checked)
            {
                yrdsnf.log_yaz("Serbest etkinlik talep bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_serbest_ders_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }


            if (cb_sil_defterler.Checked)
            {
                yrdsnf.log_yaz("Defter talep bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_defter_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }


            if (cb_sil_zumreler.Checked)
            {
                yrdsnf.log_yaz("Diğer zümre öğretmenleri bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_digerzumreogretmenleri_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }


            if (cb_sil_ogrencilistesi.Checked)
            {
                yrdsnf.log_yaz("Öğrenci listesi bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_ogrenci_listesi_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }

            if (cb_sil_kuluptalebi.Checked)
            {
                yrdsnf.log_yaz("Sosyal Kulüp bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_sosyalkulup_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }


            if (cb_sil_cdpdf.Checked)
            {
                yrdsnf.log_yaz("Ek ürünler (cd-pdf) bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_ekurunler_cd_pdf_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }

            if (cb_sil_odemeler.Checked)
            {
                yrdsnf.log_yaz("Ödeme bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_muhasebe_odeme_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }



            if (cb_sil_hersey.Checked)
            {
                yrdsnf.log_yaz("Öğretmen bilgileri silme işlemi tamamlandı");
                string tablom = metinler.neyebakalim_bilgi_ogretmen_tablo;
                vtislemleri.tamamen_sil_secili_tablodaki_verileri(BirOgt.oid, tablom);
            }

            yrdsnf.log_yaz("silme işlemi tamamlandı");
            lbl_bilgi.Text = "Silme işlemi tamamlandı.";

        }








        //DEFTER HIZLI TALEP İŞLEMLERİ.

        private void dgv_ara_alttaki_cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            tb_bilgi_musterino.Text = dgv_alt_aramavelisteleme.Rows[e.RowIndex].Cells[0].Value.ToString();

            gosterDugmesineBasildi();

        }

        private void btn_defter_talepleriniHizliAl_Click(object sender, EventArgs e)
        {

            exceldenHizliDefterTalepleriniAl();

        }

        private void exceldenHizliDefterTalepleriniAl()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*| Excel Dosyası (xlsm) |*.xlsm| Excel Dosyası(xls) |*.xls| Excel Dosyası (xlsx)|*.xlsx";
            ofd.RestoreDirectory = true;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                yrdsnf.log_yaz("Excel hızlı talep. " + ofd.FileName);
                datagridSunucuTalepleri.DataSource = excelSecildiTalepleriGetir(ofd.FileName, "defter");


                if (datagridSunucuTalepleri.Rows.Count > 1)
                {
                    //Veri var, işleme devam edelim.

                    //Başlıkları içeren bilgileri alalım. (Bilgi sütunlarının hangi sütun numarasına denk geldiğini alıyoruz. Bayikodu = 1 gibi.)
                    excelbilgisutunlari = vtislemleri.excelsutunbasliklari_bilgi();

                    lbl_bekleyin.Text = "Verileri kaydediliyor.";

                    defterVerileriniVtYeKaydet();

                    lbl_bekleyin.Text = "Tamamlandı. Adet: " + datagridSunucuTalepleri.RowCount;
                    pb_defterhizlikayit.Value = 0;


                }
                else
                {
                    MessageBox.Show("Hiçbir veri yok. İşlem yapılmadı");
                }

            }

        }


        //______________________________________________________________________________


        private void defterVerileriniVtYeKaydet()
        {

            //  MessageBox.Show(datagridSunucuTalepleri.Rows.Count.ToString(), "Satır");

            pb_defterhizlikayit.Maximum = datagridSunucuTalepleri.RowCount;


            for (int i = 0; i < datagridSunucuTalepleri.Rows.Count; i++)
            {
                pb_defterhizlikayit.Value = i; // +1 gerekir ama eklemiyoruz.

                DataGridViewRow dr = datagridSunucuTalepleri.Rows[i];

                if (dr.Cells[excelbilgisutunlari.adisoyadi_stn].Value.ToString() != "")
                {


                    //1. Adım- Öğretmen bilgilerini kaydet.

                    int ogretmenKayitID = deftervtYeKaydet_adim_1(dr);

                    if (ogretmenKayitID > 0)
                    {

                        bool talepkaydisonucu = deftervtYeKaydet_adim_2(dr);

                        if (!talepkaydisonucu)
                        {
                            string msjmtn = "Öğretmen talepleri kaydedilemedi. Satır: " + i;
                            yrdsnf.log_yaz(msjmtn);
                            MessageBox.Show(msjmtn);
                        }



                    }
                    else
                    {
                        string msjmtn = "Öğretmen talepleri kaydedilemedi. Satır: " + i;
                        yrdsnf.log_yaz(msjmtn);
                        MessageBox.Show(msjmtn);
                    }

                    //Denemek için tek kayıt ile yerlerine yazıp görme işlemi yapıyoruz. sonra çıkıyoruz.
                    // return;


                }
            }




        }


        //Bu bize yeni kaydolan öğretmenin kimlikno'sunu döndürecek ve o kayıt ile sipariş taleplerini gireceğiz.
        //Bu kısım plan talepleriyle aynı. Öğretmen bilgilerini girerek yeni bir kayıt oluşturuyoruz ve o kayıt numarasına sipariş giriyoruz.
        //Buradaki işlemden sonra, oluşan kayıt numarasına defter siparişi gireceğiz.
        private int deftervtYeKaydet_adim_1(DataGridViewRow dr)
        {
            //Excelden alınan verilere göre bilgilerin hangi sütunlardan alınacağına VT'den bakacağız. (Sayı olarak) ilk sütun 1 gireceğiz, kodlarda -1 yaparız.

            //Eğer sınıf alanında 1-2-3 gibi bir giriş varsa sadece birincisini alacağız ama dersleri tüm sınıflara göre atayacağız. Döngü oradaki sınıf sayısı olacak.

            tb_bilgi_adisoyadi.Text = yrdsnf.ismiduzelt(dr.Cells[excelbilgisutunlari.adisoyadi_stn - 1].Value.ToString(), "isim");

            cb_bilgi_bransi.Text = dr.Cells[excelbilgisutunlari.bransgorevi_stn - 1].Value.ToString();
            cb_bilgi_ili.Text = dr.Cells[excelbilgisutunlari.il_stn - 1].Value.ToString();
            cb_bilgi_ilcesi.Text = dr.Cells[excelbilgisutunlari.ilce_stn - 1].Value.ToString();


            tb_bilgi_okulkodu.Text = dr.Cells[excelbilgisutunlari.okulkodu_stn - 1].Value.ToString();
            tb_bilgi_okulu.Text = dr.Cells[excelbilgisutunlari.okuladi_stn - 1].Value.ToString();

            //Sınıfı burada olduğu gibi alıyoruz.
            cb_bilgi_sinifi.Text = dr.Cells[excelbilgisutunlari.sinif_stn - 1].Value.ToString();

            tb_bilgi_subesi.Text = dr.Cells[excelbilgisutunlari.sube_stn - 1].Value.ToString();

            tb_bilgi_muduradi.Text = yrdsnf.ismiduzelt(dr.Cells[excelbilgisutunlari.muduradi_stn - 1].Value.ToString(), "isim");
            cb_bilgi_mudurunvani.Text = dr.Cells[excelbilgisutunlari.mudurunvani_stn - 1].Value.ToString();

            tb_bilgi_telefon.Text = dr.Cells[excelbilgisutunlari.telefon_stn - 1].Value.ToString();
            tb_bilgi_eposta.Text = dr.Cells[excelbilgisutunlari.eposta_stn - 1].Value.ToString();

            //Excelden adres bilgis gelmiyor.
            //Adres bölümünde NOTUMUZ'u göstereceğiz.
            tb_bilgi_adres.Text = dr.Cells[excelbilgisutunlari.notumuz_stn - 1].Value.ToString();

            tb_bilgi_aciklama.Text = dr.Cells[excelbilgisutunlari.aciklama_stn - 1].Value.ToString();


            tb_bilgi_bayikodu.Text = dr.Cells[excelbilgisutunlari.bayikodu_stn - 1].Value.ToString();
            //Bayi adı otomatik gelecek inşallah.
            // bayikodundanBayiBilgileriniGetir();


            //Burası Defter kayıt işlemleri..

            //Öğretmen bilgisi kaydedelim. //Bilgileri forma yazmıştık, bilgileri oradan okutup kaydettiyoruz.
            //Defter için aynı sınıf şube'ye birden fazla kayıt girilebilecek.
            yeniKayitYapveyaGuncelle(true, cb_defter_mukerrerkayit_izin_ver.Checked);



            //Dersleri vs getirelim. (ile, bayiye göre...)
            varsayilanTalepleilgiliVeriler();

            //Yeni kayıt soununda oluşan müşteri numarasını döndürüyoruz.
            return int.Parse(tb_bilgi_musterino.Text);
        }


        private bool deftervtYeKaydet_adim_2(DataGridViewRow dr)
        {


            int defter_talep_sutun = 54;

            //Excelde burada nöbet yerlerinin adı yazıyor. Biz o yerlere uygun şablon adını elle kendimiz yazıyoruz. Şablon adını esas alacağız.
            int defter_nobetyerleri_sutun = 57;


            //Nöbet yeri şablonu varsa onu da ekliyoruz.
            //Nöbet yeri şablon adını listeden bulup ekleyeceğiz inşallah.

            string nobetsablonununadi = dr.Cells[defter_nobetyerleri_sutun - 1].Value.ToString();

            if (nobetsablonununadi.Trim().Length > 0)
            {

                bool sablonbulundumu = false;

                for (int i = 0; i < filtrelenenNobetyerisablonlars.Count; i++)
                {

                    yrdsnf.log_yaz("defter kodu " + filtrelenenDefterlers[i].defterkodu);

                    if (filtrelenenNobetyerisablonlars[i].nobetyerisablonadi == nobetsablonununadi)
                    {
                        sablonbulundumu = true;

                        string sablonkayitsonucu = vtislemleri.ekle_nobetyerisablonu(BirOgt.oid, filtrelenenNobetyerisablonlars[i].nobetyerisablonadi);

                        if (sablonkayitsonucu.All(char.IsNumber))
                        {


                        }
                        else
                        {
                            MessageBox.Show("Nöbet yeri şablon kaydı yapılamadı. Yapılmadan devam edilecek. Şablon adı: " + nobetsablonununadi + " Hata: " + sablonkayitsonucu);
                           
                        }

                        break;
                    }

                }

                if (!sablonbulundumu)
                {
                    MessageBox.Show("Nöbet yeri şablon kaydı yapılamadı. Şablon bulunamadı. Kayıt yapılmadan devam edilecek. Şablon adı: " + nobetsablonununadi);

                }


            }



            //Defter kaydı
            string defterkodu = dr.Cells[defter_talep_sutun - 1].Value.ToString();

            //Kulüp adı girilmişse işlem yapacağız.
            if (defterkodu.Length > 0)
            {


                bool defterbulundumu = false;

                for (int i = 0; i < filtrelenenDefterlers.Count; i++)
                {

                    yrdsnf.log_yaz("defter kodu " + filtrelenenDefterlers[i].defterkodu);

                    if (filtrelenenDefterlers[i].defterkodu == int.Parse(defterkodu))
                    {
                        defterbulundumu = true;

                        string kayitsonucu = vtislemleri.ekle_defter(BirOgt.oid, filtrelenenDefterlers[i].defterkodu, filtrelenenDefterlers[i].fiyat);

                        if (kayitsonucu.All(char.IsNumber))
                        {

                            //  MessageBox.Show("başarılı: " + kayitsonucu);
                            //varsa_talepBolumu();

                        }
                        else
                        {
                            MessageBox.Show("Defter talebi hızlı kaydı yapılamadı. " + kayitsonucu);
                            return false;
                        }

                        break;
                    }

                }

                if (!defterbulundumu)
                {
                    MessageBox.Show("Defter bulunamadı. " + defterkodu);
                    return false;
                }

            }




            return true;
        }





        private void ara_sonucu_bulunan_kayit_sayisini_yaz()
        {
            lbl_ara_bulunankayit_sayisi.Text = dgv_alt_aramavelisteleme.RowCount.ToString();
        }


        private void lnklbl_ara_plan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ara_plan_turune_gore();

        }


        private void ara_plan_turune_gore()
        {


            dgv_alt_aramavelisteleme.DataSource = vtislemleri.ara_dgv_icin_plan_turune_gore(cb_yil_ara.Text, rb_ara_plantumu.Checked, rb_ara_planyillik.Checked, rb_ara_plangunluk.Checked,
                rb_ara_durum_tumu.Checked, rb_ara_durum_basilmis.Checked, rb_ara_durum_basilmamis.Checked);


            ara_sonucu_bulunan_kayit_sayisini_yaz();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ara_ekUrunlervb();

            ara_sonucu_bulunan_kayit_sayisini_yaz();

        }


        private void ara_ekUrunlervb()
        {

            //Ek ürünler listesi boş olunca aşağıda kod alma kısmı haliyle çalışmıyor.
            if (filtrelenenEkUrunlers.Count == 0)
            {
                //Sadece kodu lazım. Ücret grubunu 1 olarak gidiriyoruz. Ücret grubuyla işimiz olmayacak. Öğretmen seçildiğinde doğru ücret grubuyla tekrrar çağırılıyor.

                filtrelenenEkUrunlers = vtislemleri.filtre_ekurunler(cb_yil_ara.Text, "1");
            }


            string tur = "PDF";

            if (rb_ara_cd.Checked)
            {
                tur = "DEFTER";
            } else if (rb_ara_sosyalkulup.Checked)
            {
                tur = "sosyalkulup";
            } else if (rb_ara_okumadefteri.Checked)
            {
                tur = "okumadefteri";
            }


            int turkodu = 0;

            //CD veya pdf ise o zaman ürün kodunu da alalım. CD = 101, pdf = 102 gibi.

            if (tur == "DEFTER" || tur == "PDF")
            {

                foreach (FiltrelenenEkUrunler urun in filtrelenenEkUrunlers)
                {

                    if (urun.urunadi == tur)
                    {

                        turkodu = urun.urunkodu;
                        break;
                    }

                }
            }


            dgv_alt_aramavelisteleme.DataSource = vtislemleri.ara_dgv_icin_ekurunler_turune_gore(cb_yil_ara.Text, tur, turkodu, 
                rb_ara_ekurun_durum_tumu.Checked, rb_ara_ekurun_durum_basilmis.Checked, rb_ara_ekurun_durum_basilmamis.Checked);



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int turkodu = 0;

            //Defter listesi boş olunca aşağıda kod alma kısmı haliyle çalışmıyor.
            if (filtrelenenDefterlers_sadeceolanlar.Count == 0)
            {
                //Sadece kodu lazım. Ücret grubunu 1 olarak gidiriyoruz. Ücret grubuyla işimiz olmayacak.
                //Öğretmen seçildiğinde doğru ücret grubuyla tekrar çağırılıyor.
                filtrelenenDefterlers_sadeceolanlar = vtislemleri.filtre_defterler_sadecetalebiolanlar(cb_yil_ara_defter.Text, "1");
            }

            //Defter isimlerini cb'ye yazalım.
            //Önceden varsa eklemiyoruz.
            if (cb_ara_defterturu.Items.Count < 1)
            {

                foreach (FiltrelenenDefterler urun in filtrelenenDefterlers_sadeceolanlar)
                {

                    cb_ara_defterturu.Items.Add(urun.defteradi + " (" + urun.defterkodu + ") " + urun.sinif + " - " + urun.ozellik);


                    //Baskı aşamasında sadece bu defter için basım yapın demek için cb dolduruyoruz.
                    cb_baski_basilacak_defterturu.Items.Add(urun.defteradi + " (" + urun.defterkodu + ") " + urun.sinif + " - " + urun.ozellik);

                }

            }


            //Seçilen bir defter türü varsa ona bakacağız. Yoksa tümüne bakacağız.
            if (cb_ara_defterturu.Text.Trim().Length > 1)
            {
                        turkodu = filtrelenenDefterlers_sadeceolanlar[cb_ara_defterturu.SelectedIndex].defterkodu;
              
            }





            dgv_alt_aramavelisteleme.DataSource = vtislemleri.ara_dgv_icin_defterler_turune_gore(cb_yil_ara_defter.Text, turkodu,
                rb_ara_defter_durum_tumu.Checked, rb_ara_defter_durum_basilmis.Checked, rb_ara_defter_durum_basilmamis.Checked);

            ara_sonucu_bulunan_kayit_sayisini_yaz();

        }

        private void bt_mukerrerkayit_izni_cb_bilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(metinler.bilgi_mukerrer_cb_secimi);
        }

        private void lnklbl_ara_bilgilerle_listele_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ara_bilgileregore_listele();
        }


        private void ara_bilgileregore_listele()
        {


            dgv_alt_aramavelisteleme.DataSource = vtislemleri.ara_dgv_icin_bilgilere_gore(cb_yil_ara_bilgileregore.Text, tb_yil_ara_bilgileregore_il.Text,
                tb_yil_ara_bilgileregore_ilce.Text, tb_yil_ara_bilgileregore_okul.Text, tb_yil_ara_musteriadi.Text, tb_yil_ara_bilgileregore_bayiadi.Text);


            ara_sonucu_bulunan_kayit_sayisini_yaz();

        }

        private void bt_defterbas_rb_secenekleri_bilgi_Click(object sender, EventArgs e)
        {

            MessageBox.Show(metinler.bilgi_defterbas_rb_secenekleri);

        }

        private void bt_bilgi_defterbaskisecenek_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(metinler.bilgi_defterbas_rb_baskisecenekleri_1);
        }

        private void bt_bilgi_defterbaskisecenek_2_teklitoplu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(metinler.bilgi_defterbas_rb_baskisecenekleri_2_teklitoplu1);
        }

        private void bt_bilgi_defterbas_sonislem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(metinler.bilgi_defterbas_rb_baskisecenekleri_sonislem);
        }

        private void bt_varsayilan_kayit_konumu_pdf_degistir_Click(object sender, EventArgs e)
        {

            string sutunbasligi = "defter_kayit_yolu_pdf";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);

        }


        private void bt_varsayilan_degistir_yillikplanyolu_Click(object sender, EventArgs e)
        {
            string sutunbasligi = "yillikplanyolu";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);
        }

        private void bt_varsayilan_degistir_gunlukplanyolu_Click(object sender, EventArgs e)
        {
            string sutunbasligi = "gunlukplanyolu";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);
        }

        private void bt_varsayilan_degistir_plankapakyolu_Click(object sender, EventArgs e)
        {
            string sutunbasligi = "plankapakyolu";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);
        }

        private void bt_varsayilan_degistir_basimsonu_planpdfyolu_Click(object sender, EventArgs e)
        {
            string sutunbasligi = "plan_kayit_yolu_pdf";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);
        }

        private void bt_varsayilan_degistir_defteryolu_Click(object sender, EventArgs e)
        {
            string sutunbasligi = "defteryolu";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);
        }

        private void bt_varsayilan_degistir_defterkapakyolu_Click(object sender, EventArgs e)
        {
            string sutunbasligi = "defterkapakyolu";
            yeni_defter_kayit_yolu_pdf_sec(sutunbasligi);
        }


        private void yeni_defter_kayit_yolu_pdf_sec(string sutunbasligi)
        {


            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Klasörü seçin.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

             //   tb_varsayilan_kayit_konumu_pdf.Text = folderPath;


                folderPath = folderPath.Replace("\\", "\\\\");

                vtislemleri.varsayilan_kayit_yeri_kaydet(sutunbasligi, folderPath);

                bossa_varsayilanlarYilBayivs();

                // ...
            } else
            {

                MessageBox.Show("Yeni klasör seçimi yapılmadı.");

            }


        }


       //Her öğretmenin belgeleri kapak, plan vs ayrı ayrı pdf oluyor. Bunları buraya birleştiriyoruz. En sonunda tek pdf haline getireceğiz.
       //Her öğretmen için ayrı dosya seçeneği seçili ise öğretmene ait belgeler diğer öğretmene geçmeden önce birleştirilip öğretmen oidpdf olarak kaydedilecek.
       //Eğer listedekilerin hepsini tek pdf yap derse tek pdf yapma içini diğer öğretmene geçse de yapmayacağız. 5 öğretmenlik belge varsa mesela onları birleştireceğiz.
       //Son öğretmenin oid'si ve toplupdf yazarak kaydedeceğiz.

        List<string> yeniBelgelerPdfBirlestirmeicin = new List<string>();
        int yenidosyasayaci;

       

        private void bt_defterbas_baskiyabasla_Click(object sender, EventArgs e)
        {
           


            defter_baskisina_basla();

        }


        private void defter_baskisina_basla()
        {

            //Liste mi basacağız, sadece ekrandakini mi_
            defter_bas_1_basilacaklar();



        }

        private void defter_bas_1_basilacaklar()
        {

            //Baskıya başla dediğimizde bu listeyi temizleyip sıfırlan belgeleri ekleyeceğiz.
            yeniBelgelerPdfBirlestirmeicin.Clear();
            //Her dosyanın başınamüşteri numarasını ekleyeceğiz, onun yanına da bu değeri ekleyeceğiz. 176_1_defterkapakdosya.pdf gibi olacak.
            yenidosyasayaci = 1;


            if (rb_defter_bas_ekrandakikayiticinislemyap.Checked)
            {
                //Listeden birini seçip göster demiyoruz. Zaten ekrandakini bas demişiz.
               
                               
                defter_bas_2_islemdekiKayit();

                //Ekrandaki kaydı bas demişse diğer öğretmene geçmeden önce öğretmenpdf'si oluşturalım.
                pdfbirlestir_1(true, false);

            } else
            {

                //Döngü ile listedeki kayıtları ekrana getireceğiz ve işleme alarak işlemdeki kayda ait defter basım işlemini başlatacağız.
                for (int i = 0; i < dgv_alt_aramavelisteleme.Rows.Count; i++)
                {

                    if (rb_defterbas_tektoplu_tek.Checked)
                    {
                        //Tek tek bas demişse her öğretmen çin temiz bir liste hazırlıyoruz.
                        yeniBelgelerPdfBirlestirmeicin.Clear();
                        yenidosyasayaci = 1;
                    }


                    //   Burada satır satır alıp göster diyeceğiz ve gösterildikten sonra işlemdeki kaydın defterini bas diyeceğiz.

                    DataGridViewRow dr = dgv_alt_aramavelisteleme.Rows[i];

                    if (dr.Selected)
                    {

                        tb_bilgi_musterino.Text = dr.Cells[0].Value.ToString();

                        gosterDugmesineBasildi();

                        //Listedeki seçili öğretmen gösterildi ve işleme alındı.
                        defter_bas_2_islemdekiKayit();



                        if (rb_defterbas_tektoplu_tek.Checked)
                        {
                            //Tek tek bas demişse diğer öğretmene geçmeden önce öğretmenpdf'si oluşturalım.

                            pdfbirlestir_1(true, false);

                        }

                    }




                }

                if (rb_defterbas_tektoplu_toplu.Checked)
                {
                    //Tek tek bas demişse diğer öğretmene geçmeden önce öğretmenpdf'si oluşturalım.

                    pdfbirlestir_1(false, false);

                }


            }


        }



        private void defter_bas_2_islemdekiKayit()
        {
            //O anda ekrandaki kayda ilişkin işlem yapar ama buradaki mantık şu şekildedir. İstenilen kayıt ekrana 
            //getirilmiştir. Yani burası liste veya ekrandaki kayıt mantığının dışında.

            FiltrelenenDefterler istenendefter = null;

            if (cb_baski_basilacak_defterturu.SelectedIndex >= 0)
            {
               
                istenendefter = filtrelenenDefterlers_sadeceolanlar[cb_baski_basilacak_defterturu.SelectedIndex];
            
            }


            //Tüm defterler için ortak olabilecek değerlerle siparişçi excelini oluşturuyoruz.
            defter_icinAdresMektupSipariscisiHazirla();


            for (int i=0;i< dgv_talep_defterler_baski.RowCount; i++)
            {
               DataGridViewRow dr = dgv_talep_defterler_baski.Rows[i];

                string basilacakolandefterkodu = dr.Cells["defterkodu"].Value.ToString();

                if (istenendefter == null || (istenendefter.defterkodu.ToString() == basilacakolandefterkodu))
                {
                    //Eğer herhangi bir defter seçilmemişse tüm defterler basılacak demektir. Defter seçilmişse aynı defter mi diye bakıyoruz.
                    defter_bas_3_gelenKaydiBas(basilacakolandefterkodu);

                }

            }

        }



        private void defter_bas_3_gelenKaydiBas(string basilacakolandefterkodu)
        {

            //Defter kodu geldi. Asıl defter basma işlemi burada başlayacak.

           



            if (rb_defterbas_secenek_kapakvedefter.Checked)
            {
                //Kapak ve defter basımı.
                //Önce defter kapağı basacağız.
                defter_bas_3_ek_defterkapagibas(basilacakolandefterkodu,"kapak");
                defter_bas_3_ek_2_defter_bas(basilacakolandefterkodu,"defter");

            } else if (rb_defterbas_secenek_kapak.Checked)
            {
                //Sadece kapağı bas.
                defter_bas_3_ek_defterkapagibas(basilacakolandefterkodu,"kapak");

            } else if (rb_defterbas_secenek_defter.Checked)
            {
                defter_bas_3_ek_2_defter_bas(basilacakolandefterkodu, "defter");
            }

            


            //Kapağa isim verip kaydediyoruz. Ne isim verdiğimizi bileceğiz. müşterino_defterno veya müşterino_defterkapakno gibi.
            //Sonra bunları sıra ile birleştireceğiz.




        }


        private void defter_icinAdresMektupSipariscisiHazirla()
        {


            Dictionary<string, string> adresMesktupBaslikDegerleri = new Dictionary<string, string>();
            //Kapakta/defterde/planda olması gereken değerleri burada oluşturuyoruz.

            adresMesktupBaslikDegerleri["İLİ"] = BirOgt.ili;
            adresMesktupBaslikDegerleri["ili"] = BirOgt.ili;
            adresMesktupBaslikDegerleri["İLÇESİ"] = BirOgt.ilcesi;
            adresMesktupBaslikDegerleri["OKULU"] = BirOgt.okuladi;
            adresMesktupBaslikDegerleri["ilcesi"] = BirOgt.ilcesi;
            adresMesktupBaslikDegerleri["sinifi"] = BirOgt.sinifi;
            adresMesktupBaslikDegerleri["SINIFI"] = BirOgt.sinifi;

            if (BirOgt.sinifi == "03" || BirOgt.sinifi == "04" || BirOgt.sinifi == "05" || BirOgt.sinifi == "06")
            {
                adresMesktupBaslikDegerleri["sinifi"] = metinler.anasinifi_okuloncesi_yazimi;
                adresMesktupBaslikDegerleri["SINIFI"] = metinler.anasinifi_okuloncesi_yazimi;
            }



            adresMesktupBaslikDegerleri["subesi"] = BirOgt.subesi;
            adresMesktupBaslikDegerleri["ŞUBE"] = BirOgt.subesi;
            adresMesktupBaslikDegerleri["adisoyadi"] = BirOgt.adisoyadi;
            adresMesktupBaslikDegerleri["ADI_SOYADI"] = BirOgt.adisoyadi;
            adresMesktupBaslikDegerleri["bransi"] = BirOgt.bransi;
            adresMesktupBaslikDegerleri["GÖREVİ"] = BirOgt.bransi;
            adresMesktupBaslikDegerleri["OKUL_MÜDÜR"] = BirOgt.muduradi;
            adresMesktupBaslikDegerleri["GÖREVİ1"] = BirOgt.mudurunvani;


            //Öğrenci listesi varsa onu da alalım ve ekleyelim.

            int ogrencisayac = 1;

            for (int o = 0; o < 60; o++)
            {
                adresMesktupBaslikDegerleri["NO" + ogrencisayac] = "";
                adresMesktupBaslikDegerleri["ÖĞRENCİ" + ogrencisayac] = "";
                ogrencisayac++;
            }


            ogrencisayac = 1;

            foreach (OgrenciListesiSnf veri in talepOgrencilistesis)
            {
                adresMesktupBaslikDegerleri["NO" + ogrencisayac] = veri.numara.ToString();
                adresMesktupBaslikDegerleri["ÖĞRENCİ" + ogrencisayac] = veri.adisoyadi;
                ogrencisayac++;
            }



            //Nöbet yerleriyle ilgili bilgileri alıyoruz.
            //Nöbet yerlerini dgv_talep_nobetyerleri üzerinden çekeceğiz. Görüntüleyince nöbet yeri varsa oraya düşüyor.

            if (dgv_talep_nobetyerleri.Rows.Count > 0)
            {

                for (int i = 0; i < 1; i++)
                {
                    //Toplam 12 tane nöbet yeri var. Boş olanlar olsa da onları yazacağız.
                    for (int ny = 1; ny < 13; ny++)
                    {
                        adresMesktupBaslikDegerleri["NOBETYERI" + ny] = dgv_talep_nobetyerleri.Rows[0].Cells[ny + 1].Value.ToString();
                    }

                }

            }
            else
            {
                //Eğer nöbet yeri belirtilmemişse başlıkları yazıp boş bırakıyoruz.
                for (int ny = 1; ny < 13; ny++)
                {
                    adresMesktupBaslikDegerleri["NOBETYERI" + ny] = "";
                }

            }



            excelSnf.adresMektupicinExceliHazirlasiparisci(adresMesktupBaslikDegerleri);

        }


        private void defter_bas_3_ek_defterkapagibas(string basilacakolandefterkodu, string basilanTur)
        {

            //Defter kodu geldi.
            //Önce defter kapağı basacağız.

            //Belgeyi açması için filigran ekle komutunu kullanıyoruz. İlk değişken olarak basılacak olan defter kapağını alıyoruz
            //ve filigran olarak bir boşluk gönderiyoruz.

            //Kapak için defterkodunu "" olarak giriyoruz. Çünkü kapak için basım tarihi eklemeyeceğiz.

            basim_1_filigranEkle(varsayilanbossa.defterkapakyolu + @"\" + "kapak_" + basilacakolandefterkodu + ".docx", " ", false, false, "", basilanTur);


        }



        private void defter_bas_3_ek_2_defter_bas(string basilacakolandefterkodu, string basilanTur)
        {

            //Defter kodu geldi.
           //Burada defteri basıyoruz.

            //Belgeyi açması için filigran ekle komutunu kullanıyoruz. İlk değişken olarak basılacak olan defter kapağını alıyoruz
            //ve filigran olarak bir boşluk gönderiyoruz.

            basim_1_filigranEkle(varsayilanbossa.defteryolu + @"\" + basilacakolandefterkodu + ".docx", " ", false, false, basilacakolandefterkodu, basilanTur);

        }








        //PLAN BASKI İŞLEMLERİ.



        private void bt_planbas_baskiyabasla_Click(object sender, EventArgs e)
        {
            plan_baskisina_basla();
        }



        private void plan_baskisina_basla()
        {

            //Liste mi basacağız, sadece ekrandakini mi_
            plan_bas_1_basilacaklar();



        }

        private void plan_bas_1_basilacaklar()
        {

            //Baskıya başla dediğimizde bu listeyi temizleyip sıfırlan belgeleri ekleyeceğiz.
            yeniBelgelerPdfBirlestirmeicin.Clear();
            //Her dosyanın başınamüşteri numarasını ekleyeceğiz, onun yanına da bu değeri ekleyeceğiz. 176_1_defterkapakdosya.pdf gibi olacak.
            yenidosyasayaci = 1;


            if (rb_planbas_ekrandakiicin.Checked)
            {
                //Listeden birini seçip göster demiyoruz. Zaten ekrandakini bas demişiz.


                plan_bas_2_islemdekiKayit();

                //Ekrandaki kaydı bas demişse diğer öğretmene geçmeden önce öğretmenpdf'si oluşturalım.
                pdfbirlestir_1(true, true);
                

            }
            else
            {

                //Döngü ile listedeki kayıtları ekrana getireceğiz ve işleme alarak işlemdeki kayda ait defter basım işlemini başlatacağız.
                for (int i = 0; i < dgv_alt_aramavelisteleme.Rows.Count; i++)
                {

                    if (rb_planbas_tektektoplu_tek.Checked)
                    {
                        //Tek tek bas demişse her öğretmen çin temiz bir liste hazırlıyoruz.
                        yeniBelgelerPdfBirlestirmeicin.Clear();
                        yenidosyasayaci = 1;
                    }


                    //   Burada satır satır alıp göster diyeceğiz ve gösterildikten sonra işlemdeki kaydın defterini bas diyeceğiz.

                    DataGridViewRow dr = dgv_alt_aramavelisteleme.Rows[i];

                    if (dr.Selected)
                    {

                        tb_bilgi_musterino.Text = dr.Cells[0].Value.ToString();

                        gosterDugmesineBasildi();

                        //Listedeki seçili öğretmen gösterildi ve işleme alındı.
                        plan_bas_2_islemdekiKayit();



                        if (rb_planbas_tektektoplu_tek.Checked)
                        {
                            //Tek tek bas demişse diğer öğretmene geçmeden önce öğretmenpdf'si oluşturalım.

                            pdfbirlestir_1(true, true);

                        }

                    }




                }

                if (rb_planbas_tektektoplu_toplu.Checked)
                {
                    //Tek tek bas demişse diğer öğretmene geçmeden önce öğretmenpdf'si oluşturalım.

                    pdfbirlestir_1(false, true);

                }


            }


        }


        //Bunları her kayıt için sıfırlayacağız. Liste döngüsüne girdiğinde her ders için tekrar tekrar basmaması için böyle yapıyoruz. Basınca true yapacağız.
        private bool kapakbasildimi = false;
        private bool ondosyabasildimi = false;


        private void plan_bas_2_islemdekiKayit()
        {
            //O anda ekrandaki kayda ilişkin işlem yapar ama buradaki mantık şu şekildedir. İstenilen kayıt ekrana 
            //getirilmiştir. Yani burası liste veya ekrandaki kayıt mantığının dışında.


            //Tüm planlar için ortak olabilecek değerlerle siparişçi excelini oluşturuyoruz.
            plan_icinAdresMektupSipariscisiHazirla();


            //Öğretmenin seçtiği dersleri tek tek göndermeden önce kapak varsa önce onu basacağız.
            //Kapaktan sonra ön dosya basılacak. Her ders için ayrı ayrı basmasın diye kapak ve ön dosya basımını döngünün başına alıyoruz.


            //Bunları her kayıt için sıfırlayacağız. Liste döngüsüne girdiğinde her ders için tekrar tekrar basmaması için böyle yapıyoruz. Basınca true yapacağız.
            kapakbasildimi = false;
            ondosyabasildimi = false;


            if (rb_planbas_kapsam_sadeceyillik.Checked)
            {

                for (int i = 0; i < dgv_talep_yillikplanlar_baski.RowCount; i++)
                {
                    DataGridViewRow dr = dgv_talep_yillikplanlar_baski.Rows[i];

                    string basilacakolanplankodu = dr.Cells["dersid"].Value.ToString();

                    plan_bas_3_gelenKaydiBas(basilacakolanplankodu);

                }

            }
            else
            {

                for (int i = 0; i < dgv_talep_gunlukplanlar_baski.RowCount; i++)
                {
                    DataGridViewRow dr = dgv_talep_gunlukplanlar_baski.Rows[i];

                    string basilacakolanplankodu = dr.Cells["dersid"].Value.ToString();

                    plan_bas_3_gelenKaydiBas(basilacakolanplankodu);

                }

            }

        }



        private void plan_bas_3_gelenKaydiBas(string basilacakolanplankodu)
        {

            //Plan kodu geldi. Asıl plan basma işlemi burada başlayacak.

            



            if (rb_planbas_secenek_kapakveplan.Checked)
            {
                //Kapak ve defter basımı.
                //Önce defter kapağı basacağız.

                //Kapağı sadece 1 kere basmak için kontrol işlemi yapıyoruz. Çünkü des listesi döngüsüne göre işlem tekrarlanıyor.
                if (!kapakbasildimi)
                {
                    plan_bas_3_ek_plankapagibas(basilacakolanplankodu, "kapak");
                    kapakbasildimi = true;
                }


                if (!ondosyabasildimi)
                {
                    plan_bas_3_ek_planOnDosyabas("ondosya");
                    ondosyabasildimi = true;
                }


                plan_bas_3_ek_2_plan_bas(basilacakolanplankodu, "plan");

            }
            else if (rb_planbas_secenek_kapak.Checked)
            {
                //Sadece kapağı bas.
                //Kapağı sadece 1 kere basmak için kontrol işlemi yapıyoruz. Çünkü des listesi döngüsüne göre işlem tekrarlanıyor.
                if (!kapakbasildimi)
                {
                    plan_bas_3_ek_plankapagibas(basilacakolanplankodu, "kapak");
                    kapakbasildimi = true;
                }

            }
            else if (rb_planbas_secenek_plan.Checked)
            {

                if (!ondosyabasildimi)
                {
                    plan_bas_3_ek_planOnDosyabas("ondosya");
                    ondosyabasildimi = true;
                }

                plan_bas_3_ek_2_plan_bas(basilacakolanplankodu, "plan");
            }




            //Kapağa isim verip kaydediyoruz. Ne isim verdiğimizi bileceğiz. müşterino_defterno veya müşterino_defterkapakno gibi.
            //Sonra bunları sıra ile birleştireceğiz.




        }


        private void plan_icinAdresMektupSipariscisiHazirla()
        {


            Dictionary<string, string> adresMesktupBaslikDegerleri = new Dictionary<string, string>();
            //Kapakta/defterde/planda olması gereken değerleri burada oluşturuyoruz.

            adresMesktupBaslikDegerleri["İLİ"] = BirOgt.ili;
            adresMesktupBaslikDegerleri["İLÇESİ"] = BirOgt.ilcesi;
            adresMesktupBaslikDegerleri["OKULU"] = BirOgt.okuladi;
            adresMesktupBaslikDegerleri["SINIFI"] = BirOgt.sinifi;


            if (BirOgt.sinifi == "03" || BirOgt.sinifi == "04" || BirOgt.sinifi == "05" || BirOgt.sinifi == "06")
            {
                adresMesktupBaslikDegerleri["sinifi"] = metinler.anasinifi_okuloncesi_yazimi;
            }

            adresMesktupBaslikDegerleri["ŞUBE"] = BirOgt.subesi;
            adresMesktupBaslikDegerleri["ADI_SOYADI"] = BirOgt.adisoyadi;
            adresMesktupBaslikDegerleri["GÖREVİ"] = BirOgt.bransi;
            adresMesktupBaslikDegerleri["OKUL_MÜDÜR"] = BirOgt.muduradi;
            adresMesktupBaslikDegerleri["GÖREVİ1"] = BirOgt.mudurunvani;

            //AŞAĞIDA DEĞER ALACAK OLAN BAŞLIKLAR.
            adresMesktupBaslikDegerleri["ZUMREOGRETMENLERI"] = "";
            adresMesktupBaslikDegerleri["M_1ZÜMRE"] = "";

            adresMesktupBaslikDegerleri["EYLUL"] = "";
            adresMesktupBaslikDegerleri["EKIM"] = "";
            adresMesktupBaslikDegerleri["KASIM"] = "";
            adresMesktupBaslikDegerleri["ARALIK"] = "";
            adresMesktupBaslikDegerleri["OCAK"] = "";
            adresMesktupBaslikDegerleri["SUBAT"] = "";
            adresMesktupBaslikDegerleri["MART"] = "";
            adresMesktupBaslikDegerleri["NISAN"] = "";
            adresMesktupBaslikDegerleri["MAYIS"] = "";
            adresMesktupBaslikDegerleri["HAZIRAN"] = "";


            //Öğrenci listesi varsa onu da alalım ve ekleyelim.

            int ogrencisayac = 1;

            //Word bunlara bakacağı için mutlaka ekliyoruz. Boş olsa bile ekleyeceğiz.
            for (int o = 0; o < 60; o++)
            {
                adresMesktupBaslikDegerleri["NO" + ogrencisayac] = "";
                adresMesktupBaslikDegerleri["ÖĞRENCİ" + ogrencisayac] = "";
                ogrencisayac++;
            }



            ogrencisayac = 1;

            foreach (OgrenciListesiSnf veri in talepOgrencilistesis)
            {
                adresMesktupBaslikDegerleri["NO" + ogrencisayac] = veri.numara.ToString();
                adresMesktupBaslikDegerleri["ÖĞRENCİ" + ogrencisayac] = veri.adisoyadi;
                ogrencisayac++;
            }


            //Diğer zümre öğretmenlerinin isimlerini plan siparişçi'sine ekleyelim.
            //Datagridden alacağız. (İleride belki de vt'den alırız.)

            //Hepsini birleştirip aralarına boşluk koyarak yazacağız. Mahmut Kök     Metin TUNCER gibi.
            string digerzumreogretmenlerininisimleri = "";
            foreach (DataGridViewRow dr in dgv_talep_digerzumreogretmenleri.Rows)
            {

                digerzumreogretmenlerininisimleri += "     " + dr.Cells["dersid"].Value.ToString();

            }

            adresMesktupBaslikDegerleri["ZUMREOGRETMENLERI"] = digerzumreogretmenlerininisimleri.Trim();
            adresMesktupBaslikDegerleri["M_1ZÜMRE"] = digerzumreogretmenlerininisimleri.Trim();

            //Mahalli kurtuluş günlerini ekleyelim. Eylül-Haziran arası her ay için bir değişken kullanalım.

            //Önce şehir için, sonra da ilçe için kurtuluş gününe bakalım ve olanları art arda birleştirip yazalım.
            List<string> mahallilist = vtislemleri.mahallikurtulusgunubilgilerinigetir(BirOgt.ili, BirOgt.ili + "-" + BirOgt.ilcesi);

            if (mahallilist.Count > 0)
            {

                foreach (string kurtulusgunu in mahallilist)
                {

                    string[] kurtulusbilgileri = kurtulusgunu.Split(';');

                    adresMesktupBaslikDegerleri[kurtulusbilgileri[0]] += kurtulusbilgileri[1] + "   ";

                }

            }



            //Serbest etkinlik için her bir derse ayrı ayrı değişken atayıp eşleştirme denemesi yapacağız. Bunu da excele atıp adres mektup ile eşleştireceğiz.
            //Eğer serbest etkinlik dersleri seçilmişse onları döngü halinde ekleyeceğiz.

            
            //Eğer serbest etkinlik dersi seçilmişse işlem yapacağız. Yoksa bu kısmı atlıyoruz.
            if (dgv_talep_serbestdersler_yillik.Rows.Count > 0)
            {
                //Öncelikle varsayılan ders saati bilgileirni alalım ve serbest etkinliklerin DGV'lerini dolduralım.
                serbestEtkinliklerdeHangiSiniftaKacSaatDersOldugunuAl();

                int kacsaatvar = varsayilanbossa.serbestderssaati_sinif_1;
                //Hangi DGV'ye bakacağımızı buradan takip ediyoruz.
                DataGridView dgv = dgv_serbestetkinlikdersleri_1;

                switch (BirOgt.sinifi)
                {

                    case "1":
                        kacsaatvar = varsayilanbossa.serbestderssaati_sinif_1;
                        dgv = dgv_serbestetkinlikdersleri_1;
                        break;


                    case "2":
                        kacsaatvar = varsayilanbossa.serbestderssaati_sinif_2;
                        dgv = dgv_serbestetkinlikdersleri_2;
                        break;

                    case "3":
                        kacsaatvar = varsayilanbossa.serbestderssaati_sinif_3;
                        dgv = dgv_serbestetkinlikdersleri_3;
                        break;

                    case "4":
                        kacsaatvar = varsayilanbossa.serbestderssaati_sinif_4;
                        dgv = dgv_serbestetkinlikdersleri_4;
                        break;

                }

                int kachaftavar = dgv_serbestetkinlikdersleri_4.RowCount;


                int derssayac = 0; //Bunu seçilen serbest etkinlik dersleri olarak takip etmek için kullanacağız.
                int saatsayac = 1;  //mesela 74'e kadar gidecek. O sene kaç saat varsa.

                for (int i = 0; i < kachaftavar; i++)
                {

                    for (int s = 0; s < kacsaatvar; s++)
                    {
                        //Dersin adını talep edilen serbet etkinlik DGV'sinden alalım. (Data Grid View)
                        DataGridViewRow dr = dgv_talep_serbestdersler_yillik.Rows[derssayac];

                        string serbestdersadi = dr.Cells[0].Value.ToString();


                        adresMesktupBaslikDegerleri["k" + saatsayac] = dgv.Rows[i].Cells[serbestdersadi].Value.ToString();
                        //Ders isminin sonunda _A var. Bu da açıklama anlamına geliyor.
                        adresMesktupBaslikDegerleri["ka" + saatsayac] = dgv.Rows[i].Cells[serbestdersadi + "_A"].Value.ToString();


                        saatsayac++;
                        derssayac++;

                        if (dgv_talep_serbestdersler_yillik.Rows.Count >= derssayac)
                        {
                            derssayac = 0;
                        }

                    }

                }


            }


            


            excelSnf.adresMektupicinExceliHazirlasiparisci(adresMesktupBaslikDegerleri);

        }


        private void plan_bas_3_ek_plankapagibas(string basilacakolanplankodu, string basilanTur)
        {

            //Plan kodu geldi.
            //Önce defter kapağı basacağız.

            //Belgeyi açması için filigran ekle komutunu kullanıyoruz. İlk değişken olarak basılacak olan defter kapağını alıyoruz
            //ve filigran metni olarak bir boşluk " " gönderiyoruz.

            //Kapak için defterkodunu "" olarak giriyoruz. Çünkü kapak için basım tarihi eklemeyeceğiz.

            //yıllık kapak, günlük kapak.


            //KAPAKLAR YATAY OLDUĞU İÇİN DİKLEŞTİRECEĞİZ.
            if (rb_planbas_kapsam_sadeceyillik.Checked)
            {
                basim_1_filigranEkle(varsayilanbossa.plankapakyolu + @"\" + "y_kapak.docx", " ", true, true, "", basilanTur);

            }
            else
            {
                basim_1_filigranEkle(varsayilanbossa.plankapakyolu + @"\" + "g_kapak.docx", " ", true, true, "", basilanTur);

            }



        }


     //   SERBEST ETKİNLİK DERSLERİNDEN HERHANGİ BİRİ SEÇİLMİŞSE ANA DERSLERE SERBEST ETKİNLİKLER DERSİNİ OTOMATİK OLARAK EKLEYECEĞİZ.
     // İnşallah ekledik. 25.05.2022 22.17       HIZLI TALEP İŞLEMİNDE DE BU DURUMU KONTROL EDECEĞİZ.



        private void plan_bas_3_ek_planOnDosyabas(string basilanTur)
        {

            //Ön Dosyayı basacağız. Sadece Yıllık plan için basılıyor. !!
            //Yıllık plan seçilmemişse ön dosyayı basmıyoruz.

            if (!rb_planbas_kapsam_sadeceyillik.Checked)
            {
                return;
            }


            //Belgeyi açması için filigran ekle komutunu kullanıyoruz. İlk değişken olarak basılacak olan defter kapağını alıyoruz
            //ve filigran metni olarak bir boşluk " " gönderiyoruz.

            //n dosya için defterkodunu "" olarak giriyoruz. Çünkü kapak için basım tarihi eklemeyeceğiz.


                basim_1_filigranEkle(varsayilanbossa.yillikplanyolu + @"\" + "0000.docx", " ", true, false, "", basilanTur);

        }






        private void plan_bas_3_ek_2_plan_bas(string basilacakolanplankodu, string basilanTur)
        {

            //Plan kodu geldi.
            //Burada planı basıyoruz.

            //Belgeyi açması için filigran ekle komutunu kullanıyoruz. İlk değişken olarak basılacak olan plan kapağını alıyoruz
            //ve filigran metni olarak öğretmen adını gönderiyoruz.


            if (rb_planbas_kapsam_sadeceyillik.Checked)
            {
                basim_1_filigranEkle(varsayilanbossa.yillikplanyolu + @"\y_" + basilacakolanplankodu + ".docx", BirOgt.adisoyadi, true, true, basilacakolanplankodu, basilanTur);

            } else
            {
                basim_1_filigranEkle(varsayilanbossa.gunlukplanyolu + @"\g_" + basilacakolanplankodu + ".docx", BirOgt.adisoyadi, true, false, basilacakolanplankodu, basilanTur);

            }

        }
























        //WORD PDF VB İŞLEMLER. PLAN DEFTER ORTAK.





        private void basim_1_filigranEkle(string filePath, string filigranmetni, bool planmi1_deftermi0, bool pdfyataydir_donecekmi, string basilanUrunKoduTarih_icin, string basilanTur)
        {
            //ORTAK İŞLEMLER...
            //Plan basılıyorsa true, defter basılıyorsa false. PDF klasörünü ayırmak için kullanacağız.

            object oMissing = System.Type.Missing;

            Document wordDoc = null;
            Application wordApp = new Application(); //null;



            wordDoc = wordApp.Documents.Open(filePath);

            if (filigranmetni.Trim().Length > 0)
            {

            //Filigran için metin yoksa hiç işlem yapmadan devam ediyoruz.


                Microsoft.Office.Interop.Word.Shape txWatermark = null;
                foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
                {
                    txWatermark = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Shapes.AddTextEffect(
                        MsoPresetTextEffect.msoTextEffect1,
                                            filigranmetni, "Arial", (float)40,
                                             MsoTriState.msoTrue,
                                             MsoTriState.msoFalse,
                                             0, 0, ref oMissing);

                    //      txWatermark.Select(ref oMissing);
                    txWatermark.Fill.Visible = MsoTriState.msoTrue;
                    txWatermark.Line.Visible = MsoTriState.msoFalse;
                    txWatermark.Fill.Solid();
                    txWatermark.Fill.ForeColor.RGB = (Int32)Microsoft.Office.Interop.Word.WdColor.wdColorGray30; //wdColorRed;
                    txWatermark.RelativeHorizontalPosition =
                                           Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin;
                    txWatermark.RelativeVerticalPosition =
                                               Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionMargin;
                    txWatermark.Left = (float)Microsoft.Office.Interop.Word.WdShapePosition.wdShapeCenter;
                    txWatermark.Top = (float)Microsoft.Office.Interop.Word.WdShapePosition.wdShapeCenter;
                    txWatermark.Height = wordApp.InchesToPoints(2.4f);
                    txWatermark.Width = wordApp.InchesToPoints(6f);
                    txWatermark.Rotation = -60;

                    //SADECE 1 BÖLÜME EKLESEK YETERLİ. YOKSA KAÇ BÖLÜM VARSA AYNISINI O KADAR EKLİYOR.
                    break;
                }

            }
            // doc.Save(); // As2(filePath, new Guid());

            // wordApp.Quit();




            //Sonraki adım için Kapatmadan açık word belgesiyle devam ediyoruz.
            basim_2_adresMektupAyarlavePDFOlarakKaydet(wordApp, wordDoc, planmi1_deftermi0, pdfyataydir_donecekmi, basilanUrunKoduTarih_icin, basilanTur);


        }



        private void basim_2_adresMektupAyarlavePDFOlarakKaydet(Application word_Uygulamasi, Document word_Belgesi, bool planmi1_deftermi0, bool pdfyataydir_donecekmi, string basilanUrunKoduTarih_icin, string basilanTur)
        {



            // string sourceFile = ""; // "c:\my_template.docx"; //this is where you store your template
            // string word_dosyamiz = @"C:\materyall\wordler\1001.docm";  //"c:\final.docx"; //this is where your result file locate


            string hedef_pdf_dosyamiz = varsayilanbossa.plan_kayit_yolu_pdf;  //@"C:\materyall\wordler\1001pdf.pdf";                                                      //   Mailmerge(sourceFile, filePath, nr, dt.Columns);

            if (!planmi1_deftermi0)
            {
                //Eğer defter basılıyorsa o klasörü seçelim.
                hedef_pdf_dosyamiz = varsayilanbossa.defter_kayit_yolu_pdf;
            }

            //Klasör yoluna pdf dosya adı olacak bilgileri ekleyelim.
            if (pdfyataydir_donecekmi)
            {
                hedef_pdf_dosyamiz = hedef_pdf_dosyamiz + @"\" + metinler.pdf_yatay_bilgisi + BirOgt.oid + "_" + yenidosyasayaci + "_" + word_Belgesi.Name + ".pdf";

            } else
            {
                hedef_pdf_dosyamiz = hedef_pdf_dosyamiz + @"\" + BirOgt.oid + "_" + yenidosyasayaci + "_" + word_Belgesi.Name + ".pdf";
            }
            


            adresmektupBirlestir2(word_Uygulamasi, word_Belgesi, hedef_pdf_dosyamiz, pdfyataydir_donecekmi, basilanUrunKoduTarih_icin, basilanTur);

        }

        private void adresmektupBirlestir2(Application word_Uygulamasi, Document word_Belgesi, string hedefpdfdosyamiz, bool pdfyataydir_donecekmi, string basilanUrunKoduTarih_icin, string basilanTur)
        {

            string excelAdresMektupbilgileri = metinler.siparisci_tam_yolu;

            //  Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();

            // var document = new Document();
            // document = wordApplication.Documents.Add(Template: word_dosyamiz);


            word_Belgesi.MailMerge.OpenDataSource(Name: excelAdresMektupbilgileri, ConfirmConversions: false, ReadOnly: true, LinkToSource: true,
                AddToRecentFiles: false, PasswordDocument: "", PasswordTemplate: "", WritePasswordDocument: "", WritePasswordTemplate: "", Revert: false,
                Format: WdOpenFormat.wdOpenFormatAuto, Connection: "Provider=Microsoft.Jet.OLEDB.4.0;Password='';User ID=Admin;Data Source=" + excelAdresMektupbilgileri + ";Mode=Read;Extended Properties=HDR=YES;IMEX=1;'';Jet OLEDB:System database='';Jet OLEDB:Registry Path='';Jet OLEDB:Database P",
                SQLStatement: "SELECT * FROM `Sayfa1$`", SQLStatement1: "", SubType: WdMergeSubType.wdMergeSubTypeAccess);

            //"SELECT * FROM `Sayfa1$`" Tek tırnak farklı.

            //   document.MailMerge.ViewMailMergeFieldCodes = WdConstants.wdToggle;
            word_Belgesi.ActiveWindow.View.MailMergeDataView = true;
           

            //Şimdi de pdf olarak kaydedelim.

            acikWorduPdfKaydet(hedefpdfdosyamiz,word_Uygulamasi, word_Belgesi, pdfyataydir_donecekmi, basilanUrunKoduTarih_icin, basilanTur);

          //çAĞRILAN NESNE İSTEMCİDEN AYRILMIŞ. Farklı kaydedince zaten kapanmış gibi oluyor galiba.  document.Close(false);
            word_Uygulamasi.Quit();





        }

      
        private void acikWorduPdfKaydet(string hedefdosya, Application word_Uygulamasi, Document word_Belgesi, bool pdfyataydir_donecekmi, string basilanUrunKoduTarih_icin, string basilanTur)
        {


            /*
             ActiveDocument.ExportAsFixedFormat OutputFileName:= _
        "C:\Materyall\SistemDosyaları\Defterler\Defterdosyaları\2710PDF2.pdf", _
        ExportFormat:=wdExportFormatPDF, OpenAfterExport:=False, OptimizeFor:= _
        wdExportOptimizeForPrint, Range:=wdExportAllDocument, From:=1, To:=1, _
        Item:=wdExportDocumentContent, IncludeDocProps:=True, KeepIRM:=True, _
        CreateBookmarks:=wdExportCreateNoBookmarks, DocStructureTags:=True, _
        BitmapMissingFonts:=True, UseISO19005_1:=False

            */

         

            word_Belgesi.SaveAs2(hedefdosya, WdSaveFormat.wdFormatPDF,  WdExportOptimizeFor.wdExportOptimizeForPrint);

            object oMissing = System.Type.Missing;


            /*
           

            object outputFileName = hedefdosya;
            object fileFormat = WdSaveFormat.wdFormatPDF;

            // Save document into PDF Format
            word_Belgesi.SaveAs(ref outputFileName,
                ref fileFormat, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            */

            // Close the Word document, but leave the Word application open.
            // doc has to be cast to type _Document so that it will find the
            // correct Close method.                
            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            ((_Document)word_Belgesi).Close(ref saveChanges, ref oMissing, ref oMissing);
            word_Belgesi = null;

            //Word belgemizi kaydetmeden kapattık ve yok ettik. Döndüreceksek döndürelim sonra Belgeler listemize ekleyelim.

            if (pdfyataydir_donecekmi)
            {
                pdfDikeyYap(hedefdosya);
            }


            yeniBelgelerPdfBirlestirmeicin.Add(hedefdosya.Replace(metinler.pdf_yatay_bilgisi,""));
            yenidosyasayaci++;



            //Belgenin hazırlandığını basımtarihine ekleyelim.

            


            vtislemleri.basimTarihini_kaydet(BirOgt.oid, basilanTur, basilanUrunKoduTarih_icin);

        }





        //PDF ÜZERİNDEKİ İŞLEMLER.
        private void pdfDikeyYap(string yataypdf)
        {

            string yadaybelge = yataypdf; //@"C:\materyall\pdfler\2YILLIK.pdf";
            string dikeybelge = yataypdf.Replace(metinler.pdf_yatay_bilgisi, ""); // @"C:\materyall\pdfler\2YILLIKD.pdf";


            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(yadaybelge);


            int pagesCount = reader.NumberOfPages;

            for (int i = 0; i < pagesCount; i++)
            {

                iTextSharp.text.pdf.PdfDictionary page = reader.GetPageN(i + 1);
                iTextSharp.text.pdf.PdfNumber rotate = page.GetAsNumber(iTextSharp.text.pdf.PdfName.ROTATE);
                page.Put(iTextSharp.text.pdf.PdfName.ROTATE, new iTextSharp.text.pdf.PdfNumber(270));

            }



            FileStream fs = new FileStream(dikeybelge, FileMode.Create,
            FileAccess.Write, FileShare.None);

            iTextSharp.text.pdf.PdfStamper stamper = new iTextSharp.text.pdf.PdfStamper(reader, fs);

            stamper.Close();
            reader.Close();


            //  MessageBox.Show("dikildi");
            string[] yataylar = new string[1];
            yataylar[0] = yataypdf;
            pdfParcaciklariniSil(yataylar);


        }




        private void pdfbirlestir_1(bool tektek1_toplu0, bool planmi1_deftermi0)
        {
            /*
            string document1 = @"C:\materyall\pdfler\belge1.pdf";
            string document2 = @"C:\materyall\pdfler\belge2.pdf";
            string document3 = @"C:\materyall\pdfler\belge3.pdf";
            string document4 = @"C:\materyall\pdfler\2YILLIK.pdf";
            */

            string hedef_pdf_dosyamiz_birlesik = varsayilanbossa.plan_kayit_yolu_pdf;  //@"C:\materyall\wordler\1001pdf.pdf";                                                      //   Mailmerge(sourceFile, filePath, nr, dt.Columns);

            if (!planmi1_deftermi0)
            {
                //Eğer defter basılıyorsa o klasörü seçelim.
                hedef_pdf_dosyamiz_birlesik = varsayilanbossa.defter_kayit_yolu_pdf;
            }

            //Tek tek değil de toplu ise o zaman toplupdf ifadesini ekleyeceğiz.
            if (!tektek1_toplu0)
            {
                hedef_pdf_dosyamiz_birlesik = hedef_pdf_dosyamiz_birlesik + @"\" + "toplu" + BirOgt.oid + ".pdf";

            }
            else
            {
                hedef_pdf_dosyamiz_birlesik = hedef_pdf_dosyamiz_birlesik + @"\" + BirOgt.oid + ".pdf";
            }



            //PDF'leri dizi haline getirip birleştirmeye gönderelim.
            if (yeniBelgelerPdfBirlestirmeicin.Count > 0)
            {


                    string[] pdfler = new string[yeniBelgelerPdfBirlestirmeicin.Count];

                for (int i=0; i < yeniBelgelerPdfBirlestirmeicin.Count;i++)
                {
                    pdfler[i] = yeniBelgelerPdfBirlestirmeicin[i];
                }


           
                    pdfbirlestir_2(hedef_pdf_dosyamiz_birlesik, pdfler);

            } else
            {

                MessageBox.Show("Hiçbir PDF oluşturulmadığı için işlem yapılmadı.");

            }

           


         //   MessageBox.Show("bitti pdf");

        }


        //Bu olay normalde static idi. Sildik. Diğer statik olmayan işlemlere erişime izin vermiyor.
        public void pdfbirlestir_2(string hedef_pdf_dosyamiz_birlesik, params string[] pdfs)
        {
            using (var hedefDoc = new PdfDocument())
            {
                foreach (var pdf in pdfs)
                {
                    using (var pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (var i = 0; i < pdfDoc.PageCount; i++)
                            hedefDoc.AddPage(pdfDoc.Pages[i]);
                    }
                }

                hedefDoc.Save(hedef_pdf_dosyamiz_birlesik);
            }


            //İşlem sonunda pdf parçacıklarını silelim.

            pdfParcaciklariniSil(pdfs);


            //Eğer doğrudan yazıcıya gönderme seçeneği seçilmişse yazıcıya gönderelim.

            if (rb_planbas_son_yazdir.Checked)
            {
                pdfyiYazdir(hedef_pdf_dosyamiz_birlesik);
            }

        }

        private void pdfParcaciklariniSil(string[] pdfler)
        {

            foreach (var pdf in pdfler)
            {
                if (File.Exists(pdf))
                {
                    File.Delete(pdf);
                }
            }

        }


        private void pdfyiYazdir(string yazdirilacakpdf)
        {

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = yazdirilacakpdf //put the correct path here
            };
            p.Start();


        }



        //DEFTER PLAN YAZIDRMA İŞLEMLERİNİN SONU.













        private void linklbl_serbestetkinlik_dgvler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            serbestEtkinlikDersleriniSaatlericinDGVListele();


        }

        private void serbestEtkinlikDersleriniSaatlericinDGVListele ()
        {


            //Tekrar tekrar almakla uğraşmasın diye dgv'lerde dersler listelenmişse tekrar işlem yapmayacağız.
            
            if (dgv_serbestetkinlikdersleri_4.Rows.Count > 0)
            {
                return;
            }

            serbestEtkinlikDersleriniSaatlericinDGVListele_2("1", dgv_serbestetkinlikdersleri_1);
            serbestEtkinlikDersleriniSaatlericinDGVListele_2("2", dgv_serbestetkinlikdersleri_2);
            serbestEtkinlikDersleriniSaatlericinDGVListele_2("3", dgv_serbestetkinlikdersleri_3);
            serbestEtkinlikDersleriniSaatlericinDGVListele_2("4", dgv_serbestetkinlikdersleri_4);

        }

        private void serbestEtkinlikDersleriniSaatlericinDGVListele_2(string sinif, DataGridView dgv)
        {


            string dosyaadi = "serbestler.xlsx";

            dgv.DataSource = excelSecildiTalepleriGetir(varsayilanbossa.yillikplanyolu + @"\" + dosyaadi, "SDERS" + sinif);

        }












        //Sınıf sonu.
    }


}
