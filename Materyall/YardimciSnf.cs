using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materyall
{
    internal class YardimciSnf
    {


        public static TextBox TB_LOG_KAYITLARI;

        public void log_yaz(string metin)
        {
            TB_LOG_KAYITLARI.Text = DateTime.Now.ToString() + "     " +  metin  + Environment.NewLine + TB_LOG_KAYITLARI.Text;
        }




        public string ismiduzelt(string isim, string turu)
        {

            if (isim == null)
            {
                return null;
            }

            //Türü isim ise son kelime büyük, ilçr ise sadece ilk harfi büyük olacak. Tamamı büyükse işlem yapmıyor. O yüzden önce küçüğe çevirdik.
            isim = CultureInfo.CurrentCulture.TextInfo.ToLower(isim.Trim());
            isim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isim.Trim());

            if (turu == "ilce")
            {
                return isim;
            }


            string ad;
            string soyad;


            int sonbosluk = isim.LastIndexOf(" ");

            if (sonbosluk != -1) {

            ad = isim.Substring(0, sonbosluk);
            soyad = isim.Substring(sonbosluk);

            soyad = soyad.ToUpper();
           

            return ad + soyad;
            } else
            {
                return isim;
            }

        }




        public void logoyuKlasoreKaydet(string logoadi)
        {
            Metinler metinler = new Metinler();
            
            //Logoların oluşturulacağı klasör. Word logoyu bu klasördeki logo.png'den alacak.
            string logohedefklasoru = metinler.logo_wordbaglantili_klasor;


            //Eğer bir logo adı gelmişse tam yol haline getiriyoruz.
            string logomuz = metinler.logo_wordbaglantili_klasor + logoadi;

            if (logoadi == null || logoadi.Trim() == "")
            {
                //Eğer logo yoksa varsayılan logoyu kullanıyoruz. Logo ismi dolu gelirse zaten logonun tam yolu gelecek.
                logomuz = logohedefklasoru + "meb_logo.png";
            }
            


            Bitmap bitmap100d = new Bitmap(Image.FromFile(logomuz), new Size(512, 512));

            bitmap100d.Save(metinler.logo_wordbaglantili_klasor + metinler.logo_wordbaglantili_dosyaadi, System.Drawing.Imaging.ImageFormat.Png);

        }








        //Sınıf sonu.
    }
}
