using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriNoKonrtol
{
    public  class SezarSifreCoz
    {
        SezarSifreleme sezarSifreleme = new SezarSifreleme();
        string result = null;
        public string Coz()
        {
            string veri = sezarSifreleme.Sıfre();
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
               
                result += Convert.ToChar(eleman - 3).ToString();
                
            }
            return result;
        }
    }
}
