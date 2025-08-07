using System;
using System.IO;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class JournalSuperBlock : IByteArraySerializable
    {
        public uint BlockSize;
        public uint MaxLength;
        public const uint Magic = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        /// <inheritdoc/>
        public int Size => 1024;

        /// <inheritdoc/>
        public int ReadFrom(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <inheritdoc/>
        public void WriteTo(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}