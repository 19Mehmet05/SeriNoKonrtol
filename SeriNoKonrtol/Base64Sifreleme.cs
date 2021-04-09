using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriNoKonrtol
{
    public  class Base64Sifreleme
    {
        public  string Sıfre()
        {
            string anametin=Islem.Value();
            byte[] veridizisi = ASCIIEncoding.ASCII.GetBytes(anametin);
            string sifrelimetin=Convert.ToBase64String(veridizisi);
            return sifrelimetin;
        }

    }
}
