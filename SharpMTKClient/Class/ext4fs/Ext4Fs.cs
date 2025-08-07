using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static SharpMTKClient.Class.Protocol.Native.gpt;
using static SharpMTKClient.Class.util;

namespace SharpMTKClient.Class.ext4fs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PMTInfo
    {
        public short stor;
        public short count;
        public short index;
        public long offset;
        public long length;
        public short partid;
        public string pname;
        public string fname;
        public string type;
        public string region;
        public string op_type;
        public string m_subpart;
        public string m_mountpoint;
        public bool m_is_file;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MTKV6_PTT
    {
        public string name;
        public string start;
        public string size;
        public string lun;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SparseHeader
    {
        public uint Magic; // quint -> uint
        public ushort MajorVersion; // qshort -> ushort
        public ushort MinorVersion; // qshort -> ushort
        public ushort SparseHeaderSize; // qshort -> ushort
        public ushort ChunkHeaderSize; // qshort -> ushort
        public uint BlockSize; // quint -> uint
        public uint TotalBlocks; // quint -> uint
        public uint TotalChunks; // quint -> uint
        public uint Checksum; // quint -> uint
    }

    public class Ext4fs
    {
        public readflash readf;
        public partf partf;
        public uint pagesize;
        public ulong m_base_addr;
        public ulong m_base_len;
        public Ext4fs(readflash read, partf partf, uint pagesize = 512)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] readBuf(ulong offset, ulong len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public T readBuf<T>(ulong offset, ulong len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Mount()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}