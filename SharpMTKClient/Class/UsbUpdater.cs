using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharpMTKClient.Class.USBAdapter.UsbNotification;

namespace SharpMTKClient.Class.USBAdapter
{
    public partial class UsbUpdater : Form
    {
        public UsbUpdater()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public const int WM_DEVICECHANGE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DBT_DEVTYP_VOLUME = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DBT_DEVICEARRIVAL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DBT_DEVTYP_DEVICEINTERFACE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void UsbUpdater_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}