using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.xml
{
    public class gptaddr
    {
        public static List<gptaddr> address = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public string name;
        public ulong start;
        public ulong size;
        public gptaddr(string name, ulong start, ulong size)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    public class listpartition
    {
        public static List<listpartition> listspart = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public int value;
        public string partname;
        public string filename;
        public long start;
        public long size;
        public string filpath;
        public listpartition(int value, string partname, string filename, long start, long size, string filpath = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}