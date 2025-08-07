using System;
using LimraTool.Class.DiscUtils.Streams;

namespace LimraTool.Class.DiscUtils.Ext
{
    internal class SuperBlock : IByteArraySerializable
    {
        public const ushort Ext2Magic = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        /// <summary>
        /// Old revision, not supported by DiscUtils.
        /// </summary>
        public const uint OldRevision = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public ushort BlockGroupNumber;
        public uint BlocksCount;
        public uint BlocksCountHigh;
        public uint BlocksPerGroup;
        public uint CheckInterval;
        public CompatibleFeatures CompatibleFeatures;
        public uint CompressionAlgorithmUsageBitmap;
        public uint CreatorOS;
        public byte DefaultHashVersion;
        public uint DefaultMountOptions;
        public ushort DefaultReservedBlockGid;
        public ushort DefaultReservedBlockUid;
        public ushort DescriptorSize;
        public byte DirPreallocateBlockCount;
        public uint ReservedGDTBlocks;
        public ushort Errors;
        public uint FirstDataBlock;
        public uint FirstInode;
        public uint FirstMetablockBlockGroup;
        public uint Flags;
        public uint FragsPerGroup;
        public uint FreeBlocksCount;
        public uint FreeBlocksCountHigh;
        public uint FreeInodesCount;
        public uint[] HashSeed;
        public IncompatibleFeatures IncompatibleFeatures;
        public uint InodesCount;
        public ushort InodeSize;
        public uint InodesPerGroup;
        public uint[] JournalBackup;
        public uint JournalDevice;
        public uint JournalInode;
        public Guid JournalSuperBlockUniqueId;
        public uint LastCheckTime;
        public string LastMountPoint;
        public uint LastOrphan;
        public uint LogBlockSize;
        public uint LogFragSize;
        public byte LogGroupsPerFlex;
        public uint OverheadBlocksCount;
        public ushort Magic;
        public ushort MaxMountCount;
        public ushort MinimumExtraInodeSize;
        public ushort MinorRevisionLevel;
        public uint MkfsTime;
        public ushort MountCount;
        public uint MountTime;
        public ulong MultiMountProtectionBlock;
        public ushort MultiMountProtectionInterval;
        public byte PreallocateBlockCount;
        public ushort RaidStride;
        public uint RaidStripeWidth;
        public ReadOnlyCompatibleFeatures ReadOnlyCompatibleFeatures;
        public uint ReservedBlocksCount;
        public uint ReservedBlocksCountHigh;
        public uint RevisionLevel;
        public ushort State;
        public Guid UniqueId;
        public string VolumeName;
        public ushort WantExtraInodeSize;
        public uint WriteTime;
        public bool Has64Bit
        {
            get
            {
                if ((IncompatibleFeatures & IncompatibleFeatures.SixtyFourBit) == IncompatibleFeatures.SixtyFourBit)
                {
                    return DescriptorSize >= 64;
                }

                return false;
            }
        }

        public uint BlockSize => (uint)(1024 << (int)LogBlockSize);
        public int Size => 1024;

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