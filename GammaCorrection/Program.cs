using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GammaCorrection
{
    internal static class Program
    {
        /// <summary>
        /// the main entry point for the application.
        /// </summary>
        [STAThread]

        //[DllImport(@"E:\szkola\rok3\JA\KorekcjaGamma\GammaCorrection\x64\Debug\GammaCorrectionAsembler.dll")]
        //static extern int GammaCorrectionCode(int a, int b);
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
