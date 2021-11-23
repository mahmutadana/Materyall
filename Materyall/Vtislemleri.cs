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

        private void baglantiyikapat (MySqlConnection connection)
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


            return list.ToArray();

        }








    }
}
