using System;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class BlockGroup : IByteArraySerializable
    {
        public const int DescriptorSize = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public uint BlockBitmapBlock;
        public ushort FreeBlocksCount;
        public ushort FreeInodesCount;
        public uint InodeBitmapBlock;
        public uint InodeTableBlock;
        public ushort UsedDirsCount;
        public virtual int Size => 32;

        public virtual int ReadFrom(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void WriteTo(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}