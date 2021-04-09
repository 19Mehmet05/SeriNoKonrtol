using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriNoKonrtol
{
    class Base64SifreCoz
    {
        public string Coz()
        {
        Base64Sifreleme base64Sifreleme = new Base64Sifreleme();
        byte[] cozulenveri = Convert.FromBase64String(base64Sifreleme.Sıfre());
        string anametin = ASCIIEncoding.ASCII.GetString(cozulenveri);
        return anametin;
        }
    }
}
