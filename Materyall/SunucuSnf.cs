using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;

namespace Materyall
{
    internal class SunucuSnf
    {




        //Sunucudan talepleri al.
        public void sunucudanTalepleriAl_Listele(DataGridView  dgv)
        {

            string adressunucu = "http://eryayin.com/yonetim/tumsiparisler.php";

             GetSourceCode(adressunucu, dgv);

           


        }


        static void GetSourceCode(string url, DataGridView dgv)
        {
            
            // web isteği oluştur
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            // gelen cevabı al
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            // cevapla gelen veriyi oku
            using (StreamReader sRead = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
            {


                HTMLDocument doc = new HTMLDocument();
                IHTMLDocument2 doc2 = (IHTMLDocument2)doc;
                doc2.write(sRead.ReadToEnd());

                //  string ilkbaslik = doc.getElementsByTagName("table").item (0).rows(1).cells(1).InnerText;

                DataTable dt = new DataTable();

                int sutunsayisi = doc.getElementsByTagName("table").item(0).rows(0).cells.length;

                for (int i = 0;i< sutunsayisi; i++)
                {

                    dt.Columns.Add(doc.getElementsByTagName("table").item(0).rows(0).cells(i).InnerText);
                        
                }


                //AÇIKLAMA: Her satır bir tablo olarak gösteriliyor. O yüzden tabloları saydık ve daima 2 satırı (indeks:1) aldık.

                int satirsayisi = doc.getElementsByTagName("table").length;

              //  MessageBox.Show("tablo: " + satirsayisi);

                for (int r = 0; r < satirsayisi; r++)
                {
                    var dr = dt.NewRow();

                    for (int c = 0; c < sutunsayisi; c++)
                    {

                        
                        dr[c] = (doc.getElementsByTagName("table").item(r).rows(1).cells(c).InnerText);
                        
                    }

                    dt.Rows.Add(dr);
                }


                dgv.DataSource = dt;



            }
            
            





        }


        /*
         DataTable dt = new DataTable();
        dt.Columns.Add("sr_no");
        dt.Columns.Add("item_name");
        dt.Columns.Add("item_id");
        dt.Columns.Add("qty");
        dt.Columns.Add("rate");
        dt.Columns.Add("total");

        var dr = dt.NewRow();
        dr["sr_no"] = txtSr.Text;
        dr["item_name"] = ddlItem.SelectedItem.Text;
        dr["item_id"] = ddlItem.SelectedValue;
        dr["qty"] = txtQty.Text;
        dr["rate"] = txtRate.Text;
        dr["total"] = int.Parse(txtQty.Text) * int.Parse(txtRate.Text);

        dt.Rows.Add(dr);
         */




    }
}
