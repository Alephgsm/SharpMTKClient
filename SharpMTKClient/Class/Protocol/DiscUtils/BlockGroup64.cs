using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class BlockGroup64 : BlockGroup
    {
        private int _descriptorSize;
        public uint BlockBitmapBlockHigh;
        public uint InodeBitmapBlockHigh;
        public uint InodeTableBlockHigh;
        public ushort FreeBlocksCountHigh;
        public ushort FreeInodesCountHigh;
        public ushort UsedDirsCountHigh;
        public override int Size => _descriptorSize;

        public BlockGroup64(int descriptorSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public override int ReadFrom(byte[] buffer, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}