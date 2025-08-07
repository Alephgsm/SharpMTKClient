using System;

namespace LimraTool.Class.DiscUtils.Ext
{
    /// <summary>
    /// Feature flags for features backwards compatible with read-only mounting.
    /// </summary>
    [Flags]
    internal enum IncompatibleFeatures : ushort
    {
        /// <summary>
        /// File compression used (not used in mainline?).
        /// </summary>
        Compression = 0x1,
        /// <summary>
        /// Indicates that directory entries contain a file type field (uses byte of file name length field).
        /// </summary>
        FileType = 0x2,
        /// <summary>
        /// Ext3 feature - indicates a dirty journal, that needs to be replayed (safe for read-only access, not for read-write).
        /// </summary>
        NeedsRecovery = 0x4,
        /// <summary>
        /// Ext3 feature - indicates the file system is a dedicated EXT3 journal, not an actual file system.
        /// </summary>
        IsJournalDevice = 0x8,
        /// <summary>
        /// Indicates the file system saves space by only allocating backup space for the superblock in groups storing it (used with SparseSuperBlock).
        /// </summary>
        MetaBlockGroup = 0x10,
        /// <summary>
        /// Ext4 feature to store files as extents.
        /// </summary>
        Extents = 0x40,
        /// <summary>
        /// Ext4 feature to support some 64-bit fields.
        /// </summary>
        SixtyFourBit = 0x80,
        /// <summary>
        /// Ext4 feature for storage of block groups.
        /// </summary>
        FlexBlockGroups = 0x200
    }
}