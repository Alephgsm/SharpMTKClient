using MediatekNaiveProtocol.Mediatek.crypto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.Native.Features;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class seccfg
    {
        public HWCrypto hwc;
        public uint magic;
        public uint seccfg_ver;
        public uint seccfg_size;
        public uint lock_state;
        public uint critical_lock_state;
        public uint sboot_runtime;
        public uint endflag;
        public byte[] hash;
        public seccfg(HWCrypto hwc)
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

    public class SECCFG_STATUS
    {
        public const int SEC_CFG_COMPLETE_NUM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // CCCC
        public const int SEC_CFG_INCOMPLETE_NUM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; //IIII
    }

    public class SECCFG_ATTR
    {
        public const int ATTR_LOCK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int ATTR_VERIFIED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int ATTR_CUSTOM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int ATTR_MP_DEFAULT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int ATTR_DEFAULT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int ATTR_UNLOCK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }

    public class seccfgV3
    {
        public byte[] info;
        public uint magic;
        public uint seccfg_ver;
        public uint seccfg_size;
        public uint seccfg_enc_len;
        public uint seccfg_enc_offset;
        public uint endflag;
        public byte sw_sec_lock_try;
        public byte sw_sec_lock_done;
        public ushort page_size;
        public uint page_count;
        public List<byte[]> imginfo;
        public uint siu_status;
        public uint seccfg_status;
        public uint seccfg_attr;
        public byte[] seccfg_ext;
        public HWCrypto hwc;
        public byte[] data;
        public string hwtype;
        public byte[] org_data;
        public seccfgV3(HWCrypto hwc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool parse(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] create(string lockflag = "unlock")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    public class seccfgV4
    {
        public HWCrypto hwc;
        public uint magic;
        public uint seccfg_ver;
        public uint seccfg_size;
        public uint lock_state;
        public uint critical_lock_state;
        public uint sboot_runtime;
        public uint endflag;
        public byte[] hash;
        public string hwtype;
        public seccfgV4(HWCrypto hwc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool parse(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] create(string lockflag = "unlock")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}