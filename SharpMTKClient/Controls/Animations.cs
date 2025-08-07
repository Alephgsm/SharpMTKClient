using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Controls
{
    enum AnimationType
    {
        Linear,
        EaseInOut,
        EaseOut,
        CustomQuadratic
    }

    enum AnimationDirection
    {
        In, //In. Stops if finished.
        Out, //Out. Stops if finished.
        InOutIn, //Same as In, but changes to InOutOut if finished.
        InOutOut, //Same as Out.
        InOutRepeatingIn, // Same as In, but changes to InOutRepeatingOut if finished.
        InOutRepeatingOut // Same as Out, but changes to InOutRepeatingIn if finished.
    }

    static class AnimationLinear
    {
        public static double CalculateProgress(double progress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    static class AnimationEaseInOut
    {
        public static double PI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static double PI_HALF = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static double CalculateProgress(double progress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static double EaseInOut(double s)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    public static class AnimationEaseOut
    {
        public static double CalculateProgress(double progress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    public static class AnimationCustomQuadratic
    {
        public static double CalculateProgress(double progress)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}