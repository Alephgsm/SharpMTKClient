using System;

namespace LimraTool.Class.DiscUtils.Streams
{
    public static class EndianUtilities
    {
        public static void WriteBytesLittleEndian(ushort val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesLittleEndian(uint val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesLittleEndian(ulong val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesLittleEndian(short val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesLittleEndian(int val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesLittleEndian(long val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesLittleEndian(Guid val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(ushort val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(uint val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(ulong val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(short val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(int val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(long val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void WriteBytesBigEndian(Guid val, byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ushort ToUInt16LittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint ToUInt32LittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ulong ToUInt64LittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static short ToInt16LittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int ToInt32LittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static long ToInt64LittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ushort ToUInt16BigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint ToUInt32BigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ulong ToUInt64BigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static short ToInt16BigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int ToInt32BigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static long ToInt64BigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static Guid ToGuidLittleEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static Guid ToGuidBigEndian(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] ToByteArray(byte[] buffer, int offset, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static T ToStruct<T>(byte[] buffer, int offset)
            where T : IByteArraySerializable, new()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Primitive conversion from Unicode to ASCII that preserves special characters.
        /// </summary>
        /// <param name = "value">The string to convert.</param>
        /// <param name = "dest">The buffer to fill.</param>
        /// <param name = "offset">The start of the string in the buffer.</param>
        /// <param name = "count">The number of characters to convert.</param>
        /// <remarks>The built-in ASCIIEncoding converts characters of codepoint &gt; 127 to ?,
        /// this preserves those code points by removing the top 16 bits of each character.</remarks>
        public static void StringToBytes(string value, byte[] dest, int offset, int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Primitive conversion from ASCII to Unicode that preserves special characters.
        /// </summary>
        /// <param name = "data">The data to convert.</param>
        /// <param name = "offset">The first byte to convert.</param>
        /// <param name = "count">The number of bytes to convert.</param>
        /// <returns>The string.</returns>
        /// <remarks>The built-in ASCIIEncoding converts characters of codepoint &gt; 127 to ?,
        /// this preserves those code points.</remarks>
        public static string BytesToString(byte[] data, int offset, int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Primitive conversion from ASCII to Unicode that stops at a null-terminator.
        /// </summary>
        /// <param name = "data">The data to convert.</param>
        /// <param name = "offset">The first byte to convert.</param>
        /// <param name = "count">The number of bytes to convert.</param>
        /// <returns>The string.</returns>
        /// <remarks>The built-in ASCIIEncoding converts characters of codepoint &gt; 127 to ?,
        /// this preserves those code points.</remarks>
        public static string BytesToZString(byte[] data, int offset, int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}