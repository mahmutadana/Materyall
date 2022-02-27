using System;
using System.Collections.Generic;
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

            string sql = "SELECT DISTINCT(yili) as yil FROM tlp_ogretmenbilgileri_tbl ORDER BY yil";

            MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

            MySqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                list.Add (oku["yil"].ToString());

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

            string sql = "SELECT DISTINCT(brans) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";

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

            string sql = "SELECT DISTINCT(mudurunvani) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";

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



        public string[] filtre_siniflar()
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT DISTINCT(sinif) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";

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


        public List<FiltrelenenSosyalKulupler> filtre_sosyalkulupler(string ucretgrubu)
        {

            //Bayi kodundan fiyat bölümünü alacağız.

            List<FiltrelenenSosyalKulupler> list = new List<FiltrelenenSosyalKulupler>();

            //Bağlantı kısmı.

            baglantiKur();

            //  string sql = "SELECT DISTINCT(il) as veri FROM tlp_ogretmenbilgileri_tbl ORDER BY veri";
            string sql = "SELECT * FROM sis_sosyalkulupler_tbl ORDER BY kulupadi";



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





        public string[] filtre_tumdersler(string yil, string iladi)
        {

            if (yil == "" || iladi == "")
            {
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
                sonuc = metinler.mukerrerkayitbilgisi;

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






        //Bilgi getir / göster işlemi.

        public OgretmenBilgileriSnf ogretmenBilgisiGetir(string musterino)
        {

            OgretmenBilgileriSnf ogrblg = new OgretmenBilgileriSnf();

            ogrblg.adisoyadi = "KAYIT BULUNAMADI";


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





















    }
}
