using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native.crypto
{
    public delegate List<uint> read32Delegate(uint addr, int dwords = 1);
    public delegate bool write32Delegate(uint addr, object dwords);
    public delegate bool writememDelegate(uint addr, byte[] data);
    public class crypto_setup
    {
        public int hwcode;
        public uint dxcc_base;
        public int efuse_base;
        public uint gcpu_base;
        public uint da_payload_addr;
        public uint sej_base;
        public List<Tuple<uint, uint>> blacklist;
        public read32Delegate read32;
        public write32Delegate write32;
        public writememDelegate writemem;
        public uint meid_addr;
        public uint socid_addr;
        public uint cqdma_base;
        public uint ap_dma_mem;
        public uint prov_addr;
    }
}