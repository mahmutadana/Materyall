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



            verileriVtYeKaydet(dgv);

        }





        private void verileriVtYeKaydet(DataGridView dgv)
        {

            MessageBox.Show(dgv.Rows.Count.ToString(), "Satır");


            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow dr = dgv.Rows[i];
                if (dr.Cells[1].ToString() != "")
                {
                    MessageBox.Show(dr.Cells[1].Value.ToString(), "1. hücre");
                }
            }




        }





    } //Sınıf sonu.
}
