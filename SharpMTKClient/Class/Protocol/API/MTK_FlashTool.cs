using SharpMTKClient.Class.Protocol.FlashToolLib;
using SharpMTKClient.Class.USBAdapter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.FlashToolLib.MTK_AUTH;
using static SharpMTKClient.Class.Protocol.FlashToolLib.MTK_SCERT;
using static SharpMTKClient.Class.Protocol.MTK_DA;
using static SharpMTKClient.Class.Protocol.MTK_DL;
using static SharpMTKClient.Class.Protocol.MTK_FlashTool;
using static SharpMTKClient.Class.util;

namespace SharpMTKClient.Class.Protocol
{
    public class MTK_FlashTool
    {
        public delegate int CALLBACK_COM_INIT_STAGE(IntPtr hCom, IntPtr usr_arg);
        public delegate int CALLBACK_IN_BROM_STAGE(IntPtr brom_handle, IntPtr hCom, IntPtr usr_arg);
        public delegate int CALLBACK_SLA_CHALLENGE(IntPtr usr_arg, IntPtr p_challenge_in, uint challenge_in_len, out IntPtr pp_challenge_out, ref uint p_challenge_out_len);
        public delegate int CALLBACK_SLA_CHALLENGE_END(IntPtr usr_arg, IntPtr p_challenge_out);
        public delegate int CALLBACK_WRITE_BUF_PROGRESS_INIT(IntPtr usr_arg);
        public delegate int CALLBACK_WRITE_BUF_PROGRESS(byte finished_percentage, uint finished_bytes, uint total_bytes, IntPtr usr_arg);
        public delegate void ControlCmd(int sn, byte data, int length);
        public event LogDelegate log;
        public event ProgressEventHandler Progress;
        public delegate void ProgressEventHandler(ulong Value, ulong Max);
        public event TransferEventHandler Transfer;
        public delegate void TransferEventHandler(ulong finished_bytes, ulong total_bytes);
        public delegate void TimerEventHandler(uint current_progress);
        public event MemoryTestResultEventHandler MemoryTestResult;
        public delegate void MemoryTestResultEventHandler(ulong BadAddress);
        public partial struct BOOT_FLASHTOOL_ARG
        {
            public BBCHIP_TYPE m_bbchip_type;
            public EXT_CLOCK m_ext_clock;
            public uint m_baudrate;
            public uint m_ms_boot_timeout;
            public uint m_max_start_cmd_retry_count;
            public CALLBACK_COM_INIT_STAGE m_cb_com_init_stage;
            public IntPtr m_cb_com_init_stage_arg;
            public CALLBACK_IN_BROM_STAGE m_cb_in_brom_stage;
            public IntPtr m_cb_in_brom_stage_arg;
            public bool m_speedup_brom_baudrate;
            public IntPtr m_ready_power_on_wnd_handle;
            public IntPtr m_ready_power_on_wparam;
            public IntPtr m_ready_power_on_lparam;
            public IntPtr m_auth_handle;
            public IntPtr m_scert_handle;
            public CALLBACK_SLA_CHALLENGE m_cb_sla_challenge;
            public IntPtr m_cb_sla_challenge_arg;
            public CALLBACK_SLA_CHALLENGE_END m_cb_sla_challenge_end;
            public IntPtr m_cb_sla_challenge_end_arg;
            public uint m_p_bank0_mem_cfg;
            public uint m_p_bank1_mem_cfg;
            public bool m_enable_da_start_addr;
            public uint m_da_start_addr;
            public IntPtr m_da_handle;
            public CALLBACK_WRITE_BUF_PROGRESS_INIT m_cb_download_da_init;
            public IntPtr m_cb_download_da_init_arg;
            public CALLBACK_WRITE_BUF_PROGRESS m_cb_download_da;
            public IntPtr m_cb_download_da_arg;
            public bool m_usb_enable;
            public uint m_bmt_block_count;
        }

        public partial struct FormatStatisticsReport_T
        {
            public ulong m_fmt_begin_addr;
            public ulong m_fmt_length;
            public uint m_total_blocks;
            public uint m_bad_blocks;
            public uint m_err_blocks;
        }

        public delegate int CALLBACK_SECURITY_PRE_PROCESS_NOTIFY(IntPtr usr_arg);
        public delegate int CALLBACK_SET_HIGHSPEED_BAUDRATE(IntPtr hCOM, byte BaudrateId, IntPtr usr_arg);
        /// <summary>
        /// Add for checking USB status, 2012/08/08 
        /// </summary>
        /// <param name = "usr_arg"></param>
        /// <param name = "usb_status"></param>
        /// <returns></returns>
        public delegate int CALLBACK_USB_STATUS_INIT(IntPtr usr_arg, string usb_status);
        public delegate int CALLBACK_FORMAT_PROGRESS_INIT(HW_StorageType_E storage_type, ulong begin_addr, ulong length, IntPtr usr_arg);
        public delegate int CALLBACK_FORMAT_PROGRESS(byte finished_percentage, IntPtr usr_arg);
        public delegate int CALLBACK_FORMAT_STATISTICS(FormatStatisticsReport_T p_report, IntPtr usr_arg);
        public enum HW_ChipSelect_E
        {
            CS_0 = 0,
            CS_1 = 1,
            CS_2 = 2,
            CS_3 = 3,
            CS_4 = 4,
            CS_5 = 5,
            CS_6 = 6,
            CS_7 = 7,
            CS_WITH_DECODER = 8,
            MAX_CS = 8,
            HW_CHIP_SELECT_END = 9
        }

        public enum HW_StorageType_E
        {
            HW_STORAGE_NOR,
            HW_STORAGE_NAND,
            HW_STORAGE_EMMC,
            HW_STORAGE_SDMMC,
            HW_STORAGE_UFS,
            HW_STORAGE_NONE,
            HW_STORAGE_TYPE_END
        }

        // BROM & DA & PRELOADER device control 
        public enum device_control_code
        {
            DEV_GET_CHIP_ID = 1,
            DEV_BROM_WDT_RESET,
            DEV_BROM_SEND_DATA_TO,
            DEV_BROM_JUMP_TO,
            DEV_BROM_GET_MODEM_INFO,
            DEV_BROM_READ_MEM16,
            DEV_BROM_READ_MEM32,
            DEV_DA_GET_USB_SPEED = 0x100,
            DEV_DA_GET_BAT_VOLTAGE,
            DEV_DA_DISABLE_EMMC_HWRESET_PIN,
            DEV_DA_SET_EMMC_HWRESET_PIN,
            DEV_DA_WRITE_REG32,
            DEV_DA_READ_REG32,
            DEV_DA_GET_DRAM_TYPE,
            // 
            // Possible value of DRAM type:
            // LPDDR4:LP4:5, LP4X:6 LP4P:7
            // LPDDR3:3
            // 
            DEV_SET_BOOT_MODE,
            DEV_DA_PMIC_COLD_RESET,
            DEV_DA_DRAM_REPAIR,
            DEV_DA_STOR_LIFE_CYCLE_CHECK,
            DEV_DA_GET_ERROR_DETAIL,
            DEV_PL_STAY_STILL = 0x200
        }

        public enum CONN_DA_END_STAGE
        {
            FIRST_DA = 1,
            SECOND_DA = 2
        }

        public enum DA_LOG_LEVEL_E
        {
            DA_LOG_LEVEL_TRACE,
            DA_LOG_LEVEL_DEBUG,
            DA_LOG_LEVEL_INFO,
            DA_LOG_LEVEL_WARNING,
            DA_LOG_LEVEL_ERRORField,
            DA_LOG_LEVEL_FATAL
        }

        public enum DA_LOG_CHANNEL_E
        {
            DA_LOG_CHANNEL_NONE,
            DA_LOG_CHANNEL_UART,
            DA_LOG_CHANNEL_USB,
            DA_LOG_CHANNEL_UART_USB
        }

        public enum FC_TYPE
        {
            FORCE_CHARGE_OFF,
            FORCE_CHARGE_ON,
            FORCE_CHARGE_AUTO
        }

        public enum BOOT_MODE
        {
            NORMAL_BOOT = 0,
            META_BOOT = 1,
            RECOVERY_BOOT = 2,
            SW_REBOOT = 3,
            FACTORY_BOOT = 4,
            ADVMETA_BOOT = 5,
            ATE_FACTORY_BOOT = 6,
            ALARM_BOOT = 7,
            DUALTALK_SWITCH = 8,
            FAST_BOOT = 99,
            DOWNLOAD_BOOT = 100,
            UNKNOWN_BOOT
        }

        public partial struct BOOT_ARG_S
        {
            // Old parameters
            public BBCHIP_TYPE m_bbchip_type;
            public EXT_CLOCK m_ext_clock;
            public uint m_ms_boot_timeout;
            public uint m_max_start_cmd_retry_count;
            // New parameters
            public uint m_uTimeout;
            public uint m_uRetryTime;
            public uint m_uInterval;
            public uint m_uBaudrate;
            // C++ TO VB CONVERTER TODO TASK: VB does not have an equivalent to pointers to value types:
            // ORIGINAL LINE: int * m_pStopFlag;
            public int m_pStopFlag;
            public bool m_bIsUSBEnable;
            public bool m_bIsSymbolicEnable;
            public bool m_bIsCompositeDeviceEnable;
            public bool m_bDisableMobileLogService;
            public bool m_bMDlogging;
            public BOOT_MODE m_euBootMode;
            public ushort m_uMDMode;
            public uint m_uPortNumber;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string m_szPortSymbolic;
            // Serial Link Authentication 
            public IntPtr m_auth_handle;
            public IntPtr m_scert_handle;
            public CALLBACK_SLA_CHALLENGE m_cb_sla_challenge;
            public IntPtr m_cb_sla_challenge_arg;
            public CALLBACK_SLA_CHALLENGE_END m_cb_sla_challenge_end;
            public IntPtr m_cb_sla_challenge_end_arg;
            public bool m_bUartLogDisable;
        }

        public partial struct BOOT_META_ARG
        {
            public BBCHIP_TYPE m_bbchip_type;
            public EXT_CLOCK m_ext_clock;
            public uint m_ms_boot_timeout;
            public uint m_max_start_cmd_retry_count;
            // This callback function will be invoke after COM port is opened
            // You can do some initialization by using this callback function.
            public CALLBACK_COM_INIT_STAGE m_cb_com_init_stage;
            public IntPtr m_cb_com_init_stage_arg;
            // This callback function will be invoke after BootROM start cmd is passed. 
            // You can issue other BootROM command by brom_handle and hCOM which provides callback arguments, 
            // or do whatever you want otherwise. 
            public CALLBACK_IN_BROM_STAGE m_cb_in_brom_stage;
            public IntPtr m_cb_in_brom_stage_arg;
            // speed-up BootROM stage baudrate 
            public bool m_speedup_brom_baudrate;
            // Application's window handle to send WM_BROM_READY_TO_POWER_ON_TGT message 
            public IntPtr m_ready_power_on_wnd_handle;
            public IntPtr m_ready_power_on_wparam;
            public IntPtr m_ready_power_on_lparam;
            // Serial Link Authentication 
            public IntPtr m_auth_handle; // AUTH file handle
            public IntPtr m_scert_handle; // CERT file handle
            public CALLBACK_SLA_CHALLENGE m_cb_sla_challenge;
            public IntPtr m_cb_sla_challenge_arg;
            public CALLBACK_SLA_CHALLENGE_END m_cb_sla_challenge_end;
            public IntPtr m_cb_sla_challenge_end_arg;
            // use USB Cable
            public bool m_usb_enable;
        }

        public partial struct FlashTool_Connect_Arg
        {
            /// <summary>
            /// com port timeout setting
            /// </summary>
            public uint m_com_ms_read_timeout;
            public uint m_com_ms_write_timeout;
            /// <summary>
            /// BootFlashTool arg
            /// </summary>
            public BOOT_FLASHTOOL_ARG m_boot_arg;
            /// <summary>
            /// security pre-process notify callback
            /// </summary>
            public CALLBACK_SECURITY_PRE_PROCESS_NOTIFY m_cb_security_pre_process_notify;
            public IntPtr m_cb_security_pre_process_notify_arg;
            /// <summary>
            /// chip-select of NOR flash memory
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public HW_ChipSelect_E[] m_nor_chip_select;
            /// <summary>
            /// chip-select of NAND flash memory
            /// </summary>
            public HW_ChipSelect_E m_nand_chip_select;
            /// <summary>
            /// NFI access control register
            /// </summary>
            public uint m_p_nand_acccon;
            /// <summary>
            /// /By HW_StorageType_E to map different storage type operations
            /// </summary>
            public HW_StorageType_E m_storage_type;
            /// <summary>
            /// 2011-11-08: Add DL_HANDLE attribute for dummy partition layout setting
            /// </summary>
            public IntPtr m_p_dl_handle;
            /// <summary>
            /// value of 'FC_TYPE'
            /// </summary>
            public byte m_force_charge;
            /// <summary>
            /// power key reset, or power+home key reset
            /// </summary>
            public const int RESET_BY_PWR_KEY_ALONE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // 'P'
            public const int RESET_BY_PWR_HOME_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // 'h' - default(everything other than 'P' means 'h')
            public const int RESET_DISABLE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // disable long press reboot feature.
            public byte m_reset_key;
            /// <summary>
            /// add for DRAM flip test set connect which DA, 1st or 2nd
            /// </summary>
            public CONN_DA_END_STAGE m_conn_da_end_stage;
            public bool m_1st_da_enable_dram;
            public DA_LOG_LEVEL_E m_da_log_level;
            public DA_LOG_CHANNEL_E m_da_log_channel;
        }

        public partial struct FlashTool_Connect_Result
        {
            /// <summary>
            /// DA report
            /// </summary>
            public DA_REPORT_T m_da_report;
        }

        public enum ACCURACY
        {
            /// <summary>
            /// auto detect by baudrate
            /// </summary>
            ACCURACY_AUTOField = 0,
            /// <summary>
            /// 33%
            /// </summary>
            ACCURACY_1_3Field = 3,
            /// <summary>
            /// 25%
            /// </summary>
            ACCURACY_1_4Field = 4,
            /// <summary>
            /// 10%
            /// </summary>
            ACCURACY_1_10Field = 10,
            /// <summary>
            ///   1%
            /// </summary>
            ACCURACY_1_100Field = 100,
            /// <summary>
            /// 0.1%
            /// </summary>
            ACCURACY_1_1000Field = 1000,
            /// <summary>
            /// 0.01%
            /// </summary>
            ACCURACY_1_10000Field = 10000
        }

        public partial struct FlashTool_Readback_Result
        {
        // dummy
        }

        public enum UART_BAUDRATE
        {
            UART_BAUD_921600 = 0x01,
            UART_BAUD_460800 = 0x02,
            UART_BAUD_230400 = 0x03,
            UART_BAUD_115200 = 0x04,
            UART_BAUD_57600 = 0x05,
            UART_BAUD_38400 = 0x06,
            UART_BAUD_19200 = 0x07,
            UART_BAUD_9600 = 0x08,
            UART_BAUD_4800 = 0x09,
            UART_BAUD_2400 = 0x0a,
            UART_BAUD_1200 = 0x0b,
            UART_BAUD_300 = 0x0c,
            UART_BAUD_110 = 0x0d
        }

        public struct COM_PORT_SETTING
        {
            public COM_PORT_HANDLE com;
            public UART_BAUDRATE baudrate;
            public uint ms_read_timeout;
            public uint ms_write_timeout;
        }

        public struct FLASHTOOL_RESULT
        {
            public DA_REPORT_T m_da_report;
            public DA_INFO m_da_info;
            public AUTH_INFO m_auth_info;
            public SCERT_INFO m_scert_info;
        }

        public enum RB_OUTPUT_TYPE
        {
            RB_TO_FILE = 0,
            RB_TO_BUF
        }

        public struct RB_INFO
        {
            public RB_OUTPUT_TYPE output_type;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string filepath;
            public byte[] read_to_buffer;
            public UInt64 readback_addr;
            public UInt64 readback_len;
            public uint part_id;
            public bool enable;
        }

        public struct FLASHTOOL_READBACK_RESULT
        {
            public RB_INFO m_rb_info;
        }

        public struct FLASHTOOL_ARG
        {
            public BOOT_FLASHTOOL_ARG m_boot_arg;
            public CALLBACK_DA_REPORT m_cb_da_report;
            public IntPtr m_cb_da_report_arg;
            public CALLBACK_SECURITY_PRE_PROCESS_NOTIFY m_cb_security_pre_process_notify;
            public IntPtr m_cb_security_pre_process_notify_arg;
            public CALLBACK_SET_HIGHSPEED_BAUDRATE m_cb_set_high_speed_baudrate;
            public IntPtr m_cb_set_high_speed_baudrate_arg;
            public byte m_baudrate_full_sync_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public HW_ChipSelect_E[] m_nor_chip_select;
            public HW_ChipSelect_E m_nand_chip_select;
            public uint m_p_nand_acccon;
            public bool m_enable_ui_dram_cfg;
            public DRAM_SETTING m_dram_cfg;
        }

        public partial struct FlashTool_Readback_Arg
        {
            public HW_StorageType_E m_storage_type;
            public IntPtr m_rb_handle;
            // readback progress callback
            public ACCURACY m_readback_accuracy;
            public CALLBACK_READBACK_PROGRESS_INIT m_cb_readback_flash_init;
            public IntPtr m_cb_readback_flash_init_arg;
            public CALLBACK_READBACK_PROGRESS m_cb_readback_flash;
            public IntPtr m_cb_readback_flash_arg;
        }

        public delegate int CALLBACK_READBACK_PROGRESS_INIT(HW_StorageType_E storage_type, ulong rb_addr, ulong rb_length, string rb_filepath, IntPtr usr_arg);
        public delegate int CALLBACK_READBACK_PROGRESS(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg);
        public delegate int CALLBACK_DA_REPORT(ref DA_REPORT_T p_da_report, IntPtr usr_arg);
        public delegate int CALLBACK_DOWNLOAD_PROGRESS_INIT(IntPtr usr_arg, string image_name);
        public delegate int CALLBACK_DOWNLOAD_PROGRESS(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg);
        public delegate int CALLBACK_BOOTLOADER_DOWNLOAD_PROGRESS_INIT(IntPtr usr_arg);
        public delegate int CALLBACK_BOOTLOADER_DOWNLOAD_PROGRESS(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg);
        public delegate int CALLBACK_CHECKSUM_PROGRESS_INIT(IntPtr usr_arg, string image_name);
        public delegate int CALLBACK_CHECKSUM_PROGRESS(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg);
        public delegate int CALLBACK_SECURITY_POST_PROCESS_NOTIFY(IntPtr usr_arg);
        public partial struct FlashTool_Download_Arg
        {
            /// <summary>
            /// single DL_HANDLE
            /// </summary>
            public IntPtr m_dl_handle;
            /// <summary>
            /// multi DL_HANDLE List
            /// </summary>
            public IntPtr m_dl_handle_list;
            /// <summary>
            /// da report callback
            /// </summary>
            public CALLBACK_DA_REPORT m_cb_da_report;
            public IntPtr m_cb_da_report_arg;
            /// <summary>
            /// DL_HANDLE download progress callback
            /// </summary>
            public ACCURACY m_download_accuracy;
            public CALLBACK_DOWNLOAD_PROGRESS_INIT m_cb_download_flash_init;
            public IntPtr m_cb_download_flash_init_arg;
            public CALLBACK_DOWNLOAD_PROGRESS m_cb_download_flash;
            public IntPtr m_cb_download_flash_arg;
            /// <summary>
            /// Boot Loader download progress callback
            /// </summary>
            public CALLBACK_BOOTLOADER_DOWNLOAD_PROGRESS_INIT m_cb_download_bloader_init;
            public IntPtr m_cb_download_bloader_init_arg;
            public CALLBACK_BOOTLOADER_DOWNLOAD_PROGRESS m_cb_download_bloader;
            public IntPtr m_cb_download_bloader_arg;
            /// <summary>
            /// security post-process notify callback
            /// </summary>
            public CALLBACK_SECURITY_POST_PROCESS_NOTIFY m_cb_security_post_process_notify;
            public IntPtr m_cb_security_post_process_notify_arg;
            /// <summary>
            /// Checksum progress callback
            /// </summary>
            public CALLBACK_CHECKSUM_PROGRESS_INIT m_cb_checksum_init;
            public IntPtr m_cb_checksum_init_arg;
            public CALLBACK_CHECKSUM_PROGRESS m_cb_checksum;
            public IntPtr m_cb_checksum_arg;
            /// <summary>
            /// The flag of m_enable_tgt_res_layout_check is used to control whether if target resource
            /// layout checking operation will be performed.
            /// _TRUE: Enable target resource layout checking operation.
            /// _FALSE: Disable target resource layout checking operation.
            /// </summary>
            public bool m_enable_tgt_res_layout_check;
            /// <summary>
            /// The flag to check if target side baseband chip version is corresponding to ROM file on PC side.
            /// </summary>
            public bool m_enable_bbchip_ver_check;
            /// <summary>
            /// Download Style : _FALSE  : best effort erase
            /// _TRUE   : sequential erase (sector by sector)
            /// </summary>
            public bool m_downloadstyle_sequential;
        }

        public partial struct FlashTool_Download_Result
        {
        }

        public enum AddressingMode
        {
            AddressingMode_BlockIndex,
            AddressingMode_PhysicalAddress,
            AddressingMode_LogicalAddress
        }

        public enum InputMode
        {
            InputMode_FromBuffer,
            InputMode_FromFile
        }

        public enum ProgramMode
        {
            ProgramMode_PageOnly,
            ProgramMode_PageSpare
        }

        public delegate int CALLBACK_WRITE_FLASH_PROGRESS(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg);
        public partial struct WriteFlashMemoryParameter
        {
            public HW_StorageType_E m_flash_type;
            public AddressingMode m_addressing_mode;
            public ulong m_address;
            public uint m_container_length;
            public InputMode m_input_mode;
            public string m_input;
            public ulong m_input_length;
            public uint m_part_id;
            public CALLBACK_WRITE_FLASH_PROGRESS m_cb_progress;
            public IntPtr m_cb_progress_arg;
            public ProgramMode m_program_mode;
        }

        public partial struct FlashTool_EnableWDT_Arg
        {
            public uint m_timeout_ms;
            public bool m_async;
            public bool m_reboot;
            public bool m_dlbit;
            public bool m_bNotResetRTCTime;
        }

        public enum transfer_phase
        {
            TPHASE_INIT,
            TPHASE_DA,
            TPHASE_LOADER,
            TPHASE_IMAGE,
            TPHASE_HOST_CHECKSUM,
            TPHASE_TARGET_CHECKSUM,
            TPHASE_FORMAT,
            TPHASE_READBACK,
            TPHASE_WRITE_MEMORY,
            TPHASE_MEMORY_TEST
        }

        public partial struct cbs_additional_info
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
            public string image_name;
        }

        public delegate void CB_OPERATION_PROGRESSType(IntPtr _this, transfer_phase phase, uint progress, ulong data_xferd, ulong data_total, ref cbs_additional_info additional_info);
        public delegate void CB_STAGE_MESSAGE(IntPtr _this, string message);
        public delegate bool CB_NOTIFY_STOPType(IntPtr _this);
        public partial struct sla_callbacks_t
        {
            public CALLBACK_SLA_CHALLENGE cb_start;
            public CALLBACK_SLA_CHALLENGE_END cb_end;
            public IntPtr start_user_arg;
            public IntPtr end_user_arg;
        }

        public partial struct callbacks_struct_t
        {
            public IntPtr _this;
            public CB_OPERATION_PROGRESSType cb_op_progress;
            public CB_STAGE_MESSAGE cb_stage_message;
            public CB_NOTIFY_STOPType cb_notify_stop;
            public sla_callbacks_t cb_sla;
        }

        public enum ExternalMemoryType
        {
            ExternalMemoryType_NonexistentField = 0,
            ExternalMemoryType_PSRAMField,
            ExternalMemoryType_DDRField,
            ExternalMemoryType_DDR2Field
        }

        public partial struct DDR_Config_v1
        {
            public uint EMI_CONI_Value;
            public uint EMI_DRVA_Value;
            public uint EMI_DRVB_Value;
            public uint EMI_CONJ_Value;
            public uint EMI_CONK_Value;
            public uint EMI_CONL_Value;
            public uint EMI_IOCL_Value;
            public uint EMI_GENA_Value;
            public uint EMI_GEND_Value;
            public uint EMI_DRCT_Value;
            public uint EMI_PPCT_Value;
            public uint EMI_SLCT_Value;
            public uint EMI_ABCT_Value;
            public uint EMI_DUTB_Value;
        }

        public partial struct DDR2_Config_v1
        {
            public uint EMI_CONI_Value;
            public uint EMI_CONJ_Value;
            public uint EMI_CONK_Value;
            public uint EMI_CONL_Value;
            public uint EMI_CONN_Value;
            public uint EMI_GENA_Value;
            public uint EMI_GEND_Value;
            public uint EMI_DRCT_Value;
            public uint EMI_PPCT_Value;
            public uint EMI_ABCT_Value;
            public uint EMI_DQSA_Value;
            public uint EMI_DQSB_Value;
        }

        public struct ExternalMemoryConfig
        {
            public ExternalMemoryType memoryType;
            public uint initFlowVersion;
            //[FieldOffset(1)]
            public DDR_Config_v1 DDR_v1;
            //[FieldOffset(1)]
            public DDR2_Config_v1 DDR2_v1;
        }

        public partial struct ex_ufs_config
        {
            public uint force_provision; // default 0
            public uint tw_size_gb; // default 0xFFFFFFFF
            public uint tw_no_red; // default 1
            public uint hpb_size_gb; // default 0xFFFFFFFF
            public uint lu3_size_mb; // default 0
            public uint lu3_type; // default 0
        }

        public partial struct UFS_Config
        {
            public uint force_provision; // default 0
            public uint tw_size_gb; // default 0xFFFFFFFF
            public uint tw_no_red; // default 1
            public uint hpb_size_gb; // default 0xFFFFFFFF
            public uint lu3_size_mb; // default 0
            public uint lu3_type; // default 0
        }

        [StructLayout(LayoutKind.Sequential)]
        public partial struct BOOT_RESULT
        {
            public BBCHIP_TYPE m_bbchip_type;
            public IntPtr m_bbchip_name;
            public ushort m_bbchip_hw_ver;
            public ushort m_bbchip_sw_ver;
            public ushort m_bbchip_hw_code;
            public EXT_CLOCK m_ext_clock;
            public uint m_bbchip_secure_ver;
            public uint m_bbchip_bl_ver;
            public uint m_fw_ver_len;
            public IntPtr m_fw_ver;
            public uint m_msp_err_code;
        }

        public partial struct FlashTool_USB_Status_Arg
        {
            public CALLBACK_USB_STATUS_INIT m_cb_usb_status_init;
            public IntPtr cb_usb_status_init_arg;
        }

        public enum USB_SPEED_STATUS_E
        {
            USB_FULL_SPEED = 0,
            USB_HIGH_SPEED = 1,
            USB_ULTRA_HIGH_SPEED = 2,
            USB_STATUS_UNKNOWN = 0xFFFF
        }

        public partial struct FlashTool_USB_Status_Result
        {
            public USB_SPEED_STATUS_E usb_speed_status;
        }

        public enum FILTER_TYPE_E
        {
            WHITE_LIST = 0,
            BLACK_LIST
        }

        public partial struct COM_FILTER_LIST_S
        {
            public uint m_uCount;
            public FILTER_TYPE_E m_eType;
            public string[] m_ppFilterID;
            public bool[] m_bInterface;
        }

        public partial struct COM_PROPERTY_S
        {
            public int m_iFilterIndex;
            public uint m_uNumber;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] m_rFriendly;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] m_rInstanceID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] m_rSymbolic;
            public bool m_bInterface;
        }

        public partial struct SCATTER_Head_Info
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string version;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string platform;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string project;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string storage;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string bootChannel;
            public uint blockSize;
            public bool modem_check;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string modem;
            public bool skip_pmt_operate;
            public bool resize_check;
        }

        public partial struct COM_PORT_HANDLE
        {
            public COM_TYPE type;
            //[FieldOffset(1)]
            public ushort number;
            //[FieldOffset(1)]
            public IntPtr handle;
            //[FieldOffset(1)]
            public string name;
        }

        public enum COM_TYPE
        {
            COM_TYPE_NUMField = 0, // !<: The COM port is provided by com port number
            COM_TYPE_HANDLEField = 1, // !<: The COM port is provided by com port handle
            COM_TYPE_NAMEField = 2 // !<: The COM port is provided by com port name
        }

        public struct PART_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string name;
            public ulong begin_addr;
            public ulong image_length;
            public ushort part_id;
        }

        public enum NUTL_EraseFlag_E
        {
            NUTL_ERASE = 0,
            NUTL_FORCE_ERASE,
            NUTL_MARK_BAD_BLOCK,
            NUTL_ERASE_FLAG_END
        }

        public enum NUTL_AddrTypeFlag_E
        {
            NUTL_ADDR_LOGICAL = 0,
            NUTL_ADDR_PHYSICAL,
            NUTL_ADDR_FLAG_END
        }

        public partial struct FORMAT_CONFIG_T
        {
            public bool m_auto_format_fat;
            public bool m_validation;
            public ulong m_format_begin_addr;
            public ulong m_format_length;
            public uint m_part_id;
            public NUTL_AddrTypeFlag_E m_AddrType;
        }

        public partial struct FlashTool_Format_Arg
        {
            public HW_StorageType_E m_storage_type;
            public FORMAT_CONFIG_T m_format_cfg;
            public NUTL_EraseFlag_E m_erase_flag;
            public CALLBACK_FORMAT_PROGRESS_INIT m_cb_format_report_init;
            public IntPtr m_cb_format_report_init_arg;
            public CALLBACK_FORMAT_PROGRESS m_cb_format_report;
            public IntPtr m_cb_format_report_arg;
            public CALLBACK_FORMAT_STATISTICS m_cb_format_statistics;
            public IntPtr m_cb_format_statistics_arg;
        }

        public partial struct FlashTool_Format_Result
        {
            public FormatStatisticsReport_T m_format_statistics;
        }

        private IntPtr g_ft_handle;
        public static HW_StorageType_E m_storage_type = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public ushort m_ufs_vendor_id;
        public string m_ufs_cid = "";
        public string m_ufs_fwver = "";
        public string LogName = "";
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_Format(IntPtr ft_handle, ref FlashTool_Format_Arg p_fmt_arg, ref FlashTool_Format_Result p_fmt_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetCOMPortWithFilter(ref COM_FILTER_LIST_S pCOMFilter, ref COM_PROPERTY_S pCOMPorperty, ref int pStopFlag, double dTimeout)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_Connect_BROM_ByName(byte[] com_port, ref FlashTool_Connect_Arg p_arg, ref IntPtr p_ft_handle, ref int p_stopflag, bool bCheckScatter = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_Connect_BROM(short com_port, ref FlashTool_Connect_Arg p_arg, ref IntPtr p_ft_handle, IntPtr p_stopflag, bool bbCheckScatter = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr ChipTypeToString(BBCHIP_TYPE chiptype)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_NandUtil_Connect(byte com_port, ref FlashTool_Connect_Arg p_arg, ref FlashTool_Connect_Result p_result, ref int p_stopflag, ref IntPtr p_ft_handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FlashTool_GetBootResult(ref IntPtr ft_handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Connect_Download_DA(ref FlashTool_Connect_Arg p_arg, ref IntPtr p_ft_handle, ref FlashTool_Connect_Result p_result, ref int p_stopflag, bool bbCheckScatter = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_CheckUSBStatus(IntPtr p_ft_handle, ref FlashTool_USB_Status_Arg p_arg, ref FlashTool_USB_Status_Result p_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DL_GetPlatformInfo(IntPtr p_dl_handle, ref DL_PlatformInfo pPlatformInfo)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_Device_Control(IntPtr ft_handle, device_control_code ctrl_code, IntPtr inbuffer, uint inbuffer_size, IntPtr outbuffer, uint outbuffer_size, uint bytes_returned)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public partial struct IMEI_PID_SWV_Info
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] m_uIMEI;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] m_uPID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] m_uSWV;
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_GetIMEI_PID_SWV_Info(IntPtr ft_handle, ref IMEI_PID_SWV_Info pProductInfo)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        /// <summary>
        /// To get total reserved ROM size (PMT+BMT+OPT)
        /// </summary>
        /// <param name = "ft_handle"></param>
        /// <param name = "dl_handle"></param>
        /// <param name = "p_rsv_size"></param>
        /// <returns></returns>
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_GetReservedRomSize(IntPtr ft_handle, IntPtr dl_handle, ref ulong p_rsv_size)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DL_GetFTHandle(ref IntPtr dl_handle, ref IntPtr ft_handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        /// <summary>
        /// To get info of regulated ROMs from scatter file
        /// </summary>
        /// <param name = "ft_handle"></param>
        /// <param name = "dl_handle"></param>
        /// <param name = "p_rom_count"></param>
        /// <param name = "bWithPreloader"></param>
        /// <returns></returns>
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_RomGetCount(ref IntPtr ft_handle, ref IntPtr dl_handle, uint p_rom_count, bool bWithPreloader = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_RomGetInfoAll(IntPtr ft_handle, IntPtr dl_handle, ref ROM_INFO p_rom_info, uint max_rom_count, bool bWithPreloader = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DL_GetScatterVersion(ref IntPtr dl_handle, ref string version)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_ReadPartitionCount(IntPtr ft_handle, ref uint p_part_count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_ReadPartitionInfo(IntPtr ft_handle, IntPtr p_part_info, uint max_part_count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Readback(IntPtr ft_handle, ref FlashTool_Readback_Arg p_rb_arg, ref FlashTool_Readback_Result p_rb_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Download(IntPtr p_ft_handle, ref FlashTool_Download_Arg p_dl_arg, ref FlashTool_Download_Result p_dl_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DL_GetCount(IntPtr p_dl_handle, out ushort p_rom_count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DL_Rom_GetInfoAll(IntPtr p_dl_handle, IntPtr p_rom_info, ushort max_rom_count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Disconnect(ref IntPtr p_ft_handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RB_ClearAll(IntPtr rb_handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashReadback(ref COM_PORT_SETTING p_com_setting, ref FLASHTOOL_ARG p_arg, ref FLASHTOOL_RESULT p_result, ref FlashTool_Readback_Arg p_rb_arg, ref FLASHTOOL_READBACK_RESULT p_rb_result, ref ExternalMemoryConfig p_external_memory_config, ref int p_stopflag)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public struct FlashTool_CheckBattery_Arg
        {
        }

        public partial struct FlashTool_CheckBattery_Result
        {
            public uint bat_voltage_value;
        }

        public partial struct Flash_Checksum_Result
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string image_name;
            public uint pc_checksum;
            public uint da_checksum;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string checksum_status;
            // Forward compatibility
            public uint image_index;
            public uint pl_checksum;
        }

        public partial struct Flash_Status_Result
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string magic_num;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32 - 24)]
            public string version;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public Flash_Checksum_Result part_info;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string ram_checksum;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string download_status;
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Check_Battery(IntPtr ft_handle, ref FlashTool_CheckBattery_Arg p_bat_arg, ref FlashTool_CheckBattery_Result p_bat_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        private static int FlashTool_ReadFlashInfo(IntPtr ft_handle, ref Flash_Status_Result p_flash_status_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_SetupUSBDL(ref IntPtr p_ft_handle, byte enable_hs)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_ChangeCOM_Ex(ref IntPtr p_ft_handle, ref COM_PORT_HANDLE p_com_port)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Connect(short com_port, ref FlashTool_Connect_Arg p_arg, ref FlashTool_Connect_Result p_result, ref ExternalMemoryConfig p_external_memory_config, int p_stopflag, ref IntPtr p_ft_handle, bool bbCheckScatter = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int DL_SetStopLoadFlag(IntPtr dl_handle, ref int stop_flag)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        // <HandleProcessCorruptedStateExceptions, SecurityCritical>
        // <DllImport("FlashToolLib.dll", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Auto, SetLastError:=True)>
        // Private Shared Function FlashTool_Connect_BROM(ByVal com_port As Short,
        // ByRef p_arg As FlashTool_Connect_Arg,
        // ByRef p_ft_handle As IntPtr,
        // ByVal p_stopflag As IntPtr,
        // ByVal Optional bbCheckScatter As Boolean = True) As Integer
        // End Function
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Disconnect_BROM(ref IntPtr p_ft_handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Connect_Download_DA(ref FlashTool_Connect_Arg p_arg, ref IntPtr p_ft_handle, ref FlashTool_Connect_Result p_result, IntPtr p_stopflag, bool bbCheckScatter = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_IsConnectWithBootRom(IntPtr p_ft_handle, ref bool p_is_connect_with_bootrom)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("SLA_Challenge.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SLA_Challenge(IntPtr usr_arg, IntPtr p_challenge_in, uint challenge_in_len, out IntPtr pp_challenge_out, ref uint p_challenge_out_len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("SLA_Challenge.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SLA_Challenge_End(IntPtr usr_arg, IntPtr p_challenge_out)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_EnableWatchDogTimeout(IntPtr ft_handle, ref FlashTool_EnableWDT_Arg p_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_Format_Partition(IntPtr ft_handle, byte[] part_name, ref callbacks_struct_t callbacks)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_FirmwareUpdate(IntPtr ft_handle, byte[] fw_filename, string fw_buffer, uint fw_buffer_len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashtoollibEx.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int flashtool_set_ufs_config(IntPtr ft_handle, ref ex_ufs_config cfg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_SetUFSConfig(IntPtr ft_handle, ref UFS_Config cfg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        // chipname in MTxxxx format
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool FlashTool_Chip_isOldArch(byte[] chipname)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int Boot_META(IntPtr hCOM, ref BOOT_META_ARG p_arg, ref BOOT_RESULT p_result, ref int p_bootstop)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int Boot_FlashTool(IntPtr hCOM, ref BOOT_FLASHTOOL_ARG p_arg, ref BOOT_RESULT p_result, ref int p_bootstop)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BootROM_BootMode(ref BOOT_ARG_S pArg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("MetaCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SP_Preloader_BootMode(ref BOOT_ARG_S pArg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public enum SP_FILTER_TYPE_E
        {
            SP_WHITE_LIST = 0,
            SP_BLACK_LIST
        }

        public partial struct SP_COM_FILTER_LIST_S
        {
            public uint m_uCount;
            public SP_FILTER_TYPE_E m_eType;
            public string[] m_ppFilterID;
            public IntPtr m_bInterface;
        }

        public partial struct SP_COM_PROPERTY_S
        {
            public int m_iFilterIndex;
            public uint m_uNumber;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] m_rFriendly;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] m_rInstanceID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] m_rSymbolic;
            public bool m_bInterface;
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetIncrementCOMPortWithFilter(ref SP_COM_FILTER_LIST_S pCOMFilter, ref SP_COM_PROPERTY_S pCOMPorperty, ref IntPtr pGuid, bool bDeviceInterface, ref int pStopFlag, double dTimeout)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("MetaCore.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SP_META_Init(CALLBACK_COM_INIT_STAGE cb)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_WriteFlashMemory(IntPtr ft_handle, ref WriteFlashMemoryParameter parameter, bool is_by_sram = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FlashTool_ReadFlashMemory(IntPtr ft_handle, ref ReadFlashMemoryParameter parameter, ref ReadFlashMemoryResult result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public partial struct ReadFlashMemoryParameter
        {
            public HW_StorageType_E m_flash_type;
            public AddressingMode m_addressing_mode;
            public ulong m_address;
            public ulong m_length;
            public uint m_container_length; // In blocks, only valid for NAND
            public OutputMode m_output_mode;
            public string m_output;
            public CALLBACK_READBACK_PROGRESS m_cb_progress;
            public IntPtr m_cb_progress_arg;
        }

        public partial struct ReadFlashMemoryResult
        {
            public ulong m_num_bytes_read;
        }

        public enum OutputMode
        {
            OutputMode_ToBuffer,
            OutputMode_ToFile
        }

        public partial struct partition_info_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] part_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] file_name;
            public ulong start_address;
            public ulong size;
            public uint storage;
            public uint region;
            public uint operation_type;
            public bool is_download;
            public bool enable;
            public bool is_reserved;
            public uint attribute;
            public uint d_type;
            public uint slc_percentage;
            public uint rom_type;
            public bool combo_partsize_check;
        }

        public partial struct partition_info_list_t
        {
            public uint count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.Struct)]
            public partition_info_t[] part;
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashtoollibEx.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int flashtool_read_partition_table(IntPtr ft_handle, ref IntPtr pt_list)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public static long session = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static IntPtr g_brom_handle = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("Flashtoollib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int Brom_Connect(ref IntPtr p_brom_handle, ref IntPtr p_ft_handle, ushort com_port, BBCHIP_TYPE bbchip_type, EXT_CLOCK ext_clock, ref int p_bootstop, uint ms_boot_timeout, uint max_start_cmd_retry_count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("Flashtoollib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int Brom_Create(ref IntPtr p_brom_handle, IntPtr hCOM, BBCHIP_TYPE bbchip_type, EXT_CLOCK ext_clock, uint baudrate, ref int p_bootstop, uint ms_boot_timeout, uint max_start_cmd_retry_count, ref BOOT_RESULT p_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        //region Emmc & ram test
        public delegate int CALLBACK_MEMORYTEST_PROGRESS_INIT(ref IntPtr usr_arg);
        public delegate int CALLBACK_MEMORYTEST_PROGRESS(uint current_progress, ulong finished_bytes, ulong total_bytes, ref IntPtr usr_arg);
        public delegate int CALLBACK_MEMORYTEST_NAND_BAD_BLOCK_REPORT(ulong bad_block_address, ref IntPtr usr_arg);
        public enum HW_MemoryType_E
        {
            HW_MEM_NOR = 0, // NOR Flash
            HW_MEM_NAND, // NAND Flash
            HW_MEM_EXT_SRAM, // External SRAM
            HW_MEM_EXT_DRAM, // External DRAM
            HW_MEM_EMMC, // EMMC Flash
            HW_MEM_SDMMC, // SDMMC Flash
            HW_MEM_UFS, // UFS
            HW_MEM_TYPE_END
        }

        public enum HW_MemoryIO_E
        {
            HW_MEM_IO_8BIT = 0, // 8-Bits Memory I/O
            HW_MEM_IO_16BIT, // 16-Bits Memory I/O
            HW_MEM_IO_32BIT, // 32-Bits Memory I/O
            HW_MEM_IO_TYPE_END
        }

        public enum HW_MemoryTestMethod_E
        {
            HW_MEM_DUMP = 0, // Memory Dump (Warning: it's not a test scenario!)
            HW_MEM_PATTERN_TEST, // Pattern Test Scenario
            HW_MEM_INC_DEC_TEST, // Increment/Decrement Test Scenario
            HW_MEM_ADDR_BUS_TEST, // EMI Address Bus Test Scenario
            HW_MEM_DATA_BUS_TEST, // EMI Data Bus Test Scenario
            HW_MEM_IO_BUS_TEST, // NFI I/O Bus Test Scenario
            HW_MEM_DRAM_FLIP_TEST, // dram flip test
            HW_MEM_TEST_TYPE_END
        }

        public partial struct FlashTool_MemoryTest_Arg
        {
            public HW_MemoryType_E m_memory_device;
            public ulong m_start_addr;
            public ulong m_size;
            public HW_MemoryIO_E m_memory_io;
            public HW_MemoryTestMethod_E m_test_method;
            public uint m_test_pattern;
            // callback function
            public CALLBACK_MEMORYTEST_PROGRESS_INIT m_cb_memorytest_progress_init;
            public IntPtr m_cb_memorytest_progress_init_arg;
            public CALLBACK_MEMORYTEST_PROGRESS m_cb_memorytest_progress;
            public IntPtr m_cb_memorytest_progress_arg;
            public CALLBACK_MEMORYTEST_NAND_BAD_BLOCK_REPORT m_cb_memorytest_nand_bad_block_report;
            public IntPtr m_cb_memorytest_nand_bad_block_report_arg;
            // stop flag
            public int m_p_stopflag;
        }

        public partial struct FlashTool_MemoryTest_Result
        {
            // return value
            public uint m_ret;
            // Error result for Pattern Test and Inc/Dec Test
            public uint m_pass_pattern;
            public ulong m_fail_addr;
            public uint m_fail_pattern;
            // Error result for Data Bus Test, Address Bus Test, and I/O Bus Test
            public uint m_fail_value;
            public uint m_fail_pin;
            public uint m_fail_pin2;
            // Memory dump value for HW_MEM_DUMP
            public byte[] m_dump_buf;
            public uint m_num_bad_blocks; // Only valid for NAND test
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FlashTool_MemoryTest(IntPtr ft_handle, ref FlashTool_MemoryTest_Arg p_mt_arg, ref FlashTool_MemoryTest_Result p_mt_result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashToolLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern string GetNandFlashNameByTypeId(ushort type_id)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions]
        public bool StorageCheck()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public bool RAMAddrBusTest()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public async Task<bool> ReadMemory(string savepath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public bool RAMIncDecTest()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool RAMDataBusTest()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void AnalysTest(string ret, int num, FlashTool_MemoryTest_Result result)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public bool RAMPatternTest()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public async Task<bool> BootToMeta(int com)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int MEMORYTEST_PROGRESS_INIT(ref IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int MEMORYTEST_PROGRESS(uint current_progress, ulong finished_bytes, ulong total_bytes, ref IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int MEMORYTEST_NAND_BAD_BLOCK_REPORT(ulong bad_block_address, ref IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public int BromService(ushort com, bool scatterCheck)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void SetLogName(string logname)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public ulong GetReservedRomSize()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public static void DebugLogsOn()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public HW_StorageType_E getDeviceStorageType()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int p_stopflag = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static DA_REPORT_T DAReport = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public COM_PROPERTY_S GetCom()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public int DAConnect_new(int idx, short com_port_num, bool scatterCheck, bool EnableDram = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool ChipIsOld(string chipset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        [DllImport("FlashtoollibEx.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr flashtool_create_session()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [HandleProcessCorruptedStateExceptions()]
        public List<PART_INFO> ReadPartitionInfo(int p_rom_count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public bool WriteMemory(string filepath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public async Task<bool> WriteMemory(string filepath, uint startaddress, uint partid, ulong partition_len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public async Task<bool> ReadMemory(string savepath, ulong address, ulong length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public uint ReadPartitionCount()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ushort com_port;
        [HandleProcessCorruptedStateExceptions()]
        public int DADisConnect(int idx)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public int Download(int idx)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public BOOT_META_ARG BootMetaArgSettings()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public BOOT_FLASHTOOL_ARG BootArgSetting()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int encrypt(int plainText, int key)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public int WriteATMBootModeFlag(int idx, List<MTK_DL.ROM_INFO> rom_info_list)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public int WriteMemory(int idx, ulong offset, string set_flag, List<MTK_DL.ROM_INFO> rom_info_list)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public void DoReboot(int idx)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ushort VidToInt(string strVid)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool FormatPartition(string name)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool UsbSetupDl()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool FormatFlags(List<PART_INFO> List)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions]
        public bool FormatFlag(ulong begin_addr, ulong length, ushort part_id, bool DlSetup = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public int DoFormatAll()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void cb_operation_progress(IntPtr _this, transfer_phase phase, uint progress, ulong data_xferd, ulong data_total, ref cbs_additional_info additional_info)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool cb_notify_stop(IntPtr _this)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void cb_statge_message(IntPtr _this, string msg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_security_pre_process_notify(IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_com_init_stage(IntPtr hCom, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_in_brom_stage(uint brom_handle, IntPtr hCom, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_download_da_init(IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_download_da(byte finished_percentage, uint finished_bytes, uint total_bytes, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_da_report(ref DA_REPORT_T FlashTool_Connect_Result, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private string LastFlashEvent;
        private int cb_download_process_init(IntPtr usr_arg, string image_name)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int READBACK_PROGRESS_INIT(HW_StorageType_E storage_type, ulong rb_addr, ulong rb_length, string rb_filepath, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int Readback_Progress(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_download_process(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_bootloader_download_process_init(IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_bootloader_download_process(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_checksum_process_init(IntPtr usr_arg, string image_name)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_checksum_process(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_security_post_process_notify(IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_progress(byte finished_percentage, ulong finished_bytes, ulong total_bytes, IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}