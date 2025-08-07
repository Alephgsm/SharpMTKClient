using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Controls
{
    public interface IMaterialControl
    {
        int Depth { get; set; }

        MaterialSkinManager SkinManager { get; }

        MouseState MouseState { get; set; }
    }

    public enum MouseState
    {
        HOVER,
        DOWN,
        OUT
    }
}