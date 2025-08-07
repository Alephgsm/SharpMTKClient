using System;
using System.IO;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class ExtentBlock : IByteArraySerializable
    {
        public Extent[] Extents;
        public ExtentHeader Header;
        public ExtentIndex[] Index;
        public int Size => 12 + Header.MaxEntries * 12;

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