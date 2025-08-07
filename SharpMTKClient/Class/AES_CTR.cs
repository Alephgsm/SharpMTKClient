using System;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace SharpMTKClient.Class
{
    public sealed class AES_CTR : IDisposable
    {
        public static readonly int[] allowedKeyLengths = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int allowedCounterLength = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int ivLength = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int processBytesAtTime = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readonly byte[] counter = new byte[16];
        private readonly ICryptoTransform counterEncryptor;
        private bool isDisposed;
        private readonly bool isLittleEndian;
        public AES_CTR(byte[] key, byte[] initialCounter, bool littleEndian = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void EncryptBytes(byte[] output, byte[] input, int numBytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void EncryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public async Task EncryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void EncryptBytes(byte[] output, byte[] input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] EncryptBytes(byte[] input, int numBytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] EncryptBytes(byte[] input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] EncryptString(string input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void DecryptBytes(byte[] output, byte[] input, int numBytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void DecryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public async Task DecryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void DecryptBytes(byte[] output, byte[] input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] DecryptBytes(byte[] input, int numBytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] DecryptBytes(byte[] input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string DecryptUTF8ByteArray(byte[] input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void WorkStreams(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private async Task WorkStreamsAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void WorkBytes(byte[] output, byte[] input, int numBytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        ~AES_CTR()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Dispose(bool disposing)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

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