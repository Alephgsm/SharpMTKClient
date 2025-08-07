using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol
{
    public class Efuse
    {
        public List<uint> efuses = new List<uint>();
        public List<uint> internal_fuses = new List<uint>();
        public List<uint> external_fuses = new List<uint>();
        public Efuse(uint baseAddr, uint hwcode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}