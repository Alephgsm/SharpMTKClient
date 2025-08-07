using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharpMTKClient.Class.Protocol.MTK_DL;
using static SharpMTKClient.Class.Protocol.MTK_FlashTool;
using static SharpMTKClient.Class.util;

namespace SharpMTKClient.Class.Protocol.FlashToolLib
{
    public class MTKDevice
    {
        public MTK_FlashTool mtk_FlashTool = new MTK_FlashTool();
        public MTKDevice()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private IntPtr g_ft_handle;
        public event LogDelegate log;
        public event TransferEventHandler Transfer;
        public event MemoryTestResultEventHandler MemoryTestResult;
        public event TimerEventHandler Timer;
        public event ProgressEventHandler Progress;
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
            public object m_cb_sla_challenge_end_arg;
            // use USB Cable
            public bool m_usb_enable;
        }

        [HandleProcessCorruptedStateExceptions]
        public IntPtr NandUtil_Connect(byte port)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int cb_security_pre_process_notify(IntPtr usr_arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ulong calculateFlashSize(MTK_DL.DA_REPORT_T da_report)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public async Task<bool> BootToMeta()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int FindPartitionId(List<PART_INFO> list, string name)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string[] GetDAPlatforms(byte[] da)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ScatterStruct PartInfoToScatter(List<PART_INFO> list)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool Disconnect()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public COM_PROPERTY_S GetCOMPortWithFilter()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool WriteMemory(string Filepath, bool checkpreloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //[HandleProcessCorruptedStateExceptions()]
        //public async Task<bool> WriteMemory(string Filepath, bool checkpreloader,uint startaddress,uint partid, ulong partition_len, bool reconnect , bool disconnect )
        //{
        //    try
        //    {
        //        if(reconnect)
        //        {
        //            var num = await mtk_FlashTool.DAConnect_new(idx, (short)comPortIndex, checkpreloader);
        //            if (num != 0)
        //            {
        //                return false;
        //            }
        //        }
        //        return await mtk_FlashTool.FlashRead(Filepath,  partid, startaddress, partition_len);
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    finally
        //    {
        //        if(disconnect)
        //        {
        //            await mtk_FlashTool.DADisConnect(0);
        //        }
        //    }
        //    return false;
        //}
        [HandleProcessCorruptedStateExceptions]
        public List<MTK_FlashTool.PART_INFO> GetPartition(bool scatterCheck)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool FormatPartition(string Name)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool SparsePreloaderImage(string Preloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<ScatterItem> Items = new List<ScatterItem>();
        public async Task<bool> StructToScatter(MTK_DL.ScatterStruct structures, List<MTK_FlashTool.PART_INFO> list, string swpath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public int FindPartitionIndex(string name, List<MTK_FlashTool.PART_INFO> list)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool FormatFlags(List<MTK_FlashTool.PART_INFO> List, bool reconnect, bool checkpreloader, bool Disconnect = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool FormatFlag(ulong BeginAddress, ulong length, ushort part_id)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [HandleProcessCorruptedStateExceptions()]
        public bool MemoryTest(bool checkpreloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool IsFirmwarewrite { get; set; }

        public static Thread th = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        [HandleProcessCorruptedStateExceptions()]
        public void flash(bool reconnect = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void mtk_FlashTool_Log(string text, Resut color = Resut.Word)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void mtk_FlashTool_Progress(ulong Value, ulong Max)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void mtk_FlashTool_Transfer(ulong finished_bytes, ulong total_bytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void mtk_FlashTool_MemoryTestResult(ulong BadAddress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void mtk_FlashTool_Timer(uint current_progress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string preloader;
        public string swPath;
        public string scatter;
        public string da;
        public string dl_type;
        public string deviceName;
        public string DevicePath;
        public int comPortIndex;
        public int sort;
        public int bootromPort;
        public int preloaderPort;
        public int idx;
        public bool FormatAll;
        public int getDeviceTimeout;
        public List<MTK_DL.ROM_INFO> rom_info_list = new List<MTK_DL.ROM_INFO>();
    }
}