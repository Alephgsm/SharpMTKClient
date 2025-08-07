using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.USBAdapter
{
    public enum PortType
    {
        Modem,
        COM_LPT,
        Both
    }

    public partial struct ItypePort
    {
        public string COM;
        public string Name;
        public string PID;
        public string VID;
        public string GUID;
        public PortType Type;
    }

    static class SerialPortUpdate
    {
        public static List<ItypePort> ListOfComPort = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static void UpdatePorts()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}