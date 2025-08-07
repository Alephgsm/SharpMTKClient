using SharpMTKClient.Class.Protocol.Native.DAconf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using static SharpMTKClient.Class.Protocol.Native.gpt;
using static SharpMTKClient.Class.Protocol.Native.mtk_daxflash;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using MediatekNaiveProtocol.Mediatek;
using System.Numerics;
using static SharpMTKClient.Class.util;
using SharpMTKClient.Class.USBAdapter;
using static SharpMTKClient.Class.Protocol.MediatekService;
using System.Runtime.InteropServices.ComTypes;
using SharpMTKClient.Class.Protocol.xml;
using System.Runtime;
using static MediatekNaiveProtocol.Mediatek.OldSecCfg.dxcc;
using System.Windows.Forms;
using SharpMTKClient.Class.Protocol.FlashToolLib;
using System.Runtime.ConstrainedExecution;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class Features
    {
        public DeviceType devicetype;
        public int SECTOR_SIZE_IN_BYTES = 4096; //fixme
        public int baudrate = 115200;
        public int packetsizeread = 0x400;
        public int sparesize = 16;
        public int blver = -2;
        public int bromver = -1;
        public event LogDelegate log;
        public ItypePort Find;
        public HwDict hwdic;
        public HwCode HW_Code;
        public Target_Config target_config;
        public byte[] meid;
        public byte[] SOCID;
        public byte[] CID;
        public byte[] otp;
        public mtk_daxflash xflash;
        public mtk_dalegacy dalegacy;
        public xml_lib xmlib;
        //public PLTools plt;
        public MtkClient Client;
        public AuthResult Security_bypass;
        public Port SerialPort;
        public bool display;
        public damodes flashmode;
        public int hwcode;
        public List<uint> plcap;
        public int linecode;
        public DAconfig Config;
        public uint revdword(uint addr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public class Cmd
        {
            // if CFG_PRELOADER_AS_DA
            public const uint SET_REMOTE_SEC_POLICY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SEND_PARTITION_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte JUMP_TO_PARTITION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CHECK_USB_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte STAY_STILL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CMD_88 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CMD_READ16_A2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_INIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_DEINIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_WRITE8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_READ8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_SET_SPEED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_INIT_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_DEINIT_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // JUMP_MAUI
            public const byte I2C_WRITE8_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // READY
            /*
                                                      Boot-loader resposne from BLDR_CMD_READY (0xB8)
                                                     STATUS_READY    public const byte     public const byte 0x00    public const byte // secure RO is found and ready to serve
                                                     STATUS_SECURE_RO_NOT_FOUND  0x01    public const byte // secure RO is not found: first download? => dead end...
                                                     STATUS_SUSBDL_NOT_SUPPORTED 0x02    public const byte // BL didn't enable Secure USB DL
                                                     */
            public const byte I2C_READ8_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte I2C_SET_SPEED_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_MAUI_FW_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OLD_SLA_SEND_AUTH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OLD_SLA_GET_RN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OLD_SLA_VERIFY_RN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_INIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_DEINIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_READ16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_WRITE16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CMD_C8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // RE
            public const byte READ16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ32 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE16_NO_ECHO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE32 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte JUMP_DA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte JUMP_BL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SEND_DA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_TARGET_CONFIG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SEND_ENV_PREPARE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte brom_register_access = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UART1_LOG_EN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UART1_SET_BAUDRATE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // RE
            public const byte BROM_DEBUGLOG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // RE
            public const byte JUMP_DA64 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // RE
            public const byte GET_BROM_LOG_NEW = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // RE
            public const byte SEND_CERT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_ME_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SEND_AUTH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SLA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CMD_E4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CMD_E5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CMD_E6 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_SOC_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte ZEROIZATION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_PL_CAP = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_HW_SW_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_HW_CODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_BL_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_VERSION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public struct PreloaderDump
        {
            public bool status;
            public byte[] data;
            public string filename;
        }

#region "PL Exploit"
        public ushort Checksum16Xor(byte[] data, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct Packet
        {
            public ulong val;
            public uint addr;
        }

        public uint m_code;
        public byte[] peek(uint addr, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] peek_reg(uint addr, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool xflashReadData(uint cmd, ref byte[] result, bool mainCmd)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool xflashCmd(uint cmd, byte[] arg, int arglen, ref byte[] result, bool skipArgStatus = false, bool skipCmdStatus = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool xflashCmd(uint cmd, byte[] arg, int arglen, ref byte[] data, int datalen, ref byte[] result, bool skipDataStatus = false, bool skipArgStatus = false, bool skipCmdStatus = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool xflashCmd(uint cmd, ref byte[] result, bool skipStatus = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DevEnv
        {
            public uint m_level;
            public uint m_channel;
            public uint m_osType;
            public uint m_provision;
            public uint m_reserved;
        }

        public bool xflashDevCtrl(uint cmd, int val, ref byte[] result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool xflashDevCtrl(uint cmd, byte[] arg, int arglen, ref byte[] result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SecurityDA
        {
            public uint is_security_enabled;
            public uint sec_enc_seccfg;
            public uint mmc_get_card;
            public uint mmc_set_part_config;
            public uint mmc_rpmb_send_command;
            public uint tzclk_on_addr;
            public uint tzclk_on_value;
            public uint tzclk_off_addr;
            public uint tzclk_off_value;
            public uint dxcc_base;
            public uint g_ufs_hba;
            public uint ufshcd_get_free_tag;
            public uint ufshcd_queuecommand;
            public uint ufshcd_put_tag;
            public uint mmc_permanent_cmd;
            public uint mmc_permanent_patch;
        }

        public enum XflashStorageType : uint
        {
            STOR_UNKNOWN = 0,
            STOR_NONE = STOR_UNKNOWN,
            STOR_EMMC,
            STOR_SDMMC,
            STOR_EMMC_END = 0xf,
            STOR_NAND,
            STOR_NAND_SLC,
            STOR_NAND_MLC,
            STOR_NAND_TLC,
            STOR_NAND_AMLC,
            STOR_NAND_SPI,
            SOTR_NAND_3DMLC,
            STOR_NAND_END = 0x1f,
            STOR_NOR,
            STOR_NOR_SERIAL,
            STOR_NOR_PARALLEL,
            STOR_NOR_END = 0x2f,
            STOR_UFS
        }
        public XflashStorageType m_stor;
        public struct RebootArg
        {
            public uint reboot; // 1 - valid, 0 invalid
            public uint timeout; // in ms
            public uint async; // 1 - disconnect before watchdg; 0 - disconnect after watchdg
            public uint bootup; // 1 - charging mode, 0 - bootup
            public uint dlbit;
            public uint resetRTCTime;
        }

        //public class DiskEntry
        //{
        //    public string Partition { get; set; } = "";
        //    public ulong Offset { get; set; }
        //    public ulong Length { get; set; } = 0;
        //    public uint PartId { get; set; } = 0;
        //}
        //[StructLayout(LayoutKind.Sequential, Pack = 1)]
        //public struct GuidUuid
        //{
        //    public uint TimeLow;
        //    public ushort TimeMid;
        //    public ushort TimeHiAndVersion;
        //    public byte ClkSeqHiRes;
        //    public byte ClkSeqLo;
        //    public ushort Node01;
        //    public uint Node25;
        //}
        //[StructLayout(LayoutKind.Sequential, Pack = 1)]
        //public struct GuidHeader
        //{
        //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        //    public byte[] Magic;
        //    public uint Revision;
        //    public uint HeaderSize;
        //    public uint HeaderCRC;
        //    public uint Reserved1;
        //    public ulong CurrentLBA;
        //    public ulong BackupLBA;
        //    public ulong FirstUsableLBA;
        //    public ulong LastUsableLBA;
        //    public GuidUuid DiskGuid;
        //    public ulong StartLBA;
        //    public uint NumPartEntries;
        //    public uint PartEntrySize;
        //    public uint EntriesCRC;
        //}
        //[StructLayout(LayoutKind.Sequential, Pack = 1)]
        //public struct GuidEntry
        //{
        //    public GuidUuid TypeGuid;
        //    public GuidUuid PartGuid;
        //    public ulong FirstLBA;
        //    public ulong LastLBA;
        //    public ulong Attribute;
        //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        //    public ushort[] PartName;
        //}
        public enum LockState : uint
        {
            Unknown,
            Default,
            MpDefault,
            Unlock,
            Lock,
            Verified,
            Custom
        }

        public enum CriticalState : uint
        {
            Unknown,
            Unlock,
            Lock
        }

        public enum SbootRuntime : uint
        {
            Off,
            On
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct sec_flag
        {
            public uint m_magic;
            public uint m_ver;
            public uint m_size;
            public LockState m_lockstate;
            public CriticalState m_criticallock;
            public SbootRuntime m_sbootruntime;
            public uint m_mark;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] m_encData;
        }

        public int m_sectorsize = 512;
        public List<partf> m_root = new List<partf>();
        public ulong m_ua_size, m_boot1, m_rpmb;
        public byte m_ua_id;
        public struct OperationArg
        {
            public XflashStorageType storage_type;
            public uint partition_type;
            public ulong offset;
            public ulong length;
            public nandExtension nandExt;
        }

        public struct nandExtension
        {
            public uint m_cell_usage;
            public uint m_addr_type;
            public uint m_bin_type;
            public uint m_region;
            public uint m_operation_type;
            public uint m_format_level;
            public uint m_sys_slc_percent;
            public uint m_usr_slc_percent;
            public uint m_phy_max_size;
        }

        public bool readBuf(ref byte[] data, ulong offset, uint len, uint id)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadSectors(ref byte[] data, ulong startSector, uint numSectors, uint id)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ParseGpt()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Packetlen m_pktlen;
        public bool WriteBuf(byte[] data, ulong offset, uint len, string partition, uint id)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private ushort Checksum16Csum(byte[] data, int len, bool mtk = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static bool SearchEntries(List<partf> root, ref partf target, ref partf entry, List<string> search)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ShutDown(ShutDownModes mode = ShutDownModes.HOME_SCREEN)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Reboot()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadInfo()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool GetDAReport()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] GenerateSecondToken(byte[] a)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte MakeSecondTokenByte(int a, int b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ResetFactory()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> MakeDerivedPairFromDa2(uint[] a)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte MakeByteForPlainMsgPart1(byte a, byte b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte MakeByteForPlainMsgPart2(byte a, byte b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] m_staticToken = new byte[]
        {
            0xBB,
            0x5A,
            0xDB,
            0xC7,
            0xBC,
            0x34,
            0x3C,
            0x50,
            0x5B,
            0xCE,
            0xD4,
            0x6C,
            0x8C,
            0x67,
            0xED,
            0x4F
        };
        private List<uint> rightOperandKeyList = new List<uint>();
        private List<uint> thirdTokenDwordList = new List<uint>();
        private List<uint> lastDACipherList = new List<uint>();
        public Features()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] GeneratePlainMessage(byte[] a, byte[] b)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        byte[] SerializeStruct<T>(T structure)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] crypt(byte[] key, byte[] iv, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DaArg
        {
            public ulong addr;
            public ulong len;
        }

        public bool Send2ndDA(byte[] data, uint addr, int len, bool sync = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SetBromArgument()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
        public PreloaderDump dump_preloader_ram()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool InitDevice(bool Handshake = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public PreloaderDump dump_preloader_ramNew()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<int, int, int> bmtsettings(int hwcode, string flash)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void set_stage2_config(string flash)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] brom_register_access(uint address, int length, byte[] data = null, bool check_result = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] ReadPreloader(byte[] PreloaderReadPacket)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] da_write(uint address, uint length, byte[] data, bool check_result = true, bool reopen = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] da_read_write(uint address, uint length, byte[] data = null, bool check_result = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void kamakiri2(int addr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public async Task kamakiri2(int addr)
        //{
        //    var device = await SerialPortComm.FindListUSB(Find, 500);
        //    try
        //    {
        //        if (device != null)
        //        {
        //            IUsbDevice wDev = device as IUsbDevice;
        //            if (wDev is IUsbDevice)
        //            {
        //                wDev.SetConfiguration(1);
        //                wDev.ClaimInterface(0);
        //                if (!wDev.IsOpen)
        //                {
        //                    wDev.Open();
        //                }
        //                var buffer = new byte[7];
        //                var GetLinePacket = new UsbSetupPacket(0xa1, 0x21, 0x00, 0x00, buffer.Length);
        //                var GetLineResult = wDev.ControlTransfer(ref GetLinePacket, buffer, buffer.Length, out _);
        //                var SetLineArray = new List<byte>();
        //                SetLineArray.AddRange( StructConverter.Pack("<", new object[] { addr }));
        //                var SetLinePacket = new UsbSetupPacket(0x21, 0x20, 0x00, 0x00, SetLineArray.Count);
        //                var SetLineResult = wDev.ControlTransfer(ref SetLinePacket, SetLineArray.ToArray(), SetLineArray.Count, out _);
        //                var reset = new byte[9] ;
        //                var ResetPacket = new UsbSetupPacket(0x80, 0x06, 0x0200, 0x00, reset.Length);
        //                var ResetResult = wDev.ControlTransfer(ref ResetPacket, reset, reset.Length, out _);
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("Cannot install libusb driver, please check your driver signture" );
        //        }
        //    }
        //    finally
        //    {
        //        if (device != null)
        //        {
        //            if (device.IsOpen)
        //            {
        //                IUsbDevice wholeUsbDevice = device as IUsbDevice;
        //                if (!ReferenceEquals(wholeUsbDevice, null))
        //                {
        //                    // Release interface
        //                    wholeUsbDevice.ReleaseInterface(0);
        //                    wholeUsbDevice.Close();
        //                }
        //                device.Close();
        //            }
        //            UsbDevice.Exit();
        //        }
        //    }
        //}
        public byte[] da_read(uint address, uint length, bool check_result = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] brom_register_access(uint address, uint length, byte[] data = null, bool check_status = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool exploit2(byte[] payload, uint payloadaddr = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool exploit(byte[] payload, uint payloadaddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public event ProgressChangedDelegate ProgressChanged;
        public Features(Port SerialPort, MtkClient Client)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Daflash_ProgressChanged(ulong max, ulong value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Daflash_log(string Text, Resut color = Resut.Word)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public enum DeviceType
        {
            brom,
            preloader
        }

        public bool setreg_disablewatchdogtimer(int hwcode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public (ushort gen_chksum, byte[] data) PrepareData(byte[] data, byte[] sigdata = null, int maxsize = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool upload_data(byte[] data, int genChecksum)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool send_root_cert(byte[] cert, int cmd = Cmd.SEND_CERT)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool send_auth(byte[] auth)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool bypass_security()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct AuthResult
        {
            public bool status;
            public bool bypassedSecurity;
            public bool IsV6;
        }

        public AuthResult auth_config(bool forceBypass = false, bool handshake = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool init(bool reinit = false, ItypePort port = default, bool handshake = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Crash(int mode = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool crasher()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write32(uint addr, object Dwords)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write8(byte cmd, int echo)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write16(uint addr, object values)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<partf> ReadPartitions(string[] partitionName, string path, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], partf> ReadPartitionsToBytes(string partitionName, string meta)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Dictionary<string, string> GenerateKeys()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], gpt> ReadGPT()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadRPMB(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool RebootPhone()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteRPMB(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<bool, string> ReadRPMBKey()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool EraseRPMB()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writeflash(ulong addr, ulong len, string filepath = "", int offset = 0, string ptype = null, byte[] wdata = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write_flash(ulong addr, ulong len, string filepath, string partitionname, int offset = 0, string ptype = null, byte[] wdata = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WritePit(byte[] gpt)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] ReadPit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteGPT(byte[] gpt)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WritePreloader(byte[] preloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteGPT(string partfilename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteFlashBytes(byte[] data, partf partition, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteFlashFromFile(string data, partf partition, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteFullFlash(string partfilename, string parttype)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public XreadFlashResult ReadFlash(string partition, string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public XreadFlashResult readflash(ulong addr, ulong len, string filename, string parttype = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool formatflash(ulong addr, ulong len, string parttype = "", bool printlog = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadFullFlash(string filepath, string parttype)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SecCfg(bool unlock)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void set_da()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool upload_da(byte[] preloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool FormatFlashxml(List<partitionaddr> partlist, string xmlscatter)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool FlashUpgradexml(List<partitionaddr> partlist, string xmlscatter)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool FormatPartitions(string[] PList, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writeFlashmode(List<partitionaddr> partlist, bool reset, string scatter, DlmMode mode = DlmMode.DownloadOnly)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool FlashDownload(List<partitionaddr> partlist, string parttype = "user")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> read32(uint addr, int dwords = 1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool BRom_ReadCmd32(uint addr, int val, bool read, int len, bool Ack = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void run_ext_cmd(byte[] cmd = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public void Crasher(bool display=true)
        //{
        //    if(Find.VID.ToUpper() != "0E8D" || Find.PID != "0003")
        //    {
        //        foreach(var crashmode in Enumerable.Range(0 , 3))
        //        {
        //            plt.Crash(crashmode);
        //            this.display = display;
        //        }
        //    }
        //}
        public bool send_da(uint address, int size, int sig_len, byte[] dadata, bool crasher = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool jump_da(uint address)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool upload_data(byte[] data, int gen_chksum, bool crasher = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public (ushort checksum, byte[] resultData) prepare_data(byte[] data, byte[] sigdata, int maxsize = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public enum HandShakeMode
        {
            Zero,
            Freezes,
            DA,
            Unknown
        }

        public bool HandShake()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Target_Config get_target_config()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public HwDict get_hw_sw_ver()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> get_plcap()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] GET_SOC_ID()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int get_blver()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int get_bromver()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_meid()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] Get_Meid()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct HwCode
        {
            public int hwcode;
            public int hwver;
        }

        public void init_hwcode(HwCode hwcode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public HwCode get_hw_code()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] fix_payload(byte[] payload, bool da = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] prepare_payload(byte[] ByteArray, ulong watchdog_address, ulong uart_base)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] AddByteToEndArray(byte[] ByteArray, byte byt)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] IntToByteArray(ulong @int)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] IntToByteArray(ulong @int, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<uint, uint> get_watchdog_addr()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] InsertByteArrayToArray(byte[] a, byte[] b, int index)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ulong GetValueOfByte(byte[] ByteArray, int index, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct Target_Config
        {
            public bool secure_boot;
            public bool sla;
            public bool daa;
            public bool swjtag;
            public bool epp;
            public bool cert;
            public bool memread;
            public bool memwrite;
            public bool cmd_c8;
            public bool Status;
        }

        public struct HwDict
        {
            public int hwsubcode;
            public int hwver;
            public int swver;
            public bool status;
        }
    }
}