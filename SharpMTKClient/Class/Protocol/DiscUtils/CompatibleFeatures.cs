using System;

namespace LimraTool.Class.DiscUtils.Ext
{
    /// <summary>
    /// Feature flags for backwards compatible features.
    /// </summary>
    [Flags]
    internal enum CompatibleFeatures : ushort
    {
        /// <summary>
        /// Indicates pre-allocation hints are present.
        /// </summary>
        DirectoryPreallocation = 0x1,
        /// <summary>
        /// AFS support in inodex.
        /// </summary>
        IMagicInodes = 0x2,
        /// <summary>
        /// Indicates an EXT3-style journal is present.
        /// </summary>
        HasJournal = 0x4,
        /// <summary>
        /// Indicates extended attributes (e.g. FileACLs) are present.
        /// </summary>
        ExtendedAttributes = 0x8,
        /// <summary>
        /// Indicates space is reserved through a special inode to enable the file system to be resized dynamically.
        /// </summary>
        ResizeInode = 0x10,
        /// <summary>
        /// Indicates that directory indexes are present (not used in mainline?).
        /// </summary>
        DirectoryIndex = 0x20
    }
}