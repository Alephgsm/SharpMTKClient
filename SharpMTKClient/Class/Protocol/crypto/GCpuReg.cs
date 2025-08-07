using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native.crypto
{
    public class GCpuReg
    {
        public uint GCPU_REG_CTL = 0;
        public uint GCPU_REG_MSC = 4;
        public uint GCPU_REG_PC_CTL = 0x400;
        public uint GCPU_REG_MEM_ADDR = 0x404;
        public uint GCPU_REG_MEM_DATA = 0x408;
        public uint GCPU_REG_READ_REG = 0x410;
        public uint GCPU_REG_MONCTL = 0x414;
        public uint GCPU_REG_DRAM_MON = 0x418;
        public uint GCPU_REG_CYC = 0x41c;
        public uint GCPU_REG_DRAM_INST_BASE = 0x420;
        public uint GCPU_REG_TRAP_START = 0x440;
        public uint GCPU_REG_TRAP_END = 0x478;
        public uint GCPU_REG_INT_SET = 0x800;
        public uint GCPU_REG_INT_CLR = 0x804;
        public uint GCPU_REG_INT_EN = 0x808;
        public uint GCPU_REG_MEM_CMD = 0xC00;
        public uint GCPU_REG_MEM_P0 = 0xC04;
        public uint GCPU_REG_MEM_P1 = 0xC08;
        public uint GCPU_REG_MEM_P2 = 0xC0C;
        public uint GCPU_REG_MEM_P3 = 0xC10;
        public uint GCPU_REG_MEM_P4 = 0xC14;
        public uint GCPU_REG_MEM_P5 = 0xC18;
        public uint GCPU_REG_MEM_P6 = 0xC1C;
        public uint GCPU_REG_MEM_P7 = 0xC20;
        public uint GCPU_REG_MEM_P8 = 0xC24;
        public uint GCPU_REG_MEM_P9 = 0xC28;
        public uint GCPU_REG_MEM_P10 = 0xC2C;
        public uint GCPU_REG_MEM_P11 = 0xC30;
        public uint GCPU_REG_MEM_P12 = 0xC34;
        public uint GCPU_REG_MEM_P13 = 0xC38;
        public uint GCPU_REG_MEM_P14 = 0xC3C;
        public uint GCPU_REG_MEM_Slot = 0xC40;
        public Dictionary<string, uint> regval;
        public bool setattr(string key, uint value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint getattribute(string key)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint gcpu_base;
        public write32Delegate write32;
        public read32Delegate read32;
        public GCpuReg(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}