using System;
using System.IO;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class Inode : IByteArraySerializable
    {
        public uint AccessTime;
        public uint BlocksCount;
        public uint CreationTime;
        public uint DeletionTime;
        public uint DirAcl;
        public uint[] DirectBlocks;
        public uint DoubleIndirectBlock;
        public ExtentBlock Extents;
        public byte[] FastSymlink;
        public uint FileAcl;
        public uint FileSize;
        public uint FileVersion;
        public InodeFlags Flags;
        public uint FragAddress;
        public byte Fragment;
        public byte FragmentSize;
        public ushort GroupIdHigh;
        public ushort GroupIdLow;
        public uint IndirectBlock;
        public ushort LinksCount;
        public ushort Mode;
        public uint ModificationTime;
        public uint TripleIndirectBlock;
        public ushort UserIdHigh;
        public ushort UserIdLow;
        public UnixFileType FileType => (UnixFileType)((Mode >> 12) & 0xFF);

        public int Size
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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