using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SeriNoKonrtol
{
    public class AesSifreleCoz
    {
        
        private const string Aes_Sunucu=@"!&+QWSDF!123126+";
        private string Aes_Key=SezarSifreleme.KarakterSayDusur();
        AesCryptoServiceProvider aesSaglayici = new AesCryptoServiceProvider();
        public string AesSifrele(string metin)
        {
            
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;

            aesSaglayici.IV = Encoding.UTF8.GetBytes(Aes_Sunucu);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(Aes_Key);
            aesSaglayici.Mode = CipherMode.CBC;
            aesSaglayici.Padding = PaddingMode.PKCS7;

            byte[] kaynak = Encoding.Unicode.GetBytes(metin);
            using (ICryptoTransform sifrele = aesSaglayici.CreateEncryptor())
            {
                byte[] hedef = sifrele.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Convert.ToBase64String(hedef);
            }
        }
        public string AesSifre_Coz(string sifrelimetin)
        {
            
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;

            aesSaglayici.IV = Encoding.UTF8.GetBytes(Aes_Sunucu);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(Aes_Key);
            aesSaglayici.Mode = CipherMode.CBC;
            aesSaglayici.Padding = PaddingMode.PKCS7;

            byte[] kaynak =System.Convert.FromBase64String(sifrelimetin);
            using (ICryptoTransform sifrelecoz = aesSaglayici.CreateDecryptor())
            {
                byte[] hedef = sifrelecoz.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Encoding.Unicode.GetString(hedef);
            }

        }
    }
}
