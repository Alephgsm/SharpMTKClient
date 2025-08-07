using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharpMTKClient.Class.Protocol.xml
{
    public class mtk
    {
        public string Partition_index;
        public string Partition_name;
        public string File_name;
        public string Is_download;
        public string Is_upgradable;
        public string Linear_start_addr;
        public string Partition_size;
        public mtk(string Partition_index, string Partition_name, string File_name, string Is_download, string Is_upgradable, string Linear_start_addr, string Partition_size)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    public class mtkxml
    {
        private static string xmlpatch = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static string platform
        {
            get
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            set
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public static string storage
        {
            get
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            set
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public static bool IsSupport(string scatterfile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static List<mtk> ScatterTable(string scatterfile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}