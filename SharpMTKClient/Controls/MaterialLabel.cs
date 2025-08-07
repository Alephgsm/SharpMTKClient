using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMTKClient.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void OnCreateControl()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}