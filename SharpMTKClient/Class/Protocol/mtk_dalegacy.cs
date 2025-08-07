using SharpMTKClient.Class.Protocol.Native.DAconf;
using MediatekNaiveProtocol.Mediatek.crypto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.Native.gpt;
using static SharpMTKClient.Class.Protocol.Native.mtk_daxflash;
using static SharpMTKClient.Class.Protocol.Native.Port;
using static SharpMTKClient.Class.util;
using SharpMTKClient.Class.USBAdapter;
using static SharpMTKClient.Class.Protocol.MediatekService;
using System.Windows.Forms;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class mtk_dalegacy
    {
        public class Rsp
        {
            public const byte SOC_OK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SOC_FAIL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SYNC_CHAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CONT_CHAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte STOP_CHAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte ACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UNKNOWN_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class Cmd
        {
            // COMMANDS
            public const byte DOWNLOAD_BLOADER_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NAND_BMT_REMARK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_SWITCH_PART_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_WRITE_IMAGE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_WRITE_DATA_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_GET_CARD_TYPE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_RESET_DIS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_SWITCH_PART_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_WRITE_IMAGE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_WRITE_DATA_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_READ_GPT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_WRITE_GPT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_OTP_CHECKDEVICE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_OTP_GETSIZE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_OTP_READ_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_OTP_PROGRAM_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_OTP_LOCK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UFS_OTP_LOCK_CHECKSTATUS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte USB_SETUP_PORT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte USB_LOOPBACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte USB_CHECK_STATUS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte USB_SETUP_PORT_EX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            // EFUSE
            public const byte READ_REG32_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE_REG32_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_READ16_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_WRITE16_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_READ8_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte PWR_WRITE8_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte EMMC_OTP_CHECKDEVICE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte EMMC_OTP_GETSIZE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte EMMC_OTP_READ_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte EMMC_OTP_PROGRAM_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte EMMC_OTP_LOCK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte EMMC_OTP_LOCK_CHECKSTATUS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE_USB_DOWNLOAD_CONTROL_BIT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE_PARTITION_TBL_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ_PARTITION_TBL_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ_BMT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_WRITE_PMT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_READ_PMT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ_IMEI_PID_SWV_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ_DOWNLOAD_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE_DOWNLOAD_INFO = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SDMMC_WRITE_GPT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NOR_READ_PTB_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NOR_WRITE_PTB_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NOR_BLOCK_INDEX_TO_ADDRESS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte NOR_ADDRESS_TO_BLOCK_INDEX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte NOR_WRITE_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte NAND_WRITE_DATA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_RECHECK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_DECRYPT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NFB_BL_FEATURE_CHECK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte NOR_BL_FEATURE_CHECK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte SF_WRITE_IMAGE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            // Android S-USBDL
            public const byte SECURE_USB_IMG_INFO_CHECK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_WRITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_ROM_INFO_UPDATE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_GET_CUST_NAME_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_CHECK_BYPASS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SECURE_USB_GET_BL_SEC_VER_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            // Android S-USBDL
            public const byte VERIFY_IMG_CHKSUM_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_BATTERY_VOLTAGE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte POST_PROCESS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte SPEED_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte MEM_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FORMAT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte WRITE_REG16_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte READ_REG16_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FINISH_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_DSP_VER_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte ENABLE_WATCHDOG_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NFB_WRITE_BLOADER_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte NAND_IMAGE_LIST_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NFB_WRITE_IMAGE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NAND_READPAGE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CHK_PC_SEC_INFO_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte UPDATE_FLASHTOOL_CFG_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte CUST_PARA_GET_INFO_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte CUST_PARA_READ_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte CUST_PARA_WRITE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte SEC_RO_GET_INFO_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte SEC_RO_READ_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte SEC_RO_WRITE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte ENABLE_DRAM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OTP_CHECKDEVICE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OTP_GETSIZE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OTP_READ_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OTP_PROGRAM_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OTP_LOCK_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte OTP_LOCK_CHECKSTATUS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_PROJECT_ID_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte GET_FAT_INFO_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte FDM_MOUNTDEVICE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_SHUTDOWN_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_READSECTORS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_WRITESECTORS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_MEDIACHANGED_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_DISCARDSECTORS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_GETDISKGEOMETRY_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_LOWLEVELFORMAT_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_NONBLOCKWRITESECTORS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_RECOVERABLEWRITESECTORS_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte FDM_RESUMESECTORSTATES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte NAND_EXTRACT_NFB_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte NAND_INJECT_NFB_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // deprecated
            public const byte MEMORY_TEST_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const byte ENTER_RELAY_MODE_CMD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class norinfo
        {
            public uint m_nor_ret = 0;
            public byte[] m_nor_chip_select;
            public uint m_nor_flash_id = 0;
            public uint m_nor_flash_size = 0;
            public List<ushort> m_nor_flash_dev_code;
            public uint m_nor_flash_otp_status = 0;
            public uint m_nor_flash_otp_size = 0;
            public norinfo(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public class nandinfo64
        {
            public uint m_nand_info = 0;
            public byte[] m_nand_chip_select;
            public uint m_nand_flash_id = 0;
            public ulong m_nand_flash_size = 0;
            public uint m_nand_flash_id_count = 0;
            public nandinfo64(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public List<ushort> m_nand_flash_dev_code { get; set; }
            public nandinfo2 info2 { get; set; }
        }

        public class nandinfo32
        {
            public uint m_nand_info = 0;
            public byte[] m_nand_chip_select;
            public uint m_nand_flash_id = 0;
            public uint m_nand_flash_size = 0;
            public uint m_nand_flash_id_count = 0;
            public nandinfo32(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public nandinfo2 info2 { get; set; }
            public List<ushort> m_nand_flash_dev_code { get; set; }
        }

        public class nandinfo2
        {
            public nandinfo2(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public ushort m_nand_pagesize { get; set; }
            public ushort m_nand_sparesize { get; set; }
            public ushort m_nand_pages_per_block { get; set; }
            public byte[] m_nand_io_interface { get; set; }
            public byte[] m_nand_addr_cycle { get; set; }
            public byte[] m_nand_bmt_exist { get; set; }
            public nandinfo2 info2 { get; set; }
        }

        public class emmcinfo
        {
            public emmcinfo(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public uint m_emmc_ret { get; set; }
            public ulong m_emmc_boot1_size { get; set; }
            public ulong m_emmc_boot2_size { get; set; }
            public ulong m_emmc_rpmb_size { get; set; }
            public List<ulong> m_emmc_gp_size { get; set; }
            public ulong m_emmc_ua_size { get; set; }
            public List<ulong> m_emmc_cid { get; set; }
            public byte[] m_emmc_fwver { get; set; }
        }

        public class sdcinfo
        {
            public sdcinfo(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public uint m_sdmmc_info { get; set; }
            public ulong m_sdmmc_ua_size { get; set; }
            public List<ulong> m_sdmmc_cid { get; set; }
        }

        public class configinfo
        {
            public configinfo(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public uint m_int_sram_ret { get; set; }
            public uint m_int_sram_size { get; set; }
            public uint m_ext_ram_ret { get; set; }
            public byte[] m_ext_ram_type { get; set; }
            public byte[] m_ext_ram_chip_select { get; set; }
            public ulong m_ext_ram_size { get; set; }
            public List<ulong> randomid { get; set; }
        }

        public class passinfo
        {
            public passinfo(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public byte[] ack { get; set; }
            public uint m_download_status { get; set; }
            public uint m_boot_style { get; set; }
            public byte[] soc_ok { get; set; }
        }

        public event ProgressChangedDelegate ProgressChanged;
        public Dictionary<int, string> errortbl;
        public Features features;
        public event LogDelegate log;
        public mtk_daxflash xflash;
        public norinfo nor;
        public nandinfo64 nand;
        public nandinfo32 nand32;
        public emmcinfo emmc;
        public sdcinfo sdc;
        public configinfo flashconfig;
        public passinfo pi;
        public Partition partition;
        public HWCrypto cryptosetup()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writemem(uint addr, uint[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writemem(uint addr, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writeregister(uint addr, object dwords)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool write_reg32(uint addr, uint data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> readmem(uint addr, int dwords = 1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint read_reg32(uint addr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void setotp(HWCrypto hwc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SecCfg(bool unlock)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], gpt> read_pmt()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public mtk_dalegacy(Features features, mtk_daxflash xflash)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool upload_da(DAconfig dacnf)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string error_to_string(int errorcode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Dictionary<string, string> generate_keys()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_stage2_config()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] custom_read_reg(uint addr, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        => custom_read(addr, length);
        public byte[] custom_read(uint addr, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Shutdown(ShutDownModes shutdown = ShutDownModes.NORMAL)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool finish(int value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool brom_send(DAconfig dasetup, byte[] dadata, int stage, int packetsize = 0x1000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool read_flash_info()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool sdmmc_switch_part(byte partition = 0x8)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool set_usb_cmd()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte check_usb_cmd()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] patch_da2(byte[] da2)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Upload()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<ulong, byte> get_parttype(ulong len, string parttype)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool writeflash(ulong addr, ulong len, string filename = "", long offset = 0, string ptype = null, byte[] wdata = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool sdmmc_write_data(ulong addr, ulong len, string filename = "", long offset = 0, string ptype = null, byte[] wdata = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool formatflash(ulong addr, ulong len, string parttype = "", bool printlog = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte get_storage()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public XreadFlashResult readflash(ulong addr, ulong len, string filename, string parttype = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}