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

            lbl_bekleyin.Text = "Veriler alınıyor...";
               

            SunucuSnf sunucuSnf = new SunucuSnf ();

            sunucuSnf.sunucudanTalepleriAl_Listele(datagridSunucuTalepleri);


            lbl_bekleyin.Text = "İşlem bitti. (" + datagridSunucuTalepleri.Rows.Count + ")";

        }

        private void btn_varsayilanlariguncelle_Click(object sender, EventArgs e)
        {

           


        }

        private void bt_yenikayit_Click(object sender, EventArgs e)
        {
            yeniKayitYap();
        }



        private void yeniKayitYap()
        {

            ogretmenBilgileriSnf ogrblg = new ogretmenBilgileriSnf ();

            ogrblg.yili = cb_yili.Text;
            ogrblg.adisoyadi = tb_bilgi_adisoyadi.Text;
            ogrblg.bransi = cb_bilgi_bransi.Text;

            ogrblg.ili = cb_bilgi_ili.Text;
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

            ogrblg.bayikodu = tb_bilgi_bayikodu.Text;
            ogrblg.bayiadi = cb_bilgi_bayiadi.Text;



           MessageBox.Show (  vtislemleri.yeniKayit(ogrblg));

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

            okulbilgileri okulbilgileri = vtislemleri.okulbilgisinigetir_kurumkodundan(tb_bilgi_okulkodu.Text);


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



        //Sınıf sonu.
    }






}
