using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materyall
{
    public partial class Form1 : Form
    {

        Vtislemleri vtislemleri = new Vtislemleri();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          string[] yillar =  vtislemleri.eoyillari();



            foreach (string s in yillar)
            {
              //  MessageBox.Show(s, "yillar");
                cb_yili.Items.Add(s);
            }

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
            sunucudanTalepleriAl_Listele();
        }











        //Sunucudan talepleri al.
        private void sunucudanTalepleriAl_Listele()
        {

            string adressunucu = "http://eryayin.com/yonetim/tumsiparisler.php";

            sunucudangelenmetin.Text = GetSourceCode(adressunucu);

        }


        static string GetSourceCode(string url)
        {
            // web isteği oluştur
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            // gelen cevabı al
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            // cevapla gelen veriyi oku
            using (StreamReader sRead = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
            {
                // veriyi döndür
                return sRead.ReadToEnd();
            }
        }

    }


   



}
