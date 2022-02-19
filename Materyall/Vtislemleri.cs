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

        public string[] eoyillari()
        {
            List<string> list = new List<string>();

            //Bağlantı kısmı.

            baglantiKur();

            string sql = "SELECT * FROM sis_yillar_tbl ORDER BY id DESC";

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










        // KAYIT İŞLEMLERİ.....

        //Yeni Kayıt işlemi.
        //Öğretmen bilgilerini ve talepleri kaydedeceğiz. Öncelikle öğretmen bilgilerini kaydedeceğiz,
        //sonra buna talep bilgilerini ekleyeceğiz. Güncelle derse aktif öğretmen verilerini değiştireceğiz. Yeni kayıt derse öğretmen bilsini
        // de ekleyeceğiz. (inşallah)

        public string yeniKayit(ogretmenBilgileriSnf ogtblg)
        {
            string sonuc = metinler.islembasarili;

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
                    + "','" + ogtblg.telefon + "','" + ogtblg.eposta + "','" + ogtblg.adres + "','" + ogtblg.aciklama + "'," + ogtblg.bayikodu + ",'" + ogtblg.bayilogo + "')";


                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglantisi);

                object kayitbilgisi = cmd.ExecuteNonQuery();


                if (kayitbilgisi == null)
                {

                    sonuc = metinler.yenikayit_bilinmeyenhata;

                }

            } catch (Exception ex)
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




        public okulbilgileri okulbilgisinigetir_kurumkodundan(string kurumkodu)
        {

            okulbilgileri okulbilgisi = new okulbilgileri();


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























    }
}
