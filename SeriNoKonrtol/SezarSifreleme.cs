using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SeriNoKonrtol
{
   public  class SezarSifreleme
    {
        int sayac1 = 1;
        string result = null;
        public string Sıfre()
        {
         
            string veri = Islem.Value();
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
                if (sayac1 % 4 == 0)
                {
                    result += "-";
                }
                result += Convert.ToChar(eleman+3).ToString();
                sayac1++;
            }
            return result;
        }
        public static string KarakterSayDusur()
        {
            int sayac1 = 1;
            string result = null;
            string veri = Islem.Value();
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
                if (sayac1 % 4 == 0)
                {
                    result += "-";
                }
                result += Convert.ToChar(eleman + 3).ToString();
                sayac1++;
            }
            string  dusur = result.Substring(9,16);
            result = dusur;
            return result;
        }
    }
}
