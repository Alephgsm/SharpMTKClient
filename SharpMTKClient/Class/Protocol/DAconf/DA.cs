using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native.DAconf
{
    public class DA
    {
        public ushort magic;
        public ushort hw_code;
        public ushort hw_sub_code;
        public ushort hw_version;
        public ushort sw_version;
        public ushort reserved1;
        public ushort pagesize;
        public ushort reserved3;
        public ushort entry_region_index;
        public ushort entry_region_count;
        public string loader;
        public List<entry_region> region;
        public bool v6;
        public bool old_ldr;
        public DA(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void setfilename(string loaderfilename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}