using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Globalization;

namespace SharpMTKClient.Class.Protocol.Native.GPTParser
{
    /// <summary>
    /// The base Kaitai stream which exposes an API for the Kaitai Struct framework.
    /// It's based off a <code>BinaryReader</code>, which is a little-endian reader.
    /// </summary>
    public partial class KaitaiStream : BinaryReader
    {
#region Constructors
        public KaitaiStream(Stream stream) : base(stream)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        ///<summary>
        /// Creates a KaitaiStream backed by a file (RO)
        ///</summary>
        public KaitaiStream(string file) : base(File.Open(file, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        ///<summary>
        ///Creates a KaitaiStream backed by a byte buffer
        ///</summary>
        public KaitaiStream(byte[] bytes) : base(new MemoryStream(bytes))
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int BitsLeft = 0;
        private ulong Bits = 0;
        static readonly bool IsLittleEndian = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
#endregion
#region Stream positioning
        /// <summary>
        /// Check if the stream position is at the end of the stream
        /// </summary>
        public bool IsEof
        {
            get
            {
                return BaseStream.Position >= BaseStream.Length && BitsLeft == 0;
            }
        }

        /// <summary>
        /// Seek to a specific position from the beginning of the stream
        /// </summary>
        /// <param name = "position">The position to seek to</param>
        public void Seek(long position)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Get the current position in the stream
        /// </summary>
        public long Pos
        {
            get
            {
                return BaseStream.Position;
            }
        }

        /// <summary>
        /// Get the total length of the stream (ie. file size)
        /// </summary>
        public long Size
        {
            get
            {
                return BaseStream.Length;
            }
        }

#endregion
#region Integer types
#region Signed
        /// <summary>
        /// Read a signed byte from the stream
        /// </summary>
        /// <returns></returns>
        public sbyte ReadS1()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region Big-endian
        /// <summary>
        /// Read a signed short from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public short ReadS2be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a signed int from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public int ReadS4be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a signed long from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public long ReadS8be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Little-endian
        /// <summary>
        /// Read a signed short from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public short ReadS2le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a signed int from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public int ReadS4le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a signed long from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public long ReadS8le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#endregion
#region Unsigned
        /// <summary>
        /// Read an unsigned byte from the stream
        /// </summary>
        /// <returns></returns>
        public byte ReadU1()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region Big-endian
        /// <summary>
        /// Read an unsigned short from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public ushort ReadU2be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read an unsigned int from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public uint ReadU4be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read an unsigned long from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public ulong ReadU8be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Little-endian
        /// <summary>
        /// Read an unsigned short from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public ushort ReadU2le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read an unsigned int from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public uint ReadU4le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read an unsigned long from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public ulong ReadU8le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#endregion
#endregion
#region Floating point types
#region Big-endian
        /// <summary>
        /// Read a single-precision floating point value from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public float ReadF4be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a double-precision floating point value from the stream (big endian)
        /// </summary>
        /// <returns></returns>
        public double ReadF8be()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Little-endian
        /// <summary>
        /// Read a single-precision floating point value from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public float ReadF4le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a double-precision floating point value from the stream (little endian)
        /// </summary>
        /// <returns></returns>
        public double ReadF8le()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#endregion
#region Unaligned bit values
        public void AlignToByte()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a n-bit integer in a big-endian manner from the stream
        /// </summary>
        /// <returns></returns>
        public ulong ReadBitsIntBe(int n)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [Obsolete("use ReadBitsIntBe instead")]
        public ulong ReadBitsInt(int n)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a n-bit integer in a little-endian manner from the stream
        /// </summary>
        /// <returns></returns>
        public ulong ReadBitsIntLe(int n)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Byte arrays
        /// <summary>
        /// Read a fixed number of bytes from the stream
        /// </summary>
        /// <param name = "count">The number of bytes to read</param>
        /// <returns></returns>
        public byte[] ReadBytes(long count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a fixed number of bytes from the stream
        /// </summary>
        /// <param name = "count">The number of bytes to read</param>
        /// <returns></returns>
        public byte[] ReadBytes(ulong count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read bytes from the stream in little endian format and convert them to the endianness of the current platform
        /// </summary>
        /// <param name = "count">The number of bytes to read</param>
        /// <returns>An array of bytes that matches the endianness of the current platform</returns>
        protected byte[] ReadBytesNormalisedLittleEndian(int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read bytes from the stream in big endian format and convert them to the endianness of the current platform
        /// </summary>
        /// <param name = "count">The number of bytes to read</param>
        /// <returns>An array of bytes that matches the endianness of the current platform</returns>
        protected byte[] ReadBytesNormalisedBigEndian(int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read all the remaining bytes from the stream until the end is reached
        /// </summary>
        /// <returns></returns>
        public byte[] ReadBytesFull()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a terminated string from the stream
        /// </summary>
        /// <param name = "terminator">The string terminator value</param>
        /// <param name = "includeTerminator">True to include the terminator in the returned string</param>
        /// <param name = "consumeTerminator">True to consume the terminator byte before returning</param>
        /// <param name = "eosError">True to throw an error when the EOS was reached before the terminator</param>
        /// <returns></returns>
        public byte[] ReadBytesTerm(byte terminator, bool includeTerminator, bool consumeTerminator, bool eosError)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Read a specific set of bytes and assert that they are the same as an expected result
        /// </summary>
        /// <param name = "expected">The expected result</param>
        /// <returns></returns>
        [Obsolete("use explicit \"if\" using ByteArrayCompare method instead")]
        public byte[] EnsureFixedContents(byte[] expected)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] BytesStripRight(byte[] src, byte padByte)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] BytesTerminate(byte[] src, byte terminator, bool includeTerminator)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Byte array processing
        /// <summary>
        /// Performs XOR processing with given data, XORing every byte of the input with a single value.
        /// </summary>
        /// <param name = "value">The data toe process</param>
        /// <param name = "key">The key value to XOR with</param>
        /// <returns>Processed data</returns>
        public byte[] ProcessXor(byte[] value, int key)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Performs XOR processing with given data, XORing every byte of the input with a key
        /// array, repeating from the beginning of the key array if necessary
        /// </summary>
        /// <param name = "value">The data toe process</param>
        /// <param name = "key">The key array to XOR with</param>
        /// <returns>Processed data</returns>
        public byte[] ProcessXor(byte[] value, byte[] key)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Performs a circular left rotation shift for a given buffer by a given amount of bits.
        /// Pass a negative amount to rotate right.
        /// </summary>
        /// <param name = "data">The data to rotate</param>
        /// <param name = "amount">The number of bytes to rotate by</param>
        /// <param name = "groupSize"></param>
        /// <returns></returns>
        public byte[] ProcessRotateLeft(byte[] data, int amount, int groupSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Inflates a deflated zlib byte stream
        /// </summary>
        /// <param name = "data">The data to deflate</param>
        /// <returns>The deflated result</returns>
        public byte[] ProcessZlib(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Misc utility methods
        /// <summary>
        /// Performs modulo operation between two integers.
        /// </summary>
        /// <remarks>
        /// This method is required because C# lacks a "true" modulo
        /// operator, the % operator rather being the "remainder"
        /// operator. We want mod operations to always be positive.
        /// </remarks>
        /// <param name = "a">The value to be divided</param>
        /// <param name = "b">The value to divide by. Must be greater than zero.</param>
        /// <returns>The result of the modulo opertion. Will always be positive.</returns>
        public static int Mod(int a, int b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Performs modulo operation between two integers.
        /// </summary>
        /// <remarks>
        /// This method is required because C# lacks a "true" modulo
        /// operator, the % operator rather being the "remainder"
        /// operator. We want mod operations to always be positive.
        /// </remarks>
        /// <param name = "a">The value to be divided</param>
        /// <param name = "b">The value to divide by. Must be greater than zero.</param>
        /// <returns>The result of the modulo opertion. Will always be positive.</returns>
        public static long Mod(long a, long b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Compares two byte arrays in lexicographical order.
        /// </summary>
        /// <returns>negative number if a is less than b, <c>0</c> if a is equal to b, positive number if a is greater than b.</returns>
        /// <param name = "a">First byte array to compare</param>
        /// <param name = "b">Second byte array to compare.</param>
        public static int ByteArrayCompare(byte[] a, byte[] b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Reverses the string, Unicode-aware.
        /// </summary>
        /// <a href="https://stackoverflow.com/a/15029493">taken from here</a>
        public static string StringReverse(string s)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
    }
}