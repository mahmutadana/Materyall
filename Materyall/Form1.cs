using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }


   



}
