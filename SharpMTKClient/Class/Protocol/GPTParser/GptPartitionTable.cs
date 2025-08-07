using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native.GPTParser
{
    /// <remarks>
    /// Reference: <a href="https://en.wikipedia.org/wiki/GUID_Partition_Table">Source</a>
    /// </remarks>
    public partial class GptPartitionTable : KaitaiStruct
    {
        public static GptPartitionTable FromFile(string fileName)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static GptPartitionTable FromBinary(byte[] binary)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public GptPartitionTable(KaitaiStream p__io, KaitaiStruct p__parent = null, GptPartitionTable p__root = null) : base(p__io)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void _read()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public partial class PartitionEntry : KaitaiStruct
        {
            public static PartitionEntry FromFile(string fileName)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public PartitionEntry(KaitaiStream p__io, GptPartitionTable.PartitionHeader p__parent = null, GptPartitionTable p__root = null) : base(p__io)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            private void _read()
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            private byte[] _typeGuid;
            private byte[] _guid;
            private ulong _firstLba;
            private ulong _lastLba;
            private ulong _attributes;
            private string _name;
            private GptPartitionTable m_root;
            private GptPartitionTable.PartitionHeader m_parent;
            public byte[] TypeGuid
            {
                get
                {
                    return _typeGuid;
                }
            }

            public byte[] Guid
            {
                get
                {
                    return _guid;
                }
            }

            public ulong FirstLba
            {
                get
                {
                    return _firstLba;
                }
            }

            public ulong LastLba
            {
                get
                {
                    return _lastLba;
                }
            }

            public ulong Attributes
            {
                get
                {
                    return _attributes;
                }
            }

            public string Name
            {
                get
                {
                    return _name;
                }
            }

            public GptPartitionTable M_Root
            {
                get
                {
                    return m_root;
                }
            }

            public GptPartitionTable.PartitionHeader M_Parent
            {
                get
                {
                    return m_parent;
                }
            }
        }

        public partial class PartitionHeader : KaitaiStruct
        {
            public static PartitionHeader FromFile(string fileName)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public PartitionHeader(KaitaiStream p__io, GptPartitionTable p__parent = null, GptPartitionTable p__root = null) : base(p__io)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            private void _read()
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            private bool f_entries;
            private List<PartitionEntry> _entries;
            public List<PartitionEntry> Entries
            {
                get
                {
                    if (f_entries)
                        return _entries;
                    KaitaiStream io = M_Root.M_Io;
                    long _pos = io.Pos;
                    io.Seek(Convert.ToInt64(EntriesStart * Convert.ToUInt64(M_Root.SectorSize)));
                    __raw_entries = new List<byte[]>((int)(EntriesCount));
                    _entries = new List<PartitionEntry>((int)(EntriesCount));
                    for (var i = 0; i < EntriesCount; i++)
                    {
                        __raw_entries.Add(io.ReadBytes(EntriesSize));
                        var io___raw_entries = new KaitaiStream(__raw_entries[__raw_entries.Count - 1]);
                        _entries.Add(new PartitionEntry(io___raw_entries, this, m_root));
                    }

                    io.Seek(_pos);
                    f_entries = true;
                    return _entries;
                }
            }

            private byte[] _signature;
            private uint _revision;
            private uint _headerSize;
            private uint _crc32Header;
            private uint _reserved;
            private ulong _currentLba;
            private ulong _backupLba;
            private ulong _firstUsableLba;
            private ulong _lastUsableLba;
            private byte[] _diskGuid;
            private ulong _entriesStart;
            private uint _entriesCount;
            private uint _entriesSize;
            private uint _crc32Array;
            private GptPartitionTable m_root;
            private GptPartitionTable m_parent;
            private List<byte[]> __raw_entries;
            public byte[] Signature
            {
                get
                {
                    return _signature;
                }
            }

            public uint Revision
            {
                get
                {
                    return _revision;
                }
            }

            public uint HeaderSize
            {
                get
                {
                    return _headerSize;
                }
            }

            public uint Crc32Header
            {
                get
                {
                    return _crc32Header;
                }
            }

            public uint Reserved
            {
                get
                {
                    return _reserved;
                }
            }

            public ulong CurrentLba
            {
                get
                {
                    return _currentLba;
                }
            }

            public ulong BackupLba
            {
                get
                {
                    return _backupLba;
                }
            }

            public ulong FirstUsableLba
            {
                get
                {
                    return _firstUsableLba;
                }
            }

            public ulong LastUsableLba
            {
                get
                {
                    return _lastUsableLba;
                }
            }

            public byte[] DiskGuid
            {
                get
                {
                    return _diskGuid;
                }
            }

            public ulong EntriesStart
            {
                get
                {
                    return _entriesStart;
                }
            }

            public uint EntriesCount
            {
                get
                {
                    return _entriesCount;
                }
            }

            public uint EntriesSize
            {
                get
                {
                    return _entriesSize;
                }
            }

            public uint Crc32Array
            {
                get
                {
                    return _crc32Array;
                }
            }

            public GptPartitionTable M_Root
            {
                get
                {
                    return m_root;
                }
            }

            public GptPartitionTable M_Parent
            {
                get
                {
                    return m_parent;
                }
            }

            public List<byte[]> M_RawEntries
            {
                get
                {
                    return __raw_entries;
                }
            }
        }

        private bool f_sectorSize;
        private int _sectorSize;
        public int SectorSize
        {
            get
            {
                if (f_sectorSize)
                    return _sectorSize;
                _sectorSize = (int)(512);
                f_sectorSize = true;
                return _sectorSize;
            }
        }

        private bool f_primary;
        private PartitionHeader _primary;
        public PartitionHeader Primary
        {
            get
            {
                if (f_primary)
                    return _primary;
                KaitaiStream io = M_Root.M_Io;
                long _pos = io.Pos;
                io.Seek(M_Root.SectorSize);
                _primary = new PartitionHeader(io, this, m_root);
                io.Seek(_pos);
                f_primary = true;
                return _primary;
            }
        }

        private bool f_backup;
        private PartitionHeader _backup;
        public PartitionHeader Backup
        {
            get
            {
                if (f_backup)
                    return _backup;
                KaitaiStream io = M_Root.M_Io;
                long _pos = io.Pos;
                io.Seek((M_Io.Size - M_Root.SectorSize));
                _backup = new PartitionHeader(io, this, m_root);
                io.Seek(_pos);
                f_backup = true;
                return _backup;
            }
        }

        private GptPartitionTable m_root;
        private KaitaiStruct m_parent;
        public GptPartitionTable M_Root
        {
            get
            {
                return m_root;
            }
        }

        public KaitaiStruct M_Parent
        {
            get
            {
                return m_parent;
            }
        }
    }
}