using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SharpMTKClient.Controls
{
    public class DropShadow
    {
#region Shadowing
#region Fields
        private bool _isAeroEnabled = false;
        private bool _isDraggingEnabled = false;
        private const int WM_NCHITTEST = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WS_MINIMIZEBOX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HTCLIENT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HTCAPTION = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CS_DBLCLKS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CS_DROPSHADOW = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_NCPAINT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_ACTIVATEAPP = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
#endregion
#region Structures
        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

#endregion
#region Methods
#region Public
        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool IsCompositionEnabled()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Private
        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        private bool CheckIfAeroIsEnabled()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Overrides
        public void ApplyShadows(Form form)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
#endregion
#endregion
    }
}