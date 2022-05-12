using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Gelen başlıkları 1. satıra, değerleri 2. satıra yazarak bir excel belgesi oluşturuyoruz. (Eski siparişçi) Adı siparisci2022.xls olabilir.

            //Exceli açalım.
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ktp;
            Microsoft.Office.Interop.Excel.Worksheet syf;


            ktp = uyg.Workbooks.Open(metinler.siparisci_tam_yolu);
            syf = ktp.Worksheets["Sayfa1"];


            syf.Cells.ClearContents();
            int sutunsayac = 1;

            foreach (string s in adresMesktupBaslikDegerleri.Keys)
            {
                syf.Cells[1, sutunsayac] = s;
                syf.Cells[2,sutunsayac] = adresMesktupBaslikDegerleri[s];

                sutunsayac++;
            }


            ktp.Close(true);
            uyg.Quit();

        }






    } //Sınıf sonu.
}
