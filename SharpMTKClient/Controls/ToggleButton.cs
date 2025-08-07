using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SharpMTKClient.Control
{
    class ToggleButton : CheckBox
    {
        public ToggleButton()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;
        //Properties
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }

            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }

        public Color OnToggleColor
        {
            get
            {
                return onToggleColor;
            }

            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }

        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }

            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }

        public Color OffToggleColor
        {
            get
            {
                return offToggleColor;
            }

            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
            }
        }

        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }

            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}