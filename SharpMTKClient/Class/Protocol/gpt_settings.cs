using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class gpt_settings
    {
        public uint gpt_num_part_entries = 0;
        public uint gpt_part_entry_size = 0;
        public uint gpt_part_entry_start_lba = 0;
        public gpt_settings(uint gpt_num_part_entries, uint gpt_part_entry_size, uint gpt_part_entry_start_lba)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}