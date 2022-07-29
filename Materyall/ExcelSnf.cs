using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Materyall
{
    internal class ExcelSnf
    {


        public void excelHizliSiparisAl(string secilenexcel, DataGridView dgv)
        {

            //Exceli açalım.
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ktp;
            Microsoft.Office.Interop.Excel.Worksheet syf;


            ktp = uyg.Workbooks.Open(secilenexcel);
            syf = ktp.Worksheets["talep"];


            Microsoft.Office.Interop.Excel.Range enson = syf.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);



            //Excelden başlık sütünlarını alıyoruz.

            DataTable dt = new DataTable();

            int sutunsayisi = enson.Column;

            for (int i = 0; i < sutunsayisi; i++)
            {

                string s = syf.Cells[1, i+1].Text;
                
                if (s != "")
                {
                    dt.Columns.Add(s);
                } else
                {
                    break;
                }
               

            }





            //AÇIKLAMA: Her satır bir tablo olarak gösteriliyor. O yüzden tabloları saydık ve daima 2 satırı (indeks:1) aldık.

            int satirsayisi = enson.Row;

            //  MessageBox.Show("tablo: " + satirsayisi);

            for (int r = 1; r < satirsayisi; r++)
            {
                var dr = dt.NewRow();

                for (int c = 0; c < sutunsayisi; c++)
                {

                    dr[c] = syf.Cells[r+1, c+1].Text;

                }

                dt.Rows.Add(dr);
            }


            dgv.DataSource = dt;



            ktp.Close(false);
            uyg.Quit();



            

        }






        public void adresMektupicinExceliHazirlasiparisci(Dictionary<string, string> adresMesktupBaslikDegerleri)
        {

            Metinler metinler = new Metinler();

            /*
            //Kendi mxl dosyasımı oluşturalım.
            // string ilksati = """"<?xml version="1.0" encoding="utf - 8"?>""";

            string tagac = "<bilgiler> \n <bilgi ";
            string tagkapat = "/> \n </bilgiler>";

            string aracumle = "";

            foreach (string s in adresMesktupBaslikDegerleri.Keys)
            {
                aracumle += " " + s + "=" + "\"" + adresMesktupBaslikDegerleri[s].Replace("\"","'") + "\"";

            }

            string xmlm = tagac + aracumle + tagkapat;
         //   System.IO.File.WriteAllText(metinler.siparisci_tam_yolu_xml, xmlm);
            */


            /*
            //xml deneyelim.
            adres mektup desteklemiyor.
           
            XElement el = new XElement("root",
                adresMesktupBaslikDegerleri.Select(kv => new XElement(kv.Key, kv.Value)));

            System.IO.File.WriteAllText(metinler.siparisci_tam_yolu, el.ToString());
            */


            /*
            String csv = String.Join( "", adresMesktupBaslikDegerleri.Select(d => $"{d.Key};"));

            csv += Environment.NewLine + String.Join("", adresMesktupBaslikDegerleri.Select(d => $"{d.Value};"));
            “
            System.IO.File.WriteAllText(metinler.siparisci_tam_yolu_csv, csv);
            */

            //Kendimiz yazalım.

            string bir = "";
                        string iki = "";
                        string uc = "";
                        string csv;


                       foreach (string s in adresMesktupBaslikDegerleri.Keys)
                       {
                           bir += s + "\t";
                           iki += adresMesktupBaslikDegerleri[s].Replace("“","'").Replace("”", "'").Replace("\"", "'").Replace("\t", " ").Replace("\n", "'").Replace("\r", "'").Replace("\r\n", "'") + "\t";
                            uc += "x\t";
                       }
                       


            /*
            for (int i = 1; i < 5; i++)
            {
                bir += "başlık" + i + ";";
               iki += "bilgi" + i + ";";
            }

            */

            csv = bir + "\n" + iki + "\n" + uc + "\n";

            System.IO.File.WriteAllText(metinler.siparisci_tam_yolu_csv, csv);
           




        }






        //Data gridleri excele aktarma.
        private void panoyaKopyala(DataGridView dgv)
        {
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgv.MultiSelect = true;
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }

        public void dgvExceleAktar(DataGridView dgv)
        {
            panoyaKopyala(dgv);

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            Clipboard.Clear();
        }






    } //Sınıf sonu.
}
