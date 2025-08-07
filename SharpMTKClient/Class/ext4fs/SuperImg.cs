//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//namespace SharpMTKClient.Class.ext4fs
//{
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataGeometry
//    {
//        public uint Magic;                    // quint -> uint
//        public uint StructSize;                // quint -> uint
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] Checksum;                // qchar[32] -> fixed-length string
//        public uint MaxSize;                   // quint -> uint
//        public uint SlotCount;                 // quint -> uint
//        public uint LogicalBlockSize;          // quint -> uint
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct Metadata
//    {
//        public MetadataGeometry Geometry;            // Struct
//        public MetadataHeader Header;                 // Struct
//        public List<MetadataPartition> Partitions;    // std::vector -> List in C#
//        public List<MetadataExtent> Extents;          // std::vector -> List in C#
//        public List<MetadataPartitionGroup> Groups;   // std::vector -> List in C#
//        public List<MetadataBlockDevice> BlockDevices; // std::vector -> List in C#
//        // Constructor for initialization
//        public Metadata(MetadataGeometry geometry, MetadataHeader header)
//        {
//            Geometry = geometry;
//            Header = header;
//            Partitions = new List<MetadataPartition>();
//            Extents = new List<MetadataExtent>();
//            Groups = new List<MetadataPartitionGroup>();
//            BlockDevices = new List<MetadataBlockDevice>();
//        }
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataPartition
//    {
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
//        public string Name;                  // qchar[36] -> fixed-length string (C# equivalent of char array)
//        public uint Attributes;              // quint -> uint
//        public uint FirstExtentIndex;         // quint -> uint
//        public uint NumExtents;               // quint -> uint
//        public uint GroupIndex;               // quint -> uint
//        // Constructor for initialization
//        public MetadataPartition(string name, uint attributes, uint firstExtentIndex, uint numExtents, uint groupIndex)
//        {
//            Name = name.PadRight(36, '\0').Substring(0, 36);  // Ensure length is exactly 36
//            Attributes = attributes;
//            FirstExtentIndex = firstExtentIndex;
//            NumExtents = numExtents;
//            GroupIndex = groupIndex;
//        }
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataExtent
//    {
//        public long NumSectors;                // qlong -> long (64-bit integer)
//        public uint TargetType;                // quint -> uint (32-bit unsigned integer)
//        public long TargetData;                // qlong -> long (64-bit integer)
//        public uint TargetSource;              // quint -> uint (32-bit unsigned integer)
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataPartitionGroup
//    {
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
//        public string Name;                    // qchar[36] -> fixed-length string
//        public uint Flags;                     // quint -> uint (32-bit unsigned integer)
//        public long MaxSize;                   // qlong -> long (64-bit integer)
//        public MetadataPartitionGroup(string name, uint flags, long maxSize)
//        {
//            Name = name.PadRight(36, '\0').Substring(0, 36);  // Ensures the length is exactly 36 characters
//            Flags = flags;
//            MaxSize = maxSize;
//        }
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataBlockDevice
//    {
//        public long FirstLogicalSector;         // qlong -> long (64-bit integer)
//        public uint Alignment;                  // quint -> uint (32-bit unsigned integer)
//        public uint AlignmentOffset;            // quint -> uint (32-bit unsigned integer)
//        public long Size;                       // qlong -> long (64-bit integer)
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
//        public string PartitionName;            // qchar[36] -> fixed-length string
//        public uint Flags;                      // quint -> uint (32-bit unsigned integer)
//        public MetadataBlockDevice(string partitionName, long firstLogicalSector, uint alignment, uint alignmentOffset, long size, uint flags)
//        {
//            PartitionName = partitionName.PadRight(36, '\0').Substring(0, 36);  // Ensures the length is exactly 36 characters
//            FirstLogicalSector = firstLogicalSector;
//            Alignment = alignment;
//            AlignmentOffset = alignmentOffset;
//            Size = size;
//            Flags = flags;
//        }
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataHeader
//    {
//        public uint Magic;                                   // quint -> uint
//        public ushort MajorVersion;                          // qshort -> ushort
//        public ushort MinorVersion;                          // qshort -> ushort
//        public uint HeaderSize;                              // quint -> uint
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
//        public string HeaderChecksum;                        // qchar[32] -> fixed-length string
//        public uint TablesSize;                              // quint -> uint
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
//        public string TableChecksum;                         // qchar[32] -> fixed-length string
//        public MetadataTableDescriptor Partitions;           // Struct
//        public MetadataTableDescriptor Extents;              // Struct
//        public MetadataTableDescriptor Groups;               // Struct
//        public MetadataTableDescriptor BlockDevices;         // Struct
//        public uint Flags;                                   // quint -> uint
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 124)]
//        public byte[] Reserved;                               // qchar[124] -> byte array (reserved space)
//        // Constructor for initialization
//        public MetadataHeader(uint magic, ushort majorVersion, ushort minorVersion, uint headerSize,
//                              string headerChecksum, uint tablesSize, string tableChecksum, uint flags)
//        {
//            Magic = magic;
//            MajorVersion = majorVersion;
//            MinorVersion = minorVersion;
//            HeaderSize = headerSize;
//            HeaderChecksum = headerChecksum.PadRight(32, '\0').Substring(0, 32);
//            TablesSize = tablesSize;
//            TableChecksum = tableChecksum.PadRight(32, '\0').Substring(0, 32);
//            Partitions = new MetadataTableDescriptor();
//            Extents = new MetadataTableDescriptor();
//            Groups = new MetadataTableDescriptor();
//            BlockDevices = new MetadataTableDescriptor();
//            Flags = flags;
//            Reserved = new byte[124]; // Reserved array is filled with 0 by default.
//        }
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataTableDescriptor
//    {
//        public uint Offset;         // quint -> uint (32-bit unsigned integer)
//        public uint NumEntries;     // quint -> uint (32-bit unsigned integer)
//        public uint EntrySize;      // quint -> uint (32-bit unsigned integer)
//        // Constructor for initialization
//        public MetadataTableDescriptor(uint offset, uint numEntries, uint entrySize)
//        {
//            Offset = offset;
//            NumEntries = numEntries;
//            EntrySize = entrySize;
//        }
//    }
//    [StructLayout(LayoutKind.Sequential, Pack = 1)]
//    public struct MetadataHeaderV1_0
//    {
//        public uint Magic;                                   // quint -> uint
//        public ushort MajorVersion;                          // qshort -> ushort
//        public ushort MinorVersion;                          // qshort -> ushort
//        public uint HeaderSize;                              // quint -> uint
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
//        public string HeaderChecksum;                        // qchar[32] -> fixed-length string
//        public uint TablesSize;                              // quint -> uint
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
//        public string TablesChecksum;                        // qchar[32] -> fixed-length string
//        public MetadataTableDescriptor Partitions;           // Struct
//        public MetadataTableDescriptor Extents;              // Struct
//        public MetadataTableDescriptor Groups;               // Struct
//        public MetadataTableDescriptor BlockDevices;         // Struct
//        // Constructor for initialization
//        public MetadataHeaderV1_0(uint magic, ushort majorVersion, ushort minorVersion, uint headerSize,
//                                  string headerChecksum, uint tablesSize, string tablesChecksum,
//                                  MetadataTableDescriptor partitions, MetadataTableDescriptor extents,
//                                  MetadataTableDescriptor groups, MetadataTableDescriptor blockDevices)
//        {
//            Magic = magic;
//            MajorVersion = majorVersion;
//            MinorVersion = minorVersion;
//            HeaderSize = headerSize;
//            HeaderChecksum = headerChecksum.PadRight(32, '\0').Substring(0, 32);  // Ensure 32-character length
//            TablesSize = tablesSize;
//            TablesChecksum = tablesChecksum.PadRight(32, '\0').Substring(0, 32);  // Ensure 32-character length
//            Partitions = partitions;
//            Extents = extents;
//            Groups = groups;
//            BlockDevices = blockDevices;
//        }
//    }
//    public class SuperImg
//    {
//        public Ext4fs extfs;
//        public Metadata m_data;
//        public string m_errlog;
//        public SuperImg(Ext4fs etfs)
//        {
//            this.extfs = etfs;
//        }
//        public bool valid()
//        {
//            var size = Marshal.SizeOf(typeof(MetadataGeometry));
//            var geo = extfs.readBuf<MetadataGeometry>(4096, (ulong)size);
//            if(geo.Magic != 0x616c4467)
//            {
//                geo = extfs.readBuf<MetadataGeometry>(4096 * 2, (ulong)size);
//            }
//            return geo.Magic == 0x616c4467;
//        }
//        public bool readLogicalPartGeometry()
//        {
//            return !readPartGeometry() ? readPartGeometry(false) : true;
//        }
//        public bool readData(uint slot)
//        {
//            if (!readLogicalPartGeometry())
//            {
//                return false;
//            }
//            if(slot > m_data.Geometry.SlotCount)
//            {
//                return false;
//            }
//            List<long> offsets = new List<long> { GetOffset(slot), GetOffset(slot, false) }
//            foreach (long offset in offsets)
//            {
//                if (ParseData(offset))
//                    break;
//            }
//            return AdjustForSlot(slot);
//        }
//        public bool parseData()
//        {
//            byte[] buffer = null;
//            if(!rea)
//        }
//        public bool readHeader(ulong offset)
//        {
//            m_data.Header = extfs.readBuf<MetadataHeader>(offset, (ulong)Marshal.SizeOf(typeof(MetadataHeaderV1_0)));
//            if(m_data.Header.Magic != 0x414c5030)
//            {
//                m_errlog = "invalid header magic";
//                return false;
//            }
//            if (m_data.Header.MajorVersion != 10 || m_data.Header.MinorVersion > 2)
//            {
//                m_errlog = "incompatible header version";
//                return false;
//            }
//            var struct_size = Marshal.SizeOf(m_data.Header);
//            if (m_data.Header.MinorVersion < 2)
//                struct_size = Marshal.SizeOf(typeof(MetadataHeaderV1_0));
//            if (m_data.Header.HeaderSize != struct_size)
//            {
//                m_errlog = "wrong header size";
//                return false;
//            }
//            var remain_size = m_data.Header.HeaderSize - Marshal.SizeOf(typeof(MetadataHeaderV1_0));
//            if (remain_size > 0)
//            {
//                var sz = Marshal.SizeOf(typeof(MetadataHeaderV1_0));
//                readBuf(remain, offset, remain_size)
//                if (!)
//                    return 0;
//                offset += remain_size;
//            }
//        }
//        public long GetOffset(uint slot, bool primary = true)
//        {
//            if (primary)
//                return 0x3000 + ((long)m_data.Geometry.MaxSize * slot);
//            else
//                return 0x3000 + ((long)m_data.Geometry.MaxSize * m_data.Geometry.SlotCount) +
//                       ((long)m_data.Geometry.MaxSize * slot);
//        }
//        public bool readPartGeometry(bool primary = true)
//        {
//            m_data.Geometry = default;
//            var addr = 4096;
//            if (!primary)
//            {
//                addr += 4096;
//            }
//            m_data.Geometry = extfs.readBuf<MetadataGeometry>((ulong)addr, 4096);
//            if(m_data.Geometry.Magic != 0x616c4467)
//            {
//                throw new Exception("invalid geometry magic signature" );
//            }
//            if (m_data.Geometry.StructSize > Marshal.SizeOf(typeof(MetadataGeometry)))
//            {
//                throw new Exception("invalid geometry fields" );
//            }
//            MetadataGeometry geo = m_data.Geometry;
//            geo.Checksum = new byte[32];
//            geo.Checksum = util.SHA256CheckSum(util.StructToBytes(geo, (int)geo.StructSize));
//            return true;
//        }
//    }
//}
