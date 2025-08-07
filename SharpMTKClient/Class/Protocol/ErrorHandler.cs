using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek
{
    public static class ErrorHandler
    {
        public static Dictionary<uint, string> ErrorCodes = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static Dictionary<uint, string> ErrorCodes_XFlash = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static Dictionary<uint, string> ErrorCodes_Legacy = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static string GetStatusMessage(uint status)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}