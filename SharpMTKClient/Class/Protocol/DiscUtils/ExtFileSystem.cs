using SharpMTKClient.Class.Protocol.Native;
using LimraTool.Class.DiscUtils.Ext;
using LimraTool.Class.DiscUtils.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.Native.gpt;

namespace LimraTool.Class.DiscUtils
{
    public class ExtFileSystem
    {
        internal const IncompatibleFeatures SupportedIncompatibleFeatures = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readflashDelegate ReadFlash;
        private Port USB;
        private partf partition;
        private ulong address;
        private BlockGroup[] _blockGroups;
        public ExtFileSystem(Port USB, readflashDelegate readFlash, partf system, ulong pagesize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void ReadHeader()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] ReadExact(ulong pos, ulong len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private Inode GetInode(uint inodeNum, SuperBlock superBlock)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private BlockGroup GetBlockGroup(uint index)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}