using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMTKClient.Controls
{
    public enum SubTab
    {
        main,
        sub
    }

    public class MaterialTabSelector : System.Windows.Forms.Control, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private MaterialTabControl _baseTabControl;
        public MaterialTabControl BaseTabControl
        {
            get
            {
                return _baseTabControl;
            }

            set
            {
                _baseTabControl = value;
                if (_baseTabControl == null)
                    return;
                _previousSelectedTabIndex = _baseTabControl.SelectedIndex;
                _baseTabControl.Deselected += (sender, args) =>
                {
                    _previousSelectedTabIndex = _baseTabControl.SelectedIndex;
                };
                _baseTabControl.SelectedIndexChanged += (sender, args) =>
                {
                    _animationManager.SetProgress(0);
                    _animationManager.StartNewAnimation(AnimationDirection.In);
                };
                _baseTabControl.ControlAdded += delegate
                {
                    Invalidate();
                };
                _baseTabControl.ControlRemoved += delegate
                {
                    Invalidate();
                };
            }
        }

        private int _previousSelectedTabIndex;
        private Point _animationSource;
        private readonly AnimationManager _animationManager;
        private List<Rectangle> _tabRects;
        private const int TAB_HEADER_PADDING = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int TAB_INDICATOR_HEIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private Color _color = ((int)Primary.Blue900).ToColor();
        private SubTab _subt;
        public SubTab SubTab
        {
            get
            {
                return _subt;
            }

            set
            {
                if (value == SubTab.main)
                {
                    _color = ((int)Primary.Teal900).ToColor();
                }
                else
                {
                    _color = ((int)Primary.Teal800).ToColor();
                }

                this.Invalidate();
                _subt = value;
            }
        }

        public MaterialTabSelector()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int CalculateTextAlpha(int tabIndex, double animationProgress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void UpdateTabRects()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}