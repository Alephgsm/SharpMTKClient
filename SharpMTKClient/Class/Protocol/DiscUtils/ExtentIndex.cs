using System;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class ExtentIndex : IByteArraySerializable
    {
        public uint FirstLogicalBlock;
        public ushort LeafPhysicalBlockHi;
        public uint LeafPhysicalBlockLo;
        public long LeafPhysicalBlock => (long)(LeafPhysicalBlockLo | ((ulong)LeafPhysicalBlockHi << 32));
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