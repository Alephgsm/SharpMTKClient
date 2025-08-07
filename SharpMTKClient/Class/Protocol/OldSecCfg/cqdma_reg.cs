using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class cqdma_reg
    {
        public uint cqdma_base;
        public read32Delegate read32;
        public write32Delegate write32;
        public cqdma_reg(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}