using System;

namespace LimraTool.Class.DiscUtils.Ext
{
    /// <summary>
    /// Inode flags.
    /// </summary>
    [Flags]
    internal enum InodeFlags : uint
    {
        SecureDelete = 0x1u,
        Undelete = 0x2u,
        CompressFile = 0x4u,
        SynchronousUpdates = 0x8u,
        ImmutableFile = 0x10u,
        AppendOnly = 0x20u,
        NoDump = 0x40u,
        NoAccessTime = 0x80u,
        CompressionDirty = 0x100u,
        CompressionCompressed = 0x200u,
        CompressionDintCompress = 0x400u,
        CompressionError = 0x800u,
        IndexedDirectory = 0x1000u,
        AfsDirectory = 0x2000u,
        JournalFileData = 0x4000u,
        NoTailMerge = 0x8000u,
        DirSync = 0x10000u,
        TopDir = 0x20000u,
        HugeFile = 0x40000u,
        ExtentsUsed = 0x80000u,
        Migrating = 0x100000u
    }
}