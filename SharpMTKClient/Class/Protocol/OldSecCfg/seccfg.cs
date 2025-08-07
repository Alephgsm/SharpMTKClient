using SharpMTKClient.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class seccfg
    {
        public hwcrypto hwc;
        public uint magic;
        public uint seccfg_ver;
        public uint seccfg_size;
        public uint lock_state;
        public uint critical_lock_state;
        public uint sboot_runtime;
        public uint endflag;
        public byte[] hash;
        public seccfg(hwcrypto hwc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool parse(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] create(seccfg sc_org, string hwtype, string lockflag = "unlock", bool V3 = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}