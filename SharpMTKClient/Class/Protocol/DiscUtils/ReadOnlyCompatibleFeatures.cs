using System;

namespace LimraTool.Class.DiscUtils.Ext
{
    /// <summary>
    /// Feature flags for features backwards compatible with read-only mounting.
    /// </summary>
    [Flags]
    internal enum ReadOnlyCompatibleFeatures : ushort
    {
        /// <summary>
        /// Indicates that not all block groups contain a backup superblock.
        /// </summary>
        SparseSuperblock = 0x1,
        /// <summary>
        /// Indicates file system contains files greater than 0x7FFFFFFF in size (limit of unsigned uints).
        /// </summary>
        LargeFiles = 0x2,
        /// <summary>
        /// Indicates BTree-style directories present (not used in mainline?).
        /// </summary>
        BtreeDirectory = 0x4,
        /// <summary>
        /// Ext4 feature - support for storing huge files.
        /// </summary>
        HugeFile = 0x5,
        /// <summary>
        /// Ext4 feature - checksum block group structures.
        /// </summary>
        GdtChecksum = 0x6,
        /// <summary>
        /// Ext4 feature - Unknown.
        /// </summary>
        DirNlink = 0x7,
        /// <summary>
        /// Ext4 feature - extra inode size.
        /// </summary>
        ExtraInodeSize = 0x8
    }
}