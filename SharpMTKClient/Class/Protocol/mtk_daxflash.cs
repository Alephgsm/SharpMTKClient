using MediatekNaiveProtocol.Mediatek;
using MediatekNaiveProtocol.Mediatek.crypto;
using SharpMTKClient.Class.Protocol.Native.DAconf;
using SharpMTKClient.Class.Protocol.xml;
using SharpMTKClient.Class.USBAdapter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static SharpMTKClient.Class.Protocol.Native.Features;
using static SharpMTKClient.Class.Protocol.Native.gpt;
using static SharpMTKClient.Class.Protocol.Native.Port;
using static SharpMTKClient.Class.util;

namespace SharpMTKClient.Class.Protocol.Native
{
    public delegate void ProgressChangedDelegate(ulong max, ulong value);
    public delegate void ProcessStatus(bool IsRunning);
    public class mtk_daxflash
    {
        public class Cmd
        {
            public const uint MAGIC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SYNC_SIGNAL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint UNKNOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DOWNLOAD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint UPLOAD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint FORMAT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint WRITE_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint READ_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint FORMAT_PARTITION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SHUTDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint BOOT_TO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DEVICE_CTRL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint INIT_EXT_RAM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SWITCH_USB_SPEED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint READ_OTP_ZONE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint WRITE_OTP_ZONE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint WRITE_EFUSE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint READ_EFUSE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint NAND_BMT_REMARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_ENVIRONMENT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_HW_INIT_PARAMS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_BMT_PERCENTAGE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_BATTERY_OPT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_CHECKSUM_LEVEL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SLA_ENABLED_STATUS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_RESET_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_HOST_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_META_BOOT_MODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_EMMC_HWRESET_PIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_GENERATE_GPX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_REGISTER_VALUE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_EXTERNAL_SIG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_REMOTE_SEC_POLICY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_ALL_IN_ONE_SIG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_RSC_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_UPDATE_FW = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_UFS_CONFIG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint GET_EMMC_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint GET_NAND_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_NOR_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_UFS_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_VERSION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_EXPIRE_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_PACKET_LENGTH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_RANDOM_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_PARTITION_TBL_CATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_CONNECTION_AGENT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_USB_SPEED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_RAM_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_CHIP_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_OTP_LOCK_STATUS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_BATTERY_VOLTAGE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_RPMB_STATUS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_EXPIRE_DATE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_DRAM_TYPE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_DEV_FW_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_HRID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int GET_ERROR_DETAIL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int START_DL_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int END_DL_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int ACT_LOCK_OTP_ZONE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int DISABLE_EMMC_HWRESET_PIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CC_OPTIONAL_DOWNLOAD_ACT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int DA_STOR_LIFE_CYCLE_CHECK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UNKNOWN_CTRL_CODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CTRL_STORAGE_TEST = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CTRL_RAM_TEST = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int DEVICE_CTRL_READ_REGISTER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class XCmd
        {
            public const uint CUSTOM_ACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_READMEM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_READREGISTER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_WRITEMEM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_WRITEREGISTER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_SET_STORAGE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_RPMB_SET_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_RPMB_PROG_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_RPMB_INIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_RPMB_READ = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_RPMB_WRITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_SEJ_HW = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_INIT_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_READ_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_WRITE_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_INIT_UFS_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_READ_UFS_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_WRITE_UFS_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint CUSTOM_SET_RPMB_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class DataType
        {
            public const int DT_PROTOCOL_FLOW = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int DT_MESSAGE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class FtSystemOSE
        {
            public const int OS_WIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int OS_LINUX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class DaStorage
        {
            public const byte MTK_DA_STORAGE_EMMC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_SDMMC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_UFS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NAND = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NAND_SLC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NAND_MLC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NAND_TLC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NAND_AMLC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NAND_SPI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NOR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NOR_SERIAL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_STORAGE_NOR_PARALLEL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class EmmcPartitionType
        {
            public const byte MTK_DA_EMMC_PART_BOOT1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_BOOT2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_GP1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_GP2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_GP3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_GP4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_USER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_PART_END = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MTK_DA_EMMC_BOOT1_BOOT2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class EMMC_PartitionType
        {
            public const int MTK_DA_EMMC_PART_BOOT1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_BOOT2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_GP1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_GP2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_GP3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_GP4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_USER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_PART_END = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_EMMC_BOOT1_BOOT2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class UFS_PartitionType
        {
            public const int UFS_LU0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU6 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU7 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_LU8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public struct EmmcInfo
        {
            public uint type; // emmc or sdmmc or none
            public ulong block_size;
            public ulong boot1_size;
            public ulong boot2_size;
            public ulong rpmb_size;
            public ulong gp1_size;
            public ulong gp2_size;
            public ulong gp3_size;
            public ulong gp4_size;
            public ulong user_size;
            public byte[] cid;
            public ulong fwver;
            public byte[] unknown;
        }

        public struct UfsInfo
        {
            public uint type; // nor, none
            public uint block_size;
            public ulong lu0_size;
            public ulong lu1_size;
            public ulong lu2_size;
            public ulong lu3_size;
            public ulong lu4_size;
            public byte[] cid;
            public uint fwver;
            public byte[] serial;
        }

        public struct RamInfo
        {
            public ulong sramtype;
            public ulong dramtype;
            public ulong srambase_address;
            public ulong drambase_address;
            public ulong dramsize;
            public ulong sramsize;
        }

        public struct ChipId
        {
            public ushort chip_hw_code;
            public ushort chip_hw_sub_code;
            public ushort chip_hw_version;
            public ushort chip_sw_version;
            public uint chip_evolution;
        }

        public struct NandInfo
        {
            public uint type; // slc, mlc, spi, none
            public uint page_size;
            public uint block_size;
            public uint spare_size;
            public ulong total_size;
            public ulong available_size;
            public uint nand_bmt_exist;
            public object[] nand_id;
        }

        public struct Packetlen
        {
            public int write_packet_length;
            public int read_packet_length;
        }

        public struct NandExtension
        {
            // uni=0, multi=1
            public int cellusage;
            // logical=0, physical=1, physical_pmt=2
            public int addr_type;
            // raw=0, ubi_img=1, ftl_img=2
            public int bin_type;
            // operation_type -> spare=0,page=1,page_ecc=2,page_spare_ecc=3,verify=4,page_spare_norandom,page_fdm
            // nand_format_level -> format_normal=0,force=1,mark_bad_block=2,level_end=3
            public int operation_type; // or nand_format_level
            public int sys_slc_percent;
            public int usr_slc_percent;
            public int phy_max_size;
        }

        public struct NorInfo
        {
            public uint type; // nor, none
            public uint page_size;
            public ulong available_size;
        }

        public struct Chipid
        {
            public ushort hw_code;
            public ushort hw_sub_code;
            public ushort hw_version;
            public ushort sw_version;
            public ushort chip_evolution;
        }

        public bool daext;
        public byte[] randomid;
        public Chipid chipid;
        public EmmcInfo emmc;
        public NandInfo nand;
        public NorInfo nor;
        public UfsInfo ufs;
        public RamInfo ram;
        public event LogDelegate log;
        public event ProgressChangedDelegate ProgressChanged;
        public Features ft;
        public bool patch;
        public Partition partition;
        public List<string> rpmb_error = new List<string>
        {
            "",
            "General failure",
            "Authentication failure",
            "Counter failure",
            "Address failure",
            "Write failure",
            "Read failure",
            "Authentication key not yet programmed"
        };
        public Dictionary<string, string> generate_keys()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] read_fuse(int idx)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_hrid()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] read_pubk()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_hwcode()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_otp()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool handle_sla(bool isbrom = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public mtk_daxflash(Features features)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool custom_writeregister(uint addr, uint data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool custom_write(uint addr, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writemem(uint addr, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writemem(uint addr, uint[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writeregister(uint addr, object dwords)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool cmd_write_name(ulong length, string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] cmd_pkt_param(int lenght)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write_flash(ulong length, string partitionname, string filepath, string ptype = null, byte[] wdata = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writeflash(ulong addr, ulong len, string filename = "", int offset = 0, string ptype = null, byte[] wdata = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WritePreloader(ulong len, byte[] dtne)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cmd_write_data(string partition_name, ulong filelen)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cmd_write_data(ulong addr, ulong size, int storage = DaStorage.MTK_DA_STORAGE_EMMC, int parttype = EMMC_PartitionType.MTK_DA_EMMC_PART_USER)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> readmem(uint addr, int dwords = 1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] custom_read(uint addr, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] custom_read_reg(uint addr, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] custom_readregister(uint addr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cmd2(uint cmd)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cmd(uint cmd)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], byte[]> patch_da(byte[] da1, byte[] da2)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static Tuple<int, int> find_da_hash_V6(byte[] da1, int siglen)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static Tuple<int, int> find_da_hash_V5(byte[] da1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static Tuple<int, int, int> compute_hash_pos(byte[] da1, byte[] da2, int da1sig_len, int da2sig_len, bool v6)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static Tuple<int, int> calc_da_hash(byte[] da1, byte[] da2)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<int, int, ulong> getstorage(string parttype, ulong length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<int, int, ulong> partitiontype_and_size(int storage, string Parttype = null, ulong length = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct XreadFlashResult
        {
            public bool status;
            public byte[] data;
        }

        public Tuple<bool, string> custom_rpmb_init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Erase_rpmb()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool erase_rpmb()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<bool, string> read_rpmbkey()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region "RPMBNEW"
        public class SEC_CMD
        {
            public const int MTK_RUN_HWC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_ENC_DEC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MMC_RST_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_RST_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MMC_READ_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int UFS_READ_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint MMC_SEND_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint UFS_SEND_RPMB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_PERM_CMD0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_PERM_CMD1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; //0x74000
        }

        public class MAIN_CMD
        {
            public const int MTK_SYNC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTKCMD01 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTKRET04 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTKCMD08 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTKRET00 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTKACKFF = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTRETLEN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECSBCEN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECSLAEN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECDAAEN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECEPARM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECRCERT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECMREAD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECMSEND = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SECCDMC8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_INIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_DEINIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_WRITE8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_READ8 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_SET_SPEED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_INIT_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_DEINIT_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_WRITE8_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_READ8_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_I2C_SET_SPEED_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_PWR_INIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_PWR_DEINIT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_PWR_READ16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_PWR_WRITE16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_READ16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_READ32 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_WRITE16 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_WRITE16_NO_ECHO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_WRITE32 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_JUMP_DA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_JUMP_BL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_SEND_DA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_GET_TGT_CFG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_ENV_PREPARE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int MTK_DA_FINISH_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_SEND_CERT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_GET_ME_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_SEND_AUTH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_SLA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_GET_SOC_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_GET_BROM_LOG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_UART1_LOG_EN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_DA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_GET_HW_SW_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_CMD_GET_HW_CODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_SCMD_GET_BROM_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_NFB_DETECTION_MW01 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_NFB_DETECTION_ME01 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_NFB_DETECTION_ME02 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BROM_NFB_DETECTION_ME03 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_CMD_SEND_PARTITION_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_CMD_JUMP_TO_PARTITION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_CMD_JUMP_MAUI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_CMD_READY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_CMD_GET_MAUI_FW_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_CMD_GET_BLDR_VER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_STATUS_READY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_STATUS_SECURE_RO_NOT_FOUND = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int BLDR_STATUS_SUSBDL_NOT_SUPPORTED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public long readack()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool DA_RPMBEmmcUFSInit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool DA_WRITERPMB()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write_rpmb_m2(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool DA_WRITERPMB(int sector, byte[] data, bool ufs = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
        public bool Write_rpmb(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write_rpmb(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool custom_rpmb_write(int sector, byte[] data, bool ufs = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool custom_rpmb_write(int sector, int sectors, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<bool, string> custom_rpmb_init_Key()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public MediatekNaiveProtocol.Mediatek.OldSecCfg.hwcrypto cryptosetup()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool read_rpmb(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] custom_rpmb_read(int sector, int sectors)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool formatflash(ulong addr, ulong len, string parttype = "", bool printlog = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public enum ShutDownModes : int
        {
            NORMAL = 0,
            HOME_SCREEN = 1,
            FASTBOOT = 2
        }

        public bool Shutdown(ShutDownModes bootmode = ShutDownModes.NORMAL)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public XreadFlashResult ReadFlash(string partitionname, string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public XreadFlashResult readflash(ulong addr, ulong len, string filename, string parttype = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct AckResult
        {
            public bool status;
            public long result;
        }

        public AckResult ack(bool rstatus = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int GetPartitionTBLA()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Packetlen get_packet_length()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cmd_readdata(string partition)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cmd_read_data(ulong addr, ulong size, int storage = DaStorage.MTK_DA_STORAGE_EMMC, int parttype = EMMC_PartitionType.MTK_DA_EMMC_PART_USER)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void bypass1stDA()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool send_xf_cmd(uint cmd, bool ack = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SECDAInitCrypto()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool upload_da()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void reinit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public HWCrypto cryptosetup()
        //{
        //    //var setup = new crypto_setup();
        //    //setup.blacklist = util.MediatekService.AuthBypass.blacklist;
        //    //setup.gcpu_base = util.MediatekService.AuthBypass.gcpu_base;
        //    //setup.dxcc_base = util.MediatekService.AuthBypass.dxcc_base;
        //    //setup.efuse_base = util.MediatekService.AuthBypass.efuse_addr;
        //    //setup.da_payload_addr = util.MediatekService.AuthBypass.da_payload_addr;
        //    //setup.sej_base = util.MediatekService.AuthBypass.sej_base;
        //    //setup.hwcode = features.hwcode;
        //    ////setup.cqdma_base = util.MediatekService.AuthBypass.cqdma_base;
        //    ////setup.ap_dma_mem = util.MediatekService.AuthBypass.ap_dma_mem;
        //    ////setup.meid_addr = util.MediatekService.AuthBypass.meid_addr;
        //    ////setup.socid_addr = util.MediatekService.AuthBypass.socid_addr;
        //    //setup.write32 = writeregister;
        //    //setup.writemem = writemem;
        //    //setup.read32 = readmem;
        //    return new HWCrypto(features);
        //}
        public void setotp(MediatekNaiveProtocol.Mediatek.OldSecCfg.hwcrypto hwc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void setotp(HWCrypto hwc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Reboot()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SecCfg(bool unlock)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], List<partf>> read_pmt()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_usb_speed()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_usb_speed()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_random_id()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Chipid get_chip_id()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public NorInfo get_nor_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public NandInfo get_nand_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public RamInfo get_ram_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_dev_fw_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool handle_sla(byte[] da2)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_remote_sec_policy(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_all_in_one_sig(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int get_sla_status()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool boot_to(ulong at_address, byte[] da, uint ret = Cmd.SYNC_SIGNAL)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool send_data(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool send_emi(byte[] emi)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public UfsInfo Get_ufs_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public EmmcInfo get_emmc_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_connection_agent()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_checksum_level(int checksum_level = 0x0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_reset_key(int reset_key = 0x68)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_battery_otp()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] get_expire_date()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct devctrl
        {
            public bool status;
            public byte[] data;
        }

        public bool custom_set_storage(bool ufs = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public devctrl send_devctrl(uint cmd, byte[] param = null, List<long> status = null, bool WriteBl = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] xread()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool setup_hw_init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool PLSetupENV()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool setup_env()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool sync()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool xsend(object data, int datatype = DataType.DT_PROTOCOL_FLOW, bool is64bit = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool send_param(object paramss)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public long status()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool bypass_2nd_da()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool upload_da1()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}