using SharpMTKClient.Class;
using SharpMTKClient.Class.Protocol.Native;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediatekNaiveProtocol.Mediatek.crypto
{
    public class Cqdma
    {
        internal class CqdmaReg
        {
            public Features ft;
            public Dictionary<string, uint> Data { get; private set; } = new Dictionary<string, uint>();

            internal uint this[string key, int baseAddress = 0]
            {
                get
                {
                    if (regval.TryGetValue(key, out var value))
                    {
                        return ft.xflash.readmem(value + util.config.chipconfig.cqdma_base + Convert.ToUInt32(baseAddress), 1)[0];
                    }

                    if (Data.TryGetValue(key, out var value2))
                    {
                        return value2;
                    }

                    return uint.MaxValue;
                }

                set
                {
                    if (regval.TryGetValue(key, out var value2))
                    {
                        ft.xflash.custom_writeregister((value2 + util.config.chipconfig.cqdma_base + Convert.ToUInt32(baseAddress)), value);
                    }
                    else
                    {
                        Data[key] = value;
                    }
                }
            }

            public CqdmaReg(Features ft)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        private static IReadOnlyDictionary<string, ushort> regval = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readonly CqdmaReg _cqdmaReg;
        public Features ft;
        public Cqdma(Features ft)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] CqRead32(uint address, int dwords)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void CqWrite32(uint address, params uint[] dwords)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] MemRead(uint address, int length, bool ucqdma = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void MemWrite(uint address, byte[] data, bool ucqdma = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void DisableRangeBlackList()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}