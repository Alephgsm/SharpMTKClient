using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpMTKClient.Properties;

namespace SharpMTKClient.Controls
{
    public class MaterialSkinManager
    {
        //Singleton instance
        private static MaterialSkinManager _instance = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        //Theme
        private Themes _theme;
        public Themes Theme
        {
            get
            {
                return _theme;
            }

            set
            {
                _theme = value;
                UpdateBackgrounds();
            }
        }

        private ColorScheme _colorScheme;
        public ColorScheme ColorScheme
        {
            get
            {
                return _colorScheme;
            }

            set
            {
                _colorScheme = value;
                UpdateBackgrounds();
            }
        }

        public enum Themes : byte
        {
            LIGHT,
            DARK
        }

        //Constant color values
        private static readonly Color PRIMARY_TEXT_BLACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush PRIMARY_TEXT_BLACK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static Color SECONDARY_TEXT_BLACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static Brush SECONDARY_TEXT_BLACK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color DISABLED_OR_HINT_TEXT_BLACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush DISABLED_OR_HINT_TEXT_BLACK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color DIVIDERS_BLACK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush DIVIDERS_BLACK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color PRIMARY_TEXT_WHITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush PRIMARY_TEXT_WHITE_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static Color SECONDARY_TEXT_WHITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static Brush SECONDARY_TEXT_WHITE_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color DISABLED_OR_HINT_TEXT_WHITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush DISABLED_OR_HINT_TEXT_WHITE_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color DIVIDERS_WHITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush DIVIDERS_WHITE_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // Checkbox colors
        private static readonly Color CHECKBOX_OFF_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush CHECKBOX_OFF_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color CHECKBOX_OFF_DISABLED_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush CHECKBOX_OFF_DISABLED_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color CHECKBOX_OFF_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush CHECKBOX_OFF_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color CHECKBOX_OFF_DISABLED_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush CHECKBOX_OFF_DISABLED_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        //Raised button
        private static readonly Color RAISED_BUTTON_BACKGROUND = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush RAISED_BUTTON_BACKGROUND_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color RAISED_BUTTON_TEXT_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush RAISED_BUTTON_TEXT_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color RAISED_BUTTON_TEXT_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush RAISED_BUTTON_TEXT_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        //Flat button
        private static readonly Color FLAT_BUTTON_BACKGROUND_HOVER_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush FLAT_BUTTON_BACKGROUND_HOVER_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color FLAT_BUTTON_DISABLEDTEXT_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush FLAT_BUTTON_DISABLEDTEXT_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color FLAT_BUTTON_BACKGROUND_HOVER_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush FLAT_BUTTON_BACKGROUND_HOVER_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color FLAT_BUTTON_BACKGROUND_PRESSED_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush FLAT_BUTTON_BACKGROUND_PRESSED_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color FLAT_BUTTON_DISABLEDTEXT_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush FLAT_BUTTON_DISABLEDTEXT_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        //ContextMenuStrip
        private static readonly Color CMS_BACKGROUND_LIGHT_HOVER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush CMS_BACKGROUND_HOVER_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color CMS_BACKGROUND_DARK_HOVER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Brush CMS_BACKGROUND_HOVER_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        //Application background
        private static readonly Color BACKGROUND_LIGHT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Brush BACKGROUND_LIGHT_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static readonly Color BACKGROUND_DARK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Brush BACKGROUND_DARK_BRUSH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        //Application action bar
        public readonly Color ACTION_BAR_TEXT = Color.FromArgb(255, 255, 255, 255);
        public readonly Brush ACTION_BAR_TEXT_BRUSH = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
        public readonly Color ACTION_BAR_TEXT_SECONDARY = Color.FromArgb(153, 255, 255, 255);
        public readonly Brush ACTION_BAR_TEXT_SECONDARY_BRUSH = new SolidBrush(Color.FromArgb(153, 255, 255, 255));
        public Color GetPrimaryTextColor()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Brush GetRaisedButtonBackgroundBrush()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Brush GetRaisedButtonTextBrush(bool primary)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Color GetCheckBoxOffDisabledColor()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Brush GetDisabledOrHintBrush()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Color GetApplicationBackgroundColor()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Color GetCheckboxOffColor()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Brush GetPrimaryTextBrush()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //Roboto font
        public Font ROBOTO_MEDIUM_12;
        public Font ROBOTO_REGULAR_11;
        public Font ROBOTO_REGULAR_9;
        public Font ROBOTO_MEDIUM_11;
        public Font ROBOTO_MEDIUM_10;
        public Font ROBOTO_MEDIUM_9;
        //Other constants
        public int FORM_PADDING = 14;
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pvd, [In] ref uint pcFonts)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        private MaterialSkinManager()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static MaterialSkinManager Instance
        {
            get
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            set
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        => _instance ?? (_instance = new MaterialSkinManager());

        private readonly PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        private FontFamily LoadFont(byte[] fontResource)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void UpdateBackgrounds()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void UpdateControl(System.Windows.Forms.Control controlToUpdate, Color newBackColor)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}