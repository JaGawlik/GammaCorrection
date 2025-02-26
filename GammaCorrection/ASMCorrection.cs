using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GammaCorrection
{
    public class ASMCorrection
    {
        private float[] pixel;
        private int gamma;
        public ASMCorrection(float[] _pixel, int _gamma) 
        { 
            pixel = _pixel;
            gamma = _gamma;
        }

        [DllImport(@"E:\szkola\rok3\JA\KorekcjaGamma\GammaCorrection\x64\Debug\GammaCorrectionAsembler.dll")]
        //static extern int MyProc1(int a, int b);

        static extern int GammaCorrectionCode(float[] pixel, int gamma);

        public void GammaCorr(float[] pixel)
        {
            GammaCorrectionCode(pixel, gamma);
        }

    }
}
