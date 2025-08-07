using SharpMTKClient.Class.Protocol.Native.DAconf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.MediatekService;

namespace SharpMTKClient.Class.Protocol.Native.DAconf
{
    public class DAconfig
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct da_hdr
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string m_title;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string m_version;
            public uint m_unknown;
            public uint m_magic;
            public int m_count;
        }

        public struct da_geometry
        {
            public uint m_offset;
            public uint m_length;
            public uint m_startaddr;
            public uint m_startoffset;
            public uint m_siglen;
        }

        public struct da_entry
        {
            public short m_magic;
            public short m_hwcode;
            public short m_hwsub;
            public short m_hwver;
            public short m_swver;
            public short m_unknown;
            public short m_pagesize;
            public short m_reserved;
            public short m_region_index;
            public short m_region_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public da_geometry[] m_geometries;
        }

        public static class Storage
        {
            public const int MTK_DA_HW_STORAGE_NOR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_HW_STORAGE_NAND = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_HW_STORAGE_EMMC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_HW_STORAGE_SDMMC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_HW_STORAGE_UFS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public static class Memory
        {
            public const int M_EMMC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int M_NAND = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int M_NOR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public static class NandCellUsage
        {
            public const int CELL_UNI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_BINARY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_TRI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_QUAD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_PENTA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_HEX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_HEPT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CELL_OCT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public string m_socString;
        public ushort m_socId;
        public ulong flashsize;
        public string flashtype;
        public uint sparesize;
        public ulong readsize;
        public uint pagesize = 512;
        public DA da_loader;
        public byte[] da2;
        public byte[] emi;
        public byte[] otp;
        public int emiver;
        public byte[] preloader;
        public string loader;
        public bool v6;
        //public Dictionary<string , List<List<Dictionary<string, Tvalue>>>> dasetup;
        public Dictionary<uint, List<DA>> dasetup;
        internal ulong rpmbsize;
        internal ulong boot1size;
        internal ulong boot2size;
        //public struct Tvalue
        //{
        //    public string Type;
        //    public uint IntValue; 
        //    public byte[] ByteValue;
        //    public string StringValue; 
        //}
        public DAconfig(string[] loaderlist = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public Dictionary<string, Tvalue> DA;
        //public Dictionary<string, Tvalue> entry_region;
        public int calcsize(char type)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public Dictionary<string, Tvalue> read_object(byte[] data , Dictionary<string, Tvalue> obj )
        //{
        //    var dicof = new Dictionary<string, Tvalue>();
        //    foreach(var i in obj)
        //    {
        //        dicof.Add(i.Key, i.Value);
        //    }
        //    var object_size = 0;
        //    var pos = 0;
        //    foreach(var item in obj)
        //    {
        //        var sz = calcsize(item.Value.Type.ToCharArray()[0]);
        //        object_size += sz;
        //        dicof[item.Key] = new Tvalue
        //        {
        //            Type = dicof[item.Key].Type,
        //            IntValue = Convert.ToUInt32(StructConverter.Unpack(item.Value.Type, util.GetFromIndex(data, pos, sz))[0])
        //        }
        //        pos += sz;
        //    }
        //    dicof.Add("object_size", new Tvalue { IntValue = Convert.ToUInt32(object_size), Type = dicof.ElementAt(0).Value.Type });
        //    dicof.Add("raw_data", new Tvalue { ByteValue = data, Type = dicof.ElementAt(0).Value.Type });
        //    return dicof;
        //}
        //public bool parse_da_loader(string loader)
        //{
        //    if(dasetup.ContainsKey(loader))
        //    {
        //        return true;
        //    }
        //    dasetup.Add(loader, new List<List<Dictionary<string, Tvalue>>>());
        //    using (var bootldr = File.OpenRead(loader))
        //    {
        //        // data = bootldr.read()
        //        // self.debug(hexlify(data).decode('utf-8'))
        //        bootldr.Seek(0x68, SeekOrigin.Begin);
        //        var buffer = new byte[4];
        //        bootldr.Read(buffer, 0, 4);
        //        var count_da = Convert.ToUInt32(StructConverter.Unpack("<I", buffer)[0]);
        //        var setup =new List<Dictionary<string, Tvalue>>();
        //        foreach (var i in Enumerable.Range(0,(int)count_da))
        //        {
        //            bootldr.Seek(0x6C + (i * 0xDC), SeekOrigin.Begin);
        //            var BufferGet = new byte[0x14];
        //            bootldr.Read(BufferGet, 0, BufferGet.Length);
        //            var datmp = read_object(BufferGet, DA);
        //            datmp.Add("loader", new Tvalue { StringValue = loader, Type = datmp.ElementAt(0).Value.Type });
        //            var da = new List<Dictionary<string, Tvalue>>();
        //            da.Add(datmp);
        //            var count = (int)datmp["entry_region_count"].IntValue;
        //            foreach (var m in Enumerable.Range(0, count))
        //            {
        //                var Bf = new byte[20];
        //                bootldr.Read(Bf, 0, 20);
        //                var entry_tmp = read_object(Bf, entry_region);
        //                da.Add(entry_tmp);
        //            }
        //            dasetup[loader].Add(da);
        //        }
        //        bootldr.Close();
        //        return true;
        //    }
        //}
        public bool parse_da_loader(string loader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool setup2(int hwver, string chip)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool setup(int hwver, int swver)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void extract_emi(byte[] preloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void get_otp(byte[] preloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<int?, byte[]> m_extract_emi(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}