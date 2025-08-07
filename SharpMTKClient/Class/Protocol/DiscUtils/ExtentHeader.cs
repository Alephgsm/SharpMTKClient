using System;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class ExtentHeader : IByteArraySerializable
    {
        public const ushort HeaderMagic = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public ushort Depth;
        public ushort Entries;
        public uint Generation;
        public ushort Magic;
        public ushort MaxEntries;
        public int Size => 12;

        public int ReadFrom(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void WriteTo(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}