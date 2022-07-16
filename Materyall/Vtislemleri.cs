using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Materyall
{
    internal class Vtislemleri
    {

        YardimciSnf yrdsnf = new YardimciSnf();

        Metinler metinler = new Metinler();

        MySqlConnection mysqlbaglantisi;
        string baglanticumlesi = "Server=localhost;Database=materyall2022;Uid=root;Pwd='mt1234';";

       private void baglantiKur()
        {

            try
            {
                mysqlbaglantisi = new MySqlConnection(baglanticumlesi);
                mysqlbaglantisi.Open();

              //  MessageBox.Show("Bağlandı: ");


            }
            catch (Exception ex)
            {
                //hata
                MessageBox.Show("hata: " + ex.Message);
            }

           
        }


        private void baglantikapat (MySqlConnection connection)
        {

            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }




        //Eğer yıl, bayi kodu seçilmemişse (ileride varsayılanlar artabilir.) buradaki değerleri kullanacağız.
        public VarsayilanYilBayivbBossaSnf varsayilanlar_bossa()
        {
            
            VarsayilanYilBayivbBossaSnf veriler = new VarsayilanYilBayivbBossaSnf();

            //Bağlantı kısmı.

            baglantiKur();

            //Zaten 1 satır ama yine de limit koyduk.
            string sql = "SELECT V.*, Y.yiladi, B.bayiadi FROM sis_varsayilanlar_tbl V LEFT JOIN sis_yillar_tbl Y ON Y.yilkodu=V.yilkodu " +
                "LEFT JOIN sis_bayiler_tbl B ON B.bayikodu=V.bayikodu LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                veriler.yilkodu = int.Parse("0" + oku["yilkodu"].ToString());
                veriler.yilgorunen = oku["yiladi"].ToString();

                veriler.bayikodu = oku["bayikodu"].ToString();
                veriler.bayigorunen = oku["bayiadi"].ToString();


                veriler.yillikplanyolu = oku["yillikplanyolu"].ToString();
                veriler.gunlukplanyolu= oku["gunlukplanyolu"].ToString();
                veriler.plankapakyolu = oku["plankapakyolu"].ToString();
                veriler.plan_kayit_yolu_pdf = oku["plan_kayit_yolu_pdf"].ToString();


                veriler.defteryolu = oku["defteryolu"].ToString();
                veriler.defterkapakyolu = oku["defterkapakyolu"].ToString();
                veriler.defter_kayit_yolu_pdf = oku["defter_kayit_yolu_pdf"].ToString();

                veriler.epostametni = oku["epostametni"].ToString();

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return veriler;

        }



        public int[] varsayilanlar_bossa_ek_serbestetkinlilkderssaatleri(string yil)
        {
            //İlk kullanımda veriler çekilecek.

            int[] sonuc = new int[4];

            //Bağlantı kısmı.

            baglantiKur();

            //Zaten 1 satır ama yine de limit koyduk.
            string sql = "SELECT * FROM sis_serbestetkinlikderssaati_tbl WHERE yil='" + yil + "'";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                sonuc[int.Parse(oku["sinif"].ToString()) - 1] = int.Parse( oku["dersaati"].ToString());
            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return sonuc;

        }








        //_____Eğitim öğretim yılı bilgilerini alalım.

        public string[] filtre_eoyillari()
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT yiladi FROM sis_yillar_tbl ORDER BY yiladi";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add (oku["yiladi"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list.ToArray();

        }



        public string[] filtre_branslar()
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT bransadi FROM sis_branslar_tbl ORDER BY bransadi";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add(oku["bransadi"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list.ToArray();

        }



        public string[] filtre_iller()
        {

            //bUNU İLLER TABLOSUNDAN ALALIM. Tüm iller olsun. Elle yanlış yazılabilir.
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT iladi as veri FROM sis_iller_tbl ORDER BY iladi";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add(oku["veri"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list.ToArray();

        }


        //İlçeler, il seçilince filtreleniyor.
        public string[] filtre_ilceler(string il)
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT DISTINCT(ilce) as veri FROM tlp_ogretmenbilgileri_tbl WHERE islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND il='" + il + "' ORDER BY veri";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add(oku["veri"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list.ToArray();

        }



        public string[] filtre_mudurunvanlar()
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT unvan FROM sis_mudurunvan_tbl ORDER BY unvan";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add(oku["unvan"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list.ToArray();

        }




        public List<FiltrelenenOdemeBilgileriListesiSnf> filtre_odemeturleri()
        {
            List<FiltrelenenOdemeBilgileriListesiSnf> list = new List<FiltrelenenOdemeBilgileriListesiSnf>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT odemekodu, odemeturu FROM sis_odemeturu_tbl";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                FiltrelenenOdemeBilgileriListesiSnf oge = new FiltrelenenOdemeBilgileriListesiSnf();

                oge.odemekodu = int.Parse(oku["odemekodu"].ToString());
                oge.odemeturu = oku["odemeturu"].ToString();
                
                list.Add(oge);

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list;

        }




        public string[] filtre_siniflar()
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT sinifadi FROM sis_siniflar_tbl ORDER BY sinifkodu";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add(oku["sinifadi"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list.ToArray();

        }


        public List<Bayibilgileri> getir_bayiler()
        {
            List<Bayibilgileri> list = new List<Bayibilgileri>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT * FROM sis_bayiler_tbl ORDER BY bayiadi";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                Bayibilgileri oge = new Bayibilgileri();

                oge.bayikodu = oku["bayikodu"].ToString();
                oge.bayiadi = oku["bayiadi"].ToString();
                oge.iladi = oku["iladi"].ToString();
                oge.ilceadi = oku["ilceadi"].ToString();
                oge.ucretgrubu = oku["ucretgrubu"].ToString();

                //Yeni ögeler.
                oge.bayitamadi = oku["bayitamadi"].ToString();
                oge.yetkili = oku["yetkili"].ToString();
                oge.ceptel = oku["ceptel"].ToString();
                oge.istel = oku["istel"].ToString();
                oge.adres = oku["adres"].ToString();
                oge.vergidairesi = oku["vergidairesi"].ToString();
                oge.verginumarasi = oku["verginumarasi"].ToString();
                oge.tckimlikno = oku["tckimlikno"].ToString();
                oge.eposta = oku["eposta"].ToString();
                oge.web = oku["web"].ToString();
                oge.odemesekli = oku["odemesekli"].ToString();

                oge.bayilogosu = "" + oku["bayilogopng"].ToString();

                //________________________________________
                //Sonradan eklenen alanlar.


                list.Add(oge);

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list;

        }





        public List<FiltrelenenSosyalKulupler> filtre_sosyalkulupler(string yil, string ucretgrubu)
        {

            //Bayi kodundan fiyat bölümünü alacağız.

            List<FiltrelenenSosyalKulupler> list = new List<FiltrelenenSosyalKulupler>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_sosyalkulupler_tbl WHERE yil='" + yil + "'  ORDER BY kulupadi";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenSosyalKulupler oge = new FiltrelenenSosyalKulupler();
                //list.Add(oku["kulupadi"].ToString());
                oge.kulupkimliktablo = int.Parse( oku["id"].ToString());
                oge.kulupkodu = int.Parse(oku["kulupkodu"].ToString());
                oge.kulupadi = oku["kulupadi"].ToString();
                oge.bolum = oku["bolum"].ToString();


                string fiyatgrubu = "grup" + ucretgrubu;

                oge.fiyat = double.Parse(oku[fiyatgrubu].ToString());


                list.Add(oge);
            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list; //.ToArray();

        }





        public List<FiltrelenenDefterler> filtre_defterler(string yil, string ucretgrubu)
        {

            //Bayi kodundan fiyat bölümünü alacağız.

            List<FiltrelenenDefterler> list = new List<FiltrelenenDefterler>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_defterler_tbl WHERE yil='" + yil + "' ORDER BY defteradi";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenDefterler oge = new FiltrelenenDefterler();
                //list.Add(oku["kulupadi"].ToString());
                oge.defterkimliktablo = int.Parse(oku["id"].ToString());
                oge.defterkodu = int.Parse(oku["defterkodu"].ToString());
                oge.defteradi = oku["defteradi"].ToString();
                oge.sayfasayisi = oku["sayfasayisi"].ToString();
                oge.sinif = oku["sinif"].ToString();
                oge.derssayisi = int.Parse(oku["derssayisi"].ToString());
                oge.ozellik = oku["ozellik"].ToString();
                oge.kapak = oku["kapak"].ToString();

                string fiyatgrubu = "grup" + ucretgrubu;
                oge.fiyat = double.Parse(oku[fiyatgrubu].ToString());

                list.Add(oge);
            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list; //.ToArray();

        }


        //Sadece talebi olanları arama kısmında gösterelim.

        public List<FiltrelenenDefterler> filtre_defterler_sadecetalebiolanlar(string yil, string ucretgrubu)
        {

            //Bayi kodundan fiyat bölümünü alacağız.

            List<FiltrelenenDefterler> list = new List<FiltrelenenDefterler>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_defterler_tbl WHERE yil='" + yil + "' AND defterkodu IN " +
                "(SELECT DISTINCT(defterkodu) as defterkodu FROM " + metinler.neyebakalim_defter_tablo + "  WHERE yil='" + yil + "') " +
                " ORDER BY defteradi";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenDefterler oge = new FiltrelenenDefterler();
                //list.Add(oku["kulupadi"].ToString());
                oge.defterkimliktablo = int.Parse(oku["id"].ToString());
                oge.defterkodu = int.Parse(oku["defterkodu"].ToString());
                oge.defteradi = oku["defteradi"].ToString();
                oge.sayfasayisi = oku["sayfasayisi"].ToString();
                oge.sinif = oku["sinif"].ToString();
                oge.derssayisi = int.Parse(oku["derssayisi"].ToString());
                oge.ozellik = oku["ozellik"].ToString();
                oge.kapak = oku["kapak"].ToString();

                string fiyatgrubu = "grup" + ucretgrubu;
                oge.fiyat = double.Parse(oku[fiyatgrubu].ToString());

                list.Add(oge);
            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list; //.ToArray();

        }




        public List<FiltrelenenEkUrunler> filtre_ekurunler(string yil, string ucretgrubu)
        {

            //Bayi kodundan fiyat bölümünü alacağız.

            List<FiltrelenenEkUrunler> list = new List<FiltrelenenEkUrunler>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_ekurunler_tbl WHERE yil='" + yil + "' ORDER BY urunkodu";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenEkUrunler oge = new FiltrelenenEkUrunler();
                //list.Add(oku["kulupadi"].ToString());
                oge.ekurunkimliktablo = int.Parse(oku["id"].ToString());
                oge.urunkodu = int.Parse(oku["urunkodu"].ToString());
                oge.urunadi = oku["urunadi"].ToString();
                

                string fiyatgrubu = "grup" + ucretgrubu;
                oge.fiyat = double.Parse(oku[fiyatgrubu].ToString());

                list.Add(oge);
            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list; //.ToArray();

        }







        public List<FiltrelenenNobetYeriSablonlari> filtre_nobetyerisablonlari()
        {

            //Bayi kodundan fiyat bölümünü alacağız.

            List<FiltrelenenNobetYeriSablonlari> list = new List<FiltrelenenNobetYeriSablonlari>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_nobetyerisablon_tbl ORDER BY sablon_adi";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenNobetYeriSablonlari oge = new FiltrelenenNobetYeriSablonlari();
                
                oge.nobetyerikimliktablo = int.Parse(oku["id"].ToString());
                oge.nobetyerisablonadi = oku["sablon_adi"].ToString();

                oge.nobetyeri_1 = oku["n1"].ToString();
                oge.nobetyeri_2 = oku["n2"].ToString();
                oge.nobetyeri_3 = oku["n3"].ToString();
                oge.nobetyeri_4 = oku["n4"].ToString();
                oge.nobetyeri_5 = oku["n5"].ToString();
                oge.nobetyeri_6 = oku["n6"].ToString();
                oge.nobetyeri_7 = oku["n7"].ToString();
                oge.nobetyeri_8 = oku["n8"].ToString();
                oge.nobetyeri_9 = oku["n9"].ToString();
                oge.nobetyeri_10 = oku["n10"].ToString();
                oge.nobetyeri_11 = oku["n11"].ToString();
                oge.nobetyeri_12 = oku["n12"].ToString();



                list.Add(oge);
            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list; //.ToArray();

        }




        //   Filtrelenendersler tüm dersler için aşağıdaki sorguyu değiştireceğiz. filtreli sınıftan alacağız.

        /*
            public string[] filtre_tumdersler(string yil, string iladi)
            {

                if (yil == "" || iladi == "")
                {
                    MessageBox.Show("Yıl, şehir ve bayi seçimi zorunludur.");
                    return new List<string>().ToArray();
                }




                //Önce hangi il ise o isim ilgili yıla ait ders grubunu alacağız.
                //Sonra o ders grubundaki dersleri listeleyeceğiz.


                string dersgrubu = ilindersgurubunuGetir(yil , iladi);


                List<string> list = new List<string>();

                //Bağlantı kısmı.

                baglantiKur();

                //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
                string sql = "SELECT dersadi as veri FROM sis_tumdersler_tbl WHERE dersid IN (SELECT " + dersgrubu + " FROM sis_dersdagilim_gruplari) ORDER BY dersid";



                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                MySqlDataReader oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    list.Add(oku["veri"].ToString());

                }


                baglantikapat(mysqlbaglantisi);

                //Bağlantı kısımları.

                return list.ToArray();

            }
        */


        public List<FiltrelenenAnaDersler> filtre_tumdersler(string yil, string iladi, string ucretgrubu)
        {

            List<FiltrelenenAnaDersler> list = new List<FiltrelenenAnaDersler>();

            if (yil == "" || iladi == "")
            {
                MessageBox.Show("Yıl, şehir ve bayi seçimi zorunludur.");
                return list;
            }




            //Önce hangi il ise o isim ilgili yıla ait ders grubunu alacağız.
            //Sonra o ders grubundaki dersleri listeleyeceğiz.


            string dersgrubu = ilindersgurubunuGetir(yil, iladi);


           if (dersgrubu == "")
            {
               //Formadaki nesneye başka sınıftan ulaşma çabasındayız. lbl_bilgi.text = "Bu eğitim öğretim yılı, şehir için ders grubu oluşturulmamış.";
                return list;
            }


            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_tumdersler_tbl WHERE dersid IN (SELECT " + dersgrubu + " FROM sis_dersdagilim_gruplari) ORDER BY dersid";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenAnaDersler oge = new FiltrelenenAnaDersler();

                oge.anaderskimliktablo = int.Parse(oku["id"].ToString());
                oge.anadersid = int.Parse(oku["dersid"].ToString());
                oge.dersadi = oku["dersadi"].ToString();
                oge.bolum = oku["bolum"].ToString();

                string fiyatgrubu = "grup" + ucretgrubu;
                oge.fiyat = double.Parse(oku[fiyatgrubu].ToString());

                oge.anadersmi = (oku["anadersmi"].ToString().Length > 0);

                oge.branskodu = int.Parse("0" + oku["branskodu"].ToString()); //0 + null olma ihtimaline karşı.

                list.Add(oge);


            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list;

        }


        //Günlük planı olan dersler.

        public List<FiltrelenenGunlukPlaniOlanDersler> filtre_gunlukplaniolandersler(string yil, string iladi, string ucretgrubu)
        {

            List<FiltrelenenGunlukPlaniOlanDersler> list = new List<FiltrelenenGunlukPlaniOlanDersler>();

            if (yil == "" || iladi == "")
            {
                MessageBox.Show("Yıl, şehir ve bayi seçimi zorunludur.");
                return list;
            }




            //Önce hangi il ise o isim ilgili yıla ait ders grubunu alacağız.
            //Sonra o ders grubundaki dersleri listeleyeceğiz.


            string dersgrubu = ilindersgurubunuGetir(yil, iladi);

            if (dersgrubu == "")
            {
         //Ana derslerde mesaj gösterilmesi yeterli.       MessageBox.Show("Bu eğitim öğretim yılı, şehir için ders grubu oluşturulmamış.");
                return list;
            }


            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_gunlukplandersler_tbl WHERE yil='" + yil + "' and dersid IN (SELECT " + dersgrubu + " FROM sis_dersdagilim_gruplari) ORDER BY dersid";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenGunlukPlaniOlanDersler oge = new FiltrelenenGunlukPlaniOlanDersler();

                oge.gunlukkimliktablo = int.Parse(oku["id"].ToString());
                oge.gunlukdersid = int.Parse(oku["dersid"].ToString());
                oge.dersadi = oku["dersadi"].ToString();
                oge.bolum = oku["bolum"].ToString();

                string fiyatgrubu = "grup" + ucretgrubu;
                oge.fiyat = double.Parse(oku[fiyatgrubu].ToString());

                list.Add(oge);


            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list;

        }


        //Günlük planı olan dersler.

        public List<FiltrelenenSerbestEtkinlikDersleri> filtre_serbestetkinlikdersleri(string yil, string iladi, string ucretgrubu)
        {

            List<FiltrelenenSerbestEtkinlikDersleri> list = new List<FiltrelenenSerbestEtkinlikDersleri>();

            if (yil == "" || iladi == "")
            {
                MessageBox.Show("Yıl, şehir ve bayi seçimi zorunludur.");
                return list;
            }




            //Önce hangi il ise o isim ilgili yıla ait ders grubunu alacağız.
            //Sonra o ders grubundaki dersleri listeleyeceğiz.


            string dersgrubu = ilindersgurubunuGetir(yil, iladi);




            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_serbestetkinlikler_tbl WHERE yil='" + yil + "' ORDER BY dersadi";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                FiltrelenenSerbestEtkinlikDersleri oge = new FiltrelenenSerbestEtkinlikDersleri();

                oge.serbestkimliktablo = int.Parse(oku["id"].ToString());
                oge.serbestdersid = int.Parse(oku["dersid"].ToString());
                oge.serbestdersadi = oku["dersadi"].ToString();
                
               

                list.Add(oge);


            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list;

        }



        public string ilindersgurubunuGetir(string yil, string iladi)
        {

            string dersgurubu = "";

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT dersgrubu as veri FROM sis_ildersleri_tbl WHERE yili='" + yil + "' AND ilkodu IN (SELECT ilkodu FROM sis_iller_tbl WHERE iladi='" + iladi + "')";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                dersgurubu = "dersgrubu" + (oku["veri"].ToString());

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return dersgurubu;

        }






        // KAYIT İŞLEMLERİ.....

        //Yeni Kayıt işlemi.
        //Öğretmen bilgilerini ve talepleri kaydedeceğiz. Öncelikle öğretmen bilgilerini kaydedeceğiz,
        //sonra buna talep bilgilerini ekleyeceğiz. Güncelle derse aktif öğretmen verilerini değiştireceğiz. Yeni kayıt derse öğretmen bilsini
        // de ekleyeceğiz. (inşallah)

        public string yeniKayit(OgretmenBilgileriSnf ogtblg, bool mukerrereizinverilsinmi)
        {
            string sonuc = metinler.islembasarili;

            long sonid = 0;

            //Mükerrer kayda izin vermiyoruz. O zaman mükerrer mi diye kontol edelim.
            if (!mukerrereizinverilsinmi)
            {
                if (bukayitdahaoncedenvarmi(ogtblg.yili, ogtblg.kurumkodu, ogtblg.ili, ogtblg.ilcesi, ogtblg.okuladi, ogtblg.sinifi, ogtblg.subesi, ogtblg.adisoyadi))
                {
                    sonuc = metinler.mukerrerkayitbilgisiogretmen;

                    yrdsnf.log_yaz(ogtblg.adisoyadi + "- " + sonuc);

                    return sonuc;
                }
            }



            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO tlp_ogretmenbilgileri_tbl (islemturu, yili, adisoyadi, brans, il, ilce, kurumkodu, okuladi, sinif, sube, " +
                    "muduradi, mudurunvani, cep, eposta, adres, aciklama, bayi,logoadi) " +
                    "VALUES (" + Form1.ISLEM_TURU_TABLO_DEGERI + ",'" + ogtblg.yili + "','" + ogtblg.adisoyadi + "','" + ogtblg.bransi + "','" + ogtblg.ili + "','" + ogtblg.ilcesi + "','" +
                    ogtblg.kurumkodu + "','" + ogtblg.okuladi + "','" + ogtblg.sinifi + "','" + ogtblg.subesi + "','" + ogtblg.muduradi + "','" + ogtblg.mudurunvani
                    + "','" + ogtblg.telefon + "','" + ogtblg.eposta + "','" + ogtblg.adres + "','" + ogtblg.aciklama + "','" + ogtblg.bayikodu + "','" + ogtblg.ogretmenlogo + "')";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();
                

                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;
                    
                } else
                {

                }

                 sonid = cmd.LastInsertedId;

            } catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
              //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

            baglantikapat(mysqlbaglantisi);

            yrdsnf.log_yaz(ogtblg.adisoyadi + "- " + sonuc + " Oluşan Müşteri No:" + sonid);

            if ( sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }



        public string kaydiGuncelle(OgretmenBilgileriSnf ogtblg)
        {

            string sonuc = metinler.islembasarili;


            long musterikayitno_oid = ogtblg.oid;

            if (!bu_oid_dahaoncedenvarmi(musterikayitno_oid))
            {
                sonuc = metinler.guncellemeyapacakidyokuyarisi;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "UPDATE tlp_ogretmenbilgileri_tbl SET " +
                    "islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + ", " +
                    "yili='" + ogtblg.yili + "', " +
                    "adisoyadi='" + ogtblg.adisoyadi + "', " +
                    "brans='" + ogtblg.bransi + "', " +
                    "il='" + ogtblg.ili + "', " +
                    "ilce='" + ogtblg.ilcesi + "', " +
                    "kurumkodu='" + ogtblg.kurumkodu + "', " +
                    "okuladi='" + ogtblg.okuladi + "', " +
                    "sinif='" + ogtblg.sinifi + "', " +
                    "sube='" + ogtblg.subesi + "', " +
                    "muduradi='" + ogtblg.muduradi + "', " +
                    "mudurunvani='" + ogtblg.mudurunvani + "', " +
                    "cep='" + ogtblg.telefon + "', " +
                    "eposta='" + ogtblg.eposta + "', " +
                    "adres='" + ogtblg.adres + "', " +
                    "aciklama='" + ogtblg.aciklama + "', " +
                    "bayi=" + ogtblg.bayikodu + ", " +
                    "logoadi='" + ogtblg.ogretmenlogo + "' " +
                    "WHERE oid=" + musterikayitno_oid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }





        private bool bukayitdahaoncedenvarmi(string yili, string kurumkodu, string il, string ilce, string okuladi, string sinif, string sube, string adisoyadi)
        {

            string adet = "0";

            baglantiKur();

            string sql = "SELECT COUNT(*) as adet FROM tlp_ogretmenbilgileri_tbl WHERE islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND yili='" + yili + "' AND kurumkodu='" + kurumkodu + "' AND il='" + il + "' AND ilce='" + ilce + "' AND okuladi='" + okuladi + "' AND sinif='" + sinif + "' AND sube='" + sube + "' AND adisoyadi='" + adisoyadi + "'";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                 adet = oku["adet"].ToString();

            }

            baglantikapat(mysqlbaglantisi);

            return adet != "0";

        }




        private bool bu_oid_dahaoncedenvarmi(long oid)
        {
            //Güncelleme yapacağımız için daha önceden var olan bir id olması gerekiyor. Olmayan bir id yazılırsa güncelleme yapmayacağız.
            string adet = "0";

            baglantiKur();
                                            //BURAYA İŞLEM (islemturu) TÜRÜ KOYMUYORUZ ÇÜNKÜ BU İKİ TARAF İÇİN DE ÖNEMLİ.  HEPSİNE BAKMASI LAZIM !!!!!!
            string sql = "SELECT COUNT(*) as adet FROM tlp_ogretmenbilgileri_tbl WHERE oid=" + oid;



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                adet = oku["adet"].ToString();

            }

            baglantikapat(mysqlbaglantisi);

            return adet != "0";

        }






        //Bilgi getir / göster işlemi.

        public OgretmenBilgileriSnf ogretmenBilgisiGetir(string musterino)
        {


            


            OgretmenBilgileriSnf ogrblg = new OgretmenBilgileriSnf();

            ogrblg.adisoyadi = metinler.veribulunamadi;


            if (musterino == null || musterino == "")
            {
                //Null gitmesin diye...
                //Bayi bilgilerini alıyoruz.
                ogrblg.bayibilgileri = bayiaBilgileriniGetir_bayikodundan(ogrblg.bayikodu);

                return ogrblg;
            }



            baglantiKur();

            string sql = "SELECT * FROM tlp_ogretmenbilgileri_tbl WHERE islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND oid=" + musterino + " LIMIT 1";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                //(yili, adisoyadi, brans, il, ilce, kurumkodu, okuladi, sinif, sube, muduradi, mudurunvani, cep, eposta, adres, aciklama, bayi,logoadi)

                ogrblg.yili = oku["yili"].ToString();

                ogrblg.adisoyadi = oku["adisoyadi"].ToString();
                ogrblg.bransi = oku["brans"].ToString();

                ogrblg.ili = oku["il"].ToString();
                ogrblg.ilcesi = oku["ilce"].ToString();
                ogrblg.kurumkodu = oku["kurumkodu"].ToString();
                ogrblg.okuladi = oku["okuladi"].ToString();
                ogrblg.sinifi = oku["sinif"].ToString();
                ogrblg.subesi = oku["sube"].ToString();

                ogrblg.muduradi = oku["muduradi"].ToString();
                ogrblg.mudurunvani = oku["mudurunvani"].ToString();

                ogrblg.telefon = oku["cep"].ToString();
                ogrblg.eposta = oku["eposta"].ToString();
                ogrblg.adres = oku["adres"].ToString();

                ogrblg.aciklama = oku["aciklama"].ToString();

                ogrblg.ogretmenlogo = oku["logoadi"].ToString();

                //Bu bayi kodu bayibilgileri sınıfının bilgilerini alabilmek için kullanılıyor.
                ogrblg.bayikodu = oku["bayi"].ToString();

                ogrblg.kayittarihi = oku["kayittarihi"].ToString();
            }

            baglantikapat(mysqlbaglantisi);

            //Bayi bilgilerini alıyoruz.
            ogrblg.bayibilgileri = bayiaBilgileriniGetir_bayikodundan(ogrblg.bayikodu);





            return ogrblg;
        }







        public Okulbilgileri okulbilgisinigetir_kurumkodundan(string kurumkodu)
        {

            //Okul bilgileri daha önce girilmiş kayıtların sonuncusundan alınmaktadır. Tüm Türkiye'nin kurum kodları mevcut değil.

            Okulbilgileri okulbilgisi = new Okulbilgileri();


            okulbilgisi.kurumkodu = "";
            okulbilgisi.ili = "";
            okulbilgisi.ilcesi = "";
            okulbilgisi.okuladi = "KAYIT YOK";
            okulbilgisi.muduradi = "";
            okulbilgisi.mudurunvani = "";


            baglantiKur();

            string sql = "SELECT il, ilce, okuladi, muduradi, mudurunvani FROM tlp_ogretmenbilgileri_tbl WHERE islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND kurumkodu='" + kurumkodu + "' ORDER BY kayittarihi LIMIT 1";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                okulbilgisi.kurumkodu = kurumkodu;
                okulbilgisi.ili = oku["il"].ToString();
                okulbilgisi.ilcesi = oku["ilce"].ToString();
                okulbilgisi.okuladi = oku["okuladi"].ToString();
                okulbilgisi.muduradi = oku["muduradi"].ToString();
                okulbilgisi.mudurunvani = oku["mudurunvani"].ToString();

            }

            baglantikapat(mysqlbaglantisi);



            return okulbilgisi;

        }




        public Bayibilgileri bayiaBilgileriniGetir_bayikodundan(string bayikodu)
        {

            Bayibilgileri bayibilgileri = new Bayibilgileri();

            bayibilgileri.bayikodu = bayikodu;
            bayibilgileri.bayiadi = "BULUNAMADI";
            bayibilgileri.iladi = "";
            bayibilgileri.ilceadi = "";
            bayibilgileri.ucretgrubu = "";



            baglantiKur();

            string sql = "SELECT * FROM sis_bayiler_tbl WHERE bayikodu='" + bayikodu + "' LIMIT 1";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                bayibilgileri.bayikodu = bayikodu;
              
                bayibilgileri.bayiadi = oku["bayiadi"].ToString();
                bayibilgileri.iladi = oku["iladi"].ToString();
                bayibilgileri.ilceadi = oku["ilceadi"].ToString();
                bayibilgileri.ucretgrubu = oku["ucretgrubu"].ToString();

                //Yeni bilgiler.
                bayibilgileri.bayikodu = oku["bayikodu"].ToString();
                bayibilgileri.bayiadi = oku["bayiadi"].ToString();
                bayibilgileri.iladi = oku["iladi"].ToString();
                bayibilgileri.ilceadi = oku["ilceadi"].ToString();
                bayibilgileri.ucretgrubu = oku["ucretgrubu"].ToString();

                //Yeni ögeler.
                bayibilgileri.bayitamadi = oku["bayitamadi"].ToString();
                bayibilgileri.yetkili = oku["yetkili"].ToString();
                bayibilgileri.ceptel = oku["ceptel"].ToString();
                bayibilgileri.istel = oku["istel"].ToString();
                bayibilgileri.adres = oku["adres"].ToString();
                bayibilgileri.vergidairesi = oku["vergidairesi"].ToString();
                bayibilgileri.verginumarasi = oku["verginumarasi"].ToString();
                bayibilgileri.tckimlikno = oku["tckimlikno"].ToString();
                bayibilgileri.eposta = oku["eposta"].ToString();
                bayibilgileri.web = oku["web"].ToString();
                bayibilgileri.odemesekli = oku["odemesekli"].ToString();

                bayibilgileri.bayilogosu = "" + oku["bayilogopng"].ToString();

            }

            baglantikapat(mysqlbaglantisi);



            return bayibilgileri;

        }








        //Talep bilgilerinin girilmesine başlandı.

        //Farklı bir işlem girişi olduğu için başa aldık. Diğerleri benzer kodlar olduğu için aşağıda olacak. Kopyala yapıştır mantığıylr yapacağız onları.

        public string ekle_ek_urunler(int oid, int urunkodu, double fiyat)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            if (bu_talep_dahaoncedenvarmi(oid, urunkodu, metinler.neyebakalim_ekurunler_cd_pdf_tablo, metinler.neyebakalim_ekurunler_cd_pdf_urunid_adi))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_ekurunler_cd_pdf_tablo + " " +
                    "(oid, urunkodu, fiyat, taleptarihi) " +
                    "VALUES (" + oid + "," + urunkodu + "," + fiyat + ", now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_ekurunler(int oid, int urunkodu)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_ekurunler_cd_pdf_tablo + " " +
                    "WHERE oid=" + oid + " AND urunkodu=" + urunkodu;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);




            return sonuc;

        }






        public string ilYayineviNoGetir1234Siniflar(string yili, string iladi, string sinifi)
        {


            //Hangi ilin 1-2-3-4. sınıflarda 


            string bakilacakalan = "yayinsnf" + sinifi;

            string adet = "1";

            baglantiKur();

            


            string sql = "SELECT " + bakilacakalan + "  as kodu FROM sis_ilyayinevino_tbl a LEFT JOIN sis_iller_tbl b ON a.ilkodu=b.ilkodu WHERE a.yil='" + yili + "' AND b.iladi='" + iladi + "'";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                adet = oku["kodu"].ToString();

            }

            baglantikapat(mysqlbaglantisi);

            return adet;


        }



        public bool ek_urun_talepEdilmismi(int oid, int urunkodu)
        {

            return bu_talep_dahaoncedenvarmi(oid, urunkodu, metinler.neyebakalim_ekurunler_cd_pdf_tablo, metinler.neyebakalim_ekurunler_cd_pdf_urunid_adi);

        }



        public DataTable dgv_icin_ekurunleri_getir(int oid, String yili)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.urunadi, a.urunkodu, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_ekurunler_cd_pdf_tablo + " a LEFT JOIN sis_ekurunler_tbl b ON a.urunkodu=b.urunkodu WHERE b.yil='" + yili + "' AND oid=" + oid + " ORDER BY a.urunkodu"; ;


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }







        public string ekle_y_anaders(int oid, int dersid, double fiyat)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            if (bu_talep_dahaoncedenvarmi(oid, dersid, metinler.neyebakalim_y_anaders_tablo, metinler.neyebakalim_y_anaders_urunid_adi))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_y_anaders_tablo + " " +
                    "(oid, dersid, fiyat, taleptarihi) " +
                    "VALUES (" + oid + "," + dersid + "," + fiyat + ", now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_y_anaders(int oid, int dersid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_y_anaders_tablo + " " +
                    "WHERE oid=" + oid + " AND dersid=" + dersid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                


            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


           

            return sonuc;

        }



        public DataTable dgv_icin_y_anaderleri_getir(int oid, String yili)
        {

           
            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_y_anaders_tablo + " a LEFT JOIN sis_tumdersler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili +"' AND oid=" + oid + " ORDER BY a.dersid";


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);

           

            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }






        //günlük plan için 3 komut 

        public string ekle_g_anaders(int oid, int dersid, double fiyat)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            if (bu_talep_dahaoncedenvarmi(oid, dersid, metinler.neyebakalim_g_anaders_tablo, metinler.neyebakalim_g_anaders_urunid_adi))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_g_anaders_tablo + " " +
                    "(oid, dersid, fiyat, taleptarihi) " +
                    "VALUES (" + oid + "," + dersid + "," + fiyat + ", now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_g_anaders(int oid, int dersid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_g_anaders_tablo + " " +
                    "WHERE oid=" + oid + " AND dersid=" + dersid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);




            return sonuc;

        }



        public DataTable dgv_icin_g_anaderleri_getir(int oid, String yili)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_g_anaders_tablo + " a LEFT JOIN sis_tumdersler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili + "' AND oid=" + oid + " ORDER BY a.dersid"; ;


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }






        //SERBEST ETKİNLİK İŞLEMLERİ VT

        
        public string ekle_s_ders(int oid, int dersid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            if (bu_talep_dahaoncedenvarmi(oid, dersid, metinler.neyebakalim_serbest_ders_tablo, metinler.neyebakalim_s_ders_urunid_adi))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_serbest_ders_tablo + " " +
                    "(oid, dersid, taleptarihi) " +
                    "VALUES (" + oid + "," + dersid + ", now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_s_anaders(int oid, int dersid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_serbest_ders_tablo + " " +
                    "WHERE oid=" + oid + " AND dersid=" + dersid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);




            return sonuc;

        }



        public DataTable dgv_icin_s_dersleri_getir(int oid, String yili)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi FROM " + metinler.neyebakalim_serbest_ders_tablo + " a LEFT JOIN sis_serbestetkinlikler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili + "' AND oid=" + oid + " ORDER BY a.dersid"; ;


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }
























        private bool bu_talep_dahaoncedenvarmi(int oid, int urunid, string neyebakalim_tablo, string neyebakalim_urun)
        {

            //Ana ders, seçmeli ders, defter vs. için ayrı ayrı kod yazmayacağız. neyebakalım ile buradan halledeceğiz.
            //Neye bakalım bilgileri istek tarafından Metinler sınıfından alınarak gönderilecek.

            string adet = "0";

            baglantiKur();



            string sql = "SELECT COUNT(*) as adet FROM " + neyebakalim_tablo + " WHERE oid=" + oid + " AND " + neyebakalim_urun + "=" + urunid;



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                adet = oku["adet"].ToString();

            }

            baglantikapat(mysqlbaglantisi);

            return adet != "0";

        }



        private bool bu_nobetsablonu_dahaoncedenvarmi(string sablonadi)
        {

          

            string adet = "0";

            baglantiKur();



            string sql = "SELECT COUNT(*) as adet FROM sis_nobetyerisablon_tbl WHERE sablon_adi='" + sablonadi + "'";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                adet = oku["adet"].ToString();

            }

            baglantikapat(mysqlbaglantisi);

            return adet != "0";

        }




        //DEFTERLERİ EKLE.
        //

        public string ekle_defter(int oid, int dersid, double fiyat)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            if (bu_talep_dahaoncedenvarmi(oid, dersid, metinler.neyebakalim_defter_tablo, metinler.neyebakalim_defter_urunid_adi))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_defter_tablo + " " +
                    "(oid, defterkodu, fiyat, taleptarihi) " +
                    "VALUES (" + oid + "," + dersid + "," + fiyat + ", now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_defter(int oid, int dersid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_defter_tablo + " " +
                    "WHERE oid=" + oid + " AND defterkodu=" + dersid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }



        public DataTable dgv_icin_defterleri_getir(int oid, String yili)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.defteradi, a.defterkodu, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_defter_tablo + " a LEFT JOIN sis_defterler_tbl b ON a.defterkodu=b.defterkodu WHERE b.yil='" + yili + "' AND oid=" + oid + " ORDER BY a.defterkodu"; ;


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }





        //SOSYAL KULÜP İŞLEMLERİ

        //günlük plan için 3 komut 

        public string ekle_sosyalkulup(int oid, int dersid, string ikinciogretmen, double fiyat)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;


            //Kayıt işleminden önce varsa daha önceki sosyal kulüp talebini sileceğiz.
              sil_sosyalkulup(oid);


            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_sosyalkulup_tablo + " " +
                    "(oid, kulupkodu, ikinciogretmen, fiyat, taleptarihi) " +
                    "VALUES (" + oid + "," + dersid + ", '" + ikinciogretmen + "'," + fiyat + ", now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_sosyalkulup(int oid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_sosyalkulup_tablo + " " +
                    "WHERE oid=" + oid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }


            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }


        public TalepedilensosyalKulup talepedilensosyalKulup (int oid)
        {

            TalepedilensosyalKulup soskulubum = new TalepedilensosyalKulup();

            soskulubum.kulupkodu = -1;
            soskulubum.sosyalkulupikinciogretmen = "";
            soskulubum.fiyat = 0;


            baglantiKur();

            string sql = "SELECT * FROM " + metinler.neyebakalim_sosyalkulup_tablo + "  WHERE oid=" + oid + " LIMIT 1";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                soskulubum.sosyalkulupkimliktablo = int.Parse(oku["id"].ToString());
                soskulubum.kulupkodu = int.Parse(oku["kulupkodu"].ToString());

                soskulubum.sosyalkulupikinciogretmen = oku["ikinciogretmen"].ToString();
                soskulubum.fiyat = double.Parse(oku["fiyat"].ToString());
                soskulubum.taleptarihi = oku["taleptarihi"].ToString();
                soskulubum.basimtarihi = oku["basimtarihi"].ToString();


            }

            baglantikapat(mysqlbaglantisi);



            return soskulubum;

        }





        public DataTable dgv_icin_kuluptalebini_getir(int oid, String yili)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.kulupadi, a.kulupkodu, a.taleptarihi, a.basimtarihi, a.ikinciogretmen, a.fiyat FROM " + metinler.neyebakalim_sosyalkulup_tablo + " a LEFT JOIN sis_sosyalkulupler_tbl b ON a.kulupkodu=b.kulupkodu WHERE b.yil='" + yili + "' AND oid=" + oid + " ORDER BY a.kulupkodu"; ;


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }











        //Diğer zümre öğretmenlerinin isimlerini ekliyoruz.
        //

        public string ekle_digerzumreogretmeni(int oid, string ogretmenadi)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            //Mükerrer kontrolü yapmıyoruz.

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_digerzumreogretmenleri_tablo + " " +
                    "(oid, ogretmenadi) " +
                    "VALUES (" + oid + ",'" + ogretmenadi + "')";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_digerzumreogretmeni(int oid, string ogretmenadi)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_digerzumreogretmenleri_tablo + " " +
                    "WHERE oid=" + oid + " AND ogretmenadi='" + ogretmenadi + "'";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }


    
        public DataTable dgv_icin_digerzumreogretmenlerini_getir(int oid)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT ogretmenadi FROM " + metinler.neyebakalim_digerzumreogretmenleri_tablo + "  WHERE oid=" + oid + " ORDER BY ogretmenadi"; ;


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }








        // NÖBET YERİ ŞABLONU KAYIT, SİLME VE LİSTELEME İŞLEMLERİ.


        public string ekle_nobetyerisablonu(int oid, string sablon_adi)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;


            //Varsa önceki kaydı sileceğiz.
            sil_nobetyerisablonu(oid);

            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_nobetyerisablonu_tablo + " " +
                    "(oid, sablon_adi) " +
                    "VALUES (" + oid + ",'" + sablon_adi + "')";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }


        public string sil_nobetyerisablonu(int oid)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM " + metinler.neyebakalim_nobetyerisablonu_tablo + " " +
                    "WHERE oid=" + oid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }



        public DataTable dgv_icin_nobetyerisablondetayi_getir(string sablon_adi)
        {
            //Bu diğerlerinden farklı. Doğrudan nöbet yeri şablon adıyla bilgileri getirecek. Şablon adını talep tablosundan alacağız.

            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT * FROM sis_nobetyerisablon_tbl WHERE sablon_adi='" + sablon_adi + "' LIMIT 1";


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }



        public string talepedilennobetyerisablonunugetir(int oid)
        {

            string sablonadi = "";


            baglantiKur();

            string sql = "SELECT * FROM " + metinler.neyebakalim_nobetyerisablonu_tablo + "  WHERE oid=" + oid + " LIMIT 1";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                
                sablonadi = oku["sablon_adi"].ToString();
                

            }

            baglantikapat(mysqlbaglantisi);



            return sablonadi;

        }








        //YENİ BİR NÖBET ŞABLONU OLUŞTURUYORUZ.

        public string ekle_yeni_nobet_sablonu_olustur(string[] nobetsablondizisi)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            if (bu_nobetsablonu_dahaoncedenvarmi(nobetsablondizisi[0]))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO sis_nobetyerisablon_tbl " +
                    "(sablon_adi, n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11,n12) " +
                    "VALUES ('" + nobetsablondizisi[0] + "','" + nobetsablondizisi[1] + "','" + nobetsablondizisi[2] + "','" + nobetsablondizisi[3] + "'," +
                    "'" + nobetsablondizisi[4] + "','" + nobetsablondizisi[5] + "','" + nobetsablondizisi[6] + "','" + nobetsablondizisi[7] + "'," +
                    "'" + nobetsablondizisi[8] + "','" + nobetsablondizisi[9] + "','" + nobetsablondizisi[10] + "','" + nobetsablondizisi[11] + "','" + nobetsablondizisi[12] + "')";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }





        //ÖĞRENCİ LİSTESİ EKLEME, DEĞİŞTİRME, SİLME VS İŞLEMLERİ.

        public List<OgrenciListesiSnf> getirOgrenciListesi(int oid)
        {

            List<OgrenciListesiSnf> list = new List<OgrenciListesiSnf>();




            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM tlp_ogrencilistesi_tbl WHERE oid=" + oid + " ORDER BY numara";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                OgrenciListesiSnf oge = new OgrenciListesiSnf();

                oge.ogrencikimliktablo = int.Parse(oku["id"].ToString());
                oge.numara = int.Parse(oku["numara"].ToString());
                oge.adisoyadi = oku["adisoyadi"].ToString();

                list.Add(oge);

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return list;


        }



        public string sil_ogrencilistesi(int oid)
        {
            //Tabloda öğretmene tanımlı öğrenci listesini siler.

            string sonuc = metinler.islembasarili;


            baglantiKur();


            try
            {

                string sql = "DELETE FROM tlp_ogrencilistesi_tbl " +
                    "WHERE oid=" + oid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }



        public string ekle_ogrencilistesi(int oid, int numara, string adisoyadi)
        {
            

            string sonuc = metinler.islembasarili;

            long sonid = 0;

            

            baglantiKur();


            try
            {

                string sql = "INSERT INTO tlp_ogrencilistesi_tbl " +
                    "(oid, numara, adisoyadi) " +
                    "VALUES (" + oid + "," + numara + ",'" + adisoyadi + "')";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }







        //MUHASEBE İŞLEMLERİ (Yeniden Bismillah)

        //Arama listesindeki tüm öğretmenlerin muhasebe bilgilerini göstereceğiz inşallah.
        
        public MuhasebeGenelDurumSnf getirMuhasebeGenelDurumTumListe(int oid)
        {



            MuhasebeGenelDurumSnf oge = new MuhasebeGenelDurumSnf();

            //Bağlantı kısmı.

            baglantiKur();

            //  ödemetürü 5 = indirim. İndirimi ayrı hesaplıyoruz.

            string sql = "SELECT SUM(t.fiyat) as toplamborc, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=" + oid + " AND odemekodu != 5) as toplamodeme," +
                " (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=" + oid + " AND odemekodu=5) as toplamindirim" +
                " FROM (" +
                "SELECT fiyat FROM tlp_defterler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid=" + oid + " ) t";




            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {



                oge.toplamborc = double.Parse("0" + oku["toplamborc"].ToString());
                oge.toplamodeme = double.Parse("0" + oku["toplamodeme"].ToString());
                oge.toplamindirim = double.Parse("0" + oku["toplamindirim"].ToString());
                oge.toplambakiye = oge.toplamborc - (oge.toplamodeme + oge.toplamindirim);



            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return oge;


        }




        public DataTable dgv_icin_getirMuhasebeGenelDurumTumListe(string oidler)
        {



            MuhasebeGenelDurumSnf oge = new MuhasebeGenelDurumSnf();

            //Bağlantı kısmı.

            baglantiKur();

            //  ödemetürü 5 = indirim. İndirimi ayrı hesaplıyoruz.

            /*
             * Bu tamamını tek seferde alıyor. Özet. Bunu yine kullanacağız. Özet bilgi vermek için kullanacağız.
            string sql = "SELECT SUM(t.fiyat) as toplamborc, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid IN (" + oidler + ") AND odemekodu != 5) as toplamodeme," +
                " (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid IN (" + oidler + ") AND odemekodu=5) as toplamindirim" +
                " FROM (" +
                "SELECT fiyat FROM tlp_defterler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid IN (" + oidler + ")  ) t";
            */

            /*
             * 
             * Bu yavaş, daha hızlı yöntem deniyoruz.
            string sql = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi," +
                " (IFNULL(e.fiyat,0) + IFNULL(f.fiyat,0) + IFNULL(g.fiyat,0) + IFNULL(h.fiyat,0) + IFNULL(i.fiyat,0) + IFNULL(j.fiyat,0) ) AS toplamBorc , " +
                " (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid AND odemekodu != 5) as toplamodeme, " +
                " (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid AND odemekodu=5) as toplamindirim " +
                " FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
                " LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
                " LEFT JOIN tlp_defterler_tbl e ON e.oid=b.oid " +
                " LEFT JOIN tlp_ekurunler_tbl f ON f.oid=b.oid " +
                " LEFT JOIN tlp_g_anadersler_tbl g ON g.oid=b.oid " +
                " LEFT JOIN tlp_g_serbestler_tbl h ON h.oid=b.oid " +
                " LEFT JOIN tlp_sosyalkulup_tbl i ON i.oid=b.oid " +
                " LEFT JOIN tlp_y_anadersler_tbl j ON j.oid=b.oid " +
                               " WHERE b.oid IN (" + oidler + ") " +
                               " GROUP BY b.oid ORDER BY b.oid";
            */



            string sql = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi," +
                " (IFNULL((SELECT SUM(fiyat) FROM tlp_defterler_tbl WHERE oid = b.oid), 0) + " +
                "IFNULL((SELECT SUM(fiyat) FROM tlp_ekurunler_tbl WHERE oid=b.oid),0) + " +
                "IFNULL((SELECT SUM(fiyat) FROM tlp_defterler_tbl WHERE oid=b.oid),0) + " +
                "IFNULL((SELECT SUM(fiyat) FROM tlp_g_anadersler_tbl WHERE oid=b.oid),0) +" +
                "IFNULL((SELECT SUM(fiyat) FROM tlp_g_serbestler_tbl WHERE oid=b.oid),0) +" +
                "IFNULL((SELECT SUM(fiyat) FROM tlp_sosyalkulup_tbl WHERE oid=b.oid),0) +" +
                "IFNULL((SELECT SUM(fiyat) FROM tlp_y_anadersler_tbl WHERE oid=b.oid),0) ) AS toplamBorc, " +
                " IFNULL((SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid AND odemekodu != 5),0) as toplamodeme, " +
                " IFNULL((SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid AND odemekodu=5),0) as toplamindirim " +
                " FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
                " LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
                               " WHERE b.oid IN (" + oidler + ") " +
                               " GROUP BY b.oid ORDER BY b.oid";



            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);
            da.SelectCommand.CommandTimeout = 1200;


            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;


        }



        public DataTable dgv_icin_getirMuhasebeGenelDurumTumListeninOzeti(string oidler)
        {

            //Bu arama listesindeki tüm kayıtların özet bilgisini verir.

            MuhasebeGenelDurumSnf oge = new MuhasebeGenelDurumSnf();

            //Bağlantı kısmı.

            baglantiKur();

            //  ödemetürü 5 = indirim. İndirimi ayrı hesaplıyoruz.

           
            string sql = "SELECT Borc, Odeme, indirim, (Borc - Odeme - indirim) as bakiye  FROM ( SELECT SUM(t.fiyat) as Borc, ifnull((SELECT SUM(tutar) FROM odemeler_tbl WHERE oid IN (" + oidler + ") AND odemekodu != 5),0) as Odeme," +
                " ifnull((SELECT SUM(tutar) FROM odemeler_tbl WHERE oid IN (" + oidler + ") AND odemekodu=5),0) as indirim " +
                " FROM (" +
                "SELECT fiyat FROM tlp_defterler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid IN (" + oidler + ")  " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid IN (" + oidler + ")  )  t ) X";
            




            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;


        }




        //Seçili hesap / Seçili müşteri / Seçili öğretmen.

        public MuhasebeGenelDurumSnf getirMuhasebeGenelDurum(int oid)
        {



            MuhasebeGenelDurumSnf oge = new MuhasebeGenelDurumSnf();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT SUM(t.fiyat) as toplamborc, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=" + oid + ") as toplamodeme FROM (" +
                "SELECT fiyat FROM tlp_defterler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid=" + oid + " " +
                "UNION ALL " +
                "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid=" + oid + " ) t";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

               

                oge.toplamborc = double.Parse("0" + oku["toplamborc"].ToString());
                oge.toplamodeme = double.Parse("0" + oku["toplamodeme"].ToString()); ;
                oge.toplambakiye = oge.toplamborc - oge.toplamodeme;

               

            }


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return oge;


        }




        public string ekle_odeme(int oid, string odenenmiktar, int odemekodu, string odemezamani, string aciklama)
        {
            //Talep tarihi now() komutuyla eklenecek. Basım tarihi basım zamanı now() ile eklenecek.

            string sonuc = metinler.islembasarili;

            long sonid = 0;


            //Mükerrer kontrolü yapmıyoruz.

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_muhasebe_odeme_tablo + " " +
                    "(oid, odemekodu, tutar, aciklama, odemetarihi, otomatiktarih) " +
                    "VALUES (" + oid + "," + odemekodu + "," + odenenmiktar + ",'" + aciklama + "', STR_TO_DATE('" + odemezamani + "', '%d.%m.%Y %H:%i:%s'), now())";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }
                else
                {

                }

                sonid = cmd.LastInsertedId;

            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            if (sonid > 0)
            {
                return sonid.ToString();
            }

            return sonuc;

        }



        public DataTable dgv_icin_muhasebe_tum_odemeleri_getir(int oid)
        {


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT b.odemeturu, a.tutar, a.odemetarihi, a.aciklama FROM " + metinler.neyebakalim_muhasebe_odeme_tablo + " a LEFT JOIN sis_odemeturu_tbl b ON a.odemekodu=b.odemekodu WHERE a.oid=" + oid + " ORDER BY a.odemetarihi";


            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglantisi);



            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }




        public DataTable dgv_icin_muhasebe_tum_borclanmalari_getir(int oid)
        {



            DataTable dt = new DataTable();

            //Kendimiz datatable oluşturup dgv'ye onu göndereceğiz. Alt alta olması için.
            dt.Columns.Add("Materyal Türü");
            dt.Columns.Add("Toplam Tutar");



            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            string sql = "SELECT SUM(fiyat) as Y_Plan," +
                " (SELECT SUM(fiyat) FROM tlp_g_anadersler_tbl WHERE oid=" + oid + ") as G_Plan," +
                " (SELECT SUM(fiyat) FROM tlp_g_serbestler_tbl WHERE oid=" + oid + ") as G_Secmeli," +
                " (SELECT SUM(fiyat) FROM tlp_ekurunler_tbl WHERE oid=" + oid + ") as EK_CD_PDF," +
                " (SELECT SUM(fiyat) FROM tlp_sosyalkulup_tbl WHERE oid=" + oid + ") as Kulup," +
                " (SELECT SUM(fiyat) FROM tlp_defterler_tbl WHERE oid=" + oid + ") as Defterler " +
                "FROM tlp_y_anadersler_tbl WHERE oid=" + oid;


            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);
            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                var dr = dt.NewRow();

                dr[0] = "Yıllık Plan";
                dr[1] = oku["Y_Plan"].ToString();

                dt.Rows.Add(dr);

                //__

                var dr2 = dt.NewRow();

                dr2[0] = "Günlük Plan";
                dr2[1] = oku["G_Plan"].ToString();

                dt.Rows.Add(dr2);

                //__

                var dr3 = dt.NewRow();

                dr3[0] = "Seçmeli Dersler";
                dr3[1] = oku["G_Secmeli"].ToString();

                dt.Rows.Add(dr3);

                //__

                var dr4 = dt.NewRow();

                dr4[0] = "Ek Ürünler (PDF vb)";
                dr4[1] = oku["EK_CD_PDF"].ToString();

                dt.Rows.Add(dr4);

                //__

                var dr5 = dt.NewRow();

                dr5[0] = "Sosyal Kulüp";
                dr5[1] = oku["Kulup"].ToString();

                dt.Rows.Add(dr5);


                //__

                var dr6 = dt.NewRow();

                dr6[0] = "Defterler";
                dr6[1] = oku["Defterler"].ToString();

                dt.Rows.Add(dr6);


            }


            baglantikapat(mysqlbaglantisi);


            return dt;

        }








        //Excelden bilgi verileri için sütun başlıklarını VT'den okuyalım.

        public ExcelSutunEslestir_Bilgi_Snf excelsutunbasliklari_bilgi()
        {

            ExcelSutunEslestir_Bilgi_Snf verisnf = new ExcelSutunEslestir_Bilgi_Snf();

            baglantiKur();

            string sql = "SELECT * FROM sis_excel_bilgisutunlari_tbl";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
            
                verisnf.bayikodu_stn = int.Parse(oku["bayikodu"].ToString());
                verisnf.aciklama_stn = int.Parse(oku["aciklama"].ToString());
                verisnf.okulkodu_stn = int.Parse(oku["okulkodu"].ToString());
                verisnf.il_stn = int.Parse(oku["il"].ToString());
                verisnf.ilce_stn = int.Parse(oku["ilce"].ToString());
                verisnf.okuladi_stn = int.Parse(oku["okuladi"].ToString());
                verisnf.sinif_stn = int.Parse(oku["sinif"].ToString());
                verisnf.sube_stn = int.Parse(oku["sube"].ToString());
                verisnf.adisoyadi_stn = int.Parse(oku["adisoyadi"].ToString());
                verisnf.bransgorevi_stn = int.Parse(oku["gorevi"].ToString());
                verisnf.muduradi_stn = int.Parse(oku["muduradi"].ToString());
                verisnf.mudurunvani_stn = int.Parse(oku["mudurunvani"].ToString());
                verisnf.eposta_stn = int.Parse(oku["eposta"].ToString());
                verisnf.telefon_stn = int.Parse(oku["telefon"].ToString());

                //Notumuzu defter talebinde kullanıyoruz.
                verisnf.notumuz_stn = int.Parse(oku["notumuz"].ToString());


            }



            baglantikapat(mysqlbaglantisi);

            return verisnf;

        }





        public string tamamen_sil_secili_tablodaki_verileri(int oid, string tablo_adi)
        {

            string sonuc = metinler.islembasarili;

            baglantiKur();
            

            try
            {

                string sql = "DELETE FROM " + tablo_adi + " " +
                    "WHERE oid=" + oid;


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }



            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);



            return sonuc;
        }





        //ARAMA İŞLEMLERİ.
        public DataTable ara_dgv_icin_plan_turune_gore_XX(String yili, bool yillik, bool gunluk, bool basilmis, bool basilmamis)
        {

            // muhasebeeklemedenemesi yaptık. 

            /*
            string sqlmuhasebe = "SELECT SUM(t.fiyat) as toplamborc, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=" + oid + ") as toplamodeme FROM (" +
               "SELECT fiyat FROM tlp_defterler_tbl WHERE oid=" + oid + " " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid=" + oid + " " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid=" + oid + " " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid=" + oid + " " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid=" + oid + " " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid=" + oid + " ) t";
            */


            baglantiKur();

            //    string sql = "SELECT * FROM " + metinler.neyebakalim_y_anaders_tablo + " WHERE oid=" + oid;
            // string sql1 = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi FROM " + metinler.neyebakalim_y_anaders_tablo + " a LEFT JOIN sis_serbestetkinlikler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili + "' AND oid=" + oid;

            /*
            string sql1 = "SELECT b.oid, b.adisoyadi, b.il, b.ilce, b.okuladi, b.sinif, b.sube FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
                "LEFT JOIN " + metinler.neyebakalim_y_anaders_tablo  + " y ON y.oid=b.oid " +
                "LEFT JOIN " +  metinler.neyebakalim_g_anaders_tablo + " g ON g.oid=b.oid " +
                " WHERE b.yili='" + yili + "' GROUP BY b.oid";
            */


            /*
             LEFT JOIN (SELECT (toplamborc) as bakiye FROM SELECT SUM(t.fiyat) as toplamborc, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid) as toplamodeme FROM (" +
               "SELECT fiyat FROM tlp_defterler_tbl WHERE oid=b.oid " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid=b.oid " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid=b.oid " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid=b.oid " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid=b.oid " +
               "UNION ALL " +
               "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid=b.oid) t) x ON x.bakiye>-1
            */



            /*

            string sql1 = "SELECT b.oid, b.adisoyadi, b.il, b.ilce, b.okuladi, b.sinif, b.sube, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid) as toplamodeme, (SELECT SUM(t.fiyat) FROM (" +
   "SELECT fiyat FROM tlp_defterler_tbl WHERE oid=96 " +
   "UNION ALL " +
   "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid=96 " +
   "UNION ALL " +
   "SELECT fiyat FROM tlp_g_anadersler_tbl WHERE oid=96 " +
   "UNION ALL " +
   "SELECT fiyat FROM tlp_g_serbestler_tbl WHERE oid=96 " +
   "UNION ALL " +
   "SELECT fiyat FROM tlp_sosyalkulup_tbl WHERE oid=96 " +
   "UNION ALL " +
   "SELECT fiyat FROM tlp_y_anadersler_tbl WHERE oid=96) t) as toplamborc FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
   "LEFT JOIN " + metinler.neyebakalim_y_anaders_tablo + " y ON y.oid=b.oid " +
   "LEFT JOIN " + metinler.neyebakalim_g_anaders_tablo + " g ON g.oid=b.oid " +
   " WHERE b.yili='" + yili + "' GROUP BY b.oid";

            */

            /*
    string sql = "SELECT b.oid, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid) as totalpaid, (SELECT SUM(t.fiyat) FROM (" +
   "SELECT fiyat FROM tlp_defterler_tbl WHERE oid=96 " +
   "UNION ALL " +
   "SELECT fiyat FROM tlp_ekurunler_tbl WHERE oid=96) t) as totalreceipt " +
   "FROM table_info_b b " +
   " WHERE b.yili='2022' GROUP BY b.oid";
            */

            /*
            string sql1 = "SELECT b.oid, (SELECT SUM(tutar) FROM odemeler_tbl WHERE oid=b.oid) as totalpaid,  " +
                " (SELECT SUM(fiyat) FROM tlp_defterler_tbl WHERE oid=b.oid) as f1," +
   "(SELECT SUM(fiyat) FROM tlp_ekurunler_tbl WHERE oid=b.oid) as f2, " +
   "(SELECT SUM(fiyat) FROM tlp_g_anadersler_tbl WHERE oid=b.oid) as f3, " +
   "(SELECT SUM(fiyat) FROM tlp_g_serbestler_tbl WHERE oid=b.oid) as f4, " +
   "(SELECT SUM(fiyat) FROM tlp_sosyalkulup_tbl WHERE oid=b.oid) as f5, " +
   "(SELECT SUM(fiyat) FROM tlp_y_anadersler_tbl WHERE oid=b.oid) as f6   FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
   " WHERE b.yili='" + yili + "' GROUP BY b.oid";
            */

            
            string sql1 = "SELECT b.oid, b.adisoyadi, b.il, b.ilce, b.okuladi, b.sinif, b.sube FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
                "LEFT JOIN " + metinler.neyebakalim_y_anaders_tablo + " y ON y.oid=b.oid " +
                "LEFT JOIN " + metinler.neyebakalim_g_anaders_tablo + " g ON g.oid=b.oid " +
                " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' GROUP BY b.oid";
            

                string sql2 = " ";
    string sql3 = " ";
    string sql4 = " ";

    string sql_son = sql1;





    MySqlDataAdapter da = new MySqlDataAdapter(sql_son, mysqlbaglantisi);



    DataTable dt = new DataTable();
    da.Fill(dt);


    baglantikapat(mysqlbaglantisi);


    return dt;

    }


        public DataTable ara_dgv_icin_plan_turune_gore(String yili, bool plantumu, bool planyillik, bool plangunluk, bool durumtumu, bool basilmis, bool basilmamis)
        {


           

            string basimdurumu;
            string basimdurumu_ikili = " ";

            //Eğer 2 türlü seçim istenmişse o zaman 2 farklı where cümlesi kullanacağız.
            
            if (durumtumu)
            {
                basimdurumu = " ";

            } else if (basilmis)
            {
                basimdurumu = " WHERE basimtarihi IS NOT NULL ";

                basimdurumu_ikili = " WHERE x.basimtarihi IS NOT NULL AND y.basimtarihi IS NOT NULL ";

            } else
            {
                //Basılmamışlar isteniyorsa.
                basimdurumu = " WHERE basimtarihi IS NULL ";
                basimdurumu_ikili = " WHERE x.basimtarihi IS NULL AND y.basimtarihi IS NULL ";
            }


            
            string sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi, b.kayittarihi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
              " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' AND b.oid IN (SELECT oid FROM " + metinler.neyebakalim_y_anaders_tablo + " " + basimdurumu + " " +
              " UNION ALL " +
              " SELECT oid FROM " + metinler.neyebakalim_g_anaders_tablo + " " + basimdurumu + " )" +
              "   GROUP BY b.oid LIMIT 100 ";
           
           

            /*
            int[] idler = { 1, 2, 3, 4, 5, 6 };

            string sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
              " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' AND b.oid IN (" + idler + ")" +
              "   GROUP BY b.oid LIMIT 100 ";
            */




            /*
           string icsorgu = "SELECT y.oid FROM " + metinler.neyebakalim_y_anaders_tablo + " y " +
            " INNER JOIN " + metinler.neyebakalim_g_anaders_tablo + " x " + basimdurumu_ikili;


           string sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
            " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' AND b.oid IN (" + icsorgu + ")" +
            "    ";

            */



            if (planyillik)
            {
                sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi, b.kayittarihi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
                                " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND  b.yili='" + yili + "' AND b.oid IN (SELECT oid FROM " + metinler.neyebakalim_y_anaders_tablo + " " + basimdurumu + ") " +
                                "    ORDER BY b.oid";

            } else if (plangunluk)
            {
                sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi, b.kayittarihi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
                                " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND  b.yili='" + yili + "' AND b.oid IN (SELECT oid FROM " + metinler.neyebakalim_g_anaders_tablo + " " + basimdurumu + ") " +
                                "    ORDER BY b.oid";
            }

           

            /*
            string sql1 = "SELECT oid FROM " + metinler.neyebakalim_y_anaders_tablo + " y WHERE y.basimtarihi IS NULL " +
                " UNION " +
                " SELECT oid FROM " + metinler.neyebakalim_g_anaders_tablo + " g WHERE g.basimtarihi IS NOT NULL";

            */

            string sql2 = " ";
            string sql3 = " ";
            string sql4 = " ";

            string sql_son = sql1;




            baglantiKur();


            MySqlDataAdapter da = new MySqlDataAdapter(sql_son, mysqlbaglantisi);
            da.SelectCommand.CommandTimeout = 600;


            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }





        //Ek ürünleri arama ve listeleme

        public DataTable ara_dgv_icin_ekurunler_turune_gore(String yili, string tur, int tur_urunkodu, bool durumtumu, bool basilmis, bool basilmamis)
        {


            string basimdurumu;

            if (durumtumu)
            {
                basimdurumu = " ";

            }
            else if (basilmis)
            {
                basimdurumu = " WHERE basimtarihi IS NOT NULL ";

            }
            else
            {
                //Basılmamışlar isteniyorsa.
                basimdurumu = " WHERE basimtarihi IS NULL ";
            }




            //Türe göre hangi tabloya bakılacağı belirlenecek ve sonra da ona göre ürün koduyla arama yapılacak. Mesela CD 101, PDF 102 gibi.
            //Şimdilik varsayılan olarak sosyal kulüp tablosunu esas alıyoruz.

            string tabloadi = metinler.neyebakalim_sosyalkulup_tablo;
           
            if (tur == metinler.basilacak_ekurun_defter_adi || tur == metinler.basilacak_ekurun_ingilizce_defter_adi || tur == "PDF")
            {
                tabloadi = metinler.neyebakalim_ekurunler_cd_pdf_tablo;

                //CD veya PDF olunca WHERE kısmına ürün kodunu da eklemek gerekiyor.

                if (basimdurumu == " ")
                {
                    basimdurumu = basimdurumu + " WHERE urunkodu=" + tur_urunkodu;
                } else
                {
                    basimdurumu = basimdurumu + " AND urunkodu=" + tur_urunkodu;
                }


            }

                                                                                           
            //Varsaılan olarak ikisi de seçili.
            string sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi, b.kayittarihi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
                                " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' AND b.oid IN (SELECT oid FROM " + tabloadi + " " + basimdurumu + ") " +
                                "  GROUP BY b.oid  ORDER BY b.oid";


           

            string sql_son = sql1;




            baglantiKur();


            MySqlDataAdapter da = new MySqlDataAdapter(sql_son, mysqlbaglantisi);
            da.SelectCommand.CommandTimeout = 600;


            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }





        public DataTable ara_dgv_icin_defterler_turune_gore(String yili, int tur_urunkodu, bool durumtumu, bool basilmis, bool basilmamis)
        {


            string basimdurumu;

            if (durumtumu)
            {
                basimdurumu = " ";

            }
            else if (basilmis)
            {
                basimdurumu = " WHERE basimtarihi IS NOT NULL ";

            }
            else
            {
                //Basılmamışlar isteniyorsa.
                basimdurumu = " WHERE basimtarihi IS NULL ";
            }



            //Ürün yani defter seçilmişse ve Where kısmı boşsa ayarlama yapıyoruz.
            if (tur_urunkodu > 0)
            {
                if (basimdurumu == " ")
                {
                    basimdurumu = basimdurumu + " WHERE defterkodu=" + tur_urunkodu;
                }
                else
                {
                    basimdurumu = basimdurumu + " AND defterkodu=" + tur_urunkodu;
                }
            }

            //Türe göre hangi tabloya bakılacağı belirlenecek ve sonra da ona göre ürün koduyla arama yapılacak. Mesela CD 101, PDF 102 gibi.
            //Şimdilik varsayılan olarak ek ürünler tablosu esas alıyoruz.

            string tabloadi = metinler.neyebakalim_defter_tablo;



          
            //Varsaılan olarak ikisi de seçili.
            string sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi, d.defterkodu, f.defteradi, b.kayittarihi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi " +
                " LEFT JOIN " + tabloadi + " d ON d.oid=b.oid" +
                " LEFT JOIN sis_defterler_tbl f ON f.defterkodu=d.defterkodu " +
                " WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' AND b.oid IN (SELECT oid FROM " + tabloadi + " " + basimdurumu + ") ORDER BY b.oid";
                          
            //Group by demiyoruz. Kişiye kayıtlı kaç defter varsa görünsün. "  GROUP BY b.oid";




            string sql_son = sql1;




            baglantiKur();


            MySqlDataAdapter da = new MySqlDataAdapter(sql_son, mysqlbaglantisi);
            da.SelectCommand.CommandTimeout = 600;


            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }






        //BİLGİLERE GÖRE LİSTELEME EKRANI



        public DataTable ara_dgv_icin_bilgilere_gore(String yili, string iladi, string ilceadi, string okuladi, string musteriadi, string bayiadi)
        {


           
            string wheree = " LEFT JOIN sis_bayiler_tbl y ON y.bayikodu=b.bayi WHERE b.islemturu=" + Form1.ISLEM_TURU_TABLO_DEGERI + " AND b.yili='" + yili + "' AND b.il LIKE '" + iladi + "%' AND b.ilce LIKE '" + ilceadi + "%' AND okuladi LIKE '" + okuladi + "%' AND" +
                " b.adisoyadi LIKE '%" + musteriadi + "%' AND b.bayi IN (SELECT bayikodu FROM sis_bayiler_tbl WHERE bayiadi LIKE '%" + bayiadi + "%') ";
            


            //Türe göre hangi tabloya bakılacağı belirlenecek ve sonra da ona göre ürün koduyla arama yapılacak. Mesela CD 101, PDF 102 gibi.
            //Şimdilik varsayılan olarak ek ürünler tablosu esas alıyoruz.

            




            //Varsaılan olarak ikisi de seçili.             Buradaki left join biraz farklı çünkü yukarıdaki where kısmında tanımlanmış.
            string sql1 = "SELECT b.oid, b.bayi, y.bayiadi,  b.il, b.ilce, b.okuladi, b.sinif, b.sube, b.adisoyadi, b.kayittarihi FROM " + metinler.neyebakalim_bilgi_ogretmen_tablo + " b " +
                " " + wheree + " ORDER BY b.oid";

            //Group by demiyoruz. Kişiye kayıtlı kaç defter varsa görünsün. "  GROUP BY b.oid";




            string sql_son = sql1;




            baglantiKur();


            MySqlDataAdapter da = new MySqlDataAdapter(sql_son, mysqlbaglantisi);
            da.SelectCommand.CommandTimeout = 600;


            DataTable dt = new DataTable();
            da.Fill(dt);


            baglantikapat(mysqlbaglantisi);


            return dt;

        }






        //varsayılan kayıt yeri bilgilerini güncelliyoruz.
        //

        public string varsayilan_kayit_yeri_kaydet(string sutunadi_defter_plan, string yeniyol)
        {

            //Sütun adı vt tabloda tutulduğu şekliyle gelecek.
            //Defter için defter_kayit_yolu_pdf, plan için plan_kayit_yolu_pdf olmak zorunda.


            string sonuc = metinler.islembasarili;



            string sql = "UPDATE sis_varsayilanlar_tbl SET " +
                    sutunadi_defter_plan + "='" +yeniyol + "'";

           



            baglantiKur();


            try
            {

                

                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }


            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            return sonuc;

        }




        public string basimTarihini_kaydet(int oid, string basilanturudefterplangunukyillikvs, string urun_kodu_id)
        {

            //Sütun adı vt tabloda tutulduğu şekliyle gelecek.
            //Defter için defter_kayit_yolu_pdf, plan için plan_kayit_yolu_pdf olmak zorunda.


            string sonuc = metinler.islembasarili;

            string sql = "";



            if (basilanturudefterplangunukyillikvs == "yillikanaders")
            {
                sql = "UPDATE " + metinler.neyebakalim_y_anaders_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND dersid=" + int.Parse(urun_kodu_id);
            
            } else if (basilanturudefterplangunukyillikvs == "gunlukanaders")
            {
                sql = "UPDATE " + metinler.neyebakalim_g_anaders_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND dersid=" + int.Parse(urun_kodu_id);
           
            } else if (basilanturudefterplangunukyillikvs == "yillikserbest")
            {
                //Serbest etkinlik derslerinin plan basım tarihi olmayacak. Ana ders olarak SERBEST ETKİNLİKLER ekleniyor. Ona tarih basılacak.
                sql = "UPDATE " + metinler.neyebakalim_serbest_ders_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND dersid=" + int.Parse(urun_kodu_id);
            }
            else if (basilanturudefterplangunukyillikvs == "defter")
            {
                sql = "UPDATE " + metinler.neyebakalim_defter_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND defterkodu=" + int.Parse(urun_kodu_id);
            }
            else if (basilanturudefterplangunukyillikvs == "sosyalkulup")
            {
                sql = "UPDATE " + metinler.neyebakalim_sosyalkulup_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND kulupkodu=" + int.Parse(urun_kodu_id);
            }
            else if (basilanturudefterplangunukyillikvs == metinler.basilacak_ekurun_defter_adi)
            {
                sql = "UPDATE " + metinler.neyebakalim_ekurunler_cd_pdf_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND urunkodu=" + 101; // şimdilik kodu eKledik. ama vt'den almamız daha uygun olacak. int.Parse(urun_kodu_id);
            }
            else if (basilanturudefterplangunukyillikvs == metinler.basilacak_ekurun_ingilizce_defter_adi)
            {
                sql = "UPDATE " + metinler.neyebakalim_ekurunler_cd_pdf_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND urunkodu=" + 103; // şimdilik kodu eKledik. ama vt'den almamız daha uygun olacak. int.Parse(urun_kodu_id);
            }
            else if (basilanturudefterplangunukyillikvs == "OZELPDF")
            {
                sql = "UPDATE " + metinler.neyebakalim_ekurunler_cd_pdf_tablo + " SET basimtarihi=NOW() WHERE oid=" + oid + " AND urunkodu=" + 102; // şimdilik kodu eKledik. ama vt'den almamız daha uygun olacak. int.Parse(urun_kodu_id);
            }
            else
            {

                //Kapak vs. burada tanımlı olmayan ürünler için basım tarihi eklemeyeceğiz.
                return sonuc;
            }



            baglantiKur();


            try
            {



                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }


            }
            catch (Exception ex)
            {
                sonuc = metinler.yenikayit_bilinmeyenhata + " (" + ex.Message + ")";
                //  MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            baglantikapat(mysqlbaglantisi);


            yrdsnf.log_yaz(sonuc);

            return sonuc;

        }








        //Mahalli kurtuluş günlerini alalım.

        public List<string> mahallikurtulusgunubilgilerinigetir(string yeradiil, string yeradiililce)
        {
            //Arasında ; olarak kutuadı ve açıklama bilgisini döndüreceğiz. OCAK;5 Ocak Adana'nın Kurtuluşu. gibi.
            List<string> mahallikurtulusgunu = new List<string>();

            baglantiKur();

            string sql = "SELECT * FROM sis_kurtulus_tbl WHERE yeradi='" + yeradiil + "' OR yeradi='" + yeradiililce + "'";



            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {

                mahallikurtulusgunu.Add(oku["kutuadi"].ToString() + ";" + oku["aciklama"].ToString());
                
            }



            baglantikapat(mysqlbaglantisi);

            return mahallikurtulusgunu;

        }






        //TARİH EKLEME VE SİLME İŞLEMLERİ. (BASILDI OLARAK İŞARETLE GİBİ...)

        public bool isle_listeyiBasimTarihiEkle_veya_Sil(string oidler, string islemyapilacakolantablo, int ekurunsekodu, string basimtarihi, bool eklensinTrue_silinsinFalse)
        {


            ////Dolu defter ve pdf için basım tarihi eklenirken farklı bir sql cümlesi kurulacak.
           


            bool durum;

            //Bağlantı kısmı.

            baglantiKur();

            //  ödemetürü 5 = indirim. İndirimi ayrı hesaplıyoruz.

            string sql = "UPDATE " + islemyapilacakolantablo + " SET basimtarihi='" + basimtarihi + "' WHERE oid IN (" + oidler + ")";

            if (ekurunsekodu != 0)
            {
                sql = "UPDATE " + islemyapilacakolantablo + " SET basimtarihi='" + basimtarihi + "' WHERE urunkodu=" + ekurunsekodu + " AND oid IN (" + oidler + ")";
            }




            //EĞER SİLME İŞLEMİ İSE YUKARIDAKİ SQL CÜMLELERİ DEĞİŞECEK.

            if (eklensinTrue_silinsinFalse == false)
            {

                    sql = "UPDATE " + islemyapilacakolantablo + " SET basimtarihi=NULL WHERE oid IN (" + oidler + ")";

                if (ekurunsekodu != 0)
                {
                    sql = "UPDATE " + islemyapilacakolantablo + " SET basimtarihi=NULL WHERE urunkodu=" + ekurunsekodu + " AND oid IN (" + oidler + ")";
                }

            }




            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            try
            {
                object kayitbilgisi = cmd.ExecuteNonQuery();
                durum = true;

            } catch (Exception)
            {

                durum = false;

            }
           


            baglantikapat(mysqlbaglantisi);

            //Bağlantı kısımları.

            return durum;


        }









        ///Sınıf sonu.
    }
}
