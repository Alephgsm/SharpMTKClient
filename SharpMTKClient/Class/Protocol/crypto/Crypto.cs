using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.crypto
{
    public class Crypto
    {
        public static byte[] AESDecrypt(byte[] key, CipherMode mode, byte[] IV, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] AESEncrypt(byte[] key, CipherMode mode, byte[] IV, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}