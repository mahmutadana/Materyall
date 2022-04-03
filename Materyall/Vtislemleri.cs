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

            string sql = "SELECT DISTINCT(ilce) as veri FROM tlp_ogretmenbilgileri_tbl WHERE il='" + il + "' ORDER BY veri";

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

        public string yeniKayit(OgretmenBilgileriSnf ogtblg)
        {
            string sonuc = metinler.islembasarili;

            long sonid = 0;

           if (bukayitdahaoncedenvarmi(ogtblg.kurumkodu, ogtblg.sinifi, ogtblg.subesi, ogtblg.adisoyadi))
            {
                sonuc = metinler.mukerrerkayitbilgisiogretmen;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO tlp_ogretmenbilgileri_tbl (yili, adisoyadi, brans, il, ilce, kurumkodu, okuladi, sinif, sube, " +
                    "muduradi, mudurunvani, cep, eposta, adres, aciklama, bayi,logoadi) " +
                    "VALUES ('" + ogtblg.yili + "','" + ogtblg.adisoyadi + "','" + ogtblg.bransi + "','" + ogtblg.ili + "','" + ogtblg.ilcesi + "','" +
                    ogtblg.kurumkodu + "','" + ogtblg.okuladi + "'," + ogtblg.sinifi + ",'" + ogtblg.subesi + "','" + ogtblg.muduradi + "','" + ogtblg.mudurunvani
                    + "','" + ogtblg.telefon + "','" + ogtblg.eposta + "','" + ogtblg.adres + "','" + ogtblg.aciklama + "'," + ogtblg.bayikodu + ",'" + ogtblg.ogretmenlogo + "')";


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
                    "yili='" + ogtblg.yili + "', " +
                    "adisoyadi='" + ogtblg.adisoyadi + "', " +
                    "brans='" + ogtblg.bransi + "', " +
                    "il='" + ogtblg.ili + "', " +
                    "ilce='" + ogtblg.ilcesi + "', " +
                    "kurumkodu='" + ogtblg.kurumkodu + "', " +
                    "okuladi='" + ogtblg.okuladi + "', " +
                    "sinif=" + ogtblg.sinifi + ", " +
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





        private bool bukayitdahaoncedenvarmi(string kurumkodu, int sinif, string sube, string adisoyadi)
        {

            string adet = "0";

            baglantiKur();

            string sql = "SELECT COUNT(*) as adet FROM tlp_ogretmenbilgileri_tbl WHERE kurumkodu='" + kurumkodu + "' AND sinif=" + sinif + " AND sube='" + sube + "' AND adisoyadi='" + adisoyadi + "'";



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

            string sql = "SELECT * FROM tlp_ogretmenbilgileri_tbl WHERE oid=" + musterino + " LIMIT 1";



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
                ogrblg.sinifi = int.Parse(oku["sinif"].ToString());
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

            string sql = "SELECT il, ilce, okuladi, muduradi, mudurunvani FROM tlp_ogretmenbilgileri_tbl WHERE kurumkodu='" + kurumkodu + "' ORDER BY kayittarihi LIMIT 1";



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



        public bool ek_urun_talepEdilmismi(int oid, int urunkodu)
        {

            return bu_talep_dahaoncedenvarmi(oid, urunkodu, metinler.neyebakalim_ekurunler_cd_pdf_tablo, metinler.neyebakalim_ekurunler_cd_pdf_urunid_adi);

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
            string sql = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_y_anaders_tablo + " a LEFT JOIN sis_tumdersler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili +"' AND oid=" + oid;


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
            string sql = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_g_anaders_tablo + " a LEFT JOIN sis_tumdersler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili + "' AND oid=" + oid;


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

            if (bu_talep_dahaoncedenvarmi(oid, dersid, metinler.neyebakalim_s_ders_tablo, metinler.neyebakalim_s_ders_urunid_adi))
            {
                sonuc = metinler.mukerrerkayitbilgisitalep;

                return sonuc;
            }


            //Mükerrer değil, devam edelim. (Yeni kayıt)

            baglantiKur();


            try
            {

                string sql = "INSERT INTO " + metinler.neyebakalim_s_ders_tablo + " " +
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

                string sql = "DELETE FROM " + metinler.neyebakalim_s_ders_tablo + " " +
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
            string sql = "SELECT b.dersadi, a.dersid, a.taleptarihi, a.basimtarihi FROM " + metinler.neyebakalim_s_ders_tablo + " a LEFT JOIN sis_serbestetkinlikler_tbl b ON a.dersid=b.dersid WHERE b.yil='" + yili + "' AND oid=" + oid;


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
            string sql = "SELECT b.defteradi, a.defterkodu, a.taleptarihi, a.basimtarihi, a.fiyat FROM " + metinler.neyebakalim_defter_tablo + " a LEFT JOIN sis_defterler_tbl b ON a.defterkodu=b.defterkodu WHERE b.yil='" + yili + "' AND oid=" + oid;


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
            string sql = "SELECT ogretmenadi FROM " + metinler.neyebakalim_digerzumreogretmenleri_tablo + "  WHERE oid=" + oid;


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



    }
}
