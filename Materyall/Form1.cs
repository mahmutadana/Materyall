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
    }






}
