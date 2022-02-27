﻿using System;
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


            //Türü isim ise son kelime büyük, ilçr ise sadece ilk harfi büyük olacak.

            isim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(isim.Trim());

            if (turu == "ilce")
            {
                return isim;
            }


            string ad;
            string soyad;


            int sonbosluk = isim.LastIndexOf(" ");

            ad = isim.Substring(0, sonbosluk);
            soyad = isim.Substring(sonbosluk);

            soyad = soyad.ToUpper();

            return ad + soyad;

        }





    }
}
