using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materyall
{
    internal class YardimciSnf
    {

        public string ismiduzelt(string isim, string turu)
        {


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





    }
}
