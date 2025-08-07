using SharpMTKClient.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class cqdma
    {
        public int hwcode;
        public uint cqdma_base;
        public uint ap_dma_mem;
        public cqdma_reg reg;
        public crypto_setup setup;
        public read32Delegate read32;
        public write32Delegate write32;
        public cqdma(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<Tuple<string, uint>> regval
        {
            get
            {
                return new List<Tuple<string, uint>>
                {
                    new Tuple<string, uint>("CQDMA_INT_FLAG", 0x0),
                    new Tuple<string, uint>("CQDMA_INT_EN", 0x4),
                    new Tuple<string, uint>("CQDMA_EN", 0x8),
                    new Tuple<string, uint>("CQDMA_RESET", 0xc),
                    new Tuple<string, uint>("CQDMA_FLUSH", 0x14),
                    new Tuple<string, uint>("CQDMA_SRC", 0x1c),
                    new Tuple<string, uint>("CQDMA_DST", 0x20),
                    new Tuple<string, uint>("CQDMA_LEN1", 0x24),
                    new Tuple<string, uint>("CQDMA_LEN2", 0x28),
                    new Tuple<string, uint>("CQDMA_SRC2", 0x60),
                    new Tuple<string, uint>("CQDMA_DST2", 0x64)
                };
            }
        }

        public bool __setattr__(string key, List<uint> value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public List<uint> __getattribute__(string key)
        //{
        //    var addr = regval.Find(func => func.Item1 == key).Item2 + util.MediatekService.AuthBypass.cqdma_base;
        //    return Features.read32(addr);
        //}
        public void disable_range_blacklist()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void cqwrite32(uint addr, List<uint> dwords)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}