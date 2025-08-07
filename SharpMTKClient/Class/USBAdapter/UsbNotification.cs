using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.USBAdapter
{
    public class UsbNotification
    {
        public const int DbtDevicearrival = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // system detected a new device        
        public const int DbtDeviceremovecomplete = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // device is gone      
        public const int WmDevicechange = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // device change event      
        private const int DbtDevtypDeviceinterface = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readonly static Guid GuidDevinterfaceUSBDevice = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // USB devices
        private static IntPtr notificationHandle = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        /// <summary>
        /// Registers a window to receive notifications when USB devices are plugged or unplugged.
        /// </summary>
        /// <paramname =  " windowHandle " >Handle to the window receiving notifications.</param>
        public static void RegisterUsbDeviceNotification(IntPtr windowHandle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Unregisters the window for USB device notifications
        /// </summary>
        public static void UnregisterUsbDeviceNotification()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr RegisterDeviceNotification(IntPtr recipient, IntPtr notificationFilter, int flags)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("user32.dll")]
        private static extern bool UnregisterDeviceNotification(IntPtr handle)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [StructLayout(LayoutKind.Sequential)]
        private partial struct DevBroadcastDeviceinterface
        {
            internal int Size;
            internal int DeviceType;
            internal int Reserved;
            internal Guid ClassGuid;
            internal short Name;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal partial class DEV_BROADCAST_HDR
        {
            public int dbch_size;
            public int dbch_devicetype;
            public int dbch_reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public partial struct DEV_BROADCAST_DEVICEINTERFACE
        {
            public int dbcc_size;
            public int dbcc_devicetype;
            public int dbcc_reserved;
            public Guid dbcc_classguid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] dbcc_name;
        }
    }
}