using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.xml
{
    public class partitionaddr
    {
        public static List<partitionaddr> partaddr = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public string partname;
        public string filename;
        public string filepath;
        public string startlba;
        public string lateslba;
        public partitionaddr(string partname, string filename, string startlba, string lateslba, string filepath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}