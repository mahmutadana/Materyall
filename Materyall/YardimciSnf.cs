using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
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



        public void bayi_logoyuKlasoreKaydet(string logoadi)
        {
            Metinler metinler = new Metinler();

            //Logoların oluşturulacağı klasör. Word logoyu bu klasördeki logo.png'den alacak.
            string logohedefklasoru = metinler.logo_wordbaglantili_klasor;


            //Eğer bir logo adı gelmişse tam yol haline getiriyoruz.
            string logomuz = metinler.logo_wordbaglantili_klasor + logoadi + ".png";

            if (logoadi == null || logoadi.Trim() == "")
            {
                //Eğer logo yoksa varsayılan logoyu kullanıyoruz. Logo ismi dolu gelirse zaten logonun tam yolu gelecek.
                logomuz = logohedefklasoru + "varsayilanbayilogosu.png";
            }



            Bitmap bitmap100d = new Bitmap(Image.FromFile(logomuz), new Size(512, 512));

            bitmap100d.Save(metinler.logo_wordbaglantili_klasor + metinler.logo_wordbaglantili_dosyaadi_bayi, System.Drawing.Imaging.ImageFormat.Png);

        }




        public int comboboxGenisligi(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

















        public void ePostaGonder(string epostamiz, string epostasifremiz, string aliciepostasi, string aliciadisoyadi, string konu, string icerik, string ekdosya)
        {

            
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress(epostamiz,"Er Yayıncılık"); // ("eposta@gmail.com");
            //
            ePosta.To.Add(aliciepostasi);
          //  ePosta.To.Add("eposta2@gmail.com");
          //  ePosta.To.Add("eposta3@gmail.com");
            //
            ePosta.Attachments.Add(new Attachment(ekdosya));// (@"C:\deneme-upload.jpg")) ;
            //
            ePosta.Subject = konu;
            //
            ePosta.Body = icerik;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential(epostamiz, epostasifremiz); // ("eposta@gmail.com", "sifre");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                // smtp.SendAsync(ePosta, (object)ePosta);
                smtp.Send(ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
          //  return kontrol;

            




            /*
            //Diğer yöntem

            var fromAddress = new MailAddress(epostamiz, "ER YAYIN GAZİANTEP");
            var toAddress = new MailAddress(aliciepostasi, aliciadisoyadi);
          //  const string fromPassword = epostasifremiz;
          //  const string subject = konu;
          //  const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, epostasifremiz)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = konu,
                Body = icerik
               
            })
            {
                smtp.Send(message);
            }
            */

            /*
            //BAŞKA DİĞER YÖNTEM

            String SendMailFrom = epostamiz;
            String SendMailTo = aliciepostasi;
            String SendMailSubject = "Email Subject";
            String SendMailBody = "Email Body";

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage email = new MailMessage();
                // START
                email.From = new MailAddress(SendMailFrom);
                email.To.Add(SendMailTo);
                email.CC.Add(SendMailFrom);
                email.Subject = SendMailSubject;
                email.Body = SendMailBody;
                //END
                SmtpServer.Timeout = 5000;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential(SendMailFrom, epostasifremiz);
                SmtpServer.Send(email);

                Console.WriteLine("Email Successfully Sent");
             //   Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               // Console.ReadKey();
            }
            */


        }


        //Sınıf sonu.
    }
}
