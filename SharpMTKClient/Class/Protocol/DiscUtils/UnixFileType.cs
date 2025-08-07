namespace LimraTool.Class.DiscUtils
{
    /// <summary>
    /// Standard Unix-style file type.
    /// </summary>
    public enum UnixFileType
    {
        /// <summary>
        /// No type specified.
        /// </summary>
        None = 0,
        /// <summary>
        /// A FIFO / Named Pipe.
        /// </summary>
        Fifo = 1,
        /// <summary>
        /// A character device.
        /// </summary>
        Character = 2,
        /// <summary>
        /// A normal directory.
        /// </summary>
        Directory = 4,
        /// <summary>
        /// A block device.
        /// </summary>
        Block = 6,
        /// <summary>
        /// A regular file.
        /// </summary>
        Regular = 8,
        /// <summary>
        /// A soft link.
        /// </summary>
        Link = 10,
        /// <summary>
        /// A unix socket.
        /// </summary>
        Socket = 12
    }
}