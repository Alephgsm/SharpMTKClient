using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SharpMTKClient.Control
{
    public class HintTextBox : TextBox
    {
        private const int EM_SETCUEBANNER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        private string _hint;
        public string PlaceholderText
        {
            get
            {
                return _hint;
            }

            set
            {
                _hint = value;
                UpdateHint();
            }
        }

        private void UpdateHint()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}